namespace Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Extensions;

    /// <summary>A list of the blobs to be exported.</summary>
    public partial class ExportBlobList
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
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonObject into a new instance of <see cref="ExportBlobList" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ExportBlobList(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_blobPath = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonArray>("blobPath"), out var __jsonBlobPath) ? If( __jsonBlobPath as Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : BlobPath;}
            {_blobPathPrefix = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonArray>("blobPathPrefix"), out var __jsonBlobPathPrefix) ? If( __jsonBlobPathPrefix as Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(string) (__p is Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonString __o ? (string)(__o.ToString()) : null)) ))() : null : BlobPathPrefix;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IExportBlobList.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IExportBlobList.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IExportBlobList FromJson(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonObject json ? new ExportBlobList(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="ExportBlobList" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ExportBlobList" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonNode" />.
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
            if (null != this._blobPath)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.XNodeArray();
                foreach( var __x in this._blobPath )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("blobPath",__w);
            }
            if (null != this._blobPathPrefix)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.XNodeArray();
                foreach( var __s in this._blobPathPrefix )
                {
                    AddIf(null != (((object)__s)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonString(__s.ToString()) : null ,__r.Add);
                }
                container.Add("blobPathPrefix",__r);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}