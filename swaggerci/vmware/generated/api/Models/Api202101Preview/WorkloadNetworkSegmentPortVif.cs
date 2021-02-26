namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>Ports and any VIF attached to segment.</summary>
    public partial class WorkloadNetworkSegmentPortVif :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkSegmentPortVif,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkSegmentPortVifInternal
    {

        /// <summary>Backing field for <see cref="PortName" /> property.</summary>
        private string _portName;

        /// <summary>Name of port or VIF attached to segment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string PortName { get => this._portName; set => this._portName = value; }

        /// <summary>Creates an new <see cref="WorkloadNetworkSegmentPortVif" /> instance.</summary>
        public WorkloadNetworkSegmentPortVif()
        {

        }
    }
    /// Ports and any VIF attached to segment.
    public partial interface IWorkloadNetworkSegmentPortVif :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable
    {
        /// <summary>Name of port or VIF attached to segment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of port or VIF attached to segment.",
        SerializedName = @"portName",
        PossibleTypes = new [] { typeof(string) })]
        string PortName { get; set; }

    }
    /// Ports and any VIF attached to segment.
    internal partial interface IWorkloadNetworkSegmentPortVifInternal

    {
        /// <summary>Name of port or VIF attached to segment.</summary>
        string PortName { get; set; }

    }
}