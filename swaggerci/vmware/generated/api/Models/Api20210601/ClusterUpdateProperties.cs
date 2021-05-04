namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>The properties of a cluster that may be updated</summary>
    public partial class ClusterUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IClusterUpdateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IClusterUpdatePropertiesInternal
    {

        /// <summary>Backing field for <see cref="ClusterSize" /> property.</summary>
        private int? _clusterSize;

        /// <summary>The cluster size</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public int? ClusterSize { get => this._clusterSize; set => this._clusterSize = value; }

        /// <summary>Creates an new <see cref="ClusterUpdateProperties" /> instance.</summary>
        public ClusterUpdateProperties()
        {

        }
    }
    /// The properties of a cluster that may be updated
    public partial interface IClusterUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable
    {
        /// <summary>The cluster size</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The cluster size",
        SerializedName = @"clusterSize",
        PossibleTypes = new [] { typeof(int) })]
        int? ClusterSize { get; set; }

    }
    /// The properties of a cluster that may be updated
    internal partial interface IClusterUpdatePropertiesInternal

    {
        /// <summary>The cluster size</summary>
        int? ClusterSize { get; set; }

    }
}