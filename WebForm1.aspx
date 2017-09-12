<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DropDown.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 65px;
        }
        .auto-style2 {
            margin-left: 51px;
            margin-top: 47px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Select Gender
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style2">
            <%--<asp:ListItem Text="Male" Value="1" Selected="True">    </asp:ListItem>
            <asp:ListItem Text="Female" Value="2">  </asp:ListItem>
            <asp:ListItem Text="Others" Value="3" Enabled="True"> </asp:ListItem>--%>
        </asp:DropDownList>
    
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    
    </div>
        <p>
            &nbsp;</p>
        <p class="auto-style1">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
