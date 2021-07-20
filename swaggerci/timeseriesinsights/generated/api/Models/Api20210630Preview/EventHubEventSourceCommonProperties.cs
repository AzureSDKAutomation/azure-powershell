namespace Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Extensions;

    /// <summary>Properties of the EventHub event source.</summary>
    public partial class EventHubEventSourceCommonProperties :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventHubEventSourceCommonProperties,
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventHubEventSourceCommonPropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IAzureEventSourceProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IAzureEventSourceProperties __azureEventSourceProperties = new Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.AzureEventSourceProperties();

        /// <summary>Backing field for <see cref="ConsumerGroupName" /> property.</summary>
        private string _consumerGroupName;

        /// <summary>
        /// The name of the event hub's consumer group that holds the partitions from which events will be read.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Owned)]
        public string ConsumerGroupName { get => this._consumerGroupName; set => this._consumerGroupName = value; }

        /// <summary>The time the resource was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public global::System.DateTime? CreationTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourcePropertiesInternal)__azureEventSourceProperties).CreationTime; }

        /// <summary>Backing field for <see cref="EventHubName" /> property.</summary>
        private string _eventHubName;

        /// <summary>The name of the event hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Owned)]
        public string EventHubName { get => this._eventHubName; set => this._eventHubName = value; }

        /// <summary>The resource id of the event source in Azure Resource Manager.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public string EventSourceResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IAzureEventSourcePropertiesInternal)__azureEventSourceProperties).EventSourceResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IAzureEventSourcePropertiesInternal)__azureEventSourceProperties).EventSourceResourceId = value ; }

        /// <summary>
        /// An object that contains the details about the starting point in time to ingest events.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIngressStartAtProperties IngressStartAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal)__azureEventSourceProperties).IngressStartAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal)__azureEventSourceProperties).IngressStartAt = value ?? null /* model class */; }

        /// <summary>
        /// ISO8601 UTC datetime with seconds precision (milliseconds are optional), specifying the date and time that will be the
        /// starting point for Events to be consumed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public string IngressStartAtTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal)__azureEventSourceProperties).IngressStartAtTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal)__azureEventSourceProperties).IngressStartAtTime = value ?? null; }

        /// <summary>
        /// The type of the ingressStartAt, It can be "EarliestAvailable", "EventSourceCreationTime", "CustomEnqueuedTime".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.IngressStartAtType? IngressStartAtType { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal)__azureEventSourceProperties).IngressStartAtType; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal)__azureEventSourceProperties).IngressStartAtType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.IngressStartAtType)""); }

        /// <summary>Backing field for <see cref="KeyName" /> property.</summary>
        private string _keyName;

        /// <summary>
        /// The name of the SAS key that grants the Time Series Insights service access to the event hub. The shared access policies
        /// for this key must grant 'Listen' permissions to the event hub.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Owned)]
        public string KeyName { get => this._keyName; set => this._keyName = value; }

        /// <summary>
        /// An object that represents the local timestamp property. It contains the format of local timestamp that needs to be used
        /// and the corresponding timezone offset information. If a value isn't specified for localTimestamp, or if null, then the
        /// local timestamp will not be ingressed with the events.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ILocalTimestamp LocalTimestamp { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal)__azureEventSourceProperties).LocalTimestamp; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal)__azureEventSourceProperties).LocalTimestamp = value ?? null /* model class */; }

        /// <summary>
        /// An enum that represents the format of the local timestamp property that needs to be set.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.LocalTimestampFormat? LocalTimestampFormat { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal)__azureEventSourceProperties).LocalTimestampFormat; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal)__azureEventSourceProperties).LocalTimestampFormat = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.LocalTimestampFormat)""); }

        /// <summary>
        /// An object that represents the offset information for the local timestamp format specified. Should not be specified for
        /// LocalTimestampFormat - Embedded.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ILocalTimestampTimeZoneOffset LocalTimestampTimeZoneOffset { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal)__azureEventSourceProperties).LocalTimestampTimeZoneOffset; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal)__azureEventSourceProperties).LocalTimestampTimeZoneOffset = value ?? null /* model class */; }

        /// <summary>Internal Acessors for CreationTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourcePropertiesInternal.CreationTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourcePropertiesInternal)__azureEventSourceProperties).CreationTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourcePropertiesInternal)__azureEventSourceProperties).CreationTime = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourcePropertiesInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourcePropertiesInternal)__azureEventSourceProperties).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourcePropertiesInternal)__azureEventSourceProperties).ProvisioningState = value; }

        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourcePropertiesInternal)__azureEventSourceProperties).ProvisioningState; }

        /// <summary>Backing field for <see cref="ServiceBusNamespace" /> property.</summary>
        private string _serviceBusNamespace;

        /// <summary>The name of the service bus that contains the event hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Owned)]
        public string ServiceBusNamespace { get => this._serviceBusNamespace; set => this._serviceBusNamespace = value; }

        /// <summary>
        /// The event property that will be contain the offset information to calculate the local timestamp. When the LocalTimestampFormat
        /// is Iana, the property name will contain the name of the column which contains IANA Timezone Name (eg: Americas/Los Angeles).
        /// When LocalTimestampFormat is Timespan, it contains the name of property which contains values representing the offset
        /// (eg: P1D or 1.00:00:00)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public string TimeZoneOffsetPropertyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal)__azureEventSourceProperties).TimeZoneOffsetPropertyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal)__azureEventSourceProperties).TimeZoneOffsetPropertyName = value ?? null; }

        /// <summary>
        /// The event property that will be used as the event source's timestamp. If a value isn't specified for timestampPropertyName,
        /// or if null or empty-string is specified, the event creation time will be used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public string TimestampPropertyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal)__azureEventSourceProperties).TimestampPropertyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal)__azureEventSourceProperties).TimestampPropertyName = value ?? null; }

        /// <summary>Creates an new <see cref="EventHubEventSourceCommonProperties" /> instance.</summary>
        public EventHubEventSourceCommonProperties()
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
            await eventListener.AssertNotNull(nameof(__azureEventSourceProperties), __azureEventSourceProperties);
            await eventListener.AssertObjectIsValid(nameof(__azureEventSourceProperties), __azureEventSourceProperties);
        }
    }
    /// Properties of the EventHub event source.
    public partial interface IEventHubEventSourceCommonProperties :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IAzureEventSourceProperties
    {
        /// <summary>
        /// The name of the event hub's consumer group that holds the partitions from which events will be read.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the event hub's consumer group that holds the partitions from which events will be read.",
        SerializedName = @"consumerGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string ConsumerGroupName { get; set; }
        /// <summary>The name of the event hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the event hub.",
        SerializedName = @"eventHubName",
        PossibleTypes = new [] { typeof(string) })]
        string EventHubName { get; set; }
        /// <summary>
        /// The name of the SAS key that grants the Time Series Insights service access to the event hub. The shared access policies
        /// for this key must grant 'Listen' permissions to the event hub.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the SAS key that grants the Time Series Insights service access to the event hub. The shared access policies for this key must grant 'Listen' permissions to the event hub.",
        SerializedName = @"keyName",
        PossibleTypes = new [] { typeof(string) })]
        string KeyName { get; set; }
        /// <summary>The name of the service bus that contains the event hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the service bus that contains the event hub.",
        SerializedName = @"serviceBusNamespace",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceBusNamespace { get; set; }

    }
    /// Properties of the EventHub event source.
    internal partial interface IEventHubEventSourceCommonPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IAzureEventSourcePropertiesInternal
    {
        /// <summary>
        /// The name of the event hub's consumer group that holds the partitions from which events will be read.
        /// </summary>
        string ConsumerGroupName { get; set; }
        /// <summary>The name of the event hub.</summary>
        string EventHubName { get; set; }
        /// <summary>
        /// The name of the SAS key that grants the Time Series Insights service access to the event hub. The shared access policies
        /// for this key must grant 'Listen' permissions to the event hub.
        /// </summary>
        string KeyName { get; set; }
        /// <summary>The name of the service bus that contains the event hub.</summary>
        string ServiceBusNamespace { get; set; }

    }
}