namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    /// <summary>Session host configurations of HostPool.</summary>
    public partial class SessionHostConfigurationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal
    {

        /// <summary>Backing field for <see cref="DiskType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.VirtualMachineDiskType? _diskType;

        /// <summary>The disk type used by virtual machine in hostpool session host.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.VirtualMachineDiskType? DiskType { get => this._diskType; set => this._diskType = value; }

        /// <summary>The keyvault resource id to the keyvault secrets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string DomainAdminPasswordKeyVaultResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoPropertiesInternal)DomainInfo).DomainAdminPasswordKeyVaultResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoPropertiesInternal)DomainInfo).DomainAdminPasswordKeyVaultResourceId = value ?? null; }

        /// <summary>The keyvault secret name the password is stored in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string DomainAdminPasswordSecretName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoPropertiesInternal)DomainInfo).DomainAdminPasswordSecretName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoPropertiesInternal)DomainInfo).DomainAdminPasswordSecretName = value ?? null; }

        /// <summary>The user name to the account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string DomainAdminUserName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoPropertiesInternal)DomainInfo).DomainAdminUserName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoPropertiesInternal)DomainInfo).DomainAdminUserName = value ?? null; }

        /// <summary>Backing field for <see cref="DomainInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoProperties _domainInfo;

        /// <summary>Domain configurations of session hosts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoProperties DomainInfo { get => (this._domainInfo = this._domainInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.DomainInfoProperties()); set => this._domainInfo = value; }

        /// <summary>The type of domain join done by the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.DomainJoinType? DomainInfoJoinType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoPropertiesInternal)DomainInfo).JoinType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoPropertiesInternal)DomainInfo).JoinType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.DomainJoinType)""); }

        /// <summary>
        /// The MDM Provider GUID used during MDM enrollment for Azure AD joined virtual machines.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string DomainInfoMdmProviderGuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoPropertiesInternal)DomainInfo).MdmProviderGuid; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoPropertiesInternal)DomainInfo).MdmProviderGuid = value ?? null; }

        /// <summary>The domain a virtual machine connected to a hostpool will join.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string DomainInfoName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoPropertiesInternal)DomainInfo).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoPropertiesInternal)DomainInfo).Name = value ?? null; }

        /// <summary>Backing field for <see cref="ImageInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IImageInfoProperties _imageInfo;

        /// <summary>Image configurations of HostPool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IImageInfoProperties ImageInfo { get => (this._imageInfo = this._imageInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ImageInfoProperties()); set => this._imageInfo = value; }

        /// <summary>
        /// The resource id of the custom image or shared image. Image type must be CustomImage.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string ImageInfoCustomId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IImageInfoPropertiesInternal)ImageInfo).CustomId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IImageInfoPropertiesInternal)ImageInfo).CustomId = value ?? null; }

        /// <summary>
        /// The uri to the storage blob which contains the VHD. Image type must be StorageBlob.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string ImageInfoStorageBlobUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IImageInfoPropertiesInternal)ImageInfo).StorageBlobUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IImageInfoPropertiesInternal)ImageInfo).StorageBlobUri = value ?? null; }

        /// <summary>The type of image session hosts use in the hostpool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ImageType? ImageInfoType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IImageInfoPropertiesInternal)ImageInfo).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IImageInfoPropertiesInternal)ImageInfo).Type = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ImageType)""); }

        /// <summary>The keyvault resource id to the keyvault secrets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string LocalAdminPasswordKeyVaultResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoPropertiesInternal)DomainInfo).LocalAdminPasswordKeyVaultResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoPropertiesInternal)DomainInfo).LocalAdminPasswordKeyVaultResourceId = value ?? null; }

        /// <summary>The keyvault secret name the password is stored in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string LocalAdminPasswordSecretName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoPropertiesInternal)DomainInfo).LocalAdminPasswordSecretName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoPropertiesInternal)DomainInfo).LocalAdminPasswordSecretName = value ?? null; }

        /// <summary>The user name to the account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string LocalAdminUserName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoPropertiesInternal)DomainInfo).LocalAdminUserName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoPropertiesInternal)DomainInfo).LocalAdminUserName = value ?? null; }

        /// <summary>The exact version of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string MarketPlaceInfoExactVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IImageInfoPropertiesInternal)ImageInfo).MarketPlaceInfoExactVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IImageInfoPropertiesInternal)ImageInfo).MarketPlaceInfoExactVersion = value ?? null; }

        /// <summary>The offer of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string MarketPlaceInfoOffer { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IImageInfoPropertiesInternal)ImageInfo).MarketPlaceInfoOffer; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IImageInfoPropertiesInternal)ImageInfo).MarketPlaceInfoOffer = value ?? null; }

        /// <summary>The publisher of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string MarketPlaceInfoPublisher { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IImageInfoPropertiesInternal)ImageInfo).MarketPlaceInfoPublisher; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IImageInfoPropertiesInternal)ImageInfo).MarketPlaceInfoPublisher = value ?? null; }

        /// <summary>The sku of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string MarketPlaceInfoSku { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IImageInfoPropertiesInternal)ImageInfo).MarketPlaceInfoSku; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IImageInfoPropertiesInternal)ImageInfo).MarketPlaceInfoSku = value ?? null; }

        /// <summary>Internal Acessors for CredentialsDomainAdmin</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal.CredentialsDomainAdmin { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoPropertiesInternal)DomainInfo).CredentialsDomainAdmin; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoPropertiesInternal)DomainInfo).CredentialsDomainAdmin = value; }

        /// <summary>Internal Acessors for CredentialsLocalAdmin</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal.CredentialsLocalAdmin { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoPropertiesInternal)DomainInfo).CredentialsLocalAdmin; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoPropertiesInternal)DomainInfo).CredentialsLocalAdmin = value; }

        /// <summary>Internal Acessors for DomainInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal.DomainInfo { get => (this._domainInfo = this._domainInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.DomainInfoProperties()); set { {_domainInfo = value;} } }

        /// <summary>Internal Acessors for DomainInfoCredentials</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ICredentialsProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal.DomainInfoCredentials { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoPropertiesInternal)DomainInfo).Credentials; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoPropertiesInternal)DomainInfo).Credentials = value; }

        /// <summary>Internal Acessors for ImageInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IImageInfoProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal.ImageInfo { get => (this._imageInfo = this._imageInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ImageInfoProperties()); set { {_imageInfo = value;} } }

        /// <summary>Internal Acessors for ImageInfoMarketPlaceInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMarketPlaceInfoProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal.ImageInfoMarketPlaceInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IImageInfoPropertiesInternal)ImageInfo).MarketPlaceInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IImageInfoPropertiesInternal)ImageInfo).MarketPlaceInfo = value; }

        /// <summary>Internal Acessors for Version</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal.Version { get => this._version; set { {_version = value;} } }

        /// <summary>Backing field for <see cref="VMCustomConfigurationUri" /> property.</summary>
        private string _vMCustomConfigurationUri;

        /// <summary>
        /// The uri to the storage blob containing scripts to be run on the virtual machine after provisioning.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string VMCustomConfigurationUri { get => this._vMCustomConfigurationUri; set => this._vMCustomConfigurationUri = value; }

        /// <summary>Backing field for <see cref="VMSizeId" /> property.</summary>
        private string _vMSizeId;

        /// <summary>The id of the size of a virtual machine connected to a hostpool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string VMSizeId { get => this._vMSizeId; set => this._vMSizeId = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private global::System.DateTime? _version;

        /// <summary>
        /// The time when session host configuration was last modified and something was changed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public global::System.DateTime? Version { get => this._version; }

        /// <summary>Creates an new <see cref="SessionHostConfigurationProperties" /> instance.</summary>
        public SessionHostConfigurationProperties()
        {

        }
    }
    /// Session host configurations of HostPool.
    public partial interface ISessionHostConfigurationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IJsonSerializable
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
    /// Session host configurations of HostPool.
    internal partial interface ISessionHostConfigurationPropertiesInternal

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