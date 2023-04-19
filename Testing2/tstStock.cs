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
    }
}
