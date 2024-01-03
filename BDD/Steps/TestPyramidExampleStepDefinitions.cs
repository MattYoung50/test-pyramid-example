using FluentAssertions;
using TechTalk.SpecFlow;
using TestPyramidExample;
using IntegrationTests;
using NUnit.Framework;

namespace BDD
{
    [Binding]
    public class TestPyramidExampleStepDefinitions
    {
        private FakeTestPyramidExampleAppDependencies _fakeDependencies;
        private TestPyramidExampleApp _testPyramidExample;
        public TestPyramidExampleStepDefinitions() { }

        [Given("the app starts")]
        public void GivenTheAppStarts()
        {
            _fakeDependencies = new FakeTestPyramidExampleAppDependencies();
            _testPyramidExample = new TestPyramidExampleApp(_fakeDependencies);
        }

        [When("the (.*) key is pressed")]
        public void WhenTheKeyIsPressed(string key)
        {
            var consoleReader = _fakeDependencies.FakeConsoleReader;
            consoleReader.InjectLine(key);
        }

        [Then("(.*) udp packet(s) get sent out")]
        public void ThenUdpPacketsGetSentOut(int numPackets)
        {
            var udpSocket = _fakeDependencies.FakeUdpSocket;
            Assert.That(udpSocket.PacketsSent.Count, Is.EqualTo(numPackets));
            foreach(var packet in udpSocket.PacketsSent)
            {
                Assert.That(udpSocket.PacketsSent[numPackets-1], Is.EqualTo($"03/13/2023 12:36:40: Hello! This is packet number {numPackets-1}"));
            }
            
        }
    }
}