using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

[TestClass]
public class tstSupplierCollection
{
    [TestMethod]
    public void InstanceOK()
    {
        clsSupplierCollection AllSupplier = new clsSupplierCollection();
        Assert.IsNotNull(AllSupplier);
    }
    [TestMethod]
    public void SupplierListok()
    { clsSupplierCollection AllSupplier = new clsSupplierCollection();
        List<clsSupplier> TestList = new List<clsSupplier>();
        clsSupplier TestItem = new clsSupplier();
        TestItem.SupplierID = "91121";
        TestItem.Suppliername = "sean";
        TestItem.OrderArrivedOn = DateTime.Now.Date;
        TestItem.OrderNumber = 7353;
        TestItem.Availability = "true";
        TestItem.Quantity = 3;
        TestItem.Add(TestItem);
        AllSupplier.SupplierList = TestList;
        Assert.AreEqual(AllSupplier.SupplierList, TestList);
    }
    [TestMethod]
    public void ThisSupplierPropertyOK()
    { clsSupplierCollection AllSupplier = new clsSupplierCollection();
        clsSupplier TestSupplier = new clsSupplier();
        TestItem.SupplierID = 91121;
        TestItem.Suppliername = "sean";
        TestItem.OrderArrivedOn = DateTime.Now.Date;
        TestItem.OrderNumber = 7353;
        TestItem.Availability = "true";
        TestItem.Quantity = 3;
        AllSupplier.ThisSupplier = TestSupplier;
        Assert.AreEqual(AllSupplier.ThisSupplier, TestSupplier);
    }
    [TestMethod]
    public void ListAndCountOk()
    { clsSupplier AllSupplier = new ClsSupplierCollection();
        List<clsSupplier> TestList = new List<clsSupplier>();
        CLSCompliantAttribute TestItem = new clsSupplier();
        TestItem.SupplierID = "91121";
        TestItem.Suppliername = "sean";
        TestItem.OrderArrivedOn = DateTime.Now.Date;
        TestItem.OrderNumber = "7353";
        TestItem.Availability = "true";
        TestItem.Quantity = 3;
        TestList.Add(TestItem);
        AllSupplier.SupplierList = TestList;
        Assert.AreEqual(AllSupplier.Count, TestList.count);
    }
    public clsSupplierCollection();
    clsSupplier TestItem = new clsSupplier();
    TestItem.SupplierID = "91121";
    TestItem.Suppliername = "sean";
    TestItem.OrderArrivedOn = DateTime.Now.Date;
    TestItem.OrderNumber = "7353";
    TestItem.Availability = "true";
    TestItem.Quantity = 3;
    AllSupplier.ThisSupplier = TestItem
    mSupplierList.Add(TestItem);
    TestItem = new clsSupplier();
    TestItem.SupplierID = "91022";
    TestItem.Suppliername = "sean";
    TestItem.OrderArrivedOn = DateTime.Now.Date;
    TestItem.OrderNumber = "7353";
    TestItem.Availability = "true";
    TestItem.Quantity = 4;
    mSupplierList.Add(TestItem);
   }
    public clsSupplierCollection()
    { Int32 Index = 0;
      Int32 RecordCount = 0;
      clsDateCennection DB = new ClsDateConnection();
        DB.Execute("sproc_tblSupplier_SelectAll");
      RecordCount = DB.Count;
    while (Index < RecordCount)
    {
        clsSupplier AnSupplier = new ClsSuppplier();
        AnSupplier.SupplierID = Convert.ToInt32(DB.DateTable.Rows[Index][SupplierID]);
        AnSupplier.SupplierName = Convert.ToString(DB.DateTable.Rows[Index][SupplierName]);
        AnSupplier.OrderArrivedOn = Convert.ToDateTime(DB.DateTable.Rows[Index][OrderArrivedOn]);
        AnSupplier.OrderNumber = Convert.ToInt32(DB.DateTable.Rows[Index][OrderNumber]);
        AnSupplier.Availability = Convert.ToBoolean(DB.DateTable.Rows[Index][Availability]);
        AnSupplier.Quantity = Convert.ToInt32(DB.DateTable.Rows[Index][Quantity]);
        SupplierListok().Add(AnSupplier);
        Index++;

        [TestMethod]
        public void ListAnd CountOk();
       { clsSupplierCollection AllSupplier = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();
            TestItem.SupplierID = "91121";
            TestItem.Suppliername = "sean";
            TestItem.OrderArrivedOn = DateTime.Now.Date;
            TestItem.OrderNumber = "7353";
            TestItem.Availability = "true";
            TestItem.Quantity = 3;
            TestList.Add.Supplier(TestItem);
            AllSupplier.SupplierList = TestList;
            Assert.AreEqual(AllSupplier.Count, TestList.Count);
        }
    }