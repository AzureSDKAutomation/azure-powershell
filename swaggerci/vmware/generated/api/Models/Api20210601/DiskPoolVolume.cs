namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>An iSCSI volume from Microsoft.StoragePool provider</summary>
    public partial class DiskPoolVolume :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IDiskPoolVolume,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IDiskPoolVolumeInternal
    {

        /// <summary>Backing field for <see cref="LunName" /> property.</summary>
        private string _lunName;

        /// <summary>Name of the LUN to be used for datastore</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string LunName { get => this._lunName; set => this._lunName = value; }

        /// <summary>Internal Acessors for Path</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IDiskPoolVolumeInternal.Path { get => this._path; set { {_path = value;} } }

        /// <summary>Backing field for <see cref="MountOption" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.MountOptionEnum? _mountOption;

        /// <summary>
        /// Mode that describes whether the LUN has to be mounted as a datastore or attached as a LUN
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.MountOptionEnum? MountOption { get => this._mountOption; set => this._mountOption = value; }

        /// <summary>Backing field for <see cref="Path" /> property.</summary>
        private string _path;

        /// <summary>Device path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string Path { get => this._path; }

        /// <summary>Backing field for <see cref="TargetId" /> property.</summary>
        private string _targetId;

        /// <summary>Azure resource ID of the iSCSI target</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string TargetId { get => this._targetId; set => this._targetId = value; }

        /// <summary>Creates an new <see cref="DiskPoolVolume" /> instance.</summary>
        public DiskPoolVolume()
        {

        }
    }
    /// An iSCSI volume from Microsoft.StoragePool provider
    public partial interface IDiskPoolVolume :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable
    {
        /// <summary>Name of the LUN to be used for datastore</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Name of the LUN to be used for datastore",
        SerializedName = @"lunName",
        PossibleTypes = new [] { typeof(string) })]
        string LunName { get; set; }
        /// <summary>
        /// Mode that describes whether the LUN has to be mounted as a datastore or attached as a LUN
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Mode that describes whether the LUN has to be mounted as a datastore or attached as a LUN",
        SerializedName = @"mountOption",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.MountOptionEnum) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.MountOptionEnum? MountOption { get; set; }
        /// <summary>Device path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Device path",
        SerializedName = @"path",
        PossibleTypes = new [] { typeof(string) })]
        string Path { get;  }
        /// <summary>Azure resource ID of the iSCSI target</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Azure resource ID of the iSCSI target",
        SerializedName = @"targetId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetId { get; set; }

    }
    /// An iSCSI volume from Microsoft.StoragePool provider
    internal partial interface IDiskPoolVolumeInternal

    {
        /// <summary>Name of the LUN to be used for datastore</summary>
        string LunName { get; set; }
        /// <summary>
        /// Mode that describes whether the LUN has to be mounted as a datastore or attached as a LUN
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.MountOptionEnum? MountOption { get; set; }
        /// <summary>Device path</summary>
        string Path { get; set; }
        /// <summary>Azure resource ID of the iSCSI target</summary>
        string TargetId { get; set; }

    }
}