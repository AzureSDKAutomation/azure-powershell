namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>App resource payload</summary>
    public partial class AppResource :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResource,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.Resource();

        /// <summary>Name of the active deployment of the App</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string ActiveDeploymentName { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourcePropertiesInternal)Property).ActiveDeploymentName; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourcePropertiesInternal)Property).ActiveDeploymentName = value ?? null; }

        /// <summary>Date time when the resource is created</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public global::System.DateTime? CreatedTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourcePropertiesInternal)Property).CreatedTime; }

        /// <summary>Indicate if end to end TLS is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public bool? EnableEndToEndTl { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourcePropertiesInternal)Property).EnableEndToEndTl; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourcePropertiesInternal)Property).EnableEndToEndTl = value ?? default(bool); }

        /// <summary>Fully qualified dns Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string Fqdn { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourcePropertiesInternal)Property).Fqdn; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourcePropertiesInternal)Property).Fqdn = value ?? null; }

        /// <summary>Indicate if only https is allowed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public bool? HttpsOnly { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourcePropertiesInternal)Property).HttpsOnly; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourcePropertiesInternal)Property).HttpsOnly = value ?? default(bool); }

        /// <summary>Fully qualified resource Id for the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)__resource).Id; }

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IManagedIdentityProperties _identity;

        /// <summary>The Managed Identity type of the app resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IManagedIdentityProperties Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ManagedIdentityProperties()); set => this._identity = value; }

        /// <summary>Principal Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IManagedIdentityPropertiesInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IManagedIdentityPropertiesInternal)Identity).PrincipalId = value ?? null; }

        /// <summary>Tenant Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IManagedIdentityPropertiesInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IManagedIdentityPropertiesInternal)Identity).TenantId = value ?? null; }

        /// <summary>Type of the managed identity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ManagedIdentityType? IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IManagedIdentityPropertiesInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IManagedIdentityPropertiesInternal)Identity).Type = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ManagedIdentityType)""); }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>The GEO location of the application, always the same with its parent resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Internal Acessors for CreatedTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourceInternal.CreatedTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourcePropertiesInternal)Property).CreatedTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourcePropertiesInternal)Property).CreatedTime = value; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IManagedIdentityProperties Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourceInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ManagedIdentityProperties()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for PersistentDisk</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IPersistentDisk Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourceInternal.PersistentDisk { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourcePropertiesInternal)Property).PersistentDisk; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourcePropertiesInternal)Property).PersistentDisk = value; }

        /// <summary>Internal Acessors for PersistentDiskUsedInGb</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourceInternal.PersistentDiskUsedInGb { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourcePropertiesInternal)Property).PersistentDiskUsedInGb; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourcePropertiesInternal)Property).PersistentDiskUsedInGb = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourceProperties Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.AppResourceProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.AppResourceProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourcePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourcePropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for TemporaryDisk</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ITemporaryDisk Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourceInternal.TemporaryDisk { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourcePropertiesInternal)Property).TemporaryDisk; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourcePropertiesInternal)Property).TemporaryDisk = value; }

        /// <summary>Internal Acessors for Url</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourceInternal.Url { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourcePropertiesInternal)Property).Url; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourcePropertiesInternal)Property).Url = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)__resource).Type = value; }

        /// <summary>The name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)__resource).Name; }

        /// <summary>Mount path of the persistent disk</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string PersistentDiskMountPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourcePropertiesInternal)Property).PersistentDiskMountPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourcePropertiesInternal)Property).PersistentDiskMountPath = value ?? null; }

        /// <summary>Size of the persistent disk in GB</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public int? PersistentDiskSizeInGb { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourcePropertiesInternal)Property).PersistentDiskSizeInGb; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourcePropertiesInternal)Property).PersistentDiskSizeInGb = value ?? default(int); }

        /// <summary>Size of the used persistent disk in GB</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public int? PersistentDiskUsedInGb { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourcePropertiesInternal)Property).PersistentDiskUsedInGb; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourceProperties _property;

        /// <summary>Properties of the App resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourceProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.AppResourceProperties()); set => this._property = value; }

        /// <summary>Provisioning state of the App</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.AppResourceProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourcePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Indicates whether the App exposes public endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public bool? Public { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourcePropertiesInternal)Property).Public; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourcePropertiesInternal)Property).Public = value ?? default(bool); }

        /// <summary>Mount path of the temporary disk</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string TemporaryDiskMountPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourcePropertiesInternal)Property).TemporaryDiskMountPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourcePropertiesInternal)Property).TemporaryDiskMountPath = value ?? null; }

        /// <summary>Size of the temporary disk in GB</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public int? TemporaryDiskSizeInGb { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourcePropertiesInternal)Property).TemporaryDiskSizeInGb; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourcePropertiesInternal)Property).TemporaryDiskSizeInGb = value ?? default(int); }

        /// <summary>The type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)__resource).Type; }

        /// <summary>URL of the App</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string Url { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourcePropertiesInternal)Property).Url; }

        /// <summary>Creates an new <see cref="AppResource" /> instance.</summary>
        public AppResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// App resource payload
    public partial interface IAppResource :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResource
    {
        /// <summary>Name of the active deployment of the App</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the active deployment of the App",
        SerializedName = @"activeDeploymentName",
        PossibleTypes = new [] { typeof(string) })]
        string ActiveDeploymentName { get; set; }
        /// <summary>Date time when the resource is created</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Date time when the resource is created",
        SerializedName = @"createdTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreatedTime { get;  }
        /// <summary>Indicate if end to end TLS is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicate if end to end TLS is enabled.",
        SerializedName = @"enableEndToEndTLS",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableEndToEndTl { get; set; }
        /// <summary>Fully qualified dns Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully qualified dns Name.",
        SerializedName = @"fqdn",
        PossibleTypes = new [] { typeof(string) })]
        string Fqdn { get; set; }
        /// <summary>Indicate if only https is allowed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicate if only https is allowed.",
        SerializedName = @"httpsOnly",
        PossibleTypes = new [] { typeof(bool) })]
        bool? HttpsOnly { get; set; }
        /// <summary>Principal Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Principal Id",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPrincipalId { get; set; }
        /// <summary>Tenant Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Tenant Id",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityTenantId { get; set; }
        /// <summary>Type of the managed identity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the managed identity",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ManagedIdentityType) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ManagedIdentityType? IdentityType { get; set; }
        /// <summary>The GEO location of the application, always the same with its parent resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The GEO location of the application, always the same with its parent resource",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>Mount path of the persistent disk</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Mount path of the persistent disk",
        SerializedName = @"mountPath",
        PossibleTypes = new [] { typeof(string) })]
        string PersistentDiskMountPath { get; set; }
        /// <summary>Size of the persistent disk in GB</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Size of the persistent disk in GB",
        SerializedName = @"sizeInGB",
        PossibleTypes = new [] { typeof(int) })]
        int? PersistentDiskSizeInGb { get; set; }
        /// <summary>Size of the used persistent disk in GB</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Size of the used persistent disk in GB",
        SerializedName = @"usedInGB",
        PossibleTypes = new [] { typeof(int) })]
        int? PersistentDiskUsedInGb { get;  }
        /// <summary>Provisioning state of the App</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning state of the App",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.AppResourceProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.AppResourceProvisioningState? ProvisioningState { get;  }
        /// <summary>Indicates whether the App exposes public endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether the App exposes public endpoint",
        SerializedName = @"public",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Public { get; set; }
        /// <summary>Mount path of the temporary disk</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Mount path of the temporary disk",
        SerializedName = @"mountPath",
        PossibleTypes = new [] { typeof(string) })]
        string TemporaryDiskMountPath { get; set; }
        /// <summary>Size of the temporary disk in GB</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Size of the temporary disk in GB",
        SerializedName = @"sizeInGB",
        PossibleTypes = new [] { typeof(int) })]
        int? TemporaryDiskSizeInGb { get; set; }
        /// <summary>URL of the App</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"URL of the App",
        SerializedName = @"url",
        PossibleTypes = new [] { typeof(string) })]
        string Url { get;  }

    }
    /// App resource payload
    internal partial interface IAppResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal
    {
        /// <summary>Name of the active deployment of the App</summary>
        string ActiveDeploymentName { get; set; }
        /// <summary>Date time when the resource is created</summary>
        global::System.DateTime? CreatedTime { get; set; }
        /// <summary>Indicate if end to end TLS is enabled.</summary>
        bool? EnableEndToEndTl { get; set; }
        /// <summary>Fully qualified dns Name.</summary>
        string Fqdn { get; set; }
        /// <summary>Indicate if only https is allowed.</summary>
        bool? HttpsOnly { get; set; }
        /// <summary>The Managed Identity type of the app resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IManagedIdentityProperties Identity { get; set; }
        /// <summary>Principal Id</summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>Tenant Id</summary>
        string IdentityTenantId { get; set; }
        /// <summary>Type of the managed identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ManagedIdentityType? IdentityType { get; set; }
        /// <summary>The GEO location of the application, always the same with its parent resource</summary>
        string Location { get; set; }
        /// <summary>Persistent disk settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IPersistentDisk PersistentDisk { get; set; }
        /// <summary>Mount path of the persistent disk</summary>
        string PersistentDiskMountPath { get; set; }
        /// <summary>Size of the persistent disk in GB</summary>
        int? PersistentDiskSizeInGb { get; set; }
        /// <summary>Size of the used persistent disk in GB</summary>
        int? PersistentDiskUsedInGb { get; set; }
        /// <summary>Properties of the App resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IAppResourceProperties Property { get; set; }
        /// <summary>Provisioning state of the App</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.AppResourceProvisioningState? ProvisioningState { get; set; }
        /// <summary>Indicates whether the App exposes public endpoint</summary>
        bool? Public { get; set; }
        /// <summary>Temporary disk settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ITemporaryDisk TemporaryDisk { get; set; }
        /// <summary>Mount path of the temporary disk</summary>
        string TemporaryDiskMountPath { get; set; }
        /// <summary>Size of the temporary disk in GB</summary>
        int? TemporaryDiskSizeInGb { get; set; }
        /// <summary>URL of the App</summary>
        string Url { get; set; }

    }
}