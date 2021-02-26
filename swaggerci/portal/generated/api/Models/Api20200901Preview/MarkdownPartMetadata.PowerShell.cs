namespace Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.PowerShell;

    /// <summary>Markdown part metadata.</summary>
    [System.ComponentModel.TypeConverter(typeof(MarkdownPartMetadataTypeConverter))]
    public partial class MarkdownPartMetadata
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.MarkdownPartMetadata"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadata" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadata DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MarkdownPartMetadata(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.MarkdownPartMetadata"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadata" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadata DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MarkdownPartMetadata(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MarkdownPartMetadata" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadata FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.MarkdownPartMetadata"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MarkdownPartMetadata(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).Setting = (Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettings) content.GetValueForProperty("Setting",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).Setting, Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.MarkdownPartMetadataSettingsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).Input = (Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.IAny[]) content.GetValueForProperty("Input",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).Input, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.IAny>(__y, Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.AnyTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartMetadataInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartMetadataInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).SettingsContent = (Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContent) content.GetValueForProperty("SettingsContent",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).SettingsContent, Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.MarkdownPartMetadataSettingsContentTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).Content = (string) content.GetValueForProperty("Content",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).Content, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).ContentSetting = (Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentSettings) content.GetValueForProperty("ContentSetting",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).ContentSetting, Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.MarkdownPartMetadataSettingsContentSettingsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).SettingTitle = (string) content.GetValueForProperty("SettingTitle",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).SettingTitle, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).SettingSubtitle = (string) content.GetValueForProperty("SettingSubtitle",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).SettingSubtitle, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).SettingMarkdownSource = (int?) content.GetValueForProperty("SettingMarkdownSource",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).SettingMarkdownSource, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).SettingMarkdownUri = (string) content.GetValueForProperty("SettingMarkdownUri",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).SettingMarkdownUri, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.MarkdownPartMetadata"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MarkdownPartMetadata(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).Setting = (Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettings) content.GetValueForProperty("Setting",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).Setting, Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.MarkdownPartMetadataSettingsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).Input = (Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.IAny[]) content.GetValueForProperty("Input",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).Input, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.IAny>(__y, Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.AnyTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartMetadataInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartMetadataInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).SettingsContent = (Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContent) content.GetValueForProperty("SettingsContent",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).SettingsContent, Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.MarkdownPartMetadataSettingsContentTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).Content = (string) content.GetValueForProperty("Content",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).Content, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).ContentSetting = (Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentSettings) content.GetValueForProperty("ContentSetting",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).ContentSetting, Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.MarkdownPartMetadataSettingsContentSettingsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).SettingTitle = (string) content.GetValueForProperty("SettingTitle",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).SettingTitle, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).SettingSubtitle = (string) content.GetValueForProperty("SettingSubtitle",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).SettingSubtitle, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).SettingMarkdownSource = (int?) content.GetValueForProperty("SettingMarkdownSource",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).SettingMarkdownSource, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).SettingMarkdownUri = (string) content.GetValueForProperty("SettingMarkdownUri",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataInternal)this).SettingMarkdownUri, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Markdown part metadata.
    [System.ComponentModel.TypeConverter(typeof(MarkdownPartMetadataTypeConverter))]
    public partial interface IMarkdownPartMetadata

    {

    }
}