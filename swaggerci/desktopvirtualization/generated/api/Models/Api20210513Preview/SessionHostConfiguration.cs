namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    /// <summary>Represents a SessionHostConfiguration definition.</summary>
    public partial class SessionHostConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.Resource();

        /// <summary>The disk type used by virtual machine in hostpool session host.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.VirtualMachineDiskType? DiskType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).DiskType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).DiskType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.VirtualMachineDiskType)""); }

        /// <summary>The keyvault resource id to the keyvault secrets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string DomainAdminPasswordKeyVaultResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).DomainAdminPasswordKeyVaultResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).DomainAdminPasswordKeyVaultResourceId = value ?? null; }

        /// <summary>The keyvault secret name the password is stored in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string DomainAdminPasswordSecretName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).DomainAdminPasswordSecretName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).DomainAdminPasswordSecretName = value ?? null; }

        /// <summary>The user name to the account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string DomainAdminUserName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).DomainAdminUserName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).DomainAdminUserName = value ?? null; }

        /// <summary>The type of domain join done by the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.DomainJoinType? DomainInfoJoinType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).DomainInfoJoinType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).DomainInfoJoinType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.DomainJoinType)""); }

        /// <summary>
        /// The MDM Provider GUID used during MDM enrollment for Azure AD joined virtual machines.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string DomainInfoMdmProviderGuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).DomainInfoMdmProviderGuid; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).DomainInfoMdmProviderGuid = value ?? null; }

        /// <summary>The domain a virtual machine connected to a hostpool will join.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string DomainInfoName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).DomainInfoName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).DomainInfoName = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal)__resource).Id; }

        /// <summary>
        /// The resource id of the custom image or shared image. Image type must be CustomImage.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string ImageInfoCustomId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).ImageInfoCustomId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).ImageInfoCustomId = value ?? null; }

        /// <summary>
        /// The uri to the storage blob which contains the VHD. Image type must be StorageBlob.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string ImageInfoStorageBlobUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).ImageInfoStorageBlobUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).ImageInfoStorageBlobUri = value ?? null; }

        /// <summary>The type of image session hosts use in the hostpool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ImageType? ImageInfoType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).ImageInfoType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).ImageInfoType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ImageType)""); }

        /// <summary>The keyvault resource id to the keyvault secrets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string LocalAdminPasswordKeyVaultResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).LocalAdminPasswordKeyVaultResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).LocalAdminPasswordKeyVaultResourceId = value ?? null; }

        /// <summary>The keyvault secret name the password is stored in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string LocalAdminPasswordSecretName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).LocalAdminPasswordSecretName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).LocalAdminPasswordSecretName = value ?? null; }

        /// <summary>The user name to the account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string LocalAdminUserName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).LocalAdminUserName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).LocalAdminUserName = value ?? null; }

        /// <summary>The exact version of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string MarketPlaceInfoExactVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).MarketPlaceInfoExactVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).MarketPlaceInfoExactVersion = value ?? null; }

        /// <summary>The offer of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string MarketPlaceInfoOffer { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).MarketPlaceInfoOffer; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).MarketPlaceInfoOffer = value ?? null; }

        /// <summary>The publisher of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string MarketPlaceInfoPublisher { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).MarketPlaceInfoPublisher; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).MarketPlaceInfoPublisher = value ?? null; }

        /// <summary>The sku of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string MarketPlaceInfoSku { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).MarketPlaceInfoSku; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).MarketPlaceInfoSku = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for CredentialsDomainAdmin</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationInternal.CredentialsDomainAdmin { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).CredentialsDomainAdmin; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).CredentialsDomainAdmin = value; }

        /// <summary>Internal Acessors for CredentialsLocalAdmin</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationInternal.CredentialsLocalAdmin { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).CredentialsLocalAdmin; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).CredentialsLocalAdmin = value; }

        /// <summary>Internal Acessors for DomainInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationInternal.DomainInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).DomainInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).DomainInfo = value; }

        /// <summary>Internal Acessors for DomainInfoCredentials</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ICredentialsProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationInternal.DomainInfoCredentials { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).DomainInfoCredentials; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).DomainInfoCredentials = value; }

        /// <summary>Internal Acessors for ImageInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IImageInfoProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationInternal.ImageInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).ImageInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).ImageInfo = value; }

        /// <summary>Internal Acessors for ImageInfoMarketPlaceInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMarketPlaceInfoProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationInternal.ImageInfoMarketPlaceInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).ImageInfoMarketPlaceInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).ImageInfoMarketPlaceInfo = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.SessionHostConfigurationProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20.ISystemData Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationInternal.SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20.SystemData()); set { {_systemData = value;} } }

        /// <summary>Internal Acessors for Version</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationInternal.Version { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).Version; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).Version = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationProperties _property;

        /// <summary>Detailed properties for SessionHostConfiguration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.SessionHostConfigurationProperties()); set => this._property = value; }

        /// <summary>Backing field for <see cref="SystemData" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20.ISystemData _systemData;

        /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20.ISystemData SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20.SystemData()); }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20.ISystemDataInternal)SystemData).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20.ISystemDataInternal)SystemData).CreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20.ISystemDataInternal)SystemData).CreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20.ISystemDataInternal)SystemData).CreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20.ISystemDataInternal)SystemData).CreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20.ISystemDataInternal)SystemData).CreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20.ISystemDataInternal)SystemData).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20.ISystemDataInternal)SystemData).LastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20.ISystemDataInternal)SystemData).LastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20.ISystemDataInternal)SystemData).LastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20.ISystemDataInternal)SystemData).LastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20.ISystemDataInternal)SystemData).LastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.CreatedByType)""); }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal)__resource).Type; }

        /// <summary>
        /// The uri to the storage blob containing scripts to be run on the virtual machine after provisioning.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string VMCustomConfigurationUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).VMCustomConfigurationUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).VMCustomConfigurationUri = value ?? null; }

        /// <summary>The id of the size of a virtual machine connected to a hostpool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string VMSizeId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).VMSizeId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).VMSizeId = value ?? null; }

        /// <summary>
        /// The time when session host configuration was last modified and something was changed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public global::System.DateTime? Version { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)Property).Version; }

        /// <summary>Creates an new <see cref="SessionHostConfiguration" /> instance.</summary>
        public SessionHostConfiguration()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Represents a SessionHostConfiguration definition.
    public partial interface ISessionHostConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResource
    {
        /// <summary>The disk type used by virtual machine in hostpool session host.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The disk type used by virtual machine in hostpool session host.",
        SerializedName = @"diskType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.VirtualMachineDiskType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.VirtualMachineDiskType? DiskType { get; set; }
        /// <summary>The keyvault resource id to the keyvault secrets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The keyvault resource id to the keyvault secrets.",
        SerializedName = @"passwordKeyVaultResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string DomainAdminPasswordKeyVaultResourceId { get; set; }
        /// <summary>The keyvault secret name the password is stored in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The keyvault secret name the password is stored in.",
        SerializedName = @"passwordSecretName",
        PossibleTypes = new [] { typeof(string) })]
        string DomainAdminPasswordSecretName { get; set; }
        /// <summary>The user name to the account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The user name to the account.",
        SerializedName = @"userName",
        PossibleTypes = new [] { typeof(string) })]
        string DomainAdminUserName { get; set; }
        /// <summary>The type of domain join done by the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of domain join done by the virtual machine.",
        SerializedName = @"joinType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.DomainJoinType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.DomainJoinType? DomainInfoJoinType { get; set; }
        /// <summary>
        /// The MDM Provider GUID used during MDM enrollment for Azure AD joined virtual machines.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The MDM Provider GUID used during MDM enrollment for Azure AD joined virtual machines.",
        SerializedName = @"mdmProviderGuid",
        PossibleTypes = new [] { typeof(string) })]
        string DomainInfoMdmProviderGuid { get; set; }
        /// <summary>The domain a virtual machine connected to a hostpool will join.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The domain a virtual machine connected to a hostpool will join.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string DomainInfoName { get; set; }
        /// <summary>
        /// The resource id of the custom image or shared image. Image type must be CustomImage.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource id of the custom image or shared image. Image type must be CustomImage.",
        SerializedName = @"customId",
        PossibleTypes = new [] { typeof(string) })]
        string ImageInfoCustomId { get; set; }
        /// <summary>
        /// The uri to the storage blob which contains the VHD. Image type must be StorageBlob.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The uri to the storage blob which contains the VHD. Image type must be StorageBlob.",
        SerializedName = @"storageBlobUri",
        PossibleTypes = new [] { typeof(string) })]
        string ImageInfoStorageBlobUri { get; set; }
        /// <summary>The type of image session hosts use in the hostpool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of image session hosts use in the hostpool.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ImageType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ImageType? ImageInfoType { get; set; }
        /// <summary>The keyvault resource id to the keyvault secrets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The keyvault resource id to the keyvault secrets.",
        SerializedName = @"passwordKeyVaultResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string LocalAdminPasswordKeyVaultResourceId { get; set; }
        /// <summary>The keyvault secret name the password is stored in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The keyvault secret name the password is stored in.",
        SerializedName = @"passwordSecretName",
        PossibleTypes = new [] { typeof(string) })]
        string LocalAdminPasswordSecretName { get; set; }
        /// <summary>The user name to the account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The user name to the account.",
        SerializedName = @"userName",
        PossibleTypes = new [] { typeof(string) })]
        string LocalAdminUserName { get; set; }
        /// <summary>The exact version of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The exact version of the image.",
        SerializedName = @"exactVersion",
        PossibleTypes = new [] { typeof(string) })]
        string MarketPlaceInfoExactVersion { get; set; }
        /// <summary>The offer of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The offer of the image.",
        SerializedName = @"offer",
        PossibleTypes = new [] { typeof(string) })]
        string MarketPlaceInfoOffer { get; set; }
        /// <summary>The publisher of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The publisher of the image.",
        SerializedName = @"publisher",
        PossibleTypes = new [] { typeof(string) })]
        string MarketPlaceInfoPublisher { get; set; }
        /// <summary>The sku of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The sku of the image.",
        SerializedName = @"sku",
        PossibleTypes = new [] { typeof(string) })]
        string MarketPlaceInfoSku { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that created the resource.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource last modification (UTC)",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that last modified the resource.",
        SerializedName = @"lastModifiedBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }
        /// <summary>
        /// The uri to the storage blob containing scripts to be run on the virtual machine after provisioning.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The uri to the storage blob containing scripts to be run on the virtual machine after provisioning.",
        SerializedName = @"vmCustomConfigurationUri",
        PossibleTypes = new [] { typeof(string) })]
        string VMCustomConfigurationUri { get; set; }
        /// <summary>The id of the size of a virtual machine connected to a hostpool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The id of the size of a virtual machine connected to a hostpool.",
        SerializedName = @"vMSizeId",
        PossibleTypes = new [] { typeof(string) })]
        string VMSizeId { get; set; }
        /// <summary>
        /// The time when session host configuration was last modified and something was changed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The time when session host configuration was last modified and something was changed.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? Version { get;  }

    }
    /// Represents a SessionHostConfiguration definition.
    internal partial interface ISessionHostConfigurationInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal
    {
        /// <summary>The domain admin credentials.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialProperties CredentialsDomainAdmin { get; set; }
        /// <summary>The local admin credentials.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialProperties CredentialsLocalAdmin { get; set; }
        /// <summary>The disk type used by virtual machine in hostpool session host.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.VirtualMachineDiskType? DiskType { get; set; }
        /// <summary>The keyvault resource id to the keyvault secrets.</summary>
        string DomainAdminPasswordKeyVaultResourceId { get; set; }
        /// <summary>The keyvault secret name the password is stored in.</summary>
        string DomainAdminPasswordSecretName { get; set; }
        /// <summary>The user name to the account.</summary>
        string DomainAdminUserName { get; set; }
        /// <summary>Domain configurations of session hosts.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoProperties DomainInfo { get; set; }
        /// <summary>Credentials needed to create the virtual machine.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ICredentialsProperties DomainInfoCredentials { get; set; }
        /// <summary>The type of domain join done by the virtual machine.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.DomainJoinType? DomainInfoJoinType { get; set; }
        /// <summary>
        /// The MDM Provider GUID used during MDM enrollment for Azure AD joined virtual machines.
        /// </summary>
        string DomainInfoMdmProviderGuid { get; set; }
        /// <summary>The domain a virtual machine connected to a hostpool will join.</summary>
        string DomainInfoName { get; set; }
        /// <summary>Image configurations of HostPool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IImageInfoProperties ImageInfo { get; set; }
        /// <summary>
        /// The resource id of the custom image or shared image. Image type must be CustomImage.
        /// </summary>
        string ImageInfoCustomId { get; set; }
        /// <summary>The values to uniquely identify a gallery image.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMarketPlaceInfoProperties ImageInfoMarketPlaceInfo { get; set; }
        /// <summary>
        /// The uri to the storage blob which contains the VHD. Image type must be StorageBlob.
        /// </summary>
        string ImageInfoStorageBlobUri { get; set; }
        /// <summary>The type of image session hosts use in the hostpool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ImageType? ImageInfoType { get; set; }
        /// <summary>The keyvault resource id to the keyvault secrets.</summary>
        string LocalAdminPasswordKeyVaultResourceId { get; set; }
        /// <summary>The keyvault secret name the password is stored in.</summary>
        string LocalAdminPasswordSecretName { get; set; }
        /// <summary>The user name to the account.</summary>
        string LocalAdminUserName { get; set; }
        /// <summary>The exact version of the image.</summary>
        string MarketPlaceInfoExactVersion { get; set; }
        /// <summary>The offer of the image.</summary>
        string MarketPlaceInfoOffer { get; set; }
        /// <summary>The publisher of the image.</summary>
        string MarketPlaceInfoPublisher { get; set; }
        /// <summary>The sku of the image.</summary>
        string MarketPlaceInfoSku { get; set; }
        /// <summary>Detailed properties for SessionHostConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationProperties Property { get; set; }
        /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20.ISystemData SystemData { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }
        /// <summary>
        /// The uri to the storage blob containing scripts to be run on the virtual machine after provisioning.
        /// </summary>
        string VMCustomConfigurationUri { get; set; }
        /// <summary>The id of the size of a virtual machine connected to a hostpool.</summary>
        string VMSizeId { get; set; }
        /// <summary>
        /// The time when session host configuration was last modified and something was changed.
        /// </summary>
        global::System.DateTime? Version { get; set; }

    }
}