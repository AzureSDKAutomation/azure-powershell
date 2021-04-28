namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>Resource tags.</summary>
    public partial class TrackedResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ITrackedResourceTags,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ITrackedResourceTagsInternal
    {

        /// <summary>Creates an new <see cref="TrackedResourceTags" /> instance.</summary>
        public TrackedResourceTags()
        {

        }
    }
    /// Resource tags.
    public partial interface ITrackedResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IAssociativeArray<string>
    {

    }
    /// Resource tags.
    internal partial interface ITrackedResourceTagsInternal

    {

    }
}