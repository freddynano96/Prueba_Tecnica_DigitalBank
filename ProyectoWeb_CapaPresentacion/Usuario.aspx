<%@ Page Language="C#" AutoEventWireup="true" 
    MasterPageFile="~/Site.Master" CodeBehind="Usuario.aspx.cs" Inherits="ProyectoWeb_CapaPresentacion.Usuario"  %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" >
        <div class="jumbotron container"><h1>Usuario</h1>

            <% if(MensajesExitosos.Count>0) { %>
            <div class="alert-success">
                <ul>
                    <% foreach(var mensaje in MensajesExitosos) {  %>
                    <li>
                        <%= mensaje %>
                    </li>
                    <% } %>
                </ul>
            </div>

            <% } %>

            <% if(MensajesValidacion.Count>0) { %>
            <div class="alert-danger">
                <ul>
                <%foreach(var mensaje in MensajesValidacion) { %>

                    <li><%= mensaje %></li>

                <% } %>
                </ul>

            </div>
            <%  }%>
            
            
                <asp:HiddenField ID="hiddenId" runat="server" Visible="false" />
            
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label runat="server" Text="Nombre" ID="lblNombre"></asp:Label>
                    <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server" CausesValidation="True" MaxLength="100">
                    </asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" Text="Fecha Nacimiento" ID="lblFechaNac" CssClass="mr-2"></asp:Label>
                    <asp:Button runat="server" Text="Seleccionar Fecha" CssClass="btn btn-info" ID="btnMostrarCalendario" OnClick="btnMostrarCalendario_Click"></asp:Button>
                    <div class="mt-2 mb-2">
                        
                            
                                <asp:Label ID="lblAnio" runat="server">Año</asp:Label>
                            
                            
                                <div class="form-group-sm">
                                    <asp:DropDownList CssClass="form-control" ID="dpdAnioSeleccion" runat="server"
                                        OnSelectedIndexChanged="dpdAnioSeleccion_Changed" AutoPostBack="True">
                                    </asp:DropDownList>
                                </div>
                            

                        
                        
                        <asp:Calendar ID="cndFechaNacimiento" 
                        runat="server" 
                        BackColor="White" 
                        
                        BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="FirstLetter" 
                        Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" 
                        NextPrevFormat="ShortMonth" Width="220px" OnSelectionChanged="calendario_SelectionChanged">
                        <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                        <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                        <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                        <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                        <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                        <WeekendDayStyle BackColor="#CCCCFF" />
                    </asp:Calendar>
                    
                    <asp:TextBox ID="txtFechaSeleccionada" runat="server" CssClass="form-control" Visible="true" ReadOnly="true"></asp:TextBox>
                </div>
            
            
                <div class="form-group">
                    <asp:Label runat="server" ID="lblSexo" Text="Sexo"></asp:Label>
                    <asp:DropDownList ID="drdSexo" runat="server" CssClass="form-control">
                        <asp:ListItem Selected="True" Value="">Selecciona un sexo</asp:ListItem>
                        <asp:ListItem  Value="Mujer">Mujer</asp:ListItem>
                        <asp:ListItem Value="Hombre">Hombre</asp:ListItem>
                    </asp:DropDownList>
                
            </div>
        </div>
  
            <asp:Button CssClass="btn btn-primary" ID="btnGuardarUsuario" OnClick="GuardarUsuario_Click" Text="Guardar" runat="server" Visible="false"></asp:Button>
  
                <asp:Button CssClass="btn btn-info" ID="btnEditarUsuario" OnClick="EditarUsuario_Click" Text="Confirmar Edición" runat="server" Visible="false"></asp:Button>
                


                <asp:Button CssClass="btn btn-danger" ID="btnEliminarUsuario" OnClick="EliminarUsuario_Click" 
                    Text="Confirmar Eliminación" runat="server" Visible="false"></asp:Button>

                
            </div>
        </div>
        
</asp:Content>