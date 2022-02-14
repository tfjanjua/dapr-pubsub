using System;
using System.Net.Http;
using System.Text;

namespace pub
{
    class Program
    {
        static readonly HttpClient client = new HttpClient();
        static readonly string daprPort = Environment.GetEnvironmentVariable("DAPR_HTTP_PORT");
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                var data = $"{{\"key\": {i}}}";
                Console.WriteLine($"Sending {data}");
                var content = new StringContent(data, UnicodeEncoding.UTF8, "application/json");
                var response = client.PostAsync($"http://localhost:{daprPort}/v1.0/publish/pubsub/mytopic", content).Result;
            }
        }
    }
}