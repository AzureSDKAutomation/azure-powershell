namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>Cluster properties.</summary>
    public partial class ClusterProperties
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
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject into a new instance of <see cref="ClusterProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ClusterProperties(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_keyVaultProperty = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject>("keyVaultProperties"), out var __jsonKeyVaultProperties) ? Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.KeyVaultProperties.FromJson(__jsonKeyVaultProperties) : KeyVaultProperty;}
            {_capacityReservationProperty = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject>("capacityReservationProperties"), out var __jsonCapacityReservationProperties) ? Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.CapacityReservationProperties.FromJson(__jsonCapacityReservationProperties) : CapacityReservationProperty;}
            {_clusterId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonString>("clusterId"), out var __jsonClusterId) ? (string)__jsonClusterId : (string)ClusterId;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)ProvisioningState;}
            {_isDoubleEncryptionEnabled = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonBoolean>("isDoubleEncryptionEnabled"), out var __jsonIsDoubleEncryptionEnabled) ? (bool?)__jsonIsDoubleEncryptionEnabled : IsDoubleEncryptionEnabled;}
            {_isAvailabilityZonesEnabled = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonBoolean>("isAvailabilityZonesEnabled"), out var __jsonIsAvailabilityZonesEnabled) ? (bool?)__jsonIsAvailabilityZonesEnabled : IsAvailabilityZonesEnabled;}
            {_billingType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonString>("billingType"), out var __jsonBillingType) ? (string)__jsonBillingType : (string)BillingType;}
            {_lastModifiedDate = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonString>("lastModifiedDate"), out var __jsonLastModifiedDate) ? (string)__jsonLastModifiedDate : (string)LastModifiedDate;}
            {_createdDate = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonString>("createdDate"), out var __jsonCreatedDate) ? (string)__jsonCreatedDate : (string)CreatedDate;}
            {_associatedWorkspace = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonArray>("associatedWorkspaces"), out var __jsonAssociatedWorkspaces) ? If( __jsonAssociatedWorkspaces as Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspace[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspace) (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.AssociatedWorkspace.FromJson(__u) )) ))() : null : AssociatedWorkspace;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject json ? new ClusterProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="ClusterProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ClusterProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._keyVaultProperty ? (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode) this._keyVaultProperty.ToJson(null,serializationMode) : null, "keyVaultProperties" ,container.Add );
            AddIf( null != this._capacityReservationProperty ? (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode) this._capacityReservationProperty.ToJson(null,serializationMode) : null, "capacityReservationProperties" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._clusterId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonString(this._clusterId.ToString()) : null, "clusterId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            AddIf( null != this._isDoubleEncryptionEnabled ? (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonBoolean((bool)this._isDoubleEncryptionEnabled) : null, "isDoubleEncryptionEnabled" ,container.Add );
            AddIf( null != this._isAvailabilityZonesEnabled ? (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonBoolean((bool)this._isAvailabilityZonesEnabled) : null, "isAvailabilityZonesEnabled" ,container.Add );
            AddIf( null != (((object)this._billingType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonString(this._billingType.ToString()) : null, "billingType" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._lastModifiedDate)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonString(this._lastModifiedDate.ToString()) : null, "lastModifiedDate" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._createdDate)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonString(this._createdDate.ToString()) : null, "createdDate" ,container.Add );
            }
            if (null != this._associatedWorkspace)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.XNodeArray();
                foreach( var __x in this._associatedWorkspace )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("associatedWorkspaces",__w);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}