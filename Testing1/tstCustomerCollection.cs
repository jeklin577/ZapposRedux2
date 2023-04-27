
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

        /// [TestMethod]

        ///public void CountPropertyOK()
        ///{
        ///    clsCustomerCollection AllCustomers = new clsCustomerCollection();
        ///     Int32 SomeCount = 2;
        ///     AllCustomers.Count = SomeCount;
        ///     Assert.AreEqual(AllCustomers.Count, SomeCount);
        /// }
        /// This test is superceded by the ListAndCountOK test, preserved here, as an example of hardcoding in data instead of writing an actually effective test.
        /// 


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

        ///  [TestMethod]

        /// public void TwoRecordsPresent()
        /// {
        ///     clsCustomerCollection AllCustomers = new clsCustomerCollection();

        ///     Assert.AreEqual(AllCustomers.Count, 2);

        /// }
        /// See the description for the CountPropertyOK method, same situation applies here.

        [TestMethod]

        public void AddMethodOK()
        {
           clsCustomerCollection AllCustomers = new clsCustomerCollection();
        clsCustomer TestCus = new clsCustomer();

        Int32 PrimaryKey = 0;

            TestCus.HasOrder = true;
            TestCus.ShippingAddress = "123 Street Street";
            TestCus.DateAdded = DateTime.Now.Date;
            TestCus.Password = "Password";
            TestCus.Username = "Dave";
            TestCus.CustomerID = 5;
            AllCustomers.ThisCustomer = TestCus;

            PrimaryKey = AllCustomers.Add();

            TestCus.CustomerID = PrimaryKey;

            AllCustomers.ThisCustomer.Find(PrimaryKey);

            Assert.AreEqual(AllCustomers.ThisCustomer, TestCus);


    }

        [TestMethod]

        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestCus = new clsCustomer();

            Int32 PrimaryKey = 0;

            TestCus.HasOrder = true;
            TestCus.ShippingAddress = "123 Street Street";
            TestCus.DateAdded = DateTime.Now.Date;
            TestCus.Password = "Password";
            TestCus.Username = "Dave";
            TestCus.CustomerID = 5;
            AllCustomers.ThisCustomer = TestCus;

            PrimaryKey = AllCustomers.Add();

            TestCus.CustomerID = PrimaryKey;


            TestCus.HasOrder = false;
            TestCus.ShippingAddress = "789 Street Street";
            TestCus.DateAdded = DateTime.Now.Date;
            TestCus.Password = "Word of pass";
            TestCus.Username = "Evad";
            TestCus.CustomerID = 77;

            AllCustomers.ThisCustomer = TestCus;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);

            Assert.AreEqual(AllCustomers.ThisCustomer, TestCus);
            
        }

        [TestMethod]

        public void DeleteMethodOK()
        {

            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestCus = new clsCustomer();

            Int32 PrimaryKey = 0;

            TestCus.HasOrder = true;
            TestCus.ShippingAddress = "123 Street Street";
            TestCus.DateAdded = DateTime.Now.Date;
            TestCus.Password = "Password";
            TestCus.Username = "Dave";
            TestCus.CustomerID = 5;
            AllCustomers.ThisCustomer = TestCus;

            PrimaryKey = AllCustomers.Add();

            TestCus.CustomerID = PrimaryKey;

            AllCustomers.ThisCustomer.Find(PrimaryKey);
            AllCustomers.Delete();

            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(Found);


        }

        [TestMethod]

        public void ReportByUsernameMethodOK()
        {
            clsCustomerCollection SomeCustomers = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            
            
            
            FilteredCustomers.ReportByUsername("");

            Assert.AreEqual(SomeCustomers.Count, FilteredCustomers.Count); //Interesting note on why hardcodn's bad, so we were supposed to write a basic hardcoded solution of Assert.AreEqual(0,FC.Count), but our empty custmer cllections
            ///contain every element on the database by default, and our unit tests continuall bump that number up by adding new customers
            ///I'm also completely unsure how the hell our actual filter procedure works? I guess filtering for something like "" is a bit of a mindfreak anyway though, plus, it passes.
            ///
        }

        [TestMethod]
        public void ReportByUsernameNoneFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByUsername("Wingdinginginigninginigningngngn"); //Should return no results
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]

        public void ReportByUsernameTestDataFound1()
        {

            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();

            Boolean OK = true;
            FilteredCustomers.ReportByUsername("Billy");
            
            if (FilteredCustomers.Count == 2)
            {
                if (FilteredCustomers.CustomerList[0].CustomerID != 3834864) { OK = false; } //Whoops! Had the wrong Customer Id for this conditional! Fixed now!

                if (FilteredCustomers.CustomerList[1].CustomerID != 3834967) { OK = false; }
            }

            else if (FilteredCustomers.Count != 2)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
            
        }

    }
}
