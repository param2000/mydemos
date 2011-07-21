using System;
using MassTransit.Play.Messages;
using MassTransit.Transports.Msmq;
using MassTransit.WindsorIntegration;

namespace MassTransit.Play.Publisher
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Starting Publisher");

            MsmqEndpointConfigurator.Defaults(config =>
            {
                config.CreateMissingQueues = true;
            });

            var container = new DefaultMassTransitContainer("windsor.xml");
            var bus = container.Resolve<IServiceBus>();

            string name;
            while((name = GetName()) != "q")
            {
                var message = new NewCustomerMessage {Name = name};
                bus.Publish(message);
                
                Console.WriteLine("Published NewCustomerMessage with name {0}", message.Name);
            }

            Console.WriteLine("Stopping Publisher");
            container.Release(bus);
            container.Dispose();
        }

        private static string GetName()
        {
            Console.WriteLine("Enter a name to publish (q to quit)");
            return Console.ReadLine();
        }
    }
}
