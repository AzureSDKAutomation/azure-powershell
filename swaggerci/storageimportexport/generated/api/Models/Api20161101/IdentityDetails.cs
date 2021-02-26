namespace Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Extensions;

    /// <summary>Specifies the identity properties.</summary>
    public partial class IdentityDetails :
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IIdentityDetails,
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IIdentityDetailsInternal
    {

        /// <summary>Internal Acessors for PrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IIdentityDetailsInternal.PrincipalId { get => this._principalId; set { {_principalId = value;} } }

        /// <summary>Internal Acessors for TenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IIdentityDetailsInternal.TenantId { get => this._tenantId; set { {_tenantId = value;} } }

        /// <summary>Backing field for <see cref="PrincipalId" /> property.</summary>
        private string _principalId;

        /// <summary>Specifies the principal id for the identity for the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Owned)]
        public string PrincipalId { get => this._principalId; }

        /// <summary>Backing field for <see cref="TenantId" /> property.</summary>
        private string _tenantId;

        /// <summary>Specifies the tenant id for the identity for the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Owned)]
        public string TenantId { get => this._tenantId; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Support.IdentityType? _type;

        /// <summary>The type of identity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Support.IdentityType? Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="IdentityDetails" /> instance.</summary>
        public IdentityDetails()
        {

        }
    }
    /// Specifies the identity properties.
    public partial interface IIdentityDetails :
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.IJsonSerializable
    {
        /// <summary>Specifies the principal id for the identity for the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Specifies the principal id for the identity for the job. ",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalId { get;  }
        /// <summary>Specifies the tenant id for the identity for the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Specifies the tenant id for the identity for the job. ",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get;  }
        /// <summary>The type of identity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Support.IdentityType) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Support.IdentityType? Type { get; set; }

    }
    /// Specifies the identity properties.
    internal partial interface IIdentityDetailsInternal

    {
        /// <summary>Specifies the principal id for the identity for the job.</summary>
        string PrincipalId { get; set; }
        /// <summary>Specifies the tenant id for the identity for the job.</summary>
        string TenantId { get; set; }
        /// <summary>The type of identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Support.IdentityType? Type { get; set; }

    }
}