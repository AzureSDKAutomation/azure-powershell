namespace Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Runtime.Extensions;

    /// <summary>
    /// The list of user identities associated with the resource. The user identity dictionary key references will be ARM resource
    /// ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
    /// </summary>
    public partial class IdentityUserAssignedIdentities :
        Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IIdentityUserAssignedIdentities,
        Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IIdentityUserAssignedIdentitiesInternal
    {

        /// <summary>Creates an new <see cref="IdentityUserAssignedIdentities" /> instance.</summary>
        public IdentityUserAssignedIdentities()
        {

        }
    }
    /// The list of user identities associated with the resource. The user identity dictionary key references will be ARM resource
    /// ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
    public partial interface IIdentityUserAssignedIdentities :
        Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Runtime.IAssociativeArray<Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IIdentityUserAssignedIdentitiesValue>
    {

    }
    /// The list of user identities associated with the resource. The user identity dictionary key references will be ARM resource
    /// ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
    internal partial interface IIdentityUserAssignedIdentitiesInternal

    {

    }
}