namespace Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Extensions;

    /// <summary>A dashboard part.</summary>
    public partial class DashboardParts :
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardParts,
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartsInternal
    {

        /// <summary>Backing field for <see cref="Metadata" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartMetadata _metadata;

        /// <summary>The dashboard part's metadata.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartMetadata Metadata { get => (this._metadata = this._metadata ?? new Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.DashboardPartMetadata()); set => this._metadata = value; }

        /// <summary>The type of dashboard part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Inlined)]
        public string MetadataType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartMetadataInternal)Metadata).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartMetadataInternal)Metadata).Type = value ?? null; }

        /// <summary>Internal Acessors for Metadata</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartMetadata Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartsInternal.Metadata { get => (this._metadata = this._metadata ?? new Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.DashboardPartMetadata()); set { {_metadata = value;} } }

        /// <summary>Internal Acessors for Position</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartsPosition Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartsInternal.Position { get => (this._position = this._position ?? new Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.DashboardPartsPosition()); set { {_position = value;} } }

        /// <summary>Backing field for <see cref="Position" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartsPosition _position;

        /// <summary>The dashboard's part position.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartsPosition Position { get => (this._position = this._position ?? new Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.DashboardPartsPosition()); set => this._position = value; }

        /// <summary>The dashboard's part column span.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Inlined)]
        public int PositionColSpan { get => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartsPositionInternal)Position).ColSpan; set => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartsPositionInternal)Position).ColSpan = value ; }

        /// <summary>The dashboard part's metadata.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartsPositionMetadata PositionMetadata { get => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartsPositionInternal)Position).Metadata; set => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartsPositionInternal)Position).Metadata = value ?? null /* model class */; }

        /// <summary>The dashboard's part row span.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Inlined)]
        public int PositionRowSpan { get => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartsPositionInternal)Position).RowSpan; set => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartsPositionInternal)Position).RowSpan = value ; }

        /// <summary>The dashboard's part x coordinate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Inlined)]
        public int PositionX { get => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartsPositionInternal)Position).X; set => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartsPositionInternal)Position).X = value ; }

        /// <summary>The dashboard's part y coordinate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Inlined)]
        public int PositionY { get => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartsPositionInternal)Position).Y; set => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartsPositionInternal)Position).Y = value ; }

        /// <summary>Creates an new <see cref="DashboardParts" /> instance.</summary>
        public DashboardParts()
        {

        }
    }
    /// A dashboard part.
    public partial interface IDashboardParts :
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.IJsonSerializable
    {
        /// <summary>The type of dashboard part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of dashboard part.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string MetadataType { get; set; }
        /// <summary>The dashboard's part column span.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The dashboard's part column span.",
        SerializedName = @"colSpan",
        PossibleTypes = new [] { typeof(int) })]
        int PositionColSpan { get; set; }
        /// <summary>The dashboard part's metadata.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The dashboard part's metadata.",
        SerializedName = @"metadata",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartsPositionMetadata) })]
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartsPositionMetadata PositionMetadata { get; set; }
        /// <summary>The dashboard's part row span.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The dashboard's part row span.",
        SerializedName = @"rowSpan",
        PossibleTypes = new [] { typeof(int) })]
        int PositionRowSpan { get; set; }
        /// <summary>The dashboard's part x coordinate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The dashboard's part x coordinate.",
        SerializedName = @"x",
        PossibleTypes = new [] { typeof(int) })]
        int PositionX { get; set; }
        /// <summary>The dashboard's part y coordinate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The dashboard's part y coordinate.",
        SerializedName = @"y",
        PossibleTypes = new [] { typeof(int) })]
        int PositionY { get; set; }

    }
    /// A dashboard part.
    internal partial interface IDashboardPartsInternal

    {
        /// <summary>The dashboard part's metadata.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartMetadata Metadata { get; set; }
        /// <summary>The type of dashboard part.</summary>
        string MetadataType { get; set; }
        /// <summary>The dashboard's part position.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartsPosition Position { get; set; }
        /// <summary>The dashboard's part column span.</summary>
        int PositionColSpan { get; set; }
        /// <summary>The dashboard part's metadata.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartsPositionMetadata PositionMetadata { get; set; }
        /// <summary>The dashboard's part row span.</summary>
        int PositionRowSpan { get; set; }
        /// <summary>The dashboard's part x coordinate.</summary>
        int PositionX { get; set; }
        /// <summary>The dashboard's part y coordinate.</summary>
        int PositionY { get; set; }

    }
}