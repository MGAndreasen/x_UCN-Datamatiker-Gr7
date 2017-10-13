using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.service
{
    public interface IOrderLine
    {
        int GetOrderId();

        void AddProduct();

        double GetPrice();




    }
}
