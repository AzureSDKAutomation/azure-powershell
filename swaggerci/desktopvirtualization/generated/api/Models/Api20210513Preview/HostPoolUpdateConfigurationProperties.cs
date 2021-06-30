namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    /// <summary>The configurations of a hostpool update.</summary>
    public partial class HostPoolUpdateConfigurationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationPropertiesInternal
    {

        /// <summary>Backing field for <see cref="LogOffDelaySecond" /> property.</summary>
        private int? _logOffDelaySecond;

        /// <summary>Grace period before logging off users in seconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public int? LogOffDelaySecond { get => this._logOffDelaySecond; set => this._logOffDelaySecond = value; }

        /// <summary>Backing field for <see cref="LogOffMessage" /> property.</summary>
        private string _logOffMessage;

        /// <summary>Log off message sent to user for logoff.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string LogOffMessage { get => this._logOffMessage; set => this._logOffMessage = value; }

        /// <summary>Backing field for <see cref="MaintenanceAlert" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMaintenanceAlertsProperties[] _maintenanceAlert;

        /// <summary>The alerts given to customers for hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMaintenanceAlertsProperties[] MaintenanceAlert { get => this._maintenanceAlert; set => this._maintenanceAlert = value; }

        /// <summary>Backing field for <see cref="MaxVmsRemovedDuringUpdate" /> property.</summary>
        private int? _maxVmsRemovedDuringUpdate;

        /// <summary>The maximum virtual machines to be removed during hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public int? MaxVmsRemovedDuringUpdate { get => this._maxVmsRemovedDuringUpdate; set => this._maxVmsRemovedDuringUpdate = value; }

        /// <summary>Internal Acessors for ScheduledTime</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IScheduledTimeProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationPropertiesInternal.ScheduledTime { get => (this._scheduledTime = this._scheduledTime ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ScheduledTimeProperties()); set { {_scheduledTime = value;} } }

        /// <summary>Backing field for <see cref="SaveOriginalDisk" /> property.</summary>
        private bool? _saveOriginalDisk;

        /// <summary>Whether to save original disk. False by default.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public bool? SaveOriginalDisk { get => this._saveOriginalDisk; set => this._saveOriginalDisk = value; }

        /// <summary>Backing field for <see cref="ScheduledTime" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IScheduledTimeProperties _scheduledTime;

        /// <summary>When set schedules the hostpool update at specific time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IScheduledTimeProperties ScheduledTime { get => (this._scheduledTime = this._scheduledTime ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ScheduledTimeProperties()); set => this._scheduledTime = value; }

        /// <summary>The time the hostpool update is schedule for.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public global::System.DateTime? ScheduledTimeDateTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IScheduledTimePropertiesInternal)ScheduledTime).DateTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IScheduledTimePropertiesInternal)ScheduledTime).DateTime = value ?? default(global::System.DateTime); }

        /// <summary>
        /// Time zone for maintenance as defined in https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.findsystemtimezonebyid?view=net-5.0.
        /// Must be set if useLocalTime is true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string ScheduledTimeZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IScheduledTimePropertiesInternal)ScheduledTime).TimeZone; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IScheduledTimePropertiesInternal)ScheduledTime).TimeZone = value ?? null; }

        /// <summary>Creates an new <see cref="HostPoolUpdateConfigurationProperties" /> instance.</summary>
        public HostPoolUpdateConfigurationProperties()
        {

        }
    }
    /// The configurations of a hostpool update.
    public partial interface IHostPoolUpdateConfigurationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IJsonSerializable
    {
        /// <summary>Grace period before logging off users in seconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Grace period before logging off users in seconds.",
        SerializedName = @"logOffDelaySeconds",
        PossibleTypes = new [] { typeof(int) })]
        int? LogOffDelaySecond { get; set; }
        /// <summary>Log off message sent to user for logoff.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Log off message sent to user for logoff.",
        SerializedName = @"logOffMessage",
        PossibleTypes = new [] { typeof(string) })]
        string LogOffMessage { get; set; }
        /// <summary>The alerts given to customers for hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The alerts given to customers for hostpool update.",
        SerializedName = @"maintenanceAlerts",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMaintenanceAlertsProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMaintenanceAlertsProperties[] MaintenanceAlert { get; set; }
        /// <summary>The maximum virtual machines to be removed during hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The maximum virtual machines to be removed during hostpool update.",
        SerializedName = @"maxVMsRemovedDuringUpdate",
        PossibleTypes = new [] { typeof(int) })]
        int? MaxVmsRemovedDuringUpdate { get; set; }
        /// <summary>Whether to save original disk. False by default.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether to save original disk. False by default.",
        SerializedName = @"saveOriginalDisk",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SaveOriginalDisk { get; set; }
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

    }
    /// The configurations of a hostpool update.
    internal partial interface IHostPoolUpdateConfigurationPropertiesInternal

    {
        /// <summary>Grace period before logging off users in seconds.</summary>
        int? LogOffDelaySecond { get; set; }
        /// <summary>Log off message sent to user for logoff.</summary>
        string LogOffMessage { get; set; }
        /// <summary>The alerts given to customers for hostpool update.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMaintenanceAlertsProperties[] MaintenanceAlert { get; set; }
        /// <summary>The maximum virtual machines to be removed during hostpool update.</summary>
        int? MaxVmsRemovedDuringUpdate { get; set; }
        /// <summary>Whether to save original disk. False by default.</summary>
        bool? SaveOriginalDisk { get; set; }
        /// <summary>When set schedules the hostpool update at specific time.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IScheduledTimeProperties ScheduledTime { get; set; }
        /// <summary>The time the hostpool update is schedule for.</summary>
        global::System.DateTime? ScheduledTimeDateTime { get; set; }
        /// <summary>
        /// Time zone for maintenance as defined in https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.findsystemtimezonebyid?view=net-5.0.
        /// Must be set if useLocalTime is true.
        /// </summary>
        string ScheduledTimeZone { get; set; }

    }
}