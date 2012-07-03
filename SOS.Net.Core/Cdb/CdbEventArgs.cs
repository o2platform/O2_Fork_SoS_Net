using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOS.Net.Core
{
    public class CdbEventArgs : EventArgs
    {
        public string Output { get; private set; }

        public string Intput { get; private set; }

        public CdbEventArgs(string input, string output)
        {
            this.Output = output;
            this.Intput = input;
        }
    }
}
