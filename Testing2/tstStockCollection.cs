﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Assert.IsNotNull(AllStock);
        }
        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.SizeAvailable = true;
            TestItem.SneakerID = 1;
            TestItem.SneakerDescription = "aa";
            TestItem.SneakerName = "aa";
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.Size = 4;
            TestItem.Price = 100;
            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.StockList, TestList);

                }
      
        [TestMethod]
        public void ThisStockPropertyOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestStock = new clsStock();
            TestStock.SizeAvailable = true;
            TestStock.SneakerID = 1;
            TestStock.SneakerName = "aa";
            TestStock.SneakerDescription = "aa";
            TestStock.ReleaseDate = DateTime.Now.Date;
            TestStock.Size = 4;
            TestStock.Price = 100;
            AllStock.ThisStock = TestStock;
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.SizeAvailable = true;
            TestItem.SneakerID = 1;
            TestItem.SneakerName = "aa";
            TestItem.SneakerDescription = "aa";
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.Size = 4;
            TestItem.Price = 100;
            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }
       [TestMethod]
       public void AddMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.SizeAvailable = true;
            TestItem.SneakerID = 1;
            TestItem.SneakerName = "aa";
            TestItem.SneakerDescription = "aa";
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.Size = 4;
            TestItem.Price = 100;
            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            TestItem.SneakerID = PrimaryKey;
            AllStock.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            //set properties
            TestItem.SizeAvailable = true;
            TestItem.SneakerName = "aa";
            TestItem.SneakerDescription = "aa";
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.Size = 4;
            TestItem.Price = 100;
            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            TestItem.SneakerID = PrimaryKey;
            //modify test data
            TestItem.SizeAvailable = false;
            TestItem.SneakerName = "bb";
            TestItem.SneakerDescription = "bb";
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.Size = 6;
            TestItem.Price = 300;
            AllStock.ThisStock = TestItem;
            //update
            AllStock.Update();
            AllStock.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.SneakerID = 1;
            TestItem.SizeAvailable = true;
            TestItem.SneakerName = "aa";
            TestItem.SneakerDescription = "aa";
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.Size = 4;
            TestItem.Price = 100;
            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            TestItem.SneakerID = PrimaryKey;
            AllStock.ThisStock.Find(PrimaryKey);
            AllStock.Delete();
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportBySneakerNameMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStockCollection FilteredStock = new clsStockCollection();
            FilteredStock.ReportBySneakerName("xxxx");
            Assert.AreEqual(0, FilteredStock.Count);
        }
        [TestMethod]
        public void ReportBySneakerNameTestDataFound()
        {
            clsStockCollection FilteredStock = new clsStockCollection();
            Boolean OK = true;
            FilteredStock.ReportBySneakerName("Nike Air Force 1");
            if(FilteredStock.Count == 2)
            {
                if(FilteredStock.StockList[0].SneakerID != 38)
                {
                    OK = false;
                }
                if(FilteredStock.StockList[1].SneakerID != 39)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
