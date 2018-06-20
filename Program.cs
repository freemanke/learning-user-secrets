using System;
using Microsoft.Extensions.Configuration;

namespace learning_user_secrets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var builder = new ConfigurationBuilder();
            builder.AddUserSecrets<Program>();

            var configuration = builder.Build();
            Console.WriteLine(configuration["ConnectionString"]);
            Console.Read();
        }
    }
}
