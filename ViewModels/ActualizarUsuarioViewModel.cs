using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ViewModels
{
    [DataContract]
    public class ActualizarUsuarioViewModel : CrearUsuarioViewModel
    {
        [DataMember]
        [Required(ErrorMessage="El id del usuario es necesario")]
        public int UsuarioId { get; set; }
    }
}