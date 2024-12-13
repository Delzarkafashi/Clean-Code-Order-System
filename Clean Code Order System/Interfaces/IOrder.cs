using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourNamespace.Interfaces
{
    public interface IOrder
    {
        string Product { get; set; }
        int Quantity { get; set; }
        double Price { get; set; }
        void ProcessOrder();
        void ShipOrder();
    }
}

