namespace Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Extensions;

    /// <summary>Properties of the event source.</summary>
    public partial class EventSourceCommonProperties :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonProperties,
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal,
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

        /// <summary>Backing field for <see cref="IngressStartAt" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIngressStartAtProperties _ingressStartAt;

        /// <summary>
        /// An object that contains the details about the starting point in time to ingest events.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIngressStartAtProperties IngressStartAt { get => (this._ingressStartAt = this._ingressStartAt ?? new Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IngressStartAtProperties()); set => this._ingressStartAt = value; }

        /// <summary>
        /// ISO8601 UTC datetime with seconds precision (milliseconds are optional), specifying the date and time that will be the
        /// starting point for Events to be consumed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public string IngressStartAtTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIngressStartAtPropertiesInternal)IngressStartAt).Time; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIngressStartAtPropertiesInternal)IngressStartAt).Time = value ?? null; }

        /// <summary>
        /// The type of the ingressStartAt, It can be "EarliestAvailable", "EventSourceCreationTime", "CustomEnqueuedTime".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.IngressStartAtType? IngressStartAtType { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIngressStartAtPropertiesInternal)IngressStartAt).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIngressStartAtPropertiesInternal)IngressStartAt).Type = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.IngressStartAtType)""); }

        /// <summary>Backing field for <see cref="LocalTimestamp" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ILocalTimestamp _localTimestamp;

        /// <summary>
        /// An object that represents the local timestamp property. It contains the format of local timestamp that needs to be used
        /// and the corresponding timezone offset information. If a value isn't specified for localTimestamp, or if null, then the
        /// local timestamp will not be ingressed with the events.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ILocalTimestamp LocalTimestamp { get => (this._localTimestamp = this._localTimestamp ?? new Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.LocalTimestamp()); set => this._localTimestamp = value; }

        /// <summary>
        /// An enum that represents the format of the local timestamp property that needs to be set.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.LocalTimestampFormat? LocalTimestampFormat { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ILocalTimestampInternal)LocalTimestamp).Format; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ILocalTimestampInternal)LocalTimestamp).Format = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.LocalTimestampFormat)""); }

        /// <summary>Internal Acessors for IngressStartAt</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIngressStartAtProperties Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal.IngressStartAt { get => (this._ingressStartAt = this._ingressStartAt ?? new Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IngressStartAtProperties()); set { {_ingressStartAt = value;} } }

        /// <summary>Internal Acessors for LocalTimestamp</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ILocalTimestamp Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal.LocalTimestamp { get => (this._localTimestamp = this._localTimestamp ?? new Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.LocalTimestamp()); set { {_localTimestamp = value;} } }

        /// <summary>Internal Acessors for LocalTimestampTimeZoneOffset</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ILocalTimestampTimeZoneOffset Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCommonPropertiesInternal.LocalTimestampTimeZoneOffset { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ILocalTimestampInternal)LocalTimestamp).TimeZoneOffset; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ILocalTimestampInternal)LocalTimestamp).TimeZoneOffset = value; }

        /// <summary>Internal Acessors for CreationTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourcePropertiesInternal.CreationTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourcePropertiesInternal)__resourceProperties).CreationTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourcePropertiesInternal)__resourceProperties).CreationTime = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourcePropertiesInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourcePropertiesInternal)__resourceProperties).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourcePropertiesInternal)__resourceProperties).ProvisioningState = value; }

        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourcePropertiesInternal)__resourceProperties).ProvisioningState; }

        /// <summary>
        /// The event property that will be contain the offset information to calculate the local timestamp. When the LocalTimestampFormat
        /// is Iana, the property name will contain the name of the column which contains IANA Timezone Name (eg: Americas/Los Angeles).
        /// When LocalTimestampFormat is Timespan, it contains the name of property which contains values representing the offset
        /// (eg: P1D or 1.00:00:00)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public string TimeZoneOffsetPropertyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ILocalTimestampInternal)LocalTimestamp).TimeZoneOffsetPropertyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ILocalTimestampInternal)LocalTimestamp).TimeZoneOffsetPropertyName = value ?? null; }

        /// <summary>Backing field for <see cref="TimestampPropertyName" /> property.</summary>
        private string _timestampPropertyName;

        /// <summary>
        /// The event property that will be used as the event source's timestamp. If a value isn't specified for timestampPropertyName,
        /// or if null or empty-string is specified, the event creation time will be used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Owned)]
        public string TimestampPropertyName { get => this._timestampPropertyName; set => this._timestampPropertyName = value; }

        /// <summary>Creates an new <see cref="EventSourceCommonProperties" /> instance.</summary>
        public EventSourceCommonProperties()
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
    /// Properties of the event source.
    public partial interface IEventSourceCommonProperties :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourceProperties
    {
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
        /// An enum that represents the format of the local timestamp property that needs to be set.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An enum that represents the format of the local timestamp property that needs to be set.",
        SerializedName = @"format",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.LocalTimestampFormat) })]
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.LocalTimestampFormat? LocalTimestampFormat { get; set; }
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
        string TimeZoneOffsetPropertyName { get; set; }
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
    /// Properties of the event source.
    internal partial interface IEventSourceCommonPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourcePropertiesInternal
    {
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
        /// An object that represents the local timestamp property. It contains the format of local timestamp that needs to be used
        /// and the corresponding timezone offset information. If a value isn't specified for localTimestamp, or if null, then the
        /// local timestamp will not be ingressed with the events.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ILocalTimestamp LocalTimestamp { get; set; }
        /// <summary>
        /// An enum that represents the format of the local timestamp property that needs to be set.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.LocalTimestampFormat? LocalTimestampFormat { get; set; }
        /// <summary>
        /// An object that represents the offset information for the local timestamp format specified. Should not be specified for
        /// LocalTimestampFormat - Embedded.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ILocalTimestampTimeZoneOffset LocalTimestampTimeZoneOffset { get; set; }
        /// <summary>
        /// The event property that will be contain the offset information to calculate the local timestamp. When the LocalTimestampFormat
        /// is Iana, the property name will contain the name of the column which contains IANA Timezone Name (eg: Americas/Los Angeles).
        /// When LocalTimestampFormat is Timespan, it contains the name of property which contains values representing the offset
        /// (eg: P1D or 1.00:00:00)
        /// </summary>
        string TimeZoneOffsetPropertyName { get; set; }
        /// <summary>
        /// The event property that will be used as the event source's timestamp. If a value isn't specified for timestampPropertyName,
        /// or if null or empty-string is specified, the event creation time will be used.
        /// </summary>
        string TimestampPropertyName { get; set; }

    }
}