using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSP.models;


namespace LSP.service
{
    public interface IOrder
    {
        void CreateOrder(Order order);

        void UpdateOrder(Order order);

        void DeleteOrder(Order order);

        Order GetOrder(int id);

        IEnumerable<Order> GetAllOrders();
    }
}
