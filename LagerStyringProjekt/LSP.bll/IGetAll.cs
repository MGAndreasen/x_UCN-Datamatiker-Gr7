using System;
using System.Collections.Generic;
using System.Text;

namespace LSP.bll
{
    public interface IGetAll<T>
    {
        IEnumerable<T> GetAll();
    }
}
