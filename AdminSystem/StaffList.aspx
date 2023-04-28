<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 363px">
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="Stafflst" runat="server" Height="185px" Width="428px"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="BtnAdd" runat="server" OnClick="Button2_Click" Text="Add" />
            <asp:Button ID="BtnEdit" runat="server" OnClick="Button1_Click" Text="Edit" />
            <asp:Button ID="BtnClear" runat="server" OnClick="Button2_Click" Text="Clear" />
        </p>
        <p style="height: 30px">
            <asp:TextBox ID="srch" runat="server" OnTextChanged="TextBox1_TextChanged">srch</asp:TextBox>
        </p>
        <p style="height: 83px">
            <asp:Button ID="BtnApply" runat="server" OnClick="BtnApply_Click" Text="Apply" />
            <asp:Button ID="BtnDelete" runat="server" OnClick="BtnDelete_Click" Text="Delete" />
        </p>
        <p style="height: 83px">
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        </p>
    </form>
</body>
</html>
