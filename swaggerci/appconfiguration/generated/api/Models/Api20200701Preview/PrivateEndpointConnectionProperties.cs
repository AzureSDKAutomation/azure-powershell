namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Extensions;

    /// <summary>Properties of a private endpoint connection.</summary>
    public partial class PrivateEndpointConnectionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IPrivateEndpointConnectionProperties,
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IPrivateEndpointConnectionPropertiesInternal
    {

        /// <summary>Internal Acessors for PrivateEndpoint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IPrivateEndpoint Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IPrivateEndpointConnectionPropertiesInternal.PrivateEndpoint { get => (this._privateEndpoint = this._privateEndpoint ?? new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.PrivateEndpoint()); set { {_privateEndpoint = value;} } }

        /// <summary>Internal Acessors for PrivateLinkServiceConnectionState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IPrivateLinkServiceConnectionState Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IPrivateEndpointConnectionPropertiesInternal.PrivateLinkServiceConnectionState { get => (this._privateLinkServiceConnectionState = this._privateLinkServiceConnectionState ?? new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.PrivateLinkServiceConnectionState()); set { {_privateLinkServiceConnectionState = value;} } }

        /// <summary>Internal Acessors for PrivateLinkServiceConnectionStateActionsRequired</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ActionsRequired? Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IPrivateEndpointConnectionPropertiesInternal.PrivateLinkServiceConnectionStateActionsRequired { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IPrivateLinkServiceConnectionStateInternal)PrivateLinkServiceConnectionState).ActionsRequired; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IPrivateLinkServiceConnectionStateInternal)PrivateLinkServiceConnectionState).ActionsRequired = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IPrivateEndpointConnectionPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="PrivateEndpoint" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IPrivateEndpoint _privateEndpoint;

        /// <summary>The resource of private endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IPrivateEndpoint PrivateEndpoint { get => (this._privateEndpoint = this._privateEndpoint ?? new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.PrivateEndpoint()); set => this._privateEndpoint = value; }

        /// <summary>The resource Id for private endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Inlined)]
        public string PrivateEndpointId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IPrivateEndpointInternal)PrivateEndpoint).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IPrivateEndpointInternal)PrivateEndpoint).Id = value ?? null; }

        /// <summary>Backing field for <see cref="PrivateLinkServiceConnectionState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IPrivateLinkServiceConnectionState _privateLinkServiceConnectionState;

        /// <summary>
        /// A collection of information about the state of the connection between service consumer and provider.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IPrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get => (this._privateLinkServiceConnectionState = this._privateLinkServiceConnectionState ?? new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.PrivateLinkServiceConnectionState()); set => this._privateLinkServiceConnectionState = value; }

        /// <summary>Any action that is required beyond basic workflow (approve/ reject/ disconnect)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ActionsRequired? PrivateLinkServiceConnectionStateActionsRequired { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IPrivateLinkServiceConnectionStateInternal)PrivateLinkServiceConnectionState).ActionsRequired; }

        /// <summary>The private link service connection description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Inlined)]
        public string PrivateLinkServiceConnectionStateDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IPrivateLinkServiceConnectionStateInternal)PrivateLinkServiceConnectionState).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IPrivateLinkServiceConnectionStateInternal)PrivateLinkServiceConnectionState).Description = value ?? null; }

        /// <summary>The private link service connection status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ConnectionStatus? PrivateLinkServiceConnectionStateStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IPrivateLinkServiceConnectionStateInternal)PrivateLinkServiceConnectionState).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IPrivateLinkServiceConnectionStateInternal)PrivateLinkServiceConnectionState).Status = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ConnectionStatus)""); }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ProvisioningState? _provisioningState;

        /// <summary>The provisioning status of the private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Creates an new <see cref="PrivateEndpointConnectionProperties" /> instance.</summary>
        public PrivateEndpointConnectionProperties()
        {

        }
    }
    /// Properties of a private endpoint connection.
    public partial interface IPrivateEndpointConnectionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IJsonSerializable
    {
        /// <summary>The resource Id for private endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource Id for private endpoint",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateEndpointId { get; set; }
        /// <summary>Any action that is required beyond basic workflow (approve/ reject/ disconnect)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Any action that is required beyond basic workflow (approve/ reject/ disconnect)",
        SerializedName = @"actionsRequired",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ActionsRequired) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ActionsRequired? PrivateLinkServiceConnectionStateActionsRequired { get;  }
        /// <summary>The private link service connection description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The private link service connection description.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkServiceConnectionStateDescription { get; set; }
        /// <summary>The private link service connection status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The private link service connection status.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ConnectionStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ConnectionStatus? PrivateLinkServiceConnectionStateStatus { get; set; }
        /// <summary>The provisioning status of the private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning status of the private endpoint connection.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ProvisioningState? ProvisioningState { get;  }

    }
    /// Properties of a private endpoint connection.
    internal partial interface IPrivateEndpointConnectionPropertiesInternal

    {
        /// <summary>The resource of private endpoint.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IPrivateEndpoint PrivateEndpoint { get; set; }
        /// <summary>The resource Id for private endpoint</summary>
        string PrivateEndpointId { get; set; }
        /// <summary>
        /// A collection of information about the state of the connection between service consumer and provider.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IPrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get; set; }
        /// <summary>Any action that is required beyond basic workflow (approve/ reject/ disconnect)</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ActionsRequired? PrivateLinkServiceConnectionStateActionsRequired { get; set; }
        /// <summary>The private link service connection description.</summary>
        string PrivateLinkServiceConnectionStateDescription { get; set; }
        /// <summary>The private link service connection status.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ConnectionStatus? PrivateLinkServiceConnectionStateStatus { get; set; }
        /// <summary>The provisioning status of the private endpoint connection.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ProvisioningState? ProvisioningState { get; set; }

    }
}