namespace Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Extensions;

    /// <summary>The private endpoint connection of a workspace</summary>
    public partial class PrivateEndpointConnection :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnection,
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnectionInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnectionInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnectionInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for PrivateEndpoint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpoint Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnectionInternal.PrivateEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateEndpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateEndpoint = value; }

        /// <summary>Internal Acessors for PrivateEndpointId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnectionInternal.PrivateEndpointId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateEndpointId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateEndpointId = value; }

        /// <summary>Internal Acessors for PrivateLinkServiceConnectionState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateLinkServiceConnectionState Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnectionInternal.PrivateLinkServiceConnectionState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionState = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnectionProperties Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnectionInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.PrivateEndpointConnectionProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PrivateEndpointConnectionProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnectionInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnectionPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnectionPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnectionInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>The resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string PrivateEndpointId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateEndpointId; }

        /// <summary>Actions required for a private endpoint connection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string PrivateLinkServiceConnectionStateActionRequired { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionStateActionRequired; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionStateActionRequired = value ?? null; }

        /// <summary>The description for the current state of a private endpoint connection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string PrivateLinkServiceConnectionStateDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionStateDescription; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionStateDescription = value ?? null; }

        /// <summary>The status of a private endpoint connection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PrivateLinkServiceConnectionStatus PrivateLinkServiceConnectionStateStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionStateStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnectionPropertiesInternal)Property).PrivateLinkServiceConnectionStateStatus = value ; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnectionProperties _property;

        /// <summary>The private endpoint connection properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnectionProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.PrivateEndpointConnectionProperties()); set => this._property = value; }

        /// <summary>Provisioning state of the private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PrivateEndpointConnectionProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnectionPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="PrivateEndpointConnection" /> instance.</summary>
        public PrivateEndpointConnection()
        {

        }
    }
    /// The private endpoint connection of a workspace
    public partial interface IPrivateEndpointConnection :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.IJsonSerializable
    {
        /// <summary>The resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resource identifier.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>The resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resource name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>The resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resource identifier.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateEndpointId { get;  }
        /// <summary>Actions required for a private endpoint connection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Actions required for a private endpoint connection",
        SerializedName = @"actionRequired",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkServiceConnectionStateActionRequired { get; set; }
        /// <summary>The description for the current state of a private endpoint connection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The description for the current state of a private endpoint connection",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkServiceConnectionStateDescription { get; set; }
        /// <summary>The status of a private endpoint connection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The status of a private endpoint connection",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PrivateLinkServiceConnectionStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PrivateLinkServiceConnectionStatus PrivateLinkServiceConnectionStateStatus { get; set; }
        /// <summary>Provisioning state of the private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning state of the private endpoint connection.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PrivateEndpointConnectionProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PrivateEndpointConnectionProvisioningState? ProvisioningState { get;  }
        /// <summary>The resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resource type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// The private endpoint connection of a workspace
    internal partial interface IPrivateEndpointConnectionInternal

    {
        /// <summary>The resource identifier.</summary>
        string Id { get; set; }
        /// <summary>The resource name.</summary>
        string Name { get; set; }
        /// <summary>Private endpoint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpoint PrivateEndpoint { get; set; }
        /// <summary>The resource identifier.</summary>
        string PrivateEndpointId { get; set; }
        /// <summary>Private endpoint connection state</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get; set; }
        /// <summary>Actions required for a private endpoint connection</summary>
        string PrivateLinkServiceConnectionStateActionRequired { get; set; }
        /// <summary>The description for the current state of a private endpoint connection</summary>
        string PrivateLinkServiceConnectionStateDescription { get; set; }
        /// <summary>The status of a private endpoint connection</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PrivateLinkServiceConnectionStatus PrivateLinkServiceConnectionStateStatus { get; set; }
        /// <summary>The private endpoint connection properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnectionProperties Property { get; set; }
        /// <summary>Provisioning state of the private endpoint connection.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PrivateEndpointConnectionProvisioningState? ProvisioningState { get; set; }
        /// <summary>The resource type.</summary>
        string Type { get; set; }

    }
}