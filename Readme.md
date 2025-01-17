# Aws S3 Lambda Messaging Function Project

This project consists of:
* Function.cs - class file containing a class with a listener of AWS S3 bucket events
* Services folder with injected Kafka publisher service
* aws-lambda-tools-defaults.json - custom argument settings for use with Visual Studio and command line deployment tools for AWS

The generated function handler responds to events on an Amazon S3 bucket. The handler receives the bucket and object key details in an S3Event instance and returns the content type of the object as the function output. Replace the body of this method, and parameters, to suit your needs.

After deploying your function you must configure an Amazon S3 bucket as an event source to trigger your Lambda function.

The sample of from AWS portal:

![image](https://github.com/user-attachments/assets/4c38a520-34a0-4b05-afec-e81e6a967a25)


## Here are some steps to follow from Visual Studio:

To deploy your function to AWS Lambda, right click the project in Solution Explorer and select *Publish to AWS Lambda*.

To view your deployed function open its Function View window by double-clicking the function name shown beneath the AWS Lambda node in the AWS Explorer tree.

To perform testing against your deployed function use the Test Invoke tab in the opened Function View window.

To configure event sources for your deployed function, for example to have your function invoked when an object is created in an Amazon S3 bucket, use the Event Sources tab in the opened Function View window.

To update the runtime configuration of your deployed function use the Configuration tab in the opened Function View window.

To view execution logs of invocations of your function use the Logs tab in the opened Function View window.

## Here are some steps to follow to get started from the command line:

Once you have edited your template and code you can deploy your application using the [Amazon.Lambda.Tools Global Tool](https://github.com/aws/aws-extensions-for-dotnet-cli#aws-lambda-amazonlambdatools) from the command line.

Install Amazon.Lambda.Tools Global Tools if not already installed.
```
    dotnet tool install -g Amazon.Lambda.Tools
```

If already installed check if new version is available.
```
    dotnet tool update -g Amazon.Lambda.Tools
```

Execute unit tests
```
    cd "AwsS3LambdaMessagingConnector/test/KafkaS3ConnectAWSLambda.Tests"
    dotnet test
```

Deploy function to AWS Lambda
```
    cd "AwsS3LambdaMessagingConnector/src/AwsS3LambdaMessagingConnector"
    dotnet lambda deploy-function
```

## Here are some steps to follow to get it worked from S3 buket and Confluent Topic consumer:

To upload files into watching bucket using ether Visual Studio AWS explorer or Amazon AWS S3 explorer:

![image](https://github.com/user-attachments/assets/45c81390-a60b-48d0-b757-58eb5d43511a)

and to watch coming messages into Kafka topics

![image](https://github.com/user-attachments/assets/788b9754-8eb8-403e-ba9f-0706839d586a)

