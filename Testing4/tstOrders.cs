using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstOrders
    {
        //Test data
        string customerID = "150";
        string itemNames = "Jordans";
        string itemQuantity = "5";
        string dateAdded = DateTime.Now.Date.ToString();
        string deliveryAddress = "110 Menlo Park";


        [TestMethod]
        public void InstanceOK()
        {
            clsOrders anOrder = new clsOrders();
            Assert.IsNotNull(anOrder);
        }

        [TestMethod]
        public void OrderIdTest()
        {
            //create an instance of the class we want to create
            clsOrders anOrder = new clsOrders();
            //create some test date to assign to the property
            int TestData = 22;
            //assign the data to the property
            anOrder.OrderNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(anOrder.OrderNo, TestData);
        }

        [TestMethod]
        public void CustomerIdTest()
        {
            clsOrders anOrder = new clsOrders();
            Int32 TestData = 1533;
            anOrder.CustomerID = TestData;
            Assert.AreEqual(anOrder.CustomerID, TestData);
        }

        [TestMethod]
        public void ItemNameTest()
        {
            clsOrders anOrder = new clsOrders();
            string TestData = "Jordans";
            anOrder.ItemNames = TestData;
            Assert.AreEqual(anOrder.ItemNames, TestData);
        }

        [TestMethod]
        public void ItemQuantityTest()
        {
            clsOrders anOrder = new clsOrders();
            Int32 TestData = 3;
            anOrder.ItemQuantity = TestData;
            Assert.AreEqual(anOrder.ItemQuantity, TestData);
        }

        [TestMethod]
        public void DateAddedTest()
        {
            clsOrders anOrder = new clsOrders();
            DateTime TestData = DateTime.Now.Date;
            anOrder.DateAdded = TestData;
            Assert.AreEqual(anOrder.DateAdded, TestData);
        }

        [TestMethod]
        public void DeliveryAddressTest()
        {
            clsOrders anOrder = new clsOrders();
            string TestData = "110 Menlo Park";
            anOrder.DeliveryAddress = TestData;
            Assert.AreEqual(anOrder.DeliveryAddress, TestData);
        }

        [TestMethod]
        public void ReadyToDispatchTest()
        {
            clsOrders anOrder = new clsOrders();
            bool TestData = true;
            anOrder.ReadyToDispatch = TestData;
            Assert.AreEqual(anOrder.ReadyToDispatch, TestData);
        }



        [TestMethod]
        public void findMethodOK()
        {
            //Create an instance of the class we want to create
            clsOrders anOrder = new clsOrders();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderID =  22;
            //invoke the method
            Found = anOrder.Find(OrderID);
            //test to see if the result is true
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestOrderNoFound()
        {
            clsOrders anOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 orderNo = 22;
            Found = anOrder.Find(orderNo);
            if (anOrder.OrderNo != 22)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsOrders anOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 orderID = 22;
            Found = anOrder.Find(orderID); 
            if (anOrder.CustomerID != 1533)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemNamesFound()
        {
            clsOrders anOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 orderID = 22;
            Found = anOrder.Find(orderID);
            if (anOrder.ItemNames != "Jordans") 
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemQuantityFound()
        {
            clsOrders anOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 orderID = 1;
            Found = anOrder.Find(orderID);
            if (anOrder.ItemQuantity != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            clsOrders anOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 orderID = 22;
            Found = anOrder.Find(orderID);

            if (anOrder.DateAdded != Convert.ToDateTime("16,09,2023"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDeliveryAddressFound()
        {
            clsOrders anOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 orderID = 22;
            Found = anOrder.Find(orderID);

            if (anOrder.DeliveryAddress != "110 Menlo Park")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestReadyToDispatchFound()
        {
            clsOrders anOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 22;
            Found = anOrder.Find(OrderID);

            if (anOrder.ReadyToDispatch != true) 
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    
    //Start of Validation Test Methods - CustomerID
        [TestMethod]
        public void ValidMethodOK()
        {
            //Create an instance of the class we want to create
            clsOrders anOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinLessOne()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string customerID = "";
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMin()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string customerID = "a";
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            Assert.AreEqual(Error, "");
        }
        
        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string customerID = "aa";
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            Assert.AreEqual(Error, "");
        }
        
        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string customerID = "aaaaa";
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            Assert.AreEqual(Error, "");
        }
        
        [TestMethod]
        public void CustomerIDMax()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string customerID = "aaaaaa";
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMid()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string customerID = "aaa";
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxPlusOne()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string customerID = "aaaaaaa";
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDExtremeMax()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string customerID = "";
            customerID = customerID.PadRight(500, 'a');
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            Assert.AreNotEqual(Error, "");
        }
        
    //DateAdded Validation
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrders anOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string dateAdded = TestDate.ToString();
            //invoke the method
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string dateAdded = TestDate.ToString();
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedMin()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "1";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string dateAdded = TestDate.ToString();
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string dateAdded = TestDate.ToString();
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string dateAdded = TestDate.ToString();
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string dateAdded = "this is not a date!";
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            Assert.AreNotEqual(Error, "");
        }
        
        //ItemNames Validation
        [TestMethod]
        public void ItemNamesMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders anOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string itemNames = "";
            //invoke the method
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemNamesMin()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string itemNames = "a";
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNamesMinPlusOne()
        { 
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string itemNames = "aa";
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNamesMaxLessOne()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string itemNames = "aaaaaaaa";
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNamesMax()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string itemNames = "aaaaaaaaa";
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNamesMaxPlusOne()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string itemNames = "aaaaaaaaaa";
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemNamesMid()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string itemNames = "aaaa";
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            Assert.AreEqual(Error, "");
        }


        //Delivery Address Validation
        [TestMethod]
        public void DeliveryAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders anOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string deliveryAddress = "";
            //invoke the method
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMin()
        {
            //create an instance of the class we want to create
            clsOrders anOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string deliveryAddress = "a";
            //invoke the method
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMinPlusOne()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string deliveryAddress = "aa";
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMaxLessOne()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string deliveryAddress = "aaaaaaaa";
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMax()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string deliveryAddress = "aaaaaaaaaaaaaaaaaaaa";
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressExtremeMax()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string deliveryAddress = "";
            deliveryAddress = deliveryAddress.PadRight(100, 'a');
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMaxPlusOne()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string deliveryAddress = "aaaaaaaaaaaaaaaaaaaaa";
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMid()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string deliveryAddress = "aaaaaaaaaa";
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            Assert.AreEqual(Error, "");
        }

        //IntemQuantity
        [TestMethod]
        public void ItemQuantityMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string itemQuantity = "";
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ItemQuantityMin()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string itemQuantity = "a";
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemQuantityMinPlusOne()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string itemQuantity = "aa";
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemQuantityMaxLessOne()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string itemQuantity = "aaaaa";
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemQuantityMax()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string itemQuantity = "aaaaaa";
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemQuantityMid()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string itemQuantity = "aaa";
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemQuantityMaxPlusOne()
        {
            clsOrders anOrder = new clsOrders();
            String Error = "";
            string itemQuantity = "aaaaaaa";
            Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
            Assert.AreEqual(Error, "");
        }
        
        
        /*
        [TestMethod]
        public void OrderListOK()
        {
            clsOrders AllOrders = new clsOrders();
            List<clsOrders> TestList = new List<clsOrders>();
            clsOrders TestItem = new clsOrders();
            TestItem.OrderNo = 22;
            TestItem.CustomerID = 150;
            TestItem.ItemNames = "Jordans";
            TestItem.ItemQuantity = 5;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.DeliveryAddress = "110 Menlo Park";

            TestList.Add(OrderList);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }
        */
    }
}

