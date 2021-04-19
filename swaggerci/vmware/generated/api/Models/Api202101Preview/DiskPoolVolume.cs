namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>An iSCSI volume from Microsoft.StoragePool provider</summary>
    public partial class DiskPoolVolume :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IDiskPoolVolume,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IDiskPoolVolumeInternal
    {

        /// <summary>Backing field for <see cref="Endpoint" /> property.</summary>
        private string[] _endpoint;

        /// <summary>iSCSI provider target IP address list</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string[] Endpoint { get => this._endpoint; set => this._endpoint = value; }

        /// <summary>Backing field for <see cref="LunName" /> property.</summary>
        private string _lunName;

        /// <summary>Name of the LUN to be used</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string LunName { get => this._lunName; set => this._lunName = value; }

        /// <summary>Creates an new <see cref="DiskPoolVolume" /> instance.</summary>
        public DiskPoolVolume()
        {

        }
    }
    /// An iSCSI volume from Microsoft.StoragePool provider
    public partial interface IDiskPoolVolume :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable
    {
        /// <summary>iSCSI provider target IP address list</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"iSCSI provider target IP address list",
        SerializedName = @"endpoints",
        PossibleTypes = new [] { typeof(string) })]
        string[] Endpoint { get; set; }
        /// <summary>Name of the LUN to be used</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the LUN to be used",
        SerializedName = @"lunName",
        PossibleTypes = new [] { typeof(string) })]
        string LunName { get; set; }

    }
    /// An iSCSI volume from Microsoft.StoragePool provider
    internal partial interface IDiskPoolVolumeInternal

    {
        /// <summary>iSCSI provider target IP address list</summary>
        string[] Endpoint { get; set; }
        /// <summary>Name of the LUN to be used</summary>
        string LunName { get; set; }

    }
}