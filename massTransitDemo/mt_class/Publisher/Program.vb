Imports System.IO
Imports Castle.Facilities.FactorySupport
Imports MassTransit.ServiceBus.Internal
Imports MassTransit.ServiceBus.MSMQ
Imports Castle.Windsor
Imports MassTransit.WindsorIntegration
Imports Castle.Facilities.Startable
Imports MassTransit.ServiceBus
Imports Messages

Module Program

    Sub Main()
        log4net.Config.XmlConfigurator.Configure(New FileInfo(".\log4net.config"))

        Console.WriteLine("Publisher")

        Dim wc As New WindsorContainer(".\pub.castle.xml")
        wc.AddFacility("masstransit", New MassTransitFacility())
        wc.AddFacility("factory", New FactorySupportFacility)
        wc.AddFacility("startable", New StartableFacility)

        Dim bus As IServiceBus = wc.Resolve(Of IServiceBus)()
        wc.AddComponent(Of AnotherConsumer)()
        bus.AddComponent(Of AnotherConsumer)()


        Console.WriteLine("Press 's' to publish a message")

        Console.WriteLine("Press any key to exit")
        While (Console.ReadKey(True) = New ConsoleKeyInfo("s"c, ConsoleKey.S, False, False, False))
            Dim message As PingMessage = New PingMessage
            bus.Publish(message)
            Console.WriteLine("Published a message")
        End While

        bus.Dispose()
        wc.Dispose()

        Console.WriteLine("Press any key to exit.")
        Console.ReadKey(True)
    End Sub

End Module

Public Class AnotherConsumer
    Implements Consumes(Of PongMessage).All

    Public Sub Consume(ByVal message As Messages.PongMessage) Implements MassTransit.ServiceBus.Consumes(Of Messages.PongMessage).All.Consume
        Console.WriteLine("Consuming PongMessage" + message.ResponseText)
    End Sub
End Class
