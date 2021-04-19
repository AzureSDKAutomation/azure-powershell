namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Extensions;

    /// <summary>Resource tags.</summary>
    public partial class TrackedResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.ITrackedResourceTags,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.ITrackedResourceTagsInternal
    {

        /// <summary>Creates an new <see cref="TrackedResourceTags" /> instance.</summary>
        public TrackedResourceTags()
        {

        }
    }
    /// Resource tags.
    public partial interface ITrackedResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.IAssociativeArray<string>
    {

    }
    /// Resource tags.
    internal partial interface ITrackedResourceTagsInternal

    {

    }
}