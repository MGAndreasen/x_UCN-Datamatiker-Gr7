using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using LSP.bll;
using LSP.models;

namespace LSP.service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class LSPService : ILSPService
    {
        private ICRUD<Order> orderCtrl;
        public LSPService()
        {
            orderCtrl = new OrderCtrl();
        }
        public string GetData(string value)
        {
            return string.Format("You entered: {0}", value);
        }
    }
}
