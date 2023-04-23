using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class Stock
    {
        //good test data
        string SneakerName = "Jordan";
        string SneakerDescription = "description";
        string ReleaseDate = DateTime.Now.Date.ToString();
        string Size = "7.5";
        string Price = "220";

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
            Int32 SneakerID = 2;
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
            Int32 SneakerID = 2;
            Found = TestStock.Find(SneakerID);
            if (TestStock.SneakerID != 2)
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
            Int32 SneakerID = 2;
            Found = TestStock.Find(SneakerID);
            if (TestStock.ReleaseDate != Convert.ToDateTime("16/09/2015"))
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
            Int32 SneakerID = 2;
            Found = TestStock.Find(SneakerID);
            if (TestStock.SneakerName != "Jordan 1")
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
            Int32 SneakerID = 2;
            Found = TestStock.Find(SneakerID);
            if (TestStock.SneakerDescription != "Brand new Jordans ....")
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
            Int32 SneakerID = 2;
            Found = TestStock.Find(SneakerID);
            if (TestStock.Size != Convert.ToDecimal(7.5))
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
            Int32 SneakerID = 2;
            Found = TestStock.Find(SneakerID);
            if (TestStock.Price != Convert.ToDecimal(220))
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
            Int32 SneakerID = 2;
            Found = TestStock.Find(SneakerID);
            if (TestStock.SizeAvailable != Convert.ToBoolean(true))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock TestStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            Error = TestStock.Valid(SneakerName, SneakerDescription, Size, ReleaseDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SneakerNameMinLessOneValidation()
        {
            clsStock TestStock = new clsStock();
            String Error = "";
            string SneakerName = "";
            Error = TestStock.Valid(SneakerName, SneakerDescription, Size, ReleaseDate, Price);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SneakerNameMinValidation()
        {
            clsStock TestStock = new clsStock();
            String Error = "";
            string SneakerName = "a";
            Error = TestStock.Valid(SneakerName, SneakerDescription, ReleaseDate, Size, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SneakerNameMinPlusOneValidation()
        {
            clsStock TestStock = new clsStock();
            String Error = "";
            string SneakerName = "aa";
            Error = TestStock.Valid(SneakerName, SneakerDescription, ReleaseDate, Size, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SneakerNameMaxLessOneValidation()
        {
            clsStock TestStock = new clsStock();
            String Error = "";
            string SneakerName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //49 characters
            Error = TestStock.Valid(SneakerName, SneakerDescription, ReleaseDate, Size, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SneakerNameMaxValidation()
        {
            clsStock TestStock = new clsStock();
            String Error = "";
            string SneakerName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //50 chars
            Error = TestStock.Valid(SneakerName, SneakerDescription, ReleaseDate, Size, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SneakerNameMidValidation()
        {
            clsStock TestStock = new clsStock();
            String Error = "";
            string SneakerName = "aaaaaaaaaaaaaaaaaaaaaaaaa"; 
            Error = TestStock.Valid(SneakerName, SneakerDescription, ReleaseDate, Size, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SneakerNameMaxPlusOneValidation()
        {
            clsStock TestStock = new clsStock();
            String Error = "";
            string SneakerName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //51 chars
            Error = TestStock.Valid(SneakerName, SneakerDescription, ReleaseDate, Size, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SneakerNameExtremeMaxValidation()
        {
            clsStock TestStock = new clsStock();
            String Error = "";
            string SneakerName = "";
            SneakerName = SneakerName.PadRight(500, 'a');
            Error = TestStock.Valid(SneakerName, SneakerDescription, ReleaseDate, Size, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SneakerDescriptionMinLessOneValidation()
        {
            clsStock TestStock = new clsStock();
            String Error = "";
            string SneakerDescription = "";
            Error = TestStock.Valid(SneakerName, SneakerDescription, Size, ReleaseDate, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SneakerDescriptionMinValidation()
        {
            clsStock TestStock = new clsStock();
            String Error = "";
            string SneakerDescription = "a";
            Error = TestStock.Valid(SneakerName, SneakerDescription, ReleaseDate, Size, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SneakerDescriptionMinPlusOneValidation()
        {
            clsStock TestStock = new clsStock();
            String Error = "";
            string SneakerDescription = "aa";
            Error = TestStock.Valid(SneakerName, SneakerDescription, ReleaseDate, Size, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SneakerDescriptionMaxLessOneValidation()
        {
            clsStock TestStock = new clsStock();
            String Error = "";
            string SneakerDescription = "";
            SneakerDescription = SneakerDescription.PadRight(249, 'a');
            Error = TestStock.Valid(SneakerName, SneakerDescription, ReleaseDate, Size, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SneakerDescriptionMaxValidtion()
        {
            clsStock TestStock = new clsStock();
            String Error = "";
            string SneakerDescription = "";
            SneakerDescription = SneakerDescription.PadRight(250, 'a');
            Error = TestStock.Valid(SneakerName, SneakerDescription, ReleaseDate, Size, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SneakerDescriptionMidValidation()
        {
            clsStock TestStock = new clsStock();
            String Error = "";
            string SneakerDescription = "";
            SneakerDescription = SneakerDescription.PadRight(100, 'a');
            Error = TestStock.Valid(SneakerName, SneakerDescription, ReleaseDate, Size, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SneakerDescriptionMaxPlusOneValidation()
        {
            clsStock TestStock = new clsStock();
            String Error = "";
            string SneakerDescription = "";
            SneakerDescription = SneakerDescription.PadRight(251, 'a');
            Error = TestStock.Valid(SneakerName, SneakerDescription, ReleaseDate, Size, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SneakerDescriptionExtremeMaxValidation()
        {
            clsStock TestStock = new clsStock();
            String Error = "";
            string SneakerDescription = "";
            SneakerDescription = SneakerDescription.PadRight(500, 'a');
            Error = TestStock.Valid(SneakerName, SneakerDescription, ReleaseDate, Size, Price);
            Assert.AreNotEqual(Error, "");
        }
        //Below is the validation for ReleaseDate. Since my property is different than the one in the handouts I will have to alter the boundaries. DateAdded
        //is based on when a record was added in the database, ReleaseDate is based on when a sneaker was released in the market. According to
        //Google search the first sneaker was released in the 1830s, so my Min value is today's date 200 years ago. My ExtremeMin boundary will be 300 years ago.
        [TestMethod]
        public void ReleaseDateExtremeMinValidation()
        {
            clsStock TestStock = new clsStock();
            String Error = "";
            //var to store the test date data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-300);
            string DateAdded = TestDate.ToString();
            Error = TestStock.Valid(SneakerName, SneakerDescription, ReleaseDate, Size, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ReleaseDateMinValidation()
        {
            clsStock TestStock = new clsStock();
            String Error = "";
            //var to store the test date data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-200);
            string DateAdded = TestDate.ToString();
            Error = TestStock.Valid(SneakerName, SneakerDescription, ReleaseDate, Size, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ReleaseDateMinLessOneValidation()
        {
            clsStock TestStock = new clsStock();
            String Error = "";
            //var to store the test date data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-201);
            string DateAdded = TestDate.ToString();
            Error = TestStock.Valid(SneakerName, SneakerDescription, ReleaseDate, Size, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ReleaseDateMinPlusOneValidation()
        {
            clsStock TestStock = new clsStock();
            String Error = "";
            //var to store the test date data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-199);
            string DateAdded = TestDate.ToString();
            Error = TestStock.Valid(SneakerName, SneakerDescription, ReleaseDate, Size, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ReleaseDateMaxValidation()
        {
            clsStock TestStock = new clsStock();
            String Error = "";
            //var to store the test date data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateAdded = TestDate.ToString();
            Error = TestStock.Valid(SneakerName, SneakerDescription, ReleaseDate, Size, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ReleaseDateMaxLessOneValidation()
        {
            clsStock TestStock = new clsStock();
            String Error = "";
            //var to store the test date data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateAdded = TestDate.ToString();
            Error = TestStock.Valid(SneakerName, SneakerDescription, ReleaseDate, Size, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ReleaseDateMaxPlusOneValidation()
        {
            clsStock TestStock = new clsStock();
            String Error = "";
            //var to store the test date data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateAdded = TestDate.ToString();
            Error = TestStock.Valid(SneakerName, SneakerDescription, ReleaseDate, Size, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ReleaseDateExtremeMaxValidation()
        {
            clsStock TestStock = new clsStock();
            String Error = "";
            //var to store the test date data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateAdded = TestDate.ToString();
            Error = TestStock.Valid(SneakerName, SneakerDescription, ReleaseDate, Size, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ReleaseDateInvalidDataValidation()
        {
            clsStock TestStock = new clsStock();
            String Error = "";
            string ReleaseDate = "this is not a date";
            Error = TestStock.Valid(SneakerName, SneakerDescription, ReleaseDate, Size, Price);
            Assert.AreNotEqual(Error, "");
        }
    }
    
}


    
       


