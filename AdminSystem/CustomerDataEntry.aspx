<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 436px">
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 360px; top: 229px; position: absolute" Text="Find" />
        </div>
        <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 26px; top: 56px; position: absolute; width: 200px;" Text="Customer ID"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 225px; top: 56px; position: absolute; width: 168px;" OnTextChanged="txtCustomerID_TextChanged" height="22px"></asp:TextBox>
        <asp:Label ID="lblCustomerName" runat="server" style="z-index: 1; left: 26px; top: 89px; position: absolute; width: 199px;" Text="Customer name"></asp:Label>
        <asp:Label ID="lblCustomerEmail" runat="server" style="z-index: 1; left: 26px; top: 124px; position: absolute; margin-top: 1px; width: 199px;" Text="Customer email"></asp:Label>
        <asp:Label ID="lblCustomerPassowrd" runat="server" style="z-index: 1; left: 26px; top: 162px; position: absolute; " Text="Customer password" width="199px"></asp:Label>
        <asp:Label ID="lblCustomerDate" runat="server" style="z-index: 1; left: 26px; top: 195px; position: absolute" Text="Customer date" width="199px"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 225px; top: 159px; position: absolute; width: 168px;" height="22px"></asp:TextBox>
        <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 225px; top: 196px; position: absolute; width: 168px;" height="22px"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; top: 263px; position: absolute; left: 36px" Text="Active" />
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 35px; top: 304px; position: absolute" Text="[lblError]"></asp:Label>
        <p>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 225px; top: 87px; position: absolute; width: 168px;" height="22px"></asp:TextBox>
        </p>
        <p>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 225px; top: 123px; position: absolute; margin-top: 0px; width: 168px;" height="22px"></asp:TextBox>
        </p>
        <p style="width: 199px; height: 22px">
            &nbsp;</p>
        <p style="width: 199px; height: 22px">
            &nbsp;</p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; right: 1294px; top: 372px; position: absolute; width: 66px;" Text="Cancel" OnClick="btnCancel_Click" />
        <p>
        <asp:Button ID="btnOK" runat="server"  style="z-index: 1; left: 67px; top: 373px; position: absolute; width: 47px;" Text="OK" OnClick="btnOK_Click1" />
        </p>
    </form>
</body>
</html>