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

   

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 SneakerID;
        if(lstStockList.SelectedIndex != -1)
        {
            SneakerID = Convert.ToInt32(lstStockList.SelectedValue);
            Session["SneakerID"] = SneakerID;
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 SneakerID;
        if(lstStockList.SelectedIndex != 1)
        {
            SneakerID = Convert.ToInt32(lstStockList.SelectedValue);
            Session["SneakerID"] = SneakerID;
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStockCollection Stock = new clsStockCollection();
        Stock.ReportBySneakerName(txtEnter.Text);
        lstStockList.DataSource = Stock.StockList;
        lstStockList.DataValueField = "SneakerID";
        lstStockList.DataTextField = "SneakerName";
        lstStockList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStockCollection Stock = new clsStockCollection();
        Stock.ReportBySneakerName("");
        txtEnter.Text = "";
        lstStockList.DataSource = Stock.StockList;
        lstStockList.DataValueField = "SneakerID";
        lstStockList.DataTextField = "SneakerName";
        lstStockList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["SneakerID"] = -1;
        Response.Redirect("StockDataEntry.aspx");
    }
}