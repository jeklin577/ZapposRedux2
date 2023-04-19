<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="lblSneakerName" runat="server" style="z-index: 1; left: 18px; top: 90px; position: absolute; width: 91px;" Text="Sneaker Name"></asp:Label>
            <br />
            <asp:TextBox ID="txtSneakerName" runat="server" style="z-index: 1; left: 165px; top: 91px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblSneakerDescription" runat="server" style="z-index: 1; left: 11px; top: 139px; position: absolute; height: 40px" Text="Sneaker Description"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <asp:TextBox ID="txtSneakerDescription" runat="server" style="z-index: 1; left: 162px; top: 137px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtReleaseDate" runat="server" style="z-index: 1; left: 157px; top: 182px; position: absolute"></asp:TextBox>
            <br />
            <asp:Label ID="lblReleaseDate" runat="server" style="z-index: 1; left: 16px; top: 183px; position: absolute; height: 44px; width: 93px" Text="Release Date"></asp:Label>
            <asp:Label ID="lblSize" runat="server" style="z-index: 1; left: 17px; top: 225px; position: absolute; height: 39px; width: 70px; bottom: 269px" Text="Size"></asp:Label>
            <asp:TextBox ID="txtSize" runat="server" style="z-index: 1; left: 157px; top: 222px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 159px; top: 267px; position: absolute"></asp:TextBox>
            <br />
            <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 18px; top: 269px; position: absolute" Text="Price" width="70px"></asp:Label>
            <asp:CheckBox ID="chkSizeAvailable" runat="server" style="z-index: 1; left: 21px; top: 313px; position: absolute" Text="Size Available" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 34px; top: 358px; position: absolute; height: 19px"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" Height="21px" OnClick="btnOK_Click" Text="OK" Width="70px" />
            <br />
            <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 124px; top: 392px; position: absolute" Text="Cancel" OnClick="Button2_Click" />
            <br />
            <br />
            <br />
        </div>
        <asp:Label ID="lblSneakerID" runat="server" style="z-index: 1; left: 18px; top: 44px; position: absolute" Text="Sneaker ID"></asp:Label>
        <asp:TextBox ID="txtSneakerID" runat="server" style="z-index: 1; left: 165px; top: 44px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
