namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.PowerShell;

    /// <summary>Deployment resource payload</summary>
    [System.ComponentModel.TypeConverter(typeof(DeploymentResourceTypeConverter))]
    public partial class DeploymentResource
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.DeploymentResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DeploymentResource(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.DeploymentResourcePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ISku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.SkuTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).DeploymentSetting = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentSettings) content.GetValueForProperty("DeploymentSetting",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).DeploymentSetting, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.DeploymentSettingsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).SkuName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).SkuTier = (string) content.GetValueForProperty("SkuTier",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).SkuTier, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).Source = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IUserSourceInfo) content.GetValueForProperty("Source",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).Source, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.UserSourceInfoTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).AppName = (string) content.GetValueForProperty("AppName",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).AppName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.DeploymentResourceProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.DeploymentResourceProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.DeploymentResourceStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.DeploymentResourceStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).Active = (bool?) content.GetValueForProperty("Active",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).Active, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).CreatedTime = (global::System.DateTime?) content.GetValueForProperty("CreatedTime",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).CreatedTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).Instance = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentInstance[]) content.GetValueForProperty("Instance",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).Instance, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentInstance>(__y, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.DeploymentInstanceTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).DeploymentSettingJvmOption = (string) content.GetValueForProperty("DeploymentSettingJvmOption",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).DeploymentSettingJvmOption, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).DeploymentSettingEnvironmentVariable = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentSettingsEnvironmentVariables) content.GetValueForProperty("DeploymentSettingEnvironmentVariable",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).DeploymentSettingEnvironmentVariable, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.DeploymentSettingsEnvironmentVariablesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).DeploymentSettingRuntimeVersion = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.RuntimeVersion?) content.GetValueForProperty("DeploymentSettingRuntimeVersion",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).DeploymentSettingRuntimeVersion, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.RuntimeVersion.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).SkuCapacity = (int?) content.GetValueForProperty("SkuCapacity",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).SkuCapacity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).SourceType = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.UserSourceType?) content.GetValueForProperty("SourceType",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).SourceType, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.UserSourceType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).SourceRelativePath = (string) content.GetValueForProperty("SourceRelativePath",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).SourceRelativePath, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).SourceVersion = (string) content.GetValueForProperty("SourceVersion",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).SourceVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).SourceArtifactSelector = (string) content.GetValueForProperty("SourceArtifactSelector",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).SourceArtifactSelector, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).DeploymentSettingCpu = (int?) content.GetValueForProperty("DeploymentSettingCpu",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).DeploymentSettingCpu, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).DeploymentSettingMemoryInGb = (int?) content.GetValueForProperty("DeploymentSettingMemoryInGb",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).DeploymentSettingMemoryInGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).DeploymentSettingNetCoreMainEntryPath = (string) content.GetValueForProperty("DeploymentSettingNetCoreMainEntryPath",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).DeploymentSettingNetCoreMainEntryPath, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.DeploymentResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DeploymentResource(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.DeploymentResourcePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ISku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.SkuTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).DeploymentSetting = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentSettings) content.GetValueForProperty("DeploymentSetting",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).DeploymentSetting, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.DeploymentSettingsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).SkuName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).SkuTier = (string) content.GetValueForProperty("SkuTier",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).SkuTier, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).Source = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IUserSourceInfo) content.GetValueForProperty("Source",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).Source, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.UserSourceInfoTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).AppName = (string) content.GetValueForProperty("AppName",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).AppName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.DeploymentResourceProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.DeploymentResourceProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.DeploymentResourceStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.DeploymentResourceStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).Active = (bool?) content.GetValueForProperty("Active",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).Active, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).CreatedTime = (global::System.DateTime?) content.GetValueForProperty("CreatedTime",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).CreatedTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).Instance = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentInstance[]) content.GetValueForProperty("Instance",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).Instance, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentInstance>(__y, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.DeploymentInstanceTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).DeploymentSettingJvmOption = (string) content.GetValueForProperty("DeploymentSettingJvmOption",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).DeploymentSettingJvmOption, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).DeploymentSettingEnvironmentVariable = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentSettingsEnvironmentVariables) content.GetValueForProperty("DeploymentSettingEnvironmentVariable",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).DeploymentSettingEnvironmentVariable, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.DeploymentSettingsEnvironmentVariablesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).DeploymentSettingRuntimeVersion = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.RuntimeVersion?) content.GetValueForProperty("DeploymentSettingRuntimeVersion",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).DeploymentSettingRuntimeVersion, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.RuntimeVersion.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).SkuCapacity = (int?) content.GetValueForProperty("SkuCapacity",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).SkuCapacity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).SourceType = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.UserSourceType?) content.GetValueForProperty("SourceType",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).SourceType, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.UserSourceType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).SourceRelativePath = (string) content.GetValueForProperty("SourceRelativePath",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).SourceRelativePath, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).SourceVersion = (string) content.GetValueForProperty("SourceVersion",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).SourceVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).SourceArtifactSelector = (string) content.GetValueForProperty("SourceArtifactSelector",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).SourceArtifactSelector, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).DeploymentSettingCpu = (int?) content.GetValueForProperty("DeploymentSettingCpu",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).DeploymentSettingCpu, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).DeploymentSettingMemoryInGb = (int?) content.GetValueForProperty("DeploymentSettingMemoryInGb",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).DeploymentSettingMemoryInGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).DeploymentSettingNetCoreMainEntryPath = (string) content.GetValueForProperty("DeploymentSettingNetCoreMainEntryPath",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResourceInternal)this).DeploymentSettingNetCoreMainEntryPath, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.DeploymentResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResource"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResource DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DeploymentResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.DeploymentResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResource"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResource DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DeploymentResource(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DeploymentResource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IDeploymentResource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Deployment resource payload
    [System.ComponentModel.TypeConverter(typeof(DeploymentResourceTypeConverter))]
    public partial interface IDeploymentResource

    {

    }
}