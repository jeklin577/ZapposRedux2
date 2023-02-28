using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer TestCustomer = new clsCustomer();
            Assert.IsNotNull(TestCustomer);
        }
    }
}
