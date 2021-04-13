namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>NSX DHCP Server</summary>
    public partial class WorkloadNetworkDhcpServer :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpServer,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpServerInternal,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntity"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntity __workloadNetworkDhcpEntity = new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.WorkloadNetworkDhcpEntity();

        /// <summary>Type of DHCP: SERVER or RELAY.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inherited)]
        public string DhcpType { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntityInternal)__workloadNetworkDhcpEntity).DhcpType; }

        /// <summary>Display name of the DHCP entity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inherited)]
        public string DisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntityInternal)__workloadNetworkDhcpEntity).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntityInternal)__workloadNetworkDhcpEntity).DisplayName = value ?? null; }

        /// <summary>Backing field for <see cref="LeaseTime" /> property.</summary>
        private long? _leaseTime;

        /// <summary>DHCP Server Lease Time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public long? LeaseTime { get => this._leaseTime; set => this._leaseTime = value; }

        /// <summary>Internal Acessors for DhcpType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntityInternal.DhcpType { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntityInternal)__workloadNetworkDhcpEntity).DhcpType; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntityInternal)__workloadNetworkDhcpEntity).DhcpType = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.WorkloadNetworkDhcpProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntityInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntityInternal)__workloadNetworkDhcpEntity).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntityInternal)__workloadNetworkDhcpEntity).ProvisioningState = value; }

        /// <summary>Internal Acessors for Segment</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntityInternal.Segment { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntityInternal)__workloadNetworkDhcpEntity).Segment; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntityInternal)__workloadNetworkDhcpEntity).Segment = value; }

        /// <summary>The provisioning state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.WorkloadNetworkDhcpProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntityInternal)__workloadNetworkDhcpEntity).ProvisioningState; }

        /// <summary>NSX revision number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inherited)]
        public long? Revision { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntityInternal)__workloadNetworkDhcpEntity).Revision; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntityInternal)__workloadNetworkDhcpEntity).Revision = value ?? default(long); }

        /// <summary>NSX Segments consuming DHCP.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inherited)]
        public string[] Segment { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntityInternal)__workloadNetworkDhcpEntity).Segment; }

        /// <summary>Backing field for <see cref="ServerAddress" /> property.</summary>
        private string _serverAddress;

        /// <summary>DHCP Server Address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string ServerAddress { get => this._serverAddress; set => this._serverAddress = value; }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__workloadNetworkDhcpEntity), __workloadNetworkDhcpEntity);
            await eventListener.AssertObjectIsValid(nameof(__workloadNetworkDhcpEntity), __workloadNetworkDhcpEntity);
        }

        /// <summary>Creates an new <see cref="WorkloadNetworkDhcpServer" /> instance.</summary>
        public WorkloadNetworkDhcpServer()
        {

        }
    }
    /// NSX DHCP Server
    public partial interface IWorkloadNetworkDhcpServer :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntity
    {
        /// <summary>DHCP Server Lease Time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"DHCP Server Lease Time.",
        SerializedName = @"leaseTime",
        PossibleTypes = new [] { typeof(long) })]
        long? LeaseTime { get; set; }
        /// <summary>DHCP Server Address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"DHCP Server Address.",
        SerializedName = @"serverAddress",
        PossibleTypes = new [] { typeof(string) })]
        string ServerAddress { get; set; }

    }
    /// NSX DHCP Server
    internal partial interface IWorkloadNetworkDhcpServerInternal :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntityInternal
    {
        /// <summary>DHCP Server Lease Time.</summary>
        long? LeaseTime { get; set; }
        /// <summary>DHCP Server Address.</summary>
        string ServerAddress { get; set; }

    }
}