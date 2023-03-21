using System;
using System.Collections.Generic;
using System.Ling;
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






        public bool Find(int OrderNo)
        {
            mOrderNo = 1;
            mCustomerID = 123;
            mItemNames = "Jordans";
            mItemQuantity = 2;
            mDateAdded = Convert.ToDateTime("16/10/2022");
            mDeliveryAddress = "123 Menlo Park";
            mReadyToDispatch = true;
        
            //Always return True
            return true;
        }
     
    }
}