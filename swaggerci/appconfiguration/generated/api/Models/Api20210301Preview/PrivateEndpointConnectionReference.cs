namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Extensions;

    /// <summary>A reference to a related private endpoint connection.</summary>
    public partial class PrivateEndpointConnectionReference :
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpointConnectionReference,
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpointConnectionReferenceInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpointConnectionReferenceInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpointConnectionReferenceInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for PrivateEndpoint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpoint Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpointConnectionReferenceInternal.PrivateEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateEndpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateEndpoint = value; }

        /// <summary>Internal Acessors for PrivateLinkServiceConnectionState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateLinkServiceConnectionState Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpointConnectionReferenceInternal.PrivateLinkServiceConnectionState { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionState; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionState = value; }

        /// <summary>Internal Acessors for PrivateLinkServiceConnectionStateActionsRequired</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ActionsRequired? Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpointConnectionReferenceInternal.PrivateLinkServiceConnectionStateActionsRequired { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionStateActionsRequired; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionStateActionsRequired = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpointConnectionProperties Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpointConnectionReferenceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.PrivateEndpointConnectionProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpointConnectionReferenceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpointConnectionPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpointConnectionPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpointConnectionReferenceInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>The resource Id for private endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Inlined)]
        public string PrivateEndpointId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateEndpointId; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateEndpointId = value ?? null; }

        /// <summary>Any action that is required beyond basic workflow (approve/ reject/ disconnect)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ActionsRequired? PrivateLinkServiceConnectionStateActionsRequired { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionStateActionsRequired; }

        /// <summary>The private link service connection description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Inlined)]
        public string PrivateLinkServiceConnectionStateDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionStateDescription; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionStateDescription = value ?? null; }

        /// <summary>The private link service connection status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ConnectionStatus? PrivateLinkServiceConnectionStateStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionStateStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionStateStatus = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ConnectionStatus)""); }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpointConnectionProperties _property;

        /// <summary>The properties of a private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpointConnectionProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.PrivateEndpointConnectionProperties()); set => this._property = value; }

        /// <summary>The provisioning status of the private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpointConnectionPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="PrivateEndpointConnectionReference" /> instance.</summary>
        public PrivateEndpointConnectionReference()
        {

        }
    }
    /// A reference to a related private endpoint connection.
    public partial interface IPrivateEndpointConnectionReference :
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IJsonSerializable
    {
        /// <summary>The resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>The name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The name of the resource.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
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
        /// <summary>The type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of the resource.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// A reference to a related private endpoint connection.
    internal partial interface IPrivateEndpointConnectionReferenceInternal

    {
        /// <summary>The resource ID.</summary>
        string Id { get; set; }
        /// <summary>The name of the resource.</summary>
        string Name { get; set; }
        /// <summary>The resource of private endpoint.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpoint PrivateEndpoint { get; set; }
        /// <summary>The resource Id for private endpoint</summary>
        string PrivateEndpointId { get; set; }
        /// <summary>
        /// A collection of information about the state of the connection between service consumer and provider.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get; set; }
        /// <summary>Any action that is required beyond basic workflow (approve/ reject/ disconnect)</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ActionsRequired? PrivateLinkServiceConnectionStateActionsRequired { get; set; }
        /// <summary>The private link service connection description.</summary>
        string PrivateLinkServiceConnectionStateDescription { get; set; }
        /// <summary>The private link service connection status.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ConnectionStatus? PrivateLinkServiceConnectionStateStatus { get; set; }
        /// <summary>The properties of a private endpoint connection.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpointConnectionProperties Property { get; set; }
        /// <summary>The provisioning status of the private endpoint connection.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>The type of the resource.</summary>
        string Type { get; set; }

    }
}