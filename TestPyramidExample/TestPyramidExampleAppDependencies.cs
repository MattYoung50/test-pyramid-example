using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestPyramidExample
{
    public class TestPyramidExampleAppDependencies : ITestPyramidExampleAppDependencies
    {
        public ILogger Logger { get; } = new ConsoleLogger();
        public IKeyReader KeyReader { get; } = new ConsoleKeyReader();
        public IUdpSocket UdpSocket { get; }
        public TimestampProvider TimestampProvider { get; }
        public TestPyramidExampleAppDependencies()
        {
            var localIp = IPAddress.Parse("127.0.0.1");
            var destinationIp = IPAddress.Parse("127.0.0.1");
            var destinationPort = 12345;
            UdpSocket = new UdpSocket(localIp, destinationIp, destinationPort);
            TimestampProvider = new TimestampProvider(new TimeProvider());
        }
    }
}
