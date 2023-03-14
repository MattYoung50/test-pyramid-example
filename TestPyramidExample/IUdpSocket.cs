using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPyramidExample
{
    public interface IUdpSocket
    {
        event EventHandler<string> PacketReceived;
        void Send(string message);
    }
}
