using System;
using System.Collections.Generic;

namespace OOPDemo.Object_Oriented_Programming.Encapsulation
{
    public class ShoppingSystem
    {
        private List<Order> Platform { get; set; }

        Order order = new Order(1, "c1", new List<string>{"apple"}, DateTime.Now, "12");

        public void GetOrderTime()
        {
            //access by method
            var time = order.GetOrderTime();
        }

        public void GetBill()
        {
            //you can access Bill here
            var bill = order.Bill;
            //following code will have compiling error
            // order.Bill = "15";
        }
    }
}