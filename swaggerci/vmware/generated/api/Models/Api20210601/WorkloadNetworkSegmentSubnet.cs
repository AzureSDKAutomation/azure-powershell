namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>Subnet configuration for segment</summary>
    public partial class WorkloadNetworkSegmentSubnet :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IWorkloadNetworkSegmentSubnet,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IWorkloadNetworkSegmentSubnetInternal
    {

        /// <summary>Backing field for <see cref="DhcpRange" /> property.</summary>
        private string[] _dhcpRange;

        /// <summary>DHCP Range assigned for subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string[] DhcpRange { get => this._dhcpRange; set => this._dhcpRange = value; }

        /// <summary>Backing field for <see cref="GatewayAddress" /> property.</summary>
        private string _gatewayAddress;

        /// <summary>Gateway address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string GatewayAddress { get => this._gatewayAddress; set => this._gatewayAddress = value; }

        /// <summary>Creates an new <see cref="WorkloadNetworkSegmentSubnet" /> instance.</summary>
        public WorkloadNetworkSegmentSubnet()
        {

        }
    }
    /// Subnet configuration for segment
    public partial interface IWorkloadNetworkSegmentSubnet :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable
    {
        /// <summary>DHCP Range assigned for subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"DHCP Range assigned for subnet.",
        SerializedName = @"dhcpRanges",
        PossibleTypes = new [] { typeof(string) })]
        string[] DhcpRange { get; set; }
        /// <summary>Gateway address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gateway address.",
        SerializedName = @"gatewayAddress",
        PossibleTypes = new [] { typeof(string) })]
        string GatewayAddress { get; set; }

    }
    /// Subnet configuration for segment
    internal partial interface IWorkloadNetworkSegmentSubnetInternal

    {
        /// <summary>DHCP Range assigned for subnet.</summary>
        string[] DhcpRange { get; set; }
        /// <summary>Gateway address.</summary>
        string GatewayAddress { get; set; }

    }
}