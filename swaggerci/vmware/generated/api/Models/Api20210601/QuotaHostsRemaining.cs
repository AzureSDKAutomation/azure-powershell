namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>Remaining hosts quota by sku type</summary>
    public partial class QuotaHostsRemaining :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IQuotaHostsRemaining,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IQuotaHostsRemainingInternal
    {

        /// <summary>Creates an new <see cref="QuotaHostsRemaining" /> instance.</summary>
        public QuotaHostsRemaining()
        {

        }
    }
    /// Remaining hosts quota by sku type
    public partial interface IQuotaHostsRemaining :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IAssociativeArray<int>
    {

    }
    /// Remaining hosts quota by sku type
    internal partial interface IQuotaHostsRemainingInternal

    {

    }
}