namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    /// <summary>Errors and warnings returned by hostpool update validation.</summary>
    public partial class HostPoolUpdateValidationResponse :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateValidationResponse,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateValidationResponseInternal
    {

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateFault[] _error;

        /// <summary>Errors from the hostpool update validation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateFault[] Error { get => this._error; set => this._error = value; }

        /// <summary>Backing field for <see cref="Warning" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateFault[] _warning;

        /// <summary>Warnings from the hostpool update validation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateFault[] Warning { get => this._warning; set => this._warning = value; }

        /// <summary>Creates an new <see cref="HostPoolUpdateValidationResponse" /> instance.</summary>
        public HostPoolUpdateValidationResponse()
        {

        }
    }
    /// Errors and warnings returned by hostpool update validation.
    public partial interface IHostPoolUpdateValidationResponse :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IJsonSerializable
    {
        /// <summary>Errors from the hostpool update validation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Errors from the hostpool update validation.",
        SerializedName = @"errors",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateFault) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateFault[] Error { get; set; }
        /// <summary>Warnings from the hostpool update validation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Warnings from the hostpool update validation.",
        SerializedName = @"warnings",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateFault) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateFault[] Warning { get; set; }

    }
    /// Errors and warnings returned by hostpool update validation.
    internal partial interface IHostPoolUpdateValidationResponseInternal

    {
        /// <summary>Errors from the hostpool update validation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateFault[] Error { get; set; }
        /// <summary>Warnings from the hostpool update validation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateFault[] Warning { get; set; }

    }
}