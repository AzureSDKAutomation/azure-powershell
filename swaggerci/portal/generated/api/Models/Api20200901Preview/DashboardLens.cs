namespace Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Extensions;

    /// <summary>A dashboard lens.</summary>
    public partial class DashboardLens :
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardLens,
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardLensInternal
    {

        /// <summary>Backing field for <see cref="Metadata" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardLensMetadata _metadata;

        /// <summary>The dashboard len's metadata.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardLensMetadata Metadata { get => (this._metadata = this._metadata ?? new Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.DashboardLensMetadata()); set => this._metadata = value; }

        /// <summary>Backing field for <see cref="Order" /> property.</summary>
        private int _order;

        /// <summary>The lens order.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Owned)]
        public int Order { get => this._order; set => this._order = value; }

        /// <summary>Backing field for <see cref="Part" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardParts[] _part;

        /// <summary>The dashboard parts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardParts[] Part { get => this._part; set => this._part = value; }

        /// <summary>Creates an new <see cref="DashboardLens" /> instance.</summary>
        public DashboardLens()
        {

        }
    }
    /// A dashboard lens.
    public partial interface IDashboardLens :
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.IJsonSerializable
    {
        /// <summary>The dashboard len's metadata.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The dashboard len's metadata.",
        SerializedName = @"metadata",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardLensMetadata) })]
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardLensMetadata Metadata { get; set; }
        /// <summary>The lens order.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The lens order.",
        SerializedName = @"order",
        PossibleTypes = new [] { typeof(int) })]
        int Order { get; set; }
        /// <summary>The dashboard parts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The dashboard parts.",
        SerializedName = @"parts",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardParts) })]
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardParts[] Part { get; set; }

    }
    /// A dashboard lens.
    internal partial interface IDashboardLensInternal

    {
        /// <summary>The dashboard len's metadata.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardLensMetadata Metadata { get; set; }
        /// <summary>The lens order.</summary>
        int Order { get; set; }
        /// <summary>The dashboard parts.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardParts[] Part { get; set; }

    }
}