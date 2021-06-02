namespace Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Extensions;

    /// <summary>An ARM resource with that can accept tags</summary>
    public partial class TaggedResource :
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ITaggedResource,
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ITaggedResourceInternal
    {

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ITaggedResourceTags _tag;

        /// <summary>
        /// Tags of the service which is a list of key value pairs that describe the resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ITaggedResourceTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.TaggedResourceTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="TaggedResource" /> instance.</summary>
        public TaggedResource()
        {

        }
    }
    /// An ARM resource with that can accept tags
    public partial interface ITaggedResource :
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Tags of the service which is a list of key value pairs that describe the resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Tags of the service which is a list of key value pairs that describe the resource.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ITaggedResourceTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ITaggedResourceTags Tag { get; set; }

    }
    /// An ARM resource with that can accept tags
    internal partial interface ITaggedResourceInternal

    {
        /// <summary>
        /// Tags of the service which is a list of key value pairs that describe the resource.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ITaggedResourceTags Tag { get; set; }

    }
}