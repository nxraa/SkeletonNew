<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 63px">
            Are you sure you want to delete this record?<asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 18px; top: 46px; position: absolute" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 60px; top: 46px; position: absolute" Text="No" />
        </div>
    </form>
</body>
</html>
