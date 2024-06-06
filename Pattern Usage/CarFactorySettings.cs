using DesignPatterns.Creational_Patterns.Abstract_Factory;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Pattern_Usage
{
    /// <summary>
    /// Settings for the CarFactory and Car Factory Method
    /// </summary>
    public class CarFactorySettings
    {
        public enum CarType
        {
            Sedan,
            Coupe,
            Hatchback
        }
        public CarType Type { get; set; }
        public Color Color { get; set; }
        public CarFactorySettings(CarType type, Color color)
        {
            Type = type;
            Color = color;
        }
    }
}
