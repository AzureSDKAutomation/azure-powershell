namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>Properties of a NSX Gateway.</summary>
    public partial class WorkloadNetworkGatewayProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IWorkloadNetworkGatewayProperties,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IWorkloadNetworkGatewayPropertiesInternal
    {

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Display name of the DHCP entity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Internal Acessors for Path</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IWorkloadNetworkGatewayPropertiesInternal.Path { get => this._path; set { {_path = value;} } }

        /// <summary>Backing field for <see cref="Path" /> property.</summary>
        private string _path;

        /// <summary>NSX Gateway Path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string Path { get => this._path; }

        /// <summary>Creates an new <see cref="WorkloadNetworkGatewayProperties" /> instance.</summary>
        public WorkloadNetworkGatewayProperties()
        {

        }
    }
    /// Properties of a NSX Gateway.
    public partial interface IWorkloadNetworkGatewayProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable
    {
        /// <summary>Display name of the DHCP entity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of the DHCP entity.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>NSX Gateway Path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"NSX Gateway Path.",
        SerializedName = @"path",
        PossibleTypes = new [] { typeof(string) })]
        string Path { get;  }

    }
    /// Properties of a NSX Gateway.
    internal partial interface IWorkloadNetworkGatewayPropertiesInternal

    {
        /// <summary>Display name of the DHCP entity.</summary>
        string DisplayName { get; set; }
        /// <summary>NSX Gateway Path.</summary>
        string Path { get; set; }

    }
}