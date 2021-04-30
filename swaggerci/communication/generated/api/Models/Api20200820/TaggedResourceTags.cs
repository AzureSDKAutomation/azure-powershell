namespace Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Extensions;

    /// <summary>
    /// Tags of the service which is a list of key value pairs that describe the resource.
    /// </summary>
    public partial class TaggedResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ITaggedResourceTags,
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ITaggedResourceTagsInternal
    {

        /// <summary>Creates an new <see cref="TaggedResourceTags" /> instance.</summary>
        public TaggedResourceTags()
        {

        }
    }
    /// Tags of the service which is a list of key value pairs that describe the resource.
    public partial interface ITaggedResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.IAssociativeArray<string>
    {

    }
    /// Tags of the service which is a list of key value pairs that describe the resource.
    internal partial interface ITaggedResourceTagsInternal

    {

    }
}