namespace Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Extensions;

    /// <summary>Properties of an Extension resource</summary>
    public partial class ExtensionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionProperties,
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AutoUpgradeMinorVersion" /> property.</summary>
        private bool? _autoUpgradeMinorVersion;

        /// <summary>
        /// Flag to note if this extension participates in auto upgrade of minor version, or not.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public bool? AutoUpgradeMinorVersion { get => this._autoUpgradeMinorVersion; set => this._autoUpgradeMinorVersion = value; }

        /// <summary>
        /// Namespace where the extension Release must be placed, for a Cluster scoped extension. If this namespace does not exist,
        /// it will be created
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public string ClusterReleaseNamespace { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScopeInternal)Scope).ClusterReleaseNamespace; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScopeInternal)Scope).ClusterReleaseNamespace = value ?? null; }

        /// <summary>Backing field for <see cref="ConfigurationProtectedSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesConfigurationProtectedSettings _configurationProtectedSetting;

        /// <summary>
        /// Configuration settings that are sensitive, as name-value pairs for configuring this extension.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesConfigurationProtectedSettings ConfigurationProtectedSetting { get => (this._configurationProtectedSetting = this._configurationProtectedSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ExtensionPropertiesConfigurationProtectedSettings()); set => this._configurationProtectedSetting = value; }

        /// <summary>Backing field for <see cref="ConfigurationSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesConfigurationSettings _configurationSetting;

        /// <summary>Configuration settings, as name-value pairs for configuring this extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesConfigurationSettings ConfigurationSetting { get => (this._configurationSetting = this._configurationSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ExtensionPropertiesConfigurationSettings()); set => this._configurationSetting = value; }

        /// <summary>Backing field for <see cref="CustomLocationSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesCustomLocationSettings _customLocationSetting;

        /// <summary>Custom Location settings properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesCustomLocationSettings CustomLocationSetting { get => (this._customLocationSetting = this._customLocationSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ExtensionPropertiesCustomLocationSettings()); }

        /// <summary>Backing field for <see cref="ErrorInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorDetail _errorInfo;

        /// <summary>Error information from the Agent - e.g. errors during installation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorDetail ErrorInfo { get => (this._errorInfo = this._errorInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.ErrorDetail()); }

        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorAdditionalInfo[] ErrorInfoAdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorDetailInternal)ErrorInfo).AdditionalInfo; }

        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public string ErrorInfoCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorDetailInternal)ErrorInfo).Code; }

        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorDetail[] ErrorInfoDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorDetailInternal)ErrorInfo).Detail; }

        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public string ErrorInfoMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorDetailInternal)ErrorInfo).Message; }

        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public string ErrorInfoTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorDetailInternal)ErrorInfo).Target; }

        /// <summary>Backing field for <see cref="ExtensionType" /> property.</summary>
        private string _extensionType;

        /// <summary>
        /// Type of the Extension, of which this resource is an instance of. It must be one of the Extension Types registered with
        /// Microsoft.KubernetesConfiguration by the Extension publisher.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public string ExtensionType { get => this._extensionType; set => this._extensionType = value; }

        /// <summary>Internal Acessors for CustomLocationSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesCustomLocationSettings Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal.CustomLocationSetting { get => (this._customLocationSetting = this._customLocationSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ExtensionPropertiesCustomLocationSettings()); set { {_customLocationSetting = value;} } }

        /// <summary>Internal Acessors for ErrorInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorDetail Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal.ErrorInfo { get => (this._errorInfo = this._errorInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.ErrorDetail()); set { {_errorInfo = value;} } }

        /// <summary>Internal Acessors for ErrorInfoAdditionalInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorAdditionalInfo[] Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal.ErrorInfoAdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorDetailInternal)ErrorInfo).AdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorDetailInternal)ErrorInfo).AdditionalInfo = value; }

        /// <summary>Internal Acessors for ErrorInfoCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal.ErrorInfoCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorDetailInternal)ErrorInfo).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorDetailInternal)ErrorInfo).Code = value; }

        /// <summary>Internal Acessors for ErrorInfoDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorDetail[] Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal.ErrorInfoDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorDetailInternal)ErrorInfo).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorDetailInternal)ErrorInfo).Detail = value; }

        /// <summary>Internal Acessors for ErrorInfoMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal.ErrorInfoMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorDetailInternal)ErrorInfo).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorDetailInternal)ErrorInfo).Message = value; }

        /// <summary>Internal Acessors for ErrorInfoTarget</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal.ErrorInfoTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorDetailInternal)ErrorInfo).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorDetailInternal)ErrorInfo).Target = value; }

        /// <summary>Internal Acessors for PackageUri</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal.PackageUri { get => this._packageUri; set { {_packageUri = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for Scope</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScope Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal.Scope { get => (this._scope = this._scope ?? new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.Scope()); set { {_scope = value;} } }

        /// <summary>Internal Acessors for ScopeCluster</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScopeCluster Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal.ScopeCluster { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScopeInternal)Scope).Cluster; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScopeInternal)Scope).Cluster = value; }

        /// <summary>Internal Acessors for ScopeNamespace</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScopeNamespace Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal.ScopeNamespace { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScopeInternal)Scope).Namespace; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScopeInternal)Scope).Namespace = value; }

        /// <summary>
        /// Namespace where the extension will be created for an Namespace scoped extension. If this namespace does not exist, it
        /// will be created
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public string NamespaceTargetNamespace { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScopeInternal)Scope).NamespaceTargetNamespace; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScopeInternal)Scope).NamespaceTargetNamespace = value ?? null; }

        /// <summary>Backing field for <see cref="PackageUri" /> property.</summary>
        private string _packageUri;

        /// <summary>Uri of the Helm package</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public string PackageUri { get => this._packageUri; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ProvisioningState? _provisioningState;

        /// <summary>Status of installation of this extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="ReleaseTrain" /> property.</summary>
        private string _releaseTrain;

        /// <summary>
        /// ReleaseTrain this extension participates in for auto-upgrade (e.g. Stable, Preview, etc.) - only if autoUpgradeMinorVersion
        /// is 'true'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public string ReleaseTrain { get => this._releaseTrain; set => this._releaseTrain = value; }

        /// <summary>Backing field for <see cref="Scope" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScope _scope;

        /// <summary>Scope at which the extension is installed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScope Scope { get => (this._scope = this._scope ?? new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.Scope()); set => this._scope = value; }

        /// <summary>Backing field for <see cref="Statuses" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionStatus[] _statuses;

        /// <summary>Status from this extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionStatus[] Statuses { get => this._statuses; set => this._statuses = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>
        /// Version of the extension for this extension, if it is 'pinned' to a specific version. autoUpgradeMinorVersion must be
        /// 'false'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="ExtensionProperties" /> instance.</summary>
        public ExtensionProperties()
        {

        }
    }
    /// Properties of an Extension resource
    public partial interface IExtensionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Flag to note if this extension participates in auto upgrade of minor version, or not.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag to note if this extension participates in auto upgrade of minor version, or not.",
        SerializedName = @"autoUpgradeMinorVersion",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AutoUpgradeMinorVersion { get; set; }
        /// <summary>
        /// Namespace where the extension Release must be placed, for a Cluster scoped extension. If this namespace does not exist,
        /// it will be created
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Namespace where the extension Release must be placed, for a Cluster scoped extension.  If this namespace does not exist, it will be created",
        SerializedName = @"releaseNamespace",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterReleaseNamespace { get; set; }
        /// <summary>
        /// Configuration settings that are sensitive, as name-value pairs for configuring this extension.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Configuration settings that are sensitive, as name-value pairs for configuring this extension.",
        SerializedName = @"configurationProtectedSettings",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesConfigurationProtectedSettings) })]
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesConfigurationProtectedSettings ConfigurationProtectedSetting { get; set; }
        /// <summary>Configuration settings, as name-value pairs for configuring this extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Configuration settings, as name-value pairs for configuring this extension.",
        SerializedName = @"configurationSettings",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesConfigurationSettings) })]
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesConfigurationSettings ConfigurationSetting { get; set; }
        /// <summary>Custom Location settings properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Custom Location settings properties.",
        SerializedName = @"customLocationSettings",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesCustomLocationSettings) })]
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesCustomLocationSettings CustomLocationSetting { get;  }
        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error additional info.",
        SerializedName = @"additionalInfo",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorAdditionalInfo) })]
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorAdditionalInfo[] ErrorInfoAdditionalInfo { get;  }
        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorInfoCode { get;  }
        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error details.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorDetail) })]
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorDetail[] ErrorInfoDetail { get;  }
        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error message.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorInfoMessage { get;  }
        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error target.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorInfoTarget { get;  }
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
        /// Namespace where the extension will be created for an Namespace scoped extension. If this namespace does not exist, it
        /// will be created
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Namespace where the extension will be created for an Namespace scoped extension.  If this namespace does not exist, it will be created",
        SerializedName = @"targetNamespace",
        PossibleTypes = new [] { typeof(string) })]
        string NamespaceTargetNamespace { get; set; }
        /// <summary>Uri of the Helm package</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Uri of the Helm package",
        SerializedName = @"packageUri",
        PossibleTypes = new [] { typeof(string) })]
        string PackageUri { get;  }
        /// <summary>Status of installation of this extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Status of installation of this extension.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>
        /// ReleaseTrain this extension participates in for auto-upgrade (e.g. Stable, Preview, etc.) - only if autoUpgradeMinorVersion
        /// is 'true'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ReleaseTrain this extension participates in for auto-upgrade (e.g. Stable, Preview, etc.) - only if autoUpgradeMinorVersion is 'true'.",
        SerializedName = @"releaseTrain",
        PossibleTypes = new [] { typeof(string) })]
        string ReleaseTrain { get; set; }
        /// <summary>Status from this extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Status from this extension.",
        SerializedName = @"statuses",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionStatus[] Statuses { get; set; }
        /// <summary>
        /// Version of the extension for this extension, if it is 'pinned' to a specific version. autoUpgradeMinorVersion must be
        /// 'false'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Version of the extension for this extension, if it is 'pinned' to a specific version. autoUpgradeMinorVersion must be 'false'.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// Properties of an Extension resource
    internal partial interface IExtensionPropertiesInternal

    {
        /// <summary>
        /// Flag to note if this extension participates in auto upgrade of minor version, or not.
        /// </summary>
        bool? AutoUpgradeMinorVersion { get; set; }
        /// <summary>
        /// Namespace where the extension Release must be placed, for a Cluster scoped extension. If this namespace does not exist,
        /// it will be created
        /// </summary>
        string ClusterReleaseNamespace { get; set; }
        /// <summary>
        /// Configuration settings that are sensitive, as name-value pairs for configuring this extension.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesConfigurationProtectedSettings ConfigurationProtectedSetting { get; set; }
        /// <summary>Configuration settings, as name-value pairs for configuring this extension.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesConfigurationSettings ConfigurationSetting { get; set; }
        /// <summary>Custom Location settings properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesCustomLocationSettings CustomLocationSetting { get; set; }
        /// <summary>Error information from the Agent - e.g. errors during installation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorDetail ErrorInfo { get; set; }
        /// <summary>The error additional info.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorAdditionalInfo[] ErrorInfoAdditionalInfo { get; set; }
        /// <summary>The error code.</summary>
        string ErrorInfoCode { get; set; }
        /// <summary>The error details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorDetail[] ErrorInfoDetail { get; set; }
        /// <summary>The error message.</summary>
        string ErrorInfoMessage { get; set; }
        /// <summary>The error target.</summary>
        string ErrorInfoTarget { get; set; }
        /// <summary>
        /// Type of the Extension, of which this resource is an instance of. It must be one of the Extension Types registered with
        /// Microsoft.KubernetesConfiguration by the Extension publisher.
        /// </summary>
        string ExtensionType { get; set; }
        /// <summary>
        /// Namespace where the extension will be created for an Namespace scoped extension. If this namespace does not exist, it
        /// will be created
        /// </summary>
        string NamespaceTargetNamespace { get; set; }
        /// <summary>Uri of the Helm package</summary>
        string PackageUri { get; set; }
        /// <summary>Status of installation of this extension.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>
        /// ReleaseTrain this extension participates in for auto-upgrade (e.g. Stable, Preview, etc.) - only if autoUpgradeMinorVersion
        /// is 'true'.
        /// </summary>
        string ReleaseTrain { get; set; }
        /// <summary>Scope at which the extension is installed.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScope Scope { get; set; }
        /// <summary>Specifies that the scope of the extension is Cluster</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScopeCluster ScopeCluster { get; set; }
        /// <summary>Specifies that the scope of the extension is Namespace</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScopeNamespace ScopeNamespace { get; set; }
        /// <summary>Status from this extension.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionStatus[] Statuses { get; set; }
        /// <summary>
        /// Version of the extension for this extension, if it is 'pinned' to a specific version. autoUpgradeMinorVersion must be
        /// 'false'.
        /// </summary>
        string Version { get; set; }

    }
}