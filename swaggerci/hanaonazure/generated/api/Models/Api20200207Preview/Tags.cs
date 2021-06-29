namespace Microsoft.Azure.PowerShell.Cmdlets.Hana.Models.Api20200207Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Hana.Runtime.Extensions;

    /// <summary>Tags field of the resource.</summary>
    public partial class Tags :
        Microsoft.Azure.PowerShell.Cmdlets.Hana.Models.Api20200207Preview.ITags,
        Microsoft.Azure.PowerShell.Cmdlets.Hana.Models.Api20200207Preview.ITagsInternal
    {

        /// <summary>Creates an new <see cref="Tags" /> instance.</summary>
        public Tags()
        {

        }
    }
    /// Tags field of the resource.
    public partial interface ITags :
        Microsoft.Azure.PowerShell.Cmdlets.Hana.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Hana.Runtime.IAssociativeArray<string>
    {

    }
    /// Tags field of the resource.
    internal partial interface ITagsInternal

    {

    }
}