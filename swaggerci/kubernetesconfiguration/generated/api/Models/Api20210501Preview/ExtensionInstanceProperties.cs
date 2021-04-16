namespace Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Extensions;

    /// <summary>Properties of an Extension Instance resource</summary>
    public partial class ExtensionInstanceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionInstanceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionInstancePropertiesInternal
    {

        /// <summary>Backing field for <see cref="AutoUpgradeMinorVersion" /> property.</summary>
        private bool? _autoUpgradeMinorVersion;

        /// <summary>
        /// Flag to note if this instance participates in auto upgrade of minor version, or not.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public bool? AutoUpgradeMinorVersion { get => this._autoUpgradeMinorVersion; set => this._autoUpgradeMinorVersion = value; }

        /// <summary>
        /// Namespace where the extension Release must be placed, for a Cluster scoped extensionInstance. If this namespace does not
        /// exist, it will be created
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public string ClusterReleaseNamespace { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScopeInternal)Scope).ClusterReleaseNamespace; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScopeInternal)Scope).ClusterReleaseNamespace = value ?? null; }

        /// <summary>Backing field for <see cref="ConfigurationProtectedSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionProtectedSettings _configurationProtectedSetting;

        /// <summary>
        /// Configuration settings that are sensitive, as name-value pairs for configuring this instance of the extension.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionProtectedSettings ConfigurationProtectedSetting { get => (this._configurationProtectedSetting = this._configurationProtectedSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ExtensionProtectedSettings()); set => this._configurationProtectedSetting = value; }

        /// <summary>Backing field for <see cref="ConfigurationSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IConfigurationSettings _configurationSetting;

        /// <summary>
        /// Configuration settings, as name-value pairs for configuring this instance of the extension.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IConfigurationSettings ConfigurationSetting { get => (this._configurationSetting = this._configurationSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ConfigurationSettings()); set => this._configurationSetting = value; }

        /// <summary>Backing field for <see cref="CreationTime" /> property.</summary>
        private string _creationTime;

        /// <summary>
        /// DateLiteral (per ISO8601) noting the time the resource was created by the client (user).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public string CreationTime { get => this._creationTime; }

        /// <summary>Backing field for <see cref="ErrorInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IErrorDefinition _errorInfo;

        /// <summary>Error information from the Agent - e.g. errors during installation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IErrorDefinition ErrorInfo { get => (this._errorInfo = this._errorInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ErrorDefinition()); }

        /// <summary>
        /// Service specific error code which serves as the substatus for the HTTP error code.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public string ErrorInfoCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IErrorDefinitionInternal)ErrorInfo).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IErrorDefinitionInternal)ErrorInfo).Code = value ?? null; }

        /// <summary>Description of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public string ErrorInfoMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IErrorDefinitionInternal)ErrorInfo).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IErrorDefinitionInternal)ErrorInfo).Message = value ?? null; }

        /// <summary>Backing field for <see cref="ExtensionType" /> property.</summary>
        private string _extensionType;

        /// <summary>
        /// Type of the Extension, of which this resource is an instance of. It must be one of the Extension Types registered with
        /// Microsoft.KubernetesConfiguration by the Extension publisher.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public string ExtensionType { get => this._extensionType; set => this._extensionType = value; }

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IConfigurationIdentity _identity;

        /// <summary>The identity of the configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IConfigurationIdentity Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ConfigurationIdentity()); set => this._identity = value; }

        /// <summary>
        /// The principal id of the system assigned identity which is used by the configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IConfigurationIdentityInternal)Identity).PrincipalId; }

        /// <summary>
        /// The tenant id of the system assigned identity which is used by the configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IConfigurationIdentityInternal)Identity).TenantId; }

        /// <summary>
        /// The type of identity used for the configuration. Type 'SystemAssigned' will use an implicitly created identity. Type 'None'
        /// will not use Managed Identity for the configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ResourceIdentityType? IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IConfigurationIdentityInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IConfigurationIdentityInternal)Identity).Type = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ResourceIdentityType)""); }

        /// <summary>Backing field for <see cref="InstallState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.InstallStateType? _installState;

        /// <summary>Status of installation of this instance of the extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.InstallStateType? InstallState { get => this._installState; }

        /// <summary>Backing field for <see cref="LastModifiedTime" /> property.</summary>
        private string _lastModifiedTime;

        /// <summary>
        /// DateLiteral (per ISO8601) noting the time the resource was modified by the client (user).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public string LastModifiedTime { get => this._lastModifiedTime; }

        /// <summary>Backing field for <see cref="LastStatusTime" /> property.</summary>
        private string _lastStatusTime;

        /// <summary>DateLiteral (per ISO8601) noting the time of last status from the agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public string LastStatusTime { get => this._lastStatusTime; }

        /// <summary>Internal Acessors for CreationTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionInstancePropertiesInternal.CreationTime { get => this._creationTime; set { {_creationTime = value;} } }

        /// <summary>Internal Acessors for ErrorInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IErrorDefinition Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionInstancePropertiesInternal.ErrorInfo { get => (this._errorInfo = this._errorInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ErrorDefinition()); set { {_errorInfo = value;} } }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IConfigurationIdentity Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionInstancePropertiesInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ConfigurationIdentity()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionInstancePropertiesInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IConfigurationIdentityInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IConfigurationIdentityInternal)Identity).PrincipalId = value; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionInstancePropertiesInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IConfigurationIdentityInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IConfigurationIdentityInternal)Identity).TenantId = value; }

        /// <summary>Internal Acessors for InstallState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.InstallStateType? Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionInstancePropertiesInternal.InstallState { get => this._installState; set { {_installState = value;} } }

        /// <summary>Internal Acessors for LastModifiedTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionInstancePropertiesInternal.LastModifiedTime { get => this._lastModifiedTime; set { {_lastModifiedTime = value;} } }

        /// <summary>Internal Acessors for LastStatusTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionInstancePropertiesInternal.LastStatusTime { get => this._lastStatusTime; set { {_lastStatusTime = value;} } }

        /// <summary>Internal Acessors for Scope</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScope Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionInstancePropertiesInternal.Scope { get => (this._scope = this._scope ?? new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.Scope()); set { {_scope = value;} } }

        /// <summary>Internal Acessors for ScopeCluster</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScopeCluster Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionInstancePropertiesInternal.ScopeCluster { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScopeInternal)Scope).Cluster; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScopeInternal)Scope).Cluster = value; }

        /// <summary>Internal Acessors for ScopeNamespace</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScopeNamespace Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionInstancePropertiesInternal.ScopeNamespace { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScopeInternal)Scope).Namespace; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScopeInternal)Scope).Namespace = value; }

        /// <summary>
        /// Namespace where the extensionInstance will be created for an Namespace scoped extensionInstance. If this namespace does
        /// not exist, it will be created
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public string NamespaceTargetNamespace { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScopeInternal)Scope).NamespaceTargetNamespace; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScopeInternal)Scope).NamespaceTargetNamespace = value ?? null; }

        /// <summary>Backing field for <see cref="ReleaseTrain" /> property.</summary>
        private string _releaseTrain;

        /// <summary>
        /// ReleaseTrain this extension instance participates in for auto-upgrade (e.g. Stable, Preview, etc.) - only if autoUpgradeMinorVersion
        /// is 'true'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public string ReleaseTrain { get => this._releaseTrain; set => this._releaseTrain = value; }

        /// <summary>Backing field for <see cref="Scope" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScope _scope;

        /// <summary>Scope at which the extension instance is installed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScope Scope { get => (this._scope = this._scope ?? new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.Scope()); set => this._scope = value; }

        /// <summary>Backing field for <see cref="Statuses" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionStatus[] _statuses;

        /// <summary>Status from this instance of the extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionStatus[] Statuses { get => this._statuses; set => this._statuses = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>
        /// Version of the extension for this extension instance, if it is 'pinned' to a specific version. autoUpgradeMinorVersion
        /// must be 'false'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="ExtensionInstanceProperties" /> instance.</summary>
        public ExtensionInstanceProperties()
        {

        }
    }
    /// Properties of an Extension Instance resource
    public partial interface IExtensionInstanceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Flag to note if this instance participates in auto upgrade of minor version, or not.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag to note if this instance participates in auto upgrade of minor version, or not.",
        SerializedName = @"autoUpgradeMinorVersion",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AutoUpgradeMinorVersion { get; set; }
        /// <summary>
        /// Namespace where the extension Release must be placed, for a Cluster scoped extensionInstance. If this namespace does not
        /// exist, it will be created
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Namespace where the extension Release must be placed, for a Cluster scoped extensionInstance.  If this namespace does not exist, it will be created",
        SerializedName = @"releaseNamespace",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterReleaseNamespace { get; set; }
        /// <summary>
        /// Configuration settings that are sensitive, as name-value pairs for configuring this instance of the extension.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Configuration settings that are sensitive, as name-value pairs for configuring this instance of the extension.",
        SerializedName = @"configurationProtectedSettings",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionProtectedSettings) })]
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionProtectedSettings ConfigurationProtectedSetting { get; set; }
        /// <summary>
        /// Configuration settings, as name-value pairs for configuring this instance of the extension.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Configuration settings, as name-value pairs for configuring this instance of the extension.",
        SerializedName = @"configurationSettings",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IConfigurationSettings) })]
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IConfigurationSettings ConfigurationSetting { get; set; }
        /// <summary>
        /// DateLiteral (per ISO8601) noting the time the resource was created by the client (user).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"DateLiteral (per ISO8601) noting the time the resource was created by the client (user).",
        SerializedName = @"creationTime",
        PossibleTypes = new [] { typeof(string) })]
        string CreationTime { get;  }
        /// <summary>
        /// Service specific error code which serves as the substatus for the HTTP error code.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Service specific error code which serves as the substatus for the HTTP error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorInfoCode { get; set; }
        /// <summary>Description of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Description of the error.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorInfoMessage { get; set; }
        /// <summary>
        /// Type of the Extension, of which this resource is an instance of. It must be one of the Extension Types registered with
        /// Microsoft.KubernetesConfiguration by the Extension publisher.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the Extension, of which this resource is an instance of.  It must be one of the Extension Types registered with Microsoft.KubernetesConfiguration by the Extension publisher.",
        SerializedName = @"extensionType",
        PossibleTypes = new [] { typeof(string) })]
        string ExtensionType { get; set; }
        /// <summary>
        /// The principal id of the system assigned identity which is used by the configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The principal id of the system assigned identity which is used by the configuration.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPrincipalId { get;  }
        /// <summary>
        /// The tenant id of the system assigned identity which is used by the configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The tenant id of the system assigned identity which is used by the configuration.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityTenantId { get;  }
        /// <summary>
        /// The type of identity used for the configuration. Type 'SystemAssigned' will use an implicitly created identity. Type 'None'
        /// will not use Managed Identity for the configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity used for the configuration. Type 'SystemAssigned' will use an implicitly created identity. Type 'None' will not use Managed Identity for the configuration.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ResourceIdentityType) })]
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ResourceIdentityType? IdentityType { get; set; }
        /// <summary>Status of installation of this instance of the extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Status of installation of this instance of the extension.",
        SerializedName = @"installState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.InstallStateType) })]
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.InstallStateType? InstallState { get;  }
        /// <summary>
        /// DateLiteral (per ISO8601) noting the time the resource was modified by the client (user).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"DateLiteral (per ISO8601) noting the time the resource was modified by the client (user).",
        SerializedName = @"lastModifiedTime",
        PossibleTypes = new [] { typeof(string) })]
        string LastModifiedTime { get;  }
        /// <summary>DateLiteral (per ISO8601) noting the time of last status from the agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"DateLiteral (per ISO8601) noting the time of last status from the agent.",
        SerializedName = @"lastStatusTime",
        PossibleTypes = new [] { typeof(string) })]
        string LastStatusTime { get;  }
        /// <summary>
        /// Namespace where the extensionInstance will be created for an Namespace scoped extensionInstance. If this namespace does
        /// not exist, it will be created
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Namespace where the extensionInstance will be created for an Namespace scoped extensionInstance.  If this namespace does not exist, it will be created",
        SerializedName = @"targetNamespace",
        PossibleTypes = new [] { typeof(string) })]
        string NamespaceTargetNamespace { get; set; }
        /// <summary>
        /// ReleaseTrain this extension instance participates in for auto-upgrade (e.g. Stable, Preview, etc.) - only if autoUpgradeMinorVersion
        /// is 'true'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ReleaseTrain this extension instance participates in for auto-upgrade (e.g. Stable, Preview, etc.) - only if autoUpgradeMinorVersion is 'true'.",
        SerializedName = @"releaseTrain",
        PossibleTypes = new [] { typeof(string) })]
        string ReleaseTrain { get; set; }
        /// <summary>Status from this instance of the extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Status from this instance of the extension.",
        SerializedName = @"statuses",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionStatus[] Statuses { get; set; }
        /// <summary>
        /// Version of the extension for this extension instance, if it is 'pinned' to a specific version. autoUpgradeMinorVersion
        /// must be 'false'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Version of the extension for this extension instance, if it is 'pinned' to a specific version. autoUpgradeMinorVersion must be 'false'.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// Properties of an Extension Instance resource
    internal partial interface IExtensionInstancePropertiesInternal

    {
        /// <summary>
        /// Flag to note if this instance participates in auto upgrade of minor version, or not.
        /// </summary>
        bool? AutoUpgradeMinorVersion { get; set; }
        /// <summary>
        /// Namespace where the extension Release must be placed, for a Cluster scoped extensionInstance. If this namespace does not
        /// exist, it will be created
        /// </summary>
        string ClusterReleaseNamespace { get; set; }
        /// <summary>
        /// Configuration settings that are sensitive, as name-value pairs for configuring this instance of the extension.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionProtectedSettings ConfigurationProtectedSetting { get; set; }
        /// <summary>
        /// Configuration settings, as name-value pairs for configuring this instance of the extension.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IConfigurationSettings ConfigurationSetting { get; set; }
        /// <summary>
        /// DateLiteral (per ISO8601) noting the time the resource was created by the client (user).
        /// </summary>
        string CreationTime { get; set; }
        /// <summary>Error information from the Agent - e.g. errors during installation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IErrorDefinition ErrorInfo { get; set; }
        /// <summary>
        /// Service specific error code which serves as the substatus for the HTTP error code.
        /// </summary>
        string ErrorInfoCode { get; set; }
        /// <summary>Description of the error.</summary>
        string ErrorInfoMessage { get; set; }
        /// <summary>
        /// Type of the Extension, of which this resource is an instance of. It must be one of the Extension Types registered with
        /// Microsoft.KubernetesConfiguration by the Extension publisher.
        /// </summary>
        string ExtensionType { get; set; }
        /// <summary>The identity of the configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IConfigurationIdentity Identity { get; set; }
        /// <summary>
        /// The principal id of the system assigned identity which is used by the configuration.
        /// </summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>
        /// The tenant id of the system assigned identity which is used by the configuration.
        /// </summary>
        string IdentityTenantId { get; set; }
        /// <summary>
        /// The type of identity used for the configuration. Type 'SystemAssigned' will use an implicitly created identity. Type 'None'
        /// will not use Managed Identity for the configuration.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ResourceIdentityType? IdentityType { get; set; }
        /// <summary>Status of installation of this instance of the extension.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.InstallStateType? InstallState { get; set; }
        /// <summary>
        /// DateLiteral (per ISO8601) noting the time the resource was modified by the client (user).
        /// </summary>
        string LastModifiedTime { get; set; }
        /// <summary>DateLiteral (per ISO8601) noting the time of last status from the agent.</summary>
        string LastStatusTime { get; set; }
        /// <summary>
        /// Namespace where the extensionInstance will be created for an Namespace scoped extensionInstance. If this namespace does
        /// not exist, it will be created
        /// </summary>
        string NamespaceTargetNamespace { get; set; }
        /// <summary>
        /// ReleaseTrain this extension instance participates in for auto-upgrade (e.g. Stable, Preview, etc.) - only if autoUpgradeMinorVersion
        /// is 'true'.
        /// </summary>
        string ReleaseTrain { get; set; }
        /// <summary>Scope at which the extension instance is installed.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScope Scope { get; set; }
        /// <summary>Specifies that the scope of the extensionInstance is Cluster</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScopeCluster ScopeCluster { get; set; }
        /// <summary>Specifies that the scope of the extensionInstance is Namespace</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScopeNamespace ScopeNamespace { get; set; }
        /// <summary>Status from this instance of the extension.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionStatus[] Statuses { get; set; }
        /// <summary>
        /// Version of the extension for this extension instance, if it is 'pinned' to a specific version. autoUpgradeMinorVersion
        /// must be 'false'.
        /// </summary>
        string Version { get; set; }

    }
}