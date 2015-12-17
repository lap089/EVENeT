﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 14.0.23107.0
// 
namespace EVENeT.EVENeTServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EVENeTServiceReference.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UsernameExists", ReplyAction="http://tempuri.org/IService/UsernameExistsResponse")]
        System.Threading.Tasks.Task<bool> UsernameExistsAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CorrectUserNameAndPassword", ReplyAction="http://tempuri.org/IService/CorrectUserNameAndPasswordResponse")]
        System.Threading.Tasks.Task<bool> CorrectUserNameAndPasswordAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/IndividualFullySetUp", ReplyAction="http://tempuri.org/IService/IndividualFullySetUpResponse")]
        System.Threading.Tasks.Task<bool> IndividualFullySetUpAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SetIndividualInfo", ReplyAction="http://tempuri.org/IService/SetIndividualInfoResponse")]
        System.Threading.Tasks.Task SetIndividualInfoAsync(string username, string firstName, string midName, string lastName, System.DateTime dob, bool gender);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SetOrganizationInfo", ReplyAction="http://tempuri.org/IService/SetOrganizationInfoResponse")]
        System.Threading.Tasks.Task SetOrganizationInfoAsync(string username, string name, string description, string type, string phone, string website);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SetProfilePicture", ReplyAction="http://tempuri.org/IService/SetProfilePictureResponse")]
        System.Threading.Tasks.Task SetProfilePictureAsync(string username, string imagePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SetCoverPicture", ReplyAction="http://tempuri.org/IService/SetCoverPictureResponse")]
        System.Threading.Tasks.Task SetCoverPictureAsync(string username, string imagePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UserType", ReplyAction="http://tempuri.org/IService/UserTypeResponse")]
        System.Threading.Tasks.Task<int> UserTypeAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CreateIndividual", ReplyAction="http://tempuri.org/IService/CreateIndividualResponse")]
        System.Threading.Tasks.Task CreateIndividualAsync(string username, string password, string profilePic, string cover, string firstName, string midName, string lastName, System.DateTime dob, bool gender);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CreateOrganization", ReplyAction="http://tempuri.org/IService/CreateOrganizationResponse")]
        System.Threading.Tasks.Task CreateOrganizationAsync(string username, string password, string name, string logo, string cover, string description, string type, string phone, string website);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CreateEvent", ReplyAction="http://tempuri.org/IService/CreateEventResponse")]
        System.Threading.Tasks.Task<bool> CreateEventAsync(System.DateTime beginTime, System.DateTime endTime, string description, string thumbnail, string title, int ticket, int locationId, string currentUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CreateLocation", ReplyAction="http://tempuri.org/IService/CreateLocationResponse")]
        System.Threading.Tasks.Task CreateLocationAsync(string name, string description, string address, double longitude, double latitude, string thumbnail);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetLocationFromAddress", ReplyAction="http://tempuri.org/IService/GetLocationFromAddressResponse")]
        System.Threading.Tasks.Task<int> GetLocationFromAddressAsync(string address);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetIndividual", ReplyAction="http://tempuri.org/IService/GetIndividualResponse")]
        System.Threading.Tasks.Task<EVENeT.EVENeTServiceReference.GetIndividualResponse> GetIndividualAsync(EVENeT.EVENeTServiceReference.GetIndividualRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Follow", ReplyAction="http://tempuri.org/IService/FollowResponse")]
        System.Threading.Tasks.Task FollowAsync(string username, string userToFollow);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/IsFollowing", ReplyAction="http://tempuri.org/IService/IsFollowingResponse")]
        System.Threading.Tasks.Task<bool> IsFollowingAsync(string username, string userToFollow);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Unfollow", ReplyAction="http://tempuri.org/IService/UnfollowResponse")]
        System.Threading.Tasks.Task UnfollowAsync(string username, string userToFollow);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetIndividual", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetIndividualRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string username;
        
        public GetIndividualRequest() {
        }
        
        public GetIndividualRequest(string username) {
            this.username = username;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetIndividualResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetIndividualResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string FirstName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string MiddleName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string LastName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public System.DateTime DOB;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public bool Gender;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=5)]
        public string ProfilePic;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=6)]
        public string CoverPic;
        
        public GetIndividualResponse() {
        }
        
        public GetIndividualResponse(string FirstName, string MiddleName, string LastName, System.DateTime DOB, bool Gender, string ProfilePic, string CoverPic) {
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = LastName;
            this.DOB = DOB;
            this.Gender = Gender;
            this.ProfilePic = ProfilePic;
            this.CoverPic = CoverPic;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : EVENeT.EVENeTServiceReference.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<EVENeT.EVENeTServiceReference.IService>, EVENeT.EVENeTServiceReference.IService {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ServiceClient() : 
                base(ServiceClient.GetDefaultBinding(), ServiceClient.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(ServiceClient.GetBindingForEndpoint(endpointConfiguration), ServiceClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Threading.Tasks.Task<bool> UsernameExistsAsync(string username) {
            return base.Channel.UsernameExistsAsync(username);
        }
        
        public System.Threading.Tasks.Task<bool> CorrectUserNameAndPasswordAsync(string username, string password) {
            return base.Channel.CorrectUserNameAndPasswordAsync(username, password);
        }
        
        public System.Threading.Tasks.Task<bool> IndividualFullySetUpAsync(string username) {
            return base.Channel.IndividualFullySetUpAsync(username);
        }
        
        public System.Threading.Tasks.Task SetIndividualInfoAsync(string username, string firstName, string midName, string lastName, System.DateTime dob, bool gender) {
            return base.Channel.SetIndividualInfoAsync(username, firstName, midName, lastName, dob, gender);
        }
        
        public System.Threading.Tasks.Task SetOrganizationInfoAsync(string username, string name, string description, string type, string phone, string website) {
            return base.Channel.SetOrganizationInfoAsync(username, name, description, type, phone, website);
        }
        
        public System.Threading.Tasks.Task SetProfilePictureAsync(string username, string imagePath) {
            return base.Channel.SetProfilePictureAsync(username, imagePath);
        }
        
        public System.Threading.Tasks.Task SetCoverPictureAsync(string username, string imagePath) {
            return base.Channel.SetCoverPictureAsync(username, imagePath);
        }
        
        public System.Threading.Tasks.Task<int> UserTypeAsync(string username) {
            return base.Channel.UserTypeAsync(username);
        }
        
        public System.Threading.Tasks.Task CreateIndividualAsync(string username, string password, string profilePic, string cover, string firstName, string midName, string lastName, System.DateTime dob, bool gender) {
            return base.Channel.CreateIndividualAsync(username, password, profilePic, cover, firstName, midName, lastName, dob, gender);
        }
        
        public System.Threading.Tasks.Task CreateOrganizationAsync(string username, string password, string name, string logo, string cover, string description, string type, string phone, string website) {
            return base.Channel.CreateOrganizationAsync(username, password, name, logo, cover, description, type, phone, website);
        }
        
        public System.Threading.Tasks.Task<bool> CreateEventAsync(System.DateTime beginTime, System.DateTime endTime, string description, string thumbnail, string title, int ticket, int locationId, string currentUser) {
            return base.Channel.CreateEventAsync(beginTime, endTime, description, thumbnail, title, ticket, locationId, currentUser);
        }
        
        public System.Threading.Tasks.Task CreateLocationAsync(string name, string description, string address, double longitude, double latitude, string thumbnail) {
            return base.Channel.CreateLocationAsync(name, description, address, longitude, latitude, thumbnail);
        }
        
        public System.Threading.Tasks.Task<int> GetLocationFromAddressAsync(string address) {
            return base.Channel.GetLocationFromAddressAsync(address);
        }
        
        public System.Threading.Tasks.Task<EVENeT.EVENeTServiceReference.GetIndividualResponse> GetIndividualAsync(EVENeT.EVENeTServiceReference.GetIndividualRequest request) {
            return base.Channel.GetIndividualAsync(request);
        }
        
        public System.Threading.Tasks.Task FollowAsync(string username, string userToFollow) {
            return base.Channel.FollowAsync(username, userToFollow);
        }
        
        public System.Threading.Tasks.Task<bool> IsFollowingAsync(string username, string userToFollow) {
            return base.Channel.IsFollowingAsync(username, userToFollow);
        }
        
        public System.Threading.Tasks.Task UnfollowAsync(string username, string userToFollow) {
            return base.Channel.UnfollowAsync(username, userToFollow);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService)) {
                return new System.ServiceModel.EndpointAddress("http://localhost:24293/Service.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return ServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return ServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IService);
        }
        
        public enum EndpointConfiguration {
            
            BasicHttpBinding_IService,
        }
    }
}
