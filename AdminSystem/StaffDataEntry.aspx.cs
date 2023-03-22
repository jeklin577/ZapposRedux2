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
        clsStaff TestStaff = new clsStaff();
        // Creates a new instance of clsStaff
        TestStaff = (clsStaff)Session["TestStaff"];
        // Gets the Data from the Session Object
        Response.Write(TestStaff.FirstName);
        // Displays the StaffID for this Entry

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaff TestStaff = new clsStaff();
        // Creates a new instance of clsStaff
        TestStaff.FirstName = "FirstName";
        // Captures the Staff ID
        Session["TestStaff"] = TestStaff;
        // Stores StaffID in the Session Object
        Response.Redirect("StaffViewer.aspx");
        // Naviagates to Viewer Page
    }
}