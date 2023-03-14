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
        public IConsoleReader ConsoleReader => FakeConsoleReader;
        public FakeConsoleReader FakeConsoleReader { get; } = new FakeConsoleReader();  
        public IUdpSocket UdpSocket => FakeUdpSocket;
        public FakeUdpSocket FakeUdpSocket { get; } = new FakeUdpSocket();
        public IEnvironmentProvider EnvironmentProvider => FakeEnvironmentProvider;
        public FakeEnvironmentProvider FakeEnvironmentProvider { get; } = new FakeEnvironmentProvider();
        public TimestampProvider TimestampProvider { get; } = new TimestampProvider(new FakeTimeProvider(13, 3, 2023, 12, 36, 40));
    }
}
