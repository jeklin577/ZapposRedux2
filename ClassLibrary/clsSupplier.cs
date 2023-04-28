using System;
namespace ClassLibrary
{
    public class clsSupplier
    {
        public DateTime mOrderArrivedOn;
        public Int32 mOrderNumber;
        public Boolean mAvailability;
        public Int32 mQuantity;
        public Int32 mSupplierID;
        public string mSupplierName;

        public string SupplierName { get; set; }
        public DateTime OrderArrivedOn { get; set; }
        public Int32 OrderNumber { get; set; }
        public Boolean Availability { get; set; }
        public Int32 Quantity { get; set; }
        public Int32 Supplier { get; set; }

        public int SupplierID
        {


            get
            {
                return mSupplierID;
            }

            set
            {
                mSupplierID = value;
            }

        }

        //public bool Find(int SupplierID)
        //{
        //    mSupplierID = 65347;
        //    mSupplierName = "Walter Heisenberg";
        //    mOrderArrivedOn = Convert.ToDateTime("17/04/2023");
        //    mOrderNumber = 2;
        //    mAvailability = true;
        //    mQuantity = 23;

        //    return true;



        public bool Find(int SupplierID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierID", SupplierID);
            DB.Execute("sproc_tblSupplier_FilterBySupplierID");
            if (DB.Count == 1)
            {
                mSupplierID = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mOrderArrivedOn = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderArrivedOn"]);
                mOrderNumber = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNumber"]);
                mAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["Availability"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);

                return true;
            }
            else
            {

                return false;
            }
        }
        public string Valid(string SupplierID, string SuppplierName, string OrderArrivedOn, string OrderNumber, string Quantity)
        {
            string Error = "";
            DateTime DateTemp; //Creates a blank DateTime Object

            if (SupplierID.Length == 0)
            {
                Error = Error + "The SupplierID must be longer than 0 Characters long. ";
            }

            if (SupplierID.Length > 50)
            {
                Error = Error + "The SupplierID must be shorter than 50 Characters. ";
            }
            if (SupplierName == SupplierID)
            {
                Error = Error + "SupplierName cannot be identical to SupplierID";
            }
        }
    }
}