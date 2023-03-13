using System.Text;
using System.Net;
using System.Net.Sockets;
namespace TestPyramidExample
{
    public class UdpSocket : IUdpSocket
    {
        private UdpClient client;
        public UdpSocket(IPAddress localIp, IPAddress destinationIp, int destinationPort)
        {
            var localEndpoint = new IPEndPoint(localIp, 0);
            client = new UdpClient(localEndpoint);
            client.Connect(destinationIp, destinationPort);
        }
        public void Send(string message)
        {
            client.Send(Encoding.ASCII.GetBytes(message));
        }
    }
}