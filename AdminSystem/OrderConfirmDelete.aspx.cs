﻿using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 OrderNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        OrderNo = Convert.ToInt32(Session["OrderNo"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsOrderCollection OrderBook = new clsOrderCollection();
        OrderBook.ThisOrder.Find(OrderNo);
        OrderBook.Delete();
        Response.Redirect("OrderList.aspx");
    }
}