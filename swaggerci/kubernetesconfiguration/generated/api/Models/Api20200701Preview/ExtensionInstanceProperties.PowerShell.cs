namespace Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.PowerShell;

    /// <summary>Properties of an Extension Instance resource</summary>
    [System.ComponentModel.TypeConverter(typeof(ExtensionInstancePropertiesTypeConverter))]
    public partial class ExtensionInstanceProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.ExtensionInstanceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstanceProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstanceProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ExtensionInstanceProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.ExtensionInstanceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstanceProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstanceProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ExtensionInstanceProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.ExtensionInstanceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ExtensionInstanceProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).Scope = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IScope) content.GetValueForProperty("Scope",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).Scope, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.ScopeTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ErrorInfo = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IErrorDefinition) content.GetValueForProperty("ErrorInfo",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ErrorInfo, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.ErrorDefinitionTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IConfigurationIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.ConfigurationIdentityTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ExtensionType = (string) content.GetValueForProperty("ExtensionType",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ExtensionType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).AutoUpgradeMinorVersion = (bool?) content.GetValueForProperty("AutoUpgradeMinorVersion",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).AutoUpgradeMinorVersion, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ReleaseTrain = (string) content.GetValueForProperty("ReleaseTrain",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ReleaseTrain, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).Version, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ConfigurationSetting = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IConfigurationSettings) content.GetValueForProperty("ConfigurationSetting",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ConfigurationSetting, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.ConfigurationSettingsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ConfigurationProtectedSetting = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionProtectedSettings) content.GetValueForProperty("ConfigurationProtectedSetting",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ConfigurationProtectedSetting, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.ExtensionProtectedSettingsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).InstallState = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.InstallStateType?) content.GetValueForProperty("InstallState",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).InstallState, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.InstallStateType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).Statuses = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionStatus[]) content.GetValueForProperty("Statuses",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).Statuses, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionStatus>(__y, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.ExtensionStatusTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).CreationTime = (string) content.GetValueForProperty("CreationTime",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).CreationTime, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).LastModifiedTime = (string) content.GetValueForProperty("LastModifiedTime",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).LastModifiedTime, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).LastStatusTime = (string) content.GetValueForProperty("LastStatusTime",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).LastStatusTime, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ScopeCluster = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IScopeCluster) content.GetValueForProperty("ScopeCluster",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ScopeCluster, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.ScopeClusterTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ScopeNamespace = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IScopeNamespace) content.GetValueForProperty("ScopeNamespace",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ScopeNamespace, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.ScopeNamespaceTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ClusterReleaseNamespace = (string) content.GetValueForProperty("ClusterReleaseNamespace",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ClusterReleaseNamespace, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).NamespaceTargetNamespace = (string) content.GetValueForProperty("NamespaceTargetNamespace",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).NamespaceTargetNamespace, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ErrorInfoCode = (string) content.GetValueForProperty("ErrorInfoCode",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ErrorInfoCode, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ErrorInfoMessage = (string) content.GetValueForProperty("ErrorInfoMessage",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ErrorInfoMessage, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).IdentityTenantId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).IdentityType = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.ResourceIdentityType?) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).IdentityType, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.ResourceIdentityType.CreateFrom);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.ExtensionInstanceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ExtensionInstanceProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).Scope = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IScope) content.GetValueForProperty("Scope",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).Scope, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.ScopeTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ErrorInfo = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IErrorDefinition) content.GetValueForProperty("ErrorInfo",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ErrorInfo, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.ErrorDefinitionTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IConfigurationIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.ConfigurationIdentityTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ExtensionType = (string) content.GetValueForProperty("ExtensionType",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ExtensionType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).AutoUpgradeMinorVersion = (bool?) content.GetValueForProperty("AutoUpgradeMinorVersion",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).AutoUpgradeMinorVersion, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ReleaseTrain = (string) content.GetValueForProperty("ReleaseTrain",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ReleaseTrain, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).Version, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ConfigurationSetting = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IConfigurationSettings) content.GetValueForProperty("ConfigurationSetting",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ConfigurationSetting, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.ConfigurationSettingsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ConfigurationProtectedSetting = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionProtectedSettings) content.GetValueForProperty("ConfigurationProtectedSetting",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ConfigurationProtectedSetting, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.ExtensionProtectedSettingsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).InstallState = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.InstallStateType?) content.GetValueForProperty("InstallState",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).InstallState, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.InstallStateType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).Statuses = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionStatus[]) content.GetValueForProperty("Statuses",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).Statuses, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionStatus>(__y, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.ExtensionStatusTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).CreationTime = (string) content.GetValueForProperty("CreationTime",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).CreationTime, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).LastModifiedTime = (string) content.GetValueForProperty("LastModifiedTime",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).LastModifiedTime, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).LastStatusTime = (string) content.GetValueForProperty("LastStatusTime",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).LastStatusTime, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ScopeCluster = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IScopeCluster) content.GetValueForProperty("ScopeCluster",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ScopeCluster, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.ScopeClusterTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ScopeNamespace = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IScopeNamespace) content.GetValueForProperty("ScopeNamespace",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ScopeNamespace, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.ScopeNamespaceTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ClusterReleaseNamespace = (string) content.GetValueForProperty("ClusterReleaseNamespace",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ClusterReleaseNamespace, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).NamespaceTargetNamespace = (string) content.GetValueForProperty("NamespaceTargetNamespace",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).NamespaceTargetNamespace, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ErrorInfoCode = (string) content.GetValueForProperty("ErrorInfoCode",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ErrorInfoCode, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ErrorInfoMessage = (string) content.GetValueForProperty("ErrorInfoMessage",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).ErrorInfoMessage, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).IdentityTenantId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).IdentityType = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.ResourceIdentityType?) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancePropertiesInternal)this).IdentityType, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Support.ResourceIdentityType.CreateFrom);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ExtensionInstanceProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstanceProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Properties of an Extension Instance resource
    [System.ComponentModel.TypeConverter(typeof(ExtensionInstancePropertiesTypeConverter))]
    public partial interface IExtensionInstanceProperties

    {

    }
}