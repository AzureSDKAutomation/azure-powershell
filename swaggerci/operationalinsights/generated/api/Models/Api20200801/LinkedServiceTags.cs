namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>Resource tags.</summary>
    public partial class LinkedServiceTags :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceTags,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceTagsInternal
    {

        /// <summary>Creates an new <see cref="LinkedServiceTags" /> instance.</summary>
        public LinkedServiceTags()
        {

        }
    }
    /// Resource tags.
    public partial interface ILinkedServiceTags :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IAssociativeArray<string>
    {

    }
    /// Resource tags.
    internal partial interface ILinkedServiceTagsInternal

    {

    }
}