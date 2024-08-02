namespace AwsS3LambdaMessagingConnector.Services
{
    public interface IKafkaService
    {
        Task<string> PublishAsync(string topic, string data);
    }
}
