using ConsoleApplication2.Entity.Object;
using ConsoleApplication2.Entity.Persons;
using ConsoleApplication2.Entity.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Entity
{
    class Administrator : Person, EmployeeInterface
    {
        public Administrator(string name, int age) : base(name, age)
        {
        }

        internal void takeMoneyToCapital(Bill bill)
        {
            if (bill.Payed == true)
            {
                Console.WriteLine("Profit!");
            }
            
        }

        internal void openRestaurant()
        {
              
        }

        internal void closeRestaurant()
        {

        }

        public void GetSalary()
        {
            Console.WriteLine("Hooorayyy!");
            throw new NotImplementedException();
        }

        //public void PaySalary(Person person)
        //{
        //    Console.WriteLine("Salary paid for ", person.Name);
        //    throw new NotImplementedException();
        //}
    }
}
