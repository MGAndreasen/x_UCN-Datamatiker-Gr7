﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSP.models;


namespace LSP.service
{
    interface IOrder
    {
        Order GetOrder(int id);
        

        void AddCustomer(Order o, Customer c);

    }
}
