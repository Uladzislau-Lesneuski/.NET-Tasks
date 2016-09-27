using ConsoleApplication2.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            HandleManager handleManager = new HandleManager();
            handleManager.Launch();
            Console.ReadLine();
        }
    }
}
