namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.PowerShell;

    /// <summary>Deployment resource properties payload</summary>
    [System.ComponentModel.TypeConverter(typeof(DeploymentResourcePropertiesTypeConverter))]
    public partial class DeploymentResourceProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.DeploymentResourceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DeploymentResourceProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).Source = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IUserSourceInfo) content.GetValueForProperty("Source",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).Source, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.UserSourceInfoTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).DeploymentSetting = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentSettings) content.GetValueForProperty("DeploymentSetting",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).DeploymentSetting, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.DeploymentSettingsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).AppName = (string) content.GetValueForProperty("AppName",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).AppName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.DeploymentResourceProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.DeploymentResourceProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.DeploymentResourceStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.DeploymentResourceStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).Active = (bool?) content.GetValueForProperty("Active",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).Active, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).CreatedTime = (global::System.DateTime?) content.GetValueForProperty("CreatedTime",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).CreatedTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).Instance = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentInstance[]) content.GetValueForProperty("Instance",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).Instance, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentInstance>(__y, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.DeploymentInstanceTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).DeploymentSettingResourceRequest = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IResourceRequests) content.GetValueForProperty("DeploymentSettingResourceRequest",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).DeploymentSettingResourceRequest, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ResourceRequestsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).DeploymentSettingJvmOption = (string) content.GetValueForProperty("DeploymentSettingJvmOption",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).DeploymentSettingJvmOption, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).DeploymentSettingEnvironmentVariable = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentSettingsEnvironmentVariables) content.GetValueForProperty("DeploymentSettingEnvironmentVariable",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).DeploymentSettingEnvironmentVariable, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.DeploymentSettingsEnvironmentVariablesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).DeploymentSettingRuntimeVersion = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.RuntimeVersion?) content.GetValueForProperty("DeploymentSettingRuntimeVersion",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).DeploymentSettingRuntimeVersion, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.RuntimeVersion.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).SourceType = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.UserSourceType?) content.GetValueForProperty("SourceType",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).SourceType, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.UserSourceType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).SourceRelativePath = (string) content.GetValueForProperty("SourceRelativePath",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).SourceRelativePath, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).SourceVersion = (string) content.GetValueForProperty("SourceVersion",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).SourceVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).SourceArtifactSelector = (string) content.GetValueForProperty("SourceArtifactSelector",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).SourceArtifactSelector, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).DeploymentSettingCpu = (int?) content.GetValueForProperty("DeploymentSettingCpu",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).DeploymentSettingCpu, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).DeploymentSettingMemoryInGb = (int?) content.GetValueForProperty("DeploymentSettingMemoryInGb",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).DeploymentSettingMemoryInGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).DeploymentSettingNetCoreMainEntryPath = (string) content.GetValueForProperty("DeploymentSettingNetCoreMainEntryPath",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).DeploymentSettingNetCoreMainEntryPath, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).ResourceRequestCpu = (string) content.GetValueForProperty("ResourceRequestCpu",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).ResourceRequestCpu, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).ResourceRequestMemory = (string) content.GetValueForProperty("ResourceRequestMemory",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).ResourceRequestMemory, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.DeploymentResourceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DeploymentResourceProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).Source = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IUserSourceInfo) content.GetValueForProperty("Source",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).Source, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.UserSourceInfoTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).DeploymentSetting = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentSettings) content.GetValueForProperty("DeploymentSetting",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).DeploymentSetting, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.DeploymentSettingsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).AppName = (string) content.GetValueForProperty("AppName",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).AppName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.DeploymentResourceProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.DeploymentResourceProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.DeploymentResourceStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.DeploymentResourceStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).Active = (bool?) content.GetValueForProperty("Active",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).Active, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).CreatedTime = (global::System.DateTime?) content.GetValueForProperty("CreatedTime",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).CreatedTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).Instance = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentInstance[]) content.GetValueForProperty("Instance",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).Instance, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentInstance>(__y, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.DeploymentInstanceTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).DeploymentSettingResourceRequest = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IResourceRequests) content.GetValueForProperty("DeploymentSettingResourceRequest",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).DeploymentSettingResourceRequest, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ResourceRequestsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).DeploymentSettingJvmOption = (string) content.GetValueForProperty("DeploymentSettingJvmOption",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).DeploymentSettingJvmOption, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).DeploymentSettingEnvironmentVariable = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentSettingsEnvironmentVariables) content.GetValueForProperty("DeploymentSettingEnvironmentVariable",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).DeploymentSettingEnvironmentVariable, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.DeploymentSettingsEnvironmentVariablesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).DeploymentSettingRuntimeVersion = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.RuntimeVersion?) content.GetValueForProperty("DeploymentSettingRuntimeVersion",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).DeploymentSettingRuntimeVersion, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.RuntimeVersion.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).SourceType = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.UserSourceType?) content.GetValueForProperty("SourceType",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).SourceType, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.UserSourceType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).SourceRelativePath = (string) content.GetValueForProperty("SourceRelativePath",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).SourceRelativePath, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).SourceVersion = (string) content.GetValueForProperty("SourceVersion",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).SourceVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).SourceArtifactSelector = (string) content.GetValueForProperty("SourceArtifactSelector",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).SourceArtifactSelector, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).DeploymentSettingCpu = (int?) content.GetValueForProperty("DeploymentSettingCpu",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).DeploymentSettingCpu, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).DeploymentSettingMemoryInGb = (int?) content.GetValueForProperty("DeploymentSettingMemoryInGb",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).DeploymentSettingMemoryInGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).DeploymentSettingNetCoreMainEntryPath = (string) content.GetValueForProperty("DeploymentSettingNetCoreMainEntryPath",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).DeploymentSettingNetCoreMainEntryPath, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).ResourceRequestCpu = (string) content.GetValueForProperty("ResourceRequestCpu",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).ResourceRequestCpu, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).ResourceRequestMemory = (string) content.GetValueForProperty("ResourceRequestMemory",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal)this).ResourceRequestMemory, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.DeploymentResourceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourceProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourceProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DeploymentResourceProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.DeploymentResourceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourceProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourceProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DeploymentResourceProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DeploymentResourceProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourceProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Deployment resource properties payload
    [System.ComponentModel.TypeConverter(typeof(DeploymentResourcePropertiesTypeConverter))]
    public partial interface IDeploymentResourceProperties

    {

    }
}