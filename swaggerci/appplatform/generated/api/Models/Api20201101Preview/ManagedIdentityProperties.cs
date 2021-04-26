namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Managed identity properties retrieved from ARM request headers.</summary>
    public partial class ManagedIdentityProperties :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IManagedIdentityProperties,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IManagedIdentityPropertiesInternal
    {

        /// <summary>Backing field for <see cref="PrincipalId" /> property.</summary>
        private string _principalId;

        /// <summary>Principal Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string PrincipalId { get => this._principalId; set => this._principalId = value; }

        /// <summary>Backing field for <see cref="TenantId" /> property.</summary>
        private string _tenantId;

        /// <summary>Tenant Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string TenantId { get => this._tenantId; set => this._tenantId = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ManagedIdentityType? _type;

        /// <summary>Type of the managed identity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ManagedIdentityType? Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="ManagedIdentityProperties" /> instance.</summary>
        public ManagedIdentityProperties()
        {

        }
    }
    /// Managed identity properties retrieved from ARM request headers.
    public partial interface IManagedIdentityProperties :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable
    {
        /// <summary>Principal Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Principal Id",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalId { get; set; }
        /// <summary>Tenant Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Tenant Id",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get; set; }
        /// <summary>Type of the managed identity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the managed identity",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ManagedIdentityType) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ManagedIdentityType? Type { get; set; }

    }
    /// Managed identity properties retrieved from ARM request headers.
    internal partial interface IManagedIdentityPropertiesInternal

    {
        /// <summary>Principal Id</summary>
        string PrincipalId { get; set; }
        /// <summary>Tenant Id</summary>
        string TenantId { get; set; }
        /// <summary>Type of the managed identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ManagedIdentityType? Type { get; set; }

    }
}