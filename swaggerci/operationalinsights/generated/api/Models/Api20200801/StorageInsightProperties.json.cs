namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>Storage insight properties.</summary>
    public partial class StorageInsightProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject json ? new StorageInsightProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject into a new instance of <see cref="StorageInsightProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal StorageInsightProperties(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_storageAccount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject>("storageAccount"), out var __jsonStorageAccount) ? Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.StorageAccount.FromJson(__jsonStorageAccount) : StorageAccount;}
            {_status = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject>("status"), out var __jsonStatus) ? Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.StorageInsightStatus.FromJson(__jsonStatus) : Status;}
            {_container = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonArray>("containers"), out var __jsonContainers) ? If( __jsonContainers as Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : Container;}
            {_table = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonArray>("tables"), out var __jsonTables) ? If( __jsonTables as Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(string) (__p is Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonString __o ? (string)(__o.ToString()) : null)) ))() : null : Table;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="StorageInsightProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="StorageInsightProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._storageAccount ? (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode) this._storageAccount.ToJson(null,serializationMode) : null, "storageAccount" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._status ? (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode) this._status.ToJson(null,serializationMode) : null, "status" ,container.Add );
            }
            if (null != this._container)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.XNodeArray();
                foreach( var __x in this._container )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("containers",__w);
            }
            if (null != this._table)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.XNodeArray();
                foreach( var __s in this._table )
                {
                    AddIf(null != (((object)__s)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonString(__s.ToString()) : null ,__r.Add);
                }
                container.Add("tables",__r);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}