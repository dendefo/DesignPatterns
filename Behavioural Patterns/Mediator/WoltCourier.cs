using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural_Patterns.Mediator
{
    internal class WoltCourier
    {
        private WoltManager _manager;
        private WoltCourier() { }
        public WoltCourier(WoltManager manager)
        {
            _manager = manager;
            manager.AddCourier(this);
        }
        async public void DeliverOrder(WoltRestaraunt restaraunt, Order order)
        {
            Console.WriteLine($"Courier is going to {restaraunt.Name}");
            await Task.Delay(1000);
            Console.WriteLine($"Courier is delivering order from {restaraunt.Name}");
            await Task.Delay(1000);
            Console.WriteLine($"Courier has delivered order from {restaraunt.Name} to {order.Client.Name}");
            order.Client.RecieveOrder(order);
        }

    }
}
