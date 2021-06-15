namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    /// <summary>
    /// Secondary maintenance windows is a list of days at one specific hour. Maintenance windows are 2 hours long. We try to
    /// exercise this only when the primary window update fails.
    /// </summary>
    public partial class SecondaryWindowProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISecondaryWindowProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISecondaryWindowPropertiesInternal
    {

        /// <summary>Backing field for <see cref="DaysOfWeek" /> property.</summary>
        private string[] _daysOfWeek;

        /// <summary>Set of days of the week on which this schedule is active.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string[] DaysOfWeek { get => this._daysOfWeek; set => this._daysOfWeek = value; }

        /// <summary>Backing field for <see cref="Hour" /> property.</summary>
        private int? _hour;

        /// <summary>The update start hour of the day. (0 - 23)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public int? Hour { get => this._hour; set => this._hour = value; }

        /// <summary>Creates an new <see cref="SecondaryWindowProperties" /> instance.</summary>
        public SecondaryWindowProperties()
        {

        }
    }
    /// Secondary maintenance windows is a list of days at one specific hour. Maintenance windows are 2 hours long. We try to
    /// exercise this only when the primary window update fails.
    public partial interface ISecondaryWindowProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IJsonSerializable
    {
        /// <summary>Set of days of the week on which this schedule is active.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Set of days of the week on which this schedule is active.",
        SerializedName = @"daysOfWeek",
        PossibleTypes = new [] { typeof(string) })]
        string[] DaysOfWeek { get; set; }
        /// <summary>The update start hour of the day. (0 - 23)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The update start hour of the day. (0 - 23)",
        SerializedName = @"hour",
        PossibleTypes = new [] { typeof(int) })]
        int? Hour { get; set; }

    }
    /// Secondary maintenance windows is a list of days at one specific hour. Maintenance windows are 2 hours long. We try to
    /// exercise this only when the primary window update fails.
    internal partial interface ISecondaryWindowPropertiesInternal

    {
        /// <summary>Set of days of the week on which this schedule is active.</summary>
        string[] DaysOfWeek { get; set; }
        /// <summary>The update start hour of the day. (0 - 23)</summary>
        int? Hour { get; set; }

    }
}