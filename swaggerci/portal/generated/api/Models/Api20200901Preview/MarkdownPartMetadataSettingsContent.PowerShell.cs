namespace Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.PowerShell;

    /// <summary>The content of markdown part.</summary>
    [System.ComponentModel.TypeConverter(typeof(MarkdownPartMetadataSettingsContentTypeConverter))]
    public partial class MarkdownPartMetadataSettingsContent
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.MarkdownPartMetadataSettingsContent"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContent"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContent DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MarkdownPartMetadataSettingsContent(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.MarkdownPartMetadataSettingsContent"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContent"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContent DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MarkdownPartMetadataSettingsContent(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MarkdownPartMetadataSettingsContent" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContent FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.MarkdownPartMetadataSettingsContent"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MarkdownPartMetadataSettingsContent(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)this).Setting = (Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentSettings) content.GetValueForProperty("Setting",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)this).Setting, Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.MarkdownPartMetadataSettingsContentSettingsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)this).SettingContent = (string) content.GetValueForProperty("SettingContent",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)this).SettingContent, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)this).SettingTitle = (string) content.GetValueForProperty("SettingTitle",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)this).SettingTitle, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)this).SettingSubtitle = (string) content.GetValueForProperty("SettingSubtitle",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)this).SettingSubtitle, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)this).SettingMarkdownSource = (int?) content.GetValueForProperty("SettingMarkdownSource",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)this).SettingMarkdownSource, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)this).SettingMarkdownUri = (string) content.GetValueForProperty("SettingMarkdownUri",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)this).SettingMarkdownUri, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.MarkdownPartMetadataSettingsContent"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MarkdownPartMetadataSettingsContent(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)this).Setting = (Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentSettings) content.GetValueForProperty("Setting",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)this).Setting, Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.MarkdownPartMetadataSettingsContentSettingsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)this).SettingContent = (string) content.GetValueForProperty("SettingContent",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)this).SettingContent, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)this).SettingTitle = (string) content.GetValueForProperty("SettingTitle",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)this).SettingTitle, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)this).SettingSubtitle = (string) content.GetValueForProperty("SettingSubtitle",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)this).SettingSubtitle, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)this).SettingMarkdownSource = (int?) content.GetValueForProperty("SettingMarkdownSource",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)this).SettingMarkdownSource, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)this).SettingMarkdownUri = (string) content.GetValueForProperty("SettingMarkdownUri",((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IMarkdownPartMetadataSettingsContentInternal)this).SettingMarkdownUri, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The content of markdown part.
    [System.ComponentModel.TypeConverter(typeof(MarkdownPartMetadataSettingsContentTypeConverter))]
    public partial interface IMarkdownPartMetadataSettingsContent

    {

    }
}