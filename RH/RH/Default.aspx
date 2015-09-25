<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RH._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Recursos Humanos</h1>

    </div>
<!--Comentario html-->
    <div id="btnsControl" style="float:right">
        <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click"/>
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click"/>
        <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click"/>
    </div>

    <div id="ctrProd">
        <asp:Label ID="lblId" runat="server" Text="ID"></asp:Label>
        <asp:TextBox ID="txtID" runat="server" width="50px"></asp:TextBox>
    </div>

    <div id="ctrProd1">
        <asp:Label ID="LabelNombre" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" width="50px"></asp:TextBox>
    </div>

    <div id="ctrProd3">
        <asp:Button ID="ButtonInsertar" runat="server" Text="Insertar" OnClick="btnInsertar_Click"/>
    </div>
  

</asp:Content>
