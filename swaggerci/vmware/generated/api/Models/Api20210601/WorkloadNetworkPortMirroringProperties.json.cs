namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>NSX Port Mirroring Properties</summary>
    public partial class WorkloadNetworkPortMirroringProperties
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IWorkloadNetworkPortMirroringProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IWorkloadNetworkPortMirroringProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IWorkloadNetworkPortMirroringProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonObject json ? new WorkloadNetworkPortMirroringProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="WorkloadNetworkPortMirroringProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="WorkloadNetworkPortMirroringProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._displayName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonString(this._displayName.ToString()) : null, "displayName" ,container.Add );
            AddIf( null != (((object)this._direction)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonString(this._direction.ToString()) : null, "direction" ,container.Add );
            AddIf( null != (((object)this._source)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonString(this._source.ToString()) : null, "source" ,container.Add );
            AddIf( null != (((object)this._destination)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonString(this._destination.ToString()) : null, "destination" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._status)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonString(this._status.ToString()) : null, "status" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            AddIf( null != this._revision ? (Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonNumber((long)this._revision) : null, "revision" ,container.Add );
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonObject into a new instance of <see cref="WorkloadNetworkPortMirroringProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal WorkloadNetworkPortMirroringProperties(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_displayName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonString>("displayName"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)DisplayName;}
            {_direction = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonString>("direction"), out var __jsonDirection) ? (string)__jsonDirection : (string)Direction;}
            {_source = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonString>("source"), out var __jsonSource) ? (string)__jsonSource : (string)Source;}
            {_destination = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonString>("destination"), out var __jsonDestination) ? (string)__jsonDestination : (string)Destination;}
            {_status = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonString>("status"), out var __jsonStatus) ? (string)__jsonStatus : (string)Status;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)ProvisioningState;}
            {_revision = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonNumber>("revision"), out var __jsonRevision) ? (long?)__jsonRevision : Revision;}
            AfterFromJson(json);
        }
    }
}