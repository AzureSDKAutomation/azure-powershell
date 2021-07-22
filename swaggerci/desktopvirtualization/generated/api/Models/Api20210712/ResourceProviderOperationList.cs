namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    /// <summary>Result of the request to list operations.</summary>
    public partial class ResourceProviderOperationList :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IResourceProviderOperationList,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IResourceProviderOperationListInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IResourceProviderOperation[] _value;

        /// <summary>List of operations supported by this resource provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IResourceProviderOperation[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ResourceProviderOperationList" /> instance.</summary>
        public ResourceProviderOperationList()
        {

        }
    }
    /// Result of the request to list operations.
    public partial interface IResourceProviderOperationList :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IJsonSerializable
    {
        /// <summary>List of operations supported by this resource provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of operations supported by this resource provider.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IResourceProviderOperation) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IResourceProviderOperation[] Value { get; set; }

    }
    /// Result of the request to list operations.
    internal partial interface IResourceProviderOperationListInternal

    {
        /// <summary>List of operations supported by this resource provider.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IResourceProviderOperation[] Value { get; set; }

    }
}