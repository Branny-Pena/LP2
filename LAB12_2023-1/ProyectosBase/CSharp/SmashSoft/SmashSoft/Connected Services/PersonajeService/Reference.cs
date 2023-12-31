﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmashSoft.PersonajeService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.smashsoft.pucp.edu.pe/", ConfigurationName="PersonajeService.SmashSoftPersonajeService")]
    public interface SmashSoftPersonajeService {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.smashsoft.pucp.edu.pe/SmashSoftPersonajeService/insertarPersonaje" +
            "Request", ReplyAction="http://services.smashsoft.pucp.edu.pe/SmashSoftPersonajeService/insertarPersonaje" +
            "Response")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        SmashSoft.PersonajeService.insertarPersonajeResponse insertarPersonaje(SmashSoft.PersonajeService.insertarPersonajeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.smashsoft.pucp.edu.pe/SmashSoftPersonajeService/insertarPersonaje" +
            "Request", ReplyAction="http://services.smashsoft.pucp.edu.pe/SmashSoftPersonajeService/insertarPersonaje" +
            "Response")]
        System.Threading.Tasks.Task<SmashSoft.PersonajeService.insertarPersonajeResponse> insertarPersonajeAsync(SmashSoft.PersonajeService.insertarPersonajeRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.smashsoft.pucp.edu.pe/")]
    public partial class personaje : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool adhesionParedesField;
        
        private bool arrastreField;
        
        private int cantidadMaxSaltosField;
        
        private string descripcionField;
        
        private System.DateTime fechaAparicionField;
        
        private bool fechaAparicionFieldSpecified;
        
        private byte[] fotoField;
        
        private int idPersonajeField;
        
        private string nombreField;
        
        private double pesoField;
        
        private plataforma plataformaField;
        
        private bool saltoParedField;
        
        private universo universoField;
        
        private double velocidadAlCaminarField;
        
        private double velocidadAlCorrerField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool adhesionParedes {
            get {
                return this.adhesionParedesField;
            }
            set {
                this.adhesionParedesField = value;
                this.RaisePropertyChanged("adhesionParedes");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public bool arrastre {
            get {
                return this.arrastreField;
            }
            set {
                this.arrastreField = value;
                this.RaisePropertyChanged("arrastre");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int cantidadMaxSaltos {
            get {
                return this.cantidadMaxSaltosField;
            }
            set {
                this.cantidadMaxSaltosField = value;
                this.RaisePropertyChanged("cantidadMaxSaltos");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
                this.RaisePropertyChanged("descripcion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public System.DateTime fechaAparicion {
            get {
                return this.fechaAparicionField;
            }
            set {
                this.fechaAparicionField = value;
                this.RaisePropertyChanged("fechaAparicion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fechaAparicionSpecified {
            get {
                return this.fechaAparicionFieldSpecified;
            }
            set {
                this.fechaAparicionFieldSpecified = value;
                this.RaisePropertyChanged("fechaAparicionSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=5)]
        public byte[] foto {
            get {
                return this.fotoField;
            }
            set {
                this.fotoField = value;
                this.RaisePropertyChanged("foto");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public int idPersonaje {
            get {
                return this.idPersonajeField;
            }
            set {
                this.idPersonajeField = value;
                this.RaisePropertyChanged("idPersonaje");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("nombre");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public double peso {
            get {
                return this.pesoField;
            }
            set {
                this.pesoField = value;
                this.RaisePropertyChanged("peso");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public plataforma plataforma {
            get {
                return this.plataformaField;
            }
            set {
                this.plataformaField = value;
                this.RaisePropertyChanged("plataforma");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public bool saltoPared {
            get {
                return this.saltoParedField;
            }
            set {
                this.saltoParedField = value;
                this.RaisePropertyChanged("saltoPared");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public universo universo {
            get {
                return this.universoField;
            }
            set {
                this.universoField = value;
                this.RaisePropertyChanged("universo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public double velocidadAlCaminar {
            get {
                return this.velocidadAlCaminarField;
            }
            set {
                this.velocidadAlCaminarField = value;
                this.RaisePropertyChanged("velocidadAlCaminar");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public double velocidadAlCorrer {
            get {
                return this.velocidadAlCorrerField;
            }
            set {
                this.velocidadAlCorrerField = value;
                this.RaisePropertyChanged("velocidadAlCorrer");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.smashsoft.pucp.edu.pe/")]
    public partial class plataforma : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool activoField;
        
        private int idPlataformaField;
        
        private string nombreField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool activo {
            get {
                return this.activoField;
            }
            set {
                this.activoField = value;
                this.RaisePropertyChanged("activo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int idPlataforma {
            get {
                return this.idPlataformaField;
            }
            set {
                this.idPlataformaField = value;
                this.RaisePropertyChanged("idPlataforma");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("nombre");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.smashsoft.pucp.edu.pe/")]
    public partial class universo : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool activoField;
        
        private int idUniversoField;
        
        private string nombreField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool activo {
            get {
                return this.activoField;
            }
            set {
                this.activoField = value;
                this.RaisePropertyChanged("activo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int idUniverso {
            get {
                return this.idUniversoField;
            }
            set {
                this.idUniversoField = value;
                this.RaisePropertyChanged("idUniverso");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("nombre");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarPersonaje", WrapperNamespace="http://services.smashsoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarPersonajeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.smashsoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SmashSoft.PersonajeService.personaje personaje;
        
        public insertarPersonajeRequest() {
        }
        
        public insertarPersonajeRequest(SmashSoft.PersonajeService.personaje personaje) {
            this.personaje = personaje;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarPersonajeResponse", WrapperNamespace="http://services.smashsoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarPersonajeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.smashsoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public insertarPersonajeResponse() {
        }
        
        public insertarPersonajeResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SmashSoftPersonajeServiceChannel : SmashSoft.PersonajeService.SmashSoftPersonajeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SmashSoftPersonajeServiceClient : System.ServiceModel.ClientBase<SmashSoft.PersonajeService.SmashSoftPersonajeService>, SmashSoft.PersonajeService.SmashSoftPersonajeService {
        
        public SmashSoftPersonajeServiceClient() {
        }
        
        public SmashSoftPersonajeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SmashSoftPersonajeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SmashSoftPersonajeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SmashSoftPersonajeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SmashSoft.PersonajeService.insertarPersonajeResponse SmashSoft.PersonajeService.SmashSoftPersonajeService.insertarPersonaje(SmashSoft.PersonajeService.insertarPersonajeRequest request) {
            return base.Channel.insertarPersonaje(request);
        }
        
        public int insertarPersonaje(SmashSoft.PersonajeService.personaje personaje) {
            SmashSoft.PersonajeService.insertarPersonajeRequest inValue = new SmashSoft.PersonajeService.insertarPersonajeRequest();
            inValue.personaje = personaje;
            SmashSoft.PersonajeService.insertarPersonajeResponse retVal = ((SmashSoft.PersonajeService.SmashSoftPersonajeService)(this)).insertarPersonaje(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SmashSoft.PersonajeService.insertarPersonajeResponse> SmashSoft.PersonajeService.SmashSoftPersonajeService.insertarPersonajeAsync(SmashSoft.PersonajeService.insertarPersonajeRequest request) {
            return base.Channel.insertarPersonajeAsync(request);
        }
        
        public System.Threading.Tasks.Task<SmashSoft.PersonajeService.insertarPersonajeResponse> insertarPersonajeAsync(SmashSoft.PersonajeService.personaje personaje) {
            SmashSoft.PersonajeService.insertarPersonajeRequest inValue = new SmashSoft.PersonajeService.insertarPersonajeRequest();
            inValue.personaje = personaje;
            return ((SmashSoft.PersonajeService.SmashSoftPersonajeService)(this)).insertarPersonajeAsync(inValue);
        }
    }
}
