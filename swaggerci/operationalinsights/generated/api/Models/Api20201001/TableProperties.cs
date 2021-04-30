namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>Table properties.</summary>
    public partial class TableProperties :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ITableProperties,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ITablePropertiesInternal
    {

        /// <summary>Backing field for <see cref="IsTroubleshootEnabled" /> property.</summary>
        private bool? _isTroubleshootEnabled;

        /// <summary>Enable or disable troubleshoot for this table.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public bool? IsTroubleshootEnabled { get => this._isTroubleshootEnabled; set => this._isTroubleshootEnabled = value; }

        /// <summary>Backing field for <see cref="IsTroubleshootingAllowed" /> property.</summary>
        private bool? _isTroubleshootingAllowed;

        /// <summary>Specifies if IsTroubleshootingEnabled property can be set for this table.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public bool? IsTroubleshootingAllowed { get => this._isTroubleshootingAllowed; }

        /// <summary>Backing field for <see cref="LastTroubleshootDate" /> property.</summary>
        private string _lastTroubleshootDate;

        /// <summary>Last time when troubleshooting was set for this table.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string LastTroubleshootDate { get => this._lastTroubleshootDate; }

        /// <summary>Internal Acessors for IsTroubleshootingAllowed</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ITablePropertiesInternal.IsTroubleshootingAllowed { get => this._isTroubleshootingAllowed; set { {_isTroubleshootingAllowed = value;} } }

        /// <summary>Internal Acessors for LastTroubleshootDate</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ITablePropertiesInternal.LastTroubleshootDate { get => this._lastTroubleshootDate; set { {_lastTroubleshootDate = value;} } }

        /// <summary>Backing field for <see cref="RetentionInDay" /> property.</summary>
        private int? _retentionInDay;

        /// <summary>
        /// The data table data retention in days, between 7 and 730. Setting this property to null will default to the workspace
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
        /// <summary>Enable or disable troubleshoot for this table.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enable or disable troubleshoot for this table.",
        SerializedName = @"isTroubleshootEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsTroubleshootEnabled { get; set; }
        /// <summary>Specifies if IsTroubleshootingEnabled property can be set for this table.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Specifies if IsTroubleshootingEnabled property can be set for this table.",
        SerializedName = @"isTroubleshootingAllowed",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsTroubleshootingAllowed { get;  }
        /// <summary>Last time when troubleshooting was set for this table.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Last time when troubleshooting was set for this table.",
        SerializedName = @"lastTroubleshootDate",
        PossibleTypes = new [] { typeof(string) })]
        string LastTroubleshootDate { get;  }
        /// <summary>
        /// The data table data retention in days, between 7 and 730. Setting this property to null will default to the workspace
        /// retention.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The data table data retention in days, between 7 and 730. Setting this property to null will default to the workspace retention.",
        SerializedName = @"retentionInDays",
        PossibleTypes = new [] { typeof(int) })]
        int? RetentionInDay { get; set; }

    }
    /// Table properties.
    internal partial interface ITablePropertiesInternal

    {
        /// <summary>Enable or disable troubleshoot for this table.</summary>
        bool? IsTroubleshootEnabled { get; set; }
        /// <summary>Specifies if IsTroubleshootingEnabled property can be set for this table.</summary>
        bool? IsTroubleshootingAllowed { get; set; }
        /// <summary>Last time when troubleshooting was set for this table.</summary>
        string LastTroubleshootDate { get; set; }
        /// <summary>
        /// The data table data retention in days, between 7 and 730. Setting this property to null will default to the workspace
        /// retention.
        /// </summary>
        int? RetentionInDay { get; set; }

    }
}