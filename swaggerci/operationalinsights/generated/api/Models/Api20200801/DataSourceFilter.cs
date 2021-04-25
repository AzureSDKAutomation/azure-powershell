namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>DataSource filter. Right now, only filter by kind is supported.</summary>
    public partial class DataSourceFilter :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataSourceFilter,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataSourceFilterInternal
    {

        /// <summary>Backing field for <see cref="Kind" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataSourceKind? _kind;

        /// <summary>The kind of the DataSource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataSourceKind? Kind { get => this._kind; set => this._kind = value; }

        /// <summary>Creates an new <see cref="DataSourceFilter" /> instance.</summary>
        public DataSourceFilter()
        {

        }
    }
    /// DataSource filter. Right now, only filter by kind is supported.
    public partial interface IDataSourceFilter :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>The kind of the DataSource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The kind of the DataSource.",
        SerializedName = @"kind",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataSourceKind) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataSourceKind? Kind { get; set; }

    }
    /// DataSource filter. Right now, only filter by kind is supported.
    internal partial interface IDataSourceFilterInternal

    {
        /// <summary>The kind of the DataSource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataSourceKind? Kind { get; set; }

    }
}