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

        public string Valid(string customerID, string itemNames, string itemQuantity, string dateAdded, string deliveryAddress)
        {
            //create the string variable to store the error
            String Error = "";
            DateTime DateTemp;
    
            if (customerID.Length == 0)
            {
                //Record the error
                Error = Error + "The Customer ID must not be blank : ";
            }
            //if the customer ID is greater than 6 characters
            if (customerID.Length > 6)
            {
                Error = Error + "The customer ID must not be more than 6 characters : ";
            }
            //Date
            try
            {
                DateTemp = Convert.ToDateTime(dateAdded);
                //Check to see if the date is less than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The Date cannot be in the past : ";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The Date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The Date is not valid Date. ";
            }

         //Item Names
            if (itemNames.Length ==0)
            {
                Error = Error + "The Item names must not be blank : ";
            }
            if (itemNames.Length > 9)
            {
                Error = Error + "The Item names must be less than 9 characters: ";
            }
        //Delivery Address
            if (deliveryAddress.Length == 0)
            {
                Error = Error + "The Delivery Address must not be blank : ";
            }
            if (deliveryAddress.Length > 40)
            {
                Error = Error + "The Delivery Address names must be less than 40 characters: ";
            }
        //Item Quantity
            if (itemQuantity.Length == 0)
            {
                Error = Error + "The Item Quantity must not be blank : ";
            }
            if (itemQuantity.Length > 9)
            {
                Error = Error + "The Item Quantity must be less than 9 : ";
            }

            //return any error messages
            return Error;
        }



    }
}
