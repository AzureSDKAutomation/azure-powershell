namespace Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Extensions;

    /// <summary>The properties for a group information object.</summary>
    public partial class GroupIdInformationProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IGroupIdInformationProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IGroupIdInformationProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IGroupIdInformationProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.JsonObject json ? new GroupIdInformationProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.JsonObject into a new instance of <see cref="GroupIdInformationProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal GroupIdInformationProperties(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_groupId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.JsonString>("groupId"), out var __jsonGroupId) ? (string)__jsonGroupId : (string)GroupId;}
            {_requiredMember = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.JsonArray>("requiredMembers"), out var __jsonRequiredMembers) ? If( __jsonRequiredMembers as Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : RequiredMember;}
            {_requiredZoneName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.JsonArray>("requiredZoneNames"), out var __jsonRequiredZoneNames) ? If( __jsonRequiredZoneNames as Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(string) (__p is Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.JsonString __o ? (string)(__o.ToString()) : null)) ))() : null : RequiredZoneName;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="GroupIdInformationProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="GroupIdInformationProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._groupId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.JsonString(this._groupId.ToString()) : null, "groupId" ,container.Add );
            if (null != this._requiredMember)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.XNodeArray();
                foreach( var __x in this._requiredMember )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("requiredMembers",__w);
            }
            if (null != this._requiredZoneName)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.XNodeArray();
                foreach( var __s in this._requiredZoneName )
                {
                    AddIf(null != (((object)__s)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.JsonString(__s.ToString()) : null ,__r.Add);
                }
                container.Add("requiredZoneNames",__r);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}