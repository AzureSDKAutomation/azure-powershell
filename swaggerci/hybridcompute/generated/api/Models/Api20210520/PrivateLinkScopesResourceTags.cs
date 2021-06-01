namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Extensions;

    /// <summary>Resource tags</summary>
    public partial class PrivateLinkScopesResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IPrivateLinkScopesResourceTags,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IPrivateLinkScopesResourceTagsInternal
    {

        /// <summary>Creates an new <see cref="PrivateLinkScopesResourceTags" /> instance.</summary>
        public PrivateLinkScopesResourceTags()
        {

        }
    }
    /// Resource tags
    public partial interface IPrivateLinkScopesResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IAssociativeArray<string>
    {

    }
    /// Resource tags
    internal partial interface IPrivateLinkScopesResourceTagsInternal

    {

    }
}