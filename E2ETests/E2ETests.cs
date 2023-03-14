using NUnit.Framework.Internal;
using System;
using System.Diagnostics;
using System.IO.Pipes;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using TestPyramidExample;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace E2ETests
{
    public class E2ETests
    {
        [Test]
        public void GivenTestPyramidExampleStarts_WhenAKeyOtherThanEnterIsPressed_AUdpPacketWithAMessageGoesOut()
        {
            var receivedMessages = new List<string>();
            ListenForPackets(receivedMessages);
            var inputs = new List<string>() { "abcd" };
            StartTestPyramidExample(inputs);

            WaitForPacketsToArrive();
            
            Assert.That(receivedMessages.Count, Is.EqualTo(1));
            var expectedInMessage = ": Hello! This is packet number 0";
            Assert.True(receivedMessages[0].Contains(expectedInMessage));
        }

        private async void WaitForPacketsToArrive()
        {
             await Task.Delay(50);
        }

        private void ListenForPackets(List<string> receivedMessages)
        {
            var localIp = IPAddress.Parse("127.0.0.1");
            var localPort = 12345;
            var destinationIp = IPAddress.Parse("127.0.0.1");
            var destinationPort = 0;
            var udpSocket = new UdpSocket(localIp, localPort, destinationIp, destinationPort);
            udpSocket.PacketReceived += (sender, message) => receivedMessages.Add(message);
        }

        private void StartTestPyramidExample(List<string> inputs)
        {
            using (var process = new Process())
            {
                var startInfo = new ProcessStartInfo()
                {
                    FileName = "C:\\Users\\Matt\\Documents\\Build\\test-pyramid-example\\TestPyramidExample\\bin\\Debug\\net7.0\\TestPyramidExample.exe",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardInput = true,
                    CreateNoWindow = false
                };
                process.StartInfo = startInfo;
                process.OutputDataReceived += (s, e) =>
                {
                    Console.WriteLine(e.Data);
                    if (e.Data == "Input any text to send a packet. Press Enter with no text to exit.")
                    {
                        foreach(var input in inputs)
                        {
                            process.StandardInput.WriteLine(input);
                        }
                        process.StandardInput.Close();
                    }
                };
                process.Start();
                process.BeginOutputReadLine();
                process.WaitForExit();
            }
        }
    }
}