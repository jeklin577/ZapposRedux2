using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
   Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerID = Convert.ToInt32(Session["CustomerID"]);



        if (IsPostBack == false)
        {
            if (CustomerID != -1) {
            DisplayCustomers();
                                    }
        }
        
        
        
    }


    void DisplayCustomers()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        lstCustomerList.DataSource = Customers.CustomerList;
       lstCustomerList.DataValueField = "CustomerID";
        lstCustomerList.DataTextField = "ShippingAddress";
         lstCustomerList.DataBind();
        
        
    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["CustomerID"] = -1;
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 CustomerID;

        if (lstCustomerList.SelectedIndex != -1)
        {
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedIndex);
            Session["CustomerID"] = CustomerID;
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a customer in order to edit their information";
        }

    }



    protected void lstCustomerList_SelectedIndexChanged(object sender, EventArgs e)
    {
        ///Misclick
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
      ///  Int32 CustomerIDHoldingVar;
      ///  if (lstCustomerList.SelectedIndex != -1)
      ///  {
      ///      CustomerIDHoldingVar = Convert.ToInt32(lstCustomerList.SelectedValue);
      ///      Session["CustomerID"] = CustomerIDHoldingVar;
      ///      Response.Redirect("CustomerConfirmDelete.aspx");
      ///  }
       // else //nO RECORD SELECTED
       // {
       //     lblError.Text = "Please select a record to delete from the list";
       // }
    }

    protected void btnDelete_Click1(object sender, EventArgs e)
    {
        Int32 CustomerIDHoldingVar;
        if (lstCustomerList.SelectedIndex != -1)
        {
            CustomerIDHoldingVar = Convert.ToInt32(lstCustomerList.SelectedIndex);
            Session["CustomerID"] = CustomerIDHoldingVar;
            
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        else //nO RECORD SELECTED
        {
            lblError.Text = "Please select a record to delete from the list";
        }

    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
           
        lstCustomerList.DataSource = Customers.CustomerList;
        lstCustomerList.DataValueField = "CustomerID";
        lstCustomerList.DataValueField = "Username";
        lstCustomerList.DataBind();
    }

    ///protected void TextBox1_TextChanged(object sender, EventArgs e)
    /// {
    //
    // }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        txtFilter.Text = ("");
        Customers.ReportByUsername(txtFilter.Text); //Ok, so clearing the page by using the btnApply works when txtfilter.text is empty, so why not just do that with the clear rather than
                                                    //Reporting by ""? ok that didn't work either, why doesn't that work?

        lstCustomerList.DataSource = Customers.CustomerList; //^^ To answer that guy's question, we forgot this line, silly ol' sean.
        lstCustomerList.DataValueField = "CustomerID";
        lstCustomerList.DataValueField = "Username";
        lstCustomerList.DataBind();
    }
}
 
