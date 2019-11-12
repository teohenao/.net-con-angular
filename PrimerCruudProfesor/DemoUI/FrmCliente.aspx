<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmCliente.aspx.cs" Inherits="DemoUI.FrmCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ID<asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            <br />
            <br />
            Nombre<asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />
            <br />
            Compañia<asp:TextBox ID="txtCompania" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Crear" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblResultado" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
