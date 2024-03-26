//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

        IPAddress broadcast = IPAddress.Parse("192.168.0.102");
        Console.WriteLine("Enter message to sent the broadcast address");
        var message = Console.ReadLine();

        while (message != string.Empty)
        {
            byte[] sendbuf = Encoding.ASCII.GetBytes(message);
            IPEndPoint ep = new IPEndPoint(broadcast, 11000);
            s.SendTo(sendbuf, ep);

            Console.WriteLine("Message sent to the broadcast address");

            message = Console.ReadLine();
        }

        Console.ReadLine();
    }
}