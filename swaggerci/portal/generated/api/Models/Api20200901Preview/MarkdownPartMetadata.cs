namespace Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Extensions;

    /// <summary>Markdown part metadata.</summary>
    public partial class MarkdownPartMetadata :
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadata,
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartMetadata"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartMetadata __dashboardPartMetadata = new Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.DashboardPartMetadata();

        /// <summary>The content of the markdown part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Inlined)]
        public string Content { get => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsInternal)Setting).SettingContent; set => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsInternal)Setting).SettingContent = value ?? null; }

        /// <summary>Backing field for <see cref="Input" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.IAny[] _input;

        /// <summary>Input to dashboard part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.IAny[] Input { get => this._input; set => this._input = value; }

        /// <summary>Internal Acessors for ContentSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentSettings Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal.ContentSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsInternal)Setting).ContentSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsInternal)Setting).ContentSetting = value; }

        /// <summary>Internal Acessors for Setting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettings Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal.Setting { get => (this._setting = this._setting ?? new Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.MarkdownPartMetadataSettings()); set { {_setting = value;} } }

        /// <summary>Internal Acessors for SettingsContent</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContent Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal.SettingsContent { get => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsInternal)Setting).Content; set => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsInternal)Setting).Content = value; }

        /// <summary>Backing field for <see cref="Setting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettings _setting;

        /// <summary>Markdown part settings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettings Setting { get => (this._setting = this._setting ?? new Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.MarkdownPartMetadataSettings()); set => this._setting = value; }

        /// <summary>The source of the content of the markdown part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Inlined)]
        public int? SettingMarkdownSource { get => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsInternal)Setting).SettingMarkdownSource; set => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsInternal)Setting).SettingMarkdownSource = value ?? default(int); }

        /// <summary>The uri of markdown content.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Inlined)]
        public string SettingMarkdownUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsInternal)Setting).SettingMarkdownUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsInternal)Setting).SettingMarkdownUri = value ?? null; }

        /// <summary>The subtitle of the markdown part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Inlined)]
        public string SettingSubtitle { get => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsInternal)Setting).SettingSubtitle; set => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsInternal)Setting).SettingSubtitle = value ?? null; }

        /// <summary>The title of the markdown part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Inlined)]
        public string SettingTitle { get => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsInternal)Setting).SettingTitle; set => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsInternal)Setting).SettingTitle = value ?? null; }

        /// <summary>The type of dashboard part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartMetadataInternal)__dashboardPartMetadata).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartMetadataInternal)__dashboardPartMetadata).Type = value ; }

        /// <summary>Creates an new <see cref="MarkdownPartMetadata" /> instance.</summary>
        public MarkdownPartMetadata()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__dashboardPartMetadata), __dashboardPartMetadata);
            await eventListener.AssertObjectIsValid(nameof(__dashboardPartMetadata), __dashboardPartMetadata);
        }
    }
    /// Markdown part metadata.
    public partial interface IMarkdownPartMetadata :
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartMetadata
    {
        /// <summary>The content of the markdown part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The content of the markdown part.",
        SerializedName = @"content",
        PossibleTypes = new [] { typeof(string) })]
        string Content { get; set; }
        /// <summary>Input to dashboard part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Input to dashboard part.",
        SerializedName = @"inputs",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.IAny) })]
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.IAny[] Input { get; set; }
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
    /// Markdown part metadata.
    internal partial interface IMarkdownPartMetadataInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartMetadataInternal
    {
        /// <summary>The content of the markdown part.</summary>
        string Content { get; set; }
        /// <summary>The setting of the content of markdown part.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentSettings ContentSetting { get; set; }
        /// <summary>Input to dashboard part.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.IAny[] Input { get; set; }
        /// <summary>Markdown part settings.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettings Setting { get; set; }
        /// <summary>The source of the content of the markdown part.</summary>
        int? SettingMarkdownSource { get; set; }
        /// <summary>The uri of markdown content.</summary>
        string SettingMarkdownUri { get; set; }
        /// <summary>The subtitle of the markdown part.</summary>
        string SettingSubtitle { get; set; }
        /// <summary>The title of the markdown part.</summary>
        string SettingTitle { get; set; }
        /// <summary>The content of markdown part.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContent SettingsContent { get; set; }

    }
}