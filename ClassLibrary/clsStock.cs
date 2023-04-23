using System;
using System.Diagnostics;

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
                mPrice = value;
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

        public string Valid(string sneakerName, string sneakerDescription, string releaseDate, string size, string price)
        {
            String Error = "";
            DateTime DateTemp;
            
           
            
                if (sneakerName.Length == 0)
                {
                    Error = Error + "The sneaker name may not be blank : ";
                }
                if (sneakerName.Length > 50)
                {
                    Error = Error + "The sneaker name may not be more than 50 characters";
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
                //LOCAL VAR
                 DateTemp = Convert.ToDateTime(releaseDate);
                if (DateTemp < DateTime.Now.Date.AddYears(-200))
                {
                    Error = Error + "The date cannot be 201 years or more ago : ";
                }
                if(DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The Date is not a valid Date. ";
            }

            if (size.Length > 4)
            {
                Error = Error + "Enter a suitable size number";
            }
            if(size.Length == 0)
            {
                Error = Error + "Enter a suitable size number : ";
            }
            if (price.Length == 0)
            {
                Error = Error + "The price must not be blank : ";
            }
            if (price.Length > 4)
            {
                Error = Error + "The price must not be more than 4 characters : ";
            }


            return Error;
        }
                                
    }
}