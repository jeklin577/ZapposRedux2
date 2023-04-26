using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
	[TestClass]
	public class tstSupplier
	{
		[TestMethod]
		public void InstanceOK()
		{
			//create an instance of the class we want to create 
			clsSupplier AnSupplier = new clsSupplier();
			//test to see thta it exists
			Assert.IsNotNull(AnSupplier);
		}
		[TestMethod]
		public void SupplierIDPropertyOK()
		{
			clsSupplier AnSupplier = new clsSupplier();
			Int32 TestData = 1;
			AnSupplier.SupplierID = TestData;
			Assert.AreEqual(AnSupplier.SupplierID, TestData);
		}
		[TestMethod]
		public void OrderNumberPropertyOK()
		{
			clsSupplier TestSupplier = new clsSupplier();
			Int32 TestNumber = 1;
			TestSupplier.OrderNumber = TestNumber;
			Assert.AreEqual(TestSupplier.OrderNumber, TestNumber);


		}
		[TestMethod]
		public void SupplierNamePropertyOK()
		{
			clsSupplier AnSupplier = new clsSupplier();
			string TestData = Convert.ToInt32 ;
			AnSupplier.SupplierName = TestData;
			Assert.AreEqual(AnSupplier.SupplierName, TestData);


		}
		[TestMethod]
		public void OrderArrivedOnPropertyOK()
		{
			clsSupplier AnSupplier = new clsSupplier();
			DateTime TestData = DateTime.Now.Date;
			AnSupplier.OrderArrivedOn = TestData;
			Assert.AreEqual(AnSupplier.OrderArrivedOn, TestData);
		}
		[TestMethod]
		public void AvailabilityPropertyOK()
		{
			clsSupplier AnSupplier = new clsSupplier();
			Boolean TestData = true;
			AnSupplier.Availability = TestData;
			Assert.AreEqual(AnSupplier.Availability, TestData);
		}

		[TestMethod]
		public void QuantityPropertyOK()
		{
			clsSupplier AnSupplier = new clsSupplier();
			Int32 TestData = 1;
			AnSupplier.Quantity = TestData;
			Assert.AreEqual(AnSupplier.Quantity, TestData);
		}

		[TestMethod]
		public void SupplierIDMinLessOne()
		{
			clsSupplier AnSupplier = new clsSupplier();
			String Error = "";
			string SupplierID = "a";
			Error = ASupplier.Valid(SpplierId, DateAdded, SpplierItems, SpplierDescription);
			Assert.AreNotEqual(Error, "");
		}
		[TestMethod]
		public void SupplierIDMin()
		{
			//create an instance of the class we want to create
			clsSupplier ASupplier = new clsSupplier();
			String Error = "";
			string SupplierID = "aa";
			Error = ASupplier.Valid(SpplierNo, SpplierId, DateAdded, SpplierItems, SpplierDescription);
			Assert.AreEqual(Error, "");

		}
		[TestMethod]
		public void SupplierIDMinPlusOne()
		{
			clsSupplier ASupplier = new clsSupplier();
			String Error = "";
			string SupplierNo = "aa";
			Error = ASupplier.Valid(SupplierId, DateAdded, SupplierItems, SupplierDescription);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]
		public void SupplierIDMaxLessOne()
		{
			clsSupplier ASupplier = new clsSupplier();
			String Error = "";
			string SupplierID = "aaaa";
			Error = ASupplier.Valid(SpplierId, DateAdded, SpplierItems, SpplierDescription);
			Assert.AreEqual(Error, "");

		}
		[TestMethod]
		public void SupplierNoMax()
		{
			clsSupplier ASupplier = new clsSupplier();
			String Error = "";
			string SupplierID = "aaaa";
			Error = ASupplier.Valid(SpplierId, DateAdded, SpplierItems, SpplierDescription);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]
		public void SupplierNoMid()
		{
			clsSupplier ASupplier = new clsSupplier();
			String Error = "";
			string SupplierID = "aaa";
			Error = ASupplier.Valid(SpplierId, DateAdded, SpplierItems, SpplierDescription);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]

		public void SupplierIDMaxPlusOne()
		{
			clsSupplier ASupplier = new clsSupplier();
			String Error = "";
			string SupplierID = "aaaaaaa";
			Error = ASupplier.Valid(SupplierId, DateAdded, SpplierItems, SpplierDescription);
			Assert.AreNotEqual(Error, "");

		}
		[TestMethod]
		public void SupplierIDExtremeMax()
		{
			clsSupplier ASupplier = new clsSupplier();
			String Error = "";
			string SupplierID = "";
			SupplierID = ASupplier.PadRight(500, 'a');
			Error = ASupplier.Valid(SupplierID, DateAdded, SpplierItems, SpplierDescription);
			Assert.AreNotEqual(Error, "");
		}
		[TestMethod]
		public void SupplierNameMinLessOne()
		{
			clsSupplier ASupplier = new clsSupplier();
			String Error = "";
			string SupplierName = "";
			Error = ASupplier.Valid(SupplierId, DateAdded, SpplierName, SpplierDescription);
			Assert.AreNotEqual(Error, "");
		}
		[TestMethod]
		public void SupplierNameMin()
		{
			//create an instance of the class we want to create
			clsSupplier ASupplier = new clsSupplier();
			String Error = "";
			string SupplierName = "a";
			Error = ASupplierValid(SupplierID, DateAdded, SpplierItems, SpplierDescription);
			Assert.AreEqual(Error, "");

		}
		[TestMethod]
		public void SupplierNameMinPlusOne()
		{
			clsSupplier ASupplier = new clsSupplier();
			String Error = "";
			string SupplierName = "aa";
			Error = ASupplier.Valid(SupplierId, DateAdded, SpplierItems, SpplierDescription);
			Assert.AreEqual(Error, "");
		}

		[TestMethod]
		public void SupplierNameMaxLessOne()
		{
			clsSupplier ASupplier = new clsSupplier();
			String Error = "";
			string SupplierItems = "aaaa";
			Error = ASupplier.Valid(SupplierId, DateAdded, SpplierItems, SpplierDescription);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]
		public void SupplierNameMax()
		{
			clsSupplier ASupplier = new clsSupplier();
			String Error = "";
			string SupplierName = "aaaa";
			Error = ASupplier.Valid(, DateAdded, StockItems, StockDescription);
			Assert.AreEqual(Error, "");

		}
		[TestMethod]

		public void SupplierNameMaxPlusOne()
		{
			clsSupplier ASupplier = new clsSpplier();
			String Error = "";
			string SpplierName = "aaaaaaa";
			Error = ASupplier Valid(SupplierId, DateAdded, SpplierItems, SpplierDescription);
			Assert.AreNotEqual(Error, "");

		}

		[TestMethod]
		public void SupplierNameMid()
		{
			clsSupplier ASupplier = new clsSupplier();
			String Error = "";
			string SpplierItems = "aaa";
			Error = ASupplier.Valid(SupplierId, DateAdded, SupplierItems, SupplierDescription);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]
		public void SupplierItemsExtremeMax()
		{
			clsSupplier ASupplier = new clsSupplier();
			String Error = "";
			string Items = "";
			SupplierID = ASupplier.PadRight(500, 'a');
			Error = ASupplier.Valid( SupplierId, DateAdded, SpplierItems, SpplierDescription);
			Assert.AreNotEqual(Error, "");
		}
		[TestMethod]
		public void OrderArrivedOnMinLessOne()
		{
			clsSupplier ASupplier = new clsSupplier();
			String Error = "";
			string OrderArrivedOn = "";
			Error = ASupplier.Valid(SupplierId, DateAdded, SpplierItems, OrderArrivedOn);
			Assert.AreNotEqual(Error, "");
		}
		[TestMethod]
		public void OrderArrivedOnMin()
		{
			//create an instance of the class we want to create
			clsSupplier ASupplier = new clsSupplier();
			String Error = "";
			stringOrderArrivedOn = "a";
			Error = ASupplier Valid(SpplierId, DateAdded, SpplierItems, SpplierDescription);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]
		public void OrderArrivedOnMinPlusOne()
		{
			clsSupplier ASupplier = new clsSupplier();
			String Error = "";
			string SupplierDescription = "aa";
			Error = ASupplier.Valid(StockNo, StockId, DateAdded, StockItems, StockDescription);
			Assert.AreEqual(Error, "");

		}
		[TestMethod]
		public void OrderArrivedOnMaxLessOne()
		{
			clsSpplier ASupplier = new clsSupplier();
			String Error = "";
			string SupplierDescription = "aaaa";
			Error = ASupplier.Valid( SpplierId, DateAdded, SpplierItems, SpplierDescription);
			Assert.AreEqual(Error, "");

		}
		[TestMethod]
		public void OrderArrivedOnMax()
		{
			clsSupplier ASupplier = new clsSupplier();
			String Error = "";
			string OrderArrivedOn = "aaaa";
			Error = ASupplier.Valid( StockId, DateAdded, StockItems, StockDescription);
			Assert.AreEqual(Error, "");

		}
		[TestMethod]
		public void SupplierDescriptionMid()
		{
			clsSupplier ASupplier = new clsSupplier();
			String Error = "";
			string SpplierDescription = "aaa";
			Error = ASupplier.Valid( SupplierId, DateAdded, SpplierItems, SpplierDescription);
			Assert.AreEqual(Error, "");

		}
		[TestMethod]
		public void OrderArrivedOnMaxPlusOne()
		{
			clsSupplier ASupplier new clsSupplier();
			String Error = "";
			string SupplierDescription = "aaaaaa";
			Error = ASupplier.Valid(SupplierNo, StockId, DateAdded, StockItems, StockDescription);
			Assert.AreEqual(Error, "");

		}
		[TestMethod]
		public void SupplierDescriptionExtremeMax()
		{
			clsSupplier AnSupplier = new clsSupplier();
			String Error = "";
			string SupplierID = "";
			SupplierID = AnSupplier.PadRight(500, 'a');
			Error = AnSupplier.Valid(StockNo, StockId, DateAdded, StockItems, StockDescription);
			Assert.AreNotEqual(Error, "");
		}


	}
}
}
