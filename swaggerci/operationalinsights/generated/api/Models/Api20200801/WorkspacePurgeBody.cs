namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>Describes the body of a purge request for an App Insights Workspace</summary>
    public partial class WorkspacePurgeBody :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IWorkspacePurgeBody,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IWorkspacePurgeBodyInternal
    {

        /// <summary>Backing field for <see cref="Filter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IWorkspacePurgeBodyFilters[] _filter;

        /// <summary>
        /// The set of columns and filters (queries) to run over them to purge the resulting data.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IWorkspacePurgeBodyFilters[] Filter { get => this._filter; set => this._filter = value; }

        /// <summary>Backing field for <see cref="Table" /> property.</summary>
        private string _table;

        /// <summary>Table from which to purge data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string Table { get => this._table; set => this._table = value; }

        /// <summary>Creates an new <see cref="WorkspacePurgeBody" /> instance.</summary>
        public WorkspacePurgeBody()
        {

        }
    }
    /// Describes the body of a purge request for an App Insights Workspace
    public partial interface IWorkspacePurgeBody :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The set of columns and filters (queries) to run over them to purge the resulting data.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The set of columns and filters (queries) to run over them to purge the resulting data.",
        SerializedName = @"filters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IWorkspacePurgeBodyFilters) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IWorkspacePurgeBodyFilters[] Filter { get; set; }
        /// <summary>Table from which to purge data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Table from which to purge data.",
        SerializedName = @"table",
        PossibleTypes = new [] { typeof(string) })]
        string Table { get; set; }

    }
    /// Describes the body of a purge request for an App Insights Workspace
    internal partial interface IWorkspacePurgeBodyInternal

    {
        /// <summary>
        /// The set of columns and filters (queries) to run over them to purge the resulting data.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IWorkspacePurgeBodyFilters[] Filter { get; set; }
        /// <summary>Table from which to purge data.</summary>
        string Table { get; set; }

    }
}