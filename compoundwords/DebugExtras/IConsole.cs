using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis.DebugExtras
{
    interface IConsole
    {
        void Write(string m = "");
        void WriteLine(string m = "");

        string ReadLine();
    }
}
