using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        private List<clsOrders> mOrderList;
        clsOrders mThisOrder = new clsOrders();
        public clsOrders ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }
        public List<clsOrders> OrderList
        {
            
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }

        public int Count 
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {

            }
        }

        //Constructor for the class
        public clsOrderCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored precedure
            DB.Execute("sproc_tblOrderProcessing_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //While there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsOrders AnOrder = new clsOrders();
                //read in the fields from the current record
                AnOrder.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnOrder.ItemNames = Convert.ToString(DB.DataTable.Rows[Index]["ItemNames"]);
                AnOrder.ItemQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemQuantity"]);
                AnOrder.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnOrder.DeliveryAddress = Convert.ToString(DB.DataTable.Rows[Index]["DeliveryAddress"]);
                AnOrder.ReadyToDispatch = Convert.ToBoolean(DB.DataTable.Rows[Index]["ReadyToDispatch"]);

            }
            /*
            clsOrders TestItem = new clsOrders();
            TestItem.OrderNo = 22;
            TestItem.CustomerID = 1533;
            TestItem.DeliveryAddress = "110 Menlo Park";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ItemNames = "Jordans";
            TestItem.ItemQuantity = 3;
            //add the item to the test list
            mOrderList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsOrders();
            //set its properties
            TestItem.OrderNo = 17;
            TestItem.CustomerID = 1102;
            TestItem.DeliveryAddress = "222 ";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ItemNames = "Air Force One";
            TestItem.ItemQuantity = 2;
            //add the item to the test list
            mOrderList.Add(TestItem);
            */  
            }


        public int Add()
        {
            mThisOrder.OrderNo = 123;
            return mThisOrder.OrderNo;
            //page 6
        }
    
    
    
    }
}