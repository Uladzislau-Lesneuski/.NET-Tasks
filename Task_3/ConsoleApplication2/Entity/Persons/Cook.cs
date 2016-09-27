using ConsoleApplication2.Entity.Object;
using ConsoleApplication2.Entity.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Entity
{
    class Cook: Person, EmployeeInterface
    {
        public Cook(string name, int age) : base(name, age)
        {
        }

        public void GetSalary()
        {
            Console.WriteLine("Hooorayyy!");
            throw new NotImplementedException();
        }

        internal Order cooking(Order dish)
        {
            if (dish.Status.Equals("accepted"))
            {
                dish.Status = "cooked";
                
                Console.WriteLine("pizza is cooked");
            }
            return dish;

        }
    }
}
