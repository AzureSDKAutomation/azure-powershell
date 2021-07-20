namespace Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Extensions;

    /// <summary>
    /// Parameters supplied to the Create or Update Event Source operation for an EventHub event source.
    /// </summary>
    public partial class EventHubEventSourceCreateOrUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventHubEventSourceCreateOrUpdateParameters,
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventHubEventSourceCreateOrUpdateParametersInternal,
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCreateOrUpdateParameters"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCreateOrUpdateParameters __eventSourceCreateOrUpdateParameters = new Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.EventSourceCreateOrUpdateParameters();

        /// <summary>
        /// The name of the event hub's consumer group that holds the partitions from which events will be read.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public string ConsumerGroupName { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventHubEventSourceCommonPropertiesInternal)Property).ConsumerGroupName; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventHubEventSourceCommonPropertiesInternal)Property).ConsumerGroupName = value ; }

        /// <summary>The time the resource was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public global::System.DateTime? CreationTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourcePropertiesInternal)Property).CreationTime; }

        /// <summary>The name of the event hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public string EventHubName { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventHubEventSourceCommonPropertiesInternal)Property).EventHubName; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventHubEventSourceCommonPropertiesInternal)Property).EventHubName = value ; }

        /// <summary>The resource id of the event source in Azure Resource Manager.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public string EventSourceResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IAzureEventSourcePropertiesInternal)Property).EventSourceResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IAzureEventSourcePropertiesInternal)Property).EventSourceResourceId = value ; }

        /// <summary>
        /// ISO8601 UTC datetime with seconds precision (milliseconds are optional), specifying the date and time that will be the
        /// starting point for Events to be consumed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public string IngressStartAtTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal)Property).IngressStartAtTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal)Property).IngressStartAtTime = value ?? null; }

        /// <summary>
        /// The type of the ingressStartAt, It can be "EarliestAvailable", "EventSourceCreationTime", "CustomEnqueuedTime".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.IngressStartAtType? IngressStartAtType { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal)Property).IngressStartAtType; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal)Property).IngressStartAtType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.IngressStartAtType)""); }

        /// <summary>
        /// The name of the SAS key that grants the Time Series Insights service access to the event hub. The shared access policies
        /// for this key must grant 'Listen' permissions to the event hub.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public string KeyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventHubEventSourceCommonPropertiesInternal)Property).KeyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventHubEventSourceCommonPropertiesInternal)Property).KeyName = value ; }

        /// <summary>The kind of the event source.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.EventSourceKind Kind { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCreateOrUpdateParametersInternal)__eventSourceCreateOrUpdateParameters).Kind; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCreateOrUpdateParametersInternal)__eventSourceCreateOrUpdateParameters).Kind = value ; }

        /// <summary>
        /// An object that represents the local timestamp property. It contains the format of local timestamp that needs to be used
        /// and the corresponding timezone offset information. If a value isn't specified for localTimestamp, or if null, then the
        /// local timestamp will not be ingressed with the events.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ILocalTimestamp LocalTimestamp { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCreateOrUpdateParametersInternal)__eventSourceCreateOrUpdateParameters).LocalTimestamp; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCreateOrUpdateParametersInternal)__eventSourceCreateOrUpdateParameters).LocalTimestamp = value ?? null /* model class */; }

        /// <summary>
        /// An enum that represents the format of the local timestamp property that needs to be set.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.LocalTimestampFormat? LocalTimestampFormat { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCreateOrUpdateParametersInternal)__eventSourceCreateOrUpdateParameters).LocalTimestampFormat; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCreateOrUpdateParametersInternal)__eventSourceCreateOrUpdateParameters).LocalTimestampFormat = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.LocalTimestampFormat)""); }

        /// <summary>
        /// An object that represents the offset information for the local timestamp format specified. Should not be specified for
        /// LocalTimestampFormat - Embedded.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ILocalTimestampTimeZoneOffset LocalTimestampTimeZoneOffset { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCreateOrUpdateParametersInternal)__eventSourceCreateOrUpdateParameters).LocalTimestampTimeZoneOffset; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCreateOrUpdateParametersInternal)__eventSourceCreateOrUpdateParameters).LocalTimestampTimeZoneOffset = value ?? null /* model class */; }

        /// <summary>The location of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ICreateOrUpdateTrackedResourcePropertiesInternal)__eventSourceCreateOrUpdateParameters).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ICreateOrUpdateTrackedResourcePropertiesInternal)__eventSourceCreateOrUpdateParameters).Location = value ; }

        /// <summary>Internal Acessors for CreationTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventHubEventSourceCreateOrUpdateParametersInternal.CreationTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourcePropertiesInternal)Property).CreationTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourcePropertiesInternal)Property).CreationTime = value; }

        /// <summary>Internal Acessors for IngressStartAt</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIngressStartAtProperties Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventHubEventSourceCreateOrUpdateParametersInternal.IngressStartAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal)Property).IngressStartAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal)Property).IngressStartAt = value; }

        /// <summary>Internal Acessors for PropertiesLocalTimestamp</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ILocalTimestamp Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventHubEventSourceCreateOrUpdateParametersInternal.PropertiesLocalTimestamp { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal)Property).LocalTimestamp; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal)Property).LocalTimestamp = value; }

        /// <summary>Internal Acessors for PropertiesLocalTimestampTimeZoneOffset</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ILocalTimestampTimeZoneOffset Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventHubEventSourceCreateOrUpdateParametersInternal.PropertiesLocalTimestampTimeZoneOffset { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal)Property).LocalTimestampTimeZoneOffset; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal)Property).LocalTimestampTimeZoneOffset = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventHubEventSourceCreationProperties Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventHubEventSourceCreateOrUpdateParametersInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.EventHubEventSourceCreationProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventHubEventSourceCreateOrUpdateParametersInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourcePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourcePropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>
        /// An enum that represents the format of the local timestamp property that needs to be set.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.LocalTimestampFormat? PropertiesLocalTimestampFormat { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal)Property).LocalTimestampFormat; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal)Property).LocalTimestampFormat = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.LocalTimestampFormat)""); }

        /// <summary>
        /// The event property that will be contain the offset information to calculate the local timestamp. When the LocalTimestampFormat
        /// is Iana, the property name will contain the name of the column which contains IANA Timezone Name (eg: Americas/Los Angeles).
        /// When LocalTimestampFormat is Timespan, it contains the name of property which contains values representing the offset
        /// (eg: P1D or 1.00:00:00)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public string PropertiesLocalTimestampTimeZoneOffsetPropertyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal)Property).TimeZoneOffsetPropertyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal)Property).TimeZoneOffsetPropertyName = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventHubEventSourceCreationProperties _property;

        /// <summary>
        /// Properties of the EventHub event source that are required on create or update requests.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventHubEventSourceCreationProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.EventHubEventSourceCreationProperties()); set => this._property = value; }

        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourcePropertiesInternal)Property).ProvisioningState; }

        /// <summary>The name of the service bus that contains the event hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public string ServiceBusNamespace { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventHubEventSourceCommonPropertiesInternal)Property).ServiceBusNamespace; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventHubEventSourceCommonPropertiesInternal)Property).ServiceBusNamespace = value ; }

        /// <summary>
        /// The value of the shared access key that grants the Time Series Insights service read access to the event hub. This property
        /// is not shown in event source responses.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public string SharedAccessKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventHubEventSourceCreationPropertiesInternal)Property).SharedAccessKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventHubEventSourceCreationPropertiesInternal)Property).SharedAccessKey = value ; }

        /// <summary>Key-value pairs of additional properties for the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ICreateOrUpdateTrackedResourcePropertiesTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ICreateOrUpdateTrackedResourcePropertiesInternal)__eventSourceCreateOrUpdateParameters).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ICreateOrUpdateTrackedResourcePropertiesInternal)__eventSourceCreateOrUpdateParameters).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The event property that will be contain the offset information to calculate the local timestamp. When the LocalTimestampFormat
        /// is Iana, the property name will contain the name of the column which contains IANA Timezone Name (eg: Americas/Los Angeles).
        /// When LocalTimestampFormat is Timespan, it contains the name of property which contains values representing the offset
        /// (eg: P1D or 1.00:00:00)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public string TimeZoneOffsetPropertyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCreateOrUpdateParametersInternal)__eventSourceCreateOrUpdateParameters).TimeZoneOffsetPropertyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCreateOrUpdateParametersInternal)__eventSourceCreateOrUpdateParameters).TimeZoneOffsetPropertyName = value ?? null; }

        /// <summary>
        /// The event property that will be used as the event source's timestamp. If a value isn't specified for timestampPropertyName,
        /// or if null or empty-string is specified, the event creation time will be used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public string TimestampPropertyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal)Property).TimestampPropertyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal)Property).TimestampPropertyName = value ?? null; }

        /// <summary>
        /// Creates an new <see cref="EventHubEventSourceCreateOrUpdateParameters" /> instance.
        /// </summary>
        public EventHubEventSourceCreateOrUpdateParameters()
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
            await eventListener.AssertNotNull(nameof(__eventSourceCreateOrUpdateParameters), __eventSourceCreateOrUpdateParameters);
            await eventListener.AssertObjectIsValid(nameof(__eventSourceCreateOrUpdateParameters), __eventSourceCreateOrUpdateParameters);
        }
    }
    /// Parameters supplied to the Create or Update Event Source operation for an EventHub event source.
    public partial interface IEventHubEventSourceCreateOrUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCreateOrUpdateParameters
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
        /// <summary>The time the resource was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The time the resource was created.",
        SerializedName = @"creationTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreationTime { get;  }
        /// <summary>The name of the event hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the event hub.",
        SerializedName = @"eventHubName",
        PossibleTypes = new [] { typeof(string) })]
        string EventHubName { get; set; }
        /// <summary>The resource id of the event source in Azure Resource Manager.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The resource id of the event source in Azure Resource Manager.",
        SerializedName = @"eventSourceResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string EventSourceResourceId { get; set; }
        /// <summary>
        /// ISO8601 UTC datetime with seconds precision (milliseconds are optional), specifying the date and time that will be the
        /// starting point for Events to be consumed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ISO8601 UTC datetime with seconds precision (milliseconds are optional), specifying the date and time that will be the starting point for Events to be consumed.",
        SerializedName = @"time",
        PossibleTypes = new [] { typeof(string) })]
        string IngressStartAtTime { get; set; }
        /// <summary>
        /// The type of the ingressStartAt, It can be "EarliestAvailable", "EventSourceCreationTime", "CustomEnqueuedTime".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of the ingressStartAt, It can be ""EarliestAvailable"", ""EventSourceCreationTime"", ""CustomEnqueuedTime"".",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.IngressStartAtType) })]
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.IngressStartAtType? IngressStartAtType { get; set; }
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
        /// <summary>
        /// An enum that represents the format of the local timestamp property that needs to be set.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An enum that represents the format of the local timestamp property that needs to be set.",
        SerializedName = @"format",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.LocalTimestampFormat) })]
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.LocalTimestampFormat? PropertiesLocalTimestampFormat { get; set; }
        /// <summary>
        /// The event property that will be contain the offset information to calculate the local timestamp. When the LocalTimestampFormat
        /// is Iana, the property name will contain the name of the column which contains IANA Timezone Name (eg: Americas/Los Angeles).
        /// When LocalTimestampFormat is Timespan, it contains the name of property which contains values representing the offset
        /// (eg: P1D or 1.00:00:00)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The event property that will be contain the offset information to calculate the local timestamp. When the LocalTimestampFormat is Iana, the property name will contain the name of the column which contains IANA Timezone Name (eg: Americas/Los Angeles). When LocalTimestampFormat is Timespan, it contains the name of property which contains values representing the offset (eg: P1D or 1.00:00:00)",
        SerializedName = @"propertyName",
        PossibleTypes = new [] { typeof(string) })]
        string PropertiesLocalTimestampTimeZoneOffsetPropertyName { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>The name of the service bus that contains the event hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the service bus that contains the event hub.",
        SerializedName = @"serviceBusNamespace",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceBusNamespace { get; set; }
        /// <summary>
        /// The value of the shared access key that grants the Time Series Insights service read access to the event hub. This property
        /// is not shown in event source responses.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The value of the shared access key that grants the Time Series Insights service read access to the event hub. This property is not shown in event source responses.",
        SerializedName = @"sharedAccessKey",
        PossibleTypes = new [] { typeof(string) })]
        string SharedAccessKey { get; set; }
        /// <summary>
        /// The event property that will be used as the event source's timestamp. If a value isn't specified for timestampPropertyName,
        /// or if null or empty-string is specified, the event creation time will be used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The event property that will be used as the event source's timestamp. If a value isn't specified for timestampPropertyName, or if null or empty-string is specified, the event creation time will be used.",
        SerializedName = @"timestampPropertyName",
        PossibleTypes = new [] { typeof(string) })]
        string TimestampPropertyName { get; set; }

    }
    /// Parameters supplied to the Create or Update Event Source operation for an EventHub event source.
    internal partial interface IEventHubEventSourceCreateOrUpdateParametersInternal :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCreateOrUpdateParametersInternal
    {
        /// <summary>
        /// The name of the event hub's consumer group that holds the partitions from which events will be read.
        /// </summary>
        string ConsumerGroupName { get; set; }
        /// <summary>The time the resource was created.</summary>
        global::System.DateTime? CreationTime { get; set; }
        /// <summary>The name of the event hub.</summary>
        string EventHubName { get; set; }
        /// <summary>The resource id of the event source in Azure Resource Manager.</summary>
        string EventSourceResourceId { get; set; }
        /// <summary>
        /// An object that contains the details about the starting point in time to ingest events.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIngressStartAtProperties IngressStartAt { get; set; }
        /// <summary>
        /// ISO8601 UTC datetime with seconds precision (milliseconds are optional), specifying the date and time that will be the
        /// starting point for Events to be consumed.
        /// </summary>
        string IngressStartAtTime { get; set; }
        /// <summary>
        /// The type of the ingressStartAt, It can be "EarliestAvailable", "EventSourceCreationTime", "CustomEnqueuedTime".
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.IngressStartAtType? IngressStartAtType { get; set; }
        /// <summary>
        /// The name of the SAS key that grants the Time Series Insights service access to the event hub. The shared access policies
        /// for this key must grant 'Listen' permissions to the event hub.
        /// </summary>
        string KeyName { get; set; }
        /// <summary>
        /// An object that represents the local timestamp property. It contains the format of local timestamp that needs to be used
        /// and the corresponding timezone offset information. If a value isn't specified for localTimestamp, or if null, then the
        /// local timestamp will not be ingressed with the events.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ILocalTimestamp PropertiesLocalTimestamp { get; set; }
        /// <summary>
        /// An enum that represents the format of the local timestamp property that needs to be set.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.LocalTimestampFormat? PropertiesLocalTimestampFormat { get; set; }
        /// <summary>
        /// An object that represents the offset information for the local timestamp format specified. Should not be specified for
        /// LocalTimestampFormat - Embedded.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ILocalTimestampTimeZoneOffset PropertiesLocalTimestampTimeZoneOffset { get; set; }
        /// <summary>
        /// The event property that will be contain the offset information to calculate the local timestamp. When the LocalTimestampFormat
        /// is Iana, the property name will contain the name of the column which contains IANA Timezone Name (eg: Americas/Los Angeles).
        /// When LocalTimestampFormat is Timespan, it contains the name of property which contains values representing the offset
        /// (eg: P1D or 1.00:00:00)
        /// </summary>
        string PropertiesLocalTimestampTimeZoneOffsetPropertyName { get; set; }
        /// <summary>
        /// Properties of the EventHub event source that are required on create or update requests.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventHubEventSourceCreationProperties Property { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>The name of the service bus that contains the event hub.</summary>
        string ServiceBusNamespace { get; set; }
        /// <summary>
        /// The value of the shared access key that grants the Time Series Insights service read access to the event hub. This property
        /// is not shown in event source responses.
        /// </summary>
        string SharedAccessKey { get; set; }
        /// <summary>
        /// The event property that will be used as the event source's timestamp. If a value isn't specified for timestampPropertyName,
        /// or if null or empty-string is specified, the event creation time will be used.
        /// </summary>
        string TimestampPropertyName { get; set; }

    }
}