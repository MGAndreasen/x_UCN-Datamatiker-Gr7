using LSP.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LSP.bll
{
    public class CustomerCtrl : ICRUD<Customer>, IGetAll<Customer>
    {
        public void Create(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
