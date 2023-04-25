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
            PopulateArray(DB);    
        }


        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderID", mThisOrder.OrderNo);
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@ItemNames", mThisOrder.ItemNames);
            DB.AddParameter("@ItemQuantity", mThisOrder.ItemQuantity);
            DB.AddParameter("@DateAdded", mThisOrder.DateAdded);
            DB.AddParameter("@DeliveryAddress", mThisOrder.DeliveryAddress);
            DB.AddParameter("@ReadyToDispatch", mThisOrder.ReadyToDispatch);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");  
        }

        public void Update()
        {
            //update an existing record based on the values of ThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored precedures
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@ItemNames", mThisOrder.ItemNames);
            DB.AddParameter("@ItemQuantity", mThisOrder.ItemQuantity);
            DB.AddParameter("@DateAdded", mThisOrder.DateAdded);
            DB.AddParameter("@DeliveryAddress", mThisOrder.DeliveryAddress);
            DB.AddParameter("@ReadyToDispatch", mThisOrder.ReadyToDispatch);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblOrder_Update");
        }

        public void Delete()
        {
            //update an existing record based on the values of ThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored precedures
            DB.AddParameter("@OrderID", mThisOrder.OrderNo);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByCustomerID(string CustomerID)
        {
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored precedures
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblOrder_FiterByCustomerID");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mOrderList = new List<clsOrders>();
            while (Index < RecordCount)
            {
                clsOrders AnOrder = new clsOrders();
                //read in the fields from the current record
                AnOrder.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnOrder.ItemNames = Convert.ToString(DB.DataTable.Rows[Index]["ItemNames"]);
                AnOrder.ItemQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemQuantity"]);
                AnOrder.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnOrder.DeliveryAddress = Convert.ToString(DB.DataTable.Rows[Index]["DeliveryAddress"]);
                AnOrder.ReadyToDispatch = Convert.ToBoolean(DB.DataTable.Rows[Index]["ReadyToDispatch"]);
                mOrderList.Add(AnOrder);
                Index++;
            }
        } 


    }
}
