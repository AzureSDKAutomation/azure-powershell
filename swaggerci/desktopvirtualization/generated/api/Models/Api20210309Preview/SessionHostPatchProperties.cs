namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    /// <summary>SessionHost properties that can be patched.</summary>
    public partial class SessionHostPatchProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.ISessionHostPatchProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.ISessionHostPatchPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AllowNewSession" /> property.</summary>
        private bool? _allowNewSession;

        /// <summary>Allow a new session.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public bool? AllowNewSession { get => this._allowNewSession; set => this._allowNewSession = value; }

        /// <summary>Backing field for <see cref="AssignedUser" /> property.</summary>
        private string _assignedUser;

        /// <summary>User assigned to SessionHost.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string AssignedUser { get => this._assignedUser; set => this._assignedUser = value; }

        /// <summary>Creates an new <see cref="SessionHostPatchProperties" /> instance.</summary>
        public SessionHostPatchProperties()
        {

        }
    }
    /// SessionHost properties that can be patched.
    public partial interface ISessionHostPatchProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IJsonSerializable
    {
        /// <summary>Allow a new session.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Allow a new session.",
        SerializedName = @"allowNewSession",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AllowNewSession { get; set; }
        /// <summary>User assigned to SessionHost.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"User assigned to SessionHost.",
        SerializedName = @"assignedUser",
        PossibleTypes = new [] { typeof(string) })]
        string AssignedUser { get; set; }

    }
    /// SessionHost properties that can be patched.
    internal partial interface ISessionHostPatchPropertiesInternal

    {
        /// <summary>Allow a new session.</summary>
        bool? AllowNewSession { get; set; }
        /// <summary>User assigned to SessionHost.</summary>
        string AssignedUser { get; set; }

    }
}