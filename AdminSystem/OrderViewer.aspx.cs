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
        clsOrders instance = new clsOrders();
        
        //get the data from the session object
        instance = (clsOrders)Session["orderNo"];
        //display the order number for this entry
        Response.Write(instance.OrderNo);

        //get the data from the session object
        instance = (clsOrders)Session["customer"];
        //display the order number for this entry
        Response.Write(instance.CustomerID);

        //get the data from the session object
        instance= (clsOrders)Session["items"];
        //display the order number for this entry
        Response.Write(instance.ItemNames);

        //get the data from the session object
        instance= (clsOrders)Session["itemQuantity"];
        //display the order number for this entry
        Response.Write(instance.ItemQuantity);

        //get the data from the session object
        instance= (clsOrders)Session["date"];
        //display the order number for this entry
        Response.Write(instance.DateAdded);

        //get the data from the session object
        instance= (clsOrders)Session["delivery"];
        //display the order number for this entry
        Response.Write(instance.DeliveryAddress);

        //get the data from the session object
        instance= (clsOrders)Session["dispatch"];
        //display the order number for this entry
        Response.Write(instance.ReadyToDispatch);




        //create a new instance of clsStock
        clsStock TestStock = new clsStock();
        //get the data from the session object
        TestStock = (clsStock)Session["TestStock"];
        //display the Sneaker ID for this entry
        Response.Write(TestStock.SneakerID);
    }
}