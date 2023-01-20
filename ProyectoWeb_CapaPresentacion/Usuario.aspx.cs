using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoWeb_CapaPresentacion
{
    public enum EstadoUsuario
    {
        Editar,
        Eliminar,
        Crear
    }

    public partial class Usuario : System.Web.UI.Page
    {
        protected List<string> MensajesValidacion = new List<string>();

        protected List<string> MensajesExitosos = new List<string>();

        protected EstadoUsuario Estado = EstadoUsuario.Crear;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                for (var i = DateTime.Now.Year; i >= DateTime.Now.Year - 100; i--)
                {
                    dpdAnioSeleccion.Items.Add(new ListItem(i + "", i + ""));
                }

                lblAnio.Visible = dpdAnioSeleccion.Visible = cndFechaNacimiento.Visible = false;

                #region ValidaciónEdiciónEliminación
                if ( Request.QueryString["id"] != null && Request.QueryString["action"] !=null )
                {
                    int usuarioId = -1;

                    bool idValido = false;

                    try
                    {
                        usuarioId = Convert.ToInt32(Request.QueryString["id"]);
                        idValido = true;
                    }
                    catch(FormatException)
                    {
                        MensajesValidacion.Add("El Id dado no es valido");
                    }

                    if ( idValido && (Request.QueryString["action"].ToString() == "editar" || Request.QueryString["action"] == "eliminar"))
                    {
                        WServiceUsuario.WSUsuariosClient cliente = new WServiceUsuario.WSUsuariosClient();

                        cliente.Open();

                        var usuarioResponse = cliente.GetUsuario(usuarioId);

                        if (usuarioResponse.OK)
                        {
                            cndFechaNacimiento.TodaysDate = usuarioResponse.Datos.FechaNacimiento;
                            cndFechaNacimiento.SelectedDate = usuarioResponse.Datos.FechaNacimiento;
                            txtFechaSeleccionada.Text = usuarioResponse.Datos.FechaNacimiento.ToString("dd/MMMM/yyyy");
                            txtNombre.Text = usuarioResponse.Datos.Nombre;
                            drdSexo.SelectedValue = usuarioResponse.Datos.Sexo;
                            hiddenId.Value = usuarioResponse.Datos.IdUsuario + "";
                            hiddenId.Visible = true;
                            Estado = Request.QueryString["action"].ToString() == "editar" ? EstadoUsuario.Editar : EstadoUsuario.Eliminar;
                        }
                        else
                        {
                            MensajesValidacion.AddRange(usuarioResponse.MensajeDeError);
                        }
                    }
                }

                if(Estado == EstadoUsuario.Crear)
                {
                    btnGuardarUsuario.Visible = true;
                }else if(Estado == EstadoUsuario.Editar)
                {
                    btnEditarUsuario.Visible = true;
                }else if(Estado == EstadoUsuario.Eliminar)
                {
                    btnEliminarUsuario.Visible = true;
                }

                #endregion
            }


        }

        protected void GuardarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                var usuarioACrear = new  ViewModels.CrearUsuarioViewModel
                {
                    FechaNacimiento = cndFechaNacimiento.SelectedDate,
                    Nombre = txtNombre.Text,
                    Sexo = drdSexo.SelectedValue
                };


                var context = new ValidationContext(usuarioACrear, serviceProvider:null,items:null);

                var resultValidacion = new List<ValidationResult>();

                if (!Validator.TryValidateObject(usuarioACrear, context, resultValidacion, true))
                {
                    MensajesValidacion.AddRange(resultValidacion.Select(d=>d.ErrorMessage).ToList());
                }
                else
                {
                    WServiceUsuario.WSUsuariosClient cliente = new WServiceUsuario.WSUsuariosClient();

                    var resultCreacion = cliente.CrearUsuario(usuarioACrear);

                    cliente.Close();

                    if (resultCreacion.OK)
                    {
                        MensajesExitosos.Add("Se guardo con exito el usuario");
                    }
                    else
                    {
                        MensajesValidacion.AddRange(resultCreacion.MensajeDeError);
                    }
                }
            }
            catch
            {
                MensajesValidacion.Add("Ocurrio un error mientras se guardaba el usuario");
            }
        }


        protected void EditarUsuario_Click(object sender, EventArgs e)
        {

            WServiceUsuario.WSUsuariosClient cliente = new WServiceUsuario.WSUsuariosClient();
            try
            {
                cliente.Open();

                var result = cliente.ActualizarUsuario(new ViewModels.ActualizarUsuarioViewModel { 
                    FechaNacimiento = cndFechaNacimiento.SelectedDate,
                    Nombre = txtNombre.Text,
                    Sexo = drdSexo.SelectedValue,
                    UsuarioId = Convert.ToInt32(hiddenId.Value)
                });

                if (result.OK)
                {
                    MensajesExitosos.Add("Se edito el usuario con exito");
                }
                else
                {
                    MensajesValidacion.AddRange(result.MensajeDeError);
                }
            }
            catch
            {
                MensajesValidacion.Add("Ocurrio un error mientras se editaba el usuario");
            }
            finally
            {
                cliente.Close();
            }
        }

        protected void EliminarUsuario_Click(object sender, EventArgs e)
        {
            WServiceUsuario.WSUsuariosClient cliente = new WServiceUsuario.WSUsuariosClient();
            try
            {
                cliente.Open();

                var result = cliente.EliminarUsuario(Convert.ToInt32(hiddenId.Value));

                if (result.OK)
                {
                    if (Response.IsClientConnected)
                    {
                        Response.Redirect($"~/UsuarioConsulta?accion=eliminado");
                    }
                }
                else
                {
                    Response.Redirect($"~/UsuarioConsulta?accion=errorEliminando");
                }
            }
            catch
            {
                MensajesValidacion.Add("Ocurrio un error mientras se eliminaba el usuario");
            }
            finally
            {
                cliente.Close();
            }
        }


        protected void btnMostrarCalendario_Click(object sender, EventArgs e)
        {
            lblAnio.Visible = dpdAnioSeleccion.Visible  = cndFechaNacimiento.Visible = !cndFechaNacimiento.Visible;
            
        }

        protected void calendario_SelectionChanged(object sender, EventArgs e)
        {
            txtFechaSeleccionada.Text = cndFechaNacimiento.SelectedDate.ToString("dd/MMMM/yyyy");
        }

        protected void dpdAnioSeleccion_Changed(object sender, EventArgs e)
        {
            DateTime fechaNueva ;
            try
            {
                fechaNueva = new DateTime(Int32.Parse(dpdAnioSeleccion.SelectedValue), cndFechaNacimiento.SelectedDate.Month, cndFechaNacimiento.SelectedDate.Day);
            }
            catch
            {
                fechaNueva = new DateTime(Int32.Parse(dpdAnioSeleccion.SelectedValue), cndFechaNacimiento.SelectedDate.Month, 28);
            
            }

            cndFechaNacimiento.TodaysDate = fechaNueva;
            cndFechaNacimiento.SelectedDate = fechaNueva;
            
            
        }
    }
}