<%@ Page Language="C#" AutoEventWireup="true" CodeFile="6DataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffID" runat="server" style="z-index: 1; left: 26px; top: 42px; position: absolute; width: 50px" Text="Staff ID"></asp:Label>
        <asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; left: 103px; top: 40px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblFirstName" runat="server" EnableTheming="True" style="z-index: 1; left: 17px; top: 71px; position: absolute" Text="First Name "></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 103px; top: 72px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 18px; top: 104px; position: absolute" Text="Last Name"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 103px; top: 103px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblGender" runat="server" style="z-index: 1; left: 25px; top: 134px; position: absolute" Text="Gender"></asp:Label>
        <asp:Label ID="lblDateHired" runat="server" style="z-index: 1; left: 16px; top: 165px; position: absolute" Text="Date Hired"></asp:Label>
        <asp:TextBox ID="txtGender" runat="server" style="z-index: 1; left: 103px; top: 135px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDateHired" runat="server" style="z-index: 1; left: 103px; top: 165px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblSalary" runat="server" style="z-index: 1; left: 29px; top: 196px; position: absolute" Text="Salary"></asp:Label>
        <asp:TextBox ID="txtSalary" runat="server" style="z-index: 1; left: 102px; top: 195px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblAge" runat="server" style="z-index: 1; left: 35px; top: 223px; position: absolute; height: 19px; width: 32px" Text="Age"></asp:Label>
        <asp:TextBox ID="txtAge" runat="server" style="z-index: 1; left: 102px; top: 222px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="CheckBox1" runat="server" style="z-index: 1; left: 14px; top: 264px; position: absolute" />
    </form>
</body>
</html>
