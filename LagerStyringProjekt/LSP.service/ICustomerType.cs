using LSP.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.service
{
    public interface ICustomerType
    {
        void CreateCustomerType(Order order);

        void UpdateCustomerType(Order order);

        void DeleteCustomerType(Order order);

        Order GetCustomerType(int id);

        IEnumerable<Order> GetAllCustomerTypes();
    }
}
