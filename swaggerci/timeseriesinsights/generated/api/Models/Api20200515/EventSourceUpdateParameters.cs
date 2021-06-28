namespace Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515
{
    using static Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Extensions;

    /// <summary>Parameters supplied to the Update Event Source operation.</summary>
    public partial class EventSourceUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventSourceUpdateParameters,
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventSourceUpdateParametersInternal
    {

        /// <summary>Backing field for <see cref="Kind" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.EventSourceKind _kind;

        /// <summary>The kind of the event source.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.EventSourceKind Kind { get => this._kind; set => this._kind = value; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventSourceUpdateParametersTags _tag;

        /// <summary>Key-value pairs of additional properties for the event source.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventSourceUpdateParametersTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.EventSourceUpdateParametersTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="EventSourceUpdateParameters" /> instance.</summary>
        public EventSourceUpdateParameters()
        {

        }
    }
    /// Parameters supplied to the Update Event Source operation.
    public partial interface IEventSourceUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IJsonSerializable
    {
        /// <summary>The kind of the event source.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The kind of the event source.",
        SerializedName = @"kind",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.EventSourceKind) })]
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.EventSourceKind Kind { get; set; }
        /// <summary>Key-value pairs of additional properties for the event source.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Key-value pairs of additional properties for the event source.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventSourceUpdateParametersTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventSourceUpdateParametersTags Tag { get; set; }

    }
    /// Parameters supplied to the Update Event Source operation.
    internal partial interface IEventSourceUpdateParametersInternal

    {
        /// <summary>The kind of the event source.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.EventSourceKind Kind { get; set; }
        /// <summary>Key-value pairs of additional properties for the event source.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEventSourceUpdateParametersTags Tag { get; set; }

    }
}