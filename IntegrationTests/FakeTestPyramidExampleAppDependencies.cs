using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPyramidExample;

namespace IntegrationTests
{
    public class FakeTestPyramidExampleAppDependencies : ITestPyramidExampleAppDependencies
    {
        public ILogger Logger => FakeLogger;
        public FakeLogger FakeLogger { get; } = new FakeLogger();
        public IKeyReader KeyReader => FakeKeyReader;
        public FakeKeyReader FakeKeyReader { get; } = new FakeKeyReader();  
        public IUdpSocket UdpSocket => FakeUdpSocket;
        public FakeUdpSocket FakeUdpSocket { get; } = new FakeUdpSocket();
        public TimestampProvider TimestampProvider { get; } = new TimestampProvider(new FakeTimeProvider(13, 3, 2023, 12, 36, 40));
    }
}
