using System;

namespace Testing1
{
    public class clsCustomer
    {
        public string Username { get; set;}

        public bool HasOrder {get; set;}
        public string Password { get; set; }
        public DateTime DateAdded { get; set; }
        public string ShippingAddress { get; internal set; }
        public int CustomerID { 
            
            get
            {
                ///Sends the classes customer ID field?
                return CustomerID;
            }
            
            set
            {
                CustomerID = value;
            }
                
                }

        internal bool Find(int customerID)
        {
            throw new NotImplementedException();
            //CustomerID = 1337;
            //return true;
        }
    }
}