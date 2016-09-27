using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Entity.Rooms
{
    public abstract class Room 
    {
        public int square { get; set; }

        public Room (int n)
        {
            square = n;
        }

        abstract public Person HireEmployee(string name, int age, string vacancy);

        abstract public void PaySalary(Person person);
    }
}
