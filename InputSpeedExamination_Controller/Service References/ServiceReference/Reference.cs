﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InputSpeedExamination_Controller.ServiceReference {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="WebService", ConfigurationName="ServiceReference.ControllerServiceSoap")]
    public interface ControllerServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/GetStats", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetStats(string BatchID, string RoomID);
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/GetExamRoomList", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetExamRoomList();
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/CreateNewExamRoom", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string CreateNewExamRoom(string RoomTitle, string IncludeIP);
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/EditExamRoom", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string EditExamRoom(string RoomID, string RoomTitle, string IncludeIP);
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/DeleteExamRoom", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool DeleteExamRoom(string RoomID);
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/GetAllContent", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetAllContent();
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/CreateNewContent", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string CreateNewContent(string Title, string Content);
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/UpdateContent", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string UpdateContent(string ContentID, string Title, string Content);
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/DeleteContent", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool DeleteContent(string ContentID);
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/GetContentByPaperID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetContentByPaperID(string IncludePaper);
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/GetContentByBatchID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetContentByBatchID(string BatchID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ControllerServiceSoapChannel : InputSpeedExamination_Controller.ServiceReference.ControllerServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ControllerServiceSoapClient : System.ServiceModel.ClientBase<InputSpeedExamination_Controller.ServiceReference.ControllerServiceSoap>, InputSpeedExamination_Controller.ServiceReference.ControllerServiceSoap {
        
        public ControllerServiceSoapClient() {
        }
        
        public ControllerServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ControllerServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ControllerServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ControllerServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet GetStats(string BatchID, string RoomID) {
            return base.Channel.GetStats(BatchID, RoomID);
        }
        
        public System.Data.DataSet GetExamRoomList() {
            return base.Channel.GetExamRoomList();
        }
        
        public string CreateNewExamRoom(string RoomTitle, string IncludeIP) {
            return base.Channel.CreateNewExamRoom(RoomTitle, IncludeIP);
        }
        
        public string EditExamRoom(string RoomID, string RoomTitle, string IncludeIP) {
            return base.Channel.EditExamRoom(RoomID, RoomTitle, IncludeIP);
        }
        
        public bool DeleteExamRoom(string RoomID) {
            return base.Channel.DeleteExamRoom(RoomID);
        }
        
        public System.Data.DataSet GetAllContent() {
            return base.Channel.GetAllContent();
        }
        
        public string CreateNewContent(string Title, string Content) {
            return base.Channel.CreateNewContent(Title, Content);
        }
        
        public string UpdateContent(string ContentID, string Title, string Content) {
            return base.Channel.UpdateContent(ContentID, Title, Content);
        }
        
        public bool DeleteContent(string ContentID) {
            return base.Channel.DeleteContent(ContentID);
        }
        
        public System.Data.DataSet GetContentByPaperID(string IncludePaper) {
            return base.Channel.GetContentByPaperID(IncludePaper);
        }
        
        public System.Data.DataSet GetContentByBatchID(string BatchID) {
            return base.Channel.GetContentByBatchID(BatchID);
        }
    }
}
