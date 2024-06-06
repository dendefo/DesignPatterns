using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Pattern_Usage
{
    internal class Coupe : Car
    {
        private Coupe() : base() { }
        internal Coupe(Color color) : base(color) { }
    }
}
