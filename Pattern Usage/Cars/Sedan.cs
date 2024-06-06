using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Pattern_Usage
{
    internal class Sedan : Car
    {
        private Sedan() : base() { }
        internal Sedan(Color color) : base(color) { }
    }
}
