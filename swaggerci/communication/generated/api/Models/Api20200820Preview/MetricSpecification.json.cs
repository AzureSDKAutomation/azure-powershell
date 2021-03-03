namespace Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Extensions;

    /// <summary>Specifications of the Metrics for Azure Monitoring.</summary>
    public partial class MetricSpecification
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820Preview.IMetricSpecification.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820Preview.IMetricSpecification.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820Preview.IMetricSpecification FromJson(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonObject json ? new MetricSpecification(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonObject into a new instance of <see cref="MetricSpecification" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal MetricSpecification(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_name = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_displayName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonString>("displayName"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)DisplayName;}
            {_displayDescription = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonString>("displayDescription"), out var __jsonDisplayDescription) ? (string)__jsonDisplayDescription : (string)DisplayDescription;}
            {_unit = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonString>("unit"), out var __jsonUnit) ? (string)__jsonUnit : (string)Unit;}
            {_aggregationType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonString>("aggregationType"), out var __jsonAggregationType) ? (string)__jsonAggregationType : (string)AggregationType;}
            {_fillGapWithZero = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonString>("fillGapWithZero"), out var __jsonFillGapWithZero) ? (string)__jsonFillGapWithZero : (string)FillGapWithZero;}
            {_category = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonString>("category"), out var __jsonCategory) ? (string)__jsonCategory : (string)Category;}
            {_dimension = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonArray>("dimensions"), out var __jsonDimensions) ? If( __jsonDimensions as Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820Preview.IDimension[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820Preview.IDimension) (Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820Preview.Dimension.FromJson(__u) )) ))() : null : Dimension;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="MetricSpecification" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MetricSpecification" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._name)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            AddIf( null != (((object)this._displayName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonString(this._displayName.ToString()) : null, "displayName" ,container.Add );
            AddIf( null != (((object)this._displayDescription)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonString(this._displayDescription.ToString()) : null, "displayDescription" ,container.Add );
            AddIf( null != (((object)this._unit)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonString(this._unit.ToString()) : null, "unit" ,container.Add );
            AddIf( null != (((object)this._aggregationType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonString(this._aggregationType.ToString()) : null, "aggregationType" ,container.Add );
            AddIf( null != (((object)this._fillGapWithZero)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonString(this._fillGapWithZero.ToString()) : null, "fillGapWithZero" ,container.Add );
            AddIf( null != (((object)this._category)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonString(this._category.ToString()) : null, "category" ,container.Add );
            if (null != this._dimension)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.XNodeArray();
                foreach( var __x in this._dimension )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("dimensions",__w);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}