using System;
using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Recovery.Provider.Api;

public class HelloFunction
{
  [Function("hello_kafka")]
  public async Task HelloKafka(
    [KafkaTrigger(
      "localhost:9092",
      "hello",
      ConsumerGroup = "hello"
    )]
    string input)
  {
    Console.WriteLine(input);
    await Task.CompletedTask;
  }
}
