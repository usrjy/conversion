﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Auth
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:Core.service.livelink.opentext.com", ConfigurationName="Auth.Authentication")]
    public interface Authentication
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:Core.service.livelink.opentext.com/AuthenticateApplication", ReplyAction="urn:Core.service.livelink.opentext.com/Authentication/AuthenticateApplicationResp" +
            "onse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Auth.AuthenticateApplicationResponse> AuthenticateApplicationAsync(Auth.AuthenticateApplicationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:Core.service.livelink.opentext.com/AuthenticateUser", ReplyAction="urn:Core.service.livelink.opentext.com/Authentication/AuthenticateUserResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> AuthenticateUserAsync(string userName, string userPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:Core.service.livelink.opentext.com/AuthenticateUserWithApplicationToken", ReplyAction="urn:Core.service.livelink.opentext.com/Authentication/AuthenticateUserWithApplica" +
            "tionTokenResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> AuthenticateUserWithApplicationTokenAsync(string userName, string userPassword, string applicationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:Core.service.livelink.opentext.com/CombineApplicationToken", ReplyAction="urn:Core.service.livelink.opentext.com/Authentication/CombineApplicationTokenResp" +
            "onse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Auth.CombineApplicationTokenResponse> CombineApplicationTokenAsync(Auth.CombineApplicationTokenRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:Core.service.livelink.opentext.com/GetOTDSResourceID", ReplyAction="urn:Core.service.livelink.opentext.com/Authentication/GetOTDSResourceIDResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> GetOTDSResourceIDAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:Core.service.livelink.opentext.com/GetOTDSServer", ReplyAction="urn:Core.service.livelink.opentext.com/Authentication/GetOTDSServerResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> GetOTDSServerAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:Core.service.livelink.opentext.com/GetSessionExpirationDate", ReplyAction="urn:Core.service.livelink.opentext.com/Authentication/GetSessionExpirationDateRes" +
            "ponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Auth.GetSessionExpirationDateResponse> GetSessionExpirationDateAsync(Auth.GetSessionExpirationDateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:Core.service.livelink.opentext.com/ImpersonateApplication", ReplyAction="urn:Core.service.livelink.opentext.com/Authentication/ImpersonateApplicationRespo" +
            "nse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Auth.ImpersonateApplicationResponse> ImpersonateApplicationAsync(Auth.ImpersonateApplicationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:Core.service.livelink.opentext.com/ImpersonateUser", ReplyAction="urn:Core.service.livelink.opentext.com/Authentication/ImpersonateUserResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Auth.ImpersonateUserResponse> ImpersonateUserAsync(Auth.ImpersonateUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:Core.service.livelink.opentext.com/RefreshToken", ReplyAction="urn:Core.service.livelink.opentext.com/Authentication/RefreshTokenResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Auth.RefreshTokenResponse> RefreshTokenAsync(Auth.RefreshTokenRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:Core.service.livelink.opentext.com/ValidateUser", ReplyAction="urn:Core.service.livelink.opentext.com/Authentication/ValidateUserResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> ValidateUserAsync(string capToken);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:api.ecm.opentext.com")]
    public partial class OTAuthentication
    {
        
        private string authenticationTokenField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string AuthenticationToken
        {
            get
            {
                return this.authenticationTokenField;
            }
            set
            {
                this.authenticationTokenField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AuthenticateApplication", WrapperNamespace="urn:Core.service.livelink.opentext.com", IsWrapped=true)]
    public partial class AuthenticateApplicationRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:api.ecm.opentext.com")]
        public Auth.OTAuthentication OTAuthentication;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:Core.service.livelink.opentext.com", Order=0)]
        public string applicationID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:Core.service.livelink.opentext.com", Order=1)]
        public string password;
        
        public AuthenticateApplicationRequest()
        {
        }
        
        public AuthenticateApplicationRequest(Auth.OTAuthentication OTAuthentication, string applicationID, string password)
        {
            this.OTAuthentication = OTAuthentication;
            this.applicationID = applicationID;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AuthenticateApplicationResponse", WrapperNamespace="urn:Core.service.livelink.opentext.com", IsWrapped=true)]
    public partial class AuthenticateApplicationResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:api.ecm.opentext.com")]
        public Auth.OTAuthentication OTAuthentication;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:Core.service.livelink.opentext.com", Order=0)]
        public string AuthenticateApplicationResult;
        
        public AuthenticateApplicationResponse()
        {
        }
        
        public AuthenticateApplicationResponse(Auth.OTAuthentication OTAuthentication, string AuthenticateApplicationResult)
        {
            this.OTAuthentication = OTAuthentication;
            this.AuthenticateApplicationResult = AuthenticateApplicationResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CombineApplicationToken", WrapperNamespace="urn:Core.service.livelink.opentext.com", IsWrapped=true)]
    public partial class CombineApplicationTokenRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:api.ecm.opentext.com")]
        public Auth.OTAuthentication OTAuthentication;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:Core.service.livelink.opentext.com", Order=0)]
        public string applicationToken;
        
        public CombineApplicationTokenRequest()
        {
        }
        
        public CombineApplicationTokenRequest(Auth.OTAuthentication OTAuthentication, string applicationToken)
        {
            this.OTAuthentication = OTAuthentication;
            this.applicationToken = applicationToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CombineApplicationTokenResponse", WrapperNamespace="urn:Core.service.livelink.opentext.com", IsWrapped=true)]
    public partial class CombineApplicationTokenResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:api.ecm.opentext.com")]
        public Auth.OTAuthentication OTAuthentication;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:Core.service.livelink.opentext.com", Order=0)]
        public string CombineApplicationTokenResult;
        
        public CombineApplicationTokenResponse()
        {
        }
        
        public CombineApplicationTokenResponse(Auth.OTAuthentication OTAuthentication, string CombineApplicationTokenResult)
        {
            this.OTAuthentication = OTAuthentication;
            this.CombineApplicationTokenResult = CombineApplicationTokenResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetSessionExpirationDate", WrapperNamespace="urn:Core.service.livelink.opentext.com", IsWrapped=true)]
    public partial class GetSessionExpirationDateRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:api.ecm.opentext.com")]
        public Auth.OTAuthentication OTAuthentication;
        
        public GetSessionExpirationDateRequest()
        {
        }
        
        public GetSessionExpirationDateRequest(Auth.OTAuthentication OTAuthentication)
        {
            this.OTAuthentication = OTAuthentication;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetSessionExpirationDateResponse", WrapperNamespace="urn:Core.service.livelink.opentext.com", IsWrapped=true)]
    public partial class GetSessionExpirationDateResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:api.ecm.opentext.com")]
        public Auth.OTAuthentication OTAuthentication;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:Core.service.livelink.opentext.com", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> GetSessionExpirationDateResult;
        
        public GetSessionExpirationDateResponse()
        {
        }
        
        public GetSessionExpirationDateResponse(Auth.OTAuthentication OTAuthentication, System.Nullable<System.DateTime> GetSessionExpirationDateResult)
        {
            this.OTAuthentication = OTAuthentication;
            this.GetSessionExpirationDateResult = GetSessionExpirationDateResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ImpersonateApplication", WrapperNamespace="urn:Core.service.livelink.opentext.com", IsWrapped=true)]
    public partial class ImpersonateApplicationRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:api.ecm.opentext.com")]
        public Auth.OTAuthentication OTAuthentication;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:Core.service.livelink.opentext.com", Order=0)]
        public string applicationID;
        
        public ImpersonateApplicationRequest()
        {
        }
        
        public ImpersonateApplicationRequest(Auth.OTAuthentication OTAuthentication, string applicationID)
        {
            this.OTAuthentication = OTAuthentication;
            this.applicationID = applicationID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ImpersonateApplicationResponse", WrapperNamespace="urn:Core.service.livelink.opentext.com", IsWrapped=true)]
    public partial class ImpersonateApplicationResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:api.ecm.opentext.com")]
        public Auth.OTAuthentication OTAuthentication;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:Core.service.livelink.opentext.com", Order=0)]
        public string ImpersonateApplicationResult;
        
        public ImpersonateApplicationResponse()
        {
        }
        
        public ImpersonateApplicationResponse(Auth.OTAuthentication OTAuthentication, string ImpersonateApplicationResult)
        {
            this.OTAuthentication = OTAuthentication;
            this.ImpersonateApplicationResult = ImpersonateApplicationResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ImpersonateUser", WrapperNamespace="urn:Core.service.livelink.opentext.com", IsWrapped=true)]
    public partial class ImpersonateUserRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:api.ecm.opentext.com")]
        public Auth.OTAuthentication OTAuthentication;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:Core.service.livelink.opentext.com", Order=0)]
        public string userName;
        
        public ImpersonateUserRequest()
        {
        }
        
        public ImpersonateUserRequest(Auth.OTAuthentication OTAuthentication, string userName)
        {
            this.OTAuthentication = OTAuthentication;
            this.userName = userName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ImpersonateUserResponse", WrapperNamespace="urn:Core.service.livelink.opentext.com", IsWrapped=true)]
    public partial class ImpersonateUserResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:api.ecm.opentext.com")]
        public Auth.OTAuthentication OTAuthentication;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:Core.service.livelink.opentext.com", Order=0)]
        public string ImpersonateUserResult;
        
        public ImpersonateUserResponse()
        {
        }
        
        public ImpersonateUserResponse(Auth.OTAuthentication OTAuthentication, string ImpersonateUserResult)
        {
            this.OTAuthentication = OTAuthentication;
            this.ImpersonateUserResult = ImpersonateUserResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RefreshToken", WrapperNamespace="urn:Core.service.livelink.opentext.com", IsWrapped=true)]
    public partial class RefreshTokenRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:api.ecm.opentext.com")]
        public Auth.OTAuthentication OTAuthentication;
        
        public RefreshTokenRequest()
        {
        }
        
        public RefreshTokenRequest(Auth.OTAuthentication OTAuthentication)
        {
            this.OTAuthentication = OTAuthentication;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RefreshTokenResponse", WrapperNamespace="urn:Core.service.livelink.opentext.com", IsWrapped=true)]
    public partial class RefreshTokenResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:api.ecm.opentext.com")]
        public Auth.OTAuthentication OTAuthentication;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:Core.service.livelink.opentext.com", Order=0)]
        public string RefreshTokenResult;
        
        public RefreshTokenResponse()
        {
        }
        
        public RefreshTokenResponse(Auth.OTAuthentication OTAuthentication, string RefreshTokenResult)
        {
            this.OTAuthentication = OTAuthentication;
            this.RefreshTokenResult = RefreshTokenResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface AuthenticationChannel : Auth.Authentication, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class AuthenticationClient : System.ServiceModel.ClientBase<Auth.Authentication>, Auth.Authentication
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public AuthenticationClient() : 
                base(AuthenticationClient.GetDefaultBinding(), AuthenticationClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_Authentication.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AuthenticationClient(EndpointConfiguration endpointConfiguration) : 
                base(AuthenticationClient.GetBindingForEndpoint(endpointConfiguration), AuthenticationClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AuthenticationClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(AuthenticationClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AuthenticationClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(AuthenticationClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AuthenticationClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Auth.AuthenticateApplicationResponse> Auth.Authentication.AuthenticateApplicationAsync(Auth.AuthenticateApplicationRequest request)
        {
            return base.Channel.AuthenticateApplicationAsync(request);
        }
        
        public System.Threading.Tasks.Task<Auth.AuthenticateApplicationResponse> AuthenticateApplicationAsync(Auth.OTAuthentication OTAuthentication, string applicationID, string password)
        {
            Auth.AuthenticateApplicationRequest inValue = new Auth.AuthenticateApplicationRequest();
            inValue.OTAuthentication = OTAuthentication;
            inValue.applicationID = applicationID;
            inValue.password = password;
            return ((Auth.Authentication)(this)).AuthenticateApplicationAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<string> AuthenticateUserAsync(string userName, string userPassword)
        {
            return base.Channel.AuthenticateUserAsync(userName, userPassword);
        }
        
        public System.Threading.Tasks.Task<string> AuthenticateUserWithApplicationTokenAsync(string userName, string userPassword, string applicationToken)
        {
            return base.Channel.AuthenticateUserWithApplicationTokenAsync(userName, userPassword, applicationToken);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Auth.CombineApplicationTokenResponse> Auth.Authentication.CombineApplicationTokenAsync(Auth.CombineApplicationTokenRequest request)
        {
            return base.Channel.CombineApplicationTokenAsync(request);
        }
        
        public System.Threading.Tasks.Task<Auth.CombineApplicationTokenResponse> CombineApplicationTokenAsync(Auth.OTAuthentication OTAuthentication, string applicationToken)
        {
            Auth.CombineApplicationTokenRequest inValue = new Auth.CombineApplicationTokenRequest();
            inValue.OTAuthentication = OTAuthentication;
            inValue.applicationToken = applicationToken;
            return ((Auth.Authentication)(this)).CombineApplicationTokenAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<string> GetOTDSResourceIDAsync()
        {
            return base.Channel.GetOTDSResourceIDAsync();
        }
        
        public System.Threading.Tasks.Task<string> GetOTDSServerAsync()
        {
            return base.Channel.GetOTDSServerAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Auth.GetSessionExpirationDateResponse> Auth.Authentication.GetSessionExpirationDateAsync(Auth.GetSessionExpirationDateRequest request)
        {
            return base.Channel.GetSessionExpirationDateAsync(request);
        }
        
        public System.Threading.Tasks.Task<Auth.GetSessionExpirationDateResponse> GetSessionExpirationDateAsync(Auth.OTAuthentication OTAuthentication)
        {
            Auth.GetSessionExpirationDateRequest inValue = new Auth.GetSessionExpirationDateRequest();
            inValue.OTAuthentication = OTAuthentication;
            return ((Auth.Authentication)(this)).GetSessionExpirationDateAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Auth.ImpersonateApplicationResponse> Auth.Authentication.ImpersonateApplicationAsync(Auth.ImpersonateApplicationRequest request)
        {
            return base.Channel.ImpersonateApplicationAsync(request);
        }
        
        public System.Threading.Tasks.Task<Auth.ImpersonateApplicationResponse> ImpersonateApplicationAsync(Auth.OTAuthentication OTAuthentication, string applicationID)
        {
            Auth.ImpersonateApplicationRequest inValue = new Auth.ImpersonateApplicationRequest();
            inValue.OTAuthentication = OTAuthentication;
            inValue.applicationID = applicationID;
            return ((Auth.Authentication)(this)).ImpersonateApplicationAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Auth.ImpersonateUserResponse> Auth.Authentication.ImpersonateUserAsync(Auth.ImpersonateUserRequest request)
        {
            return base.Channel.ImpersonateUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<Auth.ImpersonateUserResponse> ImpersonateUserAsync(Auth.OTAuthentication OTAuthentication, string userName)
        {
            Auth.ImpersonateUserRequest inValue = new Auth.ImpersonateUserRequest();
            inValue.OTAuthentication = OTAuthentication;
            inValue.userName = userName;
            return ((Auth.Authentication)(this)).ImpersonateUserAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Auth.RefreshTokenResponse> Auth.Authentication.RefreshTokenAsync(Auth.RefreshTokenRequest request)
        {
            return base.Channel.RefreshTokenAsync(request);
        }
        
        public System.Threading.Tasks.Task<Auth.RefreshTokenResponse> RefreshTokenAsync(Auth.OTAuthentication OTAuthentication)
        {
            Auth.RefreshTokenRequest inValue = new Auth.RefreshTokenRequest();
            inValue.OTAuthentication = OTAuthentication;
            return ((Auth.Authentication)(this)).RefreshTokenAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<string> ValidateUserAsync(string capToken)
        {
            return base.Channel.ValidateUserAsync(capToken);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_Authentication))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_Authentication))
            {
                return new System.ServiceModel.EndpointAddress("http://devoracleapp.devlan.com/cws/Authentication.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return AuthenticationClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_Authentication);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return AuthenticationClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_Authentication);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_Authentication,
        }
    }
}
