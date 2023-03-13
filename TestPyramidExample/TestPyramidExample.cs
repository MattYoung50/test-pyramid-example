using System.Net;
namespace example
{
    public class TestPyramidExample
    {
        public void Run()
        {
            Console.WriteLine("Press any key to send a packet. Press Enter to exit.");
            int packetCounter = 0;
            var key = Console.ReadKey();
            var localIp = IPAddress.Parse("127.0.0.1");
            var destinationIp = IPAddress.Parse("127.0.0.1");
            var destinationPort = 12345;
            var udpSocket = new UdpSocket(localIp, destinationIp, destinationPort);
            while(key.Key != ConsoleKey.Enter)
            {
                udpSocket.Send($"Hello! This is packet number {packetCounter}");
                Console.WriteLine($"\nSent packet number {packetCounter++}");
                key = Console.ReadKey();
            }
        }
    }
}