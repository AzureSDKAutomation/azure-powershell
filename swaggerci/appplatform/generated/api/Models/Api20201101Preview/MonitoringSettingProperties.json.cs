namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Monitoring Setting properties payload</summary>
    public partial class MonitoringSettingProperties
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonObject json ? new MonitoringSettingProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonObject into a new instance of <see cref="MonitoringSettingProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal MonitoringSettingProperties(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_error = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonObject>("error"), out var __jsonError) ? Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.Error.FromJson(__jsonError) : Error;}
            {_appInsightsAgentVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonObject>("appInsightsAgentVersions"), out var __jsonAppInsightsAgentVersions) ? Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ApplicationInsightsAgentVersions.FromJson(__jsonAppInsightsAgentVersions) : AppInsightsAgentVersion;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)ProvisioningState;}
            {_traceEnabled = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonBoolean>("traceEnabled"), out var __jsonTraceEnabled) ? (bool?)__jsonTraceEnabled : TraceEnabled;}
            {_appInsightsInstrumentationKey = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonString>("appInsightsInstrumentationKey"), out var __jsonAppInsightsInstrumentationKey) ? (string)__jsonAppInsightsInstrumentationKey : (string)AppInsightsInstrumentationKey;}
            {_appInsightsSamplingRate = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNumber>("appInsightsSamplingRate"), out var __jsonAppInsightsSamplingRate) ? (double?)__jsonAppInsightsSamplingRate : AppInsightsSamplingRate;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="MonitoringSettingProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MonitoringSettingProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._error ? (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode) this._error.ToJson(null,serializationMode) : null, "error" ,container.Add );
            AddIf( null != this._appInsightsAgentVersion ? (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode) this._appInsightsAgentVersion.ToJson(null,serializationMode) : null, "appInsightsAgentVersions" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            AddIf( null != this._traceEnabled ? (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonBoolean((bool)this._traceEnabled) : null, "traceEnabled" ,container.Add );
            AddIf( null != (((object)this._appInsightsInstrumentationKey)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonString(this._appInsightsInstrumentationKey.ToString()) : null, "appInsightsInstrumentationKey" ,container.Add );
            AddIf( null != this._appInsightsSamplingRate ? (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNumber((double)this._appInsightsSamplingRate) : null, "appInsightsSamplingRate" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}