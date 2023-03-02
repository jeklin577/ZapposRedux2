using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create new instance
        clsOrders anOrderId = new clsOrders();
        //get the data from the session object
        anOrderId = (clsOrders)Session["anOrder"];
        //display the order number for this entry
        Response.Write(anOrderId.orderID);

        //create new instance
        clsOrders aCustomerId= new clsOrders();
        //get the data from the session object
        aCustomerId = (clsOrders)Session["customer"];
        //display the order number for this entry
        Response.Write(aCustomerId.customerID);

        //create new instance
        clsOrders item= new clsOrders();
        //get the data from the session object
        item = (clsOrders)Session["items"];
        //display the order number for this entry
        Response.Write(item.itemNames);

        //create new instance
        clsOrders quantity = new clsOrders();
        //get the data from the session object
        quantity = (clsOrders)Session["itemQuantity"];
        //display the order number for this entry
        Response.Write(quantity.itemQuantity);

        //create new instance
        clsOrders dateAdded = new clsOrders();
        //get the data from the session object
        dateAdded = (clsOrders)Session["date"];
        //display the order number for this entry
        Response.Write(dateAdded.dateAdded);

        //create new instance
        clsOrders delivery = new clsOrders();
        //get the data from the session object
        delivery= (clsOrders)Session["delivery"];
        //display the order number for this entry
        Response.Write(delivery.deliveryAddress);

        //create new instance
        clsOrders dispatch = new clsOrders();
        //get the data from the session object
        dispatch = (clsOrders)Session["dispatch"];
        //display the order number for this entry
        Response.Write(dispatch.readyToDispatch);

    }
}