<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFRegister.aspx.cs" Inherits="Presentation.WFRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h1>MiniTienda </h1>
            <h2>Crea Tu Cuenta </h2>


            <br />
            <i class="fa-solid fa-user"></i>
            <asp:Label ID="Label1" runat="server" Text="Correo "></asp:Label>
            <asp:TextBox ID="TBCorreo" runat="server"></asp:TextBox><br />

            <br />
            <i class="fa-solid fa-lock"></i>
            <asp:Label ID="Label2" runat="server" Text="Contraseña "></asp:Label>
            <asp:TextBox ID="TBContraseña" TextMode="Password" runat="server"></asp:TextBox><br />

            <br />
            <asp:Label ID="Label3" runat="server" Text="Estado "></asp:Label>

            <asp:DropDownList ID="DDLState" runat="server">
                <asp:ListItem Value="0">Seleccione</asp:ListItem>
                <asp:ListItem Value="Activo">Activo</asp:ListItem>
                <asp:ListItem Value="Inactivo">Inactivo</asp:ListItem>
            </asp:DropDownList><br />

            <br />
            <asp:Label ID="Label4" runat="server" Text="Rol "></asp:Label>

            <asp:DropDownList ID="DDLRol" runat="server">
                <asp:ListItem Value="0">Seleccione</asp:ListItem>
                <asp:ListItem Value="Cliente">Cliente</asp:ListItem>
                <asp:ListItem Value="Administrador">Administrador</asp:ListItem>
            </asp:DropDownList><br />



            <asp:Label ID="LblMsj" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="BtnIngresar" runat="server" Text="Guardar" OnClick="BtnIngresar_Click" />



        </div>
    </form>
</body>
</html>
