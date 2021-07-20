namespace Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Extensions;

    /// <summary>
    /// An object that contains the details about the starting point in time to ingest events.
    /// </summary>
    public partial class IngressStartAtProperties :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIngressStartAtProperties,
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIngressStartAtPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Time" /> property.</summary>
        private string _time;

        /// <summary>
        /// ISO8601 UTC datetime with seconds precision (milliseconds are optional), specifying the date and time that will be the
        /// starting point for Events to be consumed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Owned)]
        public string Time { get => this._time; set => this._time = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.IngressStartAtType? _type;

        /// <summary>
        /// The type of the ingressStartAt, It can be "EarliestAvailable", "EventSourceCreationTime", "CustomEnqueuedTime".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.IngressStartAtType? Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="IngressStartAtProperties" /> instance.</summary>
        public IngressStartAtProperties()
        {

        }
    }
    /// An object that contains the details about the starting point in time to ingest events.
    public partial interface IIngressStartAtProperties :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IJsonSerializable
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
        string Time { get; set; }
        /// <summary>
        /// The type of the ingressStartAt, It can be "EarliestAvailable", "EventSourceCreationTime", "CustomEnqueuedTime".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of the ingressStartAt, It can be ""EarliestAvailable"", ""EventSourceCreationTime"", ""CustomEnqueuedTime"".",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.IngressStartAtType) })]
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.IngressStartAtType? Type { get; set; }

    }
    /// An object that contains the details about the starting point in time to ingest events.
    internal partial interface IIngressStartAtPropertiesInternal

    {
        /// <summary>
        /// ISO8601 UTC datetime with seconds precision (milliseconds are optional), specifying the date and time that will be the
        /// starting point for Events to be consumed.
        /// </summary>
        string Time { get; set; }
        /// <summary>
        /// The type of the ingressStartAt, It can be "EarliestAvailable", "EventSourceCreationTime", "CustomEnqueuedTime".
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.IngressStartAtType? Type { get; set; }

    }
}