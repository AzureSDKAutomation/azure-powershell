namespace Microsoft.Azure.PowerShell.Cmdlets.Operations.Models.Api20151101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Operations.Runtime.Extensions;

    /// <summary>Resource tags</summary>
    public partial class SolutionPatchTags :
        Microsoft.Azure.PowerShell.Cmdlets.Operations.Models.Api20151101Preview.ISolutionPatchTags,
        Microsoft.Azure.PowerShell.Cmdlets.Operations.Models.Api20151101Preview.ISolutionPatchTagsInternal
    {

        /// <summary>Creates an new <see cref="SolutionPatchTags" /> instance.</summary>
        public SolutionPatchTags()
        {

        }
    }
    /// Resource tags
    public partial interface ISolutionPatchTags :
        Microsoft.Azure.PowerShell.Cmdlets.Operations.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Operations.Runtime.IAssociativeArray<string>
    {

    }
    /// Resource tags
    internal partial interface ISolutionPatchTagsInternal

    {

    }
}