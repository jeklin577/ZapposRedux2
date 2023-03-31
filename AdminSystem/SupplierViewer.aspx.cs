﻿using System;
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
        clsSupplier instance = new clsSupplier();

        //craete a new instance of the calss
        clsSupplier AnSupplier = new clsSupplier();
        //get the data from the session object
        AnSupplier = (clsSupplier)Session["AnSupplier"];
        //dispaly the house number on the page
        Response.Write(AnSupplier.SupplierID);


        //craete a new instance of the calss
        clsSupplier clsSupplier = new clsSupplier();
        //get the data from the session object
        AnSupplier = (clsSupplier)Session["Supplier"];
        //dispaly the house number on the page
        Response.Write(AnSupplier.SupplierName);


        //craete a new instance of the calss
        clsSupplier clsSupplier = new clsSupplier();
        //get the data from the session object
        AnSupplier = (clsSupplier)Session["Order"];
        //dispaly the house number on the page
        Response.Write(AnSupplier.OrderArrivedOn);
    }
}