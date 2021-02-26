namespace Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Extensions;

    /// <summary>Properties of the OuContainer.</summary>
    public partial class OuContainerProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Account" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IContainerAccount[] _account;

        /// <summary>The list of container accounts</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IContainerAccount[] Account { get => this._account; set => this._account = value; }

        /// <summary>Backing field for <see cref="ContainerId" /> property.</summary>
        private string _containerId;

        /// <summary>The OuContainer name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public string ContainerId { get => this._containerId; }

        /// <summary>Backing field for <see cref="DeploymentId" /> property.</summary>
        private string _deploymentId;

        /// <summary>The Deployment id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public string DeploymentId { get => this._deploymentId; }

        /// <summary>Backing field for <see cref="DistinguishedName" /> property.</summary>
        private string _distinguishedName;

        /// <summary>Distinguished Name of OuContainer instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public string DistinguishedName { get => this._distinguishedName; }

        /// <summary>Backing field for <see cref="DomainName" /> property.</summary>
        private string _domainName;

        /// <summary>The domain name of Domain Services.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public string DomainName { get => this._domainName; }

        /// <summary>Internal Acessors for ContainerId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerPropertiesInternal.ContainerId { get => this._containerId; set { {_containerId = value;} } }

        /// <summary>Internal Acessors for DeploymentId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerPropertiesInternal.DeploymentId { get => this._deploymentId; set { {_deploymentId = value;} } }

        /// <summary>Internal Acessors for DistinguishedName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerPropertiesInternal.DistinguishedName { get => this._distinguishedName; set { {_distinguishedName = value;} } }

        /// <summary>Internal Acessors for DomainName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerPropertiesInternal.DomainName { get => this._domainName; set { {_domainName = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for ServiceStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerPropertiesInternal.ServiceStatus { get => this._serviceStatus; set { {_serviceStatus = value;} } }

        /// <summary>Internal Acessors for TenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainerPropertiesInternal.TenantId { get => this._tenantId; set { {_tenantId = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>
        /// The current deployment or provisioning state, which only appears in the response.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="ServiceStatus" /> property.</summary>
        private string _serviceStatus;

        /// <summary>Status of OuContainer instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public string ServiceStatus { get => this._serviceStatus; }

        /// <summary>Backing field for <see cref="TenantId" /> property.</summary>
        private string _tenantId;

        /// <summary>Azure Active Directory tenant id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public string TenantId { get => this._tenantId; }

        /// <summary>Creates an new <see cref="OuContainerProperties" /> instance.</summary>
        public OuContainerProperties()
        {

        }
    }
    /// Properties of the OuContainer.
    public partial interface IOuContainerProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.IJsonSerializable
    {
        /// <summary>The list of container accounts</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of container accounts",
        SerializedName = @"accounts",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IContainerAccount) })]
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IContainerAccount[] Account { get; set; }
        /// <summary>The OuContainer name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The OuContainer name",
        SerializedName = @"containerId",
        PossibleTypes = new [] { typeof(string) })]
        string ContainerId { get;  }
        /// <summary>The Deployment id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The Deployment id",
        SerializedName = @"deploymentId",
        PossibleTypes = new [] { typeof(string) })]
        string DeploymentId { get;  }
        /// <summary>Distinguished Name of OuContainer instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Distinguished Name of OuContainer instance",
        SerializedName = @"distinguishedName",
        PossibleTypes = new [] { typeof(string) })]
        string DistinguishedName { get;  }
        /// <summary>The domain name of Domain Services.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The domain name of Domain Services.",
        SerializedName = @"domainName",
        PossibleTypes = new [] { typeof(string) })]
        string DomainName { get;  }
        /// <summary>
        /// The current deployment or provisioning state, which only appears in the response.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The current deployment or provisioning state, which only appears in the response.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get;  }
        /// <summary>Status of OuContainer instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Status of OuContainer instance",
        SerializedName = @"serviceStatus",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceStatus { get;  }
        /// <summary>Azure Active Directory tenant id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Azure Active Directory tenant id",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get;  }

    }
    /// Properties of the OuContainer.
    internal partial interface IOuContainerPropertiesInternal

    {
        /// <summary>The list of container accounts</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IContainerAccount[] Account { get; set; }
        /// <summary>The OuContainer name</summary>
        string ContainerId { get; set; }
        /// <summary>The Deployment id</summary>
        string DeploymentId { get; set; }
        /// <summary>Distinguished Name of OuContainer instance</summary>
        string DistinguishedName { get; set; }
        /// <summary>The domain name of Domain Services.</summary>
        string DomainName { get; set; }
        /// <summary>
        /// The current deployment or provisioning state, which only appears in the response.
        /// </summary>
        string ProvisioningState { get; set; }
        /// <summary>Status of OuContainer instance</summary>
        string ServiceStatus { get; set; }
        /// <summary>Azure Active Directory tenant id</summary>
        string TenantId { get; set; }

    }
}