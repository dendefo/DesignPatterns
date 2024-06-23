using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural_Patterns.Mediator
{
    internal class WoltClient
    {
        public string Name { get; private set; }
        private WoltManager _manager;
        private WoltClient() { }
        public WoltClient(WoltManager manager, string name)
        {
            _manager = manager;
            manager.AddClient(this);
            Name = name;
        }
        public void OrderFood(FoodTypes foodType)
        {
            _manager.OrderFood(new Order(foodType, this));
        }
        public void RecieveOrder(Order order)
        {
            Console.WriteLine("Client has recieved order");
        }
    }
}
