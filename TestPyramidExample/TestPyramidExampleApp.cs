using System.Net;
namespace TestPyramidExample
{
    public class TestPyramidExampleApp
    {
        private ILogger _logger;
        private IConsoleReader _consoleReader;
        private IUdpSocket _udpSocket;
        private IEnvironmentProvider _environmentProvider;
        private TimestampProvider _timestampProvider;
        private int _packetCounter;
        public TestPyramidExampleApp(ITestPyramidExampleAppDependencies dependencies)
        {
            _logger = dependencies.Logger;
            _logger.WriteLine("Input any text to send a packet. Press Enter with no text to exit.");
            _consoleReader = dependencies.ConsoleReader;
            _consoleReader.ConsoleInputReceived += (sender, line) => HandleConsoleInputReceived(line);
            _udpSocket = dependencies.UdpSocket;
            _environmentProvider = dependencies.EnvironmentProvider;
            _timestampProvider = dependencies.TimestampProvider;
        }
        private void HandleConsoleInputReceived(string? line)
        {
            if (line == null || line.Length == 0)
            {
                _logger.WriteLine("Exit selected. Closing application...");
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