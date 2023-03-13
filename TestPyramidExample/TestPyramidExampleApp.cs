using System.Net;
namespace TestPyramidExample
{
    public class TestPyramidExampleApp
    {
        private ILogger _logger;
        private IKeyReader _keyReader;
        private IUdpSocket _udpSocket;
        private IEnvironmentProvider _environmentProvider;
        private TimestampProvider _timestampProvider;
        private int _packetCounter;
        public TestPyramidExampleApp(ITestPyramidExampleAppDependencies dependencies)
        {
            _logger = dependencies.Logger;
            _logger.WriteLine("Press any key to send a packet. Press Enter to exit.");
            _keyReader = dependencies.KeyReader;
            _keyReader.KeyPressed += (sender, keyPressed) => HandleKeyPress(keyPressed);
            _udpSocket = dependencies.UdpSocket;
            _environmentProvider = dependencies.EnvironmentProvider;
            _timestampProvider = dependencies.TimestampProvider;
        }
        private void HandleKeyPress(ConsoleKey keyPressed)
        {
            if (keyPressed == ConsoleKey.Enter)
            {
                _environmentProvider.Exit(0);
            }
            else
            {
                _udpSocket.Send($"{_timestampProvider.GetTimestamp()}: Hello! This is packet number {_packetCounter}");
                _logger.WriteLine($"\n{_timestampProvider.GetTimestamp()}: Sent packet number {_packetCounter++}");
            }
        }
    }
}