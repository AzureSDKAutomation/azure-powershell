namespace Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Extensions;

    /// <summary>The setting of the content of markdown part.</summary>
    public partial class MarkdownPartMetadataSettingsContentSettings :
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentSettings,
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentSettingsInternal
    {

        /// <summary>Backing field for <see cref="Content" /> property.</summary>
        private string _content;

        /// <summary>The content of the markdown part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Owned)]
        public string Content { get => this._content; set => this._content = value; }

        /// <summary>Backing field for <see cref="MarkdownSource" /> property.</summary>
        private int? _markdownSource;

        /// <summary>The source of the content of the markdown part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Owned)]
        public int? MarkdownSource { get => this._markdownSource; set => this._markdownSource = value; }

        /// <summary>Backing field for <see cref="MarkdownUri" /> property.</summary>
        private string _markdownUri;

        /// <summary>The uri of markdown content.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Owned)]
        public string MarkdownUri { get => this._markdownUri; set => this._markdownUri = value; }

        /// <summary>Backing field for <see cref="Subtitle" /> property.</summary>
        private string _subtitle;

        /// <summary>The subtitle of the markdown part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Owned)]
        public string Subtitle { get => this._subtitle; set => this._subtitle = value; }

        /// <summary>Backing field for <see cref="Title" /> property.</summary>
        private string _title;

        /// <summary>The title of the markdown part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Owned)]
        public string Title { get => this._title; set => this._title = value; }

        /// <summary>
        /// Creates an new <see cref="MarkdownPartMetadataSettingsContentSettings" /> instance.
        /// </summary>
        public MarkdownPartMetadataSettingsContentSettings()
        {

        }
    }
    /// The setting of the content of markdown part.
    public partial interface IMarkdownPartMetadataSettingsContentSettings :
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.IJsonSerializable
    {
        /// <summary>The content of the markdown part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The content of the markdown part.",
        SerializedName = @"content",
        PossibleTypes = new [] { typeof(string) })]
        string Content { get; set; }
        /// <summary>The source of the content of the markdown part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The source of the content of the markdown part.",
        SerializedName = @"markdownSource",
        PossibleTypes = new [] { typeof(int) })]
        int? MarkdownSource { get; set; }
        /// <summary>The uri of markdown content.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The uri of markdown content.",
        SerializedName = @"markdownUri",
        PossibleTypes = new [] { typeof(string) })]
        string MarkdownUri { get; set; }
        /// <summary>The subtitle of the markdown part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The subtitle of the markdown part.",
        SerializedName = @"subtitle",
        PossibleTypes = new [] { typeof(string) })]
        string Subtitle { get; set; }
        /// <summary>The title of the markdown part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The title of the markdown part.",
        SerializedName = @"title",
        PossibleTypes = new [] { typeof(string) })]
        string Title { get; set; }

    }
    /// The setting of the content of markdown part.
    internal partial interface IMarkdownPartMetadataSettingsContentSettingsInternal

    {
        /// <summary>The content of the markdown part.</summary>
        string Content { get; set; }
        /// <summary>The source of the content of the markdown part.</summary>
        int? MarkdownSource { get; set; }
        /// <summary>The uri of markdown content.</summary>
        string MarkdownUri { get; set; }
        /// <summary>The subtitle of the markdown part.</summary>
        string Subtitle { get; set; }
        /// <summary>The title of the markdown part.</summary>
        string Title { get; set; }

    }
}