<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstOrderList" runat="server" Height="461px" OnSelectedIndexChanged="lstOrderList_SelectedIndexChanged" Width="567px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="Button1_Click" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        <p>
            <asp:Button ID="lblError" runat="server" Text="Error" />
        </p>
    </form>
</body>
</html>
