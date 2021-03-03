namespace Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Extensions;

    /// <summary>Update Job parameters</summary>
    public partial class UpdateJobParameters :
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParameters,
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersInternal
    {

        /// <summary>
        /// Indicates whether the manifest files on the drives should be copied to block blobs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public bool? BackupDriveManifest { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).BackupDriveManifest; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).BackupDriveManifest = value ?? default(bool); }

        /// <summary>
        /// If specified, the value must be true. The service will attempt to cancel the job.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public bool? CancelRequested { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).CancelRequested; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).CancelRequested = value ?? default(bool); }

        /// <summary>The name of the carrier that is used to ship the import or export drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string DeliveryPackageCarrierName { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).DeliveryPackageCarrierName; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).DeliveryPackageCarrierName = value ?? null; }

        /// <summary>The number of drives included in the package.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public long? DeliveryPackageDriveCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).DeliveryPackageDriveCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).DeliveryPackageDriveCount = value ?? default(long); }

        /// <summary>The date when the package is shipped.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string DeliveryPackageShipDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).DeliveryPackageShipDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).DeliveryPackageShipDate = value ?? null; }

        /// <summary>The tracking number of the package.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string DeliveryPackageTrackingNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).DeliveryPackageTrackingNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).DeliveryPackageTrackingNumber = value ?? null; }

        /// <summary>List of drives that comprise the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDriveStatus[] DriveList { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).DriveList; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).DriveList = value ?? null /* arrayOf */; }

        /// <summary>Indicates whether error logging or verbose logging is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string LogLevel { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).LogLevel; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).LogLevel = value ?? null; }

        /// <summary>Internal Acessors for DeliveryPackage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformation Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersInternal.DeliveryPackage { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).DeliveryPackage; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).DeliveryPackage = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersProperties Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.UpdateJobParametersProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ReturnAddress</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IReturnAddress Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersInternal.ReturnAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).ReturnAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).ReturnAddress = value; }

        /// <summary>Internal Acessors for ReturnShipping</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IReturnShipping Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersInternal.ReturnShipping { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).ReturnShipping; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).ReturnShipping = value; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersProperties _property;

        /// <summary>Specifies the properties of a UpdateJob.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.UpdateJobParametersProperties()); set => this._property = value; }

        /// <summary>The city name to use when returning the drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ReturnAddressCity { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).ReturnAddressCity; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).ReturnAddressCity = value ?? null; }

        /// <summary>The country or region to use when returning the drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ReturnAddressCountryOrRegion { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).ReturnAddressCountryOrRegion; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).ReturnAddressCountryOrRegion = value ?? null; }

        /// <summary>Email address of the recipient of the returned drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ReturnAddressEmail { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).ReturnAddressEmail; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).ReturnAddressEmail = value ?? null; }

        /// <summary>Phone number of the recipient of the returned drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ReturnAddressPhone { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).ReturnAddressPhone; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).ReturnAddressPhone = value ?? null; }

        /// <summary>The postal code to use when returning the drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ReturnAddressPostalCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).ReturnAddressPostalCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).ReturnAddressPostalCode = value ?? null; }

        /// <summary>
        /// The name of the recipient who will receive the hard drives when they are returned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ReturnAddressRecipientName { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).ReturnAddressRecipientName; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).ReturnAddressRecipientName = value ?? null; }

        /// <summary>The state or province to use when returning the drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ReturnAddressStateOrProvince { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).ReturnAddressStateOrProvince; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).ReturnAddressStateOrProvince = value ?? null; }

        /// <summary>The first line of the street address to use when returning the drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ReturnAddressStreetAddress1 { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).ReturnAddressStreetAddress1; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).ReturnAddressStreetAddress1 = value ?? null; }

        /// <summary>The second line of the street address to use when returning the drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ReturnAddressStreetAddress2 { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).ReturnAddressStreetAddress2; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).ReturnAddressStreetAddress2 = value ?? null; }

        /// <summary>The customer's account number with the carrier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ReturnShippingCarrierAccountNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).ReturnShippingCarrierAccountNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).ReturnShippingCarrierAccountNumber = value ?? null; }

        /// <summary>The carrier's name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string ReturnShippingCarrierName { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).ReturnShippingCarrierName; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).ReturnShippingCarrierName = value ?? null; }

        /// <summary>
        /// If specified, the value must be Shipping, which tells the Import/Export service that the package for the job has been
        /// shipped. The ReturnAddress and DeliveryPackage properties must have been set either in this request or in a previous request,
        /// otherwise the request will fail.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Inlined)]
        public string State { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersPropertiesInternal)Property).State = value ?? null; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.IAny _tag;

        /// <summary>Specifies the tags that will be assigned to the job</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.IAny Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Any()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="UpdateJobParameters" /> instance.</summary>
        public UpdateJobParameters()
        {

        }
    }
    /// Update Job parameters
    public partial interface IUpdateJobParameters :
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Indicates whether the manifest files on the drives should be copied to block blobs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether the manifest files on the drives should be copied to block blobs.",
        SerializedName = @"backupDriveManifest",
        PossibleTypes = new [] { typeof(bool) })]
        bool? BackupDriveManifest { get; set; }
        /// <summary>
        /// If specified, the value must be true. The service will attempt to cancel the job.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"If specified, the value must be true. The service will attempt to cancel the job. ",
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
        /// <summary>List of drives that comprise the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of drives that comprise the job.",
        SerializedName = @"driveList",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDriveStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDriveStatus[] DriveList { get; set; }
        /// <summary>Indicates whether error logging or verbose logging is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether error logging or verbose logging is enabled.",
        SerializedName = @"logLevel",
        PossibleTypes = new [] { typeof(string) })]
        string LogLevel { get; set; }
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
        /// If specified, the value must be Shipping, which tells the Import/Export service that the package for the job has been
        /// shipped. The ReturnAddress and DeliveryPackage properties must have been set either in this request or in a previous request,
        /// otherwise the request will fail.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"If specified, the value must be Shipping, which tells the Import/Export service that the package for the job has been shipped. The ReturnAddress and DeliveryPackage properties must have been set either in this request or in a previous request, otherwise the request will fail. ",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        string State { get; set; }
        /// <summary>Specifies the tags that will be assigned to the job</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the tags that will be assigned to the job",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.IAny) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.IAny Tag { get; set; }

    }
    /// Update Job parameters
    internal partial interface IUpdateJobParametersInternal

    {
        /// <summary>
        /// Indicates whether the manifest files on the drives should be copied to block blobs.
        /// </summary>
        bool? BackupDriveManifest { get; set; }
        /// <summary>
        /// If specified, the value must be true. The service will attempt to cancel the job.
        /// </summary>
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
        /// <summary>List of drives that comprise the job.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDriveStatus[] DriveList { get; set; }
        /// <summary>Indicates whether error logging or verbose logging is enabled.</summary>
        string LogLevel { get; set; }
        /// <summary>Specifies the properties of a UpdateJob.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IUpdateJobParametersProperties Property { get; set; }
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
        /// <summary>Specifies the return carrier and customer's account with the carrier.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IReturnShipping ReturnShipping { get; set; }
        /// <summary>The customer's account number with the carrier.</summary>
        string ReturnShippingCarrierAccountNumber { get; set; }
        /// <summary>The carrier's name.</summary>
        string ReturnShippingCarrierName { get; set; }
        /// <summary>
        /// If specified, the value must be Shipping, which tells the Import/Export service that the package for the job has been
        /// shipped. The ReturnAddress and DeliveryPackage properties must have been set either in this request or in a previous request,
        /// otherwise the request will fail.
        /// </summary>
        string State { get; set; }
        /// <summary>Specifies the tags that will be assigned to the job</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.IAny Tag { get; set; }

    }
}