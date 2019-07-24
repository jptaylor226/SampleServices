﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFWindowsClient.SampleServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SampleServiceReference.ISampleService")]
    public interface ISampleService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/GetValues", ReplyAction="http://tempuri.org/ISampleService/GetValuesResponse")]
        string[] GetValues();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/GetValues", ReplyAction="http://tempuri.org/ISampleService/GetValuesResponse")]
        System.Threading.Tasks.Task<string[]> GetValuesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/GetValue", ReplyAction="http://tempuri.org/ISampleService/GetValueResponse")]
        string GetValue(int index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/GetValue", ReplyAction="http://tempuri.org/ISampleService/GetValueResponse")]
        System.Threading.Tasks.Task<string> GetValueAsync(int index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/PostValue", ReplyAction="http://tempuri.org/ISampleService/PostValueResponse")]
        void PostValue(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/PostValue", ReplyAction="http://tempuri.org/ISampleService/PostValueResponse")]
        System.Threading.Tasks.Task PostValueAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/PutValue", ReplyAction="http://tempuri.org/ISampleService/PutValueResponse")]
        void PutValue(int index, string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/PutValue", ReplyAction="http://tempuri.org/ISampleService/PutValueResponse")]
        System.Threading.Tasks.Task PutValueAsync(int index, string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/DeleteValue", ReplyAction="http://tempuri.org/ISampleService/DeleteValueResponse")]
        void DeleteValue(int index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/DeleteValue", ReplyAction="http://tempuri.org/ISampleService/DeleteValueResponse")]
        System.Threading.Tasks.Task DeleteValueAsync(int index);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISampleServiceChannel : WCFWindowsClient.SampleServiceReference.ISampleService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SampleServiceClient : System.ServiceModel.ClientBase<WCFWindowsClient.SampleServiceReference.ISampleService>, WCFWindowsClient.SampleServiceReference.ISampleService {
        
        public SampleServiceClient() {
        }
        
        public SampleServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SampleServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SampleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SampleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] GetValues() {
            return base.Channel.GetValues();
        }
        
        public System.Threading.Tasks.Task<string[]> GetValuesAsync() {
            return base.Channel.GetValuesAsync();
        }
        
        public string GetValue(int index) {
            return base.Channel.GetValue(index);
        }
        
        public System.Threading.Tasks.Task<string> GetValueAsync(int index) {
            return base.Channel.GetValueAsync(index);
        }
        
        public void PostValue(string value) {
            base.Channel.PostValue(value);
        }
        
        public System.Threading.Tasks.Task PostValueAsync(string value) {
            return base.Channel.PostValueAsync(value);
        }
        
        public void PutValue(int index, string value) {
            base.Channel.PutValue(index, value);
        }
        
        public System.Threading.Tasks.Task PutValueAsync(int index, string value) {
            return base.Channel.PutValueAsync(index, value);
        }
        
        public void DeleteValue(int index) {
            base.Channel.DeleteValue(index);
        }
        
        public System.Threading.Tasks.Task DeleteValueAsync(int index) {
            return base.Channel.DeleteValueAsync(index);
        }
    }
}