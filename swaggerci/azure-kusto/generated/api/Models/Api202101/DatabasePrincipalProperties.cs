namespace Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api202101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Extensions;

    /// <summary>A class representing database principal property.</summary>
    public partial class DatabasePrincipalProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api202101.IDatabasePrincipalProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api202101.IDatabasePrincipalPropertiesInternal
    {

        /// <summary>Internal Acessors for PrincipalName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api202101.IDatabasePrincipalPropertiesInternal.PrincipalName { get => this._principalName; set { {_principalName = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api202101.IDatabasePrincipalPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for TenantName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api202101.IDatabasePrincipalPropertiesInternal.TenantName { get => this._tenantName; set { {_tenantName = value;} } }

        /// <summary>Backing field for <see cref="PrincipalId" /> property.</summary>
        private string _principalId;

        /// <summary>
        /// The principal ID assigned to the database principal. It can be a user email, application ID, or security group name.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        public string PrincipalId { get => this._principalId; set => this._principalId = value; }

        /// <summary>Backing field for <see cref="PrincipalName" /> property.</summary>
        private string _principalName;

        /// <summary>The principal name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        public string PrincipalName { get => this._principalName; }

        /// <summary>Backing field for <see cref="PrincipalType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.PrincipalType _principalType;

        /// <summary>Principal type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.PrincipalType PrincipalType { get => this._principalType; set => this._principalType = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState? _provisioningState;

        /// <summary>The provisioned state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Role" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabasePrincipalRole _role;

        /// <summary>Database principal role.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabasePrincipalRole Role { get => this._role; set => this._role = value; }

        /// <summary>Backing field for <see cref="TenantId" /> property.</summary>
        private string _tenantId;

        /// <summary>The tenant id of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        public string TenantId { get => this._tenantId; set => this._tenantId = value; }

        /// <summary>Backing field for <see cref="TenantName" /> property.</summary>
        private string _tenantName;

        /// <summary>The tenant name of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        public string TenantName { get => this._tenantName; }

        /// <summary>Creates an new <see cref="DatabasePrincipalProperties" /> instance.</summary>
        public DatabasePrincipalProperties()
        {

        }
    }
    /// A class representing database principal property.
    public partial interface IDatabasePrincipalProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The principal ID assigned to the database principal. It can be a user email, application ID, or security group name.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The principal ID assigned to the database principal. It can be a user email, application ID, or security group name.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalId { get; set; }
        /// <summary>The principal name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The principal name",
        SerializedName = @"principalName",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalName { get;  }
        /// <summary>Principal type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Principal type.",
        SerializedName = @"principalType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.PrincipalType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.PrincipalType PrincipalType { get; set; }
        /// <summary>The provisioned state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioned state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>Database principal role.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Database principal role.",
        SerializedName = @"role",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabasePrincipalRole) })]
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabasePrincipalRole Role { get; set; }
        /// <summary>The tenant id of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tenant id of the principal",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get; set; }
        /// <summary>The tenant name of the principal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The tenant name of the principal",
        SerializedName = @"tenantName",
        PossibleTypes = new [] { typeof(string) })]
        string TenantName { get;  }

    }
    /// A class representing database principal property.
    internal partial interface IDatabasePrincipalPropertiesInternal

    {
        /// <summary>
        /// The principal ID assigned to the database principal. It can be a user email, application ID, or security group name.
        /// </summary>
        string PrincipalId { get; set; }
        /// <summary>The principal name</summary>
        string PrincipalName { get; set; }
        /// <summary>Principal type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.PrincipalType PrincipalType { get; set; }
        /// <summary>The provisioned state of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>Database principal role.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabasePrincipalRole Role { get; set; }
        /// <summary>The tenant id of the principal</summary>
        string TenantId { get; set; }
        /// <summary>The tenant name of the principal</summary>
        string TenantName { get; set; }

    }
}