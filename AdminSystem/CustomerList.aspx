<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 561px">
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstCustomerList" runat="server" Height="382px" Width="433px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="Button1_Click" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        <p>
            <asp:Label ID="lblError" runat="server" Text="[lblError]" style="z-index: 1; left: 14px; top: 549px; position: absolute"></asp:Label>
        </p>
        <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 25px; top: 446px; position: absolute" Text="Enter a name"></asp:Label>
        <asp:TextBox ID="txtEnterName" runat="server" style="z-index: 1; left: 122px; top: 441px; position: absolute; height: 24px; width: 128px"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 20px; top: 481px; position: absolute" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 75px; top: 481px; position: absolute" Text="Clear" />
    </form>
</body>
</html>
