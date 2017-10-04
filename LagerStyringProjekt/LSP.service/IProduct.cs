using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.service
{
    public interface IProduct
    {
        void CreateProduct(int id, double price, string name, ProductGroup productGroup);

    }
}
