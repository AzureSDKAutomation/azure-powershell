namespace Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Extensions;

    /// <summary>Locations response</summary>
    public partial class LocationsResponse :
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.ILocationsResponse,
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.ILocationsResponseInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.ILocation[] _value;

        /// <summary>locations</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.ILocation[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="LocationsResponse" /> instance.</summary>
        public LocationsResponse()
        {

        }
    }
    /// Locations response
    public partial interface ILocationsResponse :
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.IJsonSerializable
    {
        /// <summary>locations</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"locations",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.ILocation) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.ILocation[] Value { get; set; }

    }
    /// Locations response
    internal partial interface ILocationsResponseInternal

    {
        /// <summary>locations</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.ILocation[] Value { get; set; }

    }
}