using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

/// This is probably dumb and bad for a myriad of reasons but despite having clsCustomer literally inside the class library folder, using ClassLibrary; just isn't recognizing the clsCustomer class
/// So i'm doing this, i'm also pretty sure we previously had our clsCustomer class file in the wrong location, so we moved that to it's home in the classlibrary.
/// </summary>

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        ///Redirects user to the CustomerViewer page
        ///Response.Redirect("CustomerViewer.aspx");
        ///
        clsCustomer CustomerInfo = new clsCustomer();
        CustomerInfo.Username = txtUsername.Text;
        CustomerInfo.Password = txtPassword.Text;
        CustomerInfo.ShippingAddress = txtShippingAddress.Text;
        CustomerInfo.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        CustomerInfo.DateAdded = Convert.ToDateTime(txtDateJoined.Text);
        CustomerInfo.HasOrder = Convert.ToBoolean(chkHasOrder.Checked); ///This one seems a bit strange to me, chkHasOrder is already a boolean, it's either checked or not, so why the conversion?
        ///Creates an instance of a customer, and then populates it's three varchar fields with the text contained in the text boxes we've added to the site.
        ///Nevermind, thinking about it more, you need to evoke the .checked method to return the state of the checkbox object, which then gets converted into a traditional boolean (?)
        Session["CustomerInfo"] = CustomerInfo;
        ///Alright vague networking memories here, Session's are used as temporary files that allow for sites to remember stuff like, say, the info inputted into our data entry page, and use them
        ///on, say, our viewer page.
        ///
        Response.Redirect("CustomerViewer.aspx");
        ///Same as last time, just redirects to the CustomerViewer page.


    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer(); ///Creates new instance of a customer named ACustomer
        Int32 TCustomerID;
        Boolean Found = false; //Creates an int named CustomerID (temporary, don't get confused), and a boolean named found, setting it by default to false, CustomerID is left as null by default
        TCustomerID = Convert.ToInt32(txtCustomerID.Text);
        Found = ACustomer.Find(TCustomerID);
        if (Found == true)
        {
            txtUsername.Text = ACustomer.mUsername; ///Was originally .Username, however, we need to remember that our find function populates the objects m(whatever) field, not it's regular field.
            txtPassword.Text = ACustomer.mPassword;
            txtShippingAddress.Text = ACustomer.mShippingAddress;
            chkHasOrder.Checked = ACustomer.mHasOrder;
            txtDateJoined.Text = ACustomer.mDateAdded.ToString();

        }
    }
}