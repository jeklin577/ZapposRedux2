<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 623px;
            width: 1360px;
            margin-left: 14px;
        }
    </style>
</head>
<body style="height: 904px">
    <form id="form1" runat="server">
        <asp:Label ID="lblSupplierID" runat="server" style="z-index: 1; left: 31px; top: 98px; position: absolute; height: 19px" Text="SupplierID"></asp:Label>
        <asp:TextBox ID="txtSupplierID" runat="server" style="z-index: 1; left: 146px; top: 95px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="SupplierName" runat="server" style="z-index: 1; left: 31px; top: 127px; position: absolute; width: 66px" Text="SupplierName"></asp:Label>
        <asp:TextBox ID="txtSupplierName" runat="server" style="z-index: 1; left: 146px; top: 127px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="OrderArrivedOn" runat="server" style="z-index: 1; left: 31px; top: 153px; position: absolute; width: 66px; bottom: 505px" Text="OrderArrivedOn"></asp:Label>
        <asp:TextBox ID="txtOrderArrivedOn" runat="server" style="z-index: 1; left: 146px; top: 146px; position: absolute; margin-top: 5px" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="OrderNumber" runat="server" style="z-index: 1; left: 31px; top: 190px; position: absolute; width: 66px; height: 19px" Text="OrderNumber"></asp:Label>
        <asp:TextBox ID="txtOrderNumber" runat="server" style="z-index: 1; left: 146px; top: 184px; position: absolute; margin-top: 0px" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="Availability" runat="server" style="z-index: 1; left: 31px; top: 220px; position: absolute; width: 66px; margin-top: 0px;" Text="Availability"></asp:Label>
        <asp:TextBox ID="txtAvailability" runat="server" style="z-index: 1; left: 146px; top: 215px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="Quantity" runat="server" style="z-index: 1; left: 31px; top: 248px; position: absolute; width: 66px" Text="Quantity"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 146px; top: 242px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 32px; top: 288px; position: absolute" Text="Active" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 25px; top: 331px; position: absolute; width: 81px"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 85px; top: 396px; position: absolute" Text="Cancel" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 34px; top: 395px; position: absolute" Text="OK" />
    </form>
    <p>
&nbsp;</p>
    <p>
        &nbsp;&nbsp;</p>
</body>
</html>
