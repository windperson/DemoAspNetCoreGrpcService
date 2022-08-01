using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcGreeterClient;

namespace DemoGrpcClientConsoleApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Press Enter to start Grpc Greeter Client...");
            Console.ReadLine();
            using var channel = GrpcChannel.ForAddress("https://localhost:7119");
            var client = new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(new HelloRequest() { Name = "GreeterClient" });
            Console.WriteLine("Greeting: " + reply.Message);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}