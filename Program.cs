using DesignPatterns.Behavioural_Patterns.Mediator;
using DesignPatterns.Pattern_Usage;
using System.Drawing;

namespace DesignPatterns
{
    public class Programm
    {
        static public void Main()
        {
            WoltManager manager = new();
            WoltRestaraunt Pizzeriaaaa = new(manager,FoodTypes.Pizza,"Dominos");
            WoltRestaraunt BurgerKing = new(manager, FoodTypes.Burger,"Burger King");
            WoltRestaraunt KFC = new(manager, FoodTypes.Chicken,"KFC");
            WoltRestaraunt Franjelico = new(manager, FoodTypes.Sushi, "Franjelico");
            WoltRestaraunt GenericNativeAmericanFoodRestaurant = new(manager, FoodTypes.Indian, "Generic Native American Food Restaurant");
            WoltClient client = new(manager,"Itay Cohen");
            WoltClient client2 = new(manager, "Emily Gendelev");
            WoltClient client3 = new(manager, "David Shapiro");
            WoltCourier courier = new(manager);
            client.OrderFood(FoodTypes.Pizza);
            Thread.Sleep(1000);
            client2.OrderFood(FoodTypes.Burger);
            Thread.Sleep(1000);
            client3.OrderFood(FoodTypes.Chicken);
            Thread.Sleep(1000);
            client2.OrderFood(FoodTypes.Sushi);
            Thread.Sleep(1000);
            client.OrderFood(FoodTypes.Indian);
            Thread.Sleep(1000);
            Console.WriteLine("Waiting");
            Thread.Sleep(10000);
        }
    }
}