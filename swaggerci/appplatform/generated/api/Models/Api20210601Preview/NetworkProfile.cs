namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Service network profile payload</summary>
    public partial class NetworkProfile :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.INetworkProfile,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.INetworkProfileInternal
    {

        /// <summary>Backing field for <see cref="AppNetworkResourceGroup" /> property.</summary>
        private string _appNetworkResourceGroup;

        /// <summary>
        /// Name of the resource group containing network resources of Azure Spring Cloud Apps
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string AppNetworkResourceGroup { get => this._appNetworkResourceGroup; set => this._appNetworkResourceGroup = value; }

        /// <summary>Backing field for <see cref="AppSubnetId" /> property.</summary>
        private string _appSubnetId;

        /// <summary>Fully qualified resource Id of the subnet to host Azure Spring Cloud Apps</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string AppSubnetId { get => this._appSubnetId; set => this._appSubnetId = value; }

        /// <summary>Internal Acessors for OutboundIP</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.INetworkProfileOutboundIPs Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.INetworkProfileInternal.OutboundIP { get => (this._outboundIP = this._outboundIP ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.NetworkProfileOutboundIPs()); set { {_outboundIP = value;} } }

        /// <summary>Internal Acessors for OutboundIPPublicIP</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.INetworkProfileInternal.OutboundIPPublicIP { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.INetworkProfileOutboundIPsInternal)OutboundIP).PublicIP; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.INetworkProfileOutboundIPsInternal)OutboundIP).PublicIP = value; }

        /// <summary>Internal Acessors for RequiredTraffic</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IRequiredTraffic[] Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.INetworkProfileInternal.RequiredTraffic { get => this._requiredTraffic; set { {_requiredTraffic = value;} } }

        /// <summary>Backing field for <see cref="OutboundIP" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.INetworkProfileOutboundIPs _outboundIP;

        /// <summary>Desired outbound IP resources for Azure Spring Cloud instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.INetworkProfileOutboundIPs OutboundIP { get => (this._outboundIP = this._outboundIP ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.NetworkProfileOutboundIPs()); }

        /// <summary>A list of public IP addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string[] OutboundIPPublicIP { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.INetworkProfileOutboundIPsInternal)OutboundIP).PublicIP; }

        /// <summary>Backing field for <see cref="RequiredTraffic" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IRequiredTraffic[] _requiredTraffic;

        /// <summary>Required inbound or outbound traffics for Azure Spring Cloud instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IRequiredTraffic[] RequiredTraffic { get => this._requiredTraffic; }

        /// <summary>Backing field for <see cref="ServiceCidr" /> property.</summary>
        private string _serviceCidr;

        /// <summary>Azure Spring Cloud service reserved CIDR</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string ServiceCidr { get => this._serviceCidr; set => this._serviceCidr = value; }

        /// <summary>Backing field for <see cref="ServiceRuntimeNetworkResourceGroup" /> property.</summary>
        private string _serviceRuntimeNetworkResourceGroup;

        /// <summary>
        /// Name of the resource group containing network resources of Azure Spring Cloud Service Runtime
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string ServiceRuntimeNetworkResourceGroup { get => this._serviceRuntimeNetworkResourceGroup; set => this._serviceRuntimeNetworkResourceGroup = value; }

        /// <summary>Backing field for <see cref="ServiceRuntimeSubnetId" /> property.</summary>
        private string _serviceRuntimeSubnetId;

        /// <summary>
        /// Fully qualified resource Id of the subnet to host Azure Spring Cloud Service Runtime
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string ServiceRuntimeSubnetId { get => this._serviceRuntimeSubnetId; set => this._serviceRuntimeSubnetId = value; }

        /// <summary>Creates an new <see cref="NetworkProfile" /> instance.</summary>
        public NetworkProfile()
        {

        }
    }
    /// Service network profile payload
    public partial interface INetworkProfile :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable
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
        string AppNetworkResourceGroup { get; set; }
        /// <summary>Fully qualified resource Id of the subnet to host Azure Spring Cloud Apps</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully qualified resource Id of the subnet to host Azure Spring Cloud Apps",
        SerializedName = @"appSubnetId",
        PossibleTypes = new [] { typeof(string) })]
        string AppSubnetId { get; set; }
        /// <summary>A list of public IP addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A list of public IP addresses.",
        SerializedName = @"publicIPs",
        PossibleTypes = new [] { typeof(string) })]
        string[] OutboundIPPublicIP { get;  }
        /// <summary>Required inbound or outbound traffics for Azure Spring Cloud instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Required inbound or outbound traffics for Azure Spring Cloud instance.",
        SerializedName = @"requiredTraffics",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IRequiredTraffic) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IRequiredTraffic[] RequiredTraffic { get;  }
        /// <summary>Azure Spring Cloud service reserved CIDR</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Azure Spring Cloud service reserved CIDR",
        SerializedName = @"serviceCidr",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceCidr { get; set; }
        /// <summary>
        /// Name of the resource group containing network resources of Azure Spring Cloud Service Runtime
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the resource group containing network resources of Azure Spring Cloud Service Runtime",
        SerializedName = @"serviceRuntimeNetworkResourceGroup",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceRuntimeNetworkResourceGroup { get; set; }
        /// <summary>
        /// Fully qualified resource Id of the subnet to host Azure Spring Cloud Service Runtime
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully qualified resource Id of the subnet to host Azure Spring Cloud Service Runtime",
        SerializedName = @"serviceRuntimeSubnetId",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceRuntimeSubnetId { get; set; }

    }
    /// Service network profile payload
    internal partial interface INetworkProfileInternal

    {
        /// <summary>
        /// Name of the resource group containing network resources of Azure Spring Cloud Apps
        /// </summary>
        string AppNetworkResourceGroup { get; set; }
        /// <summary>Fully qualified resource Id of the subnet to host Azure Spring Cloud Apps</summary>
        string AppSubnetId { get; set; }
        /// <summary>Desired outbound IP resources for Azure Spring Cloud instance.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.INetworkProfileOutboundIPs OutboundIP { get; set; }
        /// <summary>A list of public IP addresses.</summary>
        string[] OutboundIPPublicIP { get; set; }
        /// <summary>Required inbound or outbound traffics for Azure Spring Cloud instance.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IRequiredTraffic[] RequiredTraffic { get; set; }
        /// <summary>Azure Spring Cloud service reserved CIDR</summary>
        string ServiceCidr { get; set; }
        /// <summary>
        /// Name of the resource group containing network resources of Azure Spring Cloud Service Runtime
        /// </summary>
        string ServiceRuntimeNetworkResourceGroup { get; set; }
        /// <summary>
        /// Fully qualified resource Id of the subnet to host Azure Spring Cloud Service Runtime
        /// </summary>
        string ServiceRuntimeSubnetId { get; set; }

    }
}