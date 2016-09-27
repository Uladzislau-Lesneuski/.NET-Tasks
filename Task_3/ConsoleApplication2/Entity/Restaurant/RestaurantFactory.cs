using ConsoleApplication2.Entity.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Entity.Restaurant
{
    abstract public class RestaurantFactory
    {
        abstract public Room RoomCreate(int n, string Room);
    }
}
