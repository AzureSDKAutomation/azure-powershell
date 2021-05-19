namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210401Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    /// <summary>Properties of HostPool.</summary>
    public partial class HostPoolProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210401Preview.IHostPoolProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210401Preview.IHostPoolProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210401Preview.IHostPoolProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonObject json ? new HostPoolProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonObject into a new instance of <see cref="HostPoolProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal HostPoolProperties(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_registrationInfo = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonObject>("registrationInfo"), out var __jsonRegistrationInfo) ? Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210401Preview.RegistrationInfo.FromJson(__jsonRegistrationInfo) : RegistrationInfo;}
            {_migrationRequest = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonObject>("migrationRequest"), out var __jsonMigrationRequest) ? Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210401Preview.MigrationRequestProperties.FromJson(__jsonMigrationRequest) : MigrationRequest;}
            {_objectId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonString>("objectId"), out var __jsonObjectId) ? (string)__jsonObjectId : (string)ObjectId;}
            {_friendlyName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonString>("friendlyName"), out var __jsonFriendlyName) ? (string)__jsonFriendlyName : (string)FriendlyName;}
            {_description = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)Description;}
            {_newProperty = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonString>("newProperty"), out var __jsonNewProperty) ? (string)__jsonNewProperty : (string)NewProperty;}
            {_hostPoolType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonString>("hostPoolType"), out var __jsonHostPoolType) ? (string)__jsonHostPoolType : (string)HostPoolType;}
            {_personalDesktopAssignmentType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonString>("personalDesktopAssignmentType"), out var __jsonPersonalDesktopAssignmentType) ? (string)__jsonPersonalDesktopAssignmentType : (string)PersonalDesktopAssignmentType;}
            {_customRdpProperty = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonString>("customRdpProperty"), out var __jsonCustomRdpProperty) ? (string)__jsonCustomRdpProperty : (string)CustomRdpProperty;}
            {_maxSessionLimit = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNumber>("maxSessionLimit"), out var __jsonMaxSessionLimit) ? (int?)__jsonMaxSessionLimit : MaxSessionLimit;}
            {_loadBalancerType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonString>("loadBalancerType"), out var __jsonLoadBalancerType) ? (string)__jsonLoadBalancerType : (string)LoadBalancerType;}
            {_ring = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNumber>("ring"), out var __jsonRing) ? (int?)__jsonRing : Ring;}
            {_validationEnvironment = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonBoolean>("validationEnvironment"), out var __jsonValidationEnvironment) ? (bool?)__jsonValidationEnvironment : ValidationEnvironment;}
            {_vMTemplate = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonString>("vmTemplate"), out var __jsonVMTemplate) ? (string)__jsonVMTemplate : (string)VMTemplate;}
            {_applicationGroupReference = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonArray>("applicationGroupReferences"), out var __jsonApplicationGroupReferences) ? If( __jsonApplicationGroupReferences as Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : ApplicationGroupReference;}
            {_ssoadfsAuthority = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonString>("ssoadfsAuthority"), out var __jsonSsoadfsAuthority) ? (string)__jsonSsoadfsAuthority : (string)SsoadfsAuthority;}
            {_ssoClientId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonString>("ssoClientId"), out var __jsonSsoClientId) ? (string)__jsonSsoClientId : (string)SsoClientId;}
            {_ssoClientSecretKeyVaultPath = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonString>("ssoClientSecretKeyVaultPath"), out var __jsonSsoClientSecretKeyVaultPath) ? (string)__jsonSsoClientSecretKeyVaultPath : (string)SsoClientSecretKeyVaultPath;}
            {_ssoSecretType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonString>("ssoSecretType"), out var __jsonSsoSecretType) ? (string)__jsonSsoSecretType : (string)SsoSecretType;}
            {_preferredAppGroupType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonString>("preferredAppGroupType"), out var __jsonPreferredAppGroupType) ? (string)__jsonPreferredAppGroupType : (string)PreferredAppGroupType;}
            {_startVMOnConnect = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonBoolean>("startVMOnConnect"), out var __jsonStartVMOnConnect) ? (bool?)__jsonStartVMOnConnect : StartVMOnConnect;}
            {_cloudPcResource = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonBoolean>("cloudPcResource"), out var __jsonCloudPcResource) ? (bool?)__jsonCloudPcResource : CloudPcResource;}
            {_publicNetworkAccess = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonString>("publicNetworkAccess"), out var __jsonPublicNetworkAccess) ? (string)__jsonPublicNetworkAccess : (string)PublicNetworkAccess;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="HostPoolProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="HostPoolProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._registrationInfo ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNode) this._registrationInfo.ToJson(null,serializationMode) : null, "registrationInfo" ,container.Add );
            AddIf( null != this._migrationRequest ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNode) this._migrationRequest.ToJson(null,serializationMode) : null, "migrationRequest" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._objectId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonString(this._objectId.ToString()) : null, "objectId" ,container.Add );
            }
            AddIf( null != (((object)this._friendlyName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonString(this._friendlyName.ToString()) : null, "friendlyName" ,container.Add );
            AddIf( null != (((object)this._description)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonString(this._description.ToString()) : null, "description" ,container.Add );
            AddIf( null != (((object)this._newProperty)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonString(this._newProperty.ToString()) : null, "newProperty" ,container.Add );
            AddIf( null != (((object)this._hostPoolType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonString(this._hostPoolType.ToString()) : null, "hostPoolType" ,container.Add );
            AddIf( null != (((object)this._personalDesktopAssignmentType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonString(this._personalDesktopAssignmentType.ToString()) : null, "personalDesktopAssignmentType" ,container.Add );
            AddIf( null != (((object)this._customRdpProperty)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonString(this._customRdpProperty.ToString()) : null, "customRdpProperty" ,container.Add );
            AddIf( null != this._maxSessionLimit ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNumber((int)this._maxSessionLimit) : null, "maxSessionLimit" ,container.Add );
            AddIf( null != (((object)this._loadBalancerType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonString(this._loadBalancerType.ToString()) : null, "loadBalancerType" ,container.Add );
            AddIf( null != this._ring ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNumber((int)this._ring) : null, "ring" ,container.Add );
            AddIf( null != this._validationEnvironment ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonBoolean((bool)this._validationEnvironment) : null, "validationEnvironment" ,container.Add );
            AddIf( null != (((object)this._vMTemplate)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonString(this._vMTemplate.ToString()) : null, "vmTemplate" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.SerializationMode.IncludeReadOnly))
            {
                if (null != this._applicationGroupReference)
                {
                    var __w = new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.XNodeArray();
                    foreach( var __x in this._applicationGroupReference )
                    {
                        AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                    }
                    container.Add("applicationGroupReferences",__w);
                }
            }
            AddIf( null != (((object)this._ssoadfsAuthority)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonString(this._ssoadfsAuthority.ToString()) : null, "ssoadfsAuthority" ,container.Add );
            AddIf( null != (((object)this._ssoClientId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonString(this._ssoClientId.ToString()) : null, "ssoClientId" ,container.Add );
            AddIf( null != (((object)this._ssoClientSecretKeyVaultPath)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonString(this._ssoClientSecretKeyVaultPath.ToString()) : null, "ssoClientSecretKeyVaultPath" ,container.Add );
            AddIf( null != (((object)this._ssoSecretType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonString(this._ssoSecretType.ToString()) : null, "ssoSecretType" ,container.Add );
            AddIf( null != (((object)this._preferredAppGroupType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonString(this._preferredAppGroupType.ToString()) : null, "preferredAppGroupType" ,container.Add );
            AddIf( null != this._startVMOnConnect ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonBoolean((bool)this._startVMOnConnect) : null, "startVMOnConnect" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._cloudPcResource ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonBoolean((bool)this._cloudPcResource) : null, "cloudPcResource" ,container.Add );
            }
            AddIf( null != (((object)this._publicNetworkAccess)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonString(this._publicNetworkAccess.ToString()) : null, "publicNetworkAccess" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}