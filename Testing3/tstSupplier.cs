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
        [TestMethodpublic] public void OrderNumberPropertyOK()
        {
            clsSupplier TestSupplier = new clsSupplier();
            Int32 TestNumber = 1;
            AnSupplier.OrderNumber = TestNumber;
            Assert.AreEqual(AnSupplier.OrderNumber, TestNumber);


        }
        [TestMethod]
        public void SupplierNamePropertyOK()
        {
            clsSupplier clsSupplier = new clsSupplier();
            string TestData = 1;
            AnSupplier.SupplierName = TestData;
            Assert.AreEqual(AnSupplier.SupplierName, TestData);


        }
        [TestMethodpublic]
        public void OrderArrivedOnPropertyOK()
        {
            clsSupplier TestSupplier = new clsSupplier();
            DateTime TestData = DateTime.Now.Date;
            AnSupplier.OrderArrivedOn = TestData;
            Assert.AreEqual(AnSupplier.OrderArrivedOn, TestData);
        }
        [TestMethodpublic]
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
