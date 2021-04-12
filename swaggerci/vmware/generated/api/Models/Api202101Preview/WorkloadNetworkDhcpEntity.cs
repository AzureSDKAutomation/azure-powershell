namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>
    /// Base class for WorkloadNetworkDhcpServer and WorkloadNetworkDhcpRelay to inherit from
    /// </summary>
    public partial class WorkloadNetworkDhcpEntity :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntity,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntityInternal
    {

        /// <summary>Backing field for <see cref="DhcpType" /> property.</summary>
        private string _dhcpType= @"SERVER, RELAY";

        /// <summary>Type of DHCP: SERVER or RELAY.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string DhcpType { get => this._dhcpType; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Display name of the DHCP entity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Internal Acessors for DhcpType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntityInternal.DhcpType { get => this._dhcpType; set { {_dhcpType = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.WorkloadNetworkDhcpProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntityInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for Segment</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntityInternal.Segment { get => this._segment; set { {_segment = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.WorkloadNetworkDhcpProvisioningState? _provisioningState;

        /// <summary>The provisioning state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.WorkloadNetworkDhcpProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Revision" /> property.</summary>
        private long? _revision;

        /// <summary>NSX revision number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public long? Revision { get => this._revision; set => this._revision = value; }

        /// <summary>Backing field for <see cref="Segment" /> property.</summary>
        private string[] _segment;

        /// <summary>NSX Segments consuming DHCP.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string[] Segment { get => this._segment; }

        /// <summary>Creates an new <see cref="WorkloadNetworkDhcpEntity" /> instance.</summary>
        public WorkloadNetworkDhcpEntity()
        {

        }
    }
    /// Base class for WorkloadNetworkDhcpServer and WorkloadNetworkDhcpRelay to inherit from
    public partial interface IWorkloadNetworkDhcpEntity :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable
    {
        /// <summary>Type of DHCP: SERVER or RELAY.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Description = @"Type of DHCP: SERVER or RELAY.",
        SerializedName = @"dhcpType",
        PossibleTypes = new [] { typeof(string) })]
        string DhcpType { get;  }
        /// <summary>Display name of the DHCP entity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of the DHCP entity.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>The provisioning state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.WorkloadNetworkDhcpProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.WorkloadNetworkDhcpProvisioningState? ProvisioningState { get;  }
        /// <summary>NSX revision number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"NSX revision number.",
        SerializedName = @"revision",
        PossibleTypes = new [] { typeof(long) })]
        long? Revision { get; set; }
        /// <summary>NSX Segments consuming DHCP.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"NSX Segments consuming DHCP.",
        SerializedName = @"segments",
        PossibleTypes = new [] { typeof(string) })]
        string[] Segment { get;  }

    }
    /// Base class for WorkloadNetworkDhcpServer and WorkloadNetworkDhcpRelay to inherit from
    internal partial interface IWorkloadNetworkDhcpEntityInternal

    {
        /// <summary>Type of DHCP: SERVER or RELAY.</summary>
        string DhcpType { get; set; }
        /// <summary>Display name of the DHCP entity.</summary>
        string DisplayName { get; set; }
        /// <summary>The provisioning state</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.WorkloadNetworkDhcpProvisioningState? ProvisioningState { get; set; }
        /// <summary>NSX revision number.</summary>
        long? Revision { get; set; }
        /// <summary>NSX Segments consuming DHCP.</summary>
        string[] Segment { get; set; }

    }
}