namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>NSX DNS Service Properties</summary>
    public partial class WorkloadNetworkDnsServiceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServiceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal
    {

        /// <summary>Backing field for <see cref="DefaultDnsZone" /> property.</summary>
        private string _defaultDnsZone;

        /// <summary>Default DNS zone of the DNS Service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string DefaultDnsZone { get => this._defaultDnsZone; set => this._defaultDnsZone = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Display name of the DNS Service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="DnsServiceIP" /> property.</summary>
        private string _dnsServiceIP;

        /// <summary>DNS service IP of the DNS Service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string DnsServiceIP { get => this._dnsServiceIP; set => this._dnsServiceIP = value; }

        /// <summary>Backing field for <see cref="FqdnZone" /> property.</summary>
        private string[] _fqdnZone;

        /// <summary>FQDN zones of the DNS Service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string[] FqdnZone { get => this._fqdnZone; set => this._fqdnZone = value; }

        /// <summary>Backing field for <see cref="LogLevel" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DnsServiceLogLevelEnum? _logLevel;

        /// <summary>DNS Service log level.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DnsServiceLogLevelEnum? LogLevel { get => this._logLevel; set => this._logLevel = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.WorkloadNetworkDnsServiceProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DnsServiceStatusEnum? Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.WorkloadNetworkDnsServiceProvisioningState? _provisioningState;

        /// <summary>The provisioning state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.WorkloadNetworkDnsServiceProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Revision" /> property.</summary>
        private long? _revision;

        /// <summary>NSX revision number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public long? Revision { get => this._revision; set => this._revision = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DnsServiceStatusEnum? _status;

        /// <summary>DNS Service status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DnsServiceStatusEnum? Status { get => this._status; }

        /// <summary>Creates an new <see cref="WorkloadNetworkDnsServiceProperties" /> instance.</summary>
        public WorkloadNetworkDnsServiceProperties()
        {

        }
    }
    /// NSX DNS Service Properties
    public partial interface IWorkloadNetworkDnsServiceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable
    {
        /// <summary>Default DNS zone of the DNS Service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Default DNS zone of the DNS Service.",
        SerializedName = @"defaultDnsZone",
        PossibleTypes = new [] { typeof(string) })]
        string DefaultDnsZone { get; set; }
        /// <summary>Display name of the DNS Service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of the DNS Service.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>DNS service IP of the DNS Service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"DNS service IP of the DNS Service.",
        SerializedName = @"dnsServiceIp",
        PossibleTypes = new [] { typeof(string) })]
        string DnsServiceIP { get; set; }
        /// <summary>FQDN zones of the DNS Service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"FQDN zones of the DNS Service.",
        SerializedName = @"fqdnZones",
        PossibleTypes = new [] { typeof(string) })]
        string[] FqdnZone { get; set; }
        /// <summary>DNS Service log level.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"DNS Service log level.",
        SerializedName = @"logLevel",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DnsServiceLogLevelEnum) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DnsServiceLogLevelEnum? LogLevel { get; set; }
        /// <summary>The provisioning state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.WorkloadNetworkDnsServiceProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.WorkloadNetworkDnsServiceProvisioningState? ProvisioningState { get;  }
        /// <summary>NSX revision number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"NSX revision number.",
        SerializedName = @"revision",
        PossibleTypes = new [] { typeof(long) })]
        long? Revision { get; set; }
        /// <summary>DNS Service status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"DNS Service status.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DnsServiceStatusEnum) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DnsServiceStatusEnum? Status { get;  }

    }
    /// NSX DNS Service Properties
    internal partial interface IWorkloadNetworkDnsServicePropertiesInternal

    {
        /// <summary>Default DNS zone of the DNS Service.</summary>
        string DefaultDnsZone { get; set; }
        /// <summary>Display name of the DNS Service.</summary>
        string DisplayName { get; set; }
        /// <summary>DNS service IP of the DNS Service.</summary>
        string DnsServiceIP { get; set; }
        /// <summary>FQDN zones of the DNS Service.</summary>
        string[] FqdnZone { get; set; }
        /// <summary>DNS Service log level.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DnsServiceLogLevelEnum? LogLevel { get; set; }
        /// <summary>The provisioning state</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.WorkloadNetworkDnsServiceProvisioningState? ProvisioningState { get; set; }
        /// <summary>NSX revision number.</summary>
        long? Revision { get; set; }
        /// <summary>DNS Service status.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DnsServiceStatusEnum? Status { get; set; }

    }
}