namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    /// <summary>
    /// Hostpool update full properties including session host config, hostpool update parameters, and update progress.
    /// </summary>
    public partial class HostPoolUpdateFullProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateFullProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateFullPropertiesInternal
    {

        /// <summary>Backing field for <see cref="CorrelationId" /> property.</summary>
        private string _correlationId;

        /// <summary>The correlationId of the hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string CorrelationId { get => this._correlationId; set => this._correlationId = value; }

        /// <summary>Backing field for <see cref="HostPoolResourceId" /> property.</summary>
        private string _hostPoolResourceId;

        /// <summary>The resourceId of hostpool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string HostPoolResourceId { get => this._hostPoolResourceId; set => this._hostPoolResourceId = value; }

        /// <summary>Backing field for <see cref="HostPoolUpdateConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationProperties _hostPoolUpdateConfiguration;

        /// <summary>The configurations of a hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationProperties HostPoolUpdateConfiguration { get => (this._hostPoolUpdateConfiguration = this._hostPoolUpdateConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.HostPoolUpdateConfigurationProperties()); set => this._hostPoolUpdateConfiguration = value; }

        /// <summary>Grace period before logging off users in seconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public int? HostPoolUpdateConfigurationLogOffDelaySecond { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationPropertiesInternal)HostPoolUpdateConfiguration).LogOffDelaySecond; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationPropertiesInternal)HostPoolUpdateConfiguration).LogOffDelaySecond = value ?? default(int); }

        /// <summary>Log off message sent to user for logoff.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string HostPoolUpdateConfigurationLogOffMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationPropertiesInternal)HostPoolUpdateConfiguration).LogOffMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationPropertiesInternal)HostPoolUpdateConfiguration).LogOffMessage = value ?? null; }

        /// <summary>The alerts given to customers for hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMaintenanceAlertsProperties[] HostPoolUpdateConfigurationMaintenanceAlert { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationPropertiesInternal)HostPoolUpdateConfiguration).MaintenanceAlert; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationPropertiesInternal)HostPoolUpdateConfiguration).MaintenanceAlert = value ?? null /* arrayOf */; }

        /// <summary>The maximum virtual machines to be removed during hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public int? HostPoolUpdateConfigurationMaxVmsRemovedDuringUpdate { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationPropertiesInternal)HostPoolUpdateConfiguration).MaxVmsRemovedDuringUpdate; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationPropertiesInternal)HostPoolUpdateConfiguration).MaxVmsRemovedDuringUpdate = value ?? default(int); }

        /// <summary>Whether to save original disk. False by default.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public bool? HostPoolUpdateConfigurationSaveOriginalDisk { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationPropertiesInternal)HostPoolUpdateConfiguration).SaveOriginalDisk; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationPropertiesInternal)HostPoolUpdateConfiguration).SaveOriginalDisk = value ?? default(bool); }

        /// <summary>Internal Acessors for HostPoolUpdateConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateFullPropertiesInternal.HostPoolUpdateConfiguration { get => (this._hostPoolUpdateConfiguration = this._hostPoolUpdateConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.HostPoolUpdateConfigurationProperties()); set { {_hostPoolUpdateConfiguration = value;} } }

        /// <summary>Internal Acessors for HostPoolUpdateConfigurationScheduledTime</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IScheduledTimeProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateFullPropertiesInternal.HostPoolUpdateConfigurationScheduledTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationPropertiesInternal)HostPoolUpdateConfiguration).ScheduledTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationPropertiesInternal)HostPoolUpdateConfiguration).ScheduledTime = value; }

        /// <summary>Internal Acessors for UpdateProgress</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateProgress Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateFullPropertiesInternal.UpdateProgress { get => (this._updateProgress = this._updateProgress ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.HostPoolUpdateProgress()); set { {_updateProgress = value;} } }

        /// <summary>The time the hostpool update is schedule for.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public global::System.DateTime? ScheduledTimeDateTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationPropertiesInternal)HostPoolUpdateConfiguration).ScheduledTimeDateTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationPropertiesInternal)HostPoolUpdateConfiguration).ScheduledTimeDateTime = value ?? default(global::System.DateTime); }

        /// <summary>
        /// Time zone for maintenance as defined in https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.findsystemtimezonebyid?view=net-5.0.
        /// Must be set if useLocalTime is true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string ScheduledTimeZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationPropertiesInternal)HostPoolUpdateConfiguration).ScheduledTimeZone; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationPropertiesInternal)HostPoolUpdateConfiguration).ScheduledTimeZone = value ?? null; }

        /// <summary>Backing field for <see cref="SessionHostConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationProperties _sessionHostConfiguration;

        /// <summary>The session host configurations of a host pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationProperties SessionHostConfiguration { get => (this._sessionHostConfiguration = this._sessionHostConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.SessionHostConfigurationProperties()); set => this._sessionHostConfiguration = value; }

        /// <summary>Backing field for <see cref="UpdateProgress" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateProgress _updateProgress;

        /// <summary>Properties of host pool update progress.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateProgress UpdateProgress { get => (this._updateProgress = this._updateProgress ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.HostPoolUpdateProgress()); }

        /// <summary>The alerts given to customers for hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateFault[] UpdateProgressError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateProgressInternal)UpdateProgress).Error; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateProgressInternal)UpdateProgress).Error = value ?? null /* arrayOf */; }

        /// <summary>The progress percentage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public float? UpdateProgressPercentage { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateProgressInternal)UpdateProgress).ProgressPercentage; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateProgressInternal)UpdateProgress).ProgressPercentage = value ?? default(float); }

        /// <summary>The number of session hosts that failed to rollback.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public int? UpdateProgressSessionHostsRollbackFailed { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateProgressInternal)UpdateProgress).SessionHostsRollbackFailed; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateProgressInternal)UpdateProgress).SessionHostsRollbackFailed = value ?? default(int); }

        /// <summary>The number of session hosts to update by hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public int? UpdateProgressSessionHostsToUpdate { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateProgressInternal)UpdateProgress).SessionHostsToUpdate; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateProgressInternal)UpdateProgress).SessionHostsToUpdate = value ?? default(int); }

        /// <summary>The number of session hosts updated by hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public int? UpdateProgressSessionHostsUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateProgressInternal)UpdateProgress).SessionHostsUpdated; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateProgressInternal)UpdateProgress).SessionHostsUpdated = value ?? default(int); }

        /// <summary>The number of session hosts updating by hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public int? UpdateProgressSessionHostsUpdating { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateProgressInternal)UpdateProgress).SessionHostsUpdating; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateProgressInternal)UpdateProgress).SessionHostsUpdating = value ?? default(int); }

        /// <summary>The hostpool update create time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public global::System.DateTime? UpdateProgressTimeCreated { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateProgressInternal)UpdateProgress).TimeCreated; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateProgressInternal)UpdateProgress).TimeCreated = value ?? default(global::System.DateTime); }

        /// <summary>The hostpool update end time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public global::System.DateTime? UpdateProgressTimeEnded { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateProgressInternal)UpdateProgress).TimeEnded; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateProgressInternal)UpdateProgress).TimeEnded = value ?? default(global::System.DateTime); }

        /// <summary>The hostpool update fail time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public global::System.DateTime? UpdateProgressTimeFailed { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateProgressInternal)UpdateProgress).TimeFailed; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateProgressInternal)UpdateProgress).TimeFailed = value ?? default(global::System.DateTime); }

        /// <summary>The hostpool update start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public global::System.DateTime? UpdateProgressTimeStarted { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateProgressInternal)UpdateProgress).TimeStarted; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateProgressInternal)UpdateProgress).TimeStarted = value ?? default(global::System.DateTime); }

        /// <summary>Backing field for <see cref="UpdateStatus" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.HostPoolUpdateStatus? _updateStatus;

        /// <summary>State of hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.HostPoolUpdateStatus? UpdateStatus { get => this._updateStatus; set => this._updateStatus = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>The version of hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="HostPoolUpdateFullProperties" /> instance.</summary>
        public HostPoolUpdateFullProperties()
        {

        }
    }
    /// Hostpool update full properties including session host config, hostpool update parameters, and update progress.
    public partial interface IHostPoolUpdateFullProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IJsonSerializable
    {
        /// <summary>The correlationId of the hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The correlationId of the hostpool update.",
        SerializedName = @"correlationId",
        PossibleTypes = new [] { typeof(string) })]
        string CorrelationId { get; set; }
        /// <summary>The resourceId of hostpool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resourceId of hostpool.",
        SerializedName = @"hostPoolResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string HostPoolResourceId { get; set; }
        /// <summary>Grace period before logging off users in seconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Grace period before logging off users in seconds.",
        SerializedName = @"logOffDelaySeconds",
        PossibleTypes = new [] { typeof(int) })]
        int? HostPoolUpdateConfigurationLogOffDelaySecond { get; set; }
        /// <summary>Log off message sent to user for logoff.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Log off message sent to user for logoff.",
        SerializedName = @"logOffMessage",
        PossibleTypes = new [] { typeof(string) })]
        string HostPoolUpdateConfigurationLogOffMessage { get; set; }
        /// <summary>The alerts given to customers for hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The alerts given to customers for hostpool update.",
        SerializedName = @"maintenanceAlerts",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMaintenanceAlertsProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMaintenanceAlertsProperties[] HostPoolUpdateConfigurationMaintenanceAlert { get; set; }
        /// <summary>The maximum virtual machines to be removed during hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The maximum virtual machines to be removed during hostpool update.",
        SerializedName = @"maxVMsRemovedDuringUpdate",
        PossibleTypes = new [] { typeof(int) })]
        int? HostPoolUpdateConfigurationMaxVmsRemovedDuringUpdate { get; set; }
        /// <summary>Whether to save original disk. False by default.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether to save original disk. False by default.",
        SerializedName = @"saveOriginalDisk",
        PossibleTypes = new [] { typeof(bool) })]
        bool? HostPoolUpdateConfigurationSaveOriginalDisk { get; set; }
        /// <summary>The time the hostpool update is schedule for.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The time the hostpool update is schedule for.",
        SerializedName = @"dateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ScheduledTimeDateTime { get; set; }
        /// <summary>
        /// Time zone for maintenance as defined in https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.findsystemtimezonebyid?view=net-5.0.
        /// Must be set if useLocalTime is true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Time zone for maintenance as defined in https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.findsystemtimezonebyid?view=net-5.0. Must be set if useLocalTime is true.",
        SerializedName = @"timeZone",
        PossibleTypes = new [] { typeof(string) })]
        string ScheduledTimeZone { get; set; }
        /// <summary>The session host configurations of a host pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The session host configurations of a host pool.",
        SerializedName = @"sessionHostConfiguration",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationProperties SessionHostConfiguration { get; set; }
        /// <summary>The alerts given to customers for hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The alerts given to customers for hostpool update.",
        SerializedName = @"errors",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateFault) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateFault[] UpdateProgressError { get; set; }
        /// <summary>The progress percentage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The progress percentage.",
        SerializedName = @"progressPercentage",
        PossibleTypes = new [] { typeof(float) })]
        float? UpdateProgressPercentage { get; set; }
        /// <summary>The number of session hosts that failed to rollback.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of session hosts that failed to rollback.",
        SerializedName = @"sessionHostsRollbackFailed",
        PossibleTypes = new [] { typeof(int) })]
        int? UpdateProgressSessionHostsRollbackFailed { get; set; }
        /// <summary>The number of session hosts to update by hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of session hosts to update by hostpool update.",
        SerializedName = @"sessionHostsToUpdate",
        PossibleTypes = new [] { typeof(int) })]
        int? UpdateProgressSessionHostsToUpdate { get; set; }
        /// <summary>The number of session hosts updated by hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of session hosts updated by hostpool update.",
        SerializedName = @"sessionHostsUpdated",
        PossibleTypes = new [] { typeof(int) })]
        int? UpdateProgressSessionHostsUpdated { get; set; }
        /// <summary>The number of session hosts updating by hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of session hosts updating by hostpool update.",
        SerializedName = @"sessionHostsUpdating",
        PossibleTypes = new [] { typeof(int) })]
        int? UpdateProgressSessionHostsUpdating { get; set; }
        /// <summary>The hostpool update create time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The hostpool update create time.",
        SerializedName = @"timeCreated",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? UpdateProgressTimeCreated { get; set; }
        /// <summary>The hostpool update end time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The hostpool update end time.",
        SerializedName = @"timeEnded",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? UpdateProgressTimeEnded { get; set; }
        /// <summary>The hostpool update fail time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The hostpool update fail time.",
        SerializedName = @"timeFailed",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? UpdateProgressTimeFailed { get; set; }
        /// <summary>The hostpool update start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The hostpool update start time.",
        SerializedName = @"timeStarted",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? UpdateProgressTimeStarted { get; set; }
        /// <summary>State of hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"State of hostpool update.",
        SerializedName = @"updateStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.HostPoolUpdateStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.HostPoolUpdateStatus? UpdateStatus { get; set; }
        /// <summary>The version of hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The version of hostpool update.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// Hostpool update full properties including session host config, hostpool update parameters, and update progress.
    internal partial interface IHostPoolUpdateFullPropertiesInternal

    {
        /// <summary>The correlationId of the hostpool update.</summary>
        string CorrelationId { get; set; }
        /// <summary>The resourceId of hostpool.</summary>
        string HostPoolResourceId { get; set; }
        /// <summary>The configurations of a hostpool update.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationProperties HostPoolUpdateConfiguration { get; set; }
        /// <summary>Grace period before logging off users in seconds.</summary>
        int? HostPoolUpdateConfigurationLogOffDelaySecond { get; set; }
        /// <summary>Log off message sent to user for logoff.</summary>
        string HostPoolUpdateConfigurationLogOffMessage { get; set; }
        /// <summary>The alerts given to customers for hostpool update.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMaintenanceAlertsProperties[] HostPoolUpdateConfigurationMaintenanceAlert { get; set; }
        /// <summary>The maximum virtual machines to be removed during hostpool update.</summary>
        int? HostPoolUpdateConfigurationMaxVmsRemovedDuringUpdate { get; set; }
        /// <summary>Whether to save original disk. False by default.</summary>
        bool? HostPoolUpdateConfigurationSaveOriginalDisk { get; set; }
        /// <summary>When set schedules the hostpool update at specific time.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IScheduledTimeProperties HostPoolUpdateConfigurationScheduledTime { get; set; }
        /// <summary>The time the hostpool update is schedule for.</summary>
        global::System.DateTime? ScheduledTimeDateTime { get; set; }
        /// <summary>
        /// Time zone for maintenance as defined in https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.findsystemtimezonebyid?view=net-5.0.
        /// Must be set if useLocalTime is true.
        /// </summary>
        string ScheduledTimeZone { get; set; }
        /// <summary>The session host configurations of a host pool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationProperties SessionHostConfiguration { get; set; }
        /// <summary>Properties of host pool update progress.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateProgress UpdateProgress { get; set; }
        /// <summary>The alerts given to customers for hostpool update.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateFault[] UpdateProgressError { get; set; }
        /// <summary>The progress percentage.</summary>
        float? UpdateProgressPercentage { get; set; }
        /// <summary>The number of session hosts that failed to rollback.</summary>
        int? UpdateProgressSessionHostsRollbackFailed { get; set; }
        /// <summary>The number of session hosts to update by hostpool update.</summary>
        int? UpdateProgressSessionHostsToUpdate { get; set; }
        /// <summary>The number of session hosts updated by hostpool update.</summary>
        int? UpdateProgressSessionHostsUpdated { get; set; }
        /// <summary>The number of session hosts updating by hostpool update.</summary>
        int? UpdateProgressSessionHostsUpdating { get; set; }
        /// <summary>The hostpool update create time.</summary>
        global::System.DateTime? UpdateProgressTimeCreated { get; set; }
        /// <summary>The hostpool update end time.</summary>
        global::System.DateTime? UpdateProgressTimeEnded { get; set; }
        /// <summary>The hostpool update fail time.</summary>
        global::System.DateTime? UpdateProgressTimeFailed { get; set; }
        /// <summary>The hostpool update start time.</summary>
        global::System.DateTime? UpdateProgressTimeStarted { get; set; }
        /// <summary>State of hostpool update.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.HostPoolUpdateStatus? UpdateStatus { get; set; }
        /// <summary>The version of hostpool update.</summary>
        string Version { get; set; }

    }
}