using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ViewModels
{
    [DataContract]
    public class UsuarioViewModel
    {
        [DataMember(Name = "Id")]
        public int IdUsuario { get;set; }

        [DataMember(Name = "Nombre_Usuario")]
        public string Nombre { get; set; }

        [DataMember(Name = "Fecha_Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [DataMember(Name = nameof(Sexo))]        
        public string Sexo { get; set; }

        [DataMember(Name= nameof(Edad))]
        public int Edad { get;set;}
    }
}