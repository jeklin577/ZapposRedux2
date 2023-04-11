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
        //Note to self: IF THIS METHOD FAILS, ASK YOURSELF, AM I USING THAT NETWORK CONNECTION PROGRAM THAT NEEDS TO BE RUNNING?
        //ALSO SORRY FOR SHOUTING, IT'S BEEN A ROUGH DAY, also, it's a very good thing that comments get shaved away at runtime, imagine having
        //to use actual resources to store all this waffling?

        


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

        [TestMethod] ///Oops, forgot this! Remember, if you don't define a method as being part of a unit test, there's no magic way for it to be
        ///understood as a unit test.
        public void UserNameValidateTooShort()
        {
            clsCustomer TestCustomer = new clsCustomer();
            string Checker = "";
            ///string BadUserNameShort = ""; ///Empty, should be caught by our if statement thresher in the Valid method, 
            ///^^^ This is dumb, we're just going to set Username directly to "", no point making a variable where a direct assignment would save space
            Username = "";
            Checker = TestCustomer.Valid(Username, HasOrder, Password, DateAdded, ShippingAddress);
            Assert.AreNotEqual(Checker, ""); ///So, because we've corrputed our innocent little Username data into being an invalid little monster
            ///our Valid method should see this, append the Error string to read "Username must be more than 0 characters long", because that
            ///string != "", the test should succeed.
            ///
            ///And the test does succeed, very nice! Now, we can effectively rewrite this test for each of our different rule sets.
        }

        [TestMethod]
        public void UserNameValidateTooLong()
        {
            clsCustomer TestCustomer = new clsCustomer();
            string Checker = "";
           
            Username = "ThisIsMyDiabolicalPlanToCreateAuserNameSoAbsurdlyLongEvenStoringItMoreThanTwiceWouldCostMyVictimsTens,IfNotTrillionsOfPoundSterling";
            Checker = TestCustomer.Valid(Username, HasOrder, Password, DateAdded, ShippingAddress);
            Assert.AreNotEqual(Checker, ""); 
        }

        [TestMethod]
        public void UserNameValidateMininmumSize()
        {
            clsCustomer TestCustomer = new clsCustomer();
            string Checker = "";
           
            Username = "Z";
            Checker = TestCustomer.Valid(Username, HasOrder, Password, DateAdded, ShippingAddress);
            Assert.AreEqual(Checker, ""); ///This username is totally valid, and so we should see our CheckerString be populated with "" (as per the valid method in clsCustomer.)
        }

        [TestMethod]
        public void UserNameValidateMininmumSizePlusOne()
        {
            clsCustomer TestCustomer = new clsCustomer();
            string Checker = "";

            Username = "ZZ";
            Checker = TestCustomer.Valid(Username, HasOrder, Password, DateAdded, ShippingAddress);
            Assert.AreEqual(Checker, ""); ///This username is totally valid, and so we should see our CheckerString be populated with "" (as per the valid method in clsCustomer.)
        }

        [TestMethod]
        public void UserNameValidateMaxSize()
        {
            clsCustomer TestCustomer = new clsCustomer();
            string Checker = "";

            Username = "(S]%7/et{hUKB;).R6!R}AnQ@6DW9uYz@4:#P;(%-]CF3[ha$y"; ///Exactly 50 random characters
            Checker = TestCustomer.Valid(Username, HasOrder, Password, DateAdded, ShippingAddress);
            Assert.AreEqual(Checker, ""); ///This username is totally valid, and so we should see our Checker string be populated with "" (as per the valid method in clsCustomer.)
        }

        [TestMethod]
        public void UserNameValidateMaxSizeMinusOne()
        {
            clsCustomer TestCustomer = new clsCustomer();
            string Checker = "";

            Username = "(S]%7/et{hUKB;).R6!R}AnQ@6DW9uYz@4:#P;(%-]CF3[ha$"; ///Exactly 50 random characters
            Checker = TestCustomer.Valid(Username, HasOrder, Password, DateAdded, ShippingAddress);
            Assert.AreEqual(Checker, ""); ///This username is totally valid, and so we should see our Checker string be populated with "" (as per the valid method in clsCustomer.)
        }

        //As insanely lazy as this sounds (Because it is), these methods also are functionally identical to ones we'd have to write for Password and Shipping Address
        //Because they're all of the same data type (A string of 50 characters), we don't think there's a reason to specifically test if, say a 49 character Password would work, if we know for a fact a 49 character long username does.
        //These next tests are going to be covering the specific rule set

        [TestMethod]

        public void PasswordValidateIdenticalToUsername()
        {
            clsCustomer TestCustomer = new clsCustomer();
            string Checker = "";
            ///string BadUserNameShort = ""; ///Empty, should be caught by our if statement thresher in the Valid method, 
            ///^^^ This is dumb, we're just going to set Username directly to "", no point making a variable where a direct assignment would save space
            Username = Password;
            Checker = TestCustomer.Valid(Username, HasOrder, Password, DateAdded, ShippingAddress);
            Assert.AreNotEqual(Checker, "");
        }

        [TestMethod]

        public void DateAddedWEGOTTAGOBACKMARTY()
        {

            clsCustomer TestCustomer = new clsCustomer();
            string Checker = "";
            DateTime GreatScott = Convert.ToDateTime(DateAdded); //A new challenger appears!, we're going to fiddle with poor Scott here and then populate date
            //added with his temporaily challenged self (we're gonna amek this date time variable go back 200 years and then populate our DateAdded
            //datetime variable

            GreatScott = GreatScott.AddYears(-200); //That first part seems unessecary, but lets try it.
            //This worked? huh, i guess the .AddYears Method doesn't immediately overwrite the original variable? odd.
            DateAdded = GreatScott.ToString();

            Checker = TestCustomer.Valid(Username, HasOrder, Password, DateAdded, ShippingAddress);
            ///Forgot to assign the result of the valid method to checker, test was failing, is now fixed, making this comment delightfully redundant.

            Assert.AreNotEqual(Checker, ""); //Scott has meddled with the primal forces of nature, and so, if he makes it through the Valid
            //method unscathed, we have failed.
        }

        [TestMethod]
        public void DateAddedWelcomeToTheWorldOfTommorrow()
        {

            clsCustomer TestCustomer = new clsCustomer();
            string Checker = "";
            DateTime GreatScott = Convert.ToDateTime(DateAdded); //A new challenger appears!, we're going to fiddle with poor Scott here and then populate date
            //added with his temporaily challenged self (we're gonna amek this date time variable go back 200 years and then populate our DateAdded
            //datetime variable

            GreatScott = GreatScott.AddYears(200); 
            DateAdded = GreatScott.ToString();

            Checker = TestCustomer.Valid(Username, HasOrder, Password, DateAdded, ShippingAddress);

            Assert.AreNotEqual(Checker, ""); //Scott has meddled with the primal forces of nature, and so, if he makes it through the Valid
            //method unscathed, we have failed.
        }

        [TestMethod]
        public void DateAddedYouCreatedATimeParadox() ///Note, while these test names are amusing to you Sean, please rewrite them before submitting
        {
            clsCustomer TestCustomer = new clsCustomer();
            string Checker = "";
            string Doomed = "";
            Doomed = "Snake? Snake? SNAAAAAAKE";

            DateAdded = Doomed;
            Checker = TestCustomer.Valid(Username, HasOrder, Password, DateAdded, ShippingAddress);
            Assert.AreNotEqual(Checker, ""); //Scott has meddled with the primal forces of nature, and so, if he makes it through the Valid
        }







        /// Rather than writing out data for each relevant field for each test, by placing this here, we have a referenceable set of good data
        /// (apart from HasOrder, but for some reason i'm having trouble understanding exactly how booleans work in this Html-MySQl-C#(?)
        /// happy family, so meh.
        string Username = "King Billy";
        string HasOrder = "True";
        string Password = "I am very cool";
        string DateAdded = DateTime.Now.Date.ToString();
       //Remember to not deal with this DateAdded String directly! instead use something like that Nifty DateTime.Now.Date when testing stuff!
        
        string ShippingAddress = "123 Street Street";
        ///Note, we don't need CustomerID here because that's handled on the data layer(?)







    }

   
}
