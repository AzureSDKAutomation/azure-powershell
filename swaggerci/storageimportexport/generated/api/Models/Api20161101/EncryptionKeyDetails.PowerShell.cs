namespace Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101
{
    using Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.PowerShell;

    /// <summary>Specifies the encryption key properties</summary>
    [System.ComponentModel.TypeConverter(typeof(EncryptionKeyDetailsTypeConverter))]
    public partial class EncryptionKeyDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.EncryptionKeyDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IEncryptionKeyDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IEncryptionKeyDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new EncryptionKeyDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.EncryptionKeyDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IEncryptionKeyDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IEncryptionKeyDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new EncryptionKeyDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.EncryptionKeyDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal EncryptionKeyDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IEncryptionKeyDetailsInternal)this).KekType = (Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Support.EncryptionKekType?) content.GetValueForProperty("KekType",((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IEncryptionKeyDetailsInternal)this).KekType, Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Support.EncryptionKekType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IEncryptionKeyDetailsInternal)this).KekUrl = (string) content.GetValueForProperty("KekUrl",((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IEncryptionKeyDetailsInternal)this).KekUrl, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IEncryptionKeyDetailsInternal)this).KekVaultResourceId = (string) content.GetValueForProperty("KekVaultResourceId",((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IEncryptionKeyDetailsInternal)this).KekVaultResourceId, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.EncryptionKeyDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal EncryptionKeyDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IEncryptionKeyDetailsInternal)this).KekType = (Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Support.EncryptionKekType?) content.GetValueForProperty("KekType",((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IEncryptionKeyDetailsInternal)this).KekType, Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Support.EncryptionKekType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IEncryptionKeyDetailsInternal)this).KekUrl = (string) content.GetValueForProperty("KekUrl",((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IEncryptionKeyDetailsInternal)this).KekUrl, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IEncryptionKeyDetailsInternal)this).KekVaultResourceId = (string) content.GetValueForProperty("KekVaultResourceId",((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IEncryptionKeyDetailsInternal)this).KekVaultResourceId, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="EncryptionKeyDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IEncryptionKeyDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Specifies the encryption key properties
    [System.ComponentModel.TypeConverter(typeof(EncryptionKeyDetailsTypeConverter))]
    public partial interface IEncryptionKeyDetails

    {

    }
}