using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
using Testing1;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer CustomerInfo = new clsCustomer();
        CustomerInfo = (clsCustomer)Session["CustomerInfo"];
        Response.Write("The customer's name is: " + CustomerInfo.Username);
        Response.Write("<br>");
        Response.Write("The customer's password is: " + CustomerInfo.Password + " This is very secure, and a very, VERY good idea!");
        Response.Write("<br>");
        Response.Write("The Customer's shipping address is: " + CustomerInfo.ShippingAddress);


    }
}