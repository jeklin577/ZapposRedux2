using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack == false)
        {
            DisplayStock();
        }
    }
    void DisplayStock()
    {
        clsStockCollection TestStock = new clsStockCollection();
        lstStockList.DataSource = TestStock.StockList;
        lstStockList.DataValueField = "SneakerID";
        lstStockList.DataValueField = "SneakerName";
        lstStockList.DataBind();
    }
}