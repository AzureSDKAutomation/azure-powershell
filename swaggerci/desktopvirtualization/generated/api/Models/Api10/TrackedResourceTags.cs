namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    /// <summary>Resource tags.</summary>
    public partial class TrackedResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.ITrackedResourceTags,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.ITrackedResourceTagsInternal
    {

        /// <summary>Creates an new <see cref="TrackedResourceTags" /> instance.</summary>
        public TrackedResourceTags()
        {

        }
    }
    /// Resource tags.
    public partial interface ITrackedResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IAssociativeArray<string>
    {

    }
    /// Resource tags.
    internal partial interface ITrackedResourceTagsInternal

    {

    }
}