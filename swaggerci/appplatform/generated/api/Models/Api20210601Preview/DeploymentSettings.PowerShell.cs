namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.PowerShell;

    /// <summary>Deployment settings payload</summary>
    [System.ComponentModel.TypeConverter(typeof(DeploymentSettingsTypeConverter))]
    public partial class DeploymentSettings
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.DeploymentSettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DeploymentSettings(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsInternal)this).ResourceRequest = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceRequests) content.GetValueForProperty("ResourceRequest",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsInternal)this).ResourceRequest, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ResourceRequestsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsInternal)this).Cpu = (int?) content.GetValueForProperty("Cpu",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsInternal)this).Cpu, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsInternal)this).MemoryInGb = (int?) content.GetValueForProperty("MemoryInGb",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsInternal)this).MemoryInGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsInternal)this).EnvironmentVariable = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsEnvironmentVariables) content.GetValueForProperty("EnvironmentVariable",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsInternal)this).EnvironmentVariable, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.DeploymentSettingsEnvironmentVariablesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsInternal)this).AddonConfig = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsAddonConfig) content.GetValueForProperty("AddonConfig",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsInternal)this).AddonConfig, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.DeploymentSettingsAddonConfigTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsInternal)this).ResourceRequestCpu = (string) content.GetValueForProperty("ResourceRequestCpu",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsInternal)this).ResourceRequestCpu, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsInternal)this).ResourceRequestMemory = (string) content.GetValueForProperty("ResourceRequestMemory",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsInternal)this).ResourceRequestMemory, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.DeploymentSettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DeploymentSettings(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsInternal)this).ResourceRequest = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceRequests) content.GetValueForProperty("ResourceRequest",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsInternal)this).ResourceRequest, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ResourceRequestsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsInternal)this).Cpu = (int?) content.GetValueForProperty("Cpu",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsInternal)this).Cpu, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsInternal)this).MemoryInGb = (int?) content.GetValueForProperty("MemoryInGb",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsInternal)this).MemoryInGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsInternal)this).EnvironmentVariable = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsEnvironmentVariables) content.GetValueForProperty("EnvironmentVariable",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsInternal)this).EnvironmentVariable, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.DeploymentSettingsEnvironmentVariablesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsInternal)this).AddonConfig = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsAddonConfig) content.GetValueForProperty("AddonConfig",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsInternal)this).AddonConfig, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.DeploymentSettingsAddonConfigTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsInternal)this).ResourceRequestCpu = (string) content.GetValueForProperty("ResourceRequestCpu",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsInternal)this).ResourceRequestCpu, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsInternal)this).ResourceRequestMemory = (string) content.GetValueForProperty("ResourceRequestMemory",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsInternal)this).ResourceRequestMemory, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.DeploymentSettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettings"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettings DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DeploymentSettings(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.DeploymentSettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettings"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettings DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DeploymentSettings(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DeploymentSettings" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettings FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Deployment settings payload
    [System.ComponentModel.TypeConverter(typeof(DeploymentSettingsTypeConverter))]
    public partial interface IDeploymentSettings

    {

    }
}