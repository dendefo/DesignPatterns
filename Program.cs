using DesignPatterns.Pattern_Usage;
using System.Drawing;

namespace DesignPatterns
{
    public class Programm
    {
        static public void Main()
        {
            var factory = new CarFactory();
            var settings = new CarFactorySettings(CarFactorySettings.CarType.Sedan, Color.Red);
            var sedan = factory.CreateProduct(settings);
            Console.WriteLine("Cars created by Abstract Factory:");
            Console.WriteLine(sedan);
            settings.Type = CarFactorySettings.CarType.Coupe;
            var coupe = factory.CreateProduct(settings);
            Console.WriteLine(coupe);
            settings.Type = CarFactorySettings.CarType.Hatchback;
            var hatchback = factory.CreateProduct(settings);
            Console.WriteLine(hatchback);

            var car = Car.GetCar(new CarFactorySettings(CarFactorySettings.CarType.Sedan,Color.White) );
            Console.WriteLine("\nCar created by Factory Method: \n" + car);

            var builder = new CarBuilder();
            builder.BuildPartA(CarFactorySettings.CarType.Sedan);
            builder.BuildPartB(Color.Black);
            car = builder.GetProduct();
            Console.WriteLine("\nCar created by Builder: \n" + car);
        }
    }
}