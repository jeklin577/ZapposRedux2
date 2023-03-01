using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrders
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsOrders anOrder = new clsOrders();
            Assert.IsNotNull(anOrder);
        }
    }

    class clsOrders
    {
    }
}
