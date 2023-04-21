﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstOrderCollection
    {

        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrders> TestList = new List<clsOrders>();
            clsOrders TestItem = new clsOrders();
            TestItem.OrderNo = 22;
            TestItem.CustomerID = 1533;
            TestItem.DeliveryAddress = "110 Menlo Park";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ItemNames = "Jordans";
            TestItem.ItemQuantity = 3;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrders TestOrder = new clsOrders();
            TestOrder.OrderNo = 22;
            TestOrder.CustomerID = 1533;
            TestOrder.DeliveryAddress = "110 Menlo Park";
            TestOrder.DateAdded = DateTime.Now.Date;
            TestOrder.ItemNames = "Jordans";
            TestOrder.ItemQuantity = 3;
            //Assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some data to assign to the property
            List<clsOrders> TestList = new List<clsOrders>();
            //Add an item to the list
            //Create the item of the test data
            clsOrders TestItem = new clsOrders();
            //set its properties
            TestItem.OrderNo = 22;
            TestItem.CustomerID = 1533;
            TestItem.DeliveryAddress = "110 Menlo Park";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ItemNames = "Jordans";
            TestItem.ItemQuantity = 3;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the test item of the test data
            clsOrders TestItem = new clsOrders();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderNo = 22;
            TestItem.CustomerID = 1533;
            TestItem.DeliveryAddress = "110 Menlo Park";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ItemNames = "Jordans";
            TestItem.ItemQuantity = 3;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderNo = PrimaryKey;
            //modify the test data
            TestItem.OrderNo = 32;
            TestItem.CustomerID = 2533;
            TestItem.DeliveryAddress = "111 Menlo Park";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ItemNames = "Jordan";
            TestItem.ItemQuantity = 2;
            //set the record based on the new test data
            AllOrders.ThisOrder = TestItem;
            //update the record
            AllOrders.Update();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see ThisOrder matches the test data.
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);



        }
    }
}