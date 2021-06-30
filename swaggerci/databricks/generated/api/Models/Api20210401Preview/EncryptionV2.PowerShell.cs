namespace Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.PowerShell;

    /// <summary>The object that contains details of encryption used on the workspace.</summary>
    [System.ComponentModel.TypeConverter(typeof(EncryptionV2TypeConverter))]
    public partial class EncryptionV2
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.EncryptionV2"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2 DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new EncryptionV2(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.EncryptionV2"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2 DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new EncryptionV2(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.EncryptionV2"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal EncryptionV2(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2Internal)this).KeyVaultProperty = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2KeyVaultProperties) content.GetValueForProperty("KeyVaultProperty",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2Internal)this).KeyVaultProperty, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.EncryptionV2KeyVaultPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2Internal)this).KeySource = (string) content.GetValueForProperty("KeySource",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2Internal)this).KeySource, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2Internal)this).KeyVaultPropertyKeyVaultUri = (string) content.GetValueForProperty("KeyVaultPropertyKeyVaultUri",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2Internal)this).KeyVaultPropertyKeyVaultUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2Internal)this).KeyVaultPropertyKeyName = (string) content.GetValueForProperty("KeyVaultPropertyKeyName",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2Internal)this).KeyVaultPropertyKeyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2Internal)this).KeyVaultPropertyKeyVersion = (string) content.GetValueForProperty("KeyVaultPropertyKeyVersion",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2Internal)this).KeyVaultPropertyKeyVersion, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.EncryptionV2"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal EncryptionV2(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2Internal)this).KeyVaultProperty = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2KeyVaultProperties) content.GetValueForProperty("KeyVaultProperty",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2Internal)this).KeyVaultProperty, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.EncryptionV2KeyVaultPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2Internal)this).KeySource = (string) content.GetValueForProperty("KeySource",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2Internal)this).KeySource, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2Internal)this).KeyVaultPropertyKeyVaultUri = (string) content.GetValueForProperty("KeyVaultPropertyKeyVaultUri",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2Internal)this).KeyVaultPropertyKeyVaultUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2Internal)this).KeyVaultPropertyKeyName = (string) content.GetValueForProperty("KeyVaultPropertyKeyName",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2Internal)this).KeyVaultPropertyKeyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2Internal)this).KeyVaultPropertyKeyVersion = (string) content.GetValueForProperty("KeyVaultPropertyKeyVersion",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2Internal)this).KeyVaultPropertyKeyVersion, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="EncryptionV2" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2 FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The object that contains details of encryption used on the workspace.
    [System.ComponentModel.TypeConverter(typeof(EncryptionV2TypeConverter))]
    public partial interface IEncryptionV2

    {

    }
}