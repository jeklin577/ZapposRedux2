using System;
using System.Collections.Generic;
//using System.Ling;
using System.Text;

namespace ClassLibrary
{
    public class clsOrders
    {
        //private data member for the orderNo property
        private Int32 mOrderNo;
        private Int32 mCustomerID;
        private String mItemNames;
        private Int32 mItemQuantity;
        private DateTime mDateAdded;
        private String mDeliveryAddress;
        private Boolean mReadyToDispatch;

     public Int32 orderID 
        {
            get
            {
                return mOrderNo;
            }
            set
            {
                mOrderNo = value;
            }
        }
     public int customerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID= value;
            }
        }
        public string itemNames
        {
            get
            {
                return mItemNames;
            }
            set
            {
                mItemNames= value;
            }
        }
        public int itemQuantity
        {
            get
            {
                return mItemQuantity;
            }
            set
            {
                mItemQuantity= value;
            }
        }
        public DateTime dateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }       
    public string deliveryAddress
        {
            get
            {
                return mDeliveryAddress;
            }
            set
            {
                mDeliveryAddress = value;
            }
        }


    public bool readyToDispatch
        {
            get
            {
                return mReadyToDispatch;
            }
            set
            {
                mReadyToDispatch = value;
            }
        }


        
        //CREATE PROCEDURE sproc_tblOrderProcessing
        //@OrderNo int
        //AS
        // select * from tblOrderProcessing where OrderNo = @OrderNo



        //To DO
        //create procedure located above then the find method should work
        //if not then match the variables up with the table variables

        /*
        public bool Find(int OrderNo)
        {
            //create an instance of the data connection
            clsOrders DB = new clsOrders();
            //add the parameter for the order no to search for
            DB.AddParameter("@OrderNo", OrderNo);
            //execute the stored precedure
            DB.Execute("sproc_tblOrder_FilterByOrderNo");
            //if one record is found
            if (DB.Count == 1)
            {

                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["customerId"]);
                mItemNames = Convert.ToString(DB.DataTable.Rows[0]["itemNo"]);
                mItemQuantity = Convert.ToString(DB.DataTable.Rows[0]["itemQuantity"]);
                mDateAdded = Convert.ToString(DB.DataTable.Rows[0]["dateAdded"]);
                mDeliveryAddress = Convert.ToDateTime(DB.DataTable.Rows[0]["deliveryAddress"]);
                mReadyToDispatch = Convert.ToBoolean(DB.DataTable.Rows[0]["readyToDispatch"]);

                //returns everything which worked
                return true;
            }

            else 
            {
                //return false indicating a problem
                return false; 
            }
            
           }
     */
    }
}