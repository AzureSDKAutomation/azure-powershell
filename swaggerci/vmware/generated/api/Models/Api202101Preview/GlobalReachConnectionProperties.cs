namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>The properties of a global reach connection</summary>
    public partial class GlobalReachConnectionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IGlobalReachConnectionProperties,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IGlobalReachConnectionPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AddressPrefix" /> property.</summary>
        private string _addressPrefix;

        /// <summary>
        /// The network used for global reach carved out from the original network block provided for the private cloud
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string AddressPrefix { get => this._addressPrefix; }

        /// <summary>Backing field for <see cref="AuthorizationKey" /> property.</summary>
        private string _authorizationKey;

        /// <summary>
        /// Authorization key from the peer express route used for the global reach connection
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string AuthorizationKey { get => this._authorizationKey; set => this._authorizationKey = value; }

        /// <summary>Backing field for <see cref="CircuitConnectionStatus" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.GlobalReachConnectionStatus? _circuitConnectionStatus;

        /// <summary>The connection status of the global reach connection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.GlobalReachConnectionStatus? CircuitConnectionStatus { get => this._circuitConnectionStatus; }

        /// <summary>Internal Acessors for AddressPrefix</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IGlobalReachConnectionPropertiesInternal.AddressPrefix { get => this._addressPrefix; set { {_addressPrefix = value;} } }

        /// <summary>Internal Acessors for CircuitConnectionStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.GlobalReachConnectionStatus? Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IGlobalReachConnectionPropertiesInternal.CircuitConnectionStatus { get => this._circuitConnectionStatus; set { {_circuitConnectionStatus = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.GlobalReachConnectionProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IGlobalReachConnectionPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="PeerExpressRouteCircuit" /> property.</summary>
        private string _peerExpressRouteCircuit;

        /// <summary>
        /// Identifier of the ExpressRoute Circuit to peer with in the global reach connection
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string PeerExpressRouteCircuit { get => this._peerExpressRouteCircuit; set => this._peerExpressRouteCircuit = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.GlobalReachConnectionProvisioningState? _provisioningState;

        /// <summary>The state of the ExpressRoute Circuit Authorization provisioning</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.GlobalReachConnectionProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Creates an new <see cref="GlobalReachConnectionProperties" /> instance.</summary>
        public GlobalReachConnectionProperties()
        {

        }
    }
    /// The properties of a global reach connection
    public partial interface IGlobalReachConnectionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable
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
    /// The properties of a global reach connection
    internal partial interface IGlobalReachConnectionPropertiesInternal

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
        /// <summary>The state of the ExpressRoute Circuit Authorization provisioning</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.GlobalReachConnectionProvisioningState? ProvisioningState { get; set; }

    }
}