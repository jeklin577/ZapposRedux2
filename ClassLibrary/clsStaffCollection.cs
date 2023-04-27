using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {

        private List<clsStaff> mStaffList;

        public List<clsStaff> StaffList
        //public prop from the address list
        {
            get
            {
                //return private data
                return mStaffList;

            }
            set
            {
                //set private data
                mStaffList = value;
            }
        }

        public int Count
        {
            get
            {
                //returns count of list
                return mStaffList.Count;
            }

            set
            {
                //later
            }
        }

        public clsStaff ThisStaff { get; set; }
    }

}