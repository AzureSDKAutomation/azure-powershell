namespace Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Extensions;

    /// <summary>The response of the List Reference Data Sets operation.</summary>
    public partial class ReferenceDataSetListResponse :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IReferenceDataSetListResponse,
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IReferenceDataSetListResponseInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IReferenceDataSetResource[] _value;

        /// <summary>Result of the List Reference Data Sets operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IReferenceDataSetResource[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ReferenceDataSetListResponse" /> instance.</summary>
        public ReferenceDataSetListResponse()
        {

        }
    }
    /// The response of the List Reference Data Sets operation.
    public partial interface IReferenceDataSetListResponse :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IJsonSerializable
    {
        /// <summary>Result of the List Reference Data Sets operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Result of the List Reference Data Sets operation.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IReferenceDataSetResource) })]
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IReferenceDataSetResource[] Value { get; set; }

    }
    /// The response of the List Reference Data Sets operation.
    internal partial interface IReferenceDataSetListResponseInternal

    {
        /// <summary>Result of the List Reference Data Sets operation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IReferenceDataSetResource[] Value { get; set; }

    }
}