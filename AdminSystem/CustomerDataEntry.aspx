<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 26px; top: 56px; position: absolute" Text="Customer ID" width="199px"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 162px; top: 54px; position: absolute" width="128px" OnTextChanged="txtCustomerID_TextChanged" height="22px"></asp:TextBox>
        <asp:Label ID="lblCustomerName" runat="server" style="z-index: 1; left: 24px; top: 89px; position: absolute; width: 199px;" Text="Customer name"></asp:Label>
        <asp:Label ID="lblCustomerEmail" runat="server" style="z-index: 1; left: 23px; top: 124px; position: absolute; right: 1234px; margin-top: 1px; width: 199px;" Text="Customer email"></asp:Label>
        <asp:Label ID="lblCustomerPassowrd" runat="server" style="z-index: 1; left: 28px; top: 159px; position: absolute; right: 1214px" Text="Customer password" width="199px"></asp:Label>
        <asp:Label ID="lblCustomerDate" runat="server" style="z-index: 1; left: 23px; top: 195px; position: absolute" Text="Customer date" width="199px"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 235px; top: 163px; position: absolute" width="128px" height="22px"></asp:TextBox>
        <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 162px; top: 194px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; top: 263px; position: absolute; left: 36px" Text="Active" />
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 35px; top: 304px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 186px; top: 337px; position: absolute" Text="Cancel" />
        <p>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 228px; top: 84px; position: absolute" width="128px" height="22px"></asp:TextBox>
        </p>
        <p>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 209px; top: 121px; position: absolute; right: 1111px; margin-top: 0px;" width="128px" height="22px"></asp:TextBox>
        </p>
        <p style="width: 199px; height: 22px">
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click1" style="z-index: 1; left: 62px; top: 345px; position: absolute" Text="OK" />
        </p>
    </form>
</body>
</html>
