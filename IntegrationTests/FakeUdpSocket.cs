using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPyramidExample;

namespace IntegrationTests
{
    public class FakeUdpSocket : IUdpSocket
    {
        public List<string> PacketsSent = new List<string>();
        public void Send(string message)
        {
            PacketsSent.Add(message);
        }
    }
}
