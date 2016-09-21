using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string or full file path");
            HandlerClass handler = new HandlerClass();
            handler.Execution();
            Console.ReadLine();
        }
    }
}
