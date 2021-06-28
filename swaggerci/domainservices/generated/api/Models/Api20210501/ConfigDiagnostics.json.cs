namespace Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Extensions;

    /// <summary>Configuration Diagnostics</summary>
    public partial class ConfigDiagnostics
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Json.JsonObject into a new instance of <see cref="ConfigDiagnostics" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ConfigDiagnostics(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_lastExecuted = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Json.JsonString>("lastExecuted"), out var __jsonLastExecuted) ? global::System.DateTime.TryParse((string)__jsonLastExecuted, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonLastExecutedValue) ? __jsonLastExecutedValue : LastExecuted : LastExecuted;}
            {_validatorResult = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Json.JsonArray>("validatorResults"), out var __jsonValidatorResults) ? If( __jsonValidatorResults as Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IConfigDiagnosticsValidatorResult[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IConfigDiagnosticsValidatorResult) (Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.ConfigDiagnosticsValidatorResult.FromJson(__u) )) ))() : null : ValidatorResult;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IConfigDiagnostics.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IConfigDiagnostics.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IConfigDiagnostics FromJson(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Json.JsonObject json ? new ConfigDiagnostics(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="ConfigDiagnostics" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ConfigDiagnostics" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._lastExecuted ? (Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Json.JsonString(this._lastExecuted?.ToString(@"R",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "lastExecuted" ,container.Add );
            if (null != this._validatorResult)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Json.XNodeArray();
                foreach( var __x in this._validatorResult )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("validatorResults",__w);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}