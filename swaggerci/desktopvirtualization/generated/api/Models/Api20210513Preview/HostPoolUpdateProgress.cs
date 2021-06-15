namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    /// <summary>Properties of host pool update progress.</summary>
    public partial class HostPoolUpdateProgress :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateProgress,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateProgressInternal
    {

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateFault[] _error;

        /// <summary>The alerts given to customers for hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateFault[] Error { get => this._error; set => this._error = value; }

        /// <summary>Backing field for <see cref="ProgressPercentage" /> property.</summary>
        private float? _progressPercentage;

        /// <summary>The progress percentage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public float? ProgressPercentage { get => this._progressPercentage; set => this._progressPercentage = value; }

        /// <summary>Backing field for <see cref="SessionHostsRollbackFailed" /> property.</summary>
        private int? _sessionHostsRollbackFailed;

        /// <summary>The number of session hosts that failed to rollback.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public int? SessionHostsRollbackFailed { get => this._sessionHostsRollbackFailed; set => this._sessionHostsRollbackFailed = value; }

        /// <summary>Backing field for <see cref="SessionHostsToUpdate" /> property.</summary>
        private int? _sessionHostsToUpdate;

        /// <summary>The number of session hosts to update by hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public int? SessionHostsToUpdate { get => this._sessionHostsToUpdate; set => this._sessionHostsToUpdate = value; }

        /// <summary>Backing field for <see cref="SessionHostsUpdated" /> property.</summary>
        private int? _sessionHostsUpdated;

        /// <summary>The number of session hosts updated by hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public int? SessionHostsUpdated { get => this._sessionHostsUpdated; set => this._sessionHostsUpdated = value; }

        /// <summary>Backing field for <see cref="SessionHostsUpdating" /> property.</summary>
        private int? _sessionHostsUpdating;

        /// <summary>The number of session hosts updating by hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public int? SessionHostsUpdating { get => this._sessionHostsUpdating; set => this._sessionHostsUpdating = value; }

        /// <summary>Backing field for <see cref="TimeCreated" /> property.</summary>
        private global::System.DateTime? _timeCreated;

        /// <summary>The hostpool update create time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public global::System.DateTime? TimeCreated { get => this._timeCreated; set => this._timeCreated = value; }

        /// <summary>Backing field for <see cref="TimeEnded" /> property.</summary>
        private global::System.DateTime? _timeEnded;

        /// <summary>The hostpool update end time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public global::System.DateTime? TimeEnded { get => this._timeEnded; set => this._timeEnded = value; }

        /// <summary>Backing field for <see cref="TimeFailed" /> property.</summary>
        private global::System.DateTime? _timeFailed;

        /// <summary>The hostpool update fail time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public global::System.DateTime? TimeFailed { get => this._timeFailed; set => this._timeFailed = value; }

        /// <summary>Backing field for <see cref="TimeStarted" /> property.</summary>
        private global::System.DateTime? _timeStarted;

        /// <summary>The hostpool update start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public global::System.DateTime? TimeStarted { get => this._timeStarted; set => this._timeStarted = value; }

        /// <summary>Creates an new <see cref="HostPoolUpdateProgress" /> instance.</summary>
        public HostPoolUpdateProgress()
        {

        }
    }
    /// Properties of host pool update progress.
    public partial interface IHostPoolUpdateProgress :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IJsonSerializable
    {
        /// <summary>The alerts given to customers for hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The alerts given to customers for hostpool update.",
        SerializedName = @"errors",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateFault) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateFault[] Error { get; set; }
        /// <summary>The progress percentage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The progress percentage.",
        SerializedName = @"progressPercentage",
        PossibleTypes = new [] { typeof(float) })]
        float? ProgressPercentage { get; set; }
        /// <summary>The number of session hosts that failed to rollback.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of session hosts that failed to rollback.",
        SerializedName = @"sessionHostsRollbackFailed",
        PossibleTypes = new [] { typeof(int) })]
        int? SessionHostsRollbackFailed { get; set; }
        /// <summary>The number of session hosts to update by hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of session hosts to update by hostpool update.",
        SerializedName = @"sessionHostsToUpdate",
        PossibleTypes = new [] { typeof(int) })]
        int? SessionHostsToUpdate { get; set; }
        /// <summary>The number of session hosts updated by hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of session hosts updated by hostpool update.",
        SerializedName = @"sessionHostsUpdated",
        PossibleTypes = new [] { typeof(int) })]
        int? SessionHostsUpdated { get; set; }
        /// <summary>The number of session hosts updating by hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of session hosts updating by hostpool update.",
        SerializedName = @"sessionHostsUpdating",
        PossibleTypes = new [] { typeof(int) })]
        int? SessionHostsUpdating { get; set; }
        /// <summary>The hostpool update create time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The hostpool update create time.",
        SerializedName = @"timeCreated",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? TimeCreated { get; set; }
        /// <summary>The hostpool update end time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The hostpool update end time.",
        SerializedName = @"timeEnded",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? TimeEnded { get; set; }
        /// <summary>The hostpool update fail time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The hostpool update fail time.",
        SerializedName = @"timeFailed",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? TimeFailed { get; set; }
        /// <summary>The hostpool update start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The hostpool update start time.",
        SerializedName = @"timeStarted",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? TimeStarted { get; set; }

    }
    /// Properties of host pool update progress.
    internal partial interface IHostPoolUpdateProgressInternal

    {
        /// <summary>The alerts given to customers for hostpool update.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateFault[] Error { get; set; }
        /// <summary>The progress percentage.</summary>
        float? ProgressPercentage { get; set; }
        /// <summary>The number of session hosts that failed to rollback.</summary>
        int? SessionHostsRollbackFailed { get; set; }
        /// <summary>The number of session hosts to update by hostpool update.</summary>
        int? SessionHostsToUpdate { get; set; }
        /// <summary>The number of session hosts updated by hostpool update.</summary>
        int? SessionHostsUpdated { get; set; }
        /// <summary>The number of session hosts updating by hostpool update.</summary>
        int? SessionHostsUpdating { get; set; }
        /// <summary>The hostpool update create time.</summary>
        global::System.DateTime? TimeCreated { get; set; }
        /// <summary>The hostpool update end time.</summary>
        global::System.DateTime? TimeEnded { get; set; }
        /// <summary>The hostpool update fail time.</summary>
        global::System.DateTime? TimeFailed { get; set; }
        /// <summary>The hostpool update start time.</summary>
        global::System.DateTime? TimeStarted { get; set; }

    }
}