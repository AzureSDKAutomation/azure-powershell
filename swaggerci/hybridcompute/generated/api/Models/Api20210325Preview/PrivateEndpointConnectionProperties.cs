namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Extensions;

    /// <summary>Properties of a private endpoint connection.</summary>
    public partial class PrivateEndpointConnectionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateEndpointConnectionProperties,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateEndpointConnectionPropertiesInternal
    {

        /// <summary>Internal Acessors for PrivateEndpoint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateEndpointProperty Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateEndpointConnectionPropertiesInternal.PrivateEndpoint { get => (this._privateEndpoint = this._privateEndpoint ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.PrivateEndpointProperty()); set { {_privateEndpoint = value;} } }

        /// <summary>Internal Acessors for PrivateLinkServiceConnectionState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateLinkServiceConnectionStateProperty Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateEndpointConnectionPropertiesInternal.PrivateLinkServiceConnectionState { get => (this._privateLinkServiceConnectionState = this._privateLinkServiceConnectionState ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.PrivateLinkServiceConnectionStateProperty()); set { {_privateLinkServiceConnectionState = value;} } }

        /// <summary>Internal Acessors for PrivateLinkServiceConnectionStateActionsRequired</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateEndpointConnectionPropertiesInternal.PrivateLinkServiceConnectionStateActionsRequired { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateLinkServiceConnectionStatePropertyInternal)PrivateLinkServiceConnectionState).ActionsRequired; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateLinkServiceConnectionStatePropertyInternal)PrivateLinkServiceConnectionState).ActionsRequired = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateEndpointConnectionPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="PrivateEndpoint" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateEndpointProperty _privateEndpoint;

        /// <summary>Private endpoint which the connection belongs to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateEndpointProperty PrivateEndpoint { get => (this._privateEndpoint = this._privateEndpoint ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.PrivateEndpointProperty()); set => this._privateEndpoint = value; }

        /// <summary>Resource id of the private endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string PrivateEndpointId { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateEndpointPropertyInternal)PrivateEndpoint).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateEndpointPropertyInternal)PrivateEndpoint).Id = value ?? null; }

        /// <summary>Backing field for <see cref="PrivateLinkServiceConnectionState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateLinkServiceConnectionStateProperty _privateLinkServiceConnectionState;

        /// <summary>Connection state of the private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateLinkServiceConnectionStateProperty PrivateLinkServiceConnectionState { get => (this._privateLinkServiceConnectionState = this._privateLinkServiceConnectionState ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.PrivateLinkServiceConnectionStateProperty()); set => this._privateLinkServiceConnectionState = value; }

        /// <summary>The actions required for private link service connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string PrivateLinkServiceConnectionStateActionsRequired { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateLinkServiceConnectionStatePropertyInternal)PrivateLinkServiceConnectionState).ActionsRequired; }

        /// <summary>The private link service connection description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string PrivateLinkServiceConnectionStateDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateLinkServiceConnectionStatePropertyInternal)PrivateLinkServiceConnectionState).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateLinkServiceConnectionStatePropertyInternal)PrivateLinkServiceConnectionState).Description = value ?? null; }

        /// <summary>The private link service connection status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string PrivateLinkServiceConnectionStateStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateLinkServiceConnectionStatePropertyInternal)PrivateLinkServiceConnectionState).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateLinkServiceConnectionStatePropertyInternal)PrivateLinkServiceConnectionState).Status = value ?? null; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>State of the private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Creates an new <see cref="PrivateEndpointConnectionProperties" /> instance.</summary>
        public PrivateEndpointConnectionProperties()
        {

        }
    }
    /// Properties of a private endpoint connection.
    public partial interface IPrivateEndpointConnectionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IJsonSerializable
    {
        /// <summary>Resource id of the private endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource id of the private endpoint.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateEndpointId { get; set; }
        /// <summary>The actions required for private link service connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The actions required for private link service connection.",
        SerializedName = @"actionsRequired",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkServiceConnectionStateActionsRequired { get;  }
        /// <summary>The private link service connection description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The private link service connection description.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkServiceConnectionStateDescription { get; set; }
        /// <summary>The private link service connection status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The private link service connection status.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkServiceConnectionStateStatus { get; set; }
        /// <summary>State of the private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"State of the private endpoint connection.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get;  }

    }
    /// Properties of a private endpoint connection.
    internal partial interface IPrivateEndpointConnectionPropertiesInternal

    {
        /// <summary>Private endpoint which the connection belongs to.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateEndpointProperty PrivateEndpoint { get; set; }
        /// <summary>Resource id of the private endpoint.</summary>
        string PrivateEndpointId { get; set; }
        /// <summary>Connection state of the private endpoint connection.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateLinkServiceConnectionStateProperty PrivateLinkServiceConnectionState { get; set; }
        /// <summary>The actions required for private link service connection.</summary>
        string PrivateLinkServiceConnectionStateActionsRequired { get; set; }
        /// <summary>The private link service connection description.</summary>
        string PrivateLinkServiceConnectionStateDescription { get; set; }
        /// <summary>The private link service connection status.</summary>
        string PrivateLinkServiceConnectionStateStatus { get; set; }
        /// <summary>State of the private endpoint connection.</summary>
        string ProvisioningState { get; set; }

    }
}