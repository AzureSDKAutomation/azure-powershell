namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.PowerShell;

    /// <summary>The top level Linked service resource container.</summary>
    [System.ComponentModel.TypeConverter(typeof(LinkedServiceTypeConverter))]
    public partial class LinkedService
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.LinkedService"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedService" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedService DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new LinkedService(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.LinkedService"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedService" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedService DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new LinkedService(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="LinkedService" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedService FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.LinkedService"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal LinkedService(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.LinkedServicePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.LinkedServiceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceInternal)this).ResourceId = (string) content.GetValueForProperty("ResourceId",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceInternal)this).ResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceInternal)this).WriteAccessResourceId = (string) content.GetValueForProperty("WriteAccessResourceId",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceInternal)this).WriteAccessResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.LinkedServiceEntityStatus?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.LinkedServiceEntityStatus.CreateFrom);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.LinkedService"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal LinkedService(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.LinkedServicePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.LinkedServiceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceInternal)this).ResourceId = (string) content.GetValueForProperty("ResourceId",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceInternal)this).ResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceInternal)this).WriteAccessResourceId = (string) content.GetValueForProperty("WriteAccessResourceId",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceInternal)this).WriteAccessResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.LinkedServiceEntityStatus?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.LinkedServiceEntityStatus.CreateFrom);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The top level Linked service resource container.
    [System.ComponentModel.TypeConverter(typeof(LinkedServiceTypeConverter))]
    public partial interface ILinkedService

    {

    }
}