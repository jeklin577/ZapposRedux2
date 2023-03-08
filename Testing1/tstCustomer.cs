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

        [TestMethod]
        public void HasOrderTest()
        {
            clsCustomer TestCustomer = new clsCustomer();
            Boolean DoesHaveOrder = true;
            TestCustomer.HasOrder = DoesHaveOrder;
            Assert.AreEqual(TestCustomer.HasOrder, DoesHaveOrder);
        }

        [TestMethod]
        public void UserNameTest()
        {
            clsCustomer TestCustomer = new clsCustomer();
            String TestUsername = "Username";
            TestCustomer.Username = TestUsername;
            Assert.AreEqual(TestCustomer.Username, TestUsername);
        }

        [TestMethod]
        public void PasswordTest()
        {
            clsCustomer TestCustomer = new clsCustomer();
            String TestPassword = "Password";
            TestCustomer.Password = TestPassword;
            Assert.AreEqual(TestCustomer.Password, TestPassword);
        }

        [TestMethod]
        public void ShippingAdressTest()
        {
            clsCustomer TestCustomer = new clsCustomer();
            String TestShipping = "123 Street Street";
            TestCustomer.ShippingAddress = TestShipping;
            Assert.AreEqual(TestCustomer.ShippingAddress, TestShipping);
        }

        [TestMethod]
        public void JoinDateTest()
        {
            clsCustomer TestCustomer = new clsCustomer();
            DateTime TestDate = DateTime.Now.Date;
            TestCustomer.DateAdded = TestDate;
            Assert.AreEqual(TestCustomer.DateAdded, TestDate);
            
        }

        [TestMethod]
        public void CustomerIDTest()
        {
            clsCustomer TestCustomer = new clsCustomer();
            Int32 CustomerIDTest = 1337;
            TestCustomer.CustomerID = CustomerIDTest;
            Assert.AreEqual(TestCustomer.CustomerID, CustomerIDTest);

        }

        [TestMethod]
        public void CusFindMethodOK()
        {
            clsCustomer TestCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1337;
            TestCustomer.CustomerID = CustomerID;
            Found = TestCustomer.Find(CustomerID); ///Sets 
            
            if (TestCustomer.CustomerID != 1337)
            {
                OK = false;
                
            }

            Assert.IsTrue(OK);

        }



    }
}
