using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Entity.Object
{
    class Bill
    {
        public int Price { get; set; }

        public bool Payed { get; set; }

        public Bill (int price)
        {
            Price = price;
            Payed = false;
        }    
    }
}
