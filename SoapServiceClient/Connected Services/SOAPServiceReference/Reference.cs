﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoapServiceClient.SOAPServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SOAPServiceReference.SOAPWebServiceSoap")]
    public interface SOAPWebServiceSoap {
        
        // CODEGEN : La génération du contrat de message depuis le nom d'élément HelloWorldResult de l'espace de noms http://tempuri.org/ n'est pas marqué nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        SoapServiceClient.SOAPServiceReference.HelloWorldResponse HelloWorld(SoapServiceClient.SOAPServiceReference.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<SoapServiceClient.SOAPServiceReference.HelloWorldResponse> HelloWorldAsync(SoapServiceClient.SOAPServiceReference.HelloWorldRequest request);
        
        // CODEGEN : La génération du contrat de message depuis le nom d'élément number de l'espace de noms http://tempuri.org/ n'est pas marqué nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Fibonacci", ReplyAction="*")]
        SoapServiceClient.SOAPServiceReference.FibonacciResponse Fibonacci(SoapServiceClient.SOAPServiceReference.FibonacciRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Fibonacci", ReplyAction="*")]
        System.Threading.Tasks.Task<SoapServiceClient.SOAPServiceReference.FibonacciResponse> FibonacciAsync(SoapServiceClient.SOAPServiceReference.FibonacciRequest request);
        
        // CODEGEN : La génération du contrat de message depuis le nom d'élément xmlString de l'espace de noms http://tempuri.org/ n'est pas marqué nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/XmlToJson", ReplyAction="*")]
        SoapServiceClient.SOAPServiceReference.XmlToJsonResponse XmlToJson(SoapServiceClient.SOAPServiceReference.XmlToJsonRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/XmlToJson", ReplyAction="*")]
        System.Threading.Tasks.Task<SoapServiceClient.SOAPServiceReference.XmlToJsonResponse> XmlToJsonAsync(SoapServiceClient.SOAPServiceReference.XmlToJsonRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public SoapServiceClient.SOAPServiceReference.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(SoapServiceClient.SOAPServiceReference.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public SoapServiceClient.SOAPServiceReference.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(SoapServiceClient.SOAPServiceReference.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FibonacciRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Fibonacci", Namespace="http://tempuri.org/", Order=0)]
        public SoapServiceClient.SOAPServiceReference.FibonacciRequestBody Body;
        
        public FibonacciRequest() {
        }
        
        public FibonacciRequest(SoapServiceClient.SOAPServiceReference.FibonacciRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FibonacciRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string number;
        
        public FibonacciRequestBody() {
        }
        
        public FibonacciRequestBody(string number) {
            this.number = number;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FibonacciResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FibonacciResponse", Namespace="http://tempuri.org/", Order=0)]
        public SoapServiceClient.SOAPServiceReference.FibonacciResponseBody Body;
        
        public FibonacciResponse() {
        }
        
        public FibonacciResponse(SoapServiceClient.SOAPServiceReference.FibonacciResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FibonacciResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public long FibonacciResult;
        
        public FibonacciResponseBody() {
        }
        
        public FibonacciResponseBody(long FibonacciResult) {
            this.FibonacciResult = FibonacciResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class XmlToJsonRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="XmlToJson", Namespace="http://tempuri.org/", Order=0)]
        public SoapServiceClient.SOAPServiceReference.XmlToJsonRequestBody Body;
        
        public XmlToJsonRequest() {
        }
        
        public XmlToJsonRequest(SoapServiceClient.SOAPServiceReference.XmlToJsonRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class XmlToJsonRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string xmlString;
        
        public XmlToJsonRequestBody() {
        }
        
        public XmlToJsonRequestBody(string xmlString) {
            this.xmlString = xmlString;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class XmlToJsonResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="XmlToJsonResponse", Namespace="http://tempuri.org/", Order=0)]
        public SoapServiceClient.SOAPServiceReference.XmlToJsonResponseBody Body;
        
        public XmlToJsonResponse() {
        }
        
        public XmlToJsonResponse(SoapServiceClient.SOAPServiceReference.XmlToJsonResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class XmlToJsonResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string XmlToJsonResult;
        
        public XmlToJsonResponseBody() {
        }
        
        public XmlToJsonResponseBody(string XmlToJsonResult) {
            this.XmlToJsonResult = XmlToJsonResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SOAPWebServiceSoapChannel : SoapServiceClient.SOAPServiceReference.SOAPWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SOAPWebServiceSoapClient : System.ServiceModel.ClientBase<SoapServiceClient.SOAPServiceReference.SOAPWebServiceSoap>, SoapServiceClient.SOAPServiceReference.SOAPWebServiceSoap {
        
        public SOAPWebServiceSoapClient() {
        }
        
        public SOAPWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SOAPWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SOAPWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SOAPWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SoapServiceClient.SOAPServiceReference.HelloWorldResponse SoapServiceClient.SOAPServiceReference.SOAPWebServiceSoap.HelloWorld(SoapServiceClient.SOAPServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            SoapServiceClient.SOAPServiceReference.HelloWorldRequest inValue = new SoapServiceClient.SOAPServiceReference.HelloWorldRequest();
            inValue.Body = new SoapServiceClient.SOAPServiceReference.HelloWorldRequestBody();
            SoapServiceClient.SOAPServiceReference.HelloWorldResponse retVal = ((SoapServiceClient.SOAPServiceReference.SOAPWebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SoapServiceClient.SOAPServiceReference.HelloWorldResponse> SoapServiceClient.SOAPServiceReference.SOAPWebServiceSoap.HelloWorldAsync(SoapServiceClient.SOAPServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<SoapServiceClient.SOAPServiceReference.HelloWorldResponse> HelloWorldAsync() {
            SoapServiceClient.SOAPServiceReference.HelloWorldRequest inValue = new SoapServiceClient.SOAPServiceReference.HelloWorldRequest();
            inValue.Body = new SoapServiceClient.SOAPServiceReference.HelloWorldRequestBody();
            return ((SoapServiceClient.SOAPServiceReference.SOAPWebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SoapServiceClient.SOAPServiceReference.FibonacciResponse SoapServiceClient.SOAPServiceReference.SOAPWebServiceSoap.Fibonacci(SoapServiceClient.SOAPServiceReference.FibonacciRequest request) {
            return base.Channel.Fibonacci(request);
        }
        
        public long Fibonacci(string number) {
            SoapServiceClient.SOAPServiceReference.FibonacciRequest inValue = new SoapServiceClient.SOAPServiceReference.FibonacciRequest();
            inValue.Body = new SoapServiceClient.SOAPServiceReference.FibonacciRequestBody();
            inValue.Body.number = number;
            SoapServiceClient.SOAPServiceReference.FibonacciResponse retVal = ((SoapServiceClient.SOAPServiceReference.SOAPWebServiceSoap)(this)).Fibonacci(inValue);
            return retVal.Body.FibonacciResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SoapServiceClient.SOAPServiceReference.FibonacciResponse> SoapServiceClient.SOAPServiceReference.SOAPWebServiceSoap.FibonacciAsync(SoapServiceClient.SOAPServiceReference.FibonacciRequest request) {
            return base.Channel.FibonacciAsync(request);
        }
        
        public System.Threading.Tasks.Task<SoapServiceClient.SOAPServiceReference.FibonacciResponse> FibonacciAsync(string number) {
            SoapServiceClient.SOAPServiceReference.FibonacciRequest inValue = new SoapServiceClient.SOAPServiceReference.FibonacciRequest();
            inValue.Body = new SoapServiceClient.SOAPServiceReference.FibonacciRequestBody();
            inValue.Body.number = number;
            return ((SoapServiceClient.SOAPServiceReference.SOAPWebServiceSoap)(this)).FibonacciAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SoapServiceClient.SOAPServiceReference.XmlToJsonResponse SoapServiceClient.SOAPServiceReference.SOAPWebServiceSoap.XmlToJson(SoapServiceClient.SOAPServiceReference.XmlToJsonRequest request) {
            return base.Channel.XmlToJson(request);
        }
        
        public string XmlToJson(string xmlString) {
            SoapServiceClient.SOAPServiceReference.XmlToJsonRequest inValue = new SoapServiceClient.SOAPServiceReference.XmlToJsonRequest();
            inValue.Body = new SoapServiceClient.SOAPServiceReference.XmlToJsonRequestBody();
            inValue.Body.xmlString = xmlString;
            SoapServiceClient.SOAPServiceReference.XmlToJsonResponse retVal = ((SoapServiceClient.SOAPServiceReference.SOAPWebServiceSoap)(this)).XmlToJson(inValue);
            return retVal.Body.XmlToJsonResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SoapServiceClient.SOAPServiceReference.XmlToJsonResponse> SoapServiceClient.SOAPServiceReference.SOAPWebServiceSoap.XmlToJsonAsync(SoapServiceClient.SOAPServiceReference.XmlToJsonRequest request) {
            return base.Channel.XmlToJsonAsync(request);
        }
        
        public System.Threading.Tasks.Task<SoapServiceClient.SOAPServiceReference.XmlToJsonResponse> XmlToJsonAsync(string xmlString) {
            SoapServiceClient.SOAPServiceReference.XmlToJsonRequest inValue = new SoapServiceClient.SOAPServiceReference.XmlToJsonRequest();
            inValue.Body = new SoapServiceClient.SOAPServiceReference.XmlToJsonRequestBody();
            inValue.Body.xmlString = xmlString;
            return ((SoapServiceClient.SOAPServiceReference.SOAPWebServiceSoap)(this)).XmlToJsonAsync(inValue);
        }
    }
}
