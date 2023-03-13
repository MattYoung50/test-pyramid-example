using TestPyramidExample;

namespace IntegrationTests
{
    public class IntegrationTests
    {
        [Test]
        public void GivenTestPyramidExampleStarts_WhenAKeyOtherThanEnterIsPressed_AUdpPacketWithAMessagGoesOut()
        {
            // Given
            var fakeDependencies = new FakeTestPyramidExampleAppDependencies();
            var app = new TestPyramidExampleApp(fakeDependencies);

            // When
            var keyReader = (FakeKeyReader)fakeDependencies.KeyReader;
            keyReader.InjectKeyPress(ConsoleKey.Home);

            // Then
            var udpSocket = fakeDependencies.FakeUdpSocket;
            Assert.That(udpSocket.PacketsSent.Count, Is.EqualTo(1));
            Assert.That(udpSocket.PacketsSent[0], Is.EqualTo("03/13/2023 12:36:40: Hello! This is packet number 0"));
        }
    }
}