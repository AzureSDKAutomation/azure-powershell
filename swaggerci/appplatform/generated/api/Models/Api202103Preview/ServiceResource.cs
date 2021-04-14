namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Service resource</summary>
    public partial class ServiceResource :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IServiceResource,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IServiceResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.TrackedResource();

        /// <summary>Fully qualified resource Id for the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IResourceInternal)__trackedResource).Id; }

        /// <summary>The GEO location of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ITrackedResourceInternal)__trackedResource).Location = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IResourceInternal)__trackedResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IResourceInternal)__trackedResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IResourceInternal)__trackedResource).Type = value; }

        /// <summary>Internal Acessors for NetworkProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.INetworkProfile Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IServiceResourceInternal.NetworkProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IClusterResourcePropertiesInternal)Property).NetworkProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IClusterResourcePropertiesInternal)Property).NetworkProfile = value; }

        /// <summary>Internal Acessors for NetworkProfileOutboundIP</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.INetworkProfileOutboundIPs Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IServiceResourceInternal.NetworkProfileOutboundIP { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IClusterResourcePropertiesInternal)Property).NetworkProfileOutboundIP; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IClusterResourcePropertiesInternal)Property).NetworkProfileOutboundIP = value; }

        /// <summary>Internal Acessors for NetworkProfileRequiredTraffic</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IRequiredTraffic[] Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IServiceResourceInternal.NetworkProfileRequiredTraffic { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IClusterResourcePropertiesInternal)Property).NetworkProfileRequiredTraffic; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IClusterResourcePropertiesInternal)Property).NetworkProfileRequiredTraffic = value; }

        /// <summary>Internal Acessors for OutboundIPPublicIP</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IServiceResourceInternal.OutboundIPPublicIP { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IClusterResourcePropertiesInternal)Property).OutboundIPPublicIP; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IClusterResourcePropertiesInternal)Property).OutboundIPPublicIP = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IClusterResourceProperties Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IServiceResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ClusterResourceProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IServiceResourceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IClusterResourcePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IClusterResourcePropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for ServiceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IServiceResourceInternal.ServiceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IClusterResourcePropertiesInternal)Property).ServiceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IClusterResourcePropertiesInternal)Property).ServiceId = value; }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ISku Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IServiceResourceInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.Sku()); set { {_sku = value;} } }

        /// <summary>Internal Acessors for Version</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IServiceResourceInternal.Version { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IClusterResourcePropertiesInternal)Property).Version; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IClusterResourcePropertiesInternal)Property).Version = value; }

        /// <summary>The name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IResourceInternal)__trackedResource).Name; }

        /// <summary>
        /// Name of the resource group containing network resources of Azure Spring Cloud Apps
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string NetworkProfileAppNetworkResourceGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IClusterResourcePropertiesInternal)Property).NetworkProfileAppNetworkResourceGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IClusterResourcePropertiesInternal)Property).NetworkProfileAppNetworkResourceGroup = value ?? null; }

        /// <summary>Fully qualified resource Id of the subnet to host Azure Spring Cloud Apps</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string NetworkProfileAppSubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IClusterResourcePropertiesInternal)Property).NetworkProfileAppSubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IClusterResourcePropertiesInternal)Property).NetworkProfileAppSubnetId = value ?? null; }

        /// <summary>Required inbound or outbound traffics for Azure Spring Cloud instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IRequiredTraffic[] NetworkProfileRequiredTraffic { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IClusterResourcePropertiesInternal)Property).NetworkProfileRequiredTraffic; }

        /// <summary>Azure Spring Cloud service reserved CIDR</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string NetworkProfileServiceCidr { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IClusterResourcePropertiesInternal)Property).NetworkProfileServiceCidr; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IClusterResourcePropertiesInternal)Property).NetworkProfileServiceCidr = value ?? null; }

        /// <summary>
        /// Name of the resource group containing network resources of Azure Spring Cloud Service Runtime
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string NetworkProfileServiceRuntimeNetworkResourceGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IClusterResourcePropertiesInternal)Property).NetworkProfileServiceRuntimeNetworkResourceGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IClusterResourcePropertiesInternal)Property).NetworkProfileServiceRuntimeNetworkResourceGroup = value ?? null; }

        /// <summary>
        /// Fully qualified resource Id of the subnet to host Azure Spring Cloud Service Runtime
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string NetworkProfileServiceRuntimeSubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IClusterResourcePropertiesInternal)Property).NetworkProfileServiceRuntimeSubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IClusterResourcePropertiesInternal)Property).NetworkProfileServiceRuntimeSubnetId = value ?? null; }

        /// <summary>A list of public IP addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string[] OutboundIPPublicIP { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IClusterResourcePropertiesInternal)Property).OutboundIPPublicIP; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IClusterResourceProperties _property;

        /// <summary>Properties of the Service resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IClusterResourceProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ClusterResourceProperties()); set => this._property = value; }

        /// <summary>Provisioning state of the Service</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IClusterResourcePropertiesInternal)Property).ProvisioningState; }

        /// <summary>ServiceInstanceEntity GUID which uniquely identifies a created resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string ServiceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IClusterResourcePropertiesInternal)Property).ServiceId; }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ISku _sku;

        /// <summary>Sku of the Service resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ISku Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.Sku()); set => this._sku = value; }

        /// <summary>Current capacity of the target resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public int? SkuCapacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ISkuInternal)Sku).Capacity; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ISkuInternal)Sku).Capacity = value ?? default(int); }

        /// <summary>Name of the Sku</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ISkuInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ISkuInternal)Sku).Name = value ?? null; }

        /// <summary>Tier of the Sku</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string SkuTier { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ISkuInternal)Sku).Tier; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ISkuInternal)Sku).Tier = value ?? null; }

        /// <summary>
        /// Tags of the service which is a list of key value pairs that describe the resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>The type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IResourceInternal)__trackedResource).Type; }

        /// <summary>Version of the Service</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public int? Version { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IClusterResourcePropertiesInternal)Property).Version; }

        /// <summary>Creates an new <see cref="ServiceResource" /> instance.</summary>
        public ServiceResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// Service resource
    public partial interface IServiceResource :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ITrackedResource
    {
        /// <summary>
        /// Name of the resource group containing network resources of Azure Spring Cloud Apps
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the resource group containing network resources of Azure Spring Cloud Apps",
        SerializedName = @"appNetworkResourceGroup",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkProfileAppNetworkResourceGroup { get; set; }
        /// <summary>Fully qualified resource Id of the subnet to host Azure Spring Cloud Apps</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully qualified resource Id of the subnet to host Azure Spring Cloud Apps",
        SerializedName = @"appSubnetId",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkProfileAppSubnetId { get; set; }
        /// <summary>Required inbound or outbound traffics for Azure Spring Cloud instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Required inbound or outbound traffics for Azure Spring Cloud instance.",
        SerializedName = @"requiredTraffics",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IRequiredTraffic) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IRequiredTraffic[] NetworkProfileRequiredTraffic { get;  }
        /// <summary>Azure Spring Cloud service reserved CIDR</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Azure Spring Cloud service reserved CIDR",
        SerializedName = @"serviceCidr",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkProfileServiceCidr { get; set; }
        /// <summary>
        /// Name of the resource group containing network resources of Azure Spring Cloud Service Runtime
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the resource group containing network resources of Azure Spring Cloud Service Runtime",
        SerializedName = @"serviceRuntimeNetworkResourceGroup",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkProfileServiceRuntimeNetworkResourceGroup { get; set; }
        /// <summary>
        /// Fully qualified resource Id of the subnet to host Azure Spring Cloud Service Runtime
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully qualified resource Id of the subnet to host Azure Spring Cloud Service Runtime",
        SerializedName = @"serviceRuntimeSubnetId",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkProfileServiceRuntimeSubnetId { get; set; }
        /// <summary>A list of public IP addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A list of public IP addresses.",
        SerializedName = @"publicIPs",
        PossibleTypes = new [] { typeof(string) })]
        string[] OutboundIPPublicIP { get;  }
        /// <summary>Provisioning state of the Service</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning state of the Service",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>ServiceInstanceEntity GUID which uniquely identifies a created resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"ServiceInstanceEntity GUID which uniquely identifies a created resource",
        SerializedName = @"serviceId",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceId { get;  }
        /// <summary>Current capacity of the target resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Current capacity of the target resource",
        SerializedName = @"capacity",
        PossibleTypes = new [] { typeof(int) })]
        int? SkuCapacity { get; set; }
        /// <summary>Name of the Sku</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the Sku",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string SkuName { get; set; }
        /// <summary>Tier of the Sku</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Tier of the Sku",
        SerializedName = @"tier",
        PossibleTypes = new [] { typeof(string) })]
        string SkuTier { get; set; }
        /// <summary>Version of the Service</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Version of the Service",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(int) })]
        int? Version { get;  }

    }
    /// Service resource
    internal partial interface IServiceResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ITrackedResourceInternal
    {
        /// <summary>Network profile of the Service</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.INetworkProfile NetworkProfile { get; set; }
        /// <summary>
        /// Name of the resource group containing network resources of Azure Spring Cloud Apps
        /// </summary>
        string NetworkProfileAppNetworkResourceGroup { get; set; }
        /// <summary>Fully qualified resource Id of the subnet to host Azure Spring Cloud Apps</summary>
        string NetworkProfileAppSubnetId { get; set; }
        /// <summary>Desired outbound IP resources for Azure Spring Cloud instance.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.INetworkProfileOutboundIPs NetworkProfileOutboundIP { get; set; }
        /// <summary>Required inbound or outbound traffics for Azure Spring Cloud instance.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IRequiredTraffic[] NetworkProfileRequiredTraffic { get; set; }
        /// <summary>Azure Spring Cloud service reserved CIDR</summary>
        string NetworkProfileServiceCidr { get; set; }
        /// <summary>
        /// Name of the resource group containing network resources of Azure Spring Cloud Service Runtime
        /// </summary>
        string NetworkProfileServiceRuntimeNetworkResourceGroup { get; set; }
        /// <summary>
        /// Fully qualified resource Id of the subnet to host Azure Spring Cloud Service Runtime
        /// </summary>
        string NetworkProfileServiceRuntimeSubnetId { get; set; }
        /// <summary>A list of public IP addresses.</summary>
        string[] OutboundIPPublicIP { get; set; }
        /// <summary>Properties of the Service resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IClusterResourceProperties Property { get; set; }
        /// <summary>Provisioning state of the Service</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>ServiceInstanceEntity GUID which uniquely identifies a created resource</summary>
        string ServiceId { get; set; }
        /// <summary>Sku of the Service resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ISku Sku { get; set; }
        /// <summary>Current capacity of the target resource</summary>
        int? SkuCapacity { get; set; }
        /// <summary>Name of the Sku</summary>
        string SkuName { get; set; }
        /// <summary>Tier of the Sku</summary>
        string SkuTier { get; set; }
        /// <summary>Version of the Service</summary>
        int? Version { get; set; }

    }
}