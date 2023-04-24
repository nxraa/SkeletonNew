<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 11px; top: 267px; position: absolute" Text="Add" />
            <asp:ListBox ID="lstOrdersList" runat="server" OnSelectedIndexChanged="lstOrdersList_SelectedIndexChanged" style="z-index: 1; left: 7px; top: 13px; position: absolute; height: 246px; width: 284px"></asp:ListBox>
        </div>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 64px; top: 266px; position: absolute" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 327px; position: absolute"></asp:Label>
    </form>
</body>
</html>
