using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //test to see thta it exists
            Assert.IsNotNull(AnSupplier);
        }
          [TestMethod]
          public void SupplierIDPropertyOK()
        { 
          clsSupplier clsSupplier = new clsSupplier();
            Int32 TestData = 1;
            AnSupplier.SupplierID = TestData;
            Assert.AreEqual(AnSupplier.SupplierID, TestData);
            }

    }
}
