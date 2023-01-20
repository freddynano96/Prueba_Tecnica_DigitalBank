using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WS_CapaNegocio
{
    using System.Data;
    using ViewModels;
    
    [ServiceContract]
    public interface IWSUsuarios
    {
        [OperationContract]
        RespuestaServicio<int> GetCantidadUsuarios();

        [OperationContract]
        RespuestaServicio<UsuarioViewModel> CrearUsuario(CrearUsuarioViewModel usuario);

        [OperationContract]
        RespuestaServicio<bool> EliminarUsuario(int id);

        [OperationContract]
        RespuestaServicio<UsuarioViewModel> ActualizarUsuario(ActualizarUsuarioViewModel actualizarUsuario);

        [OperationContract]
        RespuestaServicio<List<UsuarioViewModel>> GetListaUsuarios(int pagina = 1, int cantidad_usuarios = 20);
        
        [OperationContract]
        RespuestaServicio<UsuarioViewModel> GetUsuario(int id);

        [OperationContract]
        RespuestaServicio<List<UsuarioViewModel>> GetListaUsuariosPorBusqueda(string busqueda, int pagina = 1, int cantidad_usuarios = 20);

        [OperationContract]
        RespuestaServicio<int> GetCantidadUsuariosPorBusqueda(string busqueda);
    }

}
