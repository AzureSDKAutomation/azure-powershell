namespace Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Extensions;

    /// <summary>Resource tags</summary>
    public partial class ResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IResourceTags,
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IResourceTagsInternal
    {

        /// <summary>Creates an new <see cref="ResourceTags" /> instance.</summary>
        public ResourceTags()
        {

        }
    }
    /// Resource tags
    public partial interface IResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.IAssociativeArray<string>
    {

    }
    /// Resource tags
    internal partial interface IResourceTagsInternal

    {

    }
}