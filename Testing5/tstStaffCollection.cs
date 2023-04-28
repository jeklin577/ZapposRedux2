using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Collections.Generic;


namespace Testing5
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //creates an instance of the class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see it exists
            Assert.IsNotNull(AllStaff);
        }
        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            //new instance of class
            List<clsStaff> TestList = new List<clsStaff>();
            //creates item of test data
            clsStaff TestItem = new clsStaff();
            TestItem.StaffID = 40;
            TestItem.FirstName = "Don";
            TestItem.LastName = "Toliver";
            TestItem.Age = 24;
            TestItem.DateHired = DateTime.Now.Date;
            TestItem.Salary = 2000000;
            TestItem.Gender = true;
            //Add item to Test list
            TestList.Add(TestItem);
            //aasign to property
            AllStaff.StaffList = TestList;
            //tst to see values are same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }
        [TestMethod]
        public void CountStaffOK()
        {
            clsStaffCollection AllStaff = new ClassLibrary.clsStaffCollection();
            //create an instance of class
            Int32 SomeCount = 0;
            //test data to assign
            AllStaff.Count = SomeCount;
            //test to see if val are the same
            Assert.AreEqual(AllStaff.Count, SomeCount);
        }
        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            //creates instance of class
            clsStaff TestStaff = new clsStaff();
            //create test data
            TestStaff.StaffID = 40;
            TestStaff.FirstName = "Don";
            TestStaff.LastName = "Toliver";
            TestStaff.Age = 24;
            TestStaff.DateHired = DateTime.Now.Date;
            TestStaff.Salary = 2000000;
            TestStaff.Gender = true;
            //assign to property
            AllStaff.ThisStaff = TestStaff;
            //tests if both are same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            //creates instance of class
            List<clsStaff> TestList = new List<clsStaff>();
            //create test data
            clsStaff TestItem = new clsStaff();
            TestItem.StaffID = 40;
            TestItem.FirstName = "Don";
            TestItem.LastName = "Toliver";
            TestItem.Age = 24;
            TestItem.DateHired = DateTime.Now.Date;
            TestItem.Salary = 2000000;
            TestItem.Gender = true;
            TestList.Add(TestItem);
            //assign to property
            AllStaff.StaffList = TestList;
            //tests if both are same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            //new instance of class
            clsStaff TestItem = new clsStaff();
            //new item of test data
            Int32 PrimaryKey = 0;
            //var store the PK
            TestItem.StaffID = 40;
            TestItem.FirstName = "Don";
            TestItem.LastName = "Toliver";
            TestItem.Age = 24;
            TestItem.DateHired = DateTime.Now.Date;
            TestItem.Salary = 2000000;
            TestItem.Gender = true;
            //data is set to the staff
            AllStaff.ThisStaff = TestItem;
            //add record
            PrimaryKey = AllStaff.Add();
            //Set PK of the test data
            TestItem.StaffID = PrimaryKey;
            //FINDS RECORD
            AllStaff.ThisStaff.Find(PrimaryKey);
            //TEST TO SEE IF TWO VALS MATCH
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }
        }
    }

        
 






