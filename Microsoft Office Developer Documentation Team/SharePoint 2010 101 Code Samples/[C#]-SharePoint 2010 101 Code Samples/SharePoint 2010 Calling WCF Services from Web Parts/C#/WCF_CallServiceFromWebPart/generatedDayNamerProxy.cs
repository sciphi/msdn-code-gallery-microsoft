﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Name="http://WCF_ExampleService", ConfigurationName="httpWCF_ExampleService")]
public interface httpWCF_ExampleService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/http_x003A__x002F__x002F_WCF_ExampleService/TodayIs", ReplyAction="http://tempuri.org/http_x003A__x002F__x002F_WCF_ExampleService/TodayIsResponse")]
    string TodayIs();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/http_x003A__x002F__x002F_WCF_ExampleService/TodayAdd", ReplyAction="http://tempuri.org/http_x003A__x002F__x002F_WCF_ExampleService/TodayAddResponse")]
    string TodayAdd(int daysToAdd);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface httpWCF_ExampleServiceChannel : httpWCF_ExampleService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class httpWCF_ExampleServiceClient : System.ServiceModel.ClientBase<httpWCF_ExampleService>, httpWCF_ExampleService
{
    
    public httpWCF_ExampleServiceClient()
    {
    }
    
    public httpWCF_ExampleServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public httpWCF_ExampleServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public httpWCF_ExampleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public httpWCF_ExampleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public string TodayIs()
    {
        return base.Channel.TodayIs();
    }
    
    public string TodayAdd(int daysToAdd)
    {
        return base.Channel.TodayAdd(daysToAdd);
    }
}
