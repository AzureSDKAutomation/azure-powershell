namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    /// <summary>Hostpool update fault information.</summary>
    public partial class HostPoolUpdateFault :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateFault,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolUpdateFaultInternal
    {

        /// <summary>Backing field for <see cref="FaultCode" /> property.</summary>
        private string _faultCode;

        /// <summary>Hostpool update fault code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string FaultCode { get => this._faultCode; set => this._faultCode = value; }

        /// <summary>Backing field for <see cref="FaultContext" /> property.</summary>
        private string _faultContext;

        /// <summary>Hostpool update fault context.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string FaultContext { get => this._faultContext; set => this._faultContext = value; }

        /// <summary>Backing field for <see cref="FaultText" /> property.</summary>
        private string _faultText;

        /// <summary>Hostpool update fault text.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string FaultText { get => this._faultText; set => this._faultText = value; }

        /// <summary>Backing field for <see cref="FaultType" /> property.</summary>
        private string _faultType;

        /// <summary>Hostpool update fault type. Either ServiceError or UserError.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string FaultType { get => this._faultType; set => this._faultType = value; }

        /// <summary>Creates an new <see cref="HostPoolUpdateFault" /> instance.</summary>
        public HostPoolUpdateFault()
        {

        }
    }
    /// Hostpool update fault information.
    public partial interface IHostPoolUpdateFault :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IJsonSerializable
    {
        /// <summary>Hostpool update fault code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Hostpool update fault code.",
        SerializedName = @"faultCode",
        PossibleTypes = new [] { typeof(string) })]
        string FaultCode { get; set; }
        /// <summary>Hostpool update fault context.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Hostpool update fault context.",
        SerializedName = @"faultContext",
        PossibleTypes = new [] { typeof(string) })]
        string FaultContext { get; set; }
        /// <summary>Hostpool update fault text.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Hostpool update fault text.",
        SerializedName = @"faultText",
        PossibleTypes = new [] { typeof(string) })]
        string FaultText { get; set; }
        /// <summary>Hostpool update fault type. Either ServiceError or UserError.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Hostpool update fault type. Either ServiceError or UserError.",
        SerializedName = @"faultType",
        PossibleTypes = new [] { typeof(string) })]
        string FaultType { get; set; }

    }
    /// Hostpool update fault information.
    internal partial interface IHostPoolUpdateFaultInternal

    {
        /// <summary>Hostpool update fault code.</summary>
        string FaultCode { get; set; }
        /// <summary>Hostpool update fault context.</summary>
        string FaultContext { get; set; }
        /// <summary>Hostpool update fault text.</summary>
        string FaultText { get; set; }
        /// <summary>Hostpool update fault type. Either ServiceError or UserError.</summary>
        string FaultType { get; set; }

    }
}