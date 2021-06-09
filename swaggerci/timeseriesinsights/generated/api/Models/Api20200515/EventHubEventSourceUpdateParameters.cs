namespace Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515
{
    using static Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Extensions;

    /// <summary>
    /// Parameters supplied to the Update Event Source operation to update an EventHub event source.
    /// </summary>
    public partial class EventHubEventSourceUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventHubEventSourceUpdateParameters,
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventHubEventSourceUpdateParametersInternal,
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventSourceUpdateParameters"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventSourceUpdateParameters __eventSourceUpdateParameters = new Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.EventSourceUpdateParameters();

        /// <summary>The kind of the event source.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.EventSourceKind Kind { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventSourceUpdateParametersInternal)__eventSourceUpdateParameters).Kind; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventHubEventSourceMutableProperties Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventHubEventSourceUpdateParametersInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.EventHubEventSourceMutableProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Kind</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.EventSourceKind Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventSourceUpdateParametersInternal.Kind { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventSourceUpdateParametersInternal)__eventSourceUpdateParameters).Kind; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventSourceUpdateParametersInternal)__eventSourceUpdateParameters).Kind = value; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventHubEventSourceMutableProperties _property;

        /// <summary>Properties of the EventHub event source.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventHubEventSourceMutableProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.EventHubEventSourceMutableProperties()); set => this._property = value; }

        /// <summary>
        /// The value of the shared access key that grants the Time Series Insights service read access to the event hub. This property
        /// is not shown in event source responses.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public string SharedAccessKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventHubEventSourceMutablePropertiesInternal)Property).SharedAccessKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventHubEventSourceMutablePropertiesInternal)Property).SharedAccessKey = value ?? null; }

        /// <summary>Key-value pairs of additional properties for the event source.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventSourceUpdateParametersTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventSourceUpdateParametersInternal)__eventSourceUpdateParameters).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventSourceUpdateParametersInternal)__eventSourceUpdateParameters).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The event property that will be used as the event source's timestamp. If a value isn't specified for timestampPropertyName,
        /// or if null or empty-string is specified, the event creation time will be used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public string TimestampPropertyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventSourceMutablePropertiesInternal)Property).TimestampPropertyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventSourceMutablePropertiesInternal)Property).TimestampPropertyName = value ?? null; }

        /// <summary>Creates an new <see cref="EventHubEventSourceUpdateParameters" /> instance.</summary>
        public EventHubEventSourceUpdateParameters()
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
            await eventListener.AssertNotNull(nameof(__eventSourceUpdateParameters), __eventSourceUpdateParameters);
            await eventListener.AssertObjectIsValid(nameof(__eventSourceUpdateParameters), __eventSourceUpdateParameters);
        }
    }
    /// Parameters supplied to the Update Event Source operation to update an EventHub event source.
    public partial interface IEventHubEventSourceUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventSourceUpdateParameters
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
    /// Parameters supplied to the Update Event Source operation to update an EventHub event source.
    internal partial interface IEventHubEventSourceUpdateParametersInternal :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventSourceUpdateParametersInternal
    {
        /// <summary>Properties of the EventHub event source.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventHubEventSourceMutableProperties Property { get; set; }
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