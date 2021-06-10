namespace Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Extensions;

    /// <summary>Properties of the connected cluster.</summary>
    public partial class ExtensionTypeProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Json.JsonObject into a new instance of <see cref="ExtensionTypeProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ExtensionTypeProperties(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_supportedScope = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Json.JsonObject>("supportedScopes"), out var __jsonSupportedScopes) ? Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.SupportedScopes.FromJson(__jsonSupportedScopes) : SupportedScope;}
            {_releaseTrain = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Json.JsonArray>("releaseTrains"), out var __jsonReleaseTrains) ? If( __jsonReleaseTrains as Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : ReleaseTrain;}
            {_clusterType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Json.JsonString>("clusterTypes"), out var __jsonClusterTypes) ? (string)__jsonClusterTypes : (string)ClusterType;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Json.JsonObject json ? new ExtensionTypeProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="ExtensionTypeProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ExtensionTypeProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._supportedScope ? (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Json.JsonNode) this._supportedScope.ToJson(null,serializationMode) : null, "supportedScopes" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.SerializationMode.IncludeReadOnly))
            {
                if (null != this._releaseTrain)
                {
                    var __w = new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Json.XNodeArray();
                    foreach( var __x in this._releaseTrain )
                    {
                        AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                    }
                    container.Add("releaseTrains",__w);
                }
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._clusterType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Json.JsonString(this._clusterType.ToString()) : null, "clusterTypes" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}