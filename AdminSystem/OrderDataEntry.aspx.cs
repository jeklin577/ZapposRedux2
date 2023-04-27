using ClassLibrary;
using System;

public partial class _1_DataEntry : System.Web.UI.Page
{

    //Variable to store the primary key with page level scope
    Int32 OrderNo;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the order to be processed
        OrderNo = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (OrderNo != -1)
            {
                //Display the current data for the record
                //DisplayOrder(); Hi harry, sorry about this, needed to comment this line out to run some of my unit tests
            }
        }
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
            anOrder.ReadyToDispatch = Convert.ToBoolean(chkReadyToDispatch.Checked);

            //create a new instance of the address collection
            clsOrderCollection OrderList = new clsOrderCollection();
            //set the ThisOrder property
            OrderList.ThisOrder = anOrder;
            //add the new record
            OrderList.Add();

            //store the address in the session object
            Session["anOrder"] = anOrder;
            //Redirect to the viewer page
            Response.Redirect("OrderList.aspx");


            //if this is a new record i.e OrderNo = -1 then add the data
            if (OrderNo == -1)
            {
                //set the ThisOrder property
                OrderList.ThisOrder = anOrder;
                //Add the new record
                OrderList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                OrderList.ThisOrder.Find(OrderNo);
                //set the ThisOrder property
                OrderList.ThisOrder = anOrder;
                //update the record
                OrderList.Update();
            }
            //redirect back to the listpage
            Response.Redirect("OrderList.aspx");
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


    protected void chkReadyToDispatch_CheckedChanged(object sender, EventArgs e)
    {

    }
}