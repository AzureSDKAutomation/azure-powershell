namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    /// <summary>Properties for host pool update maintenance alerts.</summary>
    public partial class MaintenanceAlertsProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMaintenanceAlertsProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMaintenanceAlertsPropertiesInternal
    {

        /// <summary>Backing field for <see cref="BeforeKickOff" /> property.</summary>
        private bool? _beforeKickOff;

        /// <summary>
        /// Whether to send maintenance alert after or before hostpool update. False by default.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public bool? BeforeKickOff { get => this._beforeKickOff; set => this._beforeKickOff = value; }

        /// <summary>Backing field for <see cref="Duration" /> property.</summary>
        private int? _duration;

        /// <summary>
        /// The time maintenance notification will be sent relative to before/after the update kickoff in minutes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public int? Duration { get => this._duration; set => this._duration = value; }

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>The path to the legacy object to migrate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>Creates an new <see cref="MaintenanceAlertsProperties" /> instance.</summary>
        public MaintenanceAlertsProperties()
        {

        }
    }
    /// Properties for host pool update maintenance alerts.
    public partial interface IMaintenanceAlertsProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Whether to send maintenance alert after or before hostpool update. False by default.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether to send maintenance alert after or before hostpool update. False by default.",
        SerializedName = @"beforeKickOff",
        PossibleTypes = new [] { typeof(bool) })]
        bool? BeforeKickOff { get; set; }
        /// <summary>
        /// The time maintenance notification will be sent relative to before/after the update kickoff in minutes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The time maintenance notification will be sent relative to before/after the update kickoff in minutes.",
        SerializedName = @"duration",
        PossibleTypes = new [] { typeof(int) })]
        int? Duration { get; set; }
        /// <summary>The path to the legacy object to migrate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The path to the legacy object to migrate.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }

    }
    /// Properties for host pool update maintenance alerts.
    internal partial interface IMaintenanceAlertsPropertiesInternal

    {
        /// <summary>
        /// Whether to send maintenance alert after or before hostpool update. False by default.
        /// </summary>
        bool? BeforeKickOff { get; set; }
        /// <summary>
        /// The time maintenance notification will be sent relative to before/after the update kickoff in minutes.
        /// </summary>
        int? Duration { get; set; }
        /// <summary>The path to the legacy object to migrate.</summary>
        string Message { get; set; }

    }
}