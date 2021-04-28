namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>The core summary of a search.</summary>
    public partial class CoreSummary :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ICoreSummary,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ICoreSummaryInternal
    {

        /// <summary>Backing field for <see cref="NumberOfDocument" /> property.</summary>
        private long _numberOfDocument;

        /// <summary>The number of documents of a core summary.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public long NumberOfDocument { get => this._numberOfDocument; set => this._numberOfDocument = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>The status of a core summary.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="CoreSummary" /> instance.</summary>
        public CoreSummary()
        {

        }
    }
    /// The core summary of a search.
    public partial interface ICoreSummary :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>The number of documents of a core summary.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The number of documents of a core summary.",
        SerializedName = @"numberOfDocuments",
        PossibleTypes = new [] { typeof(long) })]
        long NumberOfDocument { get; set; }
        /// <summary>The status of a core summary.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The status of a core summary.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get; set; }

    }
    /// The core summary of a search.
    internal partial interface ICoreSummaryInternal

    {
        /// <summary>The number of documents of a core summary.</summary>
        long NumberOfDocument { get; set; }
        /// <summary>The status of a core summary.</summary>
        string Status { get; set; }

    }
}