using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class Stock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock TestStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(TestStock);
        }
        [TestMethod]
        public void SneakerIDTest()
        {
            //create an instance of the class we want to create
            clsStock TestStock = new clsStock();
            //create some test data to assign to the property
            int TestData = 001;
            //assign the data to the property
            TestStock.SneakerID = TestData;
            //test to see tht the two values are the same
            Assert.AreEqual(TestStock.SneakerID, TestData);
        }
        [TestMethod]
        public void SneakerNameTest()
        {
            clsStock TestStock = new clsStock();
                string TestData = "Jordan";
            TestStock.SneakerName = TestData;
            Assert.AreEqual(TestStock.SneakerName, TestData);
        }
        [TestMethod]
        public void SneakerDescriptionText()
        {
            clsStock TestStock = new clsStock();
            string TestData = "Brand new Jordans....";
                TestStock.SneakerDescription = TestData;
            Assert.AreEqual(TestStock.SneakerDescription, TestData);
        }
        [TestMethod]
        public void ReleaseDateTest()
        {
        clsStock TestStock = new clsStock();
        DateTime TestData = DateTime.Now.Date;
        TestStock.ReleaseDate = TestData;
          Assert.AreEqual(TestStock.ReleaseDate, TestData);
        }
        [TestMethod]
        public void SizeAvailableTest()
        {
            clsStock TestStock = new clsStock();
            Boolean TestData = true;
            TestStock.SizeAvailable = TestData;
            Assert.AreEqual(TestStock.SizeAvailable, TestData);
        }
        [TestMethod]
        public void SizeTest()
        {
            clsStock TestStock = new clsStock();
            decimal TestData = 42.5m;
                TestStock.Size = TestData;
            Assert.AreEqual(TestStock.Size, TestData);
        }
        [TestMethod]
        public void PriceTest()
        {
            clsStock TestStock = new clsStock();
            decimal TestData = 220m;
            TestStock.Price = TestData;
            Assert.AreEqual(TestStock.Price, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsStock TestStock = new clsStock();
            Boolean Found = false;
            Int32 SneakerID = 21;
            Found = TestStock.Find(SneakerID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestStockNoFound()
        {
            //create an instance of the clss we want to create
            clsStock TestStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            Int32 SneakerID = 21;
            Found = TestStock.Find(SneakerID);
            if (TestStock.SneakerID != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestReleaseDateFound()
        {
            clsStock TestStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SneakerID = 21;
            Found = TestStock.Find(SneakerID);
            if(TestStock.ReleaseDate != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSneakerNameFound()
        {
            clsStock TestStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SneakerID = 21;
            Found = TestStock.Find(SneakerID);
            if(TestStock.SneakerName != "Jordan 1")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSneakerDescriptionFound()
        {
            clsStock TestStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SneakerID = 21;
            Found = TestStock.Find(SneakerID);
            if(TestStock.SneakerDescription != "Brand new Jordans ....")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSizeFound()
        {
            clsStock TestStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SneakerID = 21;
            Found = TestStock.Find(SneakerID);
            if(TestStock.Size != Convert.ToDecimal(42.5))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPriceFound()
        {
            clsStock TestStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SneakerID = 21;
            Found = TestStock.Find(SneakerID);
            if(TestStock.Price != Convert.ToDecimal(220))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSizeAvailableFound()
        {
            clsStock TestStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SneakerID = 21;
            Found = TestStock.Find(SneakerID);
            if(TestStock.SizeAvailable != Convert.ToBoolean(true))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
