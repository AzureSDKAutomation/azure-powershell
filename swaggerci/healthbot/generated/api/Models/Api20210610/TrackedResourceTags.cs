namespace Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20210610
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Runtime.Extensions;

    /// <summary>Resource tags.</summary>
    public partial class TrackedResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20210610.ITrackedResourceTags,
        Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20210610.ITrackedResourceTagsInternal
    {

        /// <summary>Creates an new <see cref="TrackedResourceTags" /> instance.</summary>
        public TrackedResourceTags()
        {

        }
    }
    /// Resource tags.
    public partial interface ITrackedResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Runtime.IAssociativeArray<string>
    {

    }
    /// Resource tags.
    internal partial interface ITrackedResourceTagsInternal

    {

    }
}