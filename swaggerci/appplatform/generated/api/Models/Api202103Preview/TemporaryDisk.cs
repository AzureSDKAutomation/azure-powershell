namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Temporary disk payload</summary>
    public partial class TemporaryDisk :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ITemporaryDisk,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ITemporaryDiskInternal
    {

        /// <summary>Backing field for <see cref="MountPath" /> property.</summary>
        private string _mountPath;

        /// <summary>Mount path of the temporary disk</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string MountPath { get => this._mountPath; set => this._mountPath = value; }

        /// <summary>Backing field for <see cref="SizeInGb" /> property.</summary>
        private int? _sizeInGb;

        /// <summary>Size of the temporary disk in GB</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public int? SizeInGb { get => this._sizeInGb; set => this._sizeInGb = value; }

        /// <summary>Creates an new <see cref="TemporaryDisk" /> instance.</summary>
        public TemporaryDisk()
        {

        }
    }
    /// Temporary disk payload
    public partial interface ITemporaryDisk :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable
    {
        /// <summary>Mount path of the temporary disk</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Mount path of the temporary disk",
        SerializedName = @"mountPath",
        PossibleTypes = new [] { typeof(string) })]
        string MountPath { get; set; }
        /// <summary>Size of the temporary disk in GB</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Size of the temporary disk in GB",
        SerializedName = @"sizeInGB",
        PossibleTypes = new [] { typeof(int) })]
        int? SizeInGb { get; set; }

    }
    /// Temporary disk payload
    internal partial interface ITemporaryDiskInternal

    {
        /// <summary>Mount path of the temporary disk</summary>
        string MountPath { get; set; }
        /// <summary>Size of the temporary disk in GB</summary>
        int? SizeInGb { get; set; }

    }
}