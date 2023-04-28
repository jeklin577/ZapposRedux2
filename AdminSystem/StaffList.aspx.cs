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

    protected void Addbtn_Click(object sender, EventArgs e)
    {
        // Indicates a new record
        Session["StaffID"] = -1;
        //redirects to the data entry page
        Response.Redirect("StaffDataEntry.aspx");
    }



    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        // Indicates a new record
        Session["StaffID"] = -1;
        //redirects to the data entry page
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void BtnEdit_Click(object sender, EventArgs e)
    {

        Int32 StaffID;
        if (Stafflst.SelectedIndex != -1)
        {
            StaffID = Convert.ToInt32(Stafflst.SelectedValue);
            Session["StaffID"] = StaffID;
            Response.Redirect("StaffDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please choose a Staff ID";
        }
    }

    protected void BtnClear_Click(object sender, EventArgs e)
    {

        clsStaffCollection Staff = new clsStaffCollection();
        ID = "";
        Stafflst.Text = "";
        Stafflst.DataSource = Staff.StaffList;
        Stafflst.DataValueField = "Staff";
        Stafflst.DataTextField = "FirstName";
        Stafflst.DataBind();

    }

    protected void BtnApply_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staff = new clsStaffCollection();
        ID = "";
        Stafflst.DataSource = Staff.StaffList;
        Stafflst.DataValueField = "StaffID";
        Stafflst.DataTextField = "FirstName";
        Stafflst.DataBind();
    }

    protected void BtnDelete_Click(object sender, EventArgs e)
    {
        Int32 StaffID;
        if (Stafflst.SelectedIndex != -1)
        {
            StaffID = Convert.ToInt32(Stafflst.SelectedValue);
            Session["StaffID"] = StaffID;
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please choose a Staff ID to remove";
        }
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}