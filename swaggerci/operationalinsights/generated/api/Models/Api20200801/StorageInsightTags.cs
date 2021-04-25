namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>Resource tags.</summary>
    public partial class StorageInsightTags :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightTags,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightTagsInternal
    {

        /// <summary>Creates an new <see cref="StorageInsightTags" /> instance.</summary>
        public StorageInsightTags()
        {

        }
    }
    /// Resource tags.
    public partial interface IStorageInsightTags :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IAssociativeArray<string>
    {

    }
    /// Resource tags.
    internal partial interface IStorageInsightTagsInternal

    {

    }
}