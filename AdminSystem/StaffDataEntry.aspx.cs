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
        clsStaff TestStaffID = new clsStaff();
        // Creates a new instance of clsStaff
        TestStaffID.StaffID = Convert.ToInt32(txtStaffID.Text);
        TestStaffID.FirstName = txtFirstName.Text;
        TestStaffID.LastName = txtLastName.Text;
        TestStaffID.Gender = ddlGender.Text;
        TestStaffID.DateHired = Convert.ToDateTime(txtDateHired.Text);
        TestStaffID.Salary = Convert.ToInt32(txtSalary.Text);
        TestStaffID.Age = Convert.ToInt32(txtAge.Text);
        // Captures attribute Inputs
        Session["TestStaff"] = TestStaffID;
        // Stores StaffID in the Session Object
        Response.Redirect("StaffViewer.aspx");
        // Naviagates to Viewer Page
        
    }
}