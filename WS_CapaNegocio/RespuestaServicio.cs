using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ViewModels
{
    [DataContract]
    public class RespuestaServicio<T>
    {
        [DataMember]
        public bool OK { get; set; }

        [DataMember]
        public List<string> MensajeDeError { get; set; }

        [DataMember]
        public T Datos { get; set; }
    }
}