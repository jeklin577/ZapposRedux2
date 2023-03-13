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
        AnSupplier.SupplierID = txtSupplierID.Text;
        //store the Supplier in the session object
        Session["AnSupplier"] = AnSupplier;
        //navigate to the viewer page 
        Response.Redirect("SupplierViewer.aspx");
    }
}