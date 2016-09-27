using System;
using ConsoleApplication2.Entity.Object;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Entity
{
    class Visitor : Person
    {
        public Visitor(string name, int age) : base(name, age)
        {
        }

        public bool Hungry { get; set; }

        internal Order MakeOrder()
        {
            Hungry = true;
            Order order = new Order("new");
            Console.WriteLine("I wanna pizza");
            return order;
            

        }

        internal void GetPizza(Order order)
        {
            if (order.Status.Equals("ready"))
            {
                Hungry = false;
                Console.WriteLine("Client Satisfied");
            }
            else Console.WriteLine("I'll burn your restaurant!");
        }

        internal Bill Pay(Bill bill)
        {
            bill.Payed = true;
            Console.WriteLine("Ok, Ill pay for it");
            return bill;
            
        }

    }
}
