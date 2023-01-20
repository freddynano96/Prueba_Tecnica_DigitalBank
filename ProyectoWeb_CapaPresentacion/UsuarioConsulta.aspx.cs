using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoWeb_CapaPresentacion.WServiceUsuario;
namespace ProyectoWeb_CapaPresentacion
{
    
    public partial class UsuarioConsulta : System.Web.UI.Page
    {
        protected int CantidadUsuarios = -1;

        protected int CantidadPaginas = 0;

        protected int PaginaActual;

        protected List<string> MensajesValidos = new List<string>();

        protected List<string> MensajesError = new List<string>();

        protected string _search = null;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                WSUsuariosClient cliente = new WServiceUsuario.WSUsuariosClient();

                cliente.Open();
                
                string busqueda = Request.QueryString["search"];


                int resultadoCantidadUsuarios;
                if (!string.IsNullOrEmpty(busqueda))
                {
                    resultadoCantidadUsuarios = cliente.GetCantidadUsuariosPorBusqueda(busqueda).Datos;
                    txtBusqueda.Text = busqueda;
                }
                else
                {
                    resultadoCantidadUsuarios = cliente.GetCantidadUsuarios().Datos;
                }


                var mensajeAccion = Request.QueryString["accion"];

                if (mensajeAccion == "eliminado")
                {
                    MensajesValidos.Add("Se elimino correctamente el usuario");
                }else if(mensajeAccion == "errorEliminando")
                {
                    MensajesError.Add("Se produjo un error durante la eliminación del usuario");
                }

                CantidadUsuarios = resultadoCantidadUsuarios;

                CantidadPaginas = Convert.ToInt32(Math.Ceiling(CantidadUsuarios / 20.0));


                int pagina = 1;

                if (Request.QueryString["page"] != null)
                {
                    try
                    {
                        pagina = Convert.ToInt32(Request.QueryString["page"]);
                    }
                    catch
                    {

                    }
                }

                PaginaActual = pagina;

                int cantidadUsuarios = 20;
                if (Request.QueryString["qty"] != null)
                {
                    try
                    {
                        cantidadUsuarios = Convert.ToInt32(Request.QueryString["qty"]);
                    }
                    catch
                    {

                    }
                }

                RespuestaServicioOfArrayOfUsuarioViewModelErWrKz08 resultadoUsuarios;

                if (!string.IsNullOrEmpty(busqueda))
                {
                    resultadoUsuarios = cliente.GetListaUsuariosPorBusqueda(busqueda,pagina, cantidadUsuarios);
                }
                else
                {
                    resultadoUsuarios = cliente.GetListaUsuarios(pagina, cantidadUsuarios);
                }

                if (resultadoUsuarios.OK)
                {
                    grdUsuarios.DataSource = resultadoUsuarios.Datos;
                    grdUsuarios.DataBind();
                }

                cliente.Close();

            }

            

        }

        protected void Grid_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            int index = Convert.ToInt32(e.CommandArgument);

            GridViewRow row = grdUsuarios.Rows[index];

            int idUsuario = Convert.ToInt32(row.Cells[0].Text);

            switch (e.CommandName)
            {
                case "EditarUsuario":
                    if (Response.IsClientConnected)
                    {
                        Response.Redirect($"~/Usuario?id={idUsuario}&action=editar");
                    }
                    else
                    {
                        Response.End();
                    }
                    

                    break;
                case "EliminarUsuario":

                    if (Response.IsClientConnected)
                    {
                        Response.Redirect($"~/Usuario?id={idUsuario}&action=eliminar");
                    }
                    else
                    {
                        Response.End();
                    }

                    break;
            }
        }

        protected void BuscarUsuario_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBusqueda.Text))
            {
                if (Response.IsClientConnected)
                {
                    Response.Redirect($"~/UsuarioConsulta?search={txtBusqueda.Text}");
                }
            }
        }

    }
}