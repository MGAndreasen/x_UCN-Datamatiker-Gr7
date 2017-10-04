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
        void CreateNewCustomer(Customer cust);
        void DeleteCustomer(Customer cust);
        string UpdateCustomer(Customer cust);
        Customer getCustomer(int phoneNumber);

        string GetCustomerName();
        string SetCustomerName();

        string GetCustomerLastName();
        string SetCustomerLastName();

        int GetCustomerPhoneNumber();
        int SetCustomerPhoneNumber();

        int GetCustomerCvr();
        int SetCustomerCvr();

        int GetCustomerAddress();
        int SetCurstomerAddress();

        int GetCustomerZip();
        int SetCustomerZip();




    }
}
