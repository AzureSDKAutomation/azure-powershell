namespace Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Extensions;

    /// <summary>Specifies the encryption key properties</summary>
    public partial class EncryptionKeyDetails
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonObject into a new instance of <see cref="EncryptionKeyDetails" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal EncryptionKeyDetails(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_kekType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonString>("kekType"), out var __jsonKekType) ? (string)__jsonKekType : (string)KekType;}
            {_kekUrl = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonString>("kekUrl"), out var __jsonKekUrl) ? (string)__jsonKekUrl : (string)KekUrl;}
            {_kekVaultResourceId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonString>("kekVaultResourceID"), out var __jsonKekVaultResourceId) ? (string)__jsonKekVaultResourceId : (string)KekVaultResourceId;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IEncryptionKeyDetails.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IEncryptionKeyDetails.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IEncryptionKeyDetails FromJson(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonObject json ? new EncryptionKeyDetails(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="EncryptionKeyDetails" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="EncryptionKeyDetails" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._kekType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonString(this._kekType.ToString()) : null, "kekType" ,container.Add );
            AddIf( null != (((object)this._kekUrl)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonString(this._kekUrl.ToString()) : null, "kekUrl" ,container.Add );
            AddIf( null != (((object)this._kekVaultResourceId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonString(this._kekVaultResourceId.ToString()) : null, "kekVaultResourceID" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}