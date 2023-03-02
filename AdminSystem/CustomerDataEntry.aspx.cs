using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
using Testing1; /// <summary>
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
        ///Creates an instance of a customer, and then populates it's three varchar fields with the text contained in the text boxes we've added to the site.
        ///
        Session["CustomerInfo"] = CustomerInfo;
        ///Alright vague networking memories here, Session's are used as temporary files that allow for sites to remember stuff like, say, the info inputted into our data entry page, and use them
        ///on, say, our viewer page.
        ///
        Response.Redirect("CustomerViewer.aspx");
        ///Same as last time, just redirects to the CustomerViewer page.


    }
}