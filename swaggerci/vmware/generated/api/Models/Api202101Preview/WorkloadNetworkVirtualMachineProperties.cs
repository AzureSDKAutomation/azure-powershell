namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>NSX Virtual Machine Properties</summary>
    public partial class WorkloadNetworkVirtualMachineProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkVirtualMachineProperties,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkVirtualMachinePropertiesInternal
    {

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Display name of the VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Internal Acessors for VMType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.VMTypeEnum? Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkVirtualMachinePropertiesInternal.VMType { get => this._vMType; set { {_vMType = value;} } }

        /// <summary>Backing field for <see cref="VMType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.VMTypeEnum? _vMType;

        /// <summary>Virtual machine type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.VMTypeEnum? VMType { get => this._vMType; }

        /// <summary>Creates an new <see cref="WorkloadNetworkVirtualMachineProperties" /> instance.</summary>
        public WorkloadNetworkVirtualMachineProperties()
        {

        }
    }
    /// NSX Virtual Machine Properties
    public partial interface IWorkloadNetworkVirtualMachineProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable
    {
        /// <summary>Display name of the VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of the VM.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>Virtual machine type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Virtual machine type.",
        SerializedName = @"vmType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.VMTypeEnum) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.VMTypeEnum? VMType { get;  }

    }
    /// NSX Virtual Machine Properties
    internal partial interface IWorkloadNetworkVirtualMachinePropertiesInternal

    {
        /// <summary>Display name of the VM.</summary>
        string DisplayName { get; set; }
        /// <summary>Virtual machine type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.VMTypeEnum? VMType { get; set; }

    }
}