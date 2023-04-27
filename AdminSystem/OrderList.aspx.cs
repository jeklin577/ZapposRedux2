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
        if(IsPostBack == false)
        {
            //update the list box
            DisplayOrders();
        }
    }

    protected void lstOrderList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }


    void DisplayOrders()
    {
        clsOrderCollection Orders = new clsOrderCollection();
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderNo";
        lstOrderList.DataTextField = "DeliveryAddress";
        lstOrderList.DataBind();

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //Store -1 into the session object to indicate this is a new record
        Session["OrderID"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 OrderNo;
        //if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            OrderNo = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderID"] = OrderNo;
            //redirect to the edit page
            Response.Redirect("OrderDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }


    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderNo;
        if (lstOrderList.SelectedIndex != -1)
        {
            OrderNo = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderNo"] = OrderNo;
            Response.Redirect("OrderConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByCustomerID (Convert.ToInt32(txtFilter.Text));
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderNo";
        lstOrderList.DataTextField = "CustomerID";
        lstOrderList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByCustomerID(Convert.ToInt32(""));
        txtFilter.Text = "";
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderNo";
        lstOrderList.DataTextField = "CustomerID";
        lstOrderList.DataBind();
    }

    protected void butonEdit_Click(object sender, EventArgs e)
    {

    }
}