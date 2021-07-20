namespace Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Extensions;

    /// <summary>
    /// An object that represents a set of mutable Gen2 environment resource properties.
    /// </summary>
    public partial class Gen2EnvironmentMutableProperties :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IGen2EnvironmentMutableProperties,
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IGen2EnvironmentMutablePropertiesInternal
    {

        /// <summary>Internal Acessors for StorageConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IGen2StorageConfigurationMutableProperties Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IGen2EnvironmentMutablePropertiesInternal.StorageConfiguration { get => (this._storageConfiguration = this._storageConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.Gen2StorageConfigurationMutableProperties()); set { {_storageConfiguration = value;} } }

        /// <summary>Internal Acessors for WarmStoreConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IWarmStoreConfigurationProperties Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IGen2EnvironmentMutablePropertiesInternal.WarmStoreConfiguration { get => (this._warmStoreConfiguration = this._warmStoreConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.WarmStoreConfigurationProperties()); set { {_warmStoreConfiguration = value;} } }

        /// <summary>Backing field for <see cref="StorageConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IGen2StorageConfigurationMutableProperties _storageConfiguration;

        /// <summary>
        /// The storage configuration provides the connection details that allows the Time Series Insights service to connect to the
        /// customer storage account that is used to store the environment's data.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IGen2StorageConfigurationMutableProperties StorageConfiguration { get => (this._storageConfiguration = this._storageConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.Gen2StorageConfigurationMutableProperties()); set => this._storageConfiguration = value; }

        /// <summary>
        /// The value of the management key that grants the Time Series Insights service write access to the storage account. This
        /// property is not shown in environment responses.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public string StorageConfigurationManagementKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IGen2StorageConfigurationMutablePropertiesInternal)StorageConfiguration).ManagementKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IGen2StorageConfigurationMutablePropertiesInternal)StorageConfiguration).ManagementKey = value ?? null; }

        /// <summary>Backing field for <see cref="WarmStoreConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IWarmStoreConfigurationProperties _warmStoreConfiguration;

        /// <summary>
        /// The warm store configuration provides the details to create a warm store cache that will retain a copy of the environment's
        /// data available for faster query.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IWarmStoreConfigurationProperties WarmStoreConfiguration { get => (this._warmStoreConfiguration = this._warmStoreConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.WarmStoreConfigurationProperties()); set => this._warmStoreConfiguration = value; }

        /// <summary>
        /// ISO8601 timespan specifying the number of days the environment's events will be available for query from the warm store.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public global::System.TimeSpan? WarmStoreConfigurationDataRetention { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IWarmStoreConfigurationPropertiesInternal)WarmStoreConfiguration).DataRetention; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IWarmStoreConfigurationPropertiesInternal)WarmStoreConfiguration).DataRetention = value ?? default(global::System.TimeSpan); }

        /// <summary>Creates an new <see cref="Gen2EnvironmentMutableProperties" /> instance.</summary>
        public Gen2EnvironmentMutableProperties()
        {

        }
    }
    /// An object that represents a set of mutable Gen2 environment resource properties.
    public partial interface IGen2EnvironmentMutableProperties :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The value of the management key that grants the Time Series Insights service write access to the storage account. This
        /// property is not shown in environment responses.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value of the management key that grants the Time Series Insights service write access to the storage account. This property is not shown in environment responses.",
        SerializedName = @"managementKey",
        PossibleTypes = new [] { typeof(string) })]
        string StorageConfigurationManagementKey { get; set; }
        /// <summary>
        /// ISO8601 timespan specifying the number of days the environment's events will be available for query from the warm store.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ISO8601 timespan specifying the number of days the environment's events will be available for query from the warm store.",
        SerializedName = @"dataRetention",
        PossibleTypes = new [] { typeof(global::System.TimeSpan) })]
        global::System.TimeSpan? WarmStoreConfigurationDataRetention { get; set; }

    }
    /// An object that represents a set of mutable Gen2 environment resource properties.
    internal partial interface IGen2EnvironmentMutablePropertiesInternal

    {
        /// <summary>
        /// The storage configuration provides the connection details that allows the Time Series Insights service to connect to the
        /// customer storage account that is used to store the environment's data.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IGen2StorageConfigurationMutableProperties StorageConfiguration { get; set; }
        /// <summary>
        /// The value of the management key that grants the Time Series Insights service write access to the storage account. This
        /// property is not shown in environment responses.
        /// </summary>
        string StorageConfigurationManagementKey { get; set; }
        /// <summary>
        /// The warm store configuration provides the details to create a warm store cache that will retain a copy of the environment's
        /// data available for faster query.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IWarmStoreConfigurationProperties WarmStoreConfiguration { get; set; }
        /// <summary>
        /// ISO8601 timespan specifying the number of days the environment's events will be available for query from the warm store.
        /// </summary>
        global::System.TimeSpan? WarmStoreConfigurationDataRetention { get; set; }

    }
}