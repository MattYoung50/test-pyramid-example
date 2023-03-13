using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPyramidExample
{
    public class EnvironmentProvider : IEnvironmentProvider
    {
        public void Exit(int exitCode)
        {
            Environment.Exit(exitCode);
        }
    }
}
