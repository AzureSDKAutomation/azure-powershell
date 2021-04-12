namespace Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Extensions;

    /// <summary>
    /// Contains information about the delivery package being shipped by the customer to the Microsoft data center.
    /// </summary>
    public partial class DeliveryPackageInformation :
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformation,
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformationInternal
    {

        /// <summary>Backing field for <see cref="CarrierName" /> property.</summary>
        private string _carrierName;

        /// <summary>The name of the carrier that is used to ship the import or export drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Owned)]
        public string CarrierName { get => this._carrierName; set => this._carrierName = value; }

        /// <summary>Backing field for <see cref="DriveCount" /> property.</summary>
        private long? _driveCount;

        /// <summary>The number of drives included in the package.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Owned)]
        public long? DriveCount { get => this._driveCount; set => this._driveCount = value; }

        /// <summary>Backing field for <see cref="ShipDate" /> property.</summary>
        private string _shipDate;

        /// <summary>The date when the package is shipped.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Owned)]
        public string ShipDate { get => this._shipDate; set => this._shipDate = value; }

        /// <summary>Backing field for <see cref="TrackingNumber" /> property.</summary>
        private string _trackingNumber;

        /// <summary>The tracking number of the package.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Owned)]
        public string TrackingNumber { get => this._trackingNumber; set => this._trackingNumber = value; }

        /// <summary>Creates an new <see cref="DeliveryPackageInformation" /> instance.</summary>
        public DeliveryPackageInformation()
        {

        }
    }
    /// Contains information about the delivery package being shipped by the customer to the Microsoft data center.
    public partial interface IDeliveryPackageInformation :
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.IJsonSerializable
    {
        /// <summary>The name of the carrier that is used to ship the import or export drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the carrier that is used to ship the import or export drives.",
        SerializedName = @"carrierName",
        PossibleTypes = new [] { typeof(string) })]
        string CarrierName { get; set; }
        /// <summary>The number of drives included in the package.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of drives included in the package.",
        SerializedName = @"driveCount",
        PossibleTypes = new [] { typeof(long) })]
        long? DriveCount { get; set; }
        /// <summary>The date when the package is shipped.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The date when the package is shipped.",
        SerializedName = @"shipDate",
        PossibleTypes = new [] { typeof(string) })]
        string ShipDate { get; set; }
        /// <summary>The tracking number of the package.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The tracking number of the package.",
        SerializedName = @"trackingNumber",
        PossibleTypes = new [] { typeof(string) })]
        string TrackingNumber { get; set; }

    }
    /// Contains information about the delivery package being shipped by the customer to the Microsoft data center.
    internal partial interface IDeliveryPackageInformationInternal

    {
        /// <summary>The name of the carrier that is used to ship the import or export drives.</summary>
        string CarrierName { get; set; }
        /// <summary>The number of drives included in the package.</summary>
        long? DriveCount { get; set; }
        /// <summary>The date when the package is shipped.</summary>
        string ShipDate { get; set; }
        /// <summary>The tracking number of the package.</summary>
        string TrackingNumber { get; set; }

    }
}