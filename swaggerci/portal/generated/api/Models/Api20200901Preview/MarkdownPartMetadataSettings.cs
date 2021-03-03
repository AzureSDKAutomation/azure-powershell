namespace Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Extensions;

    /// <summary>Markdown part settings.</summary>
    public partial class MarkdownPartMetadataSettings :
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettings,
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsInternal
    {

        /// <summary>Backing field for <see cref="Content" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContent _content;

        /// <summary>The content of markdown part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContent Content { get => (this._content = this._content ?? new Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.MarkdownPartMetadataSettingsContent()); set => this._content = value; }

        /// <summary>Internal Acessors for Content</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContent Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsInternal.Content { get => (this._content = this._content ?? new Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.MarkdownPartMetadataSettingsContent()); set { {_content = value;} } }

        /// <summary>Internal Acessors for ContentSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentSettings Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsInternal.ContentSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)Content).Setting; set => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)Content).Setting = value; }

        /// <summary>The content of the markdown part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Inlined)]
        public string SettingContent { get => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)Content).SettingContent; set => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)Content).SettingContent = value ?? null; }

        /// <summary>The source of the content of the markdown part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Inlined)]
        public int? SettingMarkdownSource { get => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)Content).SettingMarkdownSource; set => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)Content).SettingMarkdownSource = value ?? default(int); }

        /// <summary>The uri of markdown content.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Inlined)]
        public string SettingMarkdownUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)Content).SettingMarkdownUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)Content).SettingMarkdownUri = value ?? null; }

        /// <summary>The subtitle of the markdown part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Inlined)]
        public string SettingSubtitle { get => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)Content).SettingSubtitle; set => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)Content).SettingSubtitle = value ?? null; }

        /// <summary>The title of the markdown part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Inlined)]
        public string SettingTitle { get => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)Content).SettingTitle; set => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)Content).SettingTitle = value ?? null; }

        /// <summary>Creates an new <see cref="MarkdownPartMetadataSettings" /> instance.</summary>
        public MarkdownPartMetadataSettings()
        {

        }
    }
    /// Markdown part settings.
    public partial interface IMarkdownPartMetadataSettings :
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.IJsonSerializable
    {
        /// <summary>The content of the markdown part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The content of the markdown part.",
        SerializedName = @"content",
        PossibleTypes = new [] { typeof(string) })]
        string SettingContent { get; set; }
        /// <summary>The source of the content of the markdown part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The source of the content of the markdown part.",
        SerializedName = @"markdownSource",
        PossibleTypes = new [] { typeof(int) })]
        int? SettingMarkdownSource { get; set; }
        /// <summary>The uri of markdown content.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The uri of markdown content.",
        SerializedName = @"markdownUri",
        PossibleTypes = new [] { typeof(string) })]
        string SettingMarkdownUri { get; set; }
        /// <summary>The subtitle of the markdown part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The subtitle of the markdown part.",
        SerializedName = @"subtitle",
        PossibleTypes = new [] { typeof(string) })]
        string SettingSubtitle { get; set; }
        /// <summary>The title of the markdown part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The title of the markdown part.",
        SerializedName = @"title",
        PossibleTypes = new [] { typeof(string) })]
        string SettingTitle { get; set; }

    }
    /// Markdown part settings.
    internal partial interface IMarkdownPartMetadataSettingsInternal

    {
        /// <summary>The content of markdown part.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContent Content { get; set; }
        /// <summary>The setting of the content of markdown part.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentSettings ContentSetting { get; set; }
        /// <summary>The content of the markdown part.</summary>
        string SettingContent { get; set; }
        /// <summary>The source of the content of the markdown part.</summary>
        int? SettingMarkdownSource { get; set; }
        /// <summary>The uri of markdown content.</summary>
        string SettingMarkdownUri { get; set; }
        /// <summary>The subtitle of the markdown part.</summary>
        string SettingSubtitle { get; set; }
        /// <summary>The title of the markdown part.</summary>
        string SettingTitle { get; set; }

    }
}