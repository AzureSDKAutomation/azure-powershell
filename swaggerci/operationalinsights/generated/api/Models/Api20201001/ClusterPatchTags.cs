namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>Resource tags.</summary>
    public partial class ClusterPatchTags :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchTags,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchTagsInternal
    {

        /// <summary>Creates an new <see cref="ClusterPatchTags" /> instance.</summary>
        public ClusterPatchTags()
        {

        }
    }
    /// Resource tags.
    public partial interface IClusterPatchTags :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IAssociativeArray<string>
    {

    }
    /// Resource tags.
    internal partial interface IClusterPatchTagsInternal

    {

    }
}