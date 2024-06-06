using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Pattern_Usage
{
    internal class Hatchback : Car
    {
        private Hatchback() : base() { }
        internal Hatchback(Color color) : base(color) { }
    }
}
