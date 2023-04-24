﻿
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {

            tstCustomerCollection CustomerCollection = new tstCustomerCollection();

            Assert.IsNotNull(CustomerCollection);

        }

        [TestMethod]

        public void CountPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Int32 SomeCount = 2;
            AllCustomers.Count = SomeCount;
            Assert.AreEqual(AllCustomers.Count, SomeCount);
        }

        [TestMethod]

        public void CustomerListOK()
        {
            
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();


            TestItem.HasOrder = true;
            TestItem.ShippingAddress = "123 Street Street";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Password = "Password";
            TestItem.Username = "Dave";
            TestItem.CustomerID = 5;

            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;

            Assert.AreEqual(AllCustomers.CustomerList, TestList);
            
        }

        [TestMethod]

        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();


            TestItem.HasOrder = true;
            TestItem.ShippingAddress = "123 Street Street";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Password = "Password";
            TestItem.Username = "Dave";
            TestItem.CustomerID = 5;

            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;

            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]

        public void TwoRecordsPresent()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            Assert.AreEqual(AllCustomers.Count, 2);

        }



    }
}
