namespace Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Runtime.Extensions;

    /// <summary>Gets or sets the Resource tags.</summary>
    public partial class UpdateMoveCollectionRequestTags :
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101.IUpdateMoveCollectionRequestTags,
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101.IUpdateMoveCollectionRequestTagsInternal
    {

        /// <summary>Creates an new <see cref="UpdateMoveCollectionRequestTags" /> instance.</summary>
        public UpdateMoveCollectionRequestTags()
        {

        }
    }
    /// Gets or sets the Resource tags.
    public partial interface IUpdateMoveCollectionRequestTags :
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Runtime.IAssociativeArray<string>
    {

    }
    /// Gets or sets the Resource tags.
    internal partial interface IUpdateMoveCollectionRequestTagsInternal

    {

    }
}