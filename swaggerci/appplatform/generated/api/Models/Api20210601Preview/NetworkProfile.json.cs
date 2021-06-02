namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Service network profile payload</summary>
    public partial class NetworkProfile
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.INetworkProfile.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.INetworkProfile.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.INetworkProfile FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonObject json ? new NetworkProfile(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonObject into a new instance of <see cref="NetworkProfile" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal NetworkProfile(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_outboundIP = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonObject>("outboundIPs"), out var __jsonOutboundIPs) ? Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.NetworkProfileOutboundIPs.FromJson(__jsonOutboundIPs) : OutboundIP;}
            {_serviceRuntimeSubnetId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonString>("serviceRuntimeSubnetId"), out var __jsonServiceRuntimeSubnetId) ? (string)__jsonServiceRuntimeSubnetId : (string)ServiceRuntimeSubnetId;}
            {_appSubnetId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonString>("appSubnetId"), out var __jsonAppSubnetId) ? (string)__jsonAppSubnetId : (string)AppSubnetId;}
            {_serviceCidr = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonString>("serviceCidr"), out var __jsonServiceCidr) ? (string)__jsonServiceCidr : (string)ServiceCidr;}
            {_serviceRuntimeNetworkResourceGroup = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonString>("serviceRuntimeNetworkResourceGroup"), out var __jsonServiceRuntimeNetworkResourceGroup) ? (string)__jsonServiceRuntimeNetworkResourceGroup : (string)ServiceRuntimeNetworkResourceGroup;}
            {_appNetworkResourceGroup = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonString>("appNetworkResourceGroup"), out var __jsonAppNetworkResourceGroup) ? (string)__jsonAppNetworkResourceGroup : (string)AppNetworkResourceGroup;}
            {_requiredTraffic = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonArray>("requiredTraffics"), out var __jsonRequiredTraffics) ? If( __jsonRequiredTraffics as Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IRequiredTraffic[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IRequiredTraffic) (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.RequiredTraffic.FromJson(__u) )) ))() : null : RequiredTraffic;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="NetworkProfile" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="NetworkProfile" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode" />.
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
                AddIf( null != this._outboundIP ? (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode) this._outboundIP.ToJson(null,serializationMode) : null, "outboundIPs" ,container.Add );
            }
            AddIf( null != (((object)this._serviceRuntimeSubnetId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonString(this._serviceRuntimeSubnetId.ToString()) : null, "serviceRuntimeSubnetId" ,container.Add );
            AddIf( null != (((object)this._appSubnetId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonString(this._appSubnetId.ToString()) : null, "appSubnetId" ,container.Add );
            AddIf( null != (((object)this._serviceCidr)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonString(this._serviceCidr.ToString()) : null, "serviceCidr" ,container.Add );
            AddIf( null != (((object)this._serviceRuntimeNetworkResourceGroup)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonString(this._serviceRuntimeNetworkResourceGroup.ToString()) : null, "serviceRuntimeNetworkResourceGroup" ,container.Add );
            AddIf( null != (((object)this._appNetworkResourceGroup)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonString(this._appNetworkResourceGroup.ToString()) : null, "appNetworkResourceGroup" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.SerializationMode.IncludeReadOnly))
            {
                if (null != this._requiredTraffic)
                {
                    var __w = new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.XNodeArray();
                    foreach( var __x in this._requiredTraffic )
                    {
                        AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                    }
                    container.Add("requiredTraffics",__w);
                }
            }
            AfterToJson(ref container);
            return container;
        }
    }
}