using ConsoleApplication2.Entity.Restaurant.Rooms;
using ConsoleApplication2.Entity.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Entity.Restaurant
{
    class Restaurant : RestaurantFactory
    {
        public override Room RoomCreate(int square, string Room)
        {
            if (Room.Equals("Hall"))
            {
                return new Hall(square);

            } else if (Room.Equals("Kitchen"))
            {
                return new Kitchen(square);
            }
            
            throw new NotImplementedException();
        }
    }
}
