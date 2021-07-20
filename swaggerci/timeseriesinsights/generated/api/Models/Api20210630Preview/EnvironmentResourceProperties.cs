namespace Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Extensions;

    /// <summary>Properties of the environment.</summary>
    public partial class EnvironmentResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentResourceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentResourcePropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourceProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourceProperties __resourceProperties = new Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ResourceProperties();

        /// <summary>The time the resource was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public global::System.DateTime? CreationTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourcePropertiesInternal)__resourceProperties).CreationTime; }

        /// <summary>Backing field for <see cref="DataAccessFqdn" /> property.</summary>
        private string _dataAccessFqdn;

        /// <summary>
        /// The fully qualified domain name used to access the environment data, e.g. to query the environment's events or upload
        /// reference data for the environment.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Owned)]
        public string DataAccessFqdn { get => this._dataAccessFqdn; }

        /// <summary>Backing field for <see cref="DataAccessId" /> property.</summary>
        private string _dataAccessId;

        /// <summary>
        /// An id used to access the environment data, e.g. to query the environment's events or upload reference data for the environment.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Owned)]
        public string DataAccessId { get => this._dataAccessId; }

        /// <summary>
        /// This string represents the state of ingress operations on an environment. It can be "Disabled", "Ready", "Running", "Paused"
        /// or "Unknown"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.IngressState? IngressState { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentStatusInternal)Status).IngressState; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentStatusInternal)Status).IngressState = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.IngressState)""); }

        /// <summary>Internal Acessors for DataAccessFqdn</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentResourcePropertiesInternal.DataAccessFqdn { get => this._dataAccessFqdn; set { {_dataAccessFqdn = value;} } }

        /// <summary>Internal Acessors for DataAccessId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentResourcePropertiesInternal.DataAccessId { get => this._dataAccessId; set { {_dataAccessId = value;} } }

        /// <summary>Internal Acessors for IngressStateDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentStateDetails Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentResourcePropertiesInternal.IngressStateDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentStatusInternal)Status).IngressStateDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentStatusInternal)Status).IngressStateDetail = value; }

        /// <summary>Internal Acessors for PropertyUsageStateDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IWarmStoragePropertiesUsageStateDetails Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentResourcePropertiesInternal.PropertyUsageStateDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentStatusInternal)Status).PropertyUsageStateDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentStatusInternal)Status).PropertyUsageStateDetail = value; }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentStatus Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentResourcePropertiesInternal.Status { get => (this._status = this._status ?? new Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.EnvironmentStatus()); set { {_status = value;} } }

        /// <summary>Internal Acessors for StatusIngress</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIngressEnvironmentStatus Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentResourcePropertiesInternal.StatusIngress { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentStatusInternal)Status).Ingress; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentStatusInternal)Status).Ingress = value; }

        /// <summary>Internal Acessors for StatusWarmStorage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IWarmStorageEnvironmentStatus Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentResourcePropertiesInternal.StatusWarmStorage { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentStatusInternal)Status).WarmStorage; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentStatusInternal)Status).WarmStorage = value; }

        /// <summary>Internal Acessors for SupportsCustomerManagedKey</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentResourcePropertiesInternal.SupportsCustomerManagedKey { get => this._supportsCustomerManagedKey; set { {_supportsCustomerManagedKey = value;} } }

        /// <summary>Internal Acessors for WarmStoragePropertiesUsage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IWarmStoragePropertiesUsage Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentResourcePropertiesInternal.WarmStoragePropertiesUsage { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentStatusInternal)Status).WarmStoragePropertiesUsage; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentStatusInternal)Status).WarmStoragePropertiesUsage = value; }

        /// <summary>Internal Acessors for CreationTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourcePropertiesInternal.CreationTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourcePropertiesInternal)__resourceProperties).CreationTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourcePropertiesInternal)__resourceProperties).CreationTime = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourcePropertiesInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourcePropertiesInternal)__resourceProperties).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourcePropertiesInternal)__resourceProperties).ProvisioningState = value; }

        /// <summary>
        /// This string represents the state of warm storage properties usage. It can be "Ok", "Error", "Unknown".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.WarmStoragePropertiesState? PropertyUsageState { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentStatusInternal)Status).PropertyUsageState; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentStatusInternal)Status).PropertyUsageState = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.WarmStoragePropertiesState)""); }

        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourcePropertiesInternal)__resourceProperties).ProvisioningState; }

        /// <summary>
        /// Contains the code that represents the reason of an environment being in a particular state. Can be used to programmatically
        /// handle specific cases.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public string StateDetailCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentStatusInternal)Status).StateDetailCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentStatusInternal)Status).StateDetailCode = value ?? null; }

        /// <summary>
        /// A value that represents the number of properties used by the environment for S1/S2 SKU and number of properties used by
        /// Warm Store for PAYG SKU
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public int? StateDetailCurrentCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentStatusInternal)Status).StateDetailCurrentCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentStatusInternal)Status).StateDetailCurrentCount = value ?? default(int); }

        /// <summary>
        /// A value that represents the maximum number of properties used allowed by the environment for S1/S2 SKU and maximum number
        /// of properties allowed by Warm Store for PAYG SKU.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public int? StateDetailMaxCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentStatusInternal)Status).StateDetailMaxCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentStatusInternal)Status).StateDetailMaxCount = value ?? default(int); }

        /// <summary>A message that describes the state in detail.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public string StateDetailMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentStatusInternal)Status).StateDetailMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentStatusInternal)Status).StateDetailMessage = value ?? null; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentStatus _status;

        /// <summary>
        /// An object that represents the status of the environment, and its internal state in the Time Series Insights service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentStatus Status { get => (this._status = this._status ?? new Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.EnvironmentStatus()); }

        /// <summary>Backing field for <see cref="SupportsCustomerManagedKey" /> property.</summary>
        private bool? _supportsCustomerManagedKey;

        /// <summary>
        /// Indicates whether an environment supports Encryption at Rest with Customer Managed Key.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Owned)]
        public bool? SupportsCustomerManagedKey { get => this._supportsCustomerManagedKey; }

        /// <summary>Creates an new <see cref="EnvironmentResourceProperties" /> instance.</summary>
        public EnvironmentResourceProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resourceProperties), __resourceProperties);
            await eventListener.AssertObjectIsValid(nameof(__resourceProperties), __resourceProperties);
        }
    }
    /// Properties of the environment.
    public partial interface IEnvironmentResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourceProperties
    {
        /// <summary>
        /// The fully qualified domain name used to access the environment data, e.g. to query the environment's events or upload
        /// reference data for the environment.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The fully qualified domain name used to access the environment data, e.g. to query the environment's events or upload reference data for the environment.",
        SerializedName = @"dataAccessFqdn",
        PossibleTypes = new [] { typeof(string) })]
        string DataAccessFqdn { get;  }
        /// <summary>
        /// An id used to access the environment data, e.g. to query the environment's events or upload reference data for the environment.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"An id used to access the environment data, e.g. to query the environment's events or upload reference data for the environment.",
        SerializedName = @"dataAccessId",
        PossibleTypes = new [] { typeof(string) })]
        string DataAccessId { get;  }
        /// <summary>
        /// This string represents the state of ingress operations on an environment. It can be "Disabled", "Ready", "Running", "Paused"
        /// or "Unknown"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This string represents the state of ingress operations on an environment. It can be ""Disabled"", ""Ready"", ""Running"", ""Paused"" or ""Unknown""",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.IngressState) })]
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.IngressState? IngressState { get; set; }
        /// <summary>
        /// This string represents the state of warm storage properties usage. It can be "Ok", "Error", "Unknown".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This string represents the state of warm storage properties usage. It can be ""Ok"", ""Error"", ""Unknown"".",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.WarmStoragePropertiesState) })]
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.WarmStoragePropertiesState? PropertyUsageState { get; set; }
        /// <summary>
        /// Contains the code that represents the reason of an environment being in a particular state. Can be used to programmatically
        /// handle specific cases.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Contains the code that represents the reason of an environment being in a particular state. Can be used to programmatically handle specific cases.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string StateDetailCode { get; set; }
        /// <summary>
        /// A value that represents the number of properties used by the environment for S1/S2 SKU and number of properties used by
        /// Warm Store for PAYG SKU
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value that represents the number of properties used by the environment for S1/S2 SKU and number of properties used by Warm Store for PAYG SKU",
        SerializedName = @"currentCount",
        PossibleTypes = new [] { typeof(int) })]
        int? StateDetailCurrentCount { get; set; }
        /// <summary>
        /// A value that represents the maximum number of properties used allowed by the environment for S1/S2 SKU and maximum number
        /// of properties allowed by Warm Store for PAYG SKU.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value that represents the maximum number of properties used allowed by the environment for S1/S2 SKU and maximum number of properties allowed by Warm Store for PAYG SKU.",
        SerializedName = @"maxCount",
        PossibleTypes = new [] { typeof(int) })]
        int? StateDetailMaxCount { get; set; }
        /// <summary>A message that describes the state in detail.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A message that describes the state in detail.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string StateDetailMessage { get; set; }
        /// <summary>
        /// Indicates whether an environment supports Encryption at Rest with Customer Managed Key.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Indicates whether an environment supports Encryption at Rest with Customer Managed Key.",
        SerializedName = @"supportsCustomerManagedKey",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SupportsCustomerManagedKey { get;  }

    }
    /// Properties of the environment.
    internal partial interface IEnvironmentResourcePropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourcePropertiesInternal
    {
        /// <summary>
        /// The fully qualified domain name used to access the environment data, e.g. to query the environment's events or upload
        /// reference data for the environment.
        /// </summary>
        string DataAccessFqdn { get; set; }
        /// <summary>
        /// An id used to access the environment data, e.g. to query the environment's events or upload reference data for the environment.
        /// </summary>
        string DataAccessId { get; set; }
        /// <summary>
        /// This string represents the state of ingress operations on an environment. It can be "Disabled", "Ready", "Running", "Paused"
        /// or "Unknown"
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.IngressState? IngressState { get; set; }
        /// <summary>An object that contains the details about an environment's state.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentStateDetails IngressStateDetail { get; set; }
        /// <summary>
        /// This string represents the state of warm storage properties usage. It can be "Ok", "Error", "Unknown".
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.WarmStoragePropertiesState? PropertyUsageState { get; set; }
        /// <summary>An object that contains the details about warm storage properties usage state.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IWarmStoragePropertiesUsageStateDetails PropertyUsageStateDetail { get; set; }
        /// <summary>
        /// Contains the code that represents the reason of an environment being in a particular state. Can be used to programmatically
        /// handle specific cases.
        /// </summary>
        string StateDetailCode { get; set; }
        /// <summary>
        /// A value that represents the number of properties used by the environment for S1/S2 SKU and number of properties used by
        /// Warm Store for PAYG SKU
        /// </summary>
        int? StateDetailCurrentCount { get; set; }
        /// <summary>
        /// A value that represents the maximum number of properties used allowed by the environment for S1/S2 SKU and maximum number
        /// of properties allowed by Warm Store for PAYG SKU.
        /// </summary>
        int? StateDetailMaxCount { get; set; }
        /// <summary>A message that describes the state in detail.</summary>
        string StateDetailMessage { get; set; }
        /// <summary>
        /// An object that represents the status of the environment, and its internal state in the Time Series Insights service.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentStatus Status { get; set; }
        /// <summary>An object that represents the status of ingress on an environment.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIngressEnvironmentStatus StatusIngress { get; set; }
        /// <summary>An object that represents the status of warm storage on an environment.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IWarmStorageEnvironmentStatus StatusWarmStorage { get; set; }
        /// <summary>
        /// Indicates whether an environment supports Encryption at Rest with Customer Managed Key.
        /// </summary>
        bool? SupportsCustomerManagedKey { get; set; }
        /// <summary>An object that contains the status of warm storage properties usage.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IWarmStoragePropertiesUsage WarmStoragePropertiesUsage { get; set; }

    }
}