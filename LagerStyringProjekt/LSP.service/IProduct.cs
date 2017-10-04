using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSP.models;

namespace LSP.service
{
    public interface IProduct
    {
        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
        Product GetProduct(string name);
        IEnumerable<Product> GetAllProducts();
    }
}
