using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.Abstract_Factory
{
    /// <summary>
    /// A factory interface that creates products of type TProduct with settings of type TSettings
    /// </summary>
    /// <typeparam name="TProduct"></typeparam>
    /// <typeparam name="TSettings"></typeparam>
    internal interface IFactory<TProduct, TSettings>
    {
        public TProduct CreateProduct(TSettings settings);
    }
}
