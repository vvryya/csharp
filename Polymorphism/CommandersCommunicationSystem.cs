using System;

namespace Polymorphism
{
    public interface ICommunicationModule
    {
        void Send(string message);
        string Receive();
    }

    public class CommunicationToWonderland : ICommunicationModule
    {
        public void Send(string message)
        {
            Console.WriteLine("Opening communication channel to Wonderland");
            Console.WriteLine($"Sending message: {message}");
        }

        public string Receive()
        {
            Console.WriteLine("Opening communication channel to Wonderland");
            var message = Console.ReadLine();

            Console.WriteLine($"Received message: {message}");

            return message;
        }
    }

    public class CommunicationToTeo : ICommunicationModule
    {
        public void Send(string message)
        {
            Console.WriteLine("Opening communication channel to Teo");
            Console.WriteLine($"Sending message: {message}");
        }

        public string Receive()
        {
            Console.WriteLine("Opening communication channel to Teo");
            var message = Console.ReadLine();

            Console.WriteLine($"Received message: {message}");

            return message;
        }
    }

    public class CommandersCommunicationSystem
    {
        public static void Main()
        {
            var communicationToWonderland = new CommunicationToTeo(); // Change this line

            var message = Console.ReadLine();
            SendMessage(communicationToWonderland, message);

            var receivedMessage = ReceiveMessage(communicationToWonderland);
        }

        static string ReceiveMessage(ICommunicationModule communicationModule)
        {
            return communicationModule.Receive();
        }

        static void SendMessage(ICommunicationModule communicationModule, string message)
        {
            communicationModule.Send(message);
        }
    }
}