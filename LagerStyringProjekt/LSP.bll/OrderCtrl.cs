using System;
using System.Collections.Generic;
using System.Text;
using LSP.models;

namespace LSP.bll
{
    public class OrderCtrl : ICRUD<Order>, IGetAll<Order>
    {
        public void Create(Order entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Order Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
