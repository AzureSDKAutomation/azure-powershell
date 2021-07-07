namespace Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.PowerShell;

    /// <summary>Encryption entities for databricks workspace resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(EncryptionEntitiesDefinitionTypeConverter))]
    public partial class EncryptionEntitiesDefinition
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.EncryptionEntitiesDefinition"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinition"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinition DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new EncryptionEntitiesDefinition(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.EncryptionEntitiesDefinition"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinition"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinition DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new EncryptionEntitiesDefinition(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.EncryptionEntitiesDefinition"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal EncryptionEntitiesDefinition(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinitionInternal)this).ManagedService = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2) content.GetValueForProperty("ManagedService",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinitionInternal)this).ManagedService, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.EncryptionV2TypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinitionInternal)this).ManagedServiceKeyVaultProperty = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2KeyVaultProperties) content.GetValueForProperty("ManagedServiceKeyVaultProperty",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinitionInternal)this).ManagedServiceKeyVaultProperty, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.EncryptionV2KeyVaultPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinitionInternal)this).ManagedServiceKeySource = (string) content.GetValueForProperty("ManagedServiceKeySource",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinitionInternal)this).ManagedServiceKeySource, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinitionInternal)this).KeyVaultPropertyKeyVaultUri = (string) content.GetValueForProperty("KeyVaultPropertyKeyVaultUri",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinitionInternal)this).KeyVaultPropertyKeyVaultUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinitionInternal)this).KeyVaultPropertyKeyName = (string) content.GetValueForProperty("KeyVaultPropertyKeyName",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinitionInternal)this).KeyVaultPropertyKeyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinitionInternal)this).KeyVaultPropertyKeyVersion = (string) content.GetValueForProperty("KeyVaultPropertyKeyVersion",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinitionInternal)this).KeyVaultPropertyKeyVersion, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.EncryptionEntitiesDefinition"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal EncryptionEntitiesDefinition(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinitionInternal)this).ManagedService = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2) content.GetValueForProperty("ManagedService",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinitionInternal)this).ManagedService, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.EncryptionV2TypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinitionInternal)this).ManagedServiceKeyVaultProperty = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2KeyVaultProperties) content.GetValueForProperty("ManagedServiceKeyVaultProperty",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinitionInternal)this).ManagedServiceKeyVaultProperty, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.EncryptionV2KeyVaultPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinitionInternal)this).ManagedServiceKeySource = (string) content.GetValueForProperty("ManagedServiceKeySource",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinitionInternal)this).ManagedServiceKeySource, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinitionInternal)this).KeyVaultPropertyKeyVaultUri = (string) content.GetValueForProperty("KeyVaultPropertyKeyVaultUri",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinitionInternal)this).KeyVaultPropertyKeyVaultUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinitionInternal)this).KeyVaultPropertyKeyName = (string) content.GetValueForProperty("KeyVaultPropertyKeyName",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinitionInternal)this).KeyVaultPropertyKeyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinitionInternal)this).KeyVaultPropertyKeyVersion = (string) content.GetValueForProperty("KeyVaultPropertyKeyVersion",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinitionInternal)this).KeyVaultPropertyKeyVersion, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="EncryptionEntitiesDefinition" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinition FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Encryption entities for databricks workspace resource.
    [System.ComponentModel.TypeConverter(typeof(EncryptionEntitiesDefinitionTypeConverter))]
    public partial interface IEncryptionEntitiesDefinition

    {

    }
}