namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>An update to a private cloud resource</summary>
    public partial class PrivateCloudUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdateInternal
    {

        /// <summary>vCenter Single Sign On Identity Sources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IIdentitySource[] IdentitySource { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdatePropertiesInternal)Property).IdentitySource; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdatePropertiesInternal)Property).IdentitySource = value ?? null /* arrayOf */; }

        /// <summary>Connectivity to internet is enabled or disabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.InternetEnum? Internet { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdatePropertiesInternal)Property).Internet; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdatePropertiesInternal)Property).Internet = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.InternetEnum)""); }

        /// <summary>The hosts</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string[] ManagementClusterHost { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdatePropertiesInternal)Property).ManagementClusterHost; }

        /// <summary>The identity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public int? ManagementClusterId { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdatePropertiesInternal)Property).ManagementClusterId; }

        /// <summary>The state of the cluster provisioning</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.ClusterProvisioningState? ManagementClusterProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdatePropertiesInternal)Property).ManagementClusterProvisioningState; }

        /// <summary>The cluster size</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public int? ManagementClusterSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdatePropertiesInternal)Property).ManagementClusterSize; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdatePropertiesInternal)Property).ManagementClusterSize = value ?? default(int); }

        /// <summary>Internal Acessors for ManagementCluster</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ICommonClusterProperties Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdateInternal.ManagementCluster { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdatePropertiesInternal)Property).ManagementCluster; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdatePropertiesInternal)Property).ManagementCluster = value; }

        /// <summary>Internal Acessors for ManagementClusterHost</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdateInternal.ManagementClusterHost { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdatePropertiesInternal)Property).ManagementClusterHost; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdatePropertiesInternal)Property).ManagementClusterHost = value; }

        /// <summary>Internal Acessors for ManagementClusterId</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdateInternal.ManagementClusterId { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdatePropertiesInternal)Property).ManagementClusterId; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdatePropertiesInternal)Property).ManagementClusterId = value; }

        /// <summary>Internal Acessors for ManagementClusterProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.ClusterProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdateInternal.ManagementClusterProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdatePropertiesInternal)Property).ManagementClusterProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdatePropertiesInternal)Property).ManagementClusterProvisioningState = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdateProperties Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.PrivateCloudUpdateProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdateProperties _property;

        /// <summary>The updatable properties of a private cloud resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.PrivateCloudUpdateProperties()); set => this._property = value; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceTags _tag;

        /// <summary>Resource tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ResourceTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="PrivateCloudUpdate" /> instance.</summary>
        public PrivateCloudUpdate()
        {

        }
    }
    /// An update to a private cloud resource
    public partial interface IPrivateCloudUpdate :
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
        /// <summary>Resource tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceTags Tag { get; set; }

    }
    /// An update to a private cloud resource
    internal partial interface IPrivateCloudUpdateInternal

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
        /// <summary>The updatable properties of a private cloud resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdateProperties Property { get; set; }
        /// <summary>Resource tags</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceTags Tag { get; set; }

    }
}