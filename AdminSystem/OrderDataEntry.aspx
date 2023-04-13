<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblOrderId" runat="server" Text="Order ID" width="105px"></asp:Label>
        <asp:TextBox ID="txtOrderId" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnOk_Click" Text="Find" />
            &nbsp;<p>
            <asp:Label ID="lblCustomerId" runat="server" Text="Customer ID" width="105px"></asp:Label>
            <asp:TextBox ID="txtCustomerId" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblItemNames" runat="server" Text="Item Name(s)" width="105px"></asp:Label>
        <asp:TextBox ID="txtItemNames" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblItemQuantity" runat="server" Text="Item Quantity" width="105px"></asp:Label>
            <asp:TextBox ID="txtItemQuantity" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblDateAdded" runat="server" Text="Date Added" width="105px"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblDeliveryAddress" runat="server" Text="Delivery Address"></asp:Label>
            <asp:TextBox ID="txtDeliveryAddress" runat="server"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkReadyToDispatch" runat="server" Text="Ready To Dispatch" />
        <p>
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
