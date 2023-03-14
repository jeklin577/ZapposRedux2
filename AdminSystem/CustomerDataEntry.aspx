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
        <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" style="margin-left: 31px"></asp:TextBox>
        <p>
            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" style="margin-left: 32px" Width="174px"></asp:TextBox>
        </p>
        <asp:Label ID="lblShippingAddress" runat="server" Text="Shipping Address"></asp:Label>
        <asp:TextBox ID="txtShippingAddress" runat="server" style="margin-left: 31px"></asp:TextBox>
        3834887<p>
            <asp:CheckBox ID="chkHasOrder" runat="server" Text="Has Order?" />
        </p>
        <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="Ok" />
            <asp:Button ID="btnCancel" runat="server" style="margin-left: 20px" Text="Cancel" />
        </p>
    </form>
</body>
</html>
