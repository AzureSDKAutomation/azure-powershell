namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    /// <summary>Represents properties for a hostpool update.</summary>
    public partial class HostPoolControlParameter :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolControlParameter,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolControlParameterInternal
    {

        /// <summary>Backing field for <see cref="Action" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.HostPoolUpdateAction? _action;

        /// <summary>Action types for controlling hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.HostPoolUpdateAction? Action { get => this._action; set => this._action = value; }

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>The cancel message sent to the user on the session host.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>Creates an new <see cref="HostPoolControlParameter" /> instance.</summary>
        public HostPoolControlParameter()
        {

        }
    }
    /// Represents properties for a hostpool update.
    public partial interface IHostPoolControlParameter :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IJsonSerializable
    {
        /// <summary>Action types for controlling hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Action types for controlling hostpool update.",
        SerializedName = @"action",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.HostPoolUpdateAction) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.HostPoolUpdateAction? Action { get; set; }
        /// <summary>The cancel message sent to the user on the session host.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The cancel message sent to the user on the session host.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }

    }
    /// Represents properties for a hostpool update.
    internal partial interface IHostPoolControlParameterInternal

    {
        /// <summary>Action types for controlling hostpool update.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.HostPoolUpdateAction? Action { get; set; }
        /// <summary>The cancel message sent to the user on the session host.</summary>
        string Message { get; set; }

    }
}