namespace Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Extensions;

    /// <summary>The managed identity for the DigitalTwinsInstance.</summary>
    public partial class DigitalTwinsIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsIdentityInternal
    {

        /// <summary>Internal Acessors for PrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsIdentityInternal.PrincipalId { get => this._principalId; set { {_principalId = value;} } }

        /// <summary>Internal Acessors for TenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsIdentityInternal.TenantId { get => this._tenantId; set { {_tenantId = value;} } }

        /// <summary>Backing field for <see cref="PrincipalId" /> property.</summary>
        private string _principalId;

        /// <summary>
        /// The object id of the Managed Identity Resource. This will be sent to the RP from ARM via the x-ms-identity-principal-id
        /// header in the PUT request if the resource has a systemAssigned(implicit) identity
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        public string PrincipalId { get => this._principalId; }

        /// <summary>Backing field for <see cref="TenantId" /> property.</summary>
        private string _tenantId;

        /// <summary>
        /// The tenant id of the Managed Identity Resource. This will be sent to the RP from ARM via the x-ms-client-tenant-id header
        /// in the PUT request if the resource has a systemAssigned(implicit) identity
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        public string TenantId { get => this._tenantId; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.DigitalTwinsIdentityType? _type;

        /// <summary>
        /// The type of Managed Identity used by the DigitalTwinsInstance. Only SystemAssigned is supported.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.DigitalTwinsIdentityType? Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="DigitalTwinsIdentity" /> instance.</summary>
        public DigitalTwinsIdentity()
        {

        }
    }
    /// The managed identity for the DigitalTwinsInstance.
    public partial interface IDigitalTwinsIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The object id of the Managed Identity Resource. This will be sent to the RP from ARM via the x-ms-identity-principal-id
        /// header in the PUT request if the resource has a systemAssigned(implicit) identity
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The object id of the Managed Identity Resource. This will be sent to the RP from ARM via the x-ms-identity-principal-id header in the PUT request if the resource has a systemAssigned(implicit) identity",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalId { get;  }
        /// <summary>
        /// The tenant id of the Managed Identity Resource. This will be sent to the RP from ARM via the x-ms-client-tenant-id header
        /// in the PUT request if the resource has a systemAssigned(implicit) identity
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The tenant id of the Managed Identity Resource. This will be sent to the RP from ARM via the x-ms-client-tenant-id header in the PUT request if the resource has a systemAssigned(implicit) identity",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get;  }
        /// <summary>
        /// The type of Managed Identity used by the DigitalTwinsInstance. Only SystemAssigned is supported.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of Managed Identity used by the DigitalTwinsInstance. Only SystemAssigned is supported.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.DigitalTwinsIdentityType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.DigitalTwinsIdentityType? Type { get; set; }

    }
    /// The managed identity for the DigitalTwinsInstance.
    internal partial interface IDigitalTwinsIdentityInternal

    {
        /// <summary>
        /// The object id of the Managed Identity Resource. This will be sent to the RP from ARM via the x-ms-identity-principal-id
        /// header in the PUT request if the resource has a systemAssigned(implicit) identity
        /// </summary>
        string PrincipalId { get; set; }
        /// <summary>
        /// The tenant id of the Managed Identity Resource. This will be sent to the RP from ARM via the x-ms-client-tenant-id header
        /// in the PUT request if the resource has a systemAssigned(implicit) identity
        /// </summary>
        string TenantId { get; set; }
        /// <summary>
        /// The type of Managed Identity used by the DigitalTwinsInstance. Only SystemAssigned is supported.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.DigitalTwinsIdentityType? Type { get; set; }

    }
}