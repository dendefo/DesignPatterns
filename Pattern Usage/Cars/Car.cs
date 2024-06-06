using DesignPatterns.Creational_Patterns.Abstract_Factory;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Pattern_Usage
{
    public abstract class Car
    {
        public Color Color { get; set; }
        protected Car() { }
        internal Car(Color color)
        {
            Color = color;
        }
        public override string ToString()
        {
            return $"Car of type: {GetType().Name}, Color: {Color.Name}";
        }
        /// <summary>
        /// Factory method of the Car class
        /// </summary>
        /// <param name="settings"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        static public Car GetCar(CarFactorySettings settings)
        {
            switch (settings.Type)
            {
                case CarFactorySettings.CarType.Sedan:
                    return new Sedan(settings.Color);
                case CarFactorySettings.CarType.Coupe:
                    return new Coupe(settings.Color);
                case CarFactorySettings.CarType.Hatchback:
                    return new Hatchback(settings.Color);
                default:
                    throw new ArgumentException("Invalid car type");
            }
        } 
    }
}
