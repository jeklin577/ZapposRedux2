using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaff TestStaff = new clsStaff();
        // Creates a new instance of clsStaff
        String StaffID = txtStaffID.Text;
        String FirstName = txtFirstName.Text;
        String LastName = txtLastName.Text;
        String Gender = ddlGender.Text;
        String DateHired = txtDateHired.Text;
        String Salary = txtSalary.Text;
        String Age = txtAge.Text;
        String Error = "";
        Error = TestStaff.Valid(FirstName, LastName, DateHired, Salary, Age);
        if (Error == "")
        {

            TestStaff.StaffID = Convert.ToInt32(txtStaffID.Text);
            TestStaff.FirstName = txtFirstName.Text;
            TestStaff.LastName = txtLastName.Text;
            TestStaff.Gender = ddlGender.Text;
            TestStaff.DateHired = Convert.ToDateTime(txtDateHired.Text);
            TestStaff.Salary = Convert.ToInt32(txtSalary.Text);
            TestStaff.Age = Convert.ToInt32(txtAge.Text);
            clsStaffCollection StaffList = new clsStaffCollection();
            StaffList.ThisStaff = TestStaff;
            StaffList.Add();

            // Captures attribute Inputs
            Session["TestStaff"] = TestStaff;
            // Stores StaffID in the Session Object
            Response.Redirect("StaffList.aspx");
            // Naviagates to Viewer Page

        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaff TestStaff = new clsStaff(); 
        //Creates new instance of a Staff
        Int32 StaffID;
        //Variable to Store the PK
        Boolean Found = false; 
        //Variable to Store the Find Operation
        StaffID = Convert.ToInt32(txtStaffID.Text);
        //Gets the PK Entered by User
        Found = TestStaff.Find(StaffID);
        //Finds Record
        if (Found == true)
        {
            //Displays Values of Properties in the Form
            txtStaffID.Text = TestStaff.StaffID.ToString();
            txtFirstName.Text = TestStaff.FirstName;
            txtLastName.Text = TestStaff.LastName;
            txtDateHired.Text = TestStaff.DateHired.ToString();
            ddlGender.Text = TestStaff.Gender.ToString();
            txtSalary.Text = TestStaff.Salary.ToString();
            txtAge.Text = TestStaff.Age.ToString();

            lblError.Text = "Staff ID Found!";
        }
        else
        {

            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtDateHired.Text = "";
            ddlGender.Text = "";
            txtSalary.Text = "";
            txtAge.Text = "";

            lblError.Text = "Staff ID Not Found!";
        }

    }
}
    
