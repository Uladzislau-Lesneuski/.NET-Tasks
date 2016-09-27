using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication2.Logic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            RestaurantWorking test = new RestaurantWorking();
            
            Assert.IsTrue(test.HurryUp());
        }
    }
}
