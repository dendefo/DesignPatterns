using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural_Patterns.Mediator
{
    /// <summary>
    /// Wolt Application Mediator
    /// </summary>
    internal class WoltManager
    {
        private List<WoltRestaraunt> _restaraunts;
        private List<WoltClient> _clients;
        private List<WoltCourier> _couriers;

        public WoltManager()
        {
            _restaraunts = new();
            _clients = new();
            _couriers = new();
        }

        public void AddRestaraunt(WoltRestaraunt restaraunt)
        {
            _restaraunts.Add(restaraunt);
        }
        public void AddClient(WoltClient client)
        {
            _clients.Add(client);
        }
        public void AddCourier(WoltCourier courier)
        {
            _couriers.Add(courier);
        }
        public void OrderFood(Order order)
        {
            Console.WriteLine("Manager ordered food");

            int minTime = int.MaxValue;
            WoltRestaraunt FastestRestaraunt = null;
            var avalibleRestaraunts = _restaraunts.Where(x => x.FoodTypes == order.FoodType).ToList();
            if (avalibleRestaraunts.Count == 0)
            {
                Console.WriteLine("No restaraunts available in your city: Beirut");
                return;
            }
            foreach (var rest in avalibleRestaraunts)
            {
                int time = rest.GetNewOrderEstimationTime();
                if (time < minTime)
                {
                    minTime = time;
                    FastestRestaraunt = rest;
                }
            }

            FastestRestaraunt.Order(CallForCourier,order);
        }
        public void CallForCourier(WoltRestaraunt restaraunt,Order order)
        {
            Console.WriteLine("Manager called for courier");
            WoltCourier ClosestCourier = null;
            int minDistance = int.MaxValue;
            foreach (var courier in _couriers)
            {
                int distance = Random.Shared.Next(1,100);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    ClosestCourier = courier;
                }
            }
            ClosestCourier.DeliverOrder(restaraunt, order);
        }
    }
    internal struct Order
    {
        public FoodTypes FoodType;
        public WoltClient Client;
        public Order(FoodTypes foodType, WoltClient client)
        {
            FoodType = foodType;
            Client = client;
        }
    }
    public enum FoodTypes{
        Indian,
        Chinese,
        Burger,
        Pizza,
        Sushi,
        Shawarma,
        Falafel,
        Pasta,
        Salad,
        Chicken
    }
}
