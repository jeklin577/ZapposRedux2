<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerID" runat="server" Text="CustomerID" width="68px"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" style="margin-left: 30px; margin-bottom: 0px" width="128px"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <p>
            <asp:Label ID="lblPassword" runat="server" Text="Password" width="68px"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" style="margin-left: 30px" Width="128px"></asp:TextBox>
        </p>
        <asp:Label ID="lblShippingAddress" runat="server" Text="Shipping Address" width="68px"></asp:Label>
        <asp:TextBox ID="txtShippingAddress" runat="server" style="margin-left: 30px" width="128px"></asp:TextBox>
        <p>
        <asp:Label ID="lblUsername" runat="server" Text="Username" width="68px"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" style="margin-left: 30px" width="128px"></asp:TextBox>
        </p>
        <asp:Label ID="lblJoinDate" runat="server" Text="DateJoined"></asp:Label>
        <asp:TextBox ID="txtDateJoined" runat="server" style="margin-left: 30px"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkHasOrder" runat="server" Text="Has Order?" />
        </p>
        <p>
        <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="Ok" />
            <asp:Button ID="btnCancel" runat="server" style="margin-left: 20px" Text="Cancel" />
        </p>
    </form>
</body>
</html>
