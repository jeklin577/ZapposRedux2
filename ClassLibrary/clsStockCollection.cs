
using System;
using System.Collections.Generic;
namespace ClassLibrary
{
    public class clsStockCollection
    {
        //constructor
        public clsStockCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsStockConnection DB = new clsStockConnection();
            DB.Execute("sproc_tblStock_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsStock TestStock = new clsStock();
                TestStock.SizeAvailable = Convert.ToBoolean(DB.DataTable.Rows[Index]["SizeAvailable"]);
                TestStock.SneakerID = Convert.ToInt32(DB.DataTable.Rows[Index]["SneakerID"]);
                TestStock.SneakerName = Convert.ToString(DB.DataTable.Rows[Index]["SneakerName"]);
                TestStock.SneakerDescription = Convert.ToString(DB.DataTable.Rows[Index]["SneakerDescription"]);
                TestStock.ReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ReleaseDate"]);
                TestStock.Size = Convert.ToInt32(DB.DataTable.Rows[Index]["Size"]);
                TestStock.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);
                mStockList.Add(TestStock);
                Index++;
            }
        }
        List<clsStock> mStockList = new List<clsStock>();
        clsStock mThisStock = new clsStock();
        public List<clsStock> StockList {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }
        public int Count {
            get
            {
                return mStockList.Count;
            }
            set
            {
                //later
            }
                }
        public clsStock ThisStock {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        }


        public int Add()
        {
            clsStockConnection DB = new clsStockConnection();
            DB.AddParameter(@"SneakerName", mThisStock.SneakerName);
            DB.AddParameter(@"SneakerDescription", mThisStock.SneakerDescription);
            DB.AddParameter(@"ReleaseDate", mThisStock.ReleaseDate);
            DB.AddParameter(@"Size", mThisStock.Size);
            DB.AddParameter(@"Price", mThisStock.Price);
            DB.AddParameter(@"SizeAvailable", mThisStock.SizeAvailable);
            return DB.Execute("sproc_tblStock_Insert");
        }
    }
}