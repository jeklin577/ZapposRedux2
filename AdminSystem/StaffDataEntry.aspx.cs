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
        // Captures the Staff ID
        Session["TestStaffID"] = TestStaffID;
        // Stores StaffID in the Session Object
        Response.Redirect("StaffViewer.aspx");
        // Naviagates to Viewer Page
    }
}