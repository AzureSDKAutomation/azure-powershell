namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>The SKU capacity</summary>
    public partial class SkuCapacity :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ISkuCapacity,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ISkuCapacityInternal
    {

        /// <summary>Backing field for <see cref="Default" /> property.</summary>
        private int? _default;

        /// <summary>Gets or sets the default.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public int? Default { get => this._default; set => this._default = value; }

        /// <summary>Backing field for <see cref="Maximum" /> property.</summary>
        private int? _maximum;

        /// <summary>Gets or sets the maximum.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public int? Maximum { get => this._maximum; set => this._maximum = value; }

        /// <summary>Backing field for <see cref="Minimum" /> property.</summary>
        private int _minimum;

        /// <summary>Gets or sets the minimum.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public int Minimum { get => this._minimum; set => this._minimum = value; }

        /// <summary>Backing field for <see cref="ScaleType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.SkuScaleType? _scaleType;

        /// <summary>Gets or sets the type of the scale.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.SkuScaleType? ScaleType { get => this._scaleType; set => this._scaleType = value; }

        /// <summary>Creates an new <see cref="SkuCapacity" /> instance.</summary>
        public SkuCapacity()
        {

        }
    }
    /// The SKU capacity
    public partial interface ISkuCapacity :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets the default.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the default.",
        SerializedName = @"default",
        PossibleTypes = new [] { typeof(int) })]
        int? Default { get; set; }
        /// <summary>Gets or sets the maximum.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the maximum.",
        SerializedName = @"maximum",
        PossibleTypes = new [] { typeof(int) })]
        int? Maximum { get; set; }
        /// <summary>Gets or sets the minimum.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Gets or sets the minimum.",
        SerializedName = @"minimum",
        PossibleTypes = new [] { typeof(int) })]
        int Minimum { get; set; }
        /// <summary>Gets or sets the type of the scale.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the type of the scale.",
        SerializedName = @"scaleType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.SkuScaleType) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.SkuScaleType? ScaleType { get; set; }

    }
    /// The SKU capacity
    internal partial interface ISkuCapacityInternal

    {
        /// <summary>Gets or sets the default.</summary>
        int? Default { get; set; }
        /// <summary>Gets or sets the maximum.</summary>
        int? Maximum { get; set; }
        /// <summary>Gets or sets the minimum.</summary>
        int Minimum { get; set; }
        /// <summary>Gets or sets the type of the scale.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.SkuScaleType? ScaleType { get; set; }

    }
}