namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210401Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    /// <summary>
    /// List of private endpoint connection associated with the specified storage account
    /// </summary>
    public partial class PrivateEndpointConnectionListResultWithSystemData :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210401Preview.IPrivateEndpointConnectionListResultWithSystemData,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210401Preview.IPrivateEndpointConnectionListResultWithSystemDataInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210401Preview.IPrivateEndpointConnectionWithSystemData[] _value;

        /// <summary>Array of private endpoint connections</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210401Preview.IPrivateEndpointConnectionWithSystemData[] Value { get => this._value; set => this._value = value; }

        /// <summary>
        /// Creates an new <see cref="PrivateEndpointConnectionListResultWithSystemData" /> instance.
        /// </summary>
        public PrivateEndpointConnectionListResultWithSystemData()
        {

        }
    }
    /// List of private endpoint connection associated with the specified storage account
    public partial interface IPrivateEndpointConnectionListResultWithSystemData :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IJsonSerializable
    {
        /// <summary>Array of private endpoint connections</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Array of private endpoint connections",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210401Preview.IPrivateEndpointConnectionWithSystemData) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210401Preview.IPrivateEndpointConnectionWithSystemData[] Value { get; set; }

    }
    /// List of private endpoint connection associated with the specified storage account
    internal partial interface IPrivateEndpointConnectionListResultWithSystemDataInternal

    {
        /// <summary>Array of private endpoint connections</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210401Preview.IPrivateEndpointConnectionWithSystemData[] Value { get; set; }

    }
}