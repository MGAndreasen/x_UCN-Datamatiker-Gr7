using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using LSP.models; 

namespace LSP.service
{
    public interface ICustomer
    {
        void CreateNewCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        Customer GetCustomer(int phoneNumber);
        IEnumerable<Customer> GetAllCustomers();
    }
}
