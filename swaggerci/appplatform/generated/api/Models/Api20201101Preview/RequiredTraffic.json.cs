namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Required inbound or outbound traffic for Azure Spring Cloud instance.</summary>
    public partial class RequiredTraffic
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IRequiredTraffic.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IRequiredTraffic.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IRequiredTraffic FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonObject json ? new RequiredTraffic(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonObject into a new instance of <see cref="RequiredTraffic" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal RequiredTraffic(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_protocol = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonString>("protocol"), out var __jsonProtocol) ? (string)__jsonProtocol : (string)Protocol;}
            {_port = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNumber>("port"), out var __jsonPort) ? (int?)__jsonPort : Port;}
            {_iP = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonArray>("ips"), out var __jsonIps) ? If( __jsonIps as Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : IP;}
            {_fqdn = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonArray>("fqdns"), out var __jsonFqdns) ? If( __jsonFqdns as Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(string) (__p is Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonString __o ? (string)(__o.ToString()) : null)) ))() : null : Fqdn;}
            {_direction = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonString>("direction"), out var __jsonDirection) ? (string)__jsonDirection : (string)Direction;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="RequiredTraffic" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="RequiredTraffic" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._protocol)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonString(this._protocol.ToString()) : null, "protocol" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._port ? (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNumber((int)this._port) : null, "port" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.SerializationMode.IncludeReadOnly))
            {
                if (null != this._iP)
                {
                    var __w = new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.XNodeArray();
                    foreach( var __x in this._iP )
                    {
                        AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                    }
                    container.Add("ips",__w);
                }
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.SerializationMode.IncludeReadOnly))
            {
                if (null != this._fqdn)
                {
                    var __r = new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.XNodeArray();
                    foreach( var __s in this._fqdn )
                    {
                        AddIf(null != (((object)__s)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonString(__s.ToString()) : null ,__r.Add);
                    }
                    container.Add("fqdns",__r);
                }
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._direction)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonString(this._direction.ToString()) : null, "direction" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}