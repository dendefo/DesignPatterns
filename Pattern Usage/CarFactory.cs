using DesignPatterns.Creational_Patterns.Abstract_Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Pattern_Usage
{
    /// <summary>
    /// A factory that creates cars with settings based on Abstract Factory Pattern
    /// </summary>
    internal class CarFactory : IFactory<Car, CarFactorySettings>
    {
        public Car CreateProduct(CarFactorySettings settings)
        {
            Car car;
            switch (settings.Type)
            {
                case CarFactorySettings.CarType.Sedan:
                    car = new Sedan(settings.Color);
                    break;
                case CarFactorySettings.CarType.Coupe:
                    car = new Coupe(settings.Color);
                    break;
                case CarFactorySettings.CarType.Hatchback:
                    car = new Hatchback(settings.Color);
                    break;
                default:
                    throw new ArgumentException("Invalid car type");
            }
            return car;
        }
    }
}
