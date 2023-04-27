using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            //updates list box
            DisplayStaff();
        }
    }

    void DisplayStaff()
    {
        clsStaffCollection Staff = new clsStaffCollection();
        //create new instance of class
        Stafflst.DataSource = Staff.StaffList;
        //set data sourceto list
        Stafflst.DataValueField = "StaffID";
        //set datafield to display
        Stafflst.DataTextField = "FirstName";
        //bind data to list
        Stafflst.DataBind();
    }
}