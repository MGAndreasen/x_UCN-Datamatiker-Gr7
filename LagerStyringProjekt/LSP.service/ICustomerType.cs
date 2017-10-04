using LSP.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.service
{
    interface ICustomerType
    {
        CustomerType GetCustomerType(int id);
        List<CustomerType> GetAllCustomerTypes();
    }
}
