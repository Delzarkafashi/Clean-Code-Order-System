using YourNamespace.Interfaces;

namespace YourNamespace.Models
{
    public class DiscountCalculator : IDiscountCalculator
    {
        public double CalculateDiscount(int quantity, double price)
        {
            if (quantity > 100)
            {
                return price * quantity * 0.10;
            }
            else if (quantity > 50)
            {
                return price * quantity * 0.05;
            }

            return 0;
        }
    }
}
