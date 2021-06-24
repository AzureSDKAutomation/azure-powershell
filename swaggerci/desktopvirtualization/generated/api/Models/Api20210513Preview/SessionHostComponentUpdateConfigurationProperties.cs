namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    /// <summary>
    /// The session host configuration for updating agent, monitoring agent, and stack component.
    /// </summary>
    public partial class SessionHostComponentUpdateConfigurationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostComponentUpdateConfigurationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostComponentUpdateConfigurationPropertiesInternal
    {

        /// <summary>Backing field for <see cref="MaintenanceType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SessionHostComponentUpdateType? _maintenanceType;

        /// <summary>The type of maintenance for session host components.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SessionHostComponentUpdateType? MaintenanceType { get => this._maintenanceType; set => this._maintenanceType = value; }

        /// <summary>Backing field for <see cref="MaintenanceWindowTimeZone" /> property.</summary>
        private string _maintenanceWindowTimeZone;

        /// <summary>
        /// Time zone for maintenance as defined in https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.findsystemtimezonebyid?view=net-5.0.
        /// Must be set if useLocalTime is true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string MaintenanceWindowTimeZone { get => this._maintenanceWindowTimeZone; set => this._maintenanceWindowTimeZone = value; }

        /// <summary>Internal Acessors for PrimaryWindow</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMaintenanceWindowProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostComponentUpdateConfigurationPropertiesInternal.PrimaryWindow { get => (this._primaryWindow = this._primaryWindow ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.MaintenanceWindowProperties()); set { {_primaryWindow = value;} } }

        /// <summary>Internal Acessors for SecondaryWindow</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISecondaryWindowProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostComponentUpdateConfigurationPropertiesInternal.SecondaryWindow { get => (this._secondaryWindow = this._secondaryWindow ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.SecondaryWindowProperties()); set { {_secondaryWindow = value;} } }

        /// <summary>Backing field for <see cref="PrimaryWindow" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMaintenanceWindowProperties _primaryWindow;

        /// <summary>
        /// Primary Window of the maintenance. Maintenance windows are 2 hours long. We try to push component update in this window
        /// first.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMaintenanceWindowProperties PrimaryWindow { get => (this._primaryWindow = this._primaryWindow ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.MaintenanceWindowProperties()); set => this._primaryWindow = value; }

        /// <summary>Day of the week.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.DayOfWeek? PrimaryWindowDayOfWeek { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMaintenanceWindowPropertiesInternal)PrimaryWindow).DayOfWeek; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMaintenanceWindowPropertiesInternal)PrimaryWindow).DayOfWeek = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.DayOfWeek)""); }

        /// <summary>The update start hour of the day. (0 - 23)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public int? PrimaryWindowHour { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMaintenanceWindowPropertiesInternal)PrimaryWindow).Hour; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMaintenanceWindowPropertiesInternal)PrimaryWindow).Hour = value ?? default(int); }

        /// <summary>Backing field for <see cref="SecondaryWindow" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISecondaryWindowProperties _secondaryWindow;

        /// <summary>
        /// Secondary maintenance windows. Maintenance windows are 2 hours long. We try to exercise this only when the primary window
        /// update fails.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISecondaryWindowProperties SecondaryWindow { get => (this._secondaryWindow = this._secondaryWindow ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.SecondaryWindowProperties()); set => this._secondaryWindow = value; }

        /// <summary>Set of days of the week on which this schedule is active.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string[] SecondaryWindowDaysOfWeek { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISecondaryWindowPropertiesInternal)SecondaryWindow).DaysOfWeek; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISecondaryWindowPropertiesInternal)SecondaryWindow).DaysOfWeek = value ?? null /* arrayOf */; }

        /// <summary>The update start hour of the day. (0 - 23)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public int? SecondaryWindowHour { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISecondaryWindowPropertiesInternal)SecondaryWindow).Hour; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISecondaryWindowPropertiesInternal)SecondaryWindow).Hour = value ?? default(int); }

        /// <summary>Backing field for <see cref="UseSessionHostLocalTime" /> property.</summary>
        private bool? _useSessionHostLocalTime;

        /// <summary>Whether to use localTime of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public bool? UseSessionHostLocalTime { get => this._useSessionHostLocalTime; set => this._useSessionHostLocalTime = value; }

        /// <summary>
        /// Creates an new <see cref="SessionHostComponentUpdateConfigurationProperties" /> instance.
        /// </summary>
        public SessionHostComponentUpdateConfigurationProperties()
        {

        }
    }
    /// The session host configuration for updating agent, monitoring agent, and stack component.
    public partial interface ISessionHostComponentUpdateConfigurationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IJsonSerializable
    {
        /// <summary>The type of maintenance for session host components.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of maintenance for session host components.",
        SerializedName = @"maintenanceType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SessionHostComponentUpdateType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SessionHostComponentUpdateType? MaintenanceType { get; set; }
        /// <summary>
        /// Time zone for maintenance as defined in https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.findsystemtimezonebyid?view=net-5.0.
        /// Must be set if useLocalTime is true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Time zone for maintenance as defined in https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.findsystemtimezonebyid?view=net-5.0. Must be set if useLocalTime is true.",
        SerializedName = @"maintenanceWindowTimeZone",
        PossibleTypes = new [] { typeof(string) })]
        string MaintenanceWindowTimeZone { get; set; }
        /// <summary>Day of the week.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Day of the week.",
        SerializedName = @"dayOfWeek",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.DayOfWeek) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.DayOfWeek? PrimaryWindowDayOfWeek { get; set; }
        /// <summary>The update start hour of the day. (0 - 23)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The update start hour of the day. (0 - 23)",
        SerializedName = @"hour",
        PossibleTypes = new [] { typeof(int) })]
        int? PrimaryWindowHour { get; set; }
        /// <summary>Set of days of the week on which this schedule is active.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Set of days of the week on which this schedule is active.",
        SerializedName = @"daysOfWeek",
        PossibleTypes = new [] { typeof(string) })]
        string[] SecondaryWindowDaysOfWeek { get; set; }
        /// <summary>The update start hour of the day. (0 - 23)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The update start hour of the day. (0 - 23)",
        SerializedName = @"hour",
        PossibleTypes = new [] { typeof(int) })]
        int? SecondaryWindowHour { get; set; }
        /// <summary>Whether to use localTime of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether to use localTime of the virtual machine.",
        SerializedName = @"useSessionHostLocalTime",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UseSessionHostLocalTime { get; set; }

    }
    /// The session host configuration for updating agent, monitoring agent, and stack component.
    internal partial interface ISessionHostComponentUpdateConfigurationPropertiesInternal

    {
        /// <summary>The type of maintenance for session host components.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SessionHostComponentUpdateType? MaintenanceType { get; set; }
        /// <summary>
        /// Time zone for maintenance as defined in https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.findsystemtimezonebyid?view=net-5.0.
        /// Must be set if useLocalTime is true.
        /// </summary>
        string MaintenanceWindowTimeZone { get; set; }
        /// <summary>
        /// Primary Window of the maintenance. Maintenance windows are 2 hours long. We try to push component update in this window
        /// first.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMaintenanceWindowProperties PrimaryWindow { get; set; }
        /// <summary>Day of the week.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.DayOfWeek? PrimaryWindowDayOfWeek { get; set; }
        /// <summary>The update start hour of the day. (0 - 23)</summary>
        int? PrimaryWindowHour { get; set; }
        /// <summary>
        /// Secondary maintenance windows. Maintenance windows are 2 hours long. We try to exercise this only when the primary window
        /// update fails.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISecondaryWindowProperties SecondaryWindow { get; set; }
        /// <summary>Set of days of the week on which this schedule is active.</summary>
        string[] SecondaryWindowDaysOfWeek { get; set; }
        /// <summary>The update start hour of the day. (0 - 23)</summary>
        int? SecondaryWindowHour { get; set; }
        /// <summary>Whether to use localTime of the virtual machine.</summary>
        bool? UseSessionHostLocalTime { get; set; }

    }
}