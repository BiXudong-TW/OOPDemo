using System;
using System.Collections.Generic;

namespace OOPDemo.Object_Oriented_Programming.Encapsulation
{
    public class Order
    {
        private long Id { get; set; }

        private string CustomerName { get; set; }

        private List<string> Merchandise { get; set; }

        private DateTime OrderTime { get; set; }

        public string Bill { get; }

        public Order(long id, string customerName, List<string> merchandise, DateTime orderTime, string bill)
        {
            Id = id;
            CustomerName = customerName;
            Merchandise = merchandise;
            OrderTime = orderTime;
            Bill = bill;
        }

        public DateTime GetOrderTime()
        {
            return OrderTime;
        }

        public void SetOrderTime(DateTime dateTime)
        {
            OrderTime = dateTime;
        }
    }
}