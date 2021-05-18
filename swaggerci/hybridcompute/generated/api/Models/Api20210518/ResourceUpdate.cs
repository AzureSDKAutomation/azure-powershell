namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Extensions;

    /// <summary>The Update Resource model definition.</summary>
    public partial class ResourceUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IResourceUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IResourceUpdateInternal
    {

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IResourceUpdateTags _tag;

        /// <summary>Resource tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IResourceUpdateTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.ResourceUpdateTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="ResourceUpdate" /> instance.</summary>
        public ResourceUpdate()
        {

        }
    }
    /// The Update Resource model definition.
    public partial interface IResourceUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IJsonSerializable
    {
        /// <summary>Resource tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IResourceUpdateTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IResourceUpdateTags Tag { get; set; }

    }
    /// The Update Resource model definition.
    internal partial interface IResourceUpdateInternal

    {
        /// <summary>Resource tags</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IResourceUpdateTags Tag { get; set; }

    }
}