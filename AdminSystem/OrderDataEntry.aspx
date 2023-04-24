<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 374px;
        }
    </style>
</head>
<body style="height: 359px">
    <form id="form1" runat="server">
        <br />
        <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 24px; top: 26px; position: absolute" Text="Order Id" width="115px"></asp:Label>
        <asp:TextBox ID="txtOrderId" runat="server" style="z-index: 1; left: 150px; top: 18px; position: absolute; height: 25px"></asp:TextBox>
        <asp:Label ID="lblDeliveryType" runat="server" style="z-index: 1; left: 24px; top: 74px; position: absolute" Text="Delivery Type"></asp:Label>
        <asp:TextBox ID="txtDeliveryType" runat="server" height="25px" style="z-index: 1; left: 150px; top: 71px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblProductId" runat="server" style="z-index: 1; left: 24px; top: 132px; position: absolute" Text="Product Id" width="115px"></asp:Label>
        <asp:TextBox ID="txtProductId" runat="server" height="25px" style="z-index: 1; left: 150px; top: 129px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 24px; top: 179px; position: absolute; margin-top: 0px" Text="Quantity" width="115px"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server" height="25px" style="z-index: 1; left: 150px; top: 178px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 24px; top: 232px; position: absolute" Text="Order Date" width="115px"></asp:Label>
        <asp:TextBox ID="txtOrderDate" runat="server" height="25px" style="z-index: 1; left: 150px; top: 232px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkOrderCompleted" runat="server" style="z-index: 1; left: 26px; top: 291px; position: absolute; margin-top: 0px" Text="Order Completed" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 31px; top: 345px; position: absolute"></asp:Label>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 20px; top: 396px; position: absolute" Text="Ok" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 70px; top: 396px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 353px; top: 17px; position: absolute" Text="Find" />
    </form>
</body>
</html>