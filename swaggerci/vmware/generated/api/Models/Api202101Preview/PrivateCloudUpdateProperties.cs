namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>The properties of a private cloud resource that may be updated</summary>
    public partial class PrivateCloudUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdatePropertiesInternal
    {

        /// <summary>Backing field for <see cref="IdentitySource" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IIdentitySource[] _identitySource;

        /// <summary>vCenter Single Sign On Identity Sources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IIdentitySource[] IdentitySource { get => this._identitySource; set => this._identitySource = value; }

        /// <summary>Backing field for <see cref="Internet" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.InternetEnum? _internet;

        /// <summary>Connectivity to internet is enabled or disabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.InternetEnum? Internet { get => this._internet; set => this._internet = value; }

        /// <summary>Backing field for <see cref="ManagementCluster" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ICommonClusterProperties _managementCluster;

        /// <summary>The default cluster used for management</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ICommonClusterProperties ManagementCluster { get => (this._managementCluster = this._managementCluster ?? new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.CommonClusterProperties()); set => this._managementCluster = value; }

        /// <summary>The hosts</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string[] ManagementClusterHost { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ICommonClusterPropertiesInternal)ManagementCluster).Host; }

        /// <summary>The identity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public int? ManagementClusterId { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ICommonClusterPropertiesInternal)ManagementCluster).ClusterId; }

        /// <summary>The state of the cluster provisioning</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.ClusterProvisioningState? ManagementClusterProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ICommonClusterPropertiesInternal)ManagementCluster).ProvisioningState; }

        /// <summary>The cluster size</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public int? ManagementClusterSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ICommonClusterPropertiesInternal)ManagementCluster).ClusterSize; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ICommonClusterPropertiesInternal)ManagementCluster).ClusterSize = value ?? default(int); }

        /// <summary>Internal Acessors for ManagementCluster</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ICommonClusterProperties Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdatePropertiesInternal.ManagementCluster { get => (this._managementCluster = this._managementCluster ?? new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.CommonClusterProperties()); set { {_managementCluster = value;} } }

        /// <summary>Internal Acessors for ManagementClusterHost</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdatePropertiesInternal.ManagementClusterHost { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ICommonClusterPropertiesInternal)ManagementCluster).Host; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ICommonClusterPropertiesInternal)ManagementCluster).Host = value; }

        /// <summary>Internal Acessors for ManagementClusterId</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdatePropertiesInternal.ManagementClusterId { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ICommonClusterPropertiesInternal)ManagementCluster).ClusterId; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ICommonClusterPropertiesInternal)ManagementCluster).ClusterId = value; }

        /// <summary>Internal Acessors for ManagementClusterProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.ClusterProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdatePropertiesInternal.ManagementClusterProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ICommonClusterPropertiesInternal)ManagementCluster).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ICommonClusterPropertiesInternal)ManagementCluster).ProvisioningState = value; }

        /// <summary>Creates an new <see cref="PrivateCloudUpdateProperties" /> instance.</summary>
        public PrivateCloudUpdateProperties()
        {

        }
    }
    /// The properties of a private cloud resource that may be updated
    public partial interface IPrivateCloudUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable
    {
        /// <summary>vCenter Single Sign On Identity Sources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"vCenter Single Sign On Identity Sources",
        SerializedName = @"identitySources",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IIdentitySource) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IIdentitySource[] IdentitySource { get; set; }
        /// <summary>Connectivity to internet is enabled or disabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Connectivity to internet is enabled or disabled",
        SerializedName = @"internet",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.InternetEnum) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.InternetEnum? Internet { get; set; }
        /// <summary>The hosts</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The hosts",
        SerializedName = @"hosts",
        PossibleTypes = new [] { typeof(string) })]
        string[] ManagementClusterHost { get;  }
        /// <summary>The identity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The identity",
        SerializedName = @"clusterId",
        PossibleTypes = new [] { typeof(int) })]
        int? ManagementClusterId { get;  }
        /// <summary>The state of the cluster provisioning</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The state of the cluster provisioning",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.ClusterProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.ClusterProvisioningState? ManagementClusterProvisioningState { get;  }
        /// <summary>The cluster size</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The cluster size",
        SerializedName = @"clusterSize",
        PossibleTypes = new [] { typeof(int) })]
        int? ManagementClusterSize { get; set; }

    }
    /// The properties of a private cloud resource that may be updated
    internal partial interface IPrivateCloudUpdatePropertiesInternal

    {
        /// <summary>vCenter Single Sign On Identity Sources</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IIdentitySource[] IdentitySource { get; set; }
        /// <summary>Connectivity to internet is enabled or disabled</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.InternetEnum? Internet { get; set; }
        /// <summary>The default cluster used for management</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ICommonClusterProperties ManagementCluster { get; set; }
        /// <summary>The hosts</summary>
        string[] ManagementClusterHost { get; set; }
        /// <summary>The identity</summary>
        int? ManagementClusterId { get; set; }
        /// <summary>The state of the cluster provisioning</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.ClusterProvisioningState? ManagementClusterProvisioningState { get; set; }
        /// <summary>The cluster size</summary>
        int? ManagementClusterSize { get; set; }

    }
}