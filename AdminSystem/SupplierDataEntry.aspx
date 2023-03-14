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
        <asp:Label ID="lblSupplierID" runat="server" style="z-index: 1; left: 52px; top: 79px; position: absolute; height: 19px" Text="SupplierID"></asp:Label>
        <asp:TextBox ID="txtSupplierID" runat="server" style="z-index: 1; left: 138px; top: 70px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="SupplierName" runat="server" style="z-index: 1; left: 50px; top: 112px; position: absolute; width: 66px" Text="SupplierName"></asp:Label>
        <asp:TextBox ID="txtSupplierName" runat="server" style="z-index: 1; left: 148px; top: 121px; position: absolute"></asp:TextBox>
        <asp:Label ID="OrderArrivedOn" runat="server" style="z-index: 1; left: 44px; top: 146px; position: absolute; width: 102px; bottom: 512px" Text="OrderArrivedOn"></asp:Label>
        <asp:TextBox ID="txtOrderArrivedOn" runat="server" style="z-index: 1; left: 157px; top: 138px; position: absolute; margin-top: 5px" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="OrderNumber" runat="server" style="z-index: 1; left: 50px; top: 179px; position: absolute; width: 86px; height: 19px" Text="OrderNumber"></asp:Label>
        <asp:TextBox ID="txtOrderNumber" runat="server" style="z-index: 1; left: 153px; top: 180px; position: absolute; margin-top: 0px" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="Availability" runat="server" style="z-index: 1; left: 54px; top: 209px; position: absolute; width: 66px" Text="Availability"></asp:Label>
        <asp:TextBox ID="txtAvailability" runat="server" style="z-index: 1; left: 137px; top: 215px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="Quantity" runat="server" style="z-index: 1; left: 52px; top: 250px; position: absolute; width: 66px" Text="Quantity"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 114px; top: 248px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 49px; top: 286px; position: absolute" Text="Active" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 44px; top: 321px; position: absolute; width: 81px"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 113px; top: 418px; position: absolute" Text="Cancel" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 50px; top: 418px; position: absolute" Text="OK" />
    </form>
</body>
</html>
