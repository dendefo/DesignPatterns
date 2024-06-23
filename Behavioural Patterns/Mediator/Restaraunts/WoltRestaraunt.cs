using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural_Patterns.Mediator
{
    internal class WoltRestaraunt
    {
        public string Name { get; private set; }
        public FoodTypes FoodTypes { get; private set; }
        private WoltManager _manager;
        private WoltRestaraunt() { }
        public WoltRestaraunt(WoltManager manager,FoodTypes foodType,string name)
        {
            _manager = manager;
            FoodTypes = foodType;
            Name = name;
            manager.AddRestaraunt(this);
        }
        public int GetNewOrderEstimationTime()
        {
            return 0;
        }
        async public void Order(Action<WoltRestaraunt,Order> OnReady, Order order)
        {
            Console.WriteLine($"{Name} got the order");
            Console.WriteLine($"{Name} is preparing order");
            await Task.Delay(5000);
            Console.WriteLine($"{Name} has prepared order");
            OnReady(this, order);

        }
    }
}
