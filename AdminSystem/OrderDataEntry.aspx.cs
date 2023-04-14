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

    protected void btnOk_Click(object sender, EventArgs e)
    {
        /*
                //create a new instance of clsOrder
                clsOrders orderInfo = new clsOrders();
                
                //capture the order number
                orderInfo.OrderNo = Convert.ToInt32(txtOrderId.Text);
                //store the order number in the session object
                Session["anOrderId"] = orderInfo;
                //navigate to the viewer page
                Response.Redirect("OrderViewer.aspx");

                orderInfo.CustomerID = Convert.ToInt32(txtCustomerId.Text);
                Session["customer"] = orderInfo;
                Response.Redirect("OrderViewer.aspx");

                orderInfo.ItemNames = txtItemNames.Text;
                Session["items"] = orderInfo;
                Response.Redirect("OrderViewer.aspx");

                orderInfo.ItemQuantity = Convert.ToInt32(txtItemQuantity.Text);
                Session["itemQuantity"] = orderInfo;
                Response.Redirect("OrderViewer.aspx");

                orderInfo.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
                Session["date"] = orderInfo;
                Response.Redirect("OrderViewer.aspx");

                orderInfo.DeliveryAddress = txtDeliveryAddress.Text;
                Session["delivery"] = orderInfo;
                Response.Redirect("OrderViewer.aspx");

                orderInfo.ReadyToDispatch = Convert.ToBoolean(chkReadyToDispatch.Text);
                Session["dispatch"] = orderInfo;
                Response.Redirect("OrderViewer.aspx");
          */      

        clsOrders anOrder = new clsOrders();

        
        //Capture the details
        string orderNo = txtOrderId.Text;
        string customerID = txtCustomerId.Text;
        string itemNames = txtItemNames.Text;
        string itemQuantity = txtItemQuantity.Text;
        string dateAdded = txtDateAdded.Text;
        string deliveryAddress = txtDeliveryAddress.Text;
        

        string Error = "";
        //Validate the data;
        Error = anOrder.Valid(customerID, itemNames, itemQuantity, dateAdded, deliveryAddress);
        if (Error == "")
        {
            anOrder.OrderNo = Convert.ToInt32(txtOrderId.Text);
            anOrder.CustomerID = Convert.ToInt32(txtCustomerId.Text);
            anOrder.ItemNames = txtItemNames.Text; 
            anOrder.ItemQuantity = Convert.ToInt32(txtItemQuantity.Text);
            anOrder.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            anOrder.DeliveryAddress = txtDeliveryAddress.Text;
            anOrder.ReadyToDispatch = Convert.ToBoolean(chkReadyToDispatch.Text);

            //sotre the address in the session object
            Session["anOrder"] = anOrder;
            //Redirect to the viewer page
            Response.Redirect("OrderViewer.aspx");

        } 
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrders anOrder = new clsOrders();
        Boolean Found = false;
        Int32 orderNo;
        orderNo = Convert.ToInt32(txtOrderId.Text);
        Found = anOrder.Find(orderNo);
        if (Found == true)
        {
            txtCustomerId.Text = anOrder.CustomerID.ToString();
            txtItemNames.Text = anOrder.ItemNames;
            txtItemQuantity.Text = anOrder.ItemQuantity.ToString();
            txtDateAdded.Text = anOrder.DateAdded.ToString();
            txtDeliveryAddress.Text = anOrder.DeliveryAddress;
            chkReadyToDispatch.Checked = anOrder.ReadyToDispatch;
        }
    }

}