namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.PowerShell;

    /// <summary>Specifies the windows configuration for update management.</summary>
    [System.ComponentModel.TypeConverter(typeof(OSProfileWindowsConfigurationTypeConverter))]
    public partial class OSProfileWindowsConfiguration
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.OSProfileWindowsConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileWindowsConfiguration"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileWindowsConfiguration DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new OSProfileWindowsConfiguration(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.OSProfileWindowsConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileWindowsConfiguration"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileWindowsConfiguration DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new OSProfileWindowsConfiguration(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="OSProfileWindowsConfiguration" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileWindowsConfiguration FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.OSProfileWindowsConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal OSProfileWindowsConfiguration(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileWindowsConfigurationInternal)this).PatchSetting = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IPatchSettings) content.GetValueForProperty("PatchSetting",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileWindowsConfigurationInternal)this).PatchSetting, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.PatchSettingsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileWindowsConfigurationInternal)this).PatchSettingAssessmentMode = (string) content.GetValueForProperty("PatchSettingAssessmentMode",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileWindowsConfigurationInternal)this).PatchSettingAssessmentMode, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.OSProfileWindowsConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal OSProfileWindowsConfiguration(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileWindowsConfigurationInternal)this).PatchSetting = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IPatchSettings) content.GetValueForProperty("PatchSetting",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileWindowsConfigurationInternal)this).PatchSetting, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.PatchSettingsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileWindowsConfigurationInternal)this).PatchSettingAssessmentMode = (string) content.GetValueForProperty("PatchSettingAssessmentMode",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileWindowsConfigurationInternal)this).PatchSettingAssessmentMode, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Specifies the windows configuration for update management.
    [System.ComponentModel.TypeConverter(typeof(OSProfileWindowsConfigurationTypeConverter))]
    public partial interface IOSProfileWindowsConfiguration

    {

    }
}