namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>The cluster sku definition.</summary>
    public partial class ClusterSku :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterSku,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterSkuInternal
    {

        /// <summary>Backing field for <see cref="Capacity" /> property.</summary>
        private long? _capacity;

        /// <summary>The capacity value</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public long? Capacity { get => this._capacity; set => this._capacity = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterSkuNameEnum? _name;

        /// <summary>The name of the SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterSkuNameEnum? Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="ClusterSku" /> instance.</summary>
        public ClusterSku()
        {

        }
    }
    /// The cluster sku definition.
    public partial interface IClusterSku :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>The capacity value</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The capacity value",
        SerializedName = @"capacity",
        PossibleTypes = new [] { typeof(long) })]
        long? Capacity { get; set; }
        /// <summary>The name of the SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the SKU.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterSkuNameEnum) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterSkuNameEnum? Name { get; set; }

    }
    /// The cluster sku definition.
    internal partial interface IClusterSkuInternal

    {
        /// <summary>The capacity value</summary>
        long? Capacity { get; set; }
        /// <summary>The name of the SKU.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterSkuNameEnum? Name { get; set; }

    }
}