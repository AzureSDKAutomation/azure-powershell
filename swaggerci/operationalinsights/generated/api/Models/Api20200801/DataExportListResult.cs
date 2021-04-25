namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>Result of the request to list data exports.</summary>
    public partial class DataExportListResult :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportListResult,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportListResultInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExport[] _value;

        /// <summary>List of data export instances within a workspace..</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExport[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="DataExportListResult" /> instance.</summary>
        public DataExportListResult()
        {

        }
    }
    /// Result of the request to list data exports.
    public partial interface IDataExportListResult :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>List of data export instances within a workspace..</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of data export instances within a workspace..",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExport) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExport[] Value { get; set; }

    }
    /// Result of the request to list data exports.
    internal partial interface IDataExportListResultInternal

    {
        /// <summary>List of data export instances within a workspace..</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExport[] Value { get; set; }

    }
}