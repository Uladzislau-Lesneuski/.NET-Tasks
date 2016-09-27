using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Entity.Rooms
{
    internal class Kitchen : Room
    {
        public Kitchen(int n) : base(n)
        {
            
        }

        public override Person HireEmployee(string name, int age, string vacancy)
        {
            if (vacancy.Equals("Cook"))
            {
                return new Cook(name, age);
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
