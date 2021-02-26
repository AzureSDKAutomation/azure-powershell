namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>The properties of a datastore</summary>
    public partial class DatastoreProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IDatastoreProperties,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IDatastorePropertiesInternal
    {

        /// <summary>Backing field for <see cref="DiskPoolVolume" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IDiskPoolVolume _diskPoolVolume;

        /// <summary>An iSCSI volume</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IDiskPoolVolume DiskPoolVolume { get => (this._diskPoolVolume = this._diskPoolVolume ?? new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.DiskPoolVolume()); set => this._diskPoolVolume = value; }

        /// <summary>iSCSI provider target IP address list</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string[] DiskPoolVolumeEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IDiskPoolVolumeInternal)DiskPoolVolume).Endpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IDiskPoolVolumeInternal)DiskPoolVolume).Endpoint = value ?? null /* arrayOf */; }

        /// <summary>Name of the LUN to be used</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string DiskPoolVolumeLunName { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IDiskPoolVolumeInternal)DiskPoolVolume).LunName; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IDiskPoolVolumeInternal)DiskPoolVolume).LunName = value ?? null; }

        /// <summary>Internal Acessors for DiskPoolVolume</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IDiskPoolVolume Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IDatastorePropertiesInternal.DiskPoolVolume { get => (this._diskPoolVolume = this._diskPoolVolume ?? new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.DiskPoolVolume()); set { {_diskPoolVolume = value;} } }

        /// <summary>Internal Acessors for NetAppVolume</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.INetAppVolume Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IDatastorePropertiesInternal.NetAppVolume { get => (this._netAppVolume = this._netAppVolume ?? new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.NetAppVolume()); set { {_netAppVolume = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DatastoreProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IDatastorePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="NetAppVolume" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.INetAppVolume _netAppVolume;

        /// <summary>An Azure NetApp Files volume</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.INetAppVolume NetAppVolume { get => (this._netAppVolume = this._netAppVolume ?? new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.NetAppVolume()); set => this._netAppVolume = value; }

        /// <summary>File path through which the NFS volume is exposed by the provider</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string NetAppVolumeNfsFilePath { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.INetAppVolumeInternal)NetAppVolume).NfsFilePath; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.INetAppVolumeInternal)NetAppVolume).NfsFilePath = value ?? null; }

        /// <summary>IP address of the NFS provider</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string NetAppVolumeNfsProviderIP { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.INetAppVolumeInternal)NetAppVolume).NfsProviderIP; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.INetAppVolumeInternal)NetAppVolume).NfsProviderIP = value ?? null; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DatastoreProvisioningState? _provisioningState;

        /// <summary>The state of the datastore provisioning</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DatastoreProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Creates an new <see cref="DatastoreProperties" /> instance.</summary>
        public DatastoreProperties()
        {

        }
    }
    /// The properties of a datastore
    public partial interface IDatastoreProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable
    {
        /// <summary>iSCSI provider target IP address list</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"iSCSI provider target IP address list",
        SerializedName = @"endpoints",
        PossibleTypes = new [] { typeof(string) })]
        string[] DiskPoolVolumeEndpoint { get; set; }
        /// <summary>Name of the LUN to be used</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the LUN to be used",
        SerializedName = @"lunName",
        PossibleTypes = new [] { typeof(string) })]
        string DiskPoolVolumeLunName { get; set; }
        /// <summary>File path through which the NFS volume is exposed by the provider</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"File path through which the NFS volume is exposed by the provider",
        SerializedName = @"nfsFilePath",
        PossibleTypes = new [] { typeof(string) })]
        string NetAppVolumeNfsFilePath { get; set; }
        /// <summary>IP address of the NFS provider</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"IP address of the NFS provider",
        SerializedName = @"nfsProviderIp",
        PossibleTypes = new [] { typeof(string) })]
        string NetAppVolumeNfsProviderIP { get; set; }
        /// <summary>The state of the datastore provisioning</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The state of the datastore provisioning",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DatastoreProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DatastoreProvisioningState? ProvisioningState { get;  }

    }
    /// The properties of a datastore
    internal partial interface IDatastorePropertiesInternal

    {
        /// <summary>An iSCSI volume</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IDiskPoolVolume DiskPoolVolume { get; set; }
        /// <summary>iSCSI provider target IP address list</summary>
        string[] DiskPoolVolumeEndpoint { get; set; }
        /// <summary>Name of the LUN to be used</summary>
        string DiskPoolVolumeLunName { get; set; }
        /// <summary>An Azure NetApp Files volume</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.INetAppVolume NetAppVolume { get; set; }
        /// <summary>File path through which the NFS volume is exposed by the provider</summary>
        string NetAppVolumeNfsFilePath { get; set; }
        /// <summary>IP address of the NFS provider</summary>
        string NetAppVolumeNfsProviderIP { get; set; }
        /// <summary>The state of the datastore provisioning</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DatastoreProvisioningState? ProvisioningState { get; set; }

    }
}