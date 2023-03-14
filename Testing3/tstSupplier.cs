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
          clsSupplier AnSupplier = new clsSupplier();
            Int32 TestData = 1;
            AnSupplier.SupplierID = TestData;
            Assert.AreEqual(AnSupplier.SupplierID, TestData);
            }
        [TestMethod] public void OrderNumberPropertyOK()
        {
            clsSupplier TestSupplier = new clsSupplier();
            Int32 TestNumber = 1;
            TestSupplier.OrderNumber = TestNumber;
            Assert.AreEqual(TestSupplier.OrderNumber, TestNumber);


        }
        [TestMethod]
        public void SupplierNamePropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string TestData = Convert.ToInt32 1;
            AnSupplier.SupplierName = TestData;
            Assert.AreEqual(AnSupplier.SupplierName, TestData);


        }
        [TestMethod]
        public void OrderArrivedOnPropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            DateTime TestData = DateTime.Now.Date;
            AnSupplier.OrderArrivedOn = TestData;
            Assert.AreEqual(AnSupplier.OrderArrivedOn, TestData);
        }
        [TestMethod]
       public void AvailabilityPropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean TestData = true;
            AnSupplier.Availability = TestData;
            Assert.AreEqual(AnSupplier.Availability, TestData);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Int32 TestData = 1;
            AnSupplier.Quantity = TestData;
            Assert.AreEqual(AnSupplier.Quantity, TestData);
        }
    }
}
