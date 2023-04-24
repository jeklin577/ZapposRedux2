using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 SneakerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        SneakerID = Convert.ToInt32(Session["SneakerID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsStockCollection TestStock = new clsStockCollection();
        TestStock.ThisStock.Find(SneakerID);
        TestStock.Delete();
        Response.Redirect("StockList.aspx");
    }


    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StocList.aspx");
    }
}