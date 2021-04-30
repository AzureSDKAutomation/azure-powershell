namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Extensions;

    /// <summary>
    /// The list of user-assigned identities associated with the resource. The user-assigned identity dictionary keys will be
    /// ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
    /// </summary>
    public partial class ResourceIdentityUserAssignedIdentities :
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IResourceIdentityUserAssignedIdentities,
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IResourceIdentityUserAssignedIdentitiesInternal
    {

        /// <summary>Creates an new <see cref="ResourceIdentityUserAssignedIdentities" /> instance.</summary>
        public ResourceIdentityUserAssignedIdentities()
        {

        }
    }
    /// The list of user-assigned identities associated with the resource. The user-assigned identity dictionary keys will be
    /// ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
    public partial interface IResourceIdentityUserAssignedIdentities :
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IAssociativeArray<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IUserIdentity>
    {

    }
    /// The list of user-assigned identities associated with the resource. The user-assigned identity dictionary keys will be
    /// ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
    internal partial interface IResourceIdentityUserAssignedIdentitiesInternal

    {

    }
}