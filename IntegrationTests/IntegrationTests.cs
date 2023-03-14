using TestPyramidExample;

namespace IntegrationTests
{
    public class IntegrationTests
    {
        [Test]
        public void GivenTestPyramidExampleStarts_WhenAKeyOtherThanEnterIsPressed_AUdpPacketWithAMessageGoesOut()
        {
            // Given
            var fakeDependencies = new FakeTestPyramidExampleAppDependencies();
            var app = new TestPyramidExampleApp(fakeDependencies);

            // When
            var consoleReader = fakeDependencies.FakeConsoleReader;
            consoleReader.InjectLine("Hello");
            consoleReader.InjectLine("World");
            consoleReader.InjectLine("!");

            // Then
            var udpSocket = fakeDependencies.FakeUdpSocket;
            Assert.That(udpSocket.PacketsSent.Count, Is.EqualTo(3));
            Assert.That(udpSocket.PacketsSent[0], Is.EqualTo("03/13/2023 12:36:40: Hello! This is packet number 0"));
            Assert.That(udpSocket.PacketsSent[1], Is.EqualTo("03/13/2023 12:36:40: Hello! This is packet number 1"));
            Assert.That(udpSocket.PacketsSent[2], Is.EqualTo("03/13/2023 12:36:40: Hello! This is packet number 2"));
        }

        [Test]
        public void GivenTestPyramidExampleStarts_WhenEnterIsPressed_TheAppClosesWithExitCode0()
        {
            // Given
            var fakeDependencies = new FakeTestPyramidExampleAppDependencies();
            var app = new TestPyramidExampleApp(fakeDependencies);

            // When
            var keyReader = fakeDependencies.FakeConsoleReader;
            keyReader.InjectLine(string.Empty);

            // Then
            var udpSocket = fakeDependencies.FakeUdpSocket;
            var environmentProvider = fakeDependencies.FakeEnvironmentProvider;
            Assert.That(udpSocket.PacketsSent.Count, Is.EqualTo(0));
            Assert.That(environmentProvider.GetExitCode(), Is.EqualTo(0));
        }
    }
}