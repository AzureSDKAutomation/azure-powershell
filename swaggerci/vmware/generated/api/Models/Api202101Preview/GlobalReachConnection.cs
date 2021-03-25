namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>A global reach connection resource</summary>
    public partial class GlobalReachConnection :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IGlobalReachConnection,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IGlobalReachConnectionInternal,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.Resource();

        /// <summary>
        /// The network used for global reach carved out from the original network block provided for the private cloud
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string AddressPrefix { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IGlobalReachConnectionPropertiesInternal)Property).AddressPrefix; }

        /// <summary>
        /// Authorization key from the peer express route used for the global reach connection
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string AuthorizationKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IGlobalReachConnectionPropertiesInternal)Property).AuthorizationKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IGlobalReachConnectionPropertiesInternal)Property).AuthorizationKey = value ?? null; }

        /// <summary>The connection status of the global reach connection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.GlobalReachConnectionStatus? CircuitConnectionStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IGlobalReachConnectionPropertiesInternal)Property).CircuitConnectionStatus; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal)__resource).Id; }

        /// <summary>Internal Acessors for AddressPrefix</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IGlobalReachConnectionInternal.AddressPrefix { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IGlobalReachConnectionPropertiesInternal)Property).AddressPrefix; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IGlobalReachConnectionPropertiesInternal)Property).AddressPrefix = value; }

        /// <summary>Internal Acessors for CircuitConnectionStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.GlobalReachConnectionStatus? Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IGlobalReachConnectionInternal.CircuitConnectionStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IGlobalReachConnectionPropertiesInternal)Property).CircuitConnectionStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IGlobalReachConnectionPropertiesInternal)Property).CircuitConnectionStatus = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IGlobalReachConnectionProperties Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IGlobalReachConnectionInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.GlobalReachConnectionProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.GlobalReachConnectionProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IGlobalReachConnectionInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IGlobalReachConnectionPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IGlobalReachConnectionPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal)__resource).Type = value; }

        /// <summary>Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal)__resource).Name; }

        /// <summary>
        /// Identifier of the ExpressRoute Circuit to peer with in the global reach connection
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string PeerExpressRouteCircuit { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IGlobalReachConnectionPropertiesInternal)Property).PeerExpressRouteCircuit; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IGlobalReachConnectionPropertiesInternal)Property).PeerExpressRouteCircuit = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IGlobalReachConnectionProperties _property;

        /// <summary>The properties of a global reach connection resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IGlobalReachConnectionProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.GlobalReachConnectionProperties()); set => this._property = value; }

        /// <summary>The state of the ExpressRoute Circuit Authorization provisioning</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.GlobalReachConnectionProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IGlobalReachConnectionPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="GlobalReachConnection" /> instance.</summary>
        public GlobalReachConnection()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// A global reach connection resource
    public partial interface IGlobalReachConnection :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResource
    {
        /// <summary>
        /// The network used for global reach carved out from the original network block provided for the private cloud
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The network used for global reach carved out from the original network block provided for the private cloud",
        SerializedName = @"addressPrefix",
        PossibleTypes = new [] { typeof(string) })]
        string AddressPrefix { get;  }
        /// <summary>
        /// Authorization key from the peer express route used for the global reach connection
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Authorization key from the peer express route used for the global reach connection",
        SerializedName = @"authorizationKey",
        PossibleTypes = new [] { typeof(string) })]
        string AuthorizationKey { get; set; }
        /// <summary>The connection status of the global reach connection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The connection status of the global reach connection",
        SerializedName = @"circuitConnectionStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.GlobalReachConnectionStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.GlobalReachConnectionStatus? CircuitConnectionStatus { get;  }
        /// <summary>
        /// Identifier of the ExpressRoute Circuit to peer with in the global reach connection
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Identifier of the ExpressRoute Circuit to peer with in the global reach connection",
        SerializedName = @"peerExpressRouteCircuit",
        PossibleTypes = new [] { typeof(string) })]
        string PeerExpressRouteCircuit { get; set; }
        /// <summary>The state of the ExpressRoute Circuit Authorization provisioning</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The state of the  ExpressRoute Circuit Authorization provisioning",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.GlobalReachConnectionProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.GlobalReachConnectionProvisioningState? ProvisioningState { get;  }

    }
    /// A global reach connection resource
    internal partial interface IGlobalReachConnectionInternal :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal
    {
        /// <summary>
        /// The network used for global reach carved out from the original network block provided for the private cloud
        /// </summary>
        string AddressPrefix { get; set; }
        /// <summary>
        /// Authorization key from the peer express route used for the global reach connection
        /// </summary>
        string AuthorizationKey { get; set; }
        /// <summary>The connection status of the global reach connection</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.GlobalReachConnectionStatus? CircuitConnectionStatus { get; set; }
        /// <summary>
        /// Identifier of the ExpressRoute Circuit to peer with in the global reach connection
        /// </summary>
        string PeerExpressRouteCircuit { get; set; }
        /// <summary>The properties of a global reach connection resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IGlobalReachConnectionProperties Property { get; set; }
        /// <summary>The state of the ExpressRoute Circuit Authorization provisioning</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.GlobalReachConnectionProvisioningState? ProvisioningState { get; set; }

    }
}