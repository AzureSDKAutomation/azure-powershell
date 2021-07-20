namespace Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Extensions;

    /// <summary>Key-value pairs of additional properties for the event source.</summary>
    public partial class EventSourceUpdateParametersTags :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceUpdateParametersTags,
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceUpdateParametersTagsInternal
    {

        /// <summary>Creates an new <see cref="EventSourceUpdateParametersTags" /> instance.</summary>
        public EventSourceUpdateParametersTags()
        {

        }
    }
    /// Key-value pairs of additional properties for the event source.
    public partial interface IEventSourceUpdateParametersTags :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IAssociativeArray<string>
    {

    }
    /// Key-value pairs of additional properties for the event source.
    internal partial interface IEventSourceUpdateParametersTagsInternal

    {

    }
}