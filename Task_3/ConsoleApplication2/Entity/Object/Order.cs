using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Entity.Object
{
    class Order
    {
        public string Status { get; set; }

        public Order(string orderStatus)
        {
            Status = orderStatus;
        }
    }
}
