namespace Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Runtime.Extensions;

    public partial class UnresolvedDependenciesFilterProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101.IUnresolvedDependenciesFilterProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101.IUnresolvedDependenciesFilterPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Count" /> property.</summary>
        private int? _count;

        /// <summary>The count of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.PropertyOrigin.Owned)]
        public int? Count { get => this._count; set => this._count = value; }

        /// <summary>Creates an new <see cref="UnresolvedDependenciesFilterProperties" /> instance.</summary>
        public UnresolvedDependenciesFilterProperties()
        {

        }
    }
    public partial interface IUnresolvedDependenciesFilterProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Runtime.IJsonSerializable
    {
        /// <summary>The count of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The count of the resource.",
        SerializedName = @"count",
        PossibleTypes = new [] { typeof(int) })]
        int? Count { get; set; }

    }
    internal partial interface IUnresolvedDependenciesFilterPropertiesInternal

    {
        /// <summary>The count of the resource.</summary>
        int? Count { get; set; }

    }
}