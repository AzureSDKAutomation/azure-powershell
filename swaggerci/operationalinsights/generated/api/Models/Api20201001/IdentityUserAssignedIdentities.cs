namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>
    /// The list of user identities associated with the resource. The user identity dictionary key references will be ARM resource
    /// ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
    /// </summary>
    public partial class IdentityUserAssignedIdentities :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentityUserAssignedIdentities,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentityUserAssignedIdentitiesInternal
    {

        /// <summary>Creates an new <see cref="IdentityUserAssignedIdentities" /> instance.</summary>
        public IdentityUserAssignedIdentities()
        {

        }
    }
    /// The list of user identities associated with the resource. The user identity dictionary key references will be ARM resource
    /// ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
    public partial interface IIdentityUserAssignedIdentities :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IAssociativeArray<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IUserIdentityProperties>
    {

    }
    /// The list of user identities associated with the resource. The user identity dictionary key references will be ARM resource
    /// ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
    internal partial interface IIdentityUserAssignedIdentitiesInternal

    {

    }
}