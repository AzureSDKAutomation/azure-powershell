namespace Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Extensions;

    /// <summary>Identity for the managed cluster.</summary>
    public partial class ConfigurationIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IConfigurationIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IConfigurationIdentityInternal
    {

        /// <summary>Internal Acessors for PrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IConfigurationIdentityInternal.PrincipalId { get => this._principalId; set { {_principalId = value;} } }

        /// <summary>Internal Acessors for TenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IConfigurationIdentityInternal.TenantId { get => this._tenantId; set { {_tenantId = value;} } }

        /// <summary>Backing field for <see cref="PrincipalId" /> property.</summary>
        private string _principalId;

        /// <summary>
        /// The principal id of the system assigned identity which is used by the configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public string PrincipalId { get => this._principalId; }

        /// <summary>Backing field for <see cref="TenantId" /> property.</summary>
        private string _tenantId;

        /// <summary>
        /// The tenant id of the system assigned identity which is used by the configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public string TenantId { get => this._tenantId; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ResourceIdentityType? _type;

        /// <summary>
        /// The type of identity used for the configuration. Type 'SystemAssigned' will use an implicitly created identity. Type 'None'
        /// will not use Managed Identity for the configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ResourceIdentityType? Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="ConfigurationIdentity" /> instance.</summary>
        public ConfigurationIdentity()
        {

        }
    }
    /// Identity for the managed cluster.
    public partial interface IConfigurationIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The principal id of the system assigned identity which is used by the configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The principal id of the system assigned identity which is used by the configuration.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalId { get;  }
        /// <summary>
        /// The tenant id of the system assigned identity which is used by the configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The tenant id of the system assigned identity which is used by the configuration.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get;  }
        /// <summary>
        /// The type of identity used for the configuration. Type 'SystemAssigned' will use an implicitly created identity. Type 'None'
        /// will not use Managed Identity for the configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity used for the configuration. Type 'SystemAssigned' will use an implicitly created identity. Type 'None' will not use Managed Identity for the configuration.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ResourceIdentityType) })]
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ResourceIdentityType? Type { get; set; }

    }
    /// Identity for the managed cluster.
    internal partial interface IConfigurationIdentityInternal

    {
        /// <summary>
        /// The principal id of the system assigned identity which is used by the configuration.
        /// </summary>
        string PrincipalId { get; set; }
        /// <summary>
        /// The tenant id of the system assigned identity which is used by the configuration.
        /// </summary>
        string TenantId { get; set; }
        /// <summary>
        /// The type of identity used for the configuration. Type 'SystemAssigned' will use an implicitly created identity. Type 'None'
        /// will not use Managed Identity for the configuration.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ResourceIdentityType? Type { get; set; }

    }
}