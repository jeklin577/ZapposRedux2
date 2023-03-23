using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff TestStaff = new clsStaff();
        // Creates a new instance of clsStaff
        TestStaff = (clsStaff)Session["TestStaff"];
        // Gets the Data from the Session Object
        Response.Write("Staff ID :  " +  TestStaff.StaffID);
        Response.Write("<br>");
        Response.Write("First Name :  " + TestStaff.FirstName);
        Response.Write("<br>");
        Response.Write("Last Name :  " + TestStaff.LastName);
        Response.Write("<br>");
        Response.Write("Date Hired :  " + TestStaff.DateHired);
        Response.Write("<br>");
        Response.Write("Salary :  " + TestStaff.Salary);
        Response.Write("<br>");
        Response.Write("Age :  " + TestStaff.Age);
        Response.Write("<br>");
        Response.Write("Gender :  " + TestStaff.Gender);
        // Displays the Entered Values for the Entries
    }
}