namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>The common properties of a cluster</summary>
    public partial class CommonClusterProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonObject into a new instance of <see cref="CommonClusterProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal CommonClusterProperties(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)ProvisioningState;}
            {_clusterSize = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonNumber>("clusterSize"), out var __jsonClusterSize) ? (int?)__jsonClusterSize : ClusterSize;}
            {_clusterId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonNumber>("clusterId"), out var __jsonClusterId) ? (int?)__jsonClusterId : ClusterId;}
            {_host = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonArray>("hosts"), out var __jsonHosts) ? If( __jsonHosts as Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : Host;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ICommonClusterProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ICommonClusterProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.ICommonClusterProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonObject json ? new CommonClusterProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="CommonClusterProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="CommonClusterProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            AddIf( null != this._clusterSize ? (Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonNumber((int)this._clusterSize) : null, "clusterSize" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._clusterId ? (Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonNumber((int)this._clusterId) : null, "clusterId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.SerializationMode.IncludeReadOnly))
            {
                if (null != this._host)
                {
                    var __w = new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.XNodeArray();
                    foreach( var __x in this._host )
                    {
                        AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                    }
                    container.Add("hosts",__w);
                }
            }
            AfterToJson(ref container);
            return container;
        }
    }
}