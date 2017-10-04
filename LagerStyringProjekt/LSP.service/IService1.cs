using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace LSP.service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICustomer
    {
       // Customer CreateNewCustomer();
        string DeleteCustomer();
        string UpdateCustomer();
        string ReadCustomer();

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
