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
			Error = AnSupplier.Valid(SpplierId, SupplierName, OrderArrivedOn, OrderNumber, Availability, Quantity);
			Assert.AreNotEqual(Error, "");
		}
		[TestMethod]
		public void SupplierIDMin()
		{
			//create an instance of the class we want to create
			clsSupplier AnSupplier = new clsSupplier();
			String Error = "";
			string SupplierID = "aa";
			Error = AnSupplier.Valid(SpplierId, SupplierName, OrderArrivedOn, OrderNumber, Availability, Quantity);
			Assert.AreEqual(Error, "");

		}
		[TestMethod]
		public void SupplierIDMinPlusOne()
		{
			clsSupplier AnSupplier = new clsSupplier();
			String Error = "";
			string SupplierNo = "aa";
			Error = AnSupplier.Valid(SpplierId, SupplierName, OrderArrivedOn, OrderNumber, Availability, Quantity);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]
		public void SupplierIDMaxLessOne()
		{
			clsSupplier AnSupplier = new clsSupplier();
			String Error = "";
			string SupplierID = "aaaa";
			Error = AnSupplier.Valid(SpplierId, SupplierName, OrderArrivedOn, OrderNumber, Availability, Quantity);
			Assert.AreEqual(Error, "");

		}
		[TestMethod]
		public void SupplierNoMax()
		{
			clsSupplier AnSupplier = new clsSupplier();
			String Error = "";
			string SupplierID = "aaaa";
			Error = AnSupplier.Valid(SpplierId, SupplierName, OrderArrivedOn, OrderNumber, Availability, Quantity);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]
		public void SupplierNoMid()
		{
			clsSupplier AnSupplier = new clsSupplier();
			String Error = "";
			string SupplierID = "aaa";
			Error = AnSupplier.Valid(SpplierId, SupplierName, OrderArrivedOn, OrderNumber, Availability, Quantity);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]

		public void SupplierIDMaxPlusOne()
		{
			clsSupplier AnSupplier = new clsSupplier();
			String Error = "";
			string SupplierID = "aaaaaaa";
			Error = AnSupplier.Valid(SpplierId, SupplierName, OrderArrivedOn, OrderNumber, Availability, Quantity);
			Assert.AreNotEqual(Error, "");

		}
		[TestMethod]
		public void SupplierNameExtremeMax()
		{
			clsSupplier AnSupplier = new clsSupplier();
			String Error = "";
			string SupplierName = "";
			SupplierID = AnSupplier.PadRight(500, 'a');
			Error = AnSupplier.Valid(SupplierId, SupplierName, OrderArrivedOn, OrderNumber, Availability, Quantity);
			Assert.AreNotEqual(Error, "");
		}
		[TestMethod]
		public void SupplierNameMinLessOne()
		{
			clsSupplier AnSupplier = new clsSupplier();
			String Error = "";
			string SupplierName = "";
			Error = AnSupplier.Valid(SupplierId, SupplierName, OrderArrivedOn, OrderNumber, Availability, Quantity);
			Assert.AreNotEqual(Error, "");
		}
		[TestMethod]
		public void SupplierNameMin()
		{
			//create an instance of the class we want to create
			clsSupplier ASupplier = new clsSupplier();
			String Error = "";
			string SupplierName = "a";
			Error = AnSupplierValid(SupplierId, SupplierName, OrderArrivedOn, OrderNumber, Availability, Quantity);
			Assert.AreEqual(Error, "");

		}
		[TestMethod]
		public void SupplierNameMinPlusOne()
		{
			clsSupplier AnSupplier = new clsSupplier();
			String Error = "";
			string SupplierName = "aa";
			Error = AnSupplier.Valid(SupplierId, SupplierName, OrderArrivedOn, OrderNumber, Availability, Quantity);
			Assert.AreEqual(Error, "");
		}

		[TestMethod]
		public void SupplierNameMaxLessOne()
		{
			clsSupplier AnSupplier = new clsSupplier();
			String Error = "";
			string SupplierItems = "aaaa";
			Error = AnSupplier.Valid(SupplierId, SupplierName, OrderArrivedOn, OrderNumber, Availability, Quantity);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]
		public void SupplierNameMax()
		{
			clsSupplier AnSupplier = new clsSupplier();
			String Error = "";
			string SupplierName = "aaaa";
			Error = AnSupplier.Valid(SupplierId, SupplierName, OrderArrivedOn, OrderNumber, Availability, Quantity);
			Assert.AreEqual(Error, "");

		}
		[TestMethod]

		public void SupplierNameMaxPlusOne()
		{
			clsSupplier AnSupplier = new clsSpplier();
			String Error = "";
			string SpplierName = "aaaaaaa";
			Error = AnSupplier.Valid(SupplierId, SupplierName, OrderArrivedOn, OrderNumber, Availability, Quantity);
			Assert.AreNotEqual(Error, "");

		}

		[TestMethod]
		public void SupplierNameMid()
		{
			clsSupplier AnSupplier = new clsSupplier();
			String Error = "";
			string SpplierItems = "aaa";
			Error = AnSupplier.Valid(SupplierId, SupplierName, OrderArrivedOn, OrderNumber, Availability, Quantity);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]
		public void SupplierItemsExtremeMax()
		{
			clsSupplier AnSupplier = new clsSupplier();
			String Error = "";
			string Items = "";
			SupplierID = AnSupplier.PadRight(500, 'a');
			Error = AnSupplier.Valid(SupplierId, SupplierName, OrderArrivedOn, OrderNumber, Availability, Quantity);
			Assert.AreNotEqual(Error, "");
		}
		[TestMethod]
		public void OrderArrivedOnMinLessOne()
		{
			clsSupplier AnSupplier = new clsSupplier();
			String Error = "";
			string OrderArrivedOn = "";
			Error = AnSupplier.Valid(SupplierId, SupplierName, OrderArrivedOn, OrderNumber, Availability, Quantity);
			Assert.AreNotEqual(Error, "");
		}
		[TestMethod]
		public void OrderArrivedOnMin()
		{
			//create an instance of the class we want to create
			clsSupplier AnSupplier = new clsSupplier();
			String Error = "";
			stringOrderArrivedOn = "a";
			Error = AnSupplier.Valid(SpplierId, SupplierName, OrderArrivedOn, OrderNumber, Availability, Quantity);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]
		public void OrderArrivedOnMinPlusOne()
		{
			clsSupplier AnSupplier = new clsSupplier();
			String Error = "";
			string SupplierDescription = "aa";
			Error = AnSupplier.Valid(SpplierId, SupplierName, OrderArrivedOn, OrderNumber, Availability, Quantity);
			Assert.AreEqual(Error, "");

		}
		[TestMethod]
		public void OrderArrivedOnMaxLessOne()
		{
			clsSpplier AnSupplier = new clsSupplier();
			String Error = "";
			string SupplierDescription = "aaaa";
			Error = AnSupplier.Valid(SpplierId, SupplierName, OrderArrivedOn, OrderNumber, Availability, Quantity);
			Assert.AreEqual(Error, "");

		}
		[TestMethod]
		public void OrderArrivedOnMax()
		{
			clsSupplier AnSupplier = new clsSupplier();
			String Error = "";
			string OrderArrivedOn = "aaaa";
			Error = AnSupplier.Valid(SpplierId, SupplierName, OrderArrivedOn, OrderNumber, Availability, Quantity);
			Assert.AreEqual(Error, "");

		}
		[TestMethod]
		public void SupplierDescriptionMid()
		{
			clsSupplier AnSupplier = new clsSupplier();
			String Error = "";
			string SpplierDescription = "aaa";
			Error = AnSupplier.Valid(SpplierId, SupplierName, OrderArrivedOn, OrderNumber, Availability, Quantity);
			Assert.AreEqual(Error, "");

		}
		[TestMethod]
		public void OrderArrivedOnMaxPlusOne()
		{
			clsSupplier AnSupplier = new clsSupplier();
			String Error = "";
			string SupplierDescription = "aaaaaa";
			Error = AnSupplier.Valid(SpplierId, SupplierName, OrderArrivedOn, OrderNumber, Availability, Quantity);
			Assert.AreEqual(Error, "");

		}
		[TestMethod]
		public void SupplierDescriptionExtremeMax()
		{
			clsSupplier AnSupplier = new clsSupplier();
			String Error = "";
			string SupplierID = "";
			SupplierID = AnSupplier.PadRight(500, 'a');
			Error = AnSupplier.Valid(SpplierId, SupplierName, OrderArrivedOn, OrderNumber, Availability, Quantity);
			Assert.AreNotEqual(Error, "");
		}


	}
}
