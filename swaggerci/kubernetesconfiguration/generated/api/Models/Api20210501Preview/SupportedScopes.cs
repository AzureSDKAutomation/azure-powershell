namespace Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Extensions;

    /// <summary>Extension scopes</summary>
    public partial class SupportedScopes :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ISupportedScopes,
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ISupportedScopesInternal
    {

        /// <summary>Describes if multiple instances of the extension are allowed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public bool? AllowMultipleInstance { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IClusterScopeSettingsInternal)ClusterScopeSetting).AllowMultipleInstance; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IClusterScopeSettingsInternal)ClusterScopeSetting).AllowMultipleInstance = value ?? default(bool); }

        /// <summary>Backing field for <see cref="ClusterScopeSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IClusterScopeSettings _clusterScopeSetting;

        /// <summary>Scope settings</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IClusterScopeSettings ClusterScopeSetting { get => (this._clusterScopeSetting = this._clusterScopeSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ClusterScopeSettings()); set => this._clusterScopeSetting = value; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public string ClusterScopeSettingId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IResourceInternal)ClusterScopeSetting).Id; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public string ClusterScopeSettingName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IResourceInternal)ClusterScopeSetting).Name; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public string ClusterScopeSettingType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IResourceInternal)ClusterScopeSetting).Type; }

        /// <summary>Default extension release namespace</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public string DefaultReleaseNamespace { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IClusterScopeSettingsInternal)ClusterScopeSetting).DefaultReleaseNamespace; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IClusterScopeSettingsInternal)ClusterScopeSetting).DefaultReleaseNamespace = value ?? null; }

        /// <summary>Backing field for <see cref="DefaultScope" /> property.</summary>
        private string _defaultScope;

        /// <summary>Default extension scopes: cluster or namespace</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public string DefaultScope { get => this._defaultScope; set => this._defaultScope = value; }

        /// <summary>Internal Acessors for ClusterScopeSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IClusterScopeSettings Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ISupportedScopesInternal.ClusterScopeSetting { get => (this._clusterScopeSetting = this._clusterScopeSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ClusterScopeSettings()); set { {_clusterScopeSetting = value;} } }

        /// <summary>Internal Acessors for ClusterScopeSettingId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ISupportedScopesInternal.ClusterScopeSettingId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IResourceInternal)ClusterScopeSetting).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IResourceInternal)ClusterScopeSetting).Id = value; }

        /// <summary>Internal Acessors for ClusterScopeSettingName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ISupportedScopesInternal.ClusterScopeSettingName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IResourceInternal)ClusterScopeSetting).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IResourceInternal)ClusterScopeSetting).Name = value; }

        /// <summary>Internal Acessors for ClusterScopeSettingProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IClusterScopeSettingsProperties Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ISupportedScopesInternal.ClusterScopeSettingProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IClusterScopeSettingsInternal)ClusterScopeSetting).Property; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IClusterScopeSettingsInternal)ClusterScopeSetting).Property = value; }

        /// <summary>Internal Acessors for ClusterScopeSettingType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ISupportedScopesInternal.ClusterScopeSettingType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IResourceInternal)ClusterScopeSetting).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IResourceInternal)ClusterScopeSetting).Type = value; }

        /// <summary>Creates an new <see cref="SupportedScopes" /> instance.</summary>
        public SupportedScopes()
        {

        }
    }
    /// Extension scopes
    public partial interface ISupportedScopes :
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
        /// <summary>Default extension release namespace</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Default extension release namespace",
        SerializedName = @"defaultReleaseNamespace",
        PossibleTypes = new [] { typeof(string) })]
        string DefaultReleaseNamespace { get; set; }
        /// <summary>Default extension scopes: cluster or namespace</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Default extension scopes: cluster or namespace",
        SerializedName = @"defaultScope",
        PossibleTypes = new [] { typeof(string) })]
        string DefaultScope { get; set; }

    }
    /// Extension scopes
    internal partial interface ISupportedScopesInternal

    {
        /// <summary>Describes if multiple instances of the extension are allowed</summary>
        bool? AllowMultipleInstance { get; set; }
        /// <summary>Scope settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IClusterScopeSettings ClusterScopeSetting { get; set; }
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
        /// <summary>Default extension release namespace</summary>
        string DefaultReleaseNamespace { get; set; }
        /// <summary>Default extension scopes: cluster or namespace</summary>
        string DefaultScope { get; set; }

    }
}