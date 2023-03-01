using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrders
    {

        [TestMethod]
        public void OrderIdTest()
        {
            //create an instance of the class we want to create
            clsOrders orderIdTest= new clsOrders();
            //create some test date to assign to the property
            int TestData = 001;
            //assign the data to the property
            orderIdTest.orderID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(orderIdTest.orderID, TestData);
        }

        [TestMethod]
        public void CustomerIdTest()
        {
            clsOrders customerIdTest = new clsOrders();
            Int32 TestData = 1533;
            customerIdTest.customerID = TestData;
            Assert.AreEqual(customerIdTest.customerID, TestData);
        }

        [TestMethod]
        public void ItemNameTest()
        {
            clsOrders itemNameTest = new clsOrders();
            string TestData = "Jordans";
            itemNameTest.itemNames= TestData;
            Assert.AreEqual(itemNameTest.itemNames, TestData);
        }

        [TestMethod]
        public void ItemQuantityTest()
        {
            clsOrders itemQuantityTest = new clsOrders();
            Int32 TestData = 3;
            itemQuantityTest.itemQuantity = TestData;
            Assert.AreEqual(itemQuantityTest.itemQuantity, TestData);
        }

        [TestMethod]
        public void DateAddedTest()
        {
            clsOrders dateAddedTest= new clsOrders();
            DateTime TestData = DateTime.Now.Date;
            dateAddedTest.dateAdded= TestData;
            Assert.AreEqual(dateAddedTest.dateAdded, TestData);
        }

        [TestMethod]
        public void DeliveryAddressTest()
        {
            clsOrders deliveryAddressTest = new clsOrders();
            string TestData = "110 Menlo Park";
            deliveryAddressTest.deliveryAddress = TestData;
            Assert.AreEqual(deliveryAddressTest.deliveryAddress, TestData);
        }

        [TestMethod]
        public void ReadyToDispatchTest()
        {
            clsOrders readyToDispatchTest = new clsOrders();
            bool TestData = true;
            readyToDispatchTest.readyToDispatch= TestData;
            Assert.AreEqual(readyToDispatchTest.readyToDispatch, TestData);
        }
    }


}
