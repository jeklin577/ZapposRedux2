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
            <asp:Label ID="lblSneakerName" runat="server" style="z-index: 1; left: 14px; top: 90px; position: absolute; width: 126px;" Text="Sneaker Name" height="40px"></asp:Label>
            <br />
            <asp:TextBox ID="txtSneakerName" runat="server" style="z-index: 1; left: 162px; top: 91px; position: absolute" height="22px" width="129px"></asp:TextBox>
            <asp:Label ID="lblSneakerDescription" runat="server" style="z-index: 1; left: 11px; top: 139px; position: absolute; height: 40px; width: 137px;" Text="Sneaker Description"></asp:Label>
            <br />
            <asp:TextBox ID="txtSneakerID" runat="server" style="z-index: 1; left: 164px; top: 48px; position: absolute" height="22px" width="129px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:TextBox ID="txtSneakerDescription" runat="server" style="z-index: 1; left: 160px; top: 137px; position: absolute" height="22px" width="129px"></asp:TextBox>
            <asp:TextBox ID="txtReleaseDate" runat="server" style="z-index: 1; left: 159px; top: 182px; position: absolute" height="22px" width="129px"></asp:TextBox>
            <br />
            <asp:Label ID="lblReleaseDate" runat="server" style="z-index: 1; left: 13px; top: 183px; position: absolute; height: 40px; width: 129px" Text="Release Date"></asp:Label>
            <asp:Label ID="lblSize" runat="server" style="z-index: 1; left: 15px; top: 225px; position: absolute; height: 40px; width: 129px; bottom: 308px" Text="Size"></asp:Label>
            <asp:TextBox ID="txtSize" runat="server" style="z-index: 1; left: 158px; top: 222px; position: absolute; width: 129px;" height="22px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 347px; top: 48px; position: absolute; height: 22px; width: 54px" Text="Find" />
            <br />
            <br />
            <br />
            <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 157px; top: 267px; position: absolute; height: 22px; width: 129px;"></asp:TextBox>
            <br />
            <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 14px; top: 270px; position: absolute; width: 129px;" Text="Price" height="40px"></asp:Label>
            <asp:CheckBox ID="chkSizeAvailable" runat="server" style="z-index: 1; left: 15px; top: 313px; position: absolute" Text="Size Available" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 34px; top: 358px; position: absolute; height: 19px"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 30px; top: 395px; position: absolute; width: 60px" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 110px; top: 396px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
            <br />
            <br />
            <br />
        </div>
        <asp:Label ID="lblSneakerID" runat="server" style="z-index: 1; left: 16px; top: 44px; position: absolute; height: 40px; width: 122px;" Text="Sneaker ID"></asp:Label>
    </form>
</body>
</html>
