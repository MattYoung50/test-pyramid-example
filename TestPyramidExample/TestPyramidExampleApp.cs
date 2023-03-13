using System.Net;
namespace TestPyramidExample
{
    public class TestPyramidExampleApp
    {
        private ILogger _logger;
        private IKeyReader _keyReader;
        private IUdpSocket _udpSocket;
        private TimestampProvider _timestampProvider;
        public TestPyramidExampleApp(ITestPyramidExampleAppDependencies dependencies)
        {
            _logger = dependencies.Logger;
            _keyReader = dependencies.KeyReader;
            _udpSocket = dependencies.UdpSocket;
            _timestampProvider = dependencies.TimestampProvider;
        }
        public void Run()
        {
            _logger.WriteLine("Press any key to send a packet. Press Enter to exit.");
            int packetCounter = 0;
            var key = _keyReader.ReadKey();
            while(key != ConsoleKey.Enter)
            {
                _udpSocket.Send($"{_timestampProvider.GetTimestamp()}: Hello! This is packet number {packetCounter}");
                _logger.WriteLine($"\n{ _timestampProvider.GetTimestamp()}: Sent packet number {packetCounter++}");
                key = _keyReader.ReadKey();
            }
        }
    }
}