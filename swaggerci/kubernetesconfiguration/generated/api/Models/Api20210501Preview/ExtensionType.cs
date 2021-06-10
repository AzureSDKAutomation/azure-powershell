namespace Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Extensions;

    /// <summary>Represents an Extension Type.</summary>
    public partial class ExtensionType :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionType,
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal
    {

        /// <summary>Describes if multiple instances of the extension are allowed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public bool? AllowMultipleInstance { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal)Property).AllowMultipleInstance; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal)Property).AllowMultipleInstance = value ?? default(bool); }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public string ClusterScopeSettingId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal)Property).ClusterScopeSettingId; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public string ClusterScopeSettingName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal)Property).ClusterScopeSettingName; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public string ClusterScopeSettingType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal)Property).ClusterScopeSettingType; }

        /// <summary>Cluster types</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ClusterTypes? ClusterType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal)Property).ClusterType; }

        /// <summary>Default extension release namespace</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public string DefaultReleaseNamespace { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal)Property).DefaultReleaseNamespace; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal)Property).DefaultReleaseNamespace = value ?? null; }

        /// <summary>Internal Acessors for ClusterScopeSettingId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal.ClusterScopeSettingId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal)Property).ClusterScopeSettingId; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal)Property).ClusterScopeSettingId = value; }

        /// <summary>Internal Acessors for ClusterScopeSettingName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal.ClusterScopeSettingName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal)Property).ClusterScopeSettingName; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal)Property).ClusterScopeSettingName = value; }

        /// <summary>Internal Acessors for ClusterScopeSettingProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IClusterScopeSettingsProperties Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal.ClusterScopeSettingProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal)Property).ClusterScopeSettingProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal)Property).ClusterScopeSettingProperty = value; }

        /// <summary>Internal Acessors for ClusterScopeSettingType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal.ClusterScopeSettingType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal)Property).ClusterScopeSettingType; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal)Property).ClusterScopeSettingType = value; }

        /// <summary>Internal Acessors for ClusterType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ClusterTypes? Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal.ClusterType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal)Property).ClusterType; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal)Property).ClusterType = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeProperties Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ExtensionTypeProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ReleaseTrain</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal.ReleaseTrain { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal)Property).ReleaseTrain; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal)Property).ReleaseTrain = value; }

        /// <summary>Internal Acessors for SupportedScope</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ISupportedScopes Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal.SupportedScope { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal)Property).SupportedScope; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal)Property).SupportedScope = value; }

        /// <summary>Internal Acessors for SupportedScopeClusterScopeSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IClusterScopeSettings Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal.SupportedScopeClusterScopeSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal)Property).SupportedScopeClusterScopeSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal)Property).SupportedScopeClusterScopeSetting = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.ISystemData Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal.SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.SystemData()); set { {_systemData = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeProperties _property;

        /// <summary>Describes the Resource Type properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ExtensionTypeProperties()); set => this._property = value; }

        /// <summary>Extension release train: preview or stable</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public string[] ReleaseTrain { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal)Property).ReleaseTrain; }

        /// <summary>Default extension scopes: cluster or namespace</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public string SupportedScopeDefaultScope { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal)Property).SupportedScopeDefaultScope; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal)Property).SupportedScopeDefaultScope = value ?? null; }

        /// <summary>Backing field for <see cref="SystemData" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.ISystemData _systemData;

        /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.ISystemData SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.SystemData()); }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.ISystemDataInternal)SystemData).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.ISystemDataInternal)SystemData).CreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.ISystemDataInternal)SystemData).CreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.ISystemDataInternal)SystemData).CreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.ISystemDataInternal)SystemData).CreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.ISystemDataInternal)SystemData).CreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.ISystemDataInternal)SystemData).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.ISystemDataInternal)SystemData).LastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.ISystemDataInternal)SystemData).LastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.ISystemDataInternal)SystemData).LastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.ISystemDataInternal)SystemData).LastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.ISystemDataInternal)SystemData).LastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.CreatedByType)""); }

        /// <summary>Creates an new <see cref="ExtensionType" /> instance.</summary>
        public ExtensionType()
        {

        }
    }
    /// Represents an Extension Type.
    public partial interface IExtensionType :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.IJsonSerializable
    {
        /// <summary>Describes if multiple instances of the extension are allowed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Describes if multiple instances of the extension are allowed",
        SerializedName = @"allowMultipleInstances",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AllowMultipleInstance { get; set; }
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterScopeSettingId { get;  }
        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The name of the resource",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterScopeSettingName { get;  }
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of the resource. E.g. ""Microsoft.Compute/virtualMachines"" or ""Microsoft.Storage/storageAccounts""",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterScopeSettingType { get;  }
        /// <summary>Cluster types</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Cluster types",
        SerializedName = @"clusterTypes",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ClusterTypes) })]
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ClusterTypes? ClusterType { get;  }
        /// <summary>Default extension release namespace</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Default extension release namespace",
        SerializedName = @"defaultReleaseNamespace",
        PossibleTypes = new [] { typeof(string) })]
        string DefaultReleaseNamespace { get; set; }
        /// <summary>Extension release train: preview or stable</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Extension release train: preview or stable",
        SerializedName = @"releaseTrains",
        PossibleTypes = new [] { typeof(string) })]
        string[] ReleaseTrain { get;  }
        /// <summary>Default extension scopes: cluster or namespace</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Default extension scopes: cluster or namespace",
        SerializedName = @"defaultScope",
        PossibleTypes = new [] { typeof(string) })]
        string SupportedScopeDefaultScope { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that created the resource.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource last modification (UTC)",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that last modified the resource.",
        SerializedName = @"lastModifiedBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }

    }
    /// Represents an Extension Type.
    internal partial interface IExtensionTypeInternal

    {
        /// <summary>Describes if multiple instances of the extension are allowed</summary>
        bool? AllowMultipleInstance { get; set; }
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        string ClusterScopeSettingId { get; set; }
        /// <summary>The name of the resource</summary>
        string ClusterScopeSettingName { get; set; }
        /// <summary>Extension scope settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IClusterScopeSettingsProperties ClusterScopeSettingProperty { get; set; }
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        string ClusterScopeSettingType { get; set; }
        /// <summary>Cluster types</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ClusterTypes? ClusterType { get; set; }
        /// <summary>Default extension release namespace</summary>
        string DefaultReleaseNamespace { get; set; }
        /// <summary>Describes the Resource Type properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeProperties Property { get; set; }
        /// <summary>Extension release train: preview or stable</summary>
        string[] ReleaseTrain { get; set; }
        /// <summary>Extension scopes</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ISupportedScopes SupportedScope { get; set; }
        /// <summary>Scope settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IClusterScopeSettings SupportedScopeClusterScopeSetting { get; set; }
        /// <summary>Default extension scopes: cluster or namespace</summary>
        string SupportedScopeDefaultScope { get; set; }
        /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.ISystemData SystemData { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }

    }
}