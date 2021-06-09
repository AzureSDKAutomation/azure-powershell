namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.PowerShell;

    /// <summary>Monitoring Setting properties payload</summary>
    [System.ComponentModel.TypeConverter(typeof(MonitoringSettingPropertiesTypeConverter))]
    public partial class MonitoringSettingProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.MonitoringSettingProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MonitoringSettingProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.MonitoringSettingProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MonitoringSettingProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MonitoringSettingProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.MonitoringSettingProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MonitoringSettingProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IError) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ErrorTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).AppInsightsAgentVersion = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IApplicationInsightsAgentVersions) content.GetValueForProperty("AppInsightsAgentVersion",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).AppInsightsAgentVersion, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ApplicationInsightsAgentVersionsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.MonitoringSettingState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.MonitoringSettingState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).TraceEnabled = (bool?) content.GetValueForProperty("TraceEnabled",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).TraceEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).AppInsightsInstrumentationKey = (string) content.GetValueForProperty("AppInsightsInstrumentationKey",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).AppInsightsInstrumentationKey, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).AppInsightsSamplingRate = (double?) content.GetValueForProperty("AppInsightsSamplingRate",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).AppInsightsSamplingRate, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).Code, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).Message, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).AppInsightAgentVersionJava = (string) content.GetValueForProperty("AppInsightAgentVersionJava",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).AppInsightAgentVersionJava, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.MonitoringSettingProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MonitoringSettingProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IError) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ErrorTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).AppInsightsAgentVersion = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IApplicationInsightsAgentVersions) content.GetValueForProperty("AppInsightsAgentVersion",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).AppInsightsAgentVersion, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ApplicationInsightsAgentVersionsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.MonitoringSettingState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.MonitoringSettingState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).TraceEnabled = (bool?) content.GetValueForProperty("TraceEnabled",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).TraceEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).AppInsightsInstrumentationKey = (string) content.GetValueForProperty("AppInsightsInstrumentationKey",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).AppInsightsInstrumentationKey, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).AppInsightsSamplingRate = (double?) content.GetValueForProperty("AppInsightsSamplingRate",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).AppInsightsSamplingRate, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).Code, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).Message, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).AppInsightAgentVersionJava = (string) content.GetValueForProperty("AppInsightAgentVersionJava",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMonitoringSettingPropertiesInternal)this).AppInsightAgentVersionJava, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Monitoring Setting properties payload
    [System.ComponentModel.TypeConverter(typeof(MonitoringSettingPropertiesTypeConverter))]
    public partial interface IMonitoringSettingProperties

    {

    }
}