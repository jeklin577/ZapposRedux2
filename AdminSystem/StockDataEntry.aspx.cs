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

 

   
    




    protected void Button1_Click(object sender, EventArgs e)
    {
        //create a new instnce of clsStock
        clsStock TestStock = new clsStock();
        //capture the sneaker id
        TestStock.SneakerID = Convert.ToInt32(txtSneakerID.Text);
      
        //store the address in the session object
        Session["TestStock"] = TestStock;
        //navigate to the viewer page
        Response.Redirect("StockViewer.aspx");
    }





    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}