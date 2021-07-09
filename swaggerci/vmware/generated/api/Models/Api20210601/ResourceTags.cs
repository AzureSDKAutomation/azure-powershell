namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>Resource tags</summary>
    public partial class ResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceTags,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceTagsInternal
    {

        /// <summary>Creates an new <see cref="ResourceTags" /> instance.</summary>
        public ResourceTags()
        {

        }
    }
    /// Resource tags
    public partial interface IResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IAssociativeArray<string>
    {

    }
    /// Resource tags
    internal partial interface IResourceTagsInternal

    {

    }
}