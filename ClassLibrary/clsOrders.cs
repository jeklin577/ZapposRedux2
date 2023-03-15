using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        //private data member for the orderNo property
        private Int32 mOrderNo;

     public int orderID 
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
     public int customerID { get; set; }
     public string itemNames { get; set; }
     public int itemQuantity { get; set; }
     public DateTime dateAdded { get; set; }
     public string deliveryAddress { get; set; }
     public bool readyToDispatch { get; set; }


    public bool Find(int OrderNo)
        {
            return true;
        }
     
    }
}