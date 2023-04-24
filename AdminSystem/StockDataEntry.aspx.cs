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














    protected void Button2_Click(object sender, EventArgs e)
    {

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
            txtReleaseDate.Text = TestStock.ReleaseDate.ToString();
            txtSize.Text = TestStock.Size.ToString();
            txtPrice.Text = TestStock.Price.ToString();
            chkSizeAvailable.Checked = TestStock.SizeAvailable;
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instnce of clsStock
        clsStock TestStock = new clsStock();
        string SneakerID = txtSneakerID.Text;
        string SneakerName = txtSneakerName.Text;
        string SneakerDescription = txtSneakerDescription.Text;
        string ReleaseDate = txtReleaseDate.Text;
        string Size = txtSize.Text;
        string Price = txtPrice.Text;
        string Error = "";
        Error = TestStock.Valid(SneakerName, SneakerDescription, ReleaseDate, Size, Price);
        if (Error == "")
        {
            TestStock.SneakerName = SneakerName;
            TestStock.SneakerDescription = SneakerDescription;
            TestStock.ReleaseDate = Convert.ToDateTime(ReleaseDate);
            TestStock.Size = Convert.ToInt32(Size);
            TestStock.Price = Convert.ToInt32(Price);

            Session["TestStock"] = TestStock;
            Response.Write("StockViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }
}