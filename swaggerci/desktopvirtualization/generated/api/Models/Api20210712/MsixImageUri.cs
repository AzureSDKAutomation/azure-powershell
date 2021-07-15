namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    /// <summary>Represents URI referring to MSIX Image</summary>
    public partial class MsixImageUri :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IMsixImageUri,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IMsixImageUriInternal
    {

        /// <summary>Backing field for <see cref="Uri" /> property.</summary>
        private string _uri;

        /// <summary>URI to Image</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string Uri { get => this._uri; set => this._uri = value; }

        /// <summary>Creates an new <see cref="MsixImageUri" /> instance.</summary>
        public MsixImageUri()
        {

        }
    }
    /// Represents URI referring to MSIX Image
    public partial interface IMsixImageUri :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IJsonSerializable
    {
        /// <summary>URI to Image</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to Image",
        SerializedName = @"uri",
        PossibleTypes = new [] { typeof(string) })]
        string Uri { get; set; }

    }
    /// Represents URI referring to MSIX Image
    internal partial interface IMsixImageUriInternal

    {
        /// <summary>URI to Image</summary>
        string Uri { get; set; }

    }
}