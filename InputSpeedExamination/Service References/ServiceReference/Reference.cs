﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InputSpeedExamination.ServiceReference {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="WebService", ConfigurationName="ServiceReference.HelloServerSoap")]
    public interface HelloServerSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/SayHello", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string SayHello(string data);
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/GetAllDepartment", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetAllDepartment();
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/GetMajorByDepartment", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetMajorByDepartment(string DepartmentID);
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/GetUpdateList", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetUpdateList();
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/GetEdu", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetEdu(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/GetUserInfo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetUserInfo(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/GetClientIP", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetClientIP();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface HelloServerSoapChannel : InputSpeedExamination.ServiceReference.HelloServerSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloServerSoapClient : System.ServiceModel.ClientBase<InputSpeedExamination.ServiceReference.HelloServerSoap>, InputSpeedExamination.ServiceReference.HelloServerSoap {
        
        public HelloServerSoapClient() {
        }
        
        public HelloServerSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HelloServerSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloServerSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloServerSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string SayHello(string data) {
            return base.Channel.SayHello(data);
        }
        
        public System.Data.DataSet GetAllDepartment() {
            return base.Channel.GetAllDepartment();
        }
        
        public System.Data.DataSet GetMajorByDepartment(string DepartmentID) {
            return base.Channel.GetMajorByDepartment(DepartmentID);
        }
        
        public System.Data.DataSet GetUpdateList() {
            return base.Channel.GetUpdateList();
        }
        
        public string GetEdu(string username, string password) {
            return base.Channel.GetEdu(username, password);
        }
        
        public string GetUserInfo(string username, string password) {
            return base.Channel.GetUserInfo(username, password);
        }
        
        public string GetClientIP() {
            return base.Channel.GetClientIP();
        }
    }
}
