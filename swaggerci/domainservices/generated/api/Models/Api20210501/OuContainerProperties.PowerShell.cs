namespace Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501
{
    using Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.PowerShell;

    /// <summary>Properties of the OuContainer.</summary>
    [System.ComponentModel.TypeConverter(typeof(OuContainerPropertiesTypeConverter))]
    public partial class OuContainerProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.OuContainerProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new OuContainerProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.OuContainerProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new OuContainerProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="OuContainerProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.OuContainerProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal OuContainerProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerPropertiesInternal)this).TenantId = (string) content.GetValueForProperty("TenantId",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerPropertiesInternal)this).TenantId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerPropertiesInternal)this).DomainName = (string) content.GetValueForProperty("DomainName",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerPropertiesInternal)this).DomainName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerPropertiesInternal)this).DeploymentId = (string) content.GetValueForProperty("DeploymentId",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerPropertiesInternal)this).DeploymentId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerPropertiesInternal)this).ContainerId = (string) content.GetValueForProperty("ContainerId",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerPropertiesInternal)this).ContainerId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerPropertiesInternal)this).Account = (Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IContainerAccount[]) content.GetValueForProperty("Account",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerPropertiesInternal)this).Account, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IContainerAccount>(__y, Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.ContainerAccountTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerPropertiesInternal)this).ServiceStatus = (string) content.GetValueForProperty("ServiceStatus",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerPropertiesInternal)this).ServiceStatus, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerPropertiesInternal)this).DistinguishedName = (string) content.GetValueForProperty("DistinguishedName",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerPropertiesInternal)this).DistinguishedName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.OuContainerProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal OuContainerProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerPropertiesInternal)this).TenantId = (string) content.GetValueForProperty("TenantId",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerPropertiesInternal)this).TenantId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerPropertiesInternal)this).DomainName = (string) content.GetValueForProperty("DomainName",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerPropertiesInternal)this).DomainName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerPropertiesInternal)this).DeploymentId = (string) content.GetValueForProperty("DeploymentId",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerPropertiesInternal)this).DeploymentId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerPropertiesInternal)this).ContainerId = (string) content.GetValueForProperty("ContainerId",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerPropertiesInternal)this).ContainerId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerPropertiesInternal)this).Account = (Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IContainerAccount[]) content.GetValueForProperty("Account",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerPropertiesInternal)this).Account, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IContainerAccount>(__y, Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.ContainerAccountTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerPropertiesInternal)this).ServiceStatus = (string) content.GetValueForProperty("ServiceStatus",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerPropertiesInternal)this).ServiceStatus, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerPropertiesInternal)this).DistinguishedName = (string) content.GetValueForProperty("DistinguishedName",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerPropertiesInternal)this).DistinguishedName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Properties of the OuContainer.
    [System.ComponentModel.TypeConverter(typeof(OuContainerPropertiesTypeConverter))]
    public partial interface IOuContainerProperties

    {

    }
}