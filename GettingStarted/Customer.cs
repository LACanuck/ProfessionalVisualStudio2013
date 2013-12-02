using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GettingStarted
{
    public class Customer
    {
        public Customer()
        {
            Orders = new List<Order>();
        }

        public string Name { get; set; }
        public List<Order> Orders { get; set; }
    }

    public class Order
    {
        public string Description { get; set; }
    }
}
