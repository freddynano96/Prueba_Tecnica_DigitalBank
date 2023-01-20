using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ViewModels;
using CapaDatos.Modelos;
using CapaDatos;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace WS_CapaNegocio
{
    
    public class WSUsuarios : IWSUsuarios
    {
        RespuestaServicio<UsuarioViewModel> IWSUsuarios.ActualizarUsuario(ActualizarUsuarioViewModel actualizarUsuario)
        {

            var context = new ValidationContext(actualizarUsuario, serviceProvider:null, items:null);

            var resultValidacion = new List<ValidationResult>();

            if (!Validator.TryValidateObject(actualizarUsuario, context, resultValidacion, true))
            {
                return new RespuestaServicio<UsuarioViewModel>
                {
                    OK = false,
                    MensajeDeError = resultValidacion.Select(d=>d.ErrorMessage).ToList()
                };
            }

            Usuario usuarioAEditar = new Usuario
            {
                Fecha_Nacimiento = actualizarUsuario.FechaNacimiento,
                Id = actualizarUsuario.UsuarioId,
                Nombre = actualizarUsuario.Nombre,
                Sexo = actualizarUsuario.Sexo == "Hombre" ? 'H' : 'M'
            };

            var resultEdicion = usuarioAEditar.EditarUsuario();

            return new RespuestaServicio<UsuarioViewModel>
            {
                Datos = new UsuarioViewModel
                {
                    FechaNacimiento = resultEdicion.Fecha_Nacimiento,
                    IdUsuario = resultEdicion.Id,
                    Nombre= resultEdicion.Nombre,
                    Sexo = resultEdicion.Sexo == 'H' ? "Hombre": "Mujer"
                },
                OK = true
            };
        }

        RespuestaServicio<UsuarioViewModel> IWSUsuarios.CrearUsuario(CrearUsuarioViewModel usuario)
        {

            var context = new ValidationContext(usuario, serviceProvider: null, items: null);

            var resultValidacion = new List<ValidationResult>();

            if (!Validator.TryValidateObject(usuario, context, resultValidacion, true))
            {

                return new RespuestaServicio<UsuarioViewModel>()
                {
                    Datos = null,
                    MensajeDeError = resultValidacion.Select(d=>d.ErrorMessage).ToList()
                };
            }

            var usuarioBD = new Usuario
            {
                Fecha_Nacimiento = usuario.FechaNacimiento,
                Nombre = usuario.Nombre,
                Sexo = usuario.Sexo == "Mujer" ? 'M' : 'H'
            };

            var result = usuarioBD.CrearUsuario();

            if (result != null)
            {
                return new RespuestaServicio<UsuarioViewModel>(){
                    OK = true,
                    Datos = new UsuarioViewModel{
                    FechaNacimiento = result.Fecha_Nacimiento,
                    IdUsuario = result.Id,
                    Nombre = result.Nombre,
                    Sexo = result.Sexo == 'M' ? "Mujer" : "Hombre"
                } };
            }
            else
            {
                return new RespuestaServicio<UsuarioViewModel>()
                {
                    Datos = null,
                    MensajeDeError = new List<string>()
                    { 
                        "Ocurrio un error durante la creación del usuario" 
                    }
                };
            }
        }

        

        RespuestaServicio<bool> IWSUsuarios.EliminarUsuario(int id)
        {
            Usuario usuario = new Usuario();
            try
            {
                var result = usuario.EliminarUsuario(id);
                return new RespuestaServicio<bool>()
                {
                    OK = true,
                    Datos = result
                };
            }
            catch { 
                return new RespuestaServicio<bool>()
                {
                    OK = false,
                    Datos = false
                };
            }
            
        }

        RespuestaServicio<int> IWSUsuarios.GetCantidadUsuarios()
        {
            Usuario usuario = new Usuario();

            var cantidad = usuario.ContarUsuarios();

            if (cantidad != -1)
            {
                return new RespuestaServicio<int>()
                {
                    Datos = cantidad,
                    MensajeDeError = new List<string>()
                };
            }
            else
            {
                return new RespuestaServicio<int>(){
                    Datos = -1,
                    MensajeDeError = new List<string>{ "Ocurrio un error mientras se contaba los usuarios" }
                };
            }

        }

        RespuestaServicio<List<UsuarioViewModel>> IWSUsuarios.GetListaUsuarios(int pagina = 1, int cantidad_usuarios = 20)
        {
            Usuario usuario = new Usuario();
            
            int skip = (pagina-1)* cantidad_usuarios;
            int take = cantidad_usuarios;
            var result = usuario.GetUsuarios(skip, take).Select(d=>new UsuarioViewModel { 
                Edad =  (DateTime.Today.AddTicks(-d.Fecha_Nacimiento.Ticks).Year -1),
                FechaNacimiento = d.Fecha_Nacimiento,
                IdUsuario = d.Id,
                Nombre = d.Nombre,
                Sexo = d.Sexo == 'M' ? "Mujer" : "Hombre"
            }).ToList();


            return new RespuestaServicio<List<UsuarioViewModel>>(){
                OK = true,
                Datos = result
            };
        }



        RespuestaServicio<UsuarioViewModel> IWSUsuarios.GetUsuario(int id)
        {
            Usuario usuario = new Usuario();
            var result = usuario.ConsultarUsuario(id);

            if(result == null)
            {
                return new RespuestaServicio<UsuarioViewModel>
                {
                    OK = false,
                    Datos = null,
                    MensajeDeError = new List<string>() { $"No se pudo encontrar el usuario con Id {id}" }
                };
            }

            return new RespuestaServicio<UsuarioViewModel>()
            {
                Datos = new UsuarioViewModel
                {
                    IdUsuario = result.Id,
                    Edad = (DateTime.Today.AddTicks(-result.Fecha_Nacimiento.Ticks).Year - 1),
                    FechaNacimiento = result.Fecha_Nacimiento,
                    Nombre = result.Nombre,
                    Sexo = result.Sexo == 'M' ? "Mujer" : "Hombre"
                },
                OK = true
            };
        }

        RespuestaServicio<List<UsuarioViewModel>> IWSUsuarios.GetListaUsuariosPorBusqueda(string busqueda,int pagina = 1, int cantidad_usuarios = 20)
        {
            Usuario usuario = new Usuario();

            int skip = (pagina - 1) * cantidad_usuarios;
            int take = cantidad_usuarios;
            var result = usuario.BuscarUsuarios(busqueda, skip, take).Select(d => new UsuarioViewModel
            {
                Edad = (DateTime.Today.AddTicks(-d.Fecha_Nacimiento.Ticks).Year - 1),
                FechaNacimiento = d.Fecha_Nacimiento,
                IdUsuario = d.Id,
                Nombre = d.Nombre,
                Sexo = d.Sexo == 'M' ? "Mujer" : "Hombre"
            }).ToList();

            return new RespuestaServicio<List<UsuarioViewModel>>()
            {
                OK = true,
                Datos = result
            };
        }

        RespuestaServicio<int> IWSUsuarios.GetCantidadUsuariosPorBusqueda(string busqueda)
        {
            Usuario usuario = new Usuario();

            var cantidad = usuario.ContarUsuarioPorBusqueda(busqueda);

            if (cantidad != -1)
            {
                return new RespuestaServicio<int>()
                {
                    Datos = cantidad,
                    MensajeDeError = new List<string>()
                };
            }
            else
            {
                return new RespuestaServicio<int>()
                {
                    Datos = -1,
                    MensajeDeError = new List<string> { "Ocurrio un error mientras se contaba los usuarios" }
                };
            }
        }

    }
}
