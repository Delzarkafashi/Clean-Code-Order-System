using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourNamespace.Interfaces
{
    public interface IDiscountCalculator
    {
        double CalculateDiscount(int quantity, double price);
    }
}
