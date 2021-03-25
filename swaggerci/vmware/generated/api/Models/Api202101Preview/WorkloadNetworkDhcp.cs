namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>NSX DHCP</summary>
    public partial class WorkloadNetworkDhcp :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcp,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpInternal,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.Resource();

        /// <summary>Type of DHCP: SERVER or RELAY.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string DhcpType { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntityInternal)Property).DhcpType; }

        /// <summary>Display name of the DHCP entity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string DisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntityInternal)Property).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntityInternal)Property).DisplayName = value ?? null; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal)__resource).Id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for DhcpType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpInternal.DhcpType { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntityInternal)Property).DhcpType; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntityInternal)Property).DhcpType = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntity Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.WorkloadNetworkDhcpEntity()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.WorkloadNetworkDhcpProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntityInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntityInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Segment</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpInternal.Segment { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntityInternal)Property).Segment; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntityInternal)Property).Segment = value; }

        /// <summary>Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntity _property;

        /// <summary>DHCP properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntity Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.WorkloadNetworkDhcpEntity()); set => this._property = value; }

        /// <summary>The provisioning state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.WorkloadNetworkDhcpProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntityInternal)Property).ProvisioningState; }

        /// <summary>NSX revision number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public long? Revision { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntityInternal)Property).Revision; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntityInternal)Property).Revision = value ?? default(long); }

        /// <summary>NSX Segments consuming DHCP.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string[] Segment { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntityInternal)Property).Segment; }

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal)__resource).Type; }

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

        /// <summary>Creates an new <see cref="WorkloadNetworkDhcp" /> instance.</summary>
        public WorkloadNetworkDhcp()
        {

        }
    }
    /// NSX DHCP
    public partial interface IWorkloadNetworkDhcp :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResource
    {
        /// <summary>Type of DHCP: SERVER or RELAY.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
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
    /// NSX DHCP
    internal partial interface IWorkloadNetworkDhcpInternal :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IResourceInternal
    {
        /// <summary>Type of DHCP: SERVER or RELAY.</summary>
        string DhcpType { get; set; }
        /// <summary>Display name of the DHCP entity.</summary>
        string DisplayName { get; set; }
        /// <summary>DHCP properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDhcpEntity Property { get; set; }
        /// <summary>The provisioning state</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.WorkloadNetworkDhcpProvisioningState? ProvisioningState { get; set; }
        /// <summary>NSX revision number.</summary>
        long? Revision { get; set; }
        /// <summary>NSX Segments consuming DHCP.</summary>
        string[] Segment { get; set; }

    }
}