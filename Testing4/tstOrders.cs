using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrders
    {

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
    
       
    }
}

