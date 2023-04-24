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
        public int Count {
            get { return mCustomerList.Count; }


            set { }
        }
        public clsCustomer ThisCustomer { get; set; }


        public List<clsCustomer> CustomerList
        {
            get { return mCustomerList; }

            set { mCustomerList = value; }

        }



        //Constructor
        public clsCustomerCollection()
        {
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

        }

    }
}
