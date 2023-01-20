using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WS_CapaNegocio.ViewModels
{
    [DataContract]
    public class RespuestaServicio<T>
    {
        private readonly bool _ok ;

        public RespuestaServicio(bool Ok)
        {
            _ok = OK;
        }

        [DataMember]
        public bool OK { get => _ok; }

        [DataMember(Name = "Mensaje_de_Error")]
        public string MensajeDeError { get; set; }

        [DataMember(Name = nameof(Datos))]
        public T Datos { get; set; }
    }
}