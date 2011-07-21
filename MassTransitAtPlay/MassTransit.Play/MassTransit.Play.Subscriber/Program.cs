using System;
using Castle.MicroKernel.Registration;
using MassTransit.Play.Subscriber.Consumers;
using MassTransit.Transports.Msmq;
using MassTransit.WindsorIntegration;

namespace MassTransit.Play.Subscriber
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Starting Subscriber, hit return to quit");

            MsmqEndpointConfigurator.Defaults(config =>
                {
                    config.CreateMissingQueues = true;
                });

            var container = new DefaultMassTransitContainer("windsor.xml")
                .Register(
                    Component.For<NewCustomerMessageConsumer>().LifeStyle.Transient
                );

            var bus = container.Resolve<IServiceBus>();
            var consumer = container.Resolve<NewCustomerMessageConsumer>();
            consumer.Start(bus);

            Console.ReadLine();
            Console.WriteLine("Stopping Subscriber");
            consumer.Stop();
            container.Dispose();
        }
    }
}
