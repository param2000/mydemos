Imports System.IO
Imports Castle.Facilities.FactorySupport
Imports MassTransit.ServiceBus
Imports Castle.Facilities.Startable
Imports MassTransit.WindsorIntegration
Imports Castle.Windsor
Imports Messages

Module Program

    Sub Main()
        log4net.Config.XmlConfigurator.Configure(New FileInfo(".\log4net.config"))


        Console.WriteLine("Subscriber")
        Dim wc As New WindsorContainer(".\sub.castle.xml")
        wc.AddFacility("masstransit", New MassTransitFacility())
        wc.AddFacility("factory", New FactorySupportFacility)
        wc.AddFacility("startable", New StartableFacility)

        Dim bus As IServiceBus = wc.Resolve(Of IServiceBus)()
        wc.AddComponent(Of MessageConsumer)()
        bus.AddComponent(Of MessageConsumer)()


        Console.WriteLine("Press any key to exit.")
        Console.ReadKey(True)

        bus.Dispose()
        wc.Dispose()

    End Sub

End Module

Public Class MessageConsumer
    Implements Consumes(Of PingMessage).All
    Private _serviceBus As IServiceBus

    Public Sub New(ByVal bus As IServiceBus)
        _serviceBus = bus

    End Sub

    Public Sub Consume(ByVal message As Messages.PingMessage) Implements MassTransit.ServiceBus.Consumes(Of Messages.PingMessage).All.Consume


        Console.WriteLine("I got Ping Message" + message.Name)

        Dim anotherMessage As New PongMessage

        anotherMessage.ResponseText = message.Name + DateTime.Now.ToString
        _serviceBus.Publish(anotherMessage)
    End Sub
End Class