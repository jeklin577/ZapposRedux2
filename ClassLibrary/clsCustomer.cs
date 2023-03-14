using System;

namespace Testing1
{
    public class clsCustomer
    {
        public Int32 mCustomerID;

        public string Username { get; set; }

        public bool HasOrder { get; set; }
        public string Password { get; set; }
        public DateTime DateAdded { get; set; }
        public string ShippingAddress { get; set; }
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

        public bool Find(int CustomerID)
        {
            ///   throw new NotImplementedException();
            ///return true;
            mCustomerID = 21;
            return true;
        }
    }
}