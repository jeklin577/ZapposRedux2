using ClassLibrary;
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
        public void FindMethodOK()
        {
            clsCustomer TestCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;

            Int32 CustomerID = 3834887; ///This is a valid point
            Found = TestCustomer.Find(CustomerID);

            if (TestCustomer.CustomerID != 3834887) {
                OK = false;
            }

            Assert.IsTrue(OK);


        }

        


        [TestMethod]

        public void ValidateMethodOK()
            ///^^^^
            ///Source of an error  that took 20 minutes and made me feel like a jackass, remember your early classes!!! a void method
            ///Doesn't return anything!!!! We had this as public string ValidateMethodOK and were confused when we were getting a "not all code paths return
            ///a value" error, we made a method that would return a string and then never gave it anything to return! Silly!
        {
            clsCustomer TestCustomer = new clsCustomer();
            string Error = "";
            Error = TestCustomer.Valid(Username, HasOrder, Password,DateAdded,ShippingAddress);
            Assert.AreEqual(Error, "");

        }


        
        /// Rather than writing out data for each relevant field for each test, by placing this here, we have a referenceable set of good data
        /// (apart from HasOrder, but for some reason i'm having trouble understanding exactly how booleans work in this Html-MySQl-C#(?)
        /// happy family, so meh.
        string Username = "King Billy";
        string HasOrder = "True";
        string Password = "I am very cool";
        string DateAdded = DateTime.Now.Date.ToString();
        string ShippingAddress = "Whereever i feel like";







    }

   
}
