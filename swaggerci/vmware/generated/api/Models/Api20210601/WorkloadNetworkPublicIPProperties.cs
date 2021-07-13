namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>NSX Public IP Block Properties</summary>
    public partial class WorkloadNetworkPublicIPProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IWorkloadNetworkPublicIPProperties,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IWorkloadNetworkPublicIPPropertiesInternal
    {

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Display name of the Public IP Block.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.WorkloadNetworkPublicIPProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IWorkloadNetworkPublicIPPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for PublicIPBlock</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IWorkloadNetworkPublicIPPropertiesInternal.PublicIPBlock { get => this._publicIPBlock; set { {_publicIPBlock = value;} } }

        /// <summary>Backing field for <see cref="NumberOfPublicIP" /> property.</summary>
        private long? _numberOfPublicIP;

        /// <summary>Number of Public IPs requested.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public long? NumberOfPublicIP { get => this._numberOfPublicIP; set => this._numberOfPublicIP = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.WorkloadNetworkPublicIPProvisioningState? _provisioningState;

        /// <summary>The provisioning state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.WorkloadNetworkPublicIPProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="PublicIPBlock" /> property.</summary>
        private string _publicIPBlock;

        /// <summary>CIDR Block of the Public IP Block.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string PublicIPBlock { get => this._publicIPBlock; }

        /// <summary>Creates an new <see cref="WorkloadNetworkPublicIPProperties" /> instance.</summary>
        public WorkloadNetworkPublicIPProperties()
        {

        }
    }
    /// NSX Public IP Block Properties
    public partial interface IWorkloadNetworkPublicIPProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable
    {
        /// <summary>Display name of the Public IP Block.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of the Public IP Block.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>Number of Public IPs requested.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of Public IPs requested.",
        SerializedName = @"numberOfPublicIPs",
        PossibleTypes = new [] { typeof(long) })]
        long? NumberOfPublicIP { get; set; }
        /// <summary>The provisioning state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.WorkloadNetworkPublicIPProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.WorkloadNetworkPublicIPProvisioningState? ProvisioningState { get;  }
        /// <summary>CIDR Block of the Public IP Block.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"CIDR Block of the Public IP Block.",
        SerializedName = @"publicIPBlock",
        PossibleTypes = new [] { typeof(string) })]
        string PublicIPBlock { get;  }

    }
    /// NSX Public IP Block Properties
    internal partial interface IWorkloadNetworkPublicIPPropertiesInternal

    {
        /// <summary>Display name of the Public IP Block.</summary>
        string DisplayName { get; set; }
        /// <summary>Number of Public IPs requested.</summary>
        long? NumberOfPublicIP { get; set; }
        /// <summary>The provisioning state</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.WorkloadNetworkPublicIPProvisioningState? ProvisioningState { get; set; }
        /// <summary>CIDR Block of the Public IP Block.</summary>
        string PublicIPBlock { get; set; }

    }
}