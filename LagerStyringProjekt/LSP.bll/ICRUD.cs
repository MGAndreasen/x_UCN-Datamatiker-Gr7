using System;
using System.Collections.Generic;
using System.Text;
using LSP.models;

namespace LSP.bll
{
    public interface ICRUD<T>
    {
        void Create(T entity);
        T Get(int id);
        void Update(T entity);
        void Delete(int id);
    }
}
