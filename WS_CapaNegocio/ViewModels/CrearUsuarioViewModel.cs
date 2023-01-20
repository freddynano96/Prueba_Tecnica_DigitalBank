using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WS_CapaNegocio.ViewModels
{
    [DataContract]
    public class CrearUsuarioViewModel
    {
        [DataMember]
        [Required(ErrorMessage = "El nombre del usuario es obligatorio")]
        [MaxLength(100,ErrorMessage = "El nombre del usuario no debe exceder mas de 100 caracteres")]
        [MinLength(2,ErrorMessage = "El nombre del usuario no puede contener un solo caracter")]
        public virtual string Nombre { get; set; }
        
        [DataMember]
        [Required(ErrorMessage = "Por favor selecciona el sexo del usuario")]
        public virtual string Sexo { get; set; }
        
        [DataMember]
        [Required(ErrorMessage = "Selecciona la fecha de nacimiento del usuario")]
        public virtual DateTime FechaNacimiento { get; set; }
    }
}