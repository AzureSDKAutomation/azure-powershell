namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Deployment instance payload</summary>
    public partial class DeploymentInstance
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
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonObject into a new instance of <see cref="DeploymentInstance" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal DeploymentInstance(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_name = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_status = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonString>("status"), out var __jsonStatus) ? (string)__jsonStatus : (string)Status;}
            {_reason = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonString>("reason"), out var __jsonReason) ? (string)__jsonReason : (string)Reason;}
            {_discoveryStatus = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonString>("discoveryStatus"), out var __jsonDiscoveryStatus) ? (string)__jsonDiscoveryStatus : (string)DiscoveryStatus;}
            {_startTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonString>("startTime"), out var __jsonStartTime) ? (string)__jsonStartTime : (string)StartTime;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentInstance.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentInstance.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentInstance FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonObject json ? new DeploymentInstance(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="DeploymentInstance" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="DeploymentInstance" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode" />.
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
                AddIf( null != (((object)this._name)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._status)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonString(this._status.ToString()) : null, "status" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._reason)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonString(this._reason.ToString()) : null, "reason" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._discoveryStatus)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonString(this._discoveryStatus.ToString()) : null, "discoveryStatus" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._startTime)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonString(this._startTime.ToString()) : null, "startTime" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}