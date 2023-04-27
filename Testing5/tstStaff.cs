using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstStaff
    {

        string FirstName = "Manny";
        string LastName = "Pacquiao";
        string DateHired = DateTime.Now.Date.ToString();
        string Salary = "22000";
        string Age = "20";

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
            //creates an instance of the class
            string TestData = "Manny";
            //create some test data to assign to the property
            TestStaff.FirstName = TestData;
            //assign the data to the property
            Assert.AreEqual(TestStaff.FirstName, TestData);
            //test to see that the two values are the same
        }
        [TestMethod]
        public void LastNameTest()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            string TestData = "Pacquiao";
            //create some test data to assign to the property
            TestStaff.LastName = TestData;
            //assign the data to the property
            Assert.AreEqual(TestStaff.LastName, TestData);
            //test to see that the two values are the same
        }
        [TestMethod]
        public void GenderTest()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            Boolean Male = true;
            //create some test data to assign to the property
            TestStaff.Gender = Male;
            //assign the data to the property
            Assert.AreEqual(TestStaff.Gender, Male);
            //test to see that the two values are the same
        }
        [TestMethod]
        public void DateHiredTest()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            DateTime TestDate = DateTime.Now.Date;
            //create some test data to assign to the property
            TestStaff.DateHired = TestDate;
            //assign the data to the property
            Assert.AreEqual(TestStaff.DateHired, TestDate);
            //test to see that the two values are the same
        }
        [TestMethod]
        public void SalaryTest()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            decimal TestData = Convert.ToDecimal("21,000");
            //create some test data to assign to the property
            TestStaff.Salary = TestData;
            //assign the data to the property
            Assert.AreEqual(TestStaff.Salary, TestData);
            //test to see that the two values are the same
        }
        [TestMethod]
        public void AgeTest()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            int TestData = 22;
            //create some test data to assign to the property
            TestStaff.Age = TestData;
            //assign the data to the property
            Assert.AreEqual(TestStaff.Age, TestData);
            //test to see that the two values are the same
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            Boolean Found = false;
            //boolean var to store results of the validation
            Int32 StaffID = 30;
            //invokes method
            Found = TestStaff.Find(StaffID);
            //tests to see if its correct
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestStaffIDFound()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            Boolean Found = false;
            //boolean var to store results of the search
            Boolean OK = true;
            //test data to use with the method
            Int32 StaffID = 30;
            //invokes method
            Found = TestStaff.Find(StaffID);
            //checks staff no
            if (TestStaff.StaffID != 30)
            {
                OK = false;
            }
            //checks if result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestFirstNameFound()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            Boolean Found = false;
            //boolean var to store results of the search
            Boolean OK = true;
            //test data to use with the method
            Int32 StaffID = 30;
            //invokes method
            Found = TestStaff.Find(StaffID);
            //checks staff no
            if (TestStaff.FirstName != ("Manny"))
            {
                OK = false;
            }
            //checks if result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestLastNameFound()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            Boolean Found = false;
            //boolean var to store results of the search
            Boolean OK = true;
            //test data to use with the method
            Int32 StaffID = 30;
            //invokes method
            Found = TestStaff.Find(StaffID);
            //checks staff no
            if (TestStaff.LastName != ("Pacquiao"))
            {
                OK = false;
            }
            //checks if result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateHiredFound()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            Boolean Found = false;
            //boolean var to store results of the search
            Boolean OK = true;
            //test data to use with the method
            Int32 StaffID = 30;
            //invokes method
            Found = TestStaff.Find(StaffID);
            //checks staff no
            if (TestStaff.DateHired != Convert.ToDateTime("10/07/22"))
            {
                OK = false;
            }
            //checks if result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSalaryFound()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            Boolean Found = false;
            //boolean var to store results of the search
            Boolean OK = true;
            //test data to use with the method
            Int32 StaffID = 30;
            //invokes method
            Found = TestStaff.Find(StaffID);
            //checks staff no
            if (TestStaff.Salary != Convert.ToDecimal("22,000"))
            {
                OK = false;
            }
            //checks if result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAgeFound()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            Boolean Found = false;
            //boolean var to store results of the search
            Boolean OK = true;
            //test data to use with the method
            Int32 StaffID = 30;
            //invokes method
            Found = TestStaff.Find(StaffID);
            //checks staff no
            if (TestStaff.Age != 22)
            {
                OK = false;
            }
            //checks if result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestGenderFound()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            Boolean Found = false;
            //boolean var to store results of the search
            Boolean OK = true;
            //test data to use with the method
            Int32 StaffID = 30;
            //invokes method
            Found = TestStaff.Find(StaffID);
            //checks staff no
            if (TestStaff.Gender != "Male")
            {
                OK = false;
            }
            //checks if result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            String Error = "";
            //string stores error message
            Error = TestStaff.Valid(FirstName, LastName, DateHired, Salary, Age);
            //invokes method
            Assert.AreEqual(Error, "");
            //test to check the results correct
        }
        [TestMethod]
        public void FirstNameInLessOne()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            String Error = "";
            //string stores error message
            string FirstName = ""; // triggers an error
            Error = TestStaff.Valid(FirstName, LastName, DateHired, Salary, Age);
            //invokes method
            Assert.AreNotEqual(Error, "");
            //test to check the results correct
        }
        [TestMethod]
        public void FirstNameMin()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            String Error = "";
            //string test data to pass
            string FirstName = "a";
            Error = TestStaff.Valid(FirstName, LastName, DateHired, Salary, Age);
            //invokes method
            Assert.AreEqual(Error, "");
            //test to check the results correct
        }
        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            String Error = "";
            //string test data to pass
            string FirstName = "aa";
            Error = TestStaff.Valid(FirstName, LastName, DateHired, Salary, Age);
            //invokes method
            Assert.AreEqual(Error, "");
            //test to check the results correct
        }
        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            String Error = "";
            //string test data to pass
            string FirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = TestStaff.Valid(FirstName, LastName, DateHired, Salary, Age);
            //invokes method
            Assert.AreEqual(Error, "");
            //test to check the results correct
        }
        [TestMethod]
        public void FirstNameMax()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            String Error = "";
            //string test data to pass
            string FirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = TestStaff.Valid(FirstName, LastName, DateHired, Salary, Age);
            //invokes method
            Assert.AreEqual(Error, "");
            //test to check the results correct
        }
        [TestMethod]
        public void FirstNameMid()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            String Error = "";
            //string test data to pass
            string FirstName = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = TestStaff.Valid(FirstName, LastName, DateHired, Salary, Age);
            //invokes method
            Assert.AreEqual(Error, "");
            //test to check the results correct
        }
        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            String Error = "";
            //string test data to pass
            string FirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = TestStaff.Valid(FirstName, LastName, DateHired, Salary, Age);
            //invokes method
            Assert.AreNotEqual(Error, "");
            //test to check the results correct
        }
        [TestMethod]
        public void FirstNameExtremeMax()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            String Error = "";
            //string test data to pass
            string FirstName = "";
            FirstName = FirstName.PadRight(500, 'a');
            Error = TestStaff.Valid(FirstName, LastName, DateHired, Salary, Age);
            //invokes method
            Assert.AreNotEqual(Error, "");
            //test to check the results correct
        }
        [TestMethod]
        public void LastNameInLessOne()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            String Error = "";
            //string stores error message
            string LastName = ""; // triggers an error
            Error = TestStaff.Valid(FirstName, LastName, DateHired, Salary, Age);
            //invokes method
            Assert.AreNotEqual(Error, "");
            //test to check the results correct
        }
        [TestMethod]
        public void LastNameMin()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            String Error = "";
            //string test data to pass
            string LastName = "a";
            Error = TestStaff.Valid(FirstName, LastName, DateHired, Salary, Age);
            //invokes method
            Assert.AreEqual(Error, "");
            //test to check the results correct
        }
        [TestMethod]
        public void LastNameMinPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            String Error = "";
            //string test data to pass
            string LastName = "aa";
            Error = TestStaff.Valid(FirstName, LastName, DateHired, Salary, Age);
            //invokes method
            Assert.AreEqual(Error, "");
            //test to check the results correct
        }
        [TestMethod]
        public void LastNameMaxLessOne()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            String Error = "";
            //string test data to pass
            string LastName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = TestStaff.Valid(FirstName, LastName, DateHired, Salary, Age);
            //invokes method
            Assert.AreEqual(Error, "");
            //test to check the results correct
        }
        [TestMethod]
        public void LastNameMax()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            String Error = "";
            //string test data to pass
            string LastName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = TestStaff.Valid(FirstName, LastName, DateHired, Salary, Age);
            //invokes method
            Assert.AreEqual(Error, "");
            //test to check the results correct
        }
        [TestMethod]
        public void LastNameMid()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            String Error = "";
            //string test data to pass
            string LastName = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = TestStaff.Valid(FirstName, LastName, DateHired, Salary, Age);
            //invokes method
            Assert.AreEqual(Error, "");
            //test to check the results correct
        }
        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            String Error = "";
            //string test data to pass
            string LastName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = TestStaff.Valid(FirstName, LastName, DateHired, Salary, Age);
            //invokes method
            Assert.AreNotEqual(Error, "");
            //test to check the results correct
        }
        [TestMethod]
        public void LastNameExtremeMax()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            String Error = "";
            //string test data to pass
            string LastName = "";
            LastName = LastName.PadRight(500, 'a');
            Error = TestStaff.Valid(FirstName, LastName, DateHired, Salary, Age);
            //invokes method
            Assert.AreNotEqual(Error, "");
            //test to check the results correct
        }
        [TestMethod]
        public void DateHiredExtremeMin()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            String Error = "";
            //string var to store error msg
            DateTime TestDate;
            //set the Date to todays
            TestDate = DateTime.Now.Date;
            //Date minus 100 years
            TestDate = TestDate.AddYears(-100);
            //Convert to String var
            String DateHired = TestDate.ToString();
            //invoke method
            Error = TestStaff.Valid(FirstName, LastName, DateHired, Salary, Age);
            //test to check result is right
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateHiredMinLessOne()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            String Error = "";
            //string var to store error msg
            DateTime TestDate;
            //set the Date to todays
            TestDate = DateTime.Now.Date;
            //Date minus 1 day
            TestDate = TestDate.AddDays(-1);
            //Convert to String var
            String DateHired = TestDate.ToString();
            //invoke method
            Error = TestStaff.Valid(FirstName, LastName, DateHired, Salary, Age);
            //test to check result is right
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateHiredMin()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            String Error = "";
            //string var to store error msg
            DateTime TestDate;
            //set the Date to todays
            TestDate = DateTime.Now.Date;
            //Convert to String var
            String DateHired = TestDate.ToString();
            //invoke method
            Error = TestStaff.Valid(FirstName, LastName, DateHired, Salary, Age);
            //test to check result is right
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateHiredMinPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            String Error = "";
            //string var to store error msg
            DateTime TestDate;
            //set the Date to todays
            TestDate = DateTime.Now.Date;
            //Date add 1 day
            TestDate = TestDate.AddDays(1);
            //Convert to String var
            String DateHired = TestDate.ToString();
            //invoke method
            Error = TestStaff.Valid(FirstName, LastName, DateHired, Salary, Age);
            //test to check result is right
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateHiredExtremeMax()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            String Error = "";
            //string var to store error msg
            DateTime TestDate;
            //set the Date to todays
            TestDate = DateTime.Now.Date;
            //Date add 100 years
            TestDate = TestDate.AddYears(100);
            //Convert to String var
            String DateHired = TestDate.ToString();
            //invoke method
            Error = TestStaff.Valid(FirstName, LastName, DateHired, Salary, Age);
            //test to check result is right
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateHiredInvalidData()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            String Error = "";
            //string var to store error msg           
            String DateHired = "This Is Not a Date!";
            //invoke method
            Error = TestStaff.Valid(FirstName, LastName, DateHired, Salary, Age);
            //test to check result is right
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void SalaryExtremeMin()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            String Error = "";
            //string var to store error msg
            string Salary = "";
            Salary = Salary.PadRight(5000000, 'a');
            //Convert to String var
            //invoke method
            Error = TestStaff.Valid(FirstName, LastName, DateHired, Salary, Age);
            //test to check result is right
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SalaryMinLessOne()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            String Error = "";
            //string var to store error msg
            //assigns var to decimal
            Decimal TempPrice = -1;
            //Convert to String var
            String Salary = TempPrice.ToString();
            //invoke method
            Error = TestStaff.Valid(FirstName, LastName, DateHired, Salary, Age);
            //test to check result is right
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateHiredMin()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            String Error = "";
            //string var to store error msg
            DateTime TestDate;
            //set the Date to todays
            TestDate = DateTime.Now.Date;
            //Convert to String var
            String DateHired = TestDate.ToString();
            //invoke method
            Error = TestStaff.Valid(FirstName, LastName, DateHired, Salary, Age);
            //test to check result is right
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateHiredMinPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            String Error = "";
            //string var to store error msg
            DateTime TestDate;
            //set the Date to todays
            TestDate = DateTime.Now.Date;
            //Date add 1 day
            TestDate = TestDate.AddDays(1);
            //Convert to String var
            String DateHired = TestDate.ToString();
            //invoke method
            Error = TestStaff.Valid(FirstName, LastName, DateHired, Salary, Age);
            //test to check result is right
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateHiredExtremeMax()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            String Error = "";
            //string var to store error msg
            DateTime TestDate;
            //set the Date to todays
            TestDate = DateTime.Now.Date;
            //Date add 100 years
            TestDate = TestDate.AddYears(100);
            //Convert to String var
            String DateHired = TestDate.ToString();
            //invoke method
            Error = TestStaff.Valid(FirstName, LastName, DateHired, Salary, Age);
            //test to check result is right
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateHiredInvalidData()
        {
            clsStaff TestStaff = new clsStaff();
            //creates an instance of the class
            String Error = "";
            //string var to store error msg           
            String DateHired = "This Is Not a Date!";
            //invoke method
            Error = TestStaff.Valid(FirstName, LastName, DateHired, Salary, Age);
            //test to check result is right
            Assert.AreNotEqual(Error, "");
        }
}


