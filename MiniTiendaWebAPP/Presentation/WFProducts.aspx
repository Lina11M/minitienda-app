<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WFProducts.aspx.cs" Inherits="Presentation.WFProducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Gestion de Productos</h1>
    <div>

        <%--Id--%>
        <asp:HiddenField ID="HFProductId" runat="server" />
        <%--Permite coultar la llave primearia--%>
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

        <asp:Button ID="BtnSave" runat="server" Text="Guardar" OnClick="BtnSave_Click" />
        <asp:Button ID="BtnUpdate" runat="server" Text="Actualizar" OnClick="BtnUpdate_Click" />
        <asp:Label ID="LblMsj" runat="server" Text=""></asp:Label>
        <br />

        <%--Lista de productos--%>
        <asp:GridView ID="GVProducts" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GVProducts_SelectedIndexChanged" OnRowDeleting="GVProducts_RowDeleting">

            <%--Se agrega la propiedad "Columns" que permite personalizar los nombres de las columnas--%>
            <Columns>
                <asp:BoundField DataField="pro_id" HeaderText="Id" />
                <asp:BoundField DataField="pro_codigo" HeaderText="Codigo" />
                <asp:BoundField DataField="pro_descripcion" HeaderText="Descripcion" />
                <asp:BoundField DataField="pro_cantidad" HeaderText="Cantidad" />
                <asp:BoundField DataField="pro_precio" HeaderText="Precio" />
                <asp:BoundField DataField="tbl_provedores_prov_id" HeaderText="FkProveedor" />
                <asp:BoundField DataField="tbl_categoria_cat_id" HeaderText="FkCategoria" />
                <asp:CommandField ShowSelectButton="True"></asp:CommandField>
                <asp:CommandField ShowDeleteButton="True"></asp:CommandField>
            </Columns>

        </asp:GridView>


    </div>
</asp:Content>
