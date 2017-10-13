using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LSP.service
{
    [ServiceContract]
    public interface ILSPService
    {
        [OperationContract]
        string GetData(string value);
    }
}
