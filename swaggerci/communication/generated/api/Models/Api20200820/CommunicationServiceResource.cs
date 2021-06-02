namespace Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Extensions;

    /// <summary>A class representing a CommunicationService resource.</summary>
    public partial class CommunicationServiceResource :
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResource,
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.IValidates,
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.IHeaderSerializable
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ILocationResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ILocationResource __locationResource = new Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.LocationResource();

        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.Resource();

        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ITaggedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ITaggedResource __taggedResource = new Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.TaggedResource();

        /// <summary>Backing field for <see cref="AzureAsyncOperation" /> property.</summary>
        private string _azureAsyncOperation;

        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Owned)]
        public string AzureAsyncOperation { get => this._azureAsyncOperation; set => this._azureAsyncOperation = value; }

        /// <summary>The location where the communication service stores its data at rest.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Inlined)]
        public string DataLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServicePropertiesInternal)Property).DataLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServicePropertiesInternal)Property).DataLocation = value ?? null; }

        /// <summary>FQDN of the CommunicationService instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Inlined)]
        public string HostName { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServicePropertiesInternal)Property).HostName; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IResourceInternal)__resource).Id; }

        /// <summary>The immutable resource Id of the communication service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Inlined)]
        public string ImmutableResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServicePropertiesInternal)Property).ImmutableResourceId; }

        /// <summary>The Azure location where the CommunicationService is running.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ILocationResourceInternal)__locationResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ILocationResourceInternal)__locationResource).Location = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for HostName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal.HostName { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServicePropertiesInternal)Property).HostName; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServicePropertiesInternal)Property).HostName = value; }

        /// <summary>Internal Acessors for ImmutableResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal.ImmutableResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServicePropertiesInternal)Property).ImmutableResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServicePropertiesInternal)Property).ImmutableResourceId = value; }

        /// <summary>Internal Acessors for NotificationHubId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal.NotificationHubId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServicePropertiesInternal)Property).NotificationHubId; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServicePropertiesInternal)Property).NotificationHubId = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceProperties Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.CommunicationServiceProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServicePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServicePropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.ISystemData Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal.SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.SystemData()); set { {_systemData = value;} } }

        /// <summary>Internal Acessors for Version</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal.Version { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServicePropertiesInternal)Property).Version; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServicePropertiesInternal)Property).Version = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IResourceInternal)__resource).Name; }

        /// <summary>Resource ID of an Azure Notification Hub linked to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Inlined)]
        public string NotificationHubId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServicePropertiesInternal)Property).NotificationHubId; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceProperties _property;

        /// <summary>The properties of the service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.CommunicationServiceProperties()); set => this._property = value; }

        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServicePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Backing field for <see cref="SystemData" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.ISystemData _systemData;

        /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.ISystemData SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.SystemData()); }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.ISystemDataInternal)SystemData).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.ISystemDataInternal)SystemData).CreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Inlined)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.ISystemDataInternal)SystemData).CreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.ISystemDataInternal)SystemData).CreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.ISystemDataInternal)SystemData).CreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.ISystemDataInternal)SystemData).CreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.ISystemDataInternal)SystemData).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.ISystemDataInternal)SystemData).LastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Inlined)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.ISystemDataInternal)SystemData).LastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.ISystemDataInternal)SystemData).LastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.ISystemDataInternal)SystemData).LastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.ISystemDataInternal)SystemData).LastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.CreatedByType)""); }

        /// <summary>
        /// Tags of the service which is a list of key value pairs that describe the resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ITaggedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ITaggedResourceInternal)__taggedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ITaggedResourceInternal)__taggedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IResourceInternal)__resource).Type; }

        /// <summary>
        /// Version of the CommunicationService resource. Probably you need the same or higher version of client SDKs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Inlined)]
        public string Version { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServicePropertiesInternal)Property).Version; }

        /// <summary>Creates an new <see cref="CommunicationServiceResource" /> instance.</summary>
        public CommunicationServiceResource()
        {

        }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("Azure-AsyncOperation", out var __azureAsyncOperationHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).AzureAsyncOperation = System.Linq.Enumerable.FirstOrDefault(__azureAsyncOperationHeader0) is string __headerAzureAsyncOperationHeader0 ? __headerAzureAsyncOperationHeader0 : (string)null;
            }
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
            await eventListener.AssertNotNull(nameof(__locationResource), __locationResource);
            await eventListener.AssertObjectIsValid(nameof(__locationResource), __locationResource);
            await eventListener.AssertNotNull(nameof(__taggedResource), __taggedResource);
            await eventListener.AssertObjectIsValid(nameof(__taggedResource), __taggedResource);
        }
    }
    /// A class representing a CommunicationService resource.
    public partial interface ICommunicationServiceResource :
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IResource,
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ILocationResource,
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ITaggedResource
    {
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"Azure-AsyncOperation",
        PossibleTypes = new [] { typeof(string) })]
        string AzureAsyncOperation { get; set; }
        /// <summary>The location where the communication service stores its data at rest.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The location where the communication service stores its data at rest.",
        SerializedName = @"dataLocation",
        PossibleTypes = new [] { typeof(string) })]
        string DataLocation { get; set; }
        /// <summary>FQDN of the CommunicationService instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"FQDN of the CommunicationService instance.",
        SerializedName = @"hostName",
        PossibleTypes = new [] { typeof(string) })]
        string HostName { get;  }
        /// <summary>The immutable resource Id of the communication service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The immutable resource Id of the communication service.",
        SerializedName = @"immutableResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ImmutableResourceId { get;  }
        /// <summary>Resource ID of an Azure Notification Hub linked to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Resource ID of an Azure Notification Hub linked to this resource.",
        SerializedName = @"notificationHubId",
        PossibleTypes = new [] { typeof(string) })]
        string NotificationHubId { get;  }
        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that created the resource.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource last modification (UTC)",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that last modified the resource.",
        SerializedName = @"lastModifiedBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }
        /// <summary>
        /// Version of the CommunicationService resource. Probably you need the same or higher version of client SDKs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Version of the CommunicationService resource. Probably you need the same or higher version of client SDKs.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get;  }

    }
    /// A class representing a CommunicationService resource.
    internal partial interface ICommunicationServiceResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ILocationResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ITaggedResourceInternal
    {
        string AzureAsyncOperation { get; set; }
        /// <summary>The location where the communication service stores its data at rest.</summary>
        string DataLocation { get; set; }
        /// <summary>FQDN of the CommunicationService instance.</summary>
        string HostName { get; set; }
        /// <summary>The immutable resource Id of the communication service.</summary>
        string ImmutableResourceId { get; set; }
        /// <summary>Resource ID of an Azure Notification Hub linked to this resource.</summary>
        string NotificationHubId { get; set; }
        /// <summary>The properties of the service.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceProperties Property { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.ISystemData SystemData { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }
        /// <summary>
        /// Version of the CommunicationService resource. Probably you need the same or higher version of client SDKs.
        /// </summary>
        string Version { get; set; }

    }
}