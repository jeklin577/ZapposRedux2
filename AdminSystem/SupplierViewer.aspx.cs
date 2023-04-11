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
        clsSupplier TestSupplier = new clsSupplier();
        //get the data from the session object
        TestSupplier = (clsSupplier)Session["Order"];
        //dispaly the house number on the page
        Response.Write(AnSupplier.OrderArrivedOn);


        //craete a new instance of the calss
        //     clsSupplier AnSupplier = new clsSupplier(); //Hi Sabur, Sean here, i commented this and line 48 out, you've already created an instance of clsSupplier named "AnSupplier", so trying to create another causes an error when i try to run my page, the rest of your code should still function, but please delete these lines.
        //dispaly the house number on the page
        //get the data from the session object
        AnSupplier = (clsSupplier)Session["Order"];  
        Response.Write(AnSupplier.OrderNumber);


        //craete a new instance of the calss
 //       clsSupplier AnSupplier = new clsSupplier();  
        //get the data from the session object
        AnSupplier = (clsSupplier)Session["Available"];
        //dispaly the house number on the page
        Response.Write(AnSupplier.Availability);


        //craete a new instance of the calss
        clsSupplier clsSupplier1 = new clsSupplier();
        //get the data from the session object
        TestSupplier = (clsSupplier)Session["Quantity"];
        //dispaly the house number on the page
        Response.Write(AnSupplier.Quantity);
    }
}