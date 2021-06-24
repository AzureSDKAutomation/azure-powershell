namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    /// <summary>Properties for a hostpool update.</summary>
    public partial class HostPoolUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateInternal
    {

        /// <summary>Internal Acessors for Parameter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateInternal.Parameter { get => (this._parameter = this._parameter ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.HostPoolUpdateConfigurationProperties()); set { {_parameter = value;} } }

        /// <summary>Internal Acessors for ParameterScheduledTime</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IScheduledTimeProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateInternal.ParameterScheduledTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationPropertiesInternal)Parameter).ScheduledTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationPropertiesInternal)Parameter).ScheduledTime = value; }

        /// <summary>Backing field for <see cref="Parameter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationProperties _parameter;

        /// <summary>Parameters for a hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationProperties Parameter { get => (this._parameter = this._parameter ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.HostPoolUpdateConfigurationProperties()); set => this._parameter = value; }

        /// <summary>Grace period before logging off users in seconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public int? ParameterLogOffDelaySecond { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationPropertiesInternal)Parameter).LogOffDelaySecond; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationPropertiesInternal)Parameter).LogOffDelaySecond = value ?? default(int); }

        /// <summary>Log off message sent to user for logoff.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string ParameterLogOffMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationPropertiesInternal)Parameter).LogOffMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationPropertiesInternal)Parameter).LogOffMessage = value ?? null; }

        /// <summary>The alerts given to customers for hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMaintenanceAlertsProperties[] ParameterMaintenanceAlert { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationPropertiesInternal)Parameter).MaintenanceAlert; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationPropertiesInternal)Parameter).MaintenanceAlert = value ?? null /* arrayOf */; }

        /// <summary>The maximum virtual machines to be removed during hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public int? ParameterMaxVmsRemovedDuringUpdate { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationPropertiesInternal)Parameter).MaxVmsRemovedDuringUpdate; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationPropertiesInternal)Parameter).MaxVmsRemovedDuringUpdate = value ?? default(int); }

        /// <summary>Whether to save original disk. False by default.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public bool? ParameterSaveOriginalDisk { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationPropertiesInternal)Parameter).SaveOriginalDisk; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationPropertiesInternal)Parameter).SaveOriginalDisk = value ?? default(bool); }

        /// <summary>The time the hostpool update is schedule for.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public global::System.DateTime? ScheduledTimeDateTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationPropertiesInternal)Parameter).ScheduledTimeDateTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationPropertiesInternal)Parameter).ScheduledTimeDateTime = value ?? default(global::System.DateTime); }

        /// <summary>
        /// Time zone for maintenance as defined in https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.findsystemtimezonebyid?view=net-5.0.
        /// Must be set if useLocalTime is true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string ScheduledTimeZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationPropertiesInternal)Parameter).ScheduledTimeZone; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationPropertiesInternal)Parameter).ScheduledTimeZone = value ?? null; }

        /// <summary>Backing field for <see cref="ValidateOnly" /> property.</summary>
        private bool? _validateOnly;

        /// <summary>
        /// When validateOnly is true this will run validations and return warnings and errors if any, hostpool will not be updated.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public bool? ValidateOnly { get => this._validateOnly; set => this._validateOnly = value; }

        /// <summary>Creates an new <see cref="HostPoolUpdate" /> instance.</summary>
        public HostPoolUpdate()
        {

        }
    }
    /// Properties for a hostpool update.
    public partial interface IHostPoolUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IJsonSerializable
    {
        /// <summary>Grace period before logging off users in seconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Grace period before logging off users in seconds.",
        SerializedName = @"logOffDelaySeconds",
        PossibleTypes = new [] { typeof(int) })]
        int? ParameterLogOffDelaySecond { get; set; }
        /// <summary>Log off message sent to user for logoff.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Log off message sent to user for logoff.",
        SerializedName = @"logOffMessage",
        PossibleTypes = new [] { typeof(string) })]
        string ParameterLogOffMessage { get; set; }
        /// <summary>The alerts given to customers for hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The alerts given to customers for hostpool update.",
        SerializedName = @"maintenanceAlerts",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMaintenanceAlertsProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMaintenanceAlertsProperties[] ParameterMaintenanceAlert { get; set; }
        /// <summary>The maximum virtual machines to be removed during hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The maximum virtual machines to be removed during hostpool update.",
        SerializedName = @"maxVMsRemovedDuringUpdate",
        PossibleTypes = new [] { typeof(int) })]
        int? ParameterMaxVmsRemovedDuringUpdate { get; set; }
        /// <summary>Whether to save original disk. False by default.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether to save original disk. False by default.",
        SerializedName = @"saveOriginalDisk",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ParameterSaveOriginalDisk { get; set; }
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
        /// <summary>
        /// When validateOnly is true this will run validations and return warnings and errors if any, hostpool will not be updated.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"When validateOnly is true this will run validations and return warnings and errors if any, hostpool will not be updated.",
        SerializedName = @"validateOnly",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ValidateOnly { get; set; }

    }
    /// Properties for a hostpool update.
    internal partial interface IHostPoolUpdateInternal

    {
        /// <summary>Parameters for a hostpool update.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateConfigurationProperties Parameter { get; set; }
        /// <summary>Grace period before logging off users in seconds.</summary>
        int? ParameterLogOffDelaySecond { get; set; }
        /// <summary>Log off message sent to user for logoff.</summary>
        string ParameterLogOffMessage { get; set; }
        /// <summary>The alerts given to customers for hostpool update.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMaintenanceAlertsProperties[] ParameterMaintenanceAlert { get; set; }
        /// <summary>The maximum virtual machines to be removed during hostpool update.</summary>
        int? ParameterMaxVmsRemovedDuringUpdate { get; set; }
        /// <summary>Whether to save original disk. False by default.</summary>
        bool? ParameterSaveOriginalDisk { get; set; }
        /// <summary>When set schedules the hostpool update at specific time.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IScheduledTimeProperties ParameterScheduledTime { get; set; }
        /// <summary>The time the hostpool update is schedule for.</summary>
        global::System.DateTime? ScheduledTimeDateTime { get; set; }
        /// <summary>
        /// Time zone for maintenance as defined in https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.findsystemtimezonebyid?view=net-5.0.
        /// Must be set if useLocalTime is true.
        /// </summary>
        string ScheduledTimeZone { get; set; }
        /// <summary>
        /// When validateOnly is true this will run validations and return warnings and errors if any, hostpool will not be updated.
        /// </summary>
        bool? ValidateOnly { get; set; }

    }
}