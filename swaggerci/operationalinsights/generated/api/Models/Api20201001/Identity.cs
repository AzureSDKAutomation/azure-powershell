namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>Identity for the resource.</summary>
    public partial class Identity :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentityInternal
    {

        /// <summary>Internal Acessors for PrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentityInternal.PrincipalId { get => this._principalId; set { {_principalId = value;} } }

        /// <summary>Internal Acessors for TenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentityInternal.TenantId { get => this._tenantId; set { {_tenantId = value;} } }

        /// <summary>Backing field for <see cref="PrincipalId" /> property.</summary>
        private string _principalId;

        /// <summary>The principal ID of resource identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string PrincipalId { get => this._principalId; }

        /// <summary>Backing field for <see cref="TenantId" /> property.</summary>
        private string _tenantId;

        /// <summary>The tenant ID of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string TenantId { get => this._tenantId; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.IdentityType _type;

        /// <summary>Type of managed service identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.IdentityType Type { get => this._type; set => this._type = value; }

        /// <summary>Backing field for <see cref="UserAssignedIdentity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentityUserAssignedIdentities _userAssignedIdentity;

        /// <summary>
        /// The list of user identities associated with the resource. The user identity dictionary key references will be ARM resource
        /// ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentityUserAssignedIdentities UserAssignedIdentity { get => (this._userAssignedIdentity = this._userAssignedIdentity ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IdentityUserAssignedIdentities()); set => this._userAssignedIdentity = value; }

        /// <summary>Creates an new <see cref="Identity" /> instance.</summary>
        public Identity()
        {

        }
    }
    /// Identity for the resource.
    public partial interface IIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>The principal ID of resource identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The principal ID of resource identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalId { get;  }
        /// <summary>The tenant ID of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The tenant ID of resource.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get;  }
        /// <summary>Type of managed service identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Type of managed service identity.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.IdentityType) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.IdentityType Type { get; set; }
        /// <summary>
        /// The list of user identities associated with the resource. The user identity dictionary key references will be ARM resource
        /// ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of user identities associated with the resource. The user identity dictionary key references will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentityUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentityUserAssignedIdentities UserAssignedIdentity { get; set; }

    }
    /// Identity for the resource.
    internal partial interface IIdentityInternal

    {
        /// <summary>The principal ID of resource identity.</summary>
        string PrincipalId { get; set; }
        /// <summary>The tenant ID of resource.</summary>
        string TenantId { get; set; }
        /// <summary>Type of managed service identity.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.IdentityType Type { get; set; }
        /// <summary>
        /// The list of user identities associated with the resource. The user identity dictionary key references will be ARM resource
        /// ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentityUserAssignedIdentities UserAssignedIdentity { get; set; }

    }
}