﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaGUI.srCalculaIMC {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="srCalculaIMC.wsCalculaIMCSoap")]
    public interface wsCalculaIMCSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/calculaIMC", ReplyAction="*")]
        double calculaIMC(double peso, double altura);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/calculaIMC", ReplyAction="*")]
        System.Threading.Tasks.Task<double> calculaIMCAsync(double peso, double altura);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsCalculaIMCSoapChannel : CapaGUI.srCalculaIMC.wsCalculaIMCSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsCalculaIMCSoapClient : System.ServiceModel.ClientBase<CapaGUI.srCalculaIMC.wsCalculaIMCSoap>, CapaGUI.srCalculaIMC.wsCalculaIMCSoap {
        
        public wsCalculaIMCSoapClient() {
        }
        
        public wsCalculaIMCSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsCalculaIMCSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsCalculaIMCSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsCalculaIMCSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double calculaIMC(double peso, double altura) {
            return base.Channel.calculaIMC(peso, altura);
        }
        
        public System.Threading.Tasks.Task<double> calculaIMCAsync(double peso, double altura) {
            return base.Channel.calculaIMCAsync(peso, altura);
        }
    }
}