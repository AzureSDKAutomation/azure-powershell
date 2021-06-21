namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621
{
    using Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.PowerShell;

    /// <summary>Properties that define a Azure Arc PrivateLinkScope resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(HybridComputePrivateLinkScopePropertiesTypeConverter))]
    public partial class HybridComputePrivateLinkScopeProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.HybridComputePrivateLinkScopeProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IHybridComputePrivateLinkScopeProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IHybridComputePrivateLinkScopeProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new HybridComputePrivateLinkScopeProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.HybridComputePrivateLinkScopeProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IHybridComputePrivateLinkScopeProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IHybridComputePrivateLinkScopeProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new HybridComputePrivateLinkScopeProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="HybridComputePrivateLinkScopeProperties" />, deserializing the content from a json
        /// string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IHybridComputePrivateLinkScopeProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.HybridComputePrivateLinkScopeProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal HybridComputePrivateLinkScopeProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IHybridComputePrivateLinkScopePropertiesInternal)this).PublicNetworkAccess = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.PublicNetworkAccessType?) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IHybridComputePrivateLinkScopePropertiesInternal)this).PublicNetworkAccess, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.PublicNetworkAccessType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IHybridComputePrivateLinkScopePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IHybridComputePrivateLinkScopePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IHybridComputePrivateLinkScopePropertiesInternal)this).PrivateLinkScopeId = (string) content.GetValueForProperty("PrivateLinkScopeId",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IHybridComputePrivateLinkScopePropertiesInternal)this).PrivateLinkScopeId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IHybridComputePrivateLinkScopePropertiesInternal)this).PrivateEndpointConnection = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IPrivateEndpointConnectionDataModel[]) content.GetValueForProperty("PrivateEndpointConnection",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IHybridComputePrivateLinkScopePropertiesInternal)this).PrivateEndpointConnection, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IPrivateEndpointConnectionDataModel>(__y, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.PrivateEndpointConnectionDataModelTypeConverter.ConvertFrom));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.HybridComputePrivateLinkScopeProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal HybridComputePrivateLinkScopeProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IHybridComputePrivateLinkScopePropertiesInternal)this).PublicNetworkAccess = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.PublicNetworkAccessType?) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IHybridComputePrivateLinkScopePropertiesInternal)this).PublicNetworkAccess, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.PublicNetworkAccessType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IHybridComputePrivateLinkScopePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IHybridComputePrivateLinkScopePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IHybridComputePrivateLinkScopePropertiesInternal)this).PrivateLinkScopeId = (string) content.GetValueForProperty("PrivateLinkScopeId",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IHybridComputePrivateLinkScopePropertiesInternal)this).PrivateLinkScopeId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IHybridComputePrivateLinkScopePropertiesInternal)this).PrivateEndpointConnection = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IPrivateEndpointConnectionDataModel[]) content.GetValueForProperty("PrivateEndpointConnection",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IHybridComputePrivateLinkScopePropertiesInternal)this).PrivateEndpointConnection, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IPrivateEndpointConnectionDataModel>(__y, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.PrivateEndpointConnectionDataModelTypeConverter.ConvertFrom));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Properties that define a Azure Arc PrivateLinkScope resource.
    [System.ComponentModel.TypeConverter(typeof(HybridComputePrivateLinkScopePropertiesTypeConverter))]
    public partial interface IHybridComputePrivateLinkScopeProperties

    {

    }
}