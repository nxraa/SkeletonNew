﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrdersList" runat="server" OnSelectedIndexChanged="lstOrdersList_SelectedIndexChanged" style="z-index: 1; left: 7px; top: 13px; position: absolute; height: 246px; width: 284px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
