namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>A cluster resource</summary>
    public partial class Cluster :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ICluster,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IClusterInternal,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.Resource();

        /// <summary>The identity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public int? ClusterId { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ICommonClusterPropertiesInternal)Property).ClusterId; }

        /// <summary>The hosts</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string[] Host { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ICommonClusterPropertiesInternal)Property).Host; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)__resource).Id; }

        /// <summary>Internal Acessors for ClusterId</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IClusterInternal.ClusterId { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ICommonClusterPropertiesInternal)Property).ClusterId; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ICommonClusterPropertiesInternal)Property).ClusterId = value; }

        /// <summary>Internal Acessors for Host</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IClusterInternal.Host { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ICommonClusterPropertiesInternal)Property).Host; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ICommonClusterPropertiesInternal)Property).Host = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ICommonClusterProperties Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IClusterInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.CommonClusterProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.ClusterProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IClusterInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ICommonClusterPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ICommonClusterPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ISku Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IClusterInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.Sku()); set { {_sku = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)__resource).Type = value; }

        /// <summary>Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ICommonClusterProperties _property;

        /// <summary>The properties of a cluster resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ICommonClusterProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.CommonClusterProperties()); set => this._property = value; }

        /// <summary>The state of the cluster provisioning</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.ClusterProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ICommonClusterPropertiesInternal)Property).ProvisioningState; }

        /// <summary>The cluster size</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public int? Size { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ICommonClusterPropertiesInternal)Property).ClusterSize; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ICommonClusterPropertiesInternal)Property).ClusterSize = value ?? default(int); }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ISku _sku;

        /// <summary>The cluster SKU</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ISku Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.Sku()); set => this._sku = value; }

        /// <summary>The name of the SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ISkuInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ISkuInternal)Sku).Name = value ; }

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="Cluster" /> instance.</summary>
        public Cluster()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// A cluster resource
    public partial interface ICluster :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResource
    {
        /// <summary>The identity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The identity",
        SerializedName = @"clusterId",
        PossibleTypes = new [] { typeof(int) })]
        int? ClusterId { get;  }
        /// <summary>The hosts</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The hosts",
        SerializedName = @"hosts",
        PossibleTypes = new [] { typeof(string) })]
        string[] Host { get;  }
        /// <summary>The state of the cluster provisioning</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The state of the cluster provisioning",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.ClusterProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.ClusterProvisioningState? ProvisioningState { get;  }
        /// <summary>The cluster size</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The cluster size",
        SerializedName = @"clusterSize",
        PossibleTypes = new [] { typeof(int) })]
        int? Size { get; set; }
        /// <summary>The name of the SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the SKU.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string SkuName { get; set; }

    }
    /// A cluster resource
    internal partial interface IClusterInternal :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal
    {
        /// <summary>The identity</summary>
        int? ClusterId { get; set; }
        /// <summary>The hosts</summary>
        string[] Host { get; set; }
        /// <summary>The properties of a cluster resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ICommonClusterProperties Property { get; set; }
        /// <summary>The state of the cluster provisioning</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.ClusterProvisioningState? ProvisioningState { get; set; }
        /// <summary>The cluster size</summary>
        int? Size { get; set; }
        /// <summary>The cluster SKU</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ISku Sku { get; set; }
        /// <summary>The name of the SKU.</summary>
        string SkuName { get; set; }

    }
}