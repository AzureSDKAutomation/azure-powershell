namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>The daily volume cap for ingestion.</summary>
    public partial class WorkspaceCapping :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceCapping,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceCappingInternal
    {

        /// <summary>Backing field for <see cref="DailyQuotaGb" /> property.</summary>
        private double? _dailyQuotaGb;

        /// <summary>The workspace daily quota for ingestion.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public double? DailyQuotaGb { get => this._dailyQuotaGb; set => this._dailyQuotaGb = value; }

        /// <summary>Backing field for <see cref="DataIngestionStatus" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataIngestionStatus? _dataIngestionStatus;

        /// <summary>The status of data ingestion for this workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataIngestionStatus? DataIngestionStatus { get => this._dataIngestionStatus; }

        /// <summary>Internal Acessors for DataIngestionStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataIngestionStatus? Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceCappingInternal.DataIngestionStatus { get => this._dataIngestionStatus; set { {_dataIngestionStatus = value;} } }

        /// <summary>Internal Acessors for QuotaNextResetTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceCappingInternal.QuotaNextResetTime { get => this._quotaNextResetTime; set { {_quotaNextResetTime = value;} } }

        /// <summary>Backing field for <see cref="QuotaNextResetTime" /> property.</summary>
        private string _quotaNextResetTime;

        /// <summary>The time when the quota will be rest.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string QuotaNextResetTime { get => this._quotaNextResetTime; }

        /// <summary>Creates an new <see cref="WorkspaceCapping" /> instance.</summary>
        public WorkspaceCapping()
        {

        }
    }
    /// The daily volume cap for ingestion.
    public partial interface IWorkspaceCapping :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>The workspace daily quota for ingestion.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The workspace daily quota for ingestion.",
        SerializedName = @"dailyQuotaGb",
        PossibleTypes = new [] { typeof(double) })]
        double? DailyQuotaGb { get; set; }
        /// <summary>The status of data ingestion for this workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The status of data ingestion for this workspace.",
        SerializedName = @"dataIngestionStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataIngestionStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataIngestionStatus? DataIngestionStatus { get;  }
        /// <summary>The time when the quota will be rest.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The time when the quota will be rest.",
        SerializedName = @"quotaNextResetTime",
        PossibleTypes = new [] { typeof(string) })]
        string QuotaNextResetTime { get;  }

    }
    /// The daily volume cap for ingestion.
    internal partial interface IWorkspaceCappingInternal

    {
        /// <summary>The workspace daily quota for ingestion.</summary>
        double? DailyQuotaGb { get; set; }
        /// <summary>The status of data ingestion for this workspace.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataIngestionStatus? DataIngestionStatus { get; set; }
        /// <summary>The time when the quota will be rest.</summary>
        string QuotaNextResetTime { get; set; }

    }
}