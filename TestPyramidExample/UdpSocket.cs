using System.Text;
using System.Net;
using System.Net.Sockets;

namespace TestPyramidExample
{
    public class UdpSocket : IUdpSocket
    {
        private UdpClient client;
        public event EventHandler<string>? PacketReceived;
        public UdpSocket(IPAddress localIp, int localPort, IPAddress destinationIp, int destinationPort)
        {
            var localEndpoint = new IPEndPoint(localIp, localPort);
            client = new UdpClient(localEndpoint);
            client.Connect(destinationIp, destinationPort);
            Task.Run(() =>
            {
                var endpoint = new IPEndPoint(IPAddress.Any, 0);
                var receivedPacket = client.Receive(ref endpoint);
                PacketReceived?.Invoke(this, Encoding.ASCII.GetString(receivedPacket));
            });
        }
        public void Send(string message)
        {
            client.Send(Encoding.ASCII.GetBytes(message));
        }
    }
}