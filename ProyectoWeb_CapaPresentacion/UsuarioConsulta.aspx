<%@ Page Title="Usuario Consulta" Language="C#" 
    MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="UsuarioConsulta.aspx.cs" Inherits="ProyectoWeb_CapaPresentacion.UsuarioConsulta" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
    <% if(MensajesValidos.Count>0) {  %>
        <div class="alert alert-success  alert-dismissible">
            <button type="button" class="close" data-dismiss="alert" aria-label="Close"></button>
            <h3>Mensaje</h3>
            <ul>
            <% foreach(var mensaje in MensajesValidos) {  %>
            <li><%= mensaje %></li>
            <% } %>

                </ul>
        </div>
    <% } %>

    <% if(MensajesError.Count>0) {  %>
        <div class="alert alert-danger  alert-dismissible" >
            <button type="button" class="close" data-dismiss="alert" aria-label="Close"></button>
            <h3>Error</h3>
            <ul>
            <% foreach(var mensaje in MensajesError) {  %>
            <li><%= mensaje %></li>
            <% } %>

                </ul>
        </div>
    <% } %>
        </div>
    <div class="jumbotron">
        <h1>Usuarios <%= CantidadUsuarios %> </h1>
    </div>
    
    <div class="container">
        <nav class="navbar navbar-default">
            <div class="container-fluid">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                     <a class="navbar-brand" href="#">Acciones</a>
                </div>

                <div class="collapse navbar-collapse">
                      <ul class="nav navbar-nav">
                          <li>
                              <a href="Usuario">Nuevo Usuario</a>
                          </li>
                      </ul>
                    <div class="navbar-form navbar-right">
                        <div class="form-group">
                            <asp:TextBox ID="txtBusqueda" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <asp:Button ID="btnBusqueda" runat="server" OnClick="BuscarUsuario_Click" CssClass="btn btn-primary" Text="Buscar"></asp:Button>
                    </div>
                </div>
            </div>
        </nav>


        <asp:GridView ID="grdUsuarios" runat="server"
            AutoGenerateColumns="false"
            CssClass="table table-bordered table-striped" OnRowCommand="Grid_RowCommand">
            <Columns>
                <asp:BoundField DataField="IdUsuario" HeaderText="Id"/>
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="FechaNacimiento" HeaderText="F. Nacimiento" DataFormatString="{0:dd/MMMM/yyyy}" />
                <asp:BoundField DataField="Edad" HeaderText="Edad" />
                <asp:BoundField DataField="Sexo" HeaderText="Sexo" />
                <asp:ButtonField ControlStyle-CssClass="btn-info btn"
                    Text="Editar" CommandName="EditarUsuario" InsertVisible="True">
                </asp:ButtonField>
                <asp:ButtonField ControlStyle-CssClass="btn btn-danger" Text="Eliminar" CommandName="EliminarUsuario" />
            </Columns>
        </asp:GridView>
        <nav>
            <ul class="pagination">
                <% if(CantidadPaginas > 0) {
                        int i = 1;%>
                <% if(PaginaActual>1) { %>
                <li class="page-item">
                    <a class="page-link" href="UsuarioConsulta?page=<%= PaginaActual-1 %><%
if (!string.IsNullOrEmpty(_search)) {                             
%>
                            query
                            <%= _search %>
  <%                           } %>">
                        &laquo;
                    </a>
                </li>

                <% } %>
                <% for(i = 1; i <= CantidadPaginas; i++) { %>
                    <li class="page-item">
                        <a class="page-link"
                            href="UsuarioConsulta?page=<%= i %><%
if (!string.IsNullOrEmpty(_search)) {                             
%>
                            query
                            <%= _search %>
  <%                           } %>"><%= i %>
                        </a>
                    </li>
                <% } if (PaginaActual < CantidadPaginas) {  %>
                
                    <li class="page-item">
                        <a class="page-link" href="UsuarioConsulta?page=<%= PaginaActual+1 %><%
if (!string.IsNullOrEmpty(_search)) {                             
%>
                            query
                            <%= _search %>
  <%                           } %>">
                            &raquo;
                        </a>
                    </li>

                <% }
                } %>
            </ul>
        </nav>
    </div>
</asp:Content>