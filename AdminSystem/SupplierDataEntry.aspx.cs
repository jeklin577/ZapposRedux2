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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //craete a new instance of clsSupplier
        clsSupplier AnSupplier = new clsSupplier();
        //capture the SupplierID
        AnSupplier.SupplierID = Convert.ToInt32(txtSupplierID.Text);
        AnSupplier.SupplierName = Convert.ToString(txtSupplierName.Text);
        AnSupplier.OrderArrivedOn = Convert.ToDateTime(txtOrderArrivedOn.Text);
        AnSupplier.OrderNumber = Convert.ToInt32(OrderNumber.Text);
        //store the Supplier in the session object
        Session["AnSupplier"] = AnSupplier;
        //navigate to the viewer page 
        Response.Redirect("SupplierViewer.aspx");

        ////craete a new instance of clsSupplier
        //clsSupplier SupplierName = new clsSupplier();
        ////capture the SupplierName
        //SupplierName.SupplierName = txtSupplierName.Text;
        ////store the Supplier in the session object
        //Session["Supplier"] = AnSupplier;
        ////navigate to the viewer page 
        //Response.Redirect("SupplierViewer.aspx");

        ////craete a new instance of clsSupplier
        //clsSupplier OrderArrivedOn = new clsSupplier();
        ////capture the OrderArrivedOn
        //OrderArrivedOn.OrderArrivedOn = txtOrderArrivedOn.Text;
        ////store the Supplier in the session object
        //Session["Order"] = OrderArrivedOn;
        ////navigate to the viewer page 
        //Response.Redirect("SupplierViewer.aspx");

        ////craete a new instance of clsSupplier
        //clsSupplier OrderNumber = new clsSupplier();
        ////capture the OrderNumber
        //OrderNumber.OrderNumber = txtOrderNumber.Text;
        ////store the Supplier in the session object
        //Session["Order"] = OrderNumber;
        ////navigate to the viewer page 
        //Response.Redirect("SupplierViewer.aspx");

        ////craete a new instance of clsSupplier
        //clsSupplier Availability = new clsSupplier();
        ////capture the Availability
        //Availability.Availability = txtAvailability.Text;
        ////store the Supplier in the session object
        //Session["Availability"] = OrderNumber;
        ////navigate to the viewer page 
        //Response.Redirect("SupplierViewer.aspx");

        ////craete a new instance of clsSupplier
        //clsSupplier Quantity = new clsSupplier();
        ////capture the Quantity
        //Quantity.Quantity = txtQuantity.Text;
        ////store the Supplier in the session object
        //Session["Quantity"] = OrderNumber;
        ////navigate to the viewer page 
        //Response.Redirect("SupplierViewer.aspx");
    }
}