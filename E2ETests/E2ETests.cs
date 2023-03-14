using NUnit.Framework.Internal;
using System;
using System.Diagnostics;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace E2ETests
{
    public class E2ETests
    {
        [Test]
        public void GivenTestPyramidExampleStarts_WhenAKeyOtherThanEnterIsPressed_AUdpPacketWithAMessageGoesOut()
        {
            var inputs = new List<string>() { "abcd" };
            StartTestPyramidExample(inputs);
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