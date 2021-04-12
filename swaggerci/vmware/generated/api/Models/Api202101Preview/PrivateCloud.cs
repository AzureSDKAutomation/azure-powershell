namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>A private cloud resource</summary>
    public partial class PrivateCloud :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloud,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudInternal,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.TrackedResource();

        /// <summary>Identifier of the ExpressRoute Circuit (Microsoft Colo only)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string CircuitExpressRouteId { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).CircuitExpressRouteId; }

        /// <summary>ExpressRoute Circuit private peering identifier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string CircuitExpressRoutePrivatePeeringId { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).CircuitExpressRoutePrivatePeeringId; }

        /// <summary>CIDR of primary subnet</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string CircuitPrimarySubnet { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).CircuitPrimarySubnet; }

        /// <summary>CIDR of secondary subnet</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string CircuitSecondarySubnet { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).CircuitSecondarySubnet; }

        /// <summary>Endpoint for the HCX Cloud Manager</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string EndpointHcxCloudManager { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).EndpointHcxCloudManager; }

        /// <summary>Endpoint for the NSX-T Data Center manager</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string EndpointNsxtManager { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).EndpointNsxtManager; }

        /// <summary>Endpoint for Virtual Center Server Appliance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string EndpointVcsa { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).EndpointVcsa; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal)__trackedResource).Id; }

        /// <summary>vCenter Single Sign On Identity Sources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IIdentitySource[] IdentitySource { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdatePropertiesInternal)Property).IdentitySource; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdatePropertiesInternal)Property).IdentitySource = value ?? null /* arrayOf */; }

        /// <summary>Connectivity to internet is enabled or disabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.InternetEnum? Internet { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdatePropertiesInternal)Property).Internet; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdatePropertiesInternal)Property).Internet = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.InternetEnum)""); }

        /// <summary>Resource location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ITrackedResourceInternal)__trackedResource).Location = value ?? null; }

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

        /// <summary>Network used to access vCenter Server and NSX-T Manager</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string ManagementNetwork { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).ManagementNetwork; }

        /// <summary>Internal Acessors for Circuit</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ICircuit Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudInternal.Circuit { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).Circuit; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).Circuit = value; }

        /// <summary>Internal Acessors for CircuitExpressRouteId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudInternal.CircuitExpressRouteId { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).CircuitExpressRouteId; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).CircuitExpressRouteId = value; }

        /// <summary>Internal Acessors for CircuitExpressRoutePrivatePeeringId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudInternal.CircuitExpressRoutePrivatePeeringId { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).CircuitExpressRoutePrivatePeeringId; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).CircuitExpressRoutePrivatePeeringId = value; }

        /// <summary>Internal Acessors for CircuitPrimarySubnet</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudInternal.CircuitPrimarySubnet { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).CircuitPrimarySubnet; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).CircuitPrimarySubnet = value; }

        /// <summary>Internal Acessors for CircuitSecondarySubnet</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudInternal.CircuitSecondarySubnet { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).CircuitSecondarySubnet; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).CircuitSecondarySubnet = value; }

        /// <summary>Internal Acessors for Endpoint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IEndpoints Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudInternal.Endpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).Endpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).Endpoint = value; }

        /// <summary>Internal Acessors for EndpointHcxCloudManager</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudInternal.EndpointHcxCloudManager { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).EndpointHcxCloudManager; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).EndpointHcxCloudManager = value; }

        /// <summary>Internal Acessors for EndpointNsxtManager</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudInternal.EndpointNsxtManager { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).EndpointNsxtManager; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).EndpointNsxtManager = value; }

        /// <summary>Internal Acessors for EndpointVcsa</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudInternal.EndpointVcsa { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).EndpointVcsa; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).EndpointVcsa = value; }

        /// <summary>Internal Acessors for ManagementCluster</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ICommonClusterProperties Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudInternal.ManagementCluster { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdatePropertiesInternal)Property).ManagementCluster; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdatePropertiesInternal)Property).ManagementCluster = value; }

        /// <summary>Internal Acessors for ManagementClusterHost</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudInternal.ManagementClusterHost { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdatePropertiesInternal)Property).ManagementClusterHost; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdatePropertiesInternal)Property).ManagementClusterHost = value; }

        /// <summary>Internal Acessors for ManagementClusterId</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudInternal.ManagementClusterId { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdatePropertiesInternal)Property).ManagementClusterId; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdatePropertiesInternal)Property).ManagementClusterId = value; }

        /// <summary>Internal Acessors for ManagementClusterProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.ClusterProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudInternal.ManagementClusterProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdatePropertiesInternal)Property).ManagementClusterProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudUpdatePropertiesInternal)Property).ManagementClusterProvisioningState = value; }

        /// <summary>Internal Acessors for ManagementNetwork</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudInternal.ManagementNetwork { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).ManagementNetwork; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).ManagementNetwork = value; }

        /// <summary>Internal Acessors for NsxtCertificateThumbprint</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudInternal.NsxtCertificateThumbprint { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).NsxtCertificateThumbprint; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).NsxtCertificateThumbprint = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudProperties Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.PrivateCloudProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningNetwork</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudInternal.ProvisioningNetwork { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).ProvisioningNetwork; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).ProvisioningNetwork = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.PrivateCloudProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ISku Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.Sku()); set { {_sku = value;} } }

        /// <summary>Internal Acessors for VcenterCertificateThumbprint</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudInternal.VcenterCertificateThumbprint { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).VcenterCertificateThumbprint; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).VcenterCertificateThumbprint = value; }

        /// <summary>Internal Acessors for VmotionNetwork</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudInternal.VmotionNetwork { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).VmotionNetwork; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).VmotionNetwork = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal)__trackedResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal)__trackedResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal)__trackedResource).Type = value; }

        /// <summary>Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal)__trackedResource).Name; }

        /// <summary>
        /// The block of addresses should be unique across VNet in your subscription as well as on-premise. Make sure the CIDR format
        /// is conformed to (A.B.C.D/X) where A,B,C,D are between 0 and 255, and X is between 0 and 22
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string NetworkBlock { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).NetworkBlock; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).NetworkBlock = value ?? null; }

        /// <summary>Thumbprint of the NSX-T Manager SSL certificate</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string NsxtCertificateThumbprint { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).NsxtCertificateThumbprint; }

        /// <summary>Optionally, set the NSX-T Manager password when the private cloud is created</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string NsxtPassword { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).NsxtPassword; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).NsxtPassword = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudProperties _property;

        /// <summary>The properties of a private cloud resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.PrivateCloudProperties()); set => this._property = value; }

        /// <summary>Used for virtual machine cold migration, cloning, and snapshot migration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string ProvisioningNetwork { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).ProvisioningNetwork; }

        /// <summary>The provisioning state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.PrivateCloudProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ISku _sku;

        /// <summary>The private cloud SKU</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ISku Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.Sku()); set => this._sku = value; }

        /// <summary>The name of the SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ISkuInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ISkuInternal)Sku).Name = value ; }

        /// <summary>Resource tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal)__trackedResource).Type; }

        /// <summary>Thumbprint of the vCenter Server SSL certificate</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string VcenterCertificateThumbprint { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).VcenterCertificateThumbprint; }

        /// <summary>Optionally, set the vCenter admin password when the private cloud is created</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string VcenterPassword { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).VcenterPassword; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).VcenterPassword = value ?? null; }

        /// <summary>Used for live migration of virtual machines</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string VmotionNetwork { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudPropertiesInternal)Property).VmotionNetwork; }

        /// <summary>Creates an new <see cref="PrivateCloud" /> instance.</summary>
        public PrivateCloud()
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
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// A private cloud resource
    public partial interface IPrivateCloud :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ITrackedResource
    {
        /// <summary>Identifier of the ExpressRoute Circuit (Microsoft Colo only)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Identifier of the ExpressRoute Circuit (Microsoft Colo only)",
        SerializedName = @"expressRouteID",
        PossibleTypes = new [] { typeof(string) })]
        string CircuitExpressRouteId { get;  }
        /// <summary>ExpressRoute Circuit private peering identifier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"ExpressRoute Circuit private peering identifier",
        SerializedName = @"expressRoutePrivatePeeringID",
        PossibleTypes = new [] { typeof(string) })]
        string CircuitExpressRoutePrivatePeeringId { get;  }
        /// <summary>CIDR of primary subnet</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"CIDR of primary subnet",
        SerializedName = @"primarySubnet",
        PossibleTypes = new [] { typeof(string) })]
        string CircuitPrimarySubnet { get;  }
        /// <summary>CIDR of secondary subnet</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"CIDR of secondary subnet",
        SerializedName = @"secondarySubnet",
        PossibleTypes = new [] { typeof(string) })]
        string CircuitSecondarySubnet { get;  }
        /// <summary>Endpoint for the HCX Cloud Manager</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Endpoint for the HCX Cloud Manager",
        SerializedName = @"hcxCloudManager",
        PossibleTypes = new [] { typeof(string) })]
        string EndpointHcxCloudManager { get;  }
        /// <summary>Endpoint for the NSX-T Data Center manager</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Endpoint for the NSX-T Data Center manager",
        SerializedName = @"nsxtManager",
        PossibleTypes = new [] { typeof(string) })]
        string EndpointNsxtManager { get;  }
        /// <summary>Endpoint for Virtual Center Server Appliance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Endpoint for Virtual Center Server Appliance",
        SerializedName = @"vcsa",
        PossibleTypes = new [] { typeof(string) })]
        string EndpointVcsa { get;  }
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
        /// <summary>Network used to access vCenter Server and NSX-T Manager</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Network used to access vCenter Server and NSX-T Manager",
        SerializedName = @"managementNetwork",
        PossibleTypes = new [] { typeof(string) })]
        string ManagementNetwork { get;  }
        /// <summary>
        /// The block of addresses should be unique across VNet in your subscription as well as on-premise. Make sure the CIDR format
        /// is conformed to (A.B.C.D/X) where A,B,C,D are between 0 and 255, and X is between 0 and 22
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The block of addresses should be unique across VNet in your subscription as well as on-premise. Make sure the CIDR format is conformed to (A.B.C.D/X) where A,B,C,D are between 0 and 255, and X is between 0 and 22",
        SerializedName = @"networkBlock",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkBlock { get; set; }
        /// <summary>Thumbprint of the NSX-T Manager SSL certificate</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Thumbprint of the NSX-T Manager SSL certificate",
        SerializedName = @"nsxtCertificateThumbprint",
        PossibleTypes = new [] { typeof(string) })]
        string NsxtCertificateThumbprint { get;  }
        /// <summary>Optionally, set the NSX-T Manager password when the private cloud is created</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Optionally, set the NSX-T Manager password when the private cloud is created",
        SerializedName = @"nsxtPassword",
        PossibleTypes = new [] { typeof(string) })]
        string NsxtPassword { get; set; }
        /// <summary>Used for virtual machine cold migration, cloning, and snapshot migration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Used for virtual machine cold migration, cloning, and snapshot migration",
        SerializedName = @"provisioningNetwork",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningNetwork { get;  }
        /// <summary>The provisioning state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.PrivateCloudProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.PrivateCloudProvisioningState? ProvisioningState { get;  }
        /// <summary>The name of the SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the SKU.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string SkuName { get; set; }
        /// <summary>Thumbprint of the vCenter Server SSL certificate</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Thumbprint of the vCenter Server SSL certificate",
        SerializedName = @"vcenterCertificateThumbprint",
        PossibleTypes = new [] { typeof(string) })]
        string VcenterCertificateThumbprint { get;  }
        /// <summary>Optionally, set the vCenter admin password when the private cloud is created</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Optionally, set the vCenter admin password when the private cloud is created",
        SerializedName = @"vcenterPassword",
        PossibleTypes = new [] { typeof(string) })]
        string VcenterPassword { get; set; }
        /// <summary>Used for live migration of virtual machines</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Used for live migration of virtual machines",
        SerializedName = @"vmotionNetwork",
        PossibleTypes = new [] { typeof(string) })]
        string VmotionNetwork { get;  }

    }
    /// A private cloud resource
    internal partial interface IPrivateCloudInternal :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ITrackedResourceInternal
    {
        /// <summary>An ExpressRoute Circuit</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ICircuit Circuit { get; set; }
        /// <summary>Identifier of the ExpressRoute Circuit (Microsoft Colo only)</summary>
        string CircuitExpressRouteId { get; set; }
        /// <summary>ExpressRoute Circuit private peering identifier</summary>
        string CircuitExpressRoutePrivatePeeringId { get; set; }
        /// <summary>CIDR of primary subnet</summary>
        string CircuitPrimarySubnet { get; set; }
        /// <summary>CIDR of secondary subnet</summary>
        string CircuitSecondarySubnet { get; set; }
        /// <summary>The endpoints</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IEndpoints Endpoint { get; set; }
        /// <summary>Endpoint for the HCX Cloud Manager</summary>
        string EndpointHcxCloudManager { get; set; }
        /// <summary>Endpoint for the NSX-T Data Center manager</summary>
        string EndpointNsxtManager { get; set; }
        /// <summary>Endpoint for Virtual Center Server Appliance</summary>
        string EndpointVcsa { get; set; }
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
        /// <summary>Network used to access vCenter Server and NSX-T Manager</summary>
        string ManagementNetwork { get; set; }
        /// <summary>
        /// The block of addresses should be unique across VNet in your subscription as well as on-premise. Make sure the CIDR format
        /// is conformed to (A.B.C.D/X) where A,B,C,D are between 0 and 255, and X is between 0 and 22
        /// </summary>
        string NetworkBlock { get; set; }
        /// <summary>Thumbprint of the NSX-T Manager SSL certificate</summary>
        string NsxtCertificateThumbprint { get; set; }
        /// <summary>Optionally, set the NSX-T Manager password when the private cloud is created</summary>
        string NsxtPassword { get; set; }
        /// <summary>The properties of a private cloud resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IPrivateCloudProperties Property { get; set; }
        /// <summary>Used for virtual machine cold migration, cloning, and snapshot migration</summary>
        string ProvisioningNetwork { get; set; }
        /// <summary>The provisioning state</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.PrivateCloudProvisioningState? ProvisioningState { get; set; }
        /// <summary>The private cloud SKU</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ISku Sku { get; set; }
        /// <summary>The name of the SKU.</summary>
        string SkuName { get; set; }
        /// <summary>Thumbprint of the vCenter Server SSL certificate</summary>
        string VcenterCertificateThumbprint { get; set; }
        /// <summary>Optionally, set the vCenter admin password when the private cloud is created</summary>
        string VcenterPassword { get; set; }
        /// <summary>Used for live migration of virtual machines</summary>
        string VmotionNetwork { get; set; }

    }
}