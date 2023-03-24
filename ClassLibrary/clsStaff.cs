using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private int mStaffID;
        private string mFirstName;
        private string mLastName;
        private object mGender;
        private DateTime mDateHired;
        private decimal mSalary;
        private int mAge;

        public int StaffID
        {
            get
            {
                return mStaffID;
                //Sends data out of the Property
            }
            set
            {
                mStaffID = value;
                //Allows data into the Property
            }
        }

        public string FirstName
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
            }
        }
        public object Gender
        {
            get
            {
                return mGender;
            }
            set
            {
                mGender = value;
            }
        }
        public DateTime DateHired
        {
            get
            {
                return mDateHired;
            }
            set
            {
                mDateHired = value;
            }
        }
        public decimal Salary
        {
            get
            {
                return mSalary;
            }
            set
            {
                mSalary = value;
            }
        }
        public int Age
        {
            get
            {
                return mAge;
            }
            set
            {
                mAge = value;
            }
        }
         
        public bool Find(int StaffID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order no to search for
            DB.AddParameter("@StaffID", StaffID);
            //execute the stored precedure
            DB.Execute("sproc_tblStaff_FilterByStaffID");
            //if one record is found
            if (DB.Count == 1)
            {

                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mDateHired = Convert.ToDateTime(DB.DataTable.Rows[0]["DateHired"]);
                mSalary = Convert.ToDecimal(DB.DataTable.Rows[0]["Salary"]);
                mAge = Convert.ToInt32(DB.DataTable.Rows[0]["Age"]);
                mGender = Convert.ToBoolean(DB.DataTable.Rows[0]["Gender"]);

                //returns everything which worked
                return true;
            }

            else
            {
                //return false indicating a problem
                return false;
            }



        }

        public string Valid(string firstName, string lastName, string dateHired, string salary, string age)
        {
            return "";
        }
    }
}