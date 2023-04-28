using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        private List<clsStaff> mStaffList;

        clsStaff mThisStaff = new clsStaff();

        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }
        public List<clsStaff> StaffList
        {

            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }

        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {
                //later
            }
        }

        //Constructor for the class
        public clsStaffCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored precedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records

        }


        public int Add()
        {

            clsDataConnection DB = new clsDataConnection();
            //
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@Gender", mThisStaff.Gender);
            DB.AddParameter("@Salary", mThisStaff.Salary);
            DB.AddParameter("@Age", mThisStaff.Age);
            DB.AddParameter("@DateHired", mThisStaff.DateHired);

            return DB.Execute("sproc_tblStaff_Insert");


        }
        public void update()
        {

            clsDataConnection DB = new clsDataConnection();
            //
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@Gender", mThisStaff.Gender);
            DB.AddParameter("@Salary", mThisStaff.Salary);
            DB.AddParameter("@Age", mThisStaff.Age);
            DB.AddParameter("@DateHired", mThisStaff.DateHired);
            //executes the stored procedure
            DB.Execute("sproc_tblStaff_Insert");

        }

    }
    }