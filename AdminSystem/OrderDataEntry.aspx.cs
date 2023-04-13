using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
  
        //create a new instance of clsOrder
        clsOrders orderInfo = new clsOrders();
        //capture the order number
        orderInfo.OrderNo = Convert.ToInt32(txtOrderId.Text);
        //store the order number in the session object
        Session["anOrderId"] = orderInfo;
        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");


        //capture the order number
        orderInfo.CustomerID = Convert.ToInt32(txtCustomerId.Text);
        //store the order number in the session object
        Session["customer"] = orderInfo;
        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");

        //capture the order number
        orderInfo.ItemNames = txtItemNames.Text;
        //store the order number in the session object
        Session["items"] = orderInfo;
        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");

        //capture the order number
        orderInfo.ItemQuantity = Convert.ToInt32(txtItemQuantity.Text);
        //store the order number in the session object
        Session["itemQuantity"] = orderInfo;
        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");

        //capture the order number
        orderInfo.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
        //store the order number in the session object
        Session["date"] = orderInfo;
        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");

        //capture the order number
        orderInfo.DeliveryAddress = txtDeliveryAddress.Text;
        //store the order number in the session object
        Session["delivery"] = orderInfo;
        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");

        //capture the order number
        orderInfo.ReadyToDispatch = Convert.ToBoolean(chkReadyToDispatch.Text);
        //store the order number in the session object
        Session["dispatch"] = orderInfo;
        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");

    }
}