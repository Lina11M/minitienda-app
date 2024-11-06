<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFProducts.aspx.cs" Inherits="Presentation.WFProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Gestion de Productos</h1>
    <div>

        <%--Id--%>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <%--Codigo--%>
        <asp:Label ID="Label1" runat="server" Text="Ingrese el codigo"></asp:Label>
        <asp:TextBox ID="TBCode" runat="server"></asp:TextBox>
        <br />
        <%--Descripcion--%>
        <asp:Label ID="Label2" runat="server" Text="Ingrese la descripción"></asp:Label>
        <asp:TextBox ID="TBDescription" runat="server"></asp:TextBox>
        <br />
        <%--Cantidad--%>
       <asp:Label ID="Label4" runat="server" Text="Ingrese la cantidad"></asp:Label>
        <asp:TextBox ID="TBQuantity" runat="server"></asp:TextBox>
        <br />
        <%--Precio--%>
        <asp:Label ID="Label5" runat="server" Text="Ingrese el precio"></asp:Label>
        <asp:TextBox ID="TBPrice" runat="server"></asp:TextBox>
        <br />
        <%--Categoria--%>
        <asp:Label ID="Label6" runat="server" Text="Seleccione la categoria"></asp:Label>
        <asp:DropDownList ID="DDLCategories" runat="server"></asp:DropDownList>
        <br />
        <%--Proveedor--%>
        <asp:Label ID="Label7" runat="server" Text="Seleccione el proveedor"></asp:Label>
        <asp:DropDownList ID="DDLProviders" runat="server"></asp:DropDownList>
        <br />

        <asp:Button ID="BtnSave" runat="server" Text="Guardar" />
        <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" />
        <asp:Label ID="LblMsj" runat="server" Text=""></asp:Label>
        <br />

        <%--Lista de productos--%>
        <asp:GridView ID="GVProducts" runat="server"></asp:GridView>

    </div>
</asp:Content>
