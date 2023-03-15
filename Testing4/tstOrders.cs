﻿using ClassLibrary;
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
            clsOrders anOrder = new clsOrders();
            //create some test date to assign to the property
            int TestData = 001;
            //assign the data to the property
            anOrder.orderID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(anOrder.orderID, TestData);
        }

        [TestMethod]
        public void CustomerIdTest()
        {
            clsOrders anOrder = new clsOrders();
            Int32 TestData = 1533;
            anOrder.customerID = TestData;
            Assert.AreEqual(anOrder.customerID, TestData);
        }

        [TestMethod]
        public void ItemNameTest()
        {
            clsOrders anOrder = new clsOrders();
            string TestData = "Jordans";
            anOrder.itemNames = TestData;
            Assert.AreEqual(anOrder.itemNames, TestData);
        }

        [TestMethod]
        public void ItemQuantityTest()
        {
            clsOrders anOrder = new clsOrders();
            Int32 TestData = 3;
            anOrder.itemQuantity = TestData;
            Assert.AreEqual(anOrder.itemQuantity, TestData);
        }

        [TestMethod]
        public void DateAddedTest()
        {
            clsOrders anOrder = new clsOrders();
            DateTime TestData = DateTime.Now.Date;
            anOrder.dateAdded = TestData;
            Assert.AreEqual(anOrder.dateAdded, TestData);
        }

        [TestMethod]
        public void DeliveryAddressTest()
        {
            clsOrders anOrder = new clsOrders();
            string TestData = "110 Menlo Park";
            anOrder.deliveryAddress = TestData;
            Assert.AreEqual(anOrder.deliveryAddress, TestData);
        }

        [TestMethod]
        public void ReadyToDispatchTest()
        {
            clsOrders anOrder = new clsOrders();
            bool TestData = true;
            anOrder.readyToDispatch = TestData;
            Assert.AreEqual(anOrder.readyToDispatch, TestData);
        }

        [TestMethod]
        public void findMethodOK()
        {
            //Create an instance of the class we want to create
            clsOrders anOrder = new clsOrders();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderNo = 1;
            //invoke the method
            Found = anOrder.Find(OrderNo);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        /*
        [TestMethod]
        public void TestOrderNoFound()
        {
            clsOrders anOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 orderID = 1;
            Found = anOrder.Find(orderID);
            if (anOrder.orderID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        */


    }


}
