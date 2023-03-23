<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
         </div>
        <asp:Label ID="lblProductId" runat="server" style="z-index: 1; left: 10px; top: 110px; position: absolute; right: 1432px;" Text="Product ID"></asp:Label>
        <asp:TextBox ID="txtProductId" runat="server" style="z-index: 1; left: 110px; top: 109px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 111px; top: 147px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblName" runat="server" height="22px" style="z-index: 1; left: 11px; top: 145px; position: absolute; width: 75px; right: 1424px; margin-bottom: 2px;" Text="Name"></asp:Label>
        <asp:Label ID="lblDescription" runat="server" height="22px" style="z-index: 1; left: 9px; top: 189px; position: absolute" Text="Description" width="86px"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 12px; top: 226px; position: absolute; height: 22px; width: 56px" Text="Price"></asp:Label>
        <asp:Label ID="lblStockLevel" runat="server" style="z-index: 1; left: 14px; position: absolute; height: 43px; width: 63px; top: 259px" Text="Stock Level"></asp:Label>
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 9px; top: 312px; position: absolute; height: 27px; width: 86px" Text="Date Added"></asp:Label>
        <asp:TextBox ID="txtDescription" runat="server" style="z-index: 1; left: 113px; top: 188px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 113px; top: 229px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStockLevel" runat="server" style="z-index: 1; left: 113px; top: 272px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 114px; top: 313px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkAvailableInStore" runat="server" style="z-index: 1; left: 12px; top: 350px; position: absolute" Text="Available In Store" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 396px; position: absolute"></asp:Label>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 13px; top: 442px; position: absolute" Text="Ok" />

        <p>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
         </p>

    </form>
</body>
</html>
