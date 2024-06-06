using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.Builder
{
    internal interface IBuilder<TProduct,TAArgument,TBArgument>
    {
        public void BuildPartA(TAArgument argument);
        public void BuildPartB(TBArgument argument);
        public TProduct GetProduct();
    }
}
