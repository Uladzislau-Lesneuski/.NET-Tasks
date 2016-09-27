using ConsoleApplication2.Entity;
using ConsoleApplication2.Entity.Object;
using ConsoleApplication2.Entity.Restaurant;
using ConsoleApplication2.Entity.Restaurant.Rooms;
using ConsoleApplication2.Entity.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Logic
{
    public class RestaurantWorking
    {
        public bool HurryUp()
        {
            Restaurant restr = new Restaurant();

            Hall hall = (Hall) restr.RoomCreate(30, "Hall");

            Kitchen kitchen = (Kitchen) restr.RoomCreate(10, "Kitchen");

            Administrator admin = (Administrator) hall.HireEmployee("Andrei", 35, "Admin");

            Waiter waiter = (Waiter) hall.HireEmployee("Denis", 20, "Waiter");

            Cook cook = (Cook) kitchen.HireEmployee("Petr", 25, "Cook");

            Visitor client = new Visitor("Vlad",40);

            Order order = client.MakeOrder();

            //Console.WriteLine(order.Status);
            order = waiter.ApplyOrder(order);

            order = cook.cooking(order);

            order = waiter.TakeCookedOrder(order);
            Bill bill = waiter.MakeBill();
            Console.WriteLine("bill status - payed:" + bill.Payed);

            client.GetPizza(order);
            client.Pay(bill);

            bill = waiter.TakeMoney(bill);
            Console.WriteLine("bill status - payed:" +  bill.Payed);

            admin.takeMoneyToCapital(bill);

            //hall.PaySalary((Person)admin);
            //hall.PaySalary(waiter);
            //kitchen.PaySalary(cook);
            return client.Hungry;

        }
        


    }
}
