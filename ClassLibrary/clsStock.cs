using System;

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
            mSneakerID = 21;
            mSneakerName = "Jordan 1";
            mSneakerDescription = "Brand new Jordans....";
            mReleaaseDate = Convert.ToDateTime("16/09/2015");
            mSize = Convert.ToDecimal(42.5);
            mPrice = Convert.ToDecimal(220);
            mSizeAvailable = Convert.ToBoolean(true);
            return true;
        }
    }
}