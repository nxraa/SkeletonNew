<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>        
        <asp:TextBox ID="txtProductId" runat="server" style="z-index: 1; left: 158px; top: 84px; position: absolute; height: 23px;"></asp:TextBox>
        <asp:Label ID="lblProductId" runat="server" style="z-index: 1; left: 11px; top: 81px; position: absolute; right: 1300px;" Text="Product ID"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; top: 136px; position: absolute; left: 158px; height: 26px;"></asp:TextBox>
        <asp:Label ID="lblName" runat="server" height="22px" style="z-index: 1; left: 12px; top: 136px; position: absolute; width: 75px; right: 1320px; margin-bottom: 2px;" Text="Name"></asp:Label>
        <asp:Label ID="lblDescription" runat="server" height="22px" style="z-index: 1; left: 9px; top: 187px; position: absolute" Text="Description" width="86px"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 10px; top: 235px; position: absolute; height: 22px; width: 56px; bottom: 438px;" Text="Price"></asp:Label>
        <asp:Label ID="lblStockLevel" runat="server" style="z-index: 1; left: 10px; position: absolute; height: 28px; width: 103px; top: 276px" Text="Stock Level"></asp:Label>
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 11px; top: 326px; position: absolute; height: 31px; width: 105px; bottom: 338px;" Text="Date Added"></asp:Label>
        <asp:TextBox ID="txtDescription" runat="server" style="z-index: 1; left: 157px; top: 184px; position: absolute; height: 25px; width: 162px; right: 1171px;"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 158px; top: 229px; position: absolute; height: 22px; bottom: 438px;"></asp:TextBox>
        <asp:TextBox ID="txtStockLevel" runat="server" style="z-index: 1; left: 159px; top: 277px; position: absolute; height: 21px;"></asp:TextBox>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 159px; top: 324px; position: absolute; height: 27px;"></asp:TextBox>
        <asp:CheckBox ID="chkAvailableInStore" runat="server" style="z-index: 1; left: 11px; top: 381px; position: absolute" Text="Available In Store" />
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 18px; top: 468px; position: absolute" Text="Ok" />

        <p>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" Height="28px" Width="75px" style =" position: absolute; top: 83px; left: 381px;"/>
         </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 17px; top: 419px; position: absolute"></asp:Label>
            </div>
        <p>
            &nbsp;</p>
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" style =" position: absolute; top: 469px; left: 115px;"/>
    </form>
</body>
</html>
