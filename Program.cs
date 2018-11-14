using System;
using System.IO;
using Akka.Actor;
using Akka.Configuration;

namespace AkkaCluster
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Console.WriteLine("Hello World!");
            var config = ConfigurationFactory.ParseString(File.ReadAllText("config.hocon"));

            ActorSystem actorSystem = ActorSystem.Create("akkacommerce",config);

            Console.CancelKeyPress += (sender, eventArgs) => { };

            actorSystem.WhenTerminated.Wait();

        }
    }
}
