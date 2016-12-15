﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Update.ServiceReference {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="WebService", ConfigurationName="ServiceReference.ClientServiceSoap")]
    public interface ClientServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/SayHello", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string SayHello(string data);
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/GetAllDepartment", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetAllDepartment();
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/GetMajorByDepartment", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetMajorByDepartment(string DepartmentID);
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/GetEdu", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetEdu(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/GetUserInfo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetUserInfo(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/GetClientIP", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetClientIP();
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/GetExaminationGUID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetExaminationGUID(string Number, string Department, string Major, string Class, string Name, string ContentMD5, string ContentTitle, string BatchID, string RoomID);
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/UpdateExaminationStats", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool UpdateExaminationStats(string GUID, string Stats, string Speed, string Process, string CorrectPercent);
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/GetUpdateInterVal", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int GetUpdateInterVal();
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/GetAllContent", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetAllContent();
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/GetExamRoomID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetExamRoomID();
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/GetExamRoomTitle", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetExamRoomTitle();
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/GetBatchTitle", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetBatchTitle();
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/GetBatchID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetBatchID();
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/GetContentByBatchID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetContentByBatchID(string BatchID);
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/UpdateFinallyScore", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string UpdateFinallyScore(string GUID, string Speed, string Process, string CorrectPercent);
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/GetOnlineRank", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetOnlineRank(string GUID);
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/GetUpdateList", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetUpdateList();
        
        [System.ServiceModel.OperationContractAttribute(Action="WebService/GetAllContentOnlineBatch", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetAllContentOnlineBatch();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ClientServiceSoapChannel : Update.ServiceReference.ClientServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClientServiceSoapClient : System.ServiceModel.ClientBase<Update.ServiceReference.ClientServiceSoap>, Update.ServiceReference.ClientServiceSoap {
        
        public ClientServiceSoapClient() {
        }
        
        public ClientServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClientServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
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
        
        public string GetEdu(string username, string password) {
            return base.Channel.GetEdu(username, password);
        }
        
        public string GetUserInfo(string username, string password) {
            return base.Channel.GetUserInfo(username, password);
        }
        
        public string GetClientIP() {
            return base.Channel.GetClientIP();
        }
        
        public string GetExaminationGUID(string Number, string Department, string Major, string Class, string Name, string ContentMD5, string ContentTitle, string BatchID, string RoomID) {
            return base.Channel.GetExaminationGUID(Number, Department, Major, Class, Name, ContentMD5, ContentTitle, BatchID, RoomID);
        }
        
        public bool UpdateExaminationStats(string GUID, string Stats, string Speed, string Process, string CorrectPercent) {
            return base.Channel.UpdateExaminationStats(GUID, Stats, Speed, Process, CorrectPercent);
        }
        
        public int GetUpdateInterVal() {
            return base.Channel.GetUpdateInterVal();
        }
        
        public System.Data.DataSet GetAllContent() {
            return base.Channel.GetAllContent();
        }
        
        public string GetExamRoomID() {
            return base.Channel.GetExamRoomID();
        }
        
        public string GetExamRoomTitle() {
            return base.Channel.GetExamRoomTitle();
        }
        
        public string GetBatchTitle() {
            return base.Channel.GetBatchTitle();
        }
        
        public string GetBatchID() {
            return base.Channel.GetBatchID();
        }
        
        public System.Data.DataSet GetContentByBatchID(string BatchID) {
            return base.Channel.GetContentByBatchID(BatchID);
        }
        
        public string UpdateFinallyScore(string GUID, string Speed, string Process, string CorrectPercent) {
            return base.Channel.UpdateFinallyScore(GUID, Speed, Process, CorrectPercent);
        }
        
        public string GetOnlineRank(string GUID) {
            return base.Channel.GetOnlineRank(GUID);
        }
        
        public System.Data.DataSet GetUpdateList() {
            return base.Channel.GetUpdateList();
        }
        
        public System.Data.DataSet GetAllContentOnlineBatch() {
            return base.Channel.GetAllContentOnlineBatch();
        }
    }
}
