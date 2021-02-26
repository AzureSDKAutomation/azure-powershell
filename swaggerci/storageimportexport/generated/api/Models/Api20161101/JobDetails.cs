namespace Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Extensions;

    /// <summary>Specifies the job properties</summary>
    public partial class JobDetails :
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IJobDetails,
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IJobDetailsInternal
    {

        /// <summary>Backing field for <see cref="BackupDriveManifest" /> property.</summary>
        private bool? _backupDriveManifest;

        /// <summary>
        /// Default value is false. Indicates whether the manifest files on the drives should be copied to block blobs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Owned)]
        public bool? BackupDriveManifest { get => this._backupDriveManifest; set => this._backupDriveManifest = value; }

        /// <summary>A collection of blob-prefix strings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string[] BlobListBlobPathPrefix { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IExportInternal)Export).BlobListBlobPathPrefix; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IExportInternal)Export).BlobListBlobPathPrefix = value ?? null /* arrayOf */; }

        /// <summary>A collection of blob-path strings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string[] BlobPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IExportInternal)Export).BlobPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IExportInternal)Export).BlobPath = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="CancelRequested" /> property.</summary>
        private bool? _cancelRequested;

        /// <summary>Indicates whether a request has been submitted to cancel the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Owned)]
        public bool? CancelRequested { get => this._cancelRequested; set => this._cancelRequested = value; }

        /// <summary>Backing field for <see cref="DeliveryPackage" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformation _deliveryPackage;

        /// <summary>
        /// Contains information about the package being shipped by the customer to the Microsoft data center.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformation DeliveryPackage { get => (this._deliveryPackage = this._deliveryPackage ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.DeliveryPackageInformation()); set => this._deliveryPackage = value; }

        /// <summary>The name of the carrier that is used to ship the import or export drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string DeliveryPackageCarrierName { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformationInternal)DeliveryPackage).CarrierName; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformationInternal)DeliveryPackage).CarrierName = value ?? null; }

        /// <summary>The number of drives included in the package.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public long? DeliveryPackageDriveCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformationInternal)DeliveryPackage).DriveCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformationInternal)DeliveryPackage).DriveCount = value ?? default(long); }

        /// <summary>The date when the package is shipped.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string DeliveryPackageShipDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformationInternal)DeliveryPackage).ShipDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformationInternal)DeliveryPackage).ShipDate = value ?? null; }

        /// <summary>The tracking number of the package.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string DeliveryPackageTrackingNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformationInternal)DeliveryPackage).TrackingNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformationInternal)DeliveryPackage).TrackingNumber = value ?? null; }

        /// <summary>Backing field for <see cref="DiagnosticsPath" /> property.</summary>
        private string _diagnosticsPath;

        /// <summary>
        /// The virtual blob directory to which the copy logs and backups of drive manifest files (if enabled) will be stored.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Owned)]
        public string DiagnosticsPath { get => this._diagnosticsPath; set => this._diagnosticsPath = value; }

        /// <summary>Backing field for <see cref="DriveList" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDriveStatus[] _driveList;

        /// <summary>
        /// List of up to ten drives that comprise the job. The drive list is a required element for an import job; it is not specified
        /// for export jobs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDriveStatus[] DriveList { get => this._driveList; set => this._driveList = value; }

        /// <summary>Backing field for <see cref="EncryptionKey" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IEncryptionKeyDetails _encryptionKey;

        /// <summary>Contains information about the encryption key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IEncryptionKeyDetails EncryptionKey { get => (this._encryptionKey = this._encryptionKey ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.EncryptionKeyDetails()); set => this._encryptionKey = value; }

        /// <summary>The type of kek encryption key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Support.EncryptionKekType? EncryptionKeyKekType { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IEncryptionKeyDetailsInternal)EncryptionKey).KekType; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IEncryptionKeyDetailsInternal)EncryptionKey).KekType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Support.EncryptionKekType)""); }

        /// <summary>Specifies the url for kek encryption key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string EncryptionKeyKekUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IEncryptionKeyDetailsInternal)EncryptionKey).KekUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IEncryptionKeyDetailsInternal)EncryptionKey).KekUrl = value ?? null; }

        /// <summary>Specifies the keyvault resource id for kek encryption key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string EncryptionKeyKekVaultResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IEncryptionKeyDetailsInternal)EncryptionKey).KekVaultResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IEncryptionKeyDetailsInternal)EncryptionKey).KekVaultResourceId = value ?? null; }

        /// <summary>Backing field for <see cref="Export" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IExport _export;

        /// <summary>
        /// A property containing information about the blobs to be exported for an export job. This property is included for export
        /// jobs only.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IExport Export { get => (this._export = this._export ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.Export()); set => this._export = value; }

        /// <summary>
        /// The relative URI to the block blob that contains the list of blob paths or blob path prefixes as defined above, beginning
        /// with the container name. If the blob is in root container, the URI must begin with $root.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ExportBlobListBlobPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IExportInternal)Export).BlobListBlobPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IExportInternal)Export).BlobListBlobPath = value ?? null; }

        /// <summary>Backing field for <see cref="IncompleteBlobListUri" /> property.</summary>
        private string _incompleteBlobListUri;

        /// <summary>
        /// A blob path that points to a block blob containing a list of blob names that were not exported due to insufficient drive
        /// space. If all blobs were exported successfully, then this element is not included in the response.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Owned)]
        public string IncompleteBlobListUri { get => this._incompleteBlobListUri; set => this._incompleteBlobListUri = value; }

        /// <summary>Backing field for <see cref="JobType" /> property.</summary>
        private string _jobType;

        /// <summary>The type of job</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Owned)]
        public string JobType { get => this._jobType; set => this._jobType = value; }

        /// <summary>Backing field for <see cref="LogLevel" /> property.</summary>
        private string _logLevel;

        /// <summary>
        /// Default value is Error. Indicates whether error logging or verbose logging will be enabled.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Owned)]
        public string LogLevel { get => this._logLevel; set => this._logLevel = value; }

        /// <summary>Internal Acessors for DeliveryPackage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformation Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IJobDetailsInternal.DeliveryPackage { get => (this._deliveryPackage = this._deliveryPackage ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.DeliveryPackageInformation()); set { {_deliveryPackage = value;} } }

        /// <summary>Internal Acessors for EncryptionKey</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IEncryptionKeyDetails Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IJobDetailsInternal.EncryptionKey { get => (this._encryptionKey = this._encryptionKey ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.EncryptionKeyDetails()); set { {_encryptionKey = value;} } }

        /// <summary>Internal Acessors for Export</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IExport Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IJobDetailsInternal.Export { get => (this._export = this._export ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.Export()); set { {_export = value;} } }

        /// <summary>Internal Acessors for ExportBlobList</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IExportBlobList Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IJobDetailsInternal.ExportBlobList { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IExportInternal)Export).BlobList; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IExportInternal)Export).BlobList = value; }

        /// <summary>Internal Acessors for ReturnAddress</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IReturnAddress Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IJobDetailsInternal.ReturnAddress { get => (this._returnAddress = this._returnAddress ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.ReturnAddress()); set { {_returnAddress = value;} } }

        /// <summary>Internal Acessors for ReturnPackage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IPackageInfomation Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IJobDetailsInternal.ReturnPackage { get => (this._returnPackage = this._returnPackage ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.PackageInfomation()); set { {_returnPackage = value;} } }

        /// <summary>Internal Acessors for ReturnShipping</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IReturnShipping Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IJobDetailsInternal.ReturnShipping { get => (this._returnShipping = this._returnShipping ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.ReturnShipping()); set { {_returnShipping = value;} } }

        /// <summary>Internal Acessors for ShippingInformation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IShippingInformation Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IJobDetailsInternal.ShippingInformation { get => (this._shippingInformation = this._shippingInformation ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.ShippingInformation()); set { {_shippingInformation = value;} } }

        /// <summary>Internal Acessors for ShippingInformationAdditionalInformation</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IJobDetailsInternal.ShippingInformationAdditionalInformation { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IShippingInformationInternal)ShippingInformation).AdditionalInformation; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IShippingInformationInternal)ShippingInformation).AdditionalInformation = value; }

        /// <summary>Backing field for <see cref="PercentComplete" /> property.</summary>
        private int? _percentComplete;

        /// <summary>Overall percentage completed for the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Owned)]
        public int? PercentComplete { get => this._percentComplete; set => this._percentComplete = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Specifies the provisioning state of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; set => this._provisioningState = value; }

        /// <summary>Backing field for <see cref="ReturnAddress" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IReturnAddress _returnAddress;

        /// <summary>Specifies the return address information for the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IReturnAddress ReturnAddress { get => (this._returnAddress = this._returnAddress ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.ReturnAddress()); set => this._returnAddress = value; }

        /// <summary>The city name to use when returning the drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ReturnAddressCity { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IReturnAddressInternal)ReturnAddress).City; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IReturnAddressInternal)ReturnAddress).City = value ?? null; }

        /// <summary>The country or region to use when returning the drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ReturnAddressCountryOrRegion { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IReturnAddressInternal)ReturnAddress).CountryOrRegion; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IReturnAddressInternal)ReturnAddress).CountryOrRegion = value ?? null; }

        /// <summary>Email address of the recipient of the returned drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ReturnAddressEmail { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IReturnAddressInternal)ReturnAddress).Email; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IReturnAddressInternal)ReturnAddress).Email = value ?? null; }

        /// <summary>Phone number of the recipient of the returned drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ReturnAddressPhone { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IReturnAddressInternal)ReturnAddress).Phone; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IReturnAddressInternal)ReturnAddress).Phone = value ?? null; }

        /// <summary>The postal code to use when returning the drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ReturnAddressPostalCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IReturnAddressInternal)ReturnAddress).PostalCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IReturnAddressInternal)ReturnAddress).PostalCode = value ?? null; }

        /// <summary>
        /// The name of the recipient who will receive the hard drives when they are returned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ReturnAddressRecipientName { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IReturnAddressInternal)ReturnAddress).RecipientName; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IReturnAddressInternal)ReturnAddress).RecipientName = value ?? null; }

        /// <summary>The state or province to use when returning the drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ReturnAddressStateOrProvince { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IReturnAddressInternal)ReturnAddress).StateOrProvince; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IReturnAddressInternal)ReturnAddress).StateOrProvince = value ?? null; }

        /// <summary>The first line of the street address to use when returning the drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ReturnAddressStreetAddress1 { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IReturnAddressInternal)ReturnAddress).StreetAddress1; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IReturnAddressInternal)ReturnAddress).StreetAddress1 = value ?? null; }

        /// <summary>The second line of the street address to use when returning the drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ReturnAddressStreetAddress2 { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IReturnAddressInternal)ReturnAddress).StreetAddress2; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IReturnAddressInternal)ReturnAddress).StreetAddress2 = value ?? null; }

        /// <summary>Backing field for <see cref="ReturnPackage" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IPackageInfomation _returnPackage;

        /// <summary>
        /// Contains information about the package being shipped from the Microsoft data center to the customer to return the drives.
        /// The format is the same as the deliveryPackage property above. This property is not included if the drives have not yet
        /// been returned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IPackageInfomation ReturnPackage { get => (this._returnPackage = this._returnPackage ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.PackageInfomation()); set => this._returnPackage = value; }

        /// <summary>The name of the carrier that is used to ship the import or export drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ReturnPackageCarrierName { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IPackageInfomationInternal)ReturnPackage).CarrierName; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IPackageInfomationInternal)ReturnPackage).CarrierName = value ?? null; }

        /// <summary>The number of drives included in the package.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public int? ReturnPackageDriveCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IPackageInfomationInternal)ReturnPackage).DriveCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IPackageInfomationInternal)ReturnPackage).DriveCount = value ?? default(int); }

        /// <summary>The date when the package is shipped.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ReturnPackageShipDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IPackageInfomationInternal)ReturnPackage).ShipDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IPackageInfomationInternal)ReturnPackage).ShipDate = value ?? null; }

        /// <summary>The tracking number of the package.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ReturnPackageTrackingNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IPackageInfomationInternal)ReturnPackage).TrackingNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IPackageInfomationInternal)ReturnPackage).TrackingNumber = value ?? null; }

        /// <summary>Backing field for <see cref="ReturnShipping" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IReturnShipping _returnShipping;

        /// <summary>Specifies the return carrier and customer's account with the carrier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IReturnShipping ReturnShipping { get => (this._returnShipping = this._returnShipping ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.ReturnShipping()); set => this._returnShipping = value; }

        /// <summary>The customer's account number with the carrier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ReturnShippingCarrierAccountNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IReturnShippingInternal)ReturnShipping).CarrierAccountNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IReturnShippingInternal)ReturnShipping).CarrierAccountNumber = value ?? null; }

        /// <summary>The carrier's name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ReturnShippingCarrierName { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IReturnShippingInternal)ReturnShipping).CarrierName; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IReturnShippingInternal)ReturnShipping).CarrierName = value ?? null; }

        /// <summary>Backing field for <see cref="ShippingInformation" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IShippingInformation _shippingInformation;

        /// <summary>
        /// Contains information about the Microsoft datacenter to which the drives should be shipped.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IShippingInformation ShippingInformation { get => (this._shippingInformation = this._shippingInformation ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.ShippingInformation()); set => this._shippingInformation = value; }

        /// <summary>
        /// Additional shipping information for customer, specific to datacenter to which customer should send their disks.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ShippingInformationAdditionalInformation { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IShippingInformationInternal)ShippingInformation).AdditionalInformation; }

        /// <summary>The city name to use when returning the drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ShippingInformationCity { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IShippingInformationInternal)ShippingInformation).City; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IShippingInformationInternal)ShippingInformation).City = value ?? null; }

        /// <summary>The country or region to use when returning the drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ShippingInformationCountryOrRegion { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IShippingInformationInternal)ShippingInformation).CountryOrRegion; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IShippingInformationInternal)ShippingInformation).CountryOrRegion = value ?? null; }

        /// <summary>Phone number of the recipient of the returned drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ShippingInformationPhone { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IShippingInformationInternal)ShippingInformation).Phone; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IShippingInformationInternal)ShippingInformation).Phone = value ?? null; }

        /// <summary>The postal code to use when returning the drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ShippingInformationPostalCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IShippingInformationInternal)ShippingInformation).PostalCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IShippingInformationInternal)ShippingInformation).PostalCode = value ?? null; }

        /// <summary>
        /// The name of the recipient who will receive the hard drives when they are returned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ShippingInformationRecipientName { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IShippingInformationInternal)ShippingInformation).RecipientName; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IShippingInformationInternal)ShippingInformation).RecipientName = value ?? null; }

        /// <summary>The state or province to use when returning the drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ShippingInformationStateOrProvince { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IShippingInformationInternal)ShippingInformation).StateOrProvince; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IShippingInformationInternal)ShippingInformation).StateOrProvince = value ?? null; }

        /// <summary>The first line of the street address to use when returning the drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ShippingInformationStreetAddress1 { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IShippingInformationInternal)ShippingInformation).StreetAddress1; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IShippingInformationInternal)ShippingInformation).StreetAddress1 = value ?? null; }

        /// <summary>The second line of the street address to use when returning the drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ShippingInformationStreetAddress2 { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IShippingInformationInternal)ShippingInformation).StreetAddress2; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IShippingInformationInternal)ShippingInformation).StreetAddress2 = value ?? null; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        /// <summary>Current state of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Owned)]
        public string State { get => this._state; set => this._state = value; }

        /// <summary>Backing field for <see cref="StorageAccountId" /> property.</summary>
        private string _storageAccountId;

        /// <summary>
        /// The resource identifier of the storage account where data will be imported to or exported from.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Owned)]
        public string StorageAccountId { get => this._storageAccountId; set => this._storageAccountId = value; }

        /// <summary>Creates an new <see cref="JobDetails" /> instance.</summary>
        public JobDetails()
        {

        }
    }
    /// Specifies the job properties
    public partial interface IJobDetails :
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Default value is false. Indicates whether the manifest files on the drives should be copied to block blobs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Default value is false. Indicates whether the manifest files on the drives should be copied to block blobs.",
        SerializedName = @"backupDriveManifest",
        PossibleTypes = new [] { typeof(bool) })]
        bool? BackupDriveManifest { get; set; }
        /// <summary>A collection of blob-prefix strings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A collection of blob-prefix strings.",
        SerializedName = @"blobPathPrefix",
        PossibleTypes = new [] { typeof(string) })]
        string[] BlobListBlobPathPrefix { get; set; }
        /// <summary>A collection of blob-path strings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A collection of blob-path strings.",
        SerializedName = @"blobPath",
        PossibleTypes = new [] { typeof(string) })]
        string[] BlobPath { get; set; }
        /// <summary>Indicates whether a request has been submitted to cancel the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether a request has been submitted to cancel the job.",
        SerializedName = @"cancelRequested",
        PossibleTypes = new [] { typeof(bool) })]
        bool? CancelRequested { get; set; }
        /// <summary>The name of the carrier that is used to ship the import or export drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the carrier that is used to ship the import or export drives.",
        SerializedName = @"carrierName",
        PossibleTypes = new [] { typeof(string) })]
        string DeliveryPackageCarrierName { get; set; }
        /// <summary>The number of drives included in the package.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of drives included in the package.",
        SerializedName = @"driveCount",
        PossibleTypes = new [] { typeof(long) })]
        long? DeliveryPackageDriveCount { get; set; }
        /// <summary>The date when the package is shipped.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The date when the package is shipped.",
        SerializedName = @"shipDate",
        PossibleTypes = new [] { typeof(string) })]
        string DeliveryPackageShipDate { get; set; }
        /// <summary>The tracking number of the package.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tracking number of the package.",
        SerializedName = @"trackingNumber",
        PossibleTypes = new [] { typeof(string) })]
        string DeliveryPackageTrackingNumber { get; set; }
        /// <summary>
        /// The virtual blob directory to which the copy logs and backups of drive manifest files (if enabled) will be stored.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The virtual blob directory to which the copy logs and backups of drive manifest files (if enabled) will be stored.",
        SerializedName = @"diagnosticsPath",
        PossibleTypes = new [] { typeof(string) })]
        string DiagnosticsPath { get; set; }
        /// <summary>
        /// List of up to ten drives that comprise the job. The drive list is a required element for an import job; it is not specified
        /// for export jobs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of up to ten drives that comprise the job. The drive list is a required element for an import job; it is not specified for export jobs.",
        SerializedName = @"driveList",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDriveStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDriveStatus[] DriveList { get; set; }
        /// <summary>The type of kek encryption key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of kek encryption key",
        SerializedName = @"kekType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Support.EncryptionKekType) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Support.EncryptionKekType? EncryptionKeyKekType { get; set; }
        /// <summary>Specifies the url for kek encryption key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the url for kek encryption key. ",
        SerializedName = @"kekUrl",
        PossibleTypes = new [] { typeof(string) })]
        string EncryptionKeyKekUrl { get; set; }
        /// <summary>Specifies the keyvault resource id for kek encryption key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the keyvault resource id for kek encryption key. ",
        SerializedName = @"kekVaultResourceID",
        PossibleTypes = new [] { typeof(string) })]
        string EncryptionKeyKekVaultResourceId { get; set; }
        /// <summary>
        /// The relative URI to the block blob that contains the list of blob paths or blob path prefixes as defined above, beginning
        /// with the container name. If the blob is in root container, the URI must begin with $root.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The relative URI to the block blob that contains the list of blob paths or blob path prefixes as defined above, beginning with the container name. If the blob is in root container, the URI must begin with $root. ",
        SerializedName = @"blobListBlobPath",
        PossibleTypes = new [] { typeof(string) })]
        string ExportBlobListBlobPath { get; set; }
        /// <summary>
        /// A blob path that points to a block blob containing a list of blob names that were not exported due to insufficient drive
        /// space. If all blobs were exported successfully, then this element is not included in the response.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A blob path that points to a block blob containing a list of blob names that were not exported due to insufficient drive space. If all blobs were exported successfully, then this element is not included in the response.",
        SerializedName = @"incompleteBlobListUri",
        PossibleTypes = new [] { typeof(string) })]
        string IncompleteBlobListUri { get; set; }
        /// <summary>The type of job</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of job",
        SerializedName = @"jobType",
        PossibleTypes = new [] { typeof(string) })]
        string JobType { get; set; }
        /// <summary>
        /// Default value is Error. Indicates whether error logging or verbose logging will be enabled.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Default value is Error. Indicates whether error logging or verbose logging will be enabled.",
        SerializedName = @"logLevel",
        PossibleTypes = new [] { typeof(string) })]
        string LogLevel { get; set; }
        /// <summary>Overall percentage completed for the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Overall percentage completed for the job.",
        SerializedName = @"percentComplete",
        PossibleTypes = new [] { typeof(int) })]
        int? PercentComplete { get; set; }
        /// <summary>Specifies the provisioning state of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the provisioning state of the job.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get; set; }
        /// <summary>The city name to use when returning the drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The city name to use when returning the drives.",
        SerializedName = @"city",
        PossibleTypes = new [] { typeof(string) })]
        string ReturnAddressCity { get; set; }
        /// <summary>The country or region to use when returning the drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The country or region to use when returning the drives. ",
        SerializedName = @"countryOrRegion",
        PossibleTypes = new [] { typeof(string) })]
        string ReturnAddressCountryOrRegion { get; set; }
        /// <summary>Email address of the recipient of the returned drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Email address of the recipient of the returned drives.",
        SerializedName = @"email",
        PossibleTypes = new [] { typeof(string) })]
        string ReturnAddressEmail { get; set; }
        /// <summary>Phone number of the recipient of the returned drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Phone number of the recipient of the returned drives.",
        SerializedName = @"phone",
        PossibleTypes = new [] { typeof(string) })]
        string ReturnAddressPhone { get; set; }
        /// <summary>The postal code to use when returning the drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The postal code to use when returning the drives.",
        SerializedName = @"postalCode",
        PossibleTypes = new [] { typeof(string) })]
        string ReturnAddressPostalCode { get; set; }
        /// <summary>
        /// The name of the recipient who will receive the hard drives when they are returned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the recipient who will receive the hard drives when they are returned. ",
        SerializedName = @"recipientName",
        PossibleTypes = new [] { typeof(string) })]
        string ReturnAddressRecipientName { get; set; }
        /// <summary>The state or province to use when returning the drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The state or province to use when returning the drives.",
        SerializedName = @"stateOrProvince",
        PossibleTypes = new [] { typeof(string) })]
        string ReturnAddressStateOrProvince { get; set; }
        /// <summary>The first line of the street address to use when returning the drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The first line of the street address to use when returning the drives. ",
        SerializedName = @"streetAddress1",
        PossibleTypes = new [] { typeof(string) })]
        string ReturnAddressStreetAddress1 { get; set; }
        /// <summary>The second line of the street address to use when returning the drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The second line of the street address to use when returning the drives. ",
        SerializedName = @"streetAddress2",
        PossibleTypes = new [] { typeof(string) })]
        string ReturnAddressStreetAddress2 { get; set; }
        /// <summary>The name of the carrier that is used to ship the import or export drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the carrier that is used to ship the import or export drives.",
        SerializedName = @"carrierName",
        PossibleTypes = new [] { typeof(string) })]
        string ReturnPackageCarrierName { get; set; }
        /// <summary>The number of drives included in the package.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of drives included in the package.",
        SerializedName = @"driveCount",
        PossibleTypes = new [] { typeof(int) })]
        int? ReturnPackageDriveCount { get; set; }
        /// <summary>The date when the package is shipped.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The date when the package is shipped.",
        SerializedName = @"shipDate",
        PossibleTypes = new [] { typeof(string) })]
        string ReturnPackageShipDate { get; set; }
        /// <summary>The tracking number of the package.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tracking number of the package.",
        SerializedName = @"trackingNumber",
        PossibleTypes = new [] { typeof(string) })]
        string ReturnPackageTrackingNumber { get; set; }
        /// <summary>The customer's account number with the carrier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The customer's account number with the carrier.",
        SerializedName = @"carrierAccountNumber",
        PossibleTypes = new [] { typeof(string) })]
        string ReturnShippingCarrierAccountNumber { get; set; }
        /// <summary>The carrier's name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The carrier's name.",
        SerializedName = @"carrierName",
        PossibleTypes = new [] { typeof(string) })]
        string ReturnShippingCarrierName { get; set; }
        /// <summary>
        /// Additional shipping information for customer, specific to datacenter to which customer should send their disks.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Additional shipping information for customer, specific to datacenter to which customer should send their disks.",
        SerializedName = @"additionalInformation",
        PossibleTypes = new [] { typeof(string) })]
        string ShippingInformationAdditionalInformation { get;  }
        /// <summary>The city name to use when returning the drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The city name to use when returning the drives.",
        SerializedName = @"city",
        PossibleTypes = new [] { typeof(string) })]
        string ShippingInformationCity { get; set; }
        /// <summary>The country or region to use when returning the drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The country or region to use when returning the drives. ",
        SerializedName = @"countryOrRegion",
        PossibleTypes = new [] { typeof(string) })]
        string ShippingInformationCountryOrRegion { get; set; }
        /// <summary>Phone number of the recipient of the returned drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Phone number of the recipient of the returned drives.",
        SerializedName = @"phone",
        PossibleTypes = new [] { typeof(string) })]
        string ShippingInformationPhone { get; set; }
        /// <summary>The postal code to use when returning the drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The postal code to use when returning the drives.",
        SerializedName = @"postalCode",
        PossibleTypes = new [] { typeof(string) })]
        string ShippingInformationPostalCode { get; set; }
        /// <summary>
        /// The name of the recipient who will receive the hard drives when they are returned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the recipient who will receive the hard drives when they are returned. ",
        SerializedName = @"recipientName",
        PossibleTypes = new [] { typeof(string) })]
        string ShippingInformationRecipientName { get; set; }
        /// <summary>The state or province to use when returning the drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The state or province to use when returning the drives.",
        SerializedName = @"stateOrProvince",
        PossibleTypes = new [] { typeof(string) })]
        string ShippingInformationStateOrProvince { get; set; }
        /// <summary>The first line of the street address to use when returning the drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The first line of the street address to use when returning the drives. ",
        SerializedName = @"streetAddress1",
        PossibleTypes = new [] { typeof(string) })]
        string ShippingInformationStreetAddress1 { get; set; }
        /// <summary>The second line of the street address to use when returning the drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The second line of the street address to use when returning the drives. ",
        SerializedName = @"streetAddress2",
        PossibleTypes = new [] { typeof(string) })]
        string ShippingInformationStreetAddress2 { get; set; }
        /// <summary>Current state of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Current state of the job.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        string State { get; set; }
        /// <summary>
        /// The resource identifier of the storage account where data will be imported to or exported from.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource identifier of the storage account where data will be imported to or exported from.",
        SerializedName = @"storageAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string StorageAccountId { get; set; }

    }
    /// Specifies the job properties
    internal partial interface IJobDetailsInternal

    {
        /// <summary>
        /// Default value is false. Indicates whether the manifest files on the drives should be copied to block blobs.
        /// </summary>
        bool? BackupDriveManifest { get; set; }
        /// <summary>A collection of blob-prefix strings.</summary>
        string[] BlobListBlobPathPrefix { get; set; }
        /// <summary>A collection of blob-path strings.</summary>
        string[] BlobPath { get; set; }
        /// <summary>Indicates whether a request has been submitted to cancel the job.</summary>
        bool? CancelRequested { get; set; }
        /// <summary>
        /// Contains information about the package being shipped by the customer to the Microsoft data center.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformation DeliveryPackage { get; set; }
        /// <summary>The name of the carrier that is used to ship the import or export drives.</summary>
        string DeliveryPackageCarrierName { get; set; }
        /// <summary>The number of drives included in the package.</summary>
        long? DeliveryPackageDriveCount { get; set; }
        /// <summary>The date when the package is shipped.</summary>
        string DeliveryPackageShipDate { get; set; }
        /// <summary>The tracking number of the package.</summary>
        string DeliveryPackageTrackingNumber { get; set; }
        /// <summary>
        /// The virtual blob directory to which the copy logs and backups of drive manifest files (if enabled) will be stored.
        /// </summary>
        string DiagnosticsPath { get; set; }
        /// <summary>
        /// List of up to ten drives that comprise the job. The drive list is a required element for an import job; it is not specified
        /// for export jobs.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDriveStatus[] DriveList { get; set; }
        /// <summary>Contains information about the encryption key.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IEncryptionKeyDetails EncryptionKey { get; set; }
        /// <summary>The type of kek encryption key</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Support.EncryptionKekType? EncryptionKeyKekType { get; set; }
        /// <summary>Specifies the url for kek encryption key.</summary>
        string EncryptionKeyKekUrl { get; set; }
        /// <summary>Specifies the keyvault resource id for kek encryption key.</summary>
        string EncryptionKeyKekVaultResourceId { get; set; }
        /// <summary>
        /// A property containing information about the blobs to be exported for an export job. This property is included for export
        /// jobs only.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IExport Export { get; set; }
        /// <summary>A list of the blobs to be exported.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IExportBlobList ExportBlobList { get; set; }
        /// <summary>
        /// The relative URI to the block blob that contains the list of blob paths or blob path prefixes as defined above, beginning
        /// with the container name. If the blob is in root container, the URI must begin with $root.
        /// </summary>
        string ExportBlobListBlobPath { get; set; }
        /// <summary>
        /// A blob path that points to a block blob containing a list of blob names that were not exported due to insufficient drive
        /// space. If all blobs were exported successfully, then this element is not included in the response.
        /// </summary>
        string IncompleteBlobListUri { get; set; }
        /// <summary>The type of job</summary>
        string JobType { get; set; }
        /// <summary>
        /// Default value is Error. Indicates whether error logging or verbose logging will be enabled.
        /// </summary>
        string LogLevel { get; set; }
        /// <summary>Overall percentage completed for the job.</summary>
        int? PercentComplete { get; set; }
        /// <summary>Specifies the provisioning state of the job.</summary>
        string ProvisioningState { get; set; }
        /// <summary>Specifies the return address information for the job.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IReturnAddress ReturnAddress { get; set; }
        /// <summary>The city name to use when returning the drives.</summary>
        string ReturnAddressCity { get; set; }
        /// <summary>The country or region to use when returning the drives.</summary>
        string ReturnAddressCountryOrRegion { get; set; }
        /// <summary>Email address of the recipient of the returned drives.</summary>
        string ReturnAddressEmail { get; set; }
        /// <summary>Phone number of the recipient of the returned drives.</summary>
        string ReturnAddressPhone { get; set; }
        /// <summary>The postal code to use when returning the drives.</summary>
        string ReturnAddressPostalCode { get; set; }
        /// <summary>
        /// The name of the recipient who will receive the hard drives when they are returned.
        /// </summary>
        string ReturnAddressRecipientName { get; set; }
        /// <summary>The state or province to use when returning the drives.</summary>
        string ReturnAddressStateOrProvince { get; set; }
        /// <summary>The first line of the street address to use when returning the drives.</summary>
        string ReturnAddressStreetAddress1 { get; set; }
        /// <summary>The second line of the street address to use when returning the drives.</summary>
        string ReturnAddressStreetAddress2 { get; set; }
        /// <summary>
        /// Contains information about the package being shipped from the Microsoft data center to the customer to return the drives.
        /// The format is the same as the deliveryPackage property above. This property is not included if the drives have not yet
        /// been returned.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IPackageInfomation ReturnPackage { get; set; }
        /// <summary>The name of the carrier that is used to ship the import or export drives.</summary>
        string ReturnPackageCarrierName { get; set; }
        /// <summary>The number of drives included in the package.</summary>
        int? ReturnPackageDriveCount { get; set; }
        /// <summary>The date when the package is shipped.</summary>
        string ReturnPackageShipDate { get; set; }
        /// <summary>The tracking number of the package.</summary>
        string ReturnPackageTrackingNumber { get; set; }
        /// <summary>Specifies the return carrier and customer's account with the carrier.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IReturnShipping ReturnShipping { get; set; }
        /// <summary>The customer's account number with the carrier.</summary>
        string ReturnShippingCarrierAccountNumber { get; set; }
        /// <summary>The carrier's name.</summary>
        string ReturnShippingCarrierName { get; set; }
        /// <summary>
        /// Contains information about the Microsoft datacenter to which the drives should be shipped.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IShippingInformation ShippingInformation { get; set; }
        /// <summary>
        /// Additional shipping information for customer, specific to datacenter to which customer should send their disks.
        /// </summary>
        string ShippingInformationAdditionalInformation { get; set; }
        /// <summary>The city name to use when returning the drives.</summary>
        string ShippingInformationCity { get; set; }
        /// <summary>The country or region to use when returning the drives.</summary>
        string ShippingInformationCountryOrRegion { get; set; }
        /// <summary>Phone number of the recipient of the returned drives.</summary>
        string ShippingInformationPhone { get; set; }
        /// <summary>The postal code to use when returning the drives.</summary>
        string ShippingInformationPostalCode { get; set; }
        /// <summary>
        /// The name of the recipient who will receive the hard drives when they are returned.
        /// </summary>
        string ShippingInformationRecipientName { get; set; }
        /// <summary>The state or province to use when returning the drives.</summary>
        string ShippingInformationStateOrProvince { get; set; }
        /// <summary>The first line of the street address to use when returning the drives.</summary>
        string ShippingInformationStreetAddress1 { get; set; }
        /// <summary>The second line of the street address to use when returning the drives.</summary>
        string ShippingInformationStreetAddress2 { get; set; }
        /// <summary>Current state of the job.</summary>
        string State { get; set; }
        /// <summary>
        /// The resource identifier of the storage account where data will be imported to or exported from.
        /// </summary>
        string StorageAccountId { get; set; }

    }
}