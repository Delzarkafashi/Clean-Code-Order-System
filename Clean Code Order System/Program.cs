using System;
using YourNamespace.Interfaces;
using YourNamespace.Models;

namespace YourNamespace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IDiscountCalculator discountCalculator = new DiscountCalculator();
            IOrder order = new Order(discountCalculator)
            {
                Product = "Laptop",
                Quantity = 120,
                Price = 899.99
            };

            order.ProcessOrder();
            order.ShipOrder();
        }
    }
}
