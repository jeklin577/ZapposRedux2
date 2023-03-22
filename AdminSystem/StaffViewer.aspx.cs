using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff TestStaffID = new clsStaff();
        // Creates a new instance of clsStaff
        TestStaffID = (clsStaff)Session["TestStaffID"];
        // Gets the Data from the Session Object
        Response.Write(TestStaffID.StaffID);
        // Displays the StaffID for this Entry
    }
}