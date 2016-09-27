using ConsoleApplication2.Entity;
using ConsoleApplication2.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication2.Manager
{
    class HandleManager
    {
        private static RestaurantWorking ACTION = new RestaurantWorking();

        internal void Launch()
        {
            try
            {
                ACTION.HurryUp();
            }
            catch (Exception)
            {
                Console.WriteLine("Smth go wrong!");
            }
            
            
        }
        


    }
}
