<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStaffID" runat="server" style="z-index: 1; left: 41px; top: 65px; position: absolute" Text="Staff ID"></asp:Label>
            <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 32px; top: 95px; position: absolute" Text="First Name"></asp:Label>
            <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 32px; top: 125px; position: absolute" Text="Last Name"></asp:Label>
        </div>
        <asp:Label ID="lblDateHired" runat="server" style="z-index: 1; left: 31px; top: 157px; position: absolute" Text="Date Hired"></asp:Label>
        <asp:Label ID="lblSalary" runat="server" style="z-index: 1; left: 41px; top: 188px; position: absolute" Text="Salary"></asp:Label>
        <asp:Label ID="lblAge" runat="server" style="z-index: 1; left: 46px; top: 216px; position: absolute" Text="Age"></asp:Label>
        <asp:Label ID="lblGender" runat="server" style="z-index: 1; left: 39px; top: 246px; position: absolute" Text="Gender"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 37px; top: 285px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; left: 128px; top: 64px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 128px; top: 95px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkGender" runat="server" style="z-index: 1; left: 129px; top: 247px; position: absolute; right: 516px" Text="Male" TextAlign="Left" />
        <asp:CheckBox ID="CheckBox1" runat="server" style="z-index: 1; left: 193px; top: 247px; position: absolute" Text="Female" TextAlign="Left" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 35px; top: 322px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; top: 322px; position: absolute; left: 82px" Text="Cancel" />
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 127px; top: 124px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDateHired" runat="server" style="z-index: 1; left: 127px; top: 155px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtSalary" runat="server" style="z-index: 1; left: 128px; top: 186px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAge" runat="server" style="z-index: 1; left: 128px; top: 216px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
