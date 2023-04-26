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
                txtSize.Text = "";
                txtReleaseDate.Text = "";
                //Initialized to a pound symbol
                txtPrice.Text = "£";
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
        txtPrice.Text = "£" + StockBook.ThisStock.Price.ToString();
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
            //The below code is added so than when a size is a single digit number like 7 or 8 it will be presented to 0 decimal places, so it will be presented
            //as 7 instead of 7.0 which is how sizes are shown everywhere. The code keeps sizes that are of .5 stll to 1 decimal place so 7.5 will still be visible
            // Check if the decimal portion of the size is zero
            if (TestStock.Size % 1 == 0)
            {
                // If the decimal portion is zero, format the size to only show the whole number
                txtSize.Text = TestStock.Size.ToString("0.#");
            }
            else
            {
                // Otherwise, format the size to show one decimal point
                txtSize.Text = TestStock.Size.ToString("0.0");
            }
            txtPrice.Text = "£" + TestStock.Price.ToString();
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
        // Replace pound symbol with empty string
        Price = Price.Replace("£", "");
        string Error = "";



        Error = TestStock.Valid(SneakerName, SneakerDescription, ReleaseDate, Price, Size);

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



    //Although code for the cancel button was not given I am creating one so that it becomes useful. It will basically clear any text entered in the text fields.
    //This helps the user because by using this button there is no need to clear the text fields one by one if the user wants to add a new record using the OK button.
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        clsStock TestStock = new clsStock();
        txtSneakerID.Text = "";
        txtSneakerName.Text = "";
        txtSneakerDescription.Text = "";
        txtReleaseDate.Text = "";
        txtSize.Text = "";
        txtPrice.Text = "£";
        chkSizeAvailable.Checked = false;
    }
}