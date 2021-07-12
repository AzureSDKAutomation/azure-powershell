namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    /// <summary>Image configurations of session host in a HostPool.</summary>
    public partial class ImageInfoProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IImageInfoProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IImageInfoPropertiesInternal
    {

        /// <summary>Backing field for <see cref="CustomId" /> property.</summary>
        private string _customId;

        /// <summary>
        /// The resource id of the custom image or shared image. Image type must be CustomImage.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string CustomId { get => this._customId; set => this._customId = value; }

        /// <summary>Backing field for <see cref="MarketPlaceInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMarketPlaceInfoProperties _marketPlaceInfo;

        /// <summary>The values to uniquely identify a gallery image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMarketPlaceInfoProperties MarketPlaceInfo { get => (this._marketPlaceInfo = this._marketPlaceInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.MarketPlaceInfoProperties()); set => this._marketPlaceInfo = value; }

        /// <summary>The exact version of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string MarketPlaceInfoExactVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMarketPlaceInfoPropertiesInternal)MarketPlaceInfo).ExactVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMarketPlaceInfoPropertiesInternal)MarketPlaceInfo).ExactVersion = value ?? null; }

        /// <summary>The offer of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string MarketPlaceInfoOffer { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMarketPlaceInfoPropertiesInternal)MarketPlaceInfo).Offer; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMarketPlaceInfoPropertiesInternal)MarketPlaceInfo).Offer = value ?? null; }

        /// <summary>The publisher of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string MarketPlaceInfoPublisher { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMarketPlaceInfoPropertiesInternal)MarketPlaceInfo).Publisher; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMarketPlaceInfoPropertiesInternal)MarketPlaceInfo).Publisher = value ?? null; }

        /// <summary>The sku of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string MarketPlaceInfoSku { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMarketPlaceInfoPropertiesInternal)MarketPlaceInfo).Sku; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMarketPlaceInfoPropertiesInternal)MarketPlaceInfo).Sku = value ?? null; }

        /// <summary>Internal Acessors for MarketPlaceInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMarketPlaceInfoProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IImageInfoPropertiesInternal.MarketPlaceInfo { get => (this._marketPlaceInfo = this._marketPlaceInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.MarketPlaceInfoProperties()); set { {_marketPlaceInfo = value;} } }

        /// <summary>Backing field for <see cref="StorageBlobUri" /> property.</summary>
        private string _storageBlobUri;

        /// <summary>
        /// The uri to the storage blob which contains the VHD. Image type must be StorageBlob.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string StorageBlobUri { get => this._storageBlobUri; set => this._storageBlobUri = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ImageType? _type;

        /// <summary>The type of image session hosts use in the hostpool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ImageType? Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="ImageInfoProperties" /> instance.</summary>
        public ImageInfoProperties()
        {

        }
    }
    /// Image configurations of session host in a HostPool.
    public partial interface IImageInfoProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The resource id of the custom image or shared image. Image type must be CustomImage.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource id of the custom image or shared image. Image type must be CustomImage.",
        SerializedName = @"customId",
        PossibleTypes = new [] { typeof(string) })]
        string CustomId { get; set; }
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
        /// The uri to the storage blob which contains the VHD. Image type must be StorageBlob.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The uri to the storage blob which contains the VHD. Image type must be StorageBlob.",
        SerializedName = @"storageBlobUri",
        PossibleTypes = new [] { typeof(string) })]
        string StorageBlobUri { get; set; }
        /// <summary>The type of image session hosts use in the hostpool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of image session hosts use in the hostpool.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ImageType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ImageType? Type { get; set; }

    }
    /// Image configurations of session host in a HostPool.
    internal partial interface IImageInfoPropertiesInternal

    {
        /// <summary>
        /// The resource id of the custom image or shared image. Image type must be CustomImage.
        /// </summary>
        string CustomId { get; set; }
        /// <summary>The values to uniquely identify a gallery image.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMarketPlaceInfoProperties MarketPlaceInfo { get; set; }
        /// <summary>The exact version of the image.</summary>
        string MarketPlaceInfoExactVersion { get; set; }
        /// <summary>The offer of the image.</summary>
        string MarketPlaceInfoOffer { get; set; }
        /// <summary>The publisher of the image.</summary>
        string MarketPlaceInfoPublisher { get; set; }
        /// <summary>The sku of the image.</summary>
        string MarketPlaceInfoSku { get; set; }
        /// <summary>
        /// The uri to the storage blob which contains the VHD. Image type must be StorageBlob.
        /// </summary>
        string StorageBlobUri { get; set; }
        /// <summary>The type of image session hosts use in the hostpool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ImageType? Type { get; set; }

    }
}