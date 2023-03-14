using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public Int32 mCustomerID;
        public String mPassword;
        public DateTime mDateAdded;
        public string mShippingAddress;
        public Boolean mHasOrder;
        public String mUsername; // reorganize these, this is messy, should be in the same order as the associated methods below

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
            // mCustomerID = 21;
            // return true; 
            //Lines 33-34 were the original, lines 35-36 were part of the hardcoded solution
            //*  mCustomerID = 21;
            //     mPassword = "Password";
            //     mShippingAddress = "51 One Fifty Street";
            //      mDateAdded = Convert.ToDateTime("16/9/2015");
            //        mHasOrder = true;
            //            return true;
            //Lines 43-49 were part of another, more complete hardcoded solution

            clsDataConnection DB = new clsDataConnection(); //Creates an instance of a class that allows for connection to the database (?)
            DB.AddParameter("@CustomerID", CustomerID); ///Adds the parameter of customer ID to our instance, this'lll be used when running the find procedure we wrote earlier
            DB.Execute("sproc_tblCustomer_FilterByCusID");
            if (DB.Count == 1) ///If a record was found (IE, the searched for customer ID was present in the table);
            {
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mUsername = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mShippingAddress = Convert.ToString(DB.DataTable.Rows[0]["ShippingAddress"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["JoinDate"]);
                ///All these basically do the same thing, they make the fields of the instance of the object the same as the record we find, converting into
                /// appropriate data types

                return true;
            }

            else { return false; } ///Failsafe, if no record gets found, then the find method has failed, so we return false;



        }
    }
}