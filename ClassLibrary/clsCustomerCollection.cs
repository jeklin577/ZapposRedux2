using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{


    public class clsCustomerCollection
    {






        List<clsCustomer> mCustomerList = new List<clsCustomer>(); //defines a field, every instance of the customer collection class starts with mCustomer list.
        clsCustomer mThisCustomer = new clsCustomer();
        public int Count
        {
            get { return mCustomerList.Count; }


            set { }
        }
        public clsCustomer ThisCustomer { 
            
            get { return mThisCustomer;  }
            
            set { mThisCustomer = value; }
        
        }


        public List<clsCustomer> CustomerList
        {
            get { return mCustomerList; }

            set { mCustomerList = value; }

        }




        //Add Method



        //Constructor
        public clsCustomerCollection()
        {
            /*
            clsCustomer TestItem = new clsCustomer();


            TestItem.HasOrder = true;
            TestItem.ShippingAddress = "123 Street Street";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Password = "Password";
            TestItem.Username = "Dave";
            TestItem.CustomerID = 5;
            mCustomerList.Add(TestItem);

            clsCustomer TestItem2 = new clsCustomer();


            TestItem2.HasOrder = true;
            TestItem2.ShippingAddress = "123 Street Street";
            TestItem2.DateAdded = DateTime.Now.Date;
            TestItem2.Password = "Password";
            TestItem2.Username = "Dave";
            TestItem2.CustomerID = 5;

            mCustomerList.Add(TestItem2);
            */

            //Deprecated method that used hard coding, preserved for posterity

            
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll"); ///Well, we found another culprit, remember to directly copy and paste procedure names
            PopulateArray(DB); //( there was some coed here, it was basically transplanted down int othe PopulateArray method)
        }

        public int Add()
        {
            //mThisCustomer.CustomerID = 1;
            //return mThisCustomer.CustomerID; (more hard coded badness)

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Username", mThisCustomer.Username);
            DB.AddParameter("@JoinDate", mThisCustomer.DateAdded);
            DB.AddParameter("@ShippingAddress", mThisCustomer.ShippingAddress);
            DB.AddParameter("@HasOrder", mThisCustomer.HasOrder);
            DB.AddParameter("@Password", mThisCustomer.Password);

            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@Username", mThisCustomer.Username);
            DB.AddParameter("@JoinDate", mThisCustomer.DateAdded);
            DB.AddParameter("@ShippingAddress", mThisCustomer.ShippingAddress);
            DB.AddParameter("@HasOrder", mThisCustomer.HasOrder);
            DB.AddParameter("@Password", mThisCustomer.Password);

            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.Execute("sproc_tblCustomer_Delete");
        }


        public void ReportByUsername(string Username)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Username", Username);
            DB.Execute("sproc_tblCustomer_FilterByUsername");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mCustomerList = new List<clsCustomer>();
            while (Index < RecordCount)
            {
                clsCustomer TestCust = new clsCustomer();
                TestCust.HasOrder = Convert.ToBoolean(DB.DataTable.Rows[Index]["HasOrder"]);
                TestCust.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                TestCust.Username = Convert.ToString(DB.DataTable.Rows[Index]["Username"]);
                TestCust.ShippingAddress = Convert.ToString(DB.DataTable.Rows[Index]["ShippingAddress"]);
                TestCust.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                TestCust.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["JoinDate"]);
                
                mCustomerList.Add(TestCust);
                Index++;
            }
        }

    }
}
