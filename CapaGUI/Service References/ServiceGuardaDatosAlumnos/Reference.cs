﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaGUI.ServiceGuardaDatosAlumnos {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceGuardaDatosAlumnos.wsGuardaDatosAlumnosSoap")]
    public interface wsGuardaDatosAlumnosSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/agregaAlumno", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void agregaAlumno(CapaGUI.ServiceGuardaDatosAlumnos.Alumno alumno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/agregaAlumno", ReplyAction="*")]
        System.Threading.Tasks.Task agregaAlumnoAsync(CapaGUI.ServiceGuardaDatosAlumnos.Alumno alumno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/entregaAlumnoDataSet", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet entregaAlumnoDataSet();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/entregaAlumnoDataSet", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> entregaAlumnoDataSetAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/entregaLargoAlumno", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaGUI.ServiceGuardaDatosAlumnos.Alumno[] entregaLargoAlumno();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/entregaLargoAlumno", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaGUI.ServiceGuardaDatosAlumnos.Alumno[]> entregaLargoAlumnoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/entregaPosicionAlumno", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaGUI.ServiceGuardaDatosAlumnos.Alumno entregaPosicionAlumno(int pos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/entregaPosicionAlumno", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaGUI.ServiceGuardaDatosAlumnos.Alumno> entregaPosicionAlumnoAsync(int pos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarAlumno", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaGUI.ServiceGuardaDatosAlumnos.Alumno buscarAlumno(string Rut);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarAlumno", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaGUI.ServiceGuardaDatosAlumnos.Alumno> buscarAlumnoAsync(string Rut);
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2053.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Alumno : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string rutField;
        
        private string nombreField;
        
        private string apellidoField;
        
        private System.DateTime fechaNacimientoField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Rut {
            get {
                return this.rutField;
            }
            set {
                this.rutField = value;
                this.RaisePropertyChanged("Rut");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("Nombre");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Apellido {
            get {
                return this.apellidoField;
            }
            set {
                this.apellidoField = value;
                this.RaisePropertyChanged("Apellido");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public System.DateTime FechaNacimiento {
            get {
                return this.fechaNacimientoField;
            }
            set {
                this.fechaNacimientoField = value;
                this.RaisePropertyChanged("FechaNacimiento");
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
    public interface wsGuardaDatosAlumnosSoapChannel : CapaGUI.ServiceGuardaDatosAlumnos.wsGuardaDatosAlumnosSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsGuardaDatosAlumnosSoapClient : System.ServiceModel.ClientBase<CapaGUI.ServiceGuardaDatosAlumnos.wsGuardaDatosAlumnosSoap>, CapaGUI.ServiceGuardaDatosAlumnos.wsGuardaDatosAlumnosSoap {
        
        public wsGuardaDatosAlumnosSoapClient() {
        }
        
        public wsGuardaDatosAlumnosSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsGuardaDatosAlumnosSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsGuardaDatosAlumnosSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsGuardaDatosAlumnosSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void agregaAlumno(CapaGUI.ServiceGuardaDatosAlumnos.Alumno alumno) {
            base.Channel.agregaAlumno(alumno);
        }
        
        public System.Threading.Tasks.Task agregaAlumnoAsync(CapaGUI.ServiceGuardaDatosAlumnos.Alumno alumno) {
            return base.Channel.agregaAlumnoAsync(alumno);
        }
        
        public System.Data.DataSet entregaAlumnoDataSet() {
            return base.Channel.entregaAlumnoDataSet();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> entregaAlumnoDataSetAsync() {
            return base.Channel.entregaAlumnoDataSetAsync();
        }
        
        public CapaGUI.ServiceGuardaDatosAlumnos.Alumno[] entregaLargoAlumno() {
            return base.Channel.entregaLargoAlumno();
        }
        
        public System.Threading.Tasks.Task<CapaGUI.ServiceGuardaDatosAlumnos.Alumno[]> entregaLargoAlumnoAsync() {
            return base.Channel.entregaLargoAlumnoAsync();
        }
        
        public CapaGUI.ServiceGuardaDatosAlumnos.Alumno entregaPosicionAlumno(int pos) {
            return base.Channel.entregaPosicionAlumno(pos);
        }
        
        public System.Threading.Tasks.Task<CapaGUI.ServiceGuardaDatosAlumnos.Alumno> entregaPosicionAlumnoAsync(int pos) {
            return base.Channel.entregaPosicionAlumnoAsync(pos);
        }
        
        public CapaGUI.ServiceGuardaDatosAlumnos.Alumno buscarAlumno(string Rut) {
            return base.Channel.buscarAlumno(Rut);
        }
        
        public System.Threading.Tasks.Task<CapaGUI.ServiceGuardaDatosAlumnos.Alumno> buscarAlumnoAsync(string Rut) {
            return base.Channel.buscarAlumnoAsync(Rut);
        }
    }
}
