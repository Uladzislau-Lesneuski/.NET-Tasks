using System;
using ConsoleApplication2.Entity.Object;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2.Entity.Persons;

namespace ConsoleApplication2.Entity
{
    class Waiter : Person, EmployeeInterface
    {
        public Waiter(string name, int age) : base(name, age)
        {
        }

        internal Order ApplyOrder(Order order)
        {
            order.Status = "accepted";
            Console.WriteLine("One moment sir");
            return order;
            
        }

        internal Order TakeCookedOrder(Order order)
        {
            order.Status = "ready";
            return order;
        }

        internal Bill MakeBill()
        {
            Random rand = new Random();
            
            Bill bill = new Bill(rand.Next(40));
            Console.WriteLine("I wanna a lot of tip");
            return bill;
            
        }

        public void GetSalary()
        {
            Console.WriteLine("Hooorayyy!");
            throw new NotImplementedException();
        }

        public Bill TakeMoney(Bill bill)
        {
            bill.Payed = true;
            Console.WriteLine("OMG");
            return bill;
            
        }
    }
}
