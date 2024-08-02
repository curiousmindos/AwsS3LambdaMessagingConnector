using Confluent.Kafka;

namespace AwsS3LambdaMessagingConnector.Services;

/// <summary>
/// KafkaService class with Publish interface implementation.
/// </summary>
public class KafkaService : IKafkaService
{
    private readonly ProducerConfig _producerConfig;

    /// <summary>
    /// KafkaService.
    /// </summary>
    public KafkaService()
    {
        _producerConfig = new ProducerConfig
        {
            // confluent.cloud
            BootstrapServers = Environment.GetEnvironmentVariable("kafka_bootstrap"),
            SecurityProtocol = SecurityProtocol.SaslSsl,
            SaslMechanism = SaslMechanism.Plain,
            SaslUsername = Environment.GetEnvironmentVariable("kafka_SaslUsername"),
            SaslPassword = Environment.GetEnvironmentVariable("kafka_SaslPassword")
        };
    }

    /// <summary>
    /// PublishAsync function.
    /// </summary>
    /// <param name="topic">topic name.</param>
    /// <param name="data">message content.</param>
    /// <returns></returns>
    public async Task<string> PublishAsync(string topic, string data)
    {
        using var producer = new ProducerBuilder<Null, string>(_producerConfig).Build();

        var result = await producer.ProduceAsync(topic, new Message<Null, string> { Value = data });

        return result.Value;
    }
}
