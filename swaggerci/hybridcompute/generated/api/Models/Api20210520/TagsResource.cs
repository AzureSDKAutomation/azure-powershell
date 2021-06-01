namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Extensions;

    /// <summary>
    /// A container holding only the Tags for a resource, allowing the user to update the tags on a PrivateLinkScope instance.
    /// </summary>
    public partial class TagsResource :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.ITagsResource,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.ITagsResourceInternal
    {

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.ITagsResourceTags _tag;

        /// <summary>Resource tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.ITagsResourceTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.TagsResourceTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="TagsResource" /> instance.</summary>
        public TagsResource()
        {

        }
    }
    /// A container holding only the Tags for a resource, allowing the user to update the tags on a PrivateLinkScope instance.
    public partial interface ITagsResource :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IJsonSerializable
    {
        /// <summary>Resource tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.ITagsResourceTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.ITagsResourceTags Tag { get; set; }

    }
    /// A container holding only the Tags for a resource, allowing the user to update the tags on a PrivateLinkScope instance.
    internal partial interface ITagsResourceInternal

    {
        /// <summary>Resource tags</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.ITagsResourceTags Tag { get; set; }

    }
}