namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>Workspace properties.</summary>
    public partial class WorkspaceProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject json ? new WorkspaceProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="WorkspaceProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="WorkspaceProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._sku ? (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode) this._sku.ToJson(null,serializationMode) : null, "sku" ,container.Add );
            AddIf( null != this._workspaceCapping ? (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode) this._workspaceCapping.ToJson(null,serializationMode) : null, "workspaceCapping" ,container.Add );
            AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._customerId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonString(this._customerId.ToString()) : null, "customerId" ,container.Add );
            }
            AddIf( null != this._retentionInDay ? (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNumber((int)this._retentionInDay) : null, "retentionInDays" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._createdDate)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonString(this._createdDate.ToString()) : null, "createdDate" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._modifiedDate)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonString(this._modifiedDate.ToString()) : null, "modifiedDate" ,container.Add );
            }
            AddIf( null != (((object)this._publicNetworkAccessForIngestion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonString(this._publicNetworkAccessForIngestion.ToString()) : null, "publicNetworkAccessForIngestion" ,container.Add );
            AddIf( null != (((object)this._publicNetworkAccessForQuery)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonString(this._publicNetworkAccessForQuery.ToString()) : null, "publicNetworkAccessForQuery" ,container.Add );
            AddIf( null != this._forceCmkForQuery ? (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonBoolean((bool)this._forceCmkForQuery) : null, "forceCmkForQuery" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SerializationMode.IncludeReadOnly))
            {
                if (null != this._privateLinkScopedResource)
                {
                    var __w = new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.XNodeArray();
                    foreach( var __x in this._privateLinkScopedResource )
                    {
                        AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                    }
                    container.Add("privateLinkScopedResources",__w);
                }
            }
            AddIf( null != this._feature ? (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode) this._feature.ToJson(null,serializationMode) : null, "features" ,container.Add );
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject into a new instance of <see cref="WorkspaceProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal WorkspaceProperties(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_sku = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject>("sku"), out var __jsonSku) ? Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.WorkspaceSku.FromJson(__jsonSku) : Sku;}
            {_workspaceCapping = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject>("workspaceCapping"), out var __jsonWorkspaceCapping) ? Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.WorkspaceCapping.FromJson(__jsonWorkspaceCapping) : WorkspaceCapping;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)ProvisioningState;}
            {_customerId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonString>("customerId"), out var __jsonCustomerId) ? (string)__jsonCustomerId : (string)CustomerId;}
            {_retentionInDay = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNumber>("retentionInDays"), out var __jsonRetentionInDays) ? (int?)__jsonRetentionInDays : RetentionInDay;}
            {_createdDate = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonString>("createdDate"), out var __jsonCreatedDate) ? (string)__jsonCreatedDate : (string)CreatedDate;}
            {_modifiedDate = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonString>("modifiedDate"), out var __jsonModifiedDate) ? (string)__jsonModifiedDate : (string)ModifiedDate;}
            {_publicNetworkAccessForIngestion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonString>("publicNetworkAccessForIngestion"), out var __jsonPublicNetworkAccessForIngestion) ? (string)__jsonPublicNetworkAccessForIngestion : (string)PublicNetworkAccessForIngestion;}
            {_publicNetworkAccessForQuery = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonString>("publicNetworkAccessForQuery"), out var __jsonPublicNetworkAccessForQuery) ? (string)__jsonPublicNetworkAccessForQuery : (string)PublicNetworkAccessForQuery;}
            {_forceCmkForQuery = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonBoolean>("forceCmkForQuery"), out var __jsonForceCmkForQuery) ? (bool?)__jsonForceCmkForQuery : ForceCmkForQuery;}
            {_privateLinkScopedResource = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonArray>("privateLinkScopedResources"), out var __jsonPrivateLinkScopedResources) ? If( __jsonPrivateLinkScopedResources as Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IPrivateLinkScopedResource[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IPrivateLinkScopedResource) (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.PrivateLinkScopedResource.FromJson(__u) )) ))() : null : PrivateLinkScopedResource;}
            {_feature = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject>("features"), out var __jsonFeatures) ? Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.WorkspaceFeatures.FromJson(__jsonFeatures) : Feature;}
            AfterFromJson(json);
        }
    }
}