namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210401Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    public partial class CloudErrorProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210401Preview.ICloudErrorProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210401Preview.ICloudErrorPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Code" /> property.</summary>
        private string _code;

        /// <summary>Error code</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string Code { get => this._code; set => this._code = value; }

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>Error message indicating why the operation failed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>Creates an new <see cref="CloudErrorProperties" /> instance.</summary>
        public CloudErrorProperties()
        {

        }
    }
    public partial interface ICloudErrorProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IJsonSerializable
    {
        /// <summary>Error code</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Error code",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get; set; }
        /// <summary>Error message indicating why the operation failed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Error message indicating why the operation failed.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }

    }
    internal partial interface ICloudErrorPropertiesInternal

    {
        /// <summary>Error code</summary>
        string Code { get; set; }
        /// <summary>Error message indicating why the operation failed.</summary>
        string Message { get; set; }

    }
}