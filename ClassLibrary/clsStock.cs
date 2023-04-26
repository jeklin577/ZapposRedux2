using System;
using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;
namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the stock property
        private Int32 mSneakerID;
        private String mSneakerName;
        private String mSneakerDescription;
        private DateTime mReleaaseDate;
        private decimal mSize;
        private decimal mPrice;
        private bool mSizeAvailable;
      
        public int SneakerID {
            get
            {
                return mSneakerID;
            }



            set
            {
                mSneakerID = value;
            }
                }
        public string SneakerName {
            get
            {
                return mSneakerName;
            }

            set
            {
                mSneakerName = value;
            }
        }
        public string SneakerDescription {
            get
            {
                return mSneakerDescription;
            }
            set
            {
                mSneakerDescription = value;
            }
        }
        public DateTime ReleaseDate {
            get
            {
                return mReleaaseDate;
            }
            set
            {
                mReleaaseDate = value;
            }
        }
        public bool SizeAvailable {
            get
            {
                return mSizeAvailable;
            }
            set
            {
                mSizeAvailable = value;
            }
        }
        public decimal Size {
            get
            {
                return mSize;
            }
            set
            {
                mSize = value;
            }
        }
        public decimal Price {
            get
            {
                return mPrice;

            }
            set
            {
                string temp = value.ToString().Replace("£", "");
                mPrice = decimal.Parse(temp);
            }
        }
        
        public bool Find(int SneakerID)
        {
            clsStockConnection DB = new clsStockConnection();
            DB.AddParameter("@SneakerID", SneakerID);
            DB.Execute("sproc_tblStock_FilterBySneakerID");
            if (DB.Count == 1)
            {
                mSneakerID = Convert.ToInt32(DB.DataTable.Rows[0]["SneakerID"]);
                mSneakerName = Convert.ToString(DB.DataTable.Rows[0]["SneakerName"]);
                mSneakerDescription = Convert.ToString(DB.DataTable.Rows[0]["SneakerDescription"]);
                mReleaaseDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ReleaseDate"]);
                mSize = Convert.ToDecimal(DB.DataTable.Rows[0]["Size"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                mSizeAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["SizeAvailable"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string sneakerName, string sneakerDescription, string releaseDate, string Price, string Size)
        {
            String Error = "";
            DateTime DateTemp;
            // Use Regex to remove any non-numeric characters from the Price string
            //The below code is used so that when the OK button is pressed the pound symbol is not included in the validation and we do not get a validation error message of invalid data
            // Use Regex to remove any non-numeric characters from the Price string
            //The below code is used so that when the OK button is pressed the pound symbol is not included in the validation and we do not get a validation error message of invalid data
            Regex rgx = new Regex("[^0-9.£-]");
            Price = rgx.Replace(Price, "");
            if (sneakerName.Length == 0)
            {
                Error = Error + "The sneaker name may not be blank : ";
            }
            if (sneakerName.Length > 50)
            {
                Error = Error + "The sneaker name may not be more than 50 characters : ";
            }

            if (sneakerDescription.Length == 0)
            {
                Error = Error + "The sneaker description may not be blank : ";
            }
            if (sneakerDescription.Length > 250)
            {
                Error = Error + "The sneaker description may not be more than 250 characters : ";
            }

            try
            {
                DateTemp = Convert.ToDateTime(releaseDate);
                if (DateTemp < DateTime.Now.Date.AddYears(-15))
                {
                    Error = Error + "The date cannot be 15 years or more ago : ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The Date is not a valid Date : ";
            }
            try
            {
                decimal TempPrice = Convert.ToDecimal(Price, CultureInfo.InvariantCulture);

                if (TempPrice < decimal.Zero)
                {
                    Error = Error + "The price cannot be less than 0 : ";
                }
                if (TempPrice > Convert.ToDecimal(1000000.00))
                {
                    Error = Error + "The price cannot be more than 1 million : ";
                }
            }
            catch
            {
                Error = Error + "Price is not valid : ";
            }
            try
            {
                decimal TempSize = Convert.ToDecimal(Size);
                if (TempSize < Convert.ToDecimal(3))
                {
                    Error = Error + "The minimum size available is 3UK : ";
                }
                if (TempSize > Convert.ToDecimal(17))
                {
                    Error = Error + "The maximum size available is 17UK : ";
                }
            }
            catch
            {
                Error = Error + "Size is not valid : ";
            }

            return Error;
        }


    }
}