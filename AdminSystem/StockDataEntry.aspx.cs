using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 SneakerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        SneakerID = Convert.ToInt32(Session["SneakerID"]);
        if(IsPostBack == false)
        {
            if(SneakerID != -1)
            {
                DisplayStock();
                //The below empty strings are used so that when the page is first displayed, these text fields are intialised to empty
                //The reason is that before thes the text fields were initialised to 0.
                txtSneakerID.Text = "";
                txtPrice.Text = "";
                txtSize.Text = "";
                txtReleaseDate.Text = "";
            }
        }

    }
    void DisplayStock()
    {
        clsStockCollection StockBook = new clsStockCollection();
        StockBook.ThisStock.Find(SneakerID);
        txtSneakerID.Text = StockBook.ThisStock.SneakerID.ToString();
        txtSneakerName.Text = StockBook.ThisStock.SneakerName;
        txtSneakerDescription.Text = StockBook.ThisStock.SneakerDescription;
        txtReleaseDate.Text = StockBook.ThisStock.ReleaseDate.ToString("dd/MM/yyyy");
        txtSize.Text = StockBook.ThisStock.Size.ToString();
        txtPrice.Text = StockBook.ThisStock.Price.ToString();
        chkSizeAvailable.Checked = StockBook.ThisStock.SizeAvailable;
    }

    


    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock TestStock = new clsStock();
        Int32 SneakerID;
        Boolean Found = false;
        SneakerID = Convert.ToInt32(txtSneakerID.Text);
        Found = TestStock.Find(SneakerID);
        if (Found == true)
        {
            txtSneakerName.Text = TestStock.SneakerName;
            txtSneakerDescription.Text = TestStock.SneakerDescription;
            txtReleaseDate.Text = TestStock.ReleaseDate.ToString("dd/MM/yyyy");
            txtSize.Text = TestStock.Size.ToString();
            txtPrice.Text = TestStock.Price.ToString();
            chkSizeAvailable.Checked = TestStock.SizeAvailable;
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instnce of clsStock
        clsStock TestStock = new clsStock();
       
        string SneakerName = txtSneakerName.Text;
        string SneakerDescription = txtSneakerDescription.Text;
        string ReleaseDate = txtReleaseDate.Text;
        string Size = txtSize.Text;
        string Price = txtPrice.Text;
        string Error = "";


        Error = TestStock.Valid(SneakerName, SneakerDescription, ReleaseDate);
        if (Error == "")
        {
            TestStock.SneakerID = SneakerID;
            TestStock.SneakerName = SneakerName;
            TestStock.SneakerDescription = SneakerDescription;
            TestStock.ReleaseDate = Convert.ToDateTime(ReleaseDate);
            TestStock.Size = Convert.ToDecimal(Size);
            TestStock.Price = Convert.ToDecimal(Price);
            TestStock.SizeAvailable = chkSizeAvailable.Checked;
            clsStockCollection StockList = new clsStockCollection();
            if(SneakerID == -1)
            {
                StockList.ThisStock = TestStock;
                StockList.Add();
            }
            else
            {
                StockList.ThisStock.Find(SneakerID);
                StockList.ThisStock = TestStock;
                StockList.Update();
            }

            Response.Redirect("StockList.aspx");
           
        }
        else
        {
            lblError.Text = Error;
        }
       
    }
}