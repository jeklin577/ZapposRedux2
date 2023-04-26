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
			string TestData = Convert.ToInt32 1;
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
		public void SpplierNoMinLessOne()
		{
			clsSpplier ASpplier = new clsSpplier();
			String Error = "";
			string SpplierNo = "";
			Error = ASpplier.Valid(StockNo, SpplierId, DateAdded, SpplierItems, SpplierDescription);
			Assert.AreNotEqual(Error, "");
		}
		[TestMethod]
		public void SpplierNoMin()
		{
			//create an instance of the class we want to create
			clsSpplier ASpplier = new clsSpplier();
			String Error = "";
			string SpplierNo = "a";
			Error = ASpplier.Valid(SpplierNo, SpplierId, DateAdded, SpplierItems, SpplierDescription);
			Assert.AreEqual(Error, "");

		}
		[TestMethod]
		public void SpplierNoMinPlusOne()
		{
			clsSpplier ASpplier = new clsSpplier();
			String Error = "";
			string SpplierNo = "aa";
			Error = AStock.Valid(SpplierNo, SpplierId, DateAdded, SpplierItems, SpplierDescription);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]
		public void SpplierNoMaxLessOne()
		{
			clsSpplier ASpplier = new clsSpplier();
			String Error = "";
			string SpplierNo = "aaaa";
			Error = ASpplier.Valid(SpplierNo, SpplierId, DateAdded, SpplierItems, SpplierDescription);
			Assert.AreEqual(Error, "");

		}
		[TestMethod]
		public void SpplierNoMax()
		{
			clsSpplier ASpplier = new clsSpplier();
			String Error = "";
			string SpplierNo = "aaaa";
			Error = AStock.Valid(SpplierNo, SpplierId, DateAdded, SpplierItems, SpplierDescription);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]
		public void SpplierNoMid()
		{
			clsSpplier ASpplier = new clsSpplier();
			String Error = "";
			string SpplierNo = "aaa";
			Error = ASpplier.Valid(SpplierNo, SpplierId, DateAdded, SpplierItems, SpplierDescription);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]

		public void SpplierNoMaxPlusOne()
		{
			clsSpplier AStock = new clsSpplier();
			String Error = "";
			string SpplierNo = "aaaaaaa";
			Error = ASpplier.Valid(SpplierNo, SpplierId, DateAdded, SpplierItems, SpplierDescription);
			Assert.AreNotEqual(Error, "");

		}
		[TestMethod]
		public void SpplierNoExtremeMax()
		{
			clsStock ASpplier = new clsSpplier();
			String Error = "";
			string Stock No = "";
			Stock No = ASpplier.PadRight(500, 'a');
			Error = ASpplier.Valid(SpplierNo, Id, DateAdded, SpplierItems, SpplierDescription);
			Assert.AreNotEqual(Error, "");
		}
		[TestMethod]
		public void SpplierItemsMinLessOne()
		{
			clsSpplier ASpplier = new clsSpplier();
			String Error = "";
			string SpplierItems = "";
			Error = ASpplier.Valid(SpplierNo, SpplierId, DateAdded, SpplierItems, SpplierDescription);
			Assert.AreNotEqual(Error, "");
		}
		[TestMethod]
		public void SpplierItemsMin()
		{
			//create an instance of the class we want to create
			clsSpplier ASpplier = new clsSpplier();
			String Error = "";
			string StockItems = "a";
			Error = ASpplierValid(SpplierNo, SpplierId, DateAdded, SpplierItems, SpplierDescription);
			Assert.AreEqual(Error, "");

		}
		[TestMethod]
		public void SpplierItemsMinPlusOne()
		{
			clsSpplier ASpplier = new clsSpplier();
			String Error = "";
			string SpplierItems = "aa";
			Error = ASpplier.Valid(SpplierNo, SpplierId, DateAdded, SpplierItems, SpplierDescription);
			Assert.AreEqual(Error, "");
		}

		[TestMethod]
		public void SpplierItemsMaxLessOne()
		{
			clsSpplier ASpplier = new clsSSpplier();
			String Error = "";
			string SpplierItems = "aaaa";
			Error = ASpplier.Valid(StockNo, SpplierId, DateAdded, SpplierItems, SpplierDescription);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]
		public void StockItemsMax()
		{
			clsSpplier ASpplier = new clsStock();
			String Error = "";
			string StockItems = "aaaa";
			Error = AStock.Valid(StockNo, StockId, DateAdded, StockItems, StockDescription);
			Assert.AreEqual(Error, "");

		}
		[TestMethod]

		public void StockItemsMaxPlusOne()
		{
			clsStock AStock = new clsSpplier();
			String Error = "";
			string SpplierItems = "aaaaaaa";
			Error = ASpplier Valid(SpplierNo, SpplierId, DateAdded, SpplierItems, SpplierDescription);
			Assert.AreNotEqual(Error, "");

		}

		[TestMethod]
		public void SpplierItemsMid()
		{
			clsSpplier AStock = new clsSpplier();
			String Error = "";
			string SpplierItems = "aaa";
			Error = ASpplier.Valid(StockNo, SpplierId, DateAdded, SpplierItems, SpplierDescription);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]
		public void SpplierItemsExtremeMax()
		{
			clsSpplier ASpplier = new clsSpplier();
			String Error = "";
			string Items = "";
			StockNo = ASpplier.PadRight(500, 'a');
			Error = ASpplier.Valid(StockNo, SpplierId, DateAdded, SpplierItems, SpplierDescription);
			Assert.AreNotEqual(Error, "");
		}
		[TestMethod]
		public void SpplierDescriptionMinLessOne()
		{
			clsSpplier ASpplier = new clsSpplier();
			String Error = "";
			string SpplierDescription = "";
			Error = ASpplier.Valid(StockNo, SpplierId, DateAdded, SpplierItems, SpplierDescription);
			Assert.AreNotEqual(Error, "");
		}
		[TestMethod]
		public void SpplierkDescriptionMin()
		{
			//create an instance of the class we want to create
			clsStock ASpplier = new clsSpplier();
			String Error = "";
			stringSpplierDescription = "a";
			Error = ASpplier Valid(SpplierNo, SpplierId, DateAdded, SpplierItems, SpplierDescription);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]
		public void SpplierDescriptionMinPlusOne()
		{
			clsSpplier ASpplier = new clsSpplier();
			String Error = "";
			string SpplierDescription = "aa";
			Error = ASpplier.Valid(StockNo, StockId, DateAdded, StockItems, StockDescription);
			Assert.AreEqual(Error, "");

		}
		[TestMethod]
		public void SpplierDescriptionMaxLessOne()
		{
			clsSpplierASpplier = new clsSpplier();
			String Error = "";
			string SpplierDescription = "aaaa";
			Error = ASpplier.Valid(SpplierNo, SpplierId, DateAdded, SpplierItems, SpplierDescription);
			Assert.AreEqual(Error, "");

		}
		[TestMethod]
		public void SpplierDescriptionMax()
		{
			clsSpplier ASpplier = new clsSpplier();
			String Error = "";
			string SpplierDescription = "aaaa";
			Error = ASpplier.Valid(StockNo, StockId, DateAdded, StockItems, StockDescription);
			Assert.AreEqual(Error, "");

		}
		[TestMethod]
		public void SpplierDescriptionMid()
		{
			clsSpplier ASpplier = new clsSpplier();
			String Error = "";
			string SpplierDescription = "aaa";
			Error = ASpplier.Valid(SpplierNo, SpplierId, DateAdded, SpplierItems, SpplierDescription);
			Assert.AreEqual(Error, "");

		}
		[TestMethod]
		public void SpplierDescriptionMaxPlusOne()
		{
			clsSpplier ASpplier new clsSpplier();
			String Error = "";
			string SpplierDescription = "aaaaaa";
			Error = ASpplier.Valid(SpplierNo, StockId, DateAdded, StockItems, StockDescription);
			Assert.AreEqual(Error, "");

		}
		[TestMethod]
		public void SpplierDescriptionExtremeMax()
		{
			clsSpplier ASpplier = new clsStock();
			String Error = "";
			string StockNo = "";
			StockNo = ASpplier.PadRight(500, 'a');
			Error = ASpplier.Valid(StockNo, StockId, DateAdded, StockItems, StockDescription);
			Assert.AreNotEqual(Error, "");
		}


	}
}
}
