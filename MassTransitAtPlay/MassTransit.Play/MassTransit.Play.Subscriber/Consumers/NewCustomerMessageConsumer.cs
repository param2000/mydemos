using System;
using MassTransit.Internal;
using MassTransit.Play.Messages;

namespace MassTransit.Play.Subscriber.Consumers
{
    public class NewCustomerMessageConsumer : Consumes<NewCustomerMessage>.All, IBusService
    {
        private IServiceBus bus;
        private UnsubscribeAction unsubscribeAction;

        public void Consume(NewCustomerMessage message)
        {
            Console.WriteLine(string.Format("Received a NewCustomerMessage with Name : '{0}'", message.Name));
        }

        public void Dispose()
        {
            bus.Dispose();
        }

        public void Start(IServiceBus bus)
        {
            this.bus = bus;
            unsubscribeAction = bus.Subscribe(this);
        }

        public void Stop()
        {
            unsubscribeAction();
        }
    }
}