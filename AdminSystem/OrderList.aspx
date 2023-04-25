<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 491px">
    <form id="form1" runat="server">
        <div style="height: 150px">
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 11px; top: 267px; position: absolute" Text="Add" />
            <asp:ListBox ID="lstOrdersList" runat="server" OnSelectedIndexChanged="lstOrdersList_SelectedIndexChanged" style="z-index: 1; left: 7px; top: 13px; position: absolute; height: 246px; width: 284px"></asp:ListBox>
        </div>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 64px; top: 266px; position: absolute" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 15px; top: 404px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 122px; top: 267px; position: absolute" Text="Delete" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 216px; top: 311px; position: absolute"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 14px; top: 355px; position: absolute" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 90px; top: 356px; position: absolute" Text="Clear" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 14px; top: 313px; position: absolute" Text="Enter a Delivery Type"></asp:Label>
    </form>
</body>
</html>

