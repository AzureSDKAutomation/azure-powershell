namespace Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Extensions;

    /// <summary>The Extension Instance object.</summary>
    public partial class ExtensionInstance :
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstance,
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstanceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.Resource();

        /// <summary>
        /// Flag to note if this instance participates in auto upgrade of minor version, or not.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inlined)]
        public bool? AutoUpgradeMinorVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).AutoUpgradeMinorVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).AutoUpgradeMinorVersion = value ?? default(bool); }

        /// <summary>
        /// Namespace where the extension Release must be placed, for a Cluster scoped extensionInstance. If this namespace does not
        /// exist, it will be created
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inlined)]
        public string ClusterReleaseNamespace { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).ClusterReleaseNamespace; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).ClusterReleaseNamespace = value ?? null; }

        /// <summary>
        /// Configuration settings that are sensitive, as name-value pairs for configuring this instance of the extension.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionProtectedSettings ConfigurationProtectedSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).ConfigurationProtectedSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).ConfigurationProtectedSetting = value ?? null /* model class */; }

        /// <summary>
        /// Configuration settings, as name-value pairs for configuring this instance of the extension.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IConfigurationSettings ConfigurationSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).ConfigurationSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).ConfigurationSetting = value ?? null /* model class */; }

        /// <summary>
        /// DateLiteral (per ISO8601) noting the time the resource was created by the client (user).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inlined)]
        public string CreationTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).CreationTime; }

        /// <summary>
        /// Service specific error code which serves as the substatus for the HTTP error code.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inlined)]
        public string ErrorInfoCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).ErrorInfoCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).ErrorInfoCode = value ?? null; }

        /// <summary>Description of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inlined)]
        public string ErrorInfoMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).ErrorInfoMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).ErrorInfoMessage = value ?? null; }

        /// <summary>
        /// Type of the Extension, of which this resource is an instance of. It must be one of the Extension Types registered with
        /// Microsoft.KubernetesConfiguration by the Extension publisher.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inlined)]
        public string ExtensionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).ExtensionType; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).ExtensionType = value ?? null; }

        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal)__resource).Id; }

        /// <summary>
        /// The principal id of the system assigned identity which is used by the configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).IdentityPrincipalId; }

        /// <summary>
        /// The tenant id of the system assigned identity which is used by the configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).IdentityTenantId; }

        /// <summary>
        /// The type of identity used for the configuration. Type 'SystemAssigned' will use an implicitly created identity. Type 'None'
        /// will not use Managed Identity for the configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.ResourceIdentityType? IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).IdentityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).IdentityType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.ResourceIdentityType)""); }

        /// <summary>Status of installation of this instance of the extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.InstallStateType? InstallState { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).InstallState; }

        /// <summary>
        /// DateLiteral (per ISO8601) noting the time the resource was modified by the client (user).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inlined)]
        public string LastModifiedTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).LastModifiedTime; }

        /// <summary>DateLiteral (per ISO8601) noting the time of last status from the agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inlined)]
        public string LastStatusTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).LastStatusTime; }

        /// <summary>Internal Acessors for CreationTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstanceInternal.CreationTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).CreationTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).CreationTime = value; }

        /// <summary>Internal Acessors for ErrorInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IErrorDefinition Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstanceInternal.ErrorInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).ErrorInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).ErrorInfo = value; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IConfigurationIdentity Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstanceInternal.Identity { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).Identity; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).Identity = value; }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstanceInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).IdentityPrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).IdentityPrincipalId = value; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstanceInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).IdentityTenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).IdentityTenantId = value; }

        /// <summary>Internal Acessors for InstallState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.InstallStateType? Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstanceInternal.InstallState { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).InstallState; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).InstallState = value; }

        /// <summary>Internal Acessors for LastModifiedTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstanceInternal.LastModifiedTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).LastModifiedTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).LastModifiedTime = value; }

        /// <summary>Internal Acessors for LastStatusTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstanceInternal.LastStatusTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).LastStatusTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).LastStatusTime = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstanceProperties Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstanceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.ExtensionInstanceProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Scope</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IScope Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstanceInternal.Scope { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).Scope; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).Scope = value; }

        /// <summary>Internal Acessors for ScopeCluster</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IScopeCluster Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstanceInternal.ScopeCluster { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).ScopeCluster; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).ScopeCluster = value; }

        /// <summary>Internal Acessors for ScopeNamespace</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IScopeNamespace Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstanceInternal.ScopeNamespace { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).ScopeNamespace; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).ScopeNamespace = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal)__resource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal)__resource).SystemDataCreatedAt = value; }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal)__resource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal)__resource).SystemDataCreatedBy = value; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal)__resource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal)__resource).SystemDataCreatedByType = value; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal)__resource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal)__resource).SystemDataLastModifiedAt = value; }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal)__resource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal)__resource).SystemDataLastModifiedBy = value; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal)__resource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal)__resource).SystemDataLastModifiedByType = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal)__resource).Type = value; }

        /// <summary>Resource name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal)__resource).Name; }

        /// <summary>
        /// Namespace where the extensionInstance will be created for an Namespace scoped extensionInstance. If this namespace does
        /// not exist, it will be created
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inlined)]
        public string NamespaceTargetNamespace { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).NamespaceTargetNamespace; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).NamespaceTargetNamespace = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstanceProperties _property;

        /// <summary>Properties of an Extension Instance resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstanceProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.ExtensionInstanceProperties()); set => this._property = value; }

        /// <summary>
        /// ReleaseTrain this extension instance participates in for auto-upgrade (e.g. Stable, Preview, etc.) - only if autoUpgradeMinorVersion
        /// is 'true'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inlined)]
        public string ReleaseTrain { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).ReleaseTrain; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).ReleaseTrain = value ?? null; }

        /// <summary>Status from this instance of the extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionStatus[] Statuses { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).Statuses; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).Statuses = value ?? null /* arrayOf */; }

        /// <summary>
        /// Top level metadata https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/common-api-contracts.md#system-metadata-for-all-azure-resources
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal)__resource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal)__resource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal)__resource).SystemDataCreatedAt; }

        /// <summary>A string identifier for the identity that created the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal)__resource).SystemDataCreatedBy; }

        /// <summary>
        /// The type of identity that created the resource: user, application, managedIdentity, key
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal)__resource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal)__resource).SystemDataLastModifiedAt; }

        /// <summary>A string identifier for the identity that last modified the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal)__resource).SystemDataLastModifiedBy; }

        /// <summary>
        /// The type of identity that last modified the resource: user, application, managedIdentity, key
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal)__resource).SystemDataLastModifiedByType; }

        /// <summary>Resource type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal)__resource).Type; }

        /// <summary>
        /// Version of the extension for this extension instance, if it is 'pinned' to a specific version. autoUpgradeMinorVersion
        /// must be 'false'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inlined)]
        public string Version { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).Version; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)Property).Version = value ?? null; }

        /// <summary>Creates an new <see cref="ExtensionInstance" /> instance.</summary>
        public ExtensionInstance()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// The Extension Instance object.
    public partial interface IExtensionInstance :
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResource
    {
        /// <summary>
        /// Flag to note if this instance participates in auto upgrade of minor version, or not.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Namespace where the extension Release must be placed, for a Cluster scoped extensionInstance.  If this namespace does not exist, it will be created",
        SerializedName = @"releaseNamespace",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterReleaseNamespace { get; set; }
        /// <summary>
        /// Configuration settings that are sensitive, as name-value pairs for configuring this instance of the extension.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Configuration settings that are sensitive, as name-value pairs for configuring this instance of the extension.",
        SerializedName = @"configurationProtectedSettings",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionProtectedSettings) })]
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionProtectedSettings ConfigurationProtectedSetting { get; set; }
        /// <summary>
        /// Configuration settings, as name-value pairs for configuring this instance of the extension.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Configuration settings, as name-value pairs for configuring this instance of the extension.",
        SerializedName = @"configurationSettings",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IConfigurationSettings) })]
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IConfigurationSettings ConfigurationSetting { get; set; }
        /// <summary>
        /// DateLiteral (per ISO8601) noting the time the resource was created by the client (user).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"DateLiteral (per ISO8601) noting the time the resource was created by the client (user).",
        SerializedName = @"creationTime",
        PossibleTypes = new [] { typeof(string) })]
        string CreationTime { get;  }
        /// <summary>
        /// Service specific error code which serves as the substatus for the HTTP error code.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Service specific error code which serves as the substatus for the HTTP error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorInfoCode { get; set; }
        /// <summary>Description of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the Extension, of which this resource is an instance of.  It must be one of the Extension Types registered with Microsoft.KubernetesConfiguration by the Extension publisher.",
        SerializedName = @"extensionType",
        PossibleTypes = new [] { typeof(string) })]
        string ExtensionType { get; set; }
        /// <summary>
        /// The principal id of the system assigned identity which is used by the configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The principal id of the system assigned identity which is used by the configuration.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPrincipalId { get;  }
        /// <summary>
        /// The tenant id of the system assigned identity which is used by the configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity used for the configuration. Type 'SystemAssigned' will use an implicitly created identity. Type 'None' will not use Managed Identity for the configuration.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.ResourceIdentityType) })]
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.ResourceIdentityType? IdentityType { get; set; }
        /// <summary>Status of installation of this instance of the extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Status of installation of this instance of the extension.",
        SerializedName = @"installState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.InstallStateType) })]
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.InstallStateType? InstallState { get;  }
        /// <summary>
        /// DateLiteral (per ISO8601) noting the time the resource was modified by the client (user).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"DateLiteral (per ISO8601) noting the time the resource was modified by the client (user).",
        SerializedName = @"lastModifiedTime",
        PossibleTypes = new [] { typeof(string) })]
        string LastModifiedTime { get;  }
        /// <summary>DateLiteral (per ISO8601) noting the time of last status from the agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ReleaseTrain this extension instance participates in for auto-upgrade (e.g. Stable, Preview, etc.) - only if autoUpgradeMinorVersion is 'true'.",
        SerializedName = @"releaseTrain",
        PossibleTypes = new [] { typeof(string) })]
        string ReleaseTrain { get; set; }
        /// <summary>Status from this instance of the extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Status from this instance of the extension.",
        SerializedName = @"statuses",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionStatus[] Statuses { get; set; }
        /// <summary>
        /// Version of the extension for this extension instance, if it is 'pinned' to a specific version. autoUpgradeMinorVersion
        /// must be 'false'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Version of the extension for this extension instance, if it is 'pinned' to a specific version. autoUpgradeMinorVersion must be 'false'.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// The Extension Instance object.
    internal partial interface IExtensionInstanceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IResourceInternal
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
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionProtectedSettings ConfigurationProtectedSetting { get; set; }
        /// <summary>
        /// Configuration settings, as name-value pairs for configuring this instance of the extension.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IConfigurationSettings ConfigurationSetting { get; set; }
        /// <summary>
        /// DateLiteral (per ISO8601) noting the time the resource was created by the client (user).
        /// </summary>
        string CreationTime { get; set; }
        /// <summary>Error information from the Agent - e.g. errors during installation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IErrorDefinition ErrorInfo { get; set; }
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
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IConfigurationIdentity Identity { get; set; }
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
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.ResourceIdentityType? IdentityType { get; set; }
        /// <summary>Status of installation of this instance of the extension.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.InstallStateType? InstallState { get; set; }
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
        /// <summary>Properties of an Extension Instance resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstanceProperties Property { get; set; }
        /// <summary>
        /// ReleaseTrain this extension instance participates in for auto-upgrade (e.g. Stable, Preview, etc.) - only if autoUpgradeMinorVersion
        /// is 'true'.
        /// </summary>
        string ReleaseTrain { get; set; }
        /// <summary>Scope at which the extension instance is installed.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IScope Scope { get; set; }
        /// <summary>Specifies that the scope of the extensionInstance is Cluster</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IScopeCluster ScopeCluster { get; set; }
        /// <summary>Specifies that the scope of the extensionInstance is Namespace</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IScopeNamespace ScopeNamespace { get; set; }
        /// <summary>Status from this instance of the extension.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionStatus[] Statuses { get; set; }
        /// <summary>
        /// Version of the extension for this extension instance, if it is 'pinned' to a specific version. autoUpgradeMinorVersion
        /// must be 'false'.
        /// </summary>
        string Version { get; set; }

    }
}