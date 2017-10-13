using System;
using System.Collections.Generic;
using System.Text;

namespace LSP.models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int CustomerId { get; set; }
        public double TotalPrice { get; set; }

    }
}
