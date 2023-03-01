using System;

namespace Testing1
{
    public class clsCustomer
    {
        public int orderID {get; set;}
        public int  customerID {get; set;}
        public string itemNames {get; set; }
        public int itemQuantity {get; set; }
        public DateTime dateAdded {get; internal set; }
        public bool readyToDispatch {get; internal set; }
    }
}