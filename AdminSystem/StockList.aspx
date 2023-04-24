<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 11px; top: 206px; position: absolute; margin-bottom: 0px" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 62px; top: 208px; position: absolute" Text="Edit" OnClick="btnEdit_Click" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 120px; top: 208px; position: absolute" Text="Delete" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 15px; top: 356px; position: absolute"></asp:Label>
            <asp:Label ID="lblEnter" runat="server" style="z-index: 1; left: 19px; top: 253px; position: absolute" Text="Enter  a Sneaker Name"></asp:Label>
            <asp:ListBox ID="lstStockList" runat="server" Height="157px" Width="337px"></asp:ListBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtEnter" runat="server" style="z-index: 1; left: 179px; top: 253px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; top: 301px; position: absolute; left: 95px; margin-bottom: 0px" Text="Clear" />
        </p>
        <p>
            <br />
        </p>
        <div>
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 13px; top: 304px; position: absolute" Text="Apply" />
        </div>
    </form>
</body>
</html>
