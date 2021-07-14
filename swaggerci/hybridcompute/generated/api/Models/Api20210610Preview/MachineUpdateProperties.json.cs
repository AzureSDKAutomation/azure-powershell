namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Extensions;

    /// <summary>Describes the ARM updatable properties of a hybrid machine.</summary>
    public partial class MachineUpdateProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdateProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdateProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdateProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonObject json ? new MachineUpdateProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonObject into a new instance of <see cref="MachineUpdateProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal MachineUpdateProperties(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_locationData = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonObject>("locationData"), out var __jsonLocationData) ? Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.LocationData.FromJson(__jsonLocationData) : LocationData;}
            {_oSProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonObject>("osProfile"), out var __jsonOSProfile) ? Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.OSProfile.FromJson(__jsonOSProfile) : OSProfile;}
            {_parentClusterResourceId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonString>("parentClusterResourceId"), out var __jsonParentClusterResourceId) ? (string)__jsonParentClusterResourceId : (string)ParentClusterResourceId;}
            {_privateLinkScopeResourceId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonString>("privateLinkScopeResourceId"), out var __jsonPrivateLinkScopeResourceId) ? (string)__jsonPrivateLinkScopeResourceId : (string)PrivateLinkScopeResourceId;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="MachineUpdateProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MachineUpdateProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._locationData ? (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonNode) this._locationData.ToJson(null,serializationMode) : null, "locationData" ,container.Add );
            AddIf( null != this._oSProfile ? (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonNode) this._oSProfile.ToJson(null,serializationMode) : null, "osProfile" ,container.Add );
            AddIf( null != (((object)this._parentClusterResourceId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonString(this._parentClusterResourceId.ToString()) : null, "parentClusterResourceId" ,container.Add );
            AddIf( null != (((object)this._privateLinkScopeResourceId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonString(this._privateLinkScopeResourceId.ToString()) : null, "privateLinkScopeResourceId" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}