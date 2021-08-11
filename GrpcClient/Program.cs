using Grpc.Net.Client;
using Proto.GrpcHelloWorldServer;
using System;
using System.Threading.Tasks;

namespace GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var grpcChannel = GrpcChannel.ForAddress("https://localhost:5001");
            var grpcClient = new Greeter.GreeterClient(grpcChannel);
            var reply = await grpcClient.SayHelloAsync (new HelloRequest { Name = "Akshay", LastName = "Patel" });
            Console.WriteLine(reply.Message);
            Console.ReadKey();
        }
    }
}
