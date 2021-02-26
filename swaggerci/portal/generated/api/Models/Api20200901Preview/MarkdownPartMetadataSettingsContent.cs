namespace Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Extensions;

    /// <summary>The content of markdown part.</summary>
    public partial class MarkdownPartMetadataSettingsContent :
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContent,
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal
    {

        /// <summary>Internal Acessors for Setting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentSettings Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal.Setting { get => (this._setting = this._setting ?? new Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.MarkdownPartMetadataSettingsContentSettings()); set { {_setting = value;} } }

        /// <summary>Backing field for <see cref="Setting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentSettings _setting;

        /// <summary>The setting of the content of markdown part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentSettings Setting { get => (this._setting = this._setting ?? new Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.MarkdownPartMetadataSettingsContentSettings()); set => this._setting = value; }

        /// <summary>The content of the markdown part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Inlined)]
        public string SettingContent { get => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentSettingsInternal)Setting).Content; set => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentSettingsInternal)Setting).Content = value ?? null; }

        /// <summary>The source of the content of the markdown part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Inlined)]
        public int? SettingMarkdownSource { get => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentSettingsInternal)Setting).MarkdownSource; set => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentSettingsInternal)Setting).MarkdownSource = value ?? default(int); }

        /// <summary>The uri of markdown content.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Inlined)]
        public string SettingMarkdownUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentSettingsInternal)Setting).MarkdownUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentSettingsInternal)Setting).MarkdownUri = value ?? null; }

        /// <summary>The subtitle of the markdown part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Inlined)]
        public string SettingSubtitle { get => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentSettingsInternal)Setting).Subtitle; set => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentSettingsInternal)Setting).Subtitle = value ?? null; }

        /// <summary>The title of the markdown part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Inlined)]
        public string SettingTitle { get => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentSettingsInternal)Setting).Title; set => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentSettingsInternal)Setting).Title = value ?? null; }

        /// <summary>Creates an new <see cref="MarkdownPartMetadataSettingsContent" /> instance.</summary>
        public MarkdownPartMetadataSettingsContent()
        {

        }
    }
    /// The content of markdown part.
    public partial interface IMarkdownPartMetadataSettingsContent :
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
    /// The content of markdown part.
    internal partial interface IMarkdownPartMetadataSettingsContentInternal

    {
        /// <summary>The setting of the content of markdown part.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentSettings Setting { get; set; }
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