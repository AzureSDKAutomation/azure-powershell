namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>An Azure NetApp Files volume from Microsoft.NetApp provider</summary>
    public partial class NetAppVolume :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.INetAppVolume,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.INetAppVolumeInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Azure resource ID of the NetApp volume</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Creates an new <see cref="NetAppVolume" /> instance.</summary>
        public NetAppVolume()
        {

        }
    }
    /// An Azure NetApp Files volume from Microsoft.NetApp provider
    public partial interface INetAppVolume :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable
    {
        /// <summary>Azure resource ID of the NetApp volume</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Azure resource ID of the NetApp volume",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

    }
    /// An Azure NetApp Files volume from Microsoft.NetApp provider
    internal partial interface INetAppVolumeInternal

    {
        /// <summary>Azure resource ID of the NetApp volume</summary>
        string Id { get; set; }

    }
}