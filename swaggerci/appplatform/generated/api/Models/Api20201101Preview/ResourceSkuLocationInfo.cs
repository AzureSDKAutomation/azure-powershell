namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Locations and availability zones where the SKU is available</summary>
    public partial class ResourceSkuLocationInfo :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceSkuLocationInfo,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceSkuLocationInfoInternal
    {

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>Gets location of the SKU</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Backing field for <see cref="Zone" /> property.</summary>
        private string[] _zone;

        /// <summary>Gets list of availability zones where the SKU is supported.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string[] Zone { get => this._zone; set => this._zone = value; }

        /// <summary>Backing field for <see cref="ZoneDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceSkuZoneDetails[] _zoneDetail;

        /// <summary>Gets details of capabilities available to a SKU in specific zones.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceSkuZoneDetails[] ZoneDetail { get => this._zoneDetail; set => this._zoneDetail = value; }

        /// <summary>Creates an new <see cref="ResourceSkuLocationInfo" /> instance.</summary>
        public ResourceSkuLocationInfo()
        {

        }
    }
    /// Locations and availability zones where the SKU is available
    public partial interface IResourceSkuLocationInfo :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable
    {
        /// <summary>Gets location of the SKU</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets location of the SKU",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>Gets list of availability zones where the SKU is supported.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets list of availability zones where the SKU is supported.",
        SerializedName = @"zones",
        PossibleTypes = new [] { typeof(string) })]
        string[] Zone { get; set; }
        /// <summary>Gets details of capabilities available to a SKU in specific zones.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets details of capabilities available to a SKU in specific zones.",
        SerializedName = @"zoneDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceSkuZoneDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceSkuZoneDetails[] ZoneDetail { get; set; }

    }
    /// Locations and availability zones where the SKU is available
    internal partial interface IResourceSkuLocationInfoInternal

    {
        /// <summary>Gets location of the SKU</summary>
        string Location { get; set; }
        /// <summary>Gets list of availability zones where the SKU is supported.</summary>
        string[] Zone { get; set; }
        /// <summary>Gets details of capabilities available to a SKU in specific zones.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceSkuZoneDetails[] ZoneDetail { get; set; }

    }
}