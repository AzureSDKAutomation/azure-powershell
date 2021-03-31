namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>An Azure NetApp Files volume from Microsoft.NetApp provider</summary>
    public partial class NetAppVolume :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.INetAppVolume,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.INetAppVolumeInternal
    {

        /// <summary>Backing field for <see cref="NfsFilePath" /> property.</summary>
        private string _nfsFilePath;

        /// <summary>File path through which the NFS volume is exposed by the provider</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string NfsFilePath { get => this._nfsFilePath; set => this._nfsFilePath = value; }

        /// <summary>Backing field for <see cref="NfsProviderIP" /> property.</summary>
        private string _nfsProviderIP;

        /// <summary>IP address of the NFS provider</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string NfsProviderIP { get => this._nfsProviderIP; set => this._nfsProviderIP = value; }

        /// <summary>Creates an new <see cref="NetAppVolume" /> instance.</summary>
        public NetAppVolume()
        {

        }
    }
    /// An Azure NetApp Files volume from Microsoft.NetApp provider
    public partial interface INetAppVolume :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable
    {
        /// <summary>File path through which the NFS volume is exposed by the provider</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"File path through which the NFS volume is exposed by the provider",
        SerializedName = @"nfsFilePath",
        PossibleTypes = new [] { typeof(string) })]
        string NfsFilePath { get; set; }
        /// <summary>IP address of the NFS provider</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"IP address of the NFS provider",
        SerializedName = @"nfsProviderIp",
        PossibleTypes = new [] { typeof(string) })]
        string NfsProviderIP { get; set; }

    }
    /// An Azure NetApp Files volume from Microsoft.NetApp provider
    internal partial interface INetAppVolumeInternal

    {
        /// <summary>File path through which the NFS volume is exposed by the provider</summary>
        string NfsFilePath { get; set; }
        /// <summary>IP address of the NFS provider</summary>
        string NfsProviderIP { get; set; }

    }
}