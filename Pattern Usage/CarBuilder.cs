using DesignPatterns.Creational_Patterns.Builder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesignPatterns.Pattern_Usage.CarFactorySettings;

namespace DesignPatterns.Pattern_Usage
{
    internal class CarBuilder : IBuilder<Car, CarType, Color>
    {
        private Car Product;
        public void BuildPartA(CarType type)
        {
            switch (type)
            {
                case CarType.Hatchback:
                    Product = new Hatchback(Color.White);
                    break;
                case CarType.Coupe:
                    Product = new Coupe(Color.White);
                    break;
                case CarType.Sedan:
                    Product = new Sedan(Color.White);
                    break;
                default:
                    throw new ArgumentException("Invalid car type");
            }
        }
        public void BuildPartB(Color color)
        {
            if (Product == null)
            {
                throw new InvalidOperationException("Product not initialized");
            }
            Product.Color = color;
        }

        public Car GetProduct()
        {
            return Product;
        }
    }
}
