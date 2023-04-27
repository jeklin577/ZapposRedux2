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
            //creates a string var to store error
            String Error = "";
            //creates temp var to store data val
            DateTime DateTemp;
            //if the First Name is blank
            if (firstName.Length == 0)
            {
                Error = Error + "First Name Must Be Entered  :  ";
                //records error msg
            }
            //if the First Name is greater than 50 chara
            if (firstName.Length > 50)
            {
                Error = Error + "First Name Must Be Less Than 50 Characters  :  ";
                //records error msg
            }
            //if the Last Name is blank
            if (lastName.Length == 0)
            {
                Error = Error + "Last Name Must Be Entered  :  ";
                //records error msg
            }
            //if the Last Name is greater than 50 chara
            if (lastName.Length > 50)
            {
                Error = Error + "Last Name Must Be Less Than 50 Characters  :  ";
                //records error msg
            }
            try
            {
                decimal Tempsalary = Convert.ToDecimal(salary);

                if (Tempsalary < decimal.Zero)
                {
                    Error = Error + "Salary cannot be less than 0 : ";
                }
                if (Tempsalary > Convert.ToDecimal(1000000))
                {
                    Error = Error + "The Salary cannot be more than 10000000 : ";
                }
                //if the Last Name is blank
                if (salary.Length == 0)
                {
                    Error = Error + "Salary Must Be Entered  :  ";
                    //records error msg
                }
                }
            catch
            {
            }
                try
                {

                DateTemp = Convert.ToDateTime(dateHired);
                if (DateTemp < DateTime.Now.Date)
                //checks if the date is todays date
                {
                    Error = Error + "The Date Cannot Be Set In the Past  :  ";
                    //records error msg
                }
                if (DateTemp > DateTime.Now.Date)
                //checks the date isnt greater
                {
                    Error = Error + "The Date Cannot Be Set In the Future  :  ";
                    //records error msg
                }
            }

            catch
            {
                Error = Error + "The Date Was Not Valid  :  ";
                //records error
            }
            try
            {
                int Tempage = Convert.ToInt32(age);

                if (Tempage < 0)
                {
                    Error = Error + "Age cannot be less than 0 : ";
                }
                if (Tempage > Convert.ToInt32(100))
                {
                    Error = Error + "The Salary cannot be more than 100 : ";
                }
                //if the Last Name is blank
                if (age.Length == 0)
                {
                    Error = Error + "Enter an Age  :  ";
                }
            }
            catch
            { 
                
                }
                return Error;
            //return error msg
        }
    }
}
    

    

    


