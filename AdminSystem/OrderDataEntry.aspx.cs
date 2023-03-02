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
  /*
        //create a new instance of clsOrder
        clsOrders anOrderId = new clsOrders();
        //capture the order number
        anOrderId.orderID = txtOrderId.Text;
        //store the order number in the session object
        Session["anOrderId"] = anOrderId;
        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");

        //create a new instance of clsOrder
        clsOrders CustomerId = new clsOrders();
        //capture the order number
        CustomerId.customerID = txtCustomerId.Text;
        //store the order number in the session object
        Session["customer"] = CustomerId;
        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");
  */
        //create a new instance of clsOrder
        clsOrders itemNames = new clsOrders();
        //capture the order number
        itemNames.itemNames = txtItemNames.Text;
        //store the order number in the session object
        Session["items"] = itemNames;
        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");
/*
        //create a new instance of clsOrder
        clsOrders itemQuantity = new clsOrders();
        //capture the order number
        itemQuantity.itemQuantity = txtItemQuantity.Text;
        //store the order number in the session object
        Session["itemQuantity"] = itemQuantity;
        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");

        //create a new instance of clsOrder
        clsOrders dateAdd= new clsOrders();
        //capture the order number
        dateAdd.dateAdded = txtDateAdded.Text;
        //store the order number in the session object
        Session["date"] = dateAdd;
        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");
*/
        //create a new instance of clsOrder
        clsOrders deliveryAddress = new clsOrders();
        //capture the order number
        deliveryAddress.deliveryAddress= txtDeliveryAddress.Text;
        //store the order number in the session object
        Session["delivery"] = deliveryAddress;
        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");
/*
        //create a new instance of clsOrder
        clsOrders readyToDispatch = new clsOrders();
        //capture the order number
        readyToDispatch.readyToDispatch = chkReadyToDispatch.Text;
        //store the order number in the session object
        Session["dispatch"] = readyToDispatch;
        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");
*/
    }
}