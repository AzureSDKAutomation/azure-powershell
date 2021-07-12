namespace Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Extensions;

    /// <summary>Properties of the connected cluster.</summary>
    public partial class ExtensionTypeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeProperties,
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal
    {

        /// <summary>Describes if multiple instances of the extension are allowed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public bool? AllowMultipleInstance { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ISupportedScopesInternal)SupportedScope).AllowMultipleInstance; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ISupportedScopesInternal)SupportedScope).AllowMultipleInstance = value ?? default(bool); }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public string ClusterScopeSettingId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ISupportedScopesInternal)SupportedScope).ClusterScopeSettingId; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public string ClusterScopeSettingName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ISupportedScopesInternal)SupportedScope).ClusterScopeSettingName; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public string ClusterScopeSettingType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ISupportedScopesInternal)SupportedScope).ClusterScopeSettingType; }

        /// <summary>Backing field for <see cref="ClusterType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ClusterTypes? _clusterType;

        /// <summary>Cluster types</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ClusterTypes? ClusterType { get => this._clusterType; }

        /// <summary>Default extension release namespace</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public string DefaultReleaseNamespace { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ISupportedScopesInternal)SupportedScope).DefaultReleaseNamespace; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ISupportedScopesInternal)SupportedScope).DefaultReleaseNamespace = value ?? null; }

        /// <summary>Internal Acessors for ClusterScopeSettingId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal.ClusterScopeSettingId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ISupportedScopesInternal)SupportedScope).ClusterScopeSettingId; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ISupportedScopesInternal)SupportedScope).ClusterScopeSettingId = value; }

        /// <summary>Internal Acessors for ClusterScopeSettingName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal.ClusterScopeSettingName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ISupportedScopesInternal)SupportedScope).ClusterScopeSettingName; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ISupportedScopesInternal)SupportedScope).ClusterScopeSettingName = value; }

        /// <summary>Internal Acessors for ClusterScopeSettingProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IClusterScopeSettingsProperties Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal.ClusterScopeSettingProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ISupportedScopesInternal)SupportedScope).ClusterScopeSettingProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ISupportedScopesInternal)SupportedScope).ClusterScopeSettingProperty = value; }

        /// <summary>Internal Acessors for ClusterScopeSettingType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal.ClusterScopeSettingType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ISupportedScopesInternal)SupportedScope).ClusterScopeSettingType; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ISupportedScopesInternal)SupportedScope).ClusterScopeSettingType = value; }

        /// <summary>Internal Acessors for ClusterType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ClusterTypes? Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal.ClusterType { get => this._clusterType; set { {_clusterType = value;} } }

        /// <summary>Internal Acessors for ReleaseTrain</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal.ReleaseTrain { get => this._releaseTrain; set { {_releaseTrain = value;} } }

        /// <summary>Internal Acessors for SupportedScope</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ISupportedScopes Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal.SupportedScope { get => (this._supportedScope = this._supportedScope ?? new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.SupportedScopes()); set { {_supportedScope = value;} } }

        /// <summary>Internal Acessors for SupportedScopeClusterScopeSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IClusterScopeSettings Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypePropertiesInternal.SupportedScopeClusterScopeSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ISupportedScopesInternal)SupportedScope).ClusterScopeSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ISupportedScopesInternal)SupportedScope).ClusterScopeSetting = value; }

        /// <summary>Backing field for <see cref="ReleaseTrain" /> property.</summary>
        private string[] _releaseTrain;

        /// <summary>Extension release train: preview or stable</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public string[] ReleaseTrain { get => this._releaseTrain; }

        /// <summary>Backing field for <see cref="SupportedScope" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ISupportedScopes _supportedScope;

        /// <summary>Extension scopes</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ISupportedScopes SupportedScope { get => (this._supportedScope = this._supportedScope ?? new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.SupportedScopes()); }

        /// <summary>Default extension scopes: cluster or namespace</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public string SupportedScopeDefaultScope { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ISupportedScopesInternal)SupportedScope).DefaultScope; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ISupportedScopesInternal)SupportedScope).DefaultScope = value ?? null; }

        /// <summary>Creates an new <see cref="ExtensionTypeProperties" /> instance.</summary>
        public ExtensionTypeProperties()
        {

        }
    }
    /// Properties of the connected cluster.
    public partial interface IExtensionTypeProperties :
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

    }
    /// Properties of the connected cluster.
    internal partial interface IExtensionTypePropertiesInternal

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
        /// <summary>Extension release train: preview or stable</summary>
        string[] ReleaseTrain { get; set; }
        /// <summary>Extension scopes</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ISupportedScopes SupportedScope { get; set; }
        /// <summary>Scope settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IClusterScopeSettings SupportedScopeClusterScopeSetting { get; set; }
        /// <summary>Default extension scopes: cluster or namespace</summary>
        string SupportedScopeDefaultScope { get; set; }

    }
}