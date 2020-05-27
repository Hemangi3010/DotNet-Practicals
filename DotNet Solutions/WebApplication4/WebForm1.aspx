<asp:TextBox runat="server"></asp:TextBox><%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="CHANGE FONT SIZE DEMO IN ASP.NET"></asp:Label>
        </div>
        <div>
            <asp:Button runat="server" Text="Increase_font" ID="btnIncFont" OnClick="btnIncFont_Click"/>
            </br>
            <asp:Button runat="server" Text="Decrease_font" ID="btnDecFont" OnClick="btnDecFont_Click"/>
        </div>
    </form>
</body>
</html>



