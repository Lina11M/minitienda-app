<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Presentation.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

         <div>
           <h1> Jhojan’s Tennis </h1>
           <h2> Iniciar Sesión </h2>
             
            <asp:Label ID="Label1" runat="server" Text="Correo:"></asp:Label>
            <asp:TextBox ID="TBCorreo" TextMode="Email" runat="server"></asp:TextBox><br /> <br />

            <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
            <asp:TextBox ID="TBContrasena" TextMode="Password" runat="server"></asp:TextBox><br /> 
            <br />
            <asp:Button ID="BtnIngresar" runat="server" Text="Ingresar" OnClick="BtnIngresar_Click" />
            <asp:Label ID="LblMsg" runat="server" Text=""></asp:Label><br />
        
         </div>
    </form>
</body>
</html>
