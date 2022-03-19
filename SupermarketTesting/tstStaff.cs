using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SupermarketTesting
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void Instance()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AStaff);
        }
    }

    class clsStaff
    {
    }
}
