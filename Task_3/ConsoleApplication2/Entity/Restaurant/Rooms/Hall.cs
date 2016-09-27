using ConsoleApplication2.Entity.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Entity.Restaurant.Rooms
{
    class Hall : Room
    {
        public Hall(int n) : base(n)
        {

        }

        public override Person HireEmployee(string name, int age, string vacancy)
        {
            if (vacancy.Equals("Admin"))
            {
                return new Administrator(name, age);
            } else if (vacancy.Equals("Waiter"))
            {
                return new Waiter(name, age);
            }
            throw new NotImplementedException();
        }

        public override void PaySalary(Person person)
        {
            Console.WriteLine("Salary paid for ", person.Name);
            throw new NotImplementedException();
        }
    }
}
