using System;

namespace ClassLibrary
{
    public class clsOrders
    {
     public int orderID { get; set; }
     public int customerID { get; set; }
     public string itemNames { get; set; }
     public int itemQuantity { get; set; }
     public DateTime dateAdded { get; set; }
     public string deliveryAddress { get; set; }
     public bool readyToDispatch { get; set; }
     
    }
}