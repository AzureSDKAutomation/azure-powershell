namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>Resource tags. Optional.</summary>
    public partial class WorkspacePatchTags :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePatchTags,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePatchTagsInternal
    {

        /// <summary>Creates an new <see cref="WorkspacePatchTags" /> instance.</summary>
        public WorkspacePatchTags()
        {

        }
    }
    /// Resource tags. Optional.
    public partial interface IWorkspacePatchTags :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IAssociativeArray<string>
    {

    }
    /// Resource tags. Optional.
    internal partial interface IWorkspacePatchTagsInternal

    {

    }
}