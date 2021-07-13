namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>NSX DNS Zone Properties</summary>
    public partial class WorkloadNetworkDnsZoneProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IWorkloadNetworkDnsZoneProperties,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IWorkloadNetworkDnsZonePropertiesInternal
    {

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Display name of the DNS Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="DnsServerIP" /> property.</summary>
        private string[] _dnsServerIP;

        /// <summary>DNS Server IP array of the DNS Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string[] DnsServerIP { get => this._dnsServerIP; set => this._dnsServerIP = value; }

        /// <summary>Backing field for <see cref="DnsService" /> property.</summary>
        private long? _dnsService;

        /// <summary>Number of DNS Services using the DNS zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public long? DnsService { get => this._dnsService; set => this._dnsService = value; }

        /// <summary>Backing field for <see cref="Domain" /> property.</summary>
        private string[] _domain;

        /// <summary>Domain names of the DNS Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string[] Domain { get => this._domain; set => this._domain = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.WorkloadNetworkDnsZoneProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IWorkloadNetworkDnsZonePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.WorkloadNetworkDnsZoneProvisioningState? _provisioningState;

        /// <summary>The provisioning state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.WorkloadNetworkDnsZoneProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Revision" /> property.</summary>
        private long? _revision;

        /// <summary>NSX revision number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public long? Revision { get => this._revision; set => this._revision = value; }

        /// <summary>Backing field for <see cref="SourceIP" /> property.</summary>
        private string _sourceIP;

        /// <summary>Source IP of the DNS Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string SourceIP { get => this._sourceIP; set => this._sourceIP = value; }

        /// <summary>Creates an new <see cref="WorkloadNetworkDnsZoneProperties" /> instance.</summary>
        public WorkloadNetworkDnsZoneProperties()
        {

        }
    }
    /// NSX DNS Zone Properties
    public partial interface IWorkloadNetworkDnsZoneProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable
    {
        /// <summary>Display name of the DNS Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of the DNS Zone.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>DNS Server IP array of the DNS Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"DNS Server IP array of the DNS Zone.",
        SerializedName = @"dnsServerIps",
        PossibleTypes = new [] { typeof(string) })]
        string[] DnsServerIP { get; set; }
        /// <summary>Number of DNS Services using the DNS zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of DNS Services using the DNS zone.",
        SerializedName = @"dnsServices",
        PossibleTypes = new [] { typeof(long) })]
        long? DnsService { get; set; }
        /// <summary>Domain names of the DNS Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Domain names of the DNS Zone.",
        SerializedName = @"domain",
        PossibleTypes = new [] { typeof(string) })]
        string[] Domain { get; set; }
        /// <summary>The provisioning state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.WorkloadNetworkDnsZoneProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.WorkloadNetworkDnsZoneProvisioningState? ProvisioningState { get;  }
        /// <summary>NSX revision number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"NSX revision number.",
        SerializedName = @"revision",
        PossibleTypes = new [] { typeof(long) })]
        long? Revision { get; set; }
        /// <summary>Source IP of the DNS Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Source IP of the DNS Zone.",
        SerializedName = @"sourceIp",
        PossibleTypes = new [] { typeof(string) })]
        string SourceIP { get; set; }

    }
    /// NSX DNS Zone Properties
    internal partial interface IWorkloadNetworkDnsZonePropertiesInternal

    {
        /// <summary>Display name of the DNS Zone.</summary>
        string DisplayName { get; set; }
        /// <summary>DNS Server IP array of the DNS Zone.</summary>
        string[] DnsServerIP { get; set; }
        /// <summary>Number of DNS Services using the DNS zone.</summary>
        long? DnsService { get; set; }
        /// <summary>Domain names of the DNS Zone.</summary>
        string[] Domain { get; set; }
        /// <summary>The provisioning state</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.WorkloadNetworkDnsZoneProvisioningState? ProvisioningState { get; set; }
        /// <summary>NSX revision number.</summary>
        long? Revision { get; set; }
        /// <summary>Source IP of the DNS Zone.</summary>
        string SourceIP { get; set; }

    }
}