using System;
using YourNamespace.Interfaces;

namespace YourNamespace.Models
{
    public class Order : IOrder
    {
        public string Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        private readonly IDiscountCalculator _discountCalculator;

        public Order(IDiscountCalculator discountCalculator)
        {
            _discountCalculator = discountCalculator;
        }

        public void ProcessOrder()
        {
            if (IsValidOrder())
            {
                double discount = _discountCalculator.CalculateDiscount(Quantity, Price);
                double total = (Price * Quantity) - discount;

                Console.WriteLine($"Processing order for {Quantity} {Product}(s) at ${Price * Quantity}");
                Console.WriteLine($"Total price after discount: ${total}");
            }
            else
            {
                Console.WriteLine("Invalid order!");
            }
        }

        public void ShipOrder()
        {
            Console.WriteLine("Order shipped");
        }

        private bool IsValidOrder()
        {
            return Quantity > 0 && !string.IsNullOrWhiteSpace(Product);
        }
    }
}
