using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff TestStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(TestStaff);
        }
        [TestMethod]
        public void StaffIDTest()
        {
            //create an instance of the class we want to create
            clsStaff TestStaff = new clsStaff();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            TestStaff.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(TestStaff.StaffID, TestData);
        }
        [TestMethod]
        public void FirstNameTest()
        {
            clsStaff TestStaff = new clsStaff();
            string TestData = "Manny";
            TestStaff.FirstName = TestData;
            Assert.AreEqual(TestStaff.FirstName, TestData);
        }
        [TestMethod]
        public void LastNameTest()
        {
            clsStaff TestStaff = new clsStaff();
            string TestData = "Pacquiao";
            TestStaff.LastName = TestData;
            Assert.AreEqual(TestStaff.LastName, TestData);
        }
        [TestMethod]
        public void GenderTest()
        {
            clsStaff TestStaff = new clsStaff();
            Boolean Male = true;
            TestStaff.Gender = Male;
            Assert.AreEqual(TestStaff.Gender, Male);
        }
        [TestMethod]
        public void DateHiredTest()
        {
            clsStaff TestStaff = new clsStaff();
            DateTime TestDate = new DateTime();
            TestStaff.DateHired = TestDate;
            Assert.AreEqual(TestStaff.DateHired, TestDate);
        }
        [TestMethod]
        public void SalaryTest()
        {
            clsStaff TestStaff = new clsStaff();
            decimal TestData = Convert.ToDecimal("21,000");
            TestStaff.Salary = TestData;
            Assert.AreEqual(TestStaff.Salary, TestData);
        }
        [TestMethod]
        public void AgeTest()
        {
            clsStaff TestStaff = new clsStaff();
            int TestData = 22;
            TestStaff.Age = TestData;
            Assert.AreEqual(TestStaff.Age, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff TestStaff = new clsStaff();
            Boolean Found = false;
            Int32 StaffID = 30;
            Found = TestStaff.Find(StaffID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestStaffIDFound()
        {
            clsStaff TestStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 30;
            Found = TestStaff.Find(StaffID);
            if (TestStaff.StaffID != 30)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestFirstNameFound()
        {
            clsStaff TestStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 30;
            Found = TestStaff.Find(StaffID);
            if (TestStaff.FirstName != ("Manny"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestLastNameFound()
        {
            clsStaff TestStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 30;
            Found = TestStaff.Find(StaffID);
            if (TestStaff.LastName != ("Pacquiao"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateHiredFound()
        {
            clsStaff TestStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 30;
            Found = TestStaff.Find(StaffID);
            if (TestStaff.DateHired != Convert.ToDateTime("10/07/22"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSalaryFound()
        {
            clsStaff TestStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 30;
            Found = TestStaff.Find(StaffID);
            if (TestStaff.Salary != Convert.ToDecimal("22,000"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAgeFound()
        {
            clsStaff TestStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 30;
            Found = TestStaff.Find(StaffID);
            if (TestStaff.Age != 22)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestGenderFound()
        {
            clsStaff TestStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 30;
            Found = TestStaff.Find(StaffID);
            if (TestStaff.Gender != "male")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}


