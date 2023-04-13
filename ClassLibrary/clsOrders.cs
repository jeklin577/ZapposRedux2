using System;
using System.Collections.Generic;
// using System.Ling;
using System.Text;

namespace ClassLibrary
{
    public class clsOrders
    {

        private Int32 mOrderNo;
        public Int32 OrderNo
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

        private Int32 mCustomerID;
        public int CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }

        private String mItemNames;
        public string ItemNames
        {
            get
            {
                return mItemNames;
            }
            set
            {
                mItemNames = value;
            }
        }

        private Int32 mItemQuantity;
        public int ItemQuantity
        {
            get
            {
                return mItemQuantity;
            }
            set
            {
                mItemQuantity = value;
            }
        }

        private DateTime mDateAdded;
        public DateTime DateAdded
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

        private String mDeliveryAddress;
        public string DeliveryAddress
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

        private Boolean mReadyToDispatch;
        public bool ReadyToDispatch
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

        public bool Find(int OrderNo)
        {
            /* Test Data to check if method was working */
            /*
            mOrderNo = 22;
            mCustomerID = 1533;
            mItemNames = "Jordans";
            mItemQuantity = 3;
            mDateAdded = Convert.ToDateTime("16,09,2023");
            mDeliveryAddress = "110 Menlo Park";
            mReadyToDispatch = true;
            return true;
            */
            
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order no to search for
            DB.AddParameter("@OrderID", OrderNo);
            //execute the stored precedure
            DB.Execute("sproc_tblOrders_FilterByOrderNo");
            //if one record is found
            if (DB.Count == 1)
            {

                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mItemNames = Convert.ToString(DB.DataTable.Rows[0]["ItemNames"]);
                mItemQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["ItemQuantity"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mDeliveryAddress = Convert.ToString(DB.DataTable.Rows[0]["DeliveryAddress"]);
                mReadyToDispatch = Convert.ToBoolean(DB.DataTable.Rows[0]["ReadyToDispatch"]);

                //returns everything which worked
                return true;
            }
            //if no record is found
            else
            {
                //return false indicating a problem
                return false;
            }
            


        }
}
        
    
            /*
            



            //To DO
        //create procedure located above then the find method should work
        //if not then match the variables up with the table variables

     */
    }
