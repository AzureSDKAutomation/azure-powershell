namespace Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515
{
    using static Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Extensions;

    /// <summary>
    /// An object that represents a set of mutable EventHub event source resource properties.
    /// </summary>
    public partial class EventHubEventSourceMutableProperties :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventHubEventSourceMutableProperties,
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventHubEventSourceMutablePropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventSourceMutableProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventSourceMutableProperties __eventSourceMutableProperties = new Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.EventSourceMutableProperties();

        /// <summary>
        /// An object that represents the local timestamp property. It contains the format of local timestamp that needs to be used
        /// and the corresponding timezone offset information. If a value isn't specified for localTimestamp, or if null, then the
        /// local timestamp will not be ingressed with the events.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ILocalTimestamp LocalTimestamp { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventSourceMutablePropertiesInternal)__eventSourceMutableProperties).LocalTimestamp; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventSourceMutablePropertiesInternal)__eventSourceMutableProperties).LocalTimestamp = value ?? null /* model class */; }

        /// <summary>
        /// An enum that represents the format of the local timestamp property that needs to be set.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.LocalTimestampFormat? LocalTimestampFormat { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventSourceMutablePropertiesInternal)__eventSourceMutableProperties).LocalTimestampFormat; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventSourceMutablePropertiesInternal)__eventSourceMutableProperties).LocalTimestampFormat = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.LocalTimestampFormat)""); }

        /// <summary>
        /// An object that represents the offset information for the local timestamp format specified. Should not be specified for
        /// LocalTimestampFormat - Embedded.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ILocalTimestampTimeZoneOffset LocalTimestampTimeZoneOffset { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventSourceMutablePropertiesInternal)__eventSourceMutableProperties).LocalTimestampTimeZoneOffset; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventSourceMutablePropertiesInternal)__eventSourceMutableProperties).LocalTimestampTimeZoneOffset = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="SharedAccessKey" /> property.</summary>
        private string _sharedAccessKey;

        /// <summary>
        /// The value of the shared access key that grants the Time Series Insights service read access to the event hub. This property
        /// is not shown in event source responses.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Owned)]
        public string SharedAccessKey { get => this._sharedAccessKey; set => this._sharedAccessKey = value; }

        /// <summary>
        /// The event property that will be contain the offset information to calculate the local timestamp. When the LocalTimestampFormat
        /// is Iana, the property name will contain the name of the column which contains IANA Timezone Name (eg: Americas/Los Angeles).
        /// When LocalTimestampFormat is Timespan, it contains the name of property which contains values representing the offset
        /// (eg: P1D or 1.00:00:00)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public string TimeZoneOffsetPropertyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventSourceMutablePropertiesInternal)__eventSourceMutableProperties).TimeZoneOffsetPropertyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventSourceMutablePropertiesInternal)__eventSourceMutableProperties).TimeZoneOffsetPropertyName = value ?? null; }

        /// <summary>
        /// The event property that will be used as the event source's timestamp. If a value isn't specified for timestampPropertyName,
        /// or if null or empty-string is specified, the event creation time will be used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public string TimestampPropertyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventSourceMutablePropertiesInternal)__eventSourceMutableProperties).TimestampPropertyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventSourceMutablePropertiesInternal)__eventSourceMutableProperties).TimestampPropertyName = value ?? null; }

        /// <summary>Creates an new <see cref="EventHubEventSourceMutableProperties" /> instance.</summary>
        public EventHubEventSourceMutableProperties()
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
            await eventListener.AssertNotNull(nameof(__eventSourceMutableProperties), __eventSourceMutableProperties);
            await eventListener.AssertObjectIsValid(nameof(__eventSourceMutableProperties), __eventSourceMutableProperties);
        }
    }
    /// An object that represents a set of mutable EventHub event source resource properties.
    public partial interface IEventHubEventSourceMutableProperties :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventSourceMutableProperties
    {
        /// <summary>
        /// The value of the shared access key that grants the Time Series Insights service read access to the event hub. This property
        /// is not shown in event source responses.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value of the shared access key that grants the Time Series Insights service read access to the event hub. This property is not shown in event source responses.",
        SerializedName = @"sharedAccessKey",
        PossibleTypes = new [] { typeof(string) })]
        string SharedAccessKey { get; set; }

    }
    /// An object that represents a set of mutable EventHub event source resource properties.
    internal partial interface IEventHubEventSourceMutablePropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventSourceMutablePropertiesInternal
    {
        /// <summary>
        /// The value of the shared access key that grants the Time Series Insights service read access to the event hub. This property
        /// is not shown in event source responses.
        /// </summary>
        string SharedAccessKey { get; set; }

    }
}