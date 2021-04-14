namespace Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.PowerShell;

    /// <summary>Properties of an Extension resource</summary>
    [System.ComponentModel.TypeConverter(typeof(ExtensionPropertiesTypeConverter))]
    public partial class ExtensionProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ExtensionProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ExtensionProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ExtensionProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ExtensionProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ExtensionProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ExtensionProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).Scope = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScope) content.GetValueForProperty("Scope",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).Scope, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ScopeTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ErrorInfo = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorDetail) content.GetValueForProperty("ErrorInfo",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ErrorInfo, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.ErrorDetailTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ExtensionType = (string) content.GetValueForProperty("ExtensionType",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ExtensionType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).AutoUpgradeMinorVersion = (bool?) content.GetValueForProperty("AutoUpgradeMinorVersion",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).AutoUpgradeMinorVersion, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ReleaseTrain = (string) content.GetValueForProperty("ReleaseTrain",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ReleaseTrain, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).Version, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ConfigurationSetting = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesConfigurationSettings) content.GetValueForProperty("ConfigurationSetting",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ConfigurationSetting, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ExtensionPropertiesConfigurationSettingsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ConfigurationProtectedSetting = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesConfigurationProtectedSettings) content.GetValueForProperty("ConfigurationProtectedSetting",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ConfigurationProtectedSetting, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ExtensionPropertiesConfigurationProtectedSettingsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).Statuses = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionStatus[]) content.GetValueForProperty("Statuses",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).Statuses, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionStatus>(__y, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ExtensionStatusTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).CustomLocationSetting = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesCustomLocationSettings) content.GetValueForProperty("CustomLocationSetting",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).CustomLocationSetting, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ExtensionPropertiesCustomLocationSettingsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).PackageUri = (string) content.GetValueForProperty("PackageUri",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).PackageUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ScopeCluster = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScopeCluster) content.GetValueForProperty("ScopeCluster",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ScopeCluster, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ScopeClusterTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ScopeNamespace = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScopeNamespace) content.GetValueForProperty("ScopeNamespace",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ScopeNamespace, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ScopeNamespaceTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ClusterReleaseNamespace = (string) content.GetValueForProperty("ClusterReleaseNamespace",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ClusterReleaseNamespace, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).NamespaceTargetNamespace = (string) content.GetValueForProperty("NamespaceTargetNamespace",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).NamespaceTargetNamespace, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ErrorInfoCode = (string) content.GetValueForProperty("ErrorInfoCode",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ErrorInfoCode, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ErrorInfoMessage = (string) content.GetValueForProperty("ErrorInfoMessage",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ErrorInfoMessage, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ErrorInfoTarget = (string) content.GetValueForProperty("ErrorInfoTarget",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ErrorInfoTarget, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ErrorInfoDetail = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorDetail[]) content.GetValueForProperty("ErrorInfoDetail",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ErrorInfoDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorDetail>(__y, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.ErrorDetailTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ErrorInfoAdditionalInfo = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorAdditionalInfo[]) content.GetValueForProperty("ErrorInfoAdditionalInfo",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ErrorInfoAdditionalInfo, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorAdditionalInfo>(__y, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.ErrorAdditionalInfoTypeConverter.ConvertFrom));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ExtensionProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ExtensionProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).Scope = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScope) content.GetValueForProperty("Scope",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).Scope, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ScopeTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ErrorInfo = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorDetail) content.GetValueForProperty("ErrorInfo",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ErrorInfo, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.ErrorDetailTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ExtensionType = (string) content.GetValueForProperty("ExtensionType",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ExtensionType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).AutoUpgradeMinorVersion = (bool?) content.GetValueForProperty("AutoUpgradeMinorVersion",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).AutoUpgradeMinorVersion, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ReleaseTrain = (string) content.GetValueForProperty("ReleaseTrain",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ReleaseTrain, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).Version, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ConfigurationSetting = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesConfigurationSettings) content.GetValueForProperty("ConfigurationSetting",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ConfigurationSetting, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ExtensionPropertiesConfigurationSettingsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ConfigurationProtectedSetting = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesConfigurationProtectedSettings) content.GetValueForProperty("ConfigurationProtectedSetting",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ConfigurationProtectedSetting, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ExtensionPropertiesConfigurationProtectedSettingsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).Statuses = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionStatus[]) content.GetValueForProperty("Statuses",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).Statuses, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionStatus>(__y, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ExtensionStatusTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).CustomLocationSetting = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesCustomLocationSettings) content.GetValueForProperty("CustomLocationSetting",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).CustomLocationSetting, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ExtensionPropertiesCustomLocationSettingsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).PackageUri = (string) content.GetValueForProperty("PackageUri",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).PackageUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ScopeCluster = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScopeCluster) content.GetValueForProperty("ScopeCluster",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ScopeCluster, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ScopeClusterTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ScopeNamespace = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScopeNamespace) content.GetValueForProperty("ScopeNamespace",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ScopeNamespace, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ScopeNamespaceTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ClusterReleaseNamespace = (string) content.GetValueForProperty("ClusterReleaseNamespace",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ClusterReleaseNamespace, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).NamespaceTargetNamespace = (string) content.GetValueForProperty("NamespaceTargetNamespace",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).NamespaceTargetNamespace, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ErrorInfoCode = (string) content.GetValueForProperty("ErrorInfoCode",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ErrorInfoCode, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ErrorInfoMessage = (string) content.GetValueForProperty("ErrorInfoMessage",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ErrorInfoMessage, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ErrorInfoTarget = (string) content.GetValueForProperty("ErrorInfoTarget",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ErrorInfoTarget, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ErrorInfoDetail = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorDetail[]) content.GetValueForProperty("ErrorInfoDetail",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ErrorInfoDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorDetail>(__y, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.ErrorDetailTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ErrorInfoAdditionalInfo = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorAdditionalInfo[]) content.GetValueForProperty("ErrorInfoAdditionalInfo",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesInternal)this).ErrorInfoAdditionalInfo, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.IErrorAdditionalInfo>(__y, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.ErrorAdditionalInfoTypeConverter.ConvertFrom));
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ExtensionProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Properties of an Extension resource
    [System.ComponentModel.TypeConverter(typeof(ExtensionPropertiesTypeConverter))]
    public partial interface IExtensionProperties

    {

    }
}