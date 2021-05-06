namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>Table properties.</summary>
    public partial class TableProperties :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ITableProperties,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ITablePropertiesInternal
    {

        /// <summary>Backing field for <see cref="RetentionInDay" /> property.</summary>
        private int? _retentionInDay;

        /// <summary>
        /// The data table data retention in days, between 30 and 730. Setting this property to null will default to the workspace
        /// retention.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public int? RetentionInDay { get => this._retentionInDay; set => this._retentionInDay = value; }

        /// <summary>Creates an new <see cref="TableProperties" /> instance.</summary>
        public TableProperties()
        {

        }
    }
    /// Table properties.
    public partial interface ITableProperties :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The data table data retention in days, between 30 and 730. Setting this property to null will default to the workspace
        /// retention.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The data table data retention in days, between 30 and 730. Setting this property to null will default to the workspace retention.",
        SerializedName = @"retentionInDays",
        PossibleTypes = new [] { typeof(int) })]
        int? RetentionInDay { get; set; }

    }
    /// Table properties.
    internal partial interface ITablePropertiesInternal

    {
        /// <summary>
        /// The data table data retention in days, between 30 and 730. Setting this property to null will default to the workspace
        /// retention.
        /// </summary>
        int? RetentionInDay { get; set; }

    }
}