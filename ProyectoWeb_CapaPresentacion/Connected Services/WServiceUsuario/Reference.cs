//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoWeb_CapaPresentacion.WServiceUsuario {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RespuestaServicioOfint", Namespace="http://schemas.datacontract.org/2004/07/ViewModels")]
    [System.SerializableAttribute()]
    public partial class RespuestaServicioOfint : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DatosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] MensajeDeErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool OKField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Datos {
            get {
                return this.DatosField;
            }
            set {
                if ((this.DatosField.Equals(value) != true)) {
                    this.DatosField = value;
                    this.RaisePropertyChanged("Datos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] MensajeDeError {
            get {
                return this.MensajeDeErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.MensajeDeErrorField, value) != true)) {
                    this.MensajeDeErrorField = value;
                    this.RaisePropertyChanged("MensajeDeError");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool OK {
            get {
                return this.OKField;
            }
            set {
                if ((this.OKField.Equals(value) != true)) {
                    this.OKField = value;
                    this.RaisePropertyChanged("OK");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RespuestaServicioOfUsuarioViewModelErWrKz08", Namespace="http://schemas.datacontract.org/2004/07/ViewModels")]
    [System.SerializableAttribute()]
    public partial class RespuestaServicioOfUsuarioViewModelErWrKz08 : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ViewModels.UsuarioViewModel DatosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] MensajeDeErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool OKField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ViewModels.UsuarioViewModel Datos {
            get {
                return this.DatosField;
            }
            set {
                if ((object.ReferenceEquals(this.DatosField, value) != true)) {
                    this.DatosField = value;
                    this.RaisePropertyChanged("Datos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] MensajeDeError {
            get {
                return this.MensajeDeErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.MensajeDeErrorField, value) != true)) {
                    this.MensajeDeErrorField = value;
                    this.RaisePropertyChanged("MensajeDeError");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool OK {
            get {
                return this.OKField;
            }
            set {
                if ((this.OKField.Equals(value) != true)) {
                    this.OKField = value;
                    this.RaisePropertyChanged("OK");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RespuestaServicioOfboolean", Namespace="http://schemas.datacontract.org/2004/07/ViewModels")]
    [System.SerializableAttribute()]
    public partial class RespuestaServicioOfboolean : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool DatosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] MensajeDeErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool OKField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Datos {
            get {
                return this.DatosField;
            }
            set {
                if ((this.DatosField.Equals(value) != true)) {
                    this.DatosField = value;
                    this.RaisePropertyChanged("Datos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] MensajeDeError {
            get {
                return this.MensajeDeErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.MensajeDeErrorField, value) != true)) {
                    this.MensajeDeErrorField = value;
                    this.RaisePropertyChanged("MensajeDeError");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool OK {
            get {
                return this.OKField;
            }
            set {
                if ((this.OKField.Equals(value) != true)) {
                    this.OKField = value;
                    this.RaisePropertyChanged("OK");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RespuestaServicioOfArrayOfUsuarioViewModelErWrKz08", Namespace="http://schemas.datacontract.org/2004/07/ViewModels")]
    [System.SerializableAttribute()]
    public partial class RespuestaServicioOfArrayOfUsuarioViewModelErWrKz08 : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ViewModels.UsuarioViewModel[] DatosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] MensajeDeErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool OKField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ViewModels.UsuarioViewModel[] Datos {
            get {
                return this.DatosField;
            }
            set {
                if ((object.ReferenceEquals(this.DatosField, value) != true)) {
                    this.DatosField = value;
                    this.RaisePropertyChanged("Datos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] MensajeDeError {
            get {
                return this.MensajeDeErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.MensajeDeErrorField, value) != true)) {
                    this.MensajeDeErrorField = value;
                    this.RaisePropertyChanged("MensajeDeError");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool OK {
            get {
                return this.OKField;
            }
            set {
                if ((this.OKField.Equals(value) != true)) {
                    this.OKField = value;
                    this.RaisePropertyChanged("OK");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WServiceUsuario.IWSUsuarios")]
    public interface IWSUsuarios {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuarios/GetCantidadUsuarios", ReplyAction="http://tempuri.org/IWSUsuarios/GetCantidadUsuariosResponse")]
        ProyectoWeb_CapaPresentacion.WServiceUsuario.RespuestaServicioOfint GetCantidadUsuarios();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuarios/GetCantidadUsuarios", ReplyAction="http://tempuri.org/IWSUsuarios/GetCantidadUsuariosResponse")]
        System.Threading.Tasks.Task<ProyectoWeb_CapaPresentacion.WServiceUsuario.RespuestaServicioOfint> GetCantidadUsuariosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuarios/CrearUsuario", ReplyAction="http://tempuri.org/IWSUsuarios/CrearUsuarioResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ViewModels.ActualizarUsuarioViewModel))]
        ProyectoWeb_CapaPresentacion.WServiceUsuario.RespuestaServicioOfUsuarioViewModelErWrKz08 CrearUsuario(ViewModels.CrearUsuarioViewModel usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuarios/CrearUsuario", ReplyAction="http://tempuri.org/IWSUsuarios/CrearUsuarioResponse")]
        System.Threading.Tasks.Task<ProyectoWeb_CapaPresentacion.WServiceUsuario.RespuestaServicioOfUsuarioViewModelErWrKz08> CrearUsuarioAsync(ViewModels.CrearUsuarioViewModel usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuarios/EliminarUsuario", ReplyAction="http://tempuri.org/IWSUsuarios/EliminarUsuarioResponse")]
        ProyectoWeb_CapaPresentacion.WServiceUsuario.RespuestaServicioOfboolean EliminarUsuario(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuarios/EliminarUsuario", ReplyAction="http://tempuri.org/IWSUsuarios/EliminarUsuarioResponse")]
        System.Threading.Tasks.Task<ProyectoWeb_CapaPresentacion.WServiceUsuario.RespuestaServicioOfboolean> EliminarUsuarioAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuarios/ActualizarUsuario", ReplyAction="http://tempuri.org/IWSUsuarios/ActualizarUsuarioResponse")]
        ProyectoWeb_CapaPresentacion.WServiceUsuario.RespuestaServicioOfUsuarioViewModelErWrKz08 ActualizarUsuario([System.ServiceModel.MessageParameterAttribute(Name="actualizarUsuario")] ViewModels.ActualizarUsuarioViewModel actualizarUsuario1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuarios/ActualizarUsuario", ReplyAction="http://tempuri.org/IWSUsuarios/ActualizarUsuarioResponse")]
        System.Threading.Tasks.Task<ProyectoWeb_CapaPresentacion.WServiceUsuario.RespuestaServicioOfUsuarioViewModelErWrKz08> ActualizarUsuarioAsync(ViewModels.ActualizarUsuarioViewModel actualizarUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuarios/GetListaUsuarios", ReplyAction="http://tempuri.org/IWSUsuarios/GetListaUsuariosResponse")]
        ProyectoWeb_CapaPresentacion.WServiceUsuario.RespuestaServicioOfArrayOfUsuarioViewModelErWrKz08 GetListaUsuarios(int pagina, int cantidad_usuarios);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuarios/GetListaUsuarios", ReplyAction="http://tempuri.org/IWSUsuarios/GetListaUsuariosResponse")]
        System.Threading.Tasks.Task<ProyectoWeb_CapaPresentacion.WServiceUsuario.RespuestaServicioOfArrayOfUsuarioViewModelErWrKz08> GetListaUsuariosAsync(int pagina, int cantidad_usuarios);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuarios/GetUsuario", ReplyAction="http://tempuri.org/IWSUsuarios/GetUsuarioResponse")]
        ProyectoWeb_CapaPresentacion.WServiceUsuario.RespuestaServicioOfUsuarioViewModelErWrKz08 GetUsuario(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuarios/GetUsuario", ReplyAction="http://tempuri.org/IWSUsuarios/GetUsuarioResponse")]
        System.Threading.Tasks.Task<ProyectoWeb_CapaPresentacion.WServiceUsuario.RespuestaServicioOfUsuarioViewModelErWrKz08> GetUsuarioAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuarios/GetListaUsuariosPorBusqueda", ReplyAction="http://tempuri.org/IWSUsuarios/GetListaUsuariosPorBusquedaResponse")]
        ProyectoWeb_CapaPresentacion.WServiceUsuario.RespuestaServicioOfArrayOfUsuarioViewModelErWrKz08 GetListaUsuariosPorBusqueda(string busqueda, int pagina, int cantidad_usuarios);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuarios/GetListaUsuariosPorBusqueda", ReplyAction="http://tempuri.org/IWSUsuarios/GetListaUsuariosPorBusquedaResponse")]
        System.Threading.Tasks.Task<ProyectoWeb_CapaPresentacion.WServiceUsuario.RespuestaServicioOfArrayOfUsuarioViewModelErWrKz08> GetListaUsuariosPorBusquedaAsync(string busqueda, int pagina, int cantidad_usuarios);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuarios/GetCantidadUsuariosPorBusqueda", ReplyAction="http://tempuri.org/IWSUsuarios/GetCantidadUsuariosPorBusquedaResponse")]
        ProyectoWeb_CapaPresentacion.WServiceUsuario.RespuestaServicioOfint GetCantidadUsuariosPorBusqueda(string busqueda);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUsuarios/GetCantidadUsuariosPorBusqueda", ReplyAction="http://tempuri.org/IWSUsuarios/GetCantidadUsuariosPorBusquedaResponse")]
        System.Threading.Tasks.Task<ProyectoWeb_CapaPresentacion.WServiceUsuario.RespuestaServicioOfint> GetCantidadUsuariosPorBusquedaAsync(string busqueda);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWSUsuariosChannel : ProyectoWeb_CapaPresentacion.WServiceUsuario.IWSUsuarios, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSUsuariosClient : System.ServiceModel.ClientBase<ProyectoWeb_CapaPresentacion.WServiceUsuario.IWSUsuarios>, ProyectoWeb_CapaPresentacion.WServiceUsuario.IWSUsuarios {
        
        public WSUsuariosClient() {
        }
        
        public WSUsuariosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSUsuariosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSUsuariosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSUsuariosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ProyectoWeb_CapaPresentacion.WServiceUsuario.RespuestaServicioOfint GetCantidadUsuarios() {
            return base.Channel.GetCantidadUsuarios();
        }
        
        public System.Threading.Tasks.Task<ProyectoWeb_CapaPresentacion.WServiceUsuario.RespuestaServicioOfint> GetCantidadUsuariosAsync() {
            return base.Channel.GetCantidadUsuariosAsync();
        }
        
        public ProyectoWeb_CapaPresentacion.WServiceUsuario.RespuestaServicioOfUsuarioViewModelErWrKz08 CrearUsuario(ViewModels.CrearUsuarioViewModel usuario) {
            return base.Channel.CrearUsuario(usuario);
        }
        
        public System.Threading.Tasks.Task<ProyectoWeb_CapaPresentacion.WServiceUsuario.RespuestaServicioOfUsuarioViewModelErWrKz08> CrearUsuarioAsync(ViewModels.CrearUsuarioViewModel usuario) {
            return base.Channel.CrearUsuarioAsync(usuario);
        }
        
        public ProyectoWeb_CapaPresentacion.WServiceUsuario.RespuestaServicioOfboolean EliminarUsuario(int id) {
            return base.Channel.EliminarUsuario(id);
        }
        
        public System.Threading.Tasks.Task<ProyectoWeb_CapaPresentacion.WServiceUsuario.RespuestaServicioOfboolean> EliminarUsuarioAsync(int id) {
            return base.Channel.EliminarUsuarioAsync(id);
        }
        
        public ProyectoWeb_CapaPresentacion.WServiceUsuario.RespuestaServicioOfUsuarioViewModelErWrKz08 ActualizarUsuario(ViewModels.ActualizarUsuarioViewModel actualizarUsuario1) {
            return base.Channel.ActualizarUsuario(actualizarUsuario1);
        }
        
        public System.Threading.Tasks.Task<ProyectoWeb_CapaPresentacion.WServiceUsuario.RespuestaServicioOfUsuarioViewModelErWrKz08> ActualizarUsuarioAsync(ViewModels.ActualizarUsuarioViewModel actualizarUsuario) {
            return base.Channel.ActualizarUsuarioAsync(actualizarUsuario);
        }
        
        public ProyectoWeb_CapaPresentacion.WServiceUsuario.RespuestaServicioOfArrayOfUsuarioViewModelErWrKz08 GetListaUsuarios(int pagina, int cantidad_usuarios) {
            return base.Channel.GetListaUsuarios(pagina, cantidad_usuarios);
        }
        
        public System.Threading.Tasks.Task<ProyectoWeb_CapaPresentacion.WServiceUsuario.RespuestaServicioOfArrayOfUsuarioViewModelErWrKz08> GetListaUsuariosAsync(int pagina, int cantidad_usuarios) {
            return base.Channel.GetListaUsuariosAsync(pagina, cantidad_usuarios);
        }
        
        public ProyectoWeb_CapaPresentacion.WServiceUsuario.RespuestaServicioOfUsuarioViewModelErWrKz08 GetUsuario(int id) {
            return base.Channel.GetUsuario(id);
        }
        
        public System.Threading.Tasks.Task<ProyectoWeb_CapaPresentacion.WServiceUsuario.RespuestaServicioOfUsuarioViewModelErWrKz08> GetUsuarioAsync(int id) {
            return base.Channel.GetUsuarioAsync(id);
        }
        
        public ProyectoWeb_CapaPresentacion.WServiceUsuario.RespuestaServicioOfArrayOfUsuarioViewModelErWrKz08 GetListaUsuariosPorBusqueda(string busqueda, int pagina, int cantidad_usuarios) {
            return base.Channel.GetListaUsuariosPorBusqueda(busqueda, pagina, cantidad_usuarios);
        }
        
        public System.Threading.Tasks.Task<ProyectoWeb_CapaPresentacion.WServiceUsuario.RespuestaServicioOfArrayOfUsuarioViewModelErWrKz08> GetListaUsuariosPorBusquedaAsync(string busqueda, int pagina, int cantidad_usuarios) {
            return base.Channel.GetListaUsuariosPorBusquedaAsync(busqueda, pagina, cantidad_usuarios);
        }
        
        public ProyectoWeb_CapaPresentacion.WServiceUsuario.RespuestaServicioOfint GetCantidadUsuariosPorBusqueda(string busqueda) {
            return base.Channel.GetCantidadUsuariosPorBusqueda(busqueda);
        }
        
        public System.Threading.Tasks.Task<ProyectoWeb_CapaPresentacion.WServiceUsuario.RespuestaServicioOfint> GetCantidadUsuariosPorBusquedaAsync(string busqueda) {
            return base.Channel.GetCantidadUsuariosPorBusquedaAsync(busqueda);
        }
    }
}
