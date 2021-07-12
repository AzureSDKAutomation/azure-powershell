namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    /// <summary>When set schedules the hostpool update at specific time.</summary>
    public partial class ScheduledTimeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IScheduledTimeProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IScheduledTimePropertiesInternal
    {

        /// <summary>Backing field for <see cref="DateTime" /> property.</summary>
        private global::System.DateTime? _dateTime;

        /// <summary>The time the hostpool update is schedule for.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public global::System.DateTime? DateTime { get => this._dateTime; set => this._dateTime = value; }

        /// <summary>Backing field for <see cref="TimeZone" /> property.</summary>
        private string _timeZone;

        /// <summary>
        /// Time zone for maintenance as defined in https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.findsystemtimezonebyid?view=net-5.0.
        /// Must be set if useLocalTime is true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string TimeZone { get => this._timeZone; set => this._timeZone = value; }

        /// <summary>Creates an new <see cref="ScheduledTimeProperties" /> instance.</summary>
        public ScheduledTimeProperties()
        {

        }
    }
    /// When set schedules the hostpool update at specific time.
    public partial interface IScheduledTimeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IJsonSerializable
    {
        /// <summary>The time the hostpool update is schedule for.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The time the hostpool update is schedule for.",
        SerializedName = @"dateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? DateTime { get; set; }
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
        string TimeZone { get; set; }

    }
    /// When set schedules the hostpool update at specific time.
    internal partial interface IScheduledTimePropertiesInternal

    {
        /// <summary>The time the hostpool update is schedule for.</summary>
        global::System.DateTime? DateTime { get; set; }
        /// <summary>
        /// Time zone for maintenance as defined in https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.findsystemtimezonebyid?view=net-5.0.
        /// Must be set if useLocalTime is true.
        /// </summary>
        string TimeZone { get; set; }

    }
}