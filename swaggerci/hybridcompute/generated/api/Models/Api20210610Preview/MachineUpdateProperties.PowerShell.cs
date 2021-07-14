namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.PowerShell;

    /// <summary>Describes the ARM updatable properties of a hybrid machine.</summary>
    [System.ComponentModel.TypeConverter(typeof(MachineUpdatePropertiesTypeConverter))]
    public partial class MachineUpdateProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.MachineUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdateProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdateProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MachineUpdateProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.MachineUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdateProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdateProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MachineUpdateProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MachineUpdateProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdateProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.MachineUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MachineUpdateProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).LocationData = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ILocationData) content.GetValueForProperty("LocationData",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).LocationData, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.LocationDataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).OSProfile = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfile) content.GetValueForProperty("OSProfile",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).OSProfile, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.OSProfileTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).ParentClusterResourceId = (string) content.GetValueForProperty("ParentClusterResourceId",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).ParentClusterResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).PrivateLinkScopeResourceId = (string) content.GetValueForProperty("PrivateLinkScopeResourceId",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).PrivateLinkScopeResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).LocationDataName = (string) content.GetValueForProperty("LocationDataName",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).LocationDataName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).LocationDataCity = (string) content.GetValueForProperty("LocationDataCity",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).LocationDataCity, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).LocationDataDistrict = (string) content.GetValueForProperty("LocationDataDistrict",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).LocationDataDistrict, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).LocationDataCountryOrRegion = (string) content.GetValueForProperty("LocationDataCountryOrRegion",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).LocationDataCountryOrRegion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).OSProfileWindowsConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileWindowsConfiguration) content.GetValueForProperty("OSProfileWindowsConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).OSProfileWindowsConfiguration, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.OSProfileWindowsConfigurationTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).OSProfileLinuxConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileLinuxConfiguration) content.GetValueForProperty("OSProfileLinuxConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).OSProfileLinuxConfiguration, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.OSProfileLinuxConfigurationTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).OSProfileComputerName = (string) content.GetValueForProperty("OSProfileComputerName",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).OSProfileComputerName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).WindowConfigurationPatchSetting = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IPatchSettings) content.GetValueForProperty("WindowConfigurationPatchSetting",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).WindowConfigurationPatchSetting, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.PatchSettingsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).LinuxConfigurationPatchSetting = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IPatchSettings) content.GetValueForProperty("LinuxConfigurationPatchSetting",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).LinuxConfigurationPatchSetting, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.PatchSettingsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).WindowsConfigurationPatchSettingsAssessmentMode = (string) content.GetValueForProperty("WindowsConfigurationPatchSettingsAssessmentMode",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).WindowsConfigurationPatchSettingsAssessmentMode, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).LinuxConfigurationPatchSettingsAssessmentMode = (string) content.GetValueForProperty("LinuxConfigurationPatchSettingsAssessmentMode",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).LinuxConfigurationPatchSettingsAssessmentMode, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.MachineUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MachineUpdateProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).LocationData = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ILocationData) content.GetValueForProperty("LocationData",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).LocationData, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.LocationDataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).OSProfile = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfile) content.GetValueForProperty("OSProfile",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).OSProfile, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.OSProfileTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).ParentClusterResourceId = (string) content.GetValueForProperty("ParentClusterResourceId",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).ParentClusterResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).PrivateLinkScopeResourceId = (string) content.GetValueForProperty("PrivateLinkScopeResourceId",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).PrivateLinkScopeResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).LocationDataName = (string) content.GetValueForProperty("LocationDataName",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).LocationDataName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).LocationDataCity = (string) content.GetValueForProperty("LocationDataCity",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).LocationDataCity, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).LocationDataDistrict = (string) content.GetValueForProperty("LocationDataDistrict",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).LocationDataDistrict, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).LocationDataCountryOrRegion = (string) content.GetValueForProperty("LocationDataCountryOrRegion",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).LocationDataCountryOrRegion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).OSProfileWindowsConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileWindowsConfiguration) content.GetValueForProperty("OSProfileWindowsConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).OSProfileWindowsConfiguration, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.OSProfileWindowsConfigurationTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).OSProfileLinuxConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileLinuxConfiguration) content.GetValueForProperty("OSProfileLinuxConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).OSProfileLinuxConfiguration, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.OSProfileLinuxConfigurationTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).OSProfileComputerName = (string) content.GetValueForProperty("OSProfileComputerName",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).OSProfileComputerName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).WindowConfigurationPatchSetting = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IPatchSettings) content.GetValueForProperty("WindowConfigurationPatchSetting",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).WindowConfigurationPatchSetting, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.PatchSettingsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).LinuxConfigurationPatchSetting = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IPatchSettings) content.GetValueForProperty("LinuxConfigurationPatchSetting",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).LinuxConfigurationPatchSetting, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.PatchSettingsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).WindowsConfigurationPatchSettingsAssessmentMode = (string) content.GetValueForProperty("WindowsConfigurationPatchSettingsAssessmentMode",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).WindowsConfigurationPatchSettingsAssessmentMode, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).LinuxConfigurationPatchSettingsAssessmentMode = (string) content.GetValueForProperty("LinuxConfigurationPatchSettingsAssessmentMode",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)this).LinuxConfigurationPatchSettingsAssessmentMode, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Describes the ARM updatable properties of a hybrid machine.
    [System.ComponentModel.TypeConverter(typeof(MachineUpdatePropertiesTypeConverter))]
    public partial interface IMachineUpdateProperties

    {

    }
}