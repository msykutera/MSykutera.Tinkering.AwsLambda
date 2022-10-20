using Amazon.Lambda.Core;
using Amazon.Lambda.RuntimeSupport;
using Amazon.Lambda.Serialization.SystemTextJson;
using MSykutera.Tinkering.AwsLambda.Services;

var fibonacciSequenceService = new FibonacciSequenceService();

var handler = (int n, ILambdaContext context) => fibonacciSequenceService.CalculateFibonacciNumber(n);

await LambdaBootstrapBuilder.Create(handler, new DefaultLambdaJsonSerializer())
        .Build()
        .RunAsync();