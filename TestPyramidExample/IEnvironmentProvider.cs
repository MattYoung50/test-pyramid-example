using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPyramidExample
{
    public interface IEnvironmentProvider
    {
        void Exit(int exitCode);
    }
}
