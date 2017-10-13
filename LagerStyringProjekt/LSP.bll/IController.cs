using System;
using System.Collections.Generic;
using System.Text;
using LSP.models;

namespace LSP.bll
{
    public interface IController<T>
    {
        void Create(T entity);
        T Get(int id);
        IEnumerable<T> GetAll();
        void Update(T entity);
        void Delete(int id);
    }
}
