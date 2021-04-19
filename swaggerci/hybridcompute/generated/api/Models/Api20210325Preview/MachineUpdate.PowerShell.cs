namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.PowerShell;

    /// <summary>Describes a hybrid machine Update.</summary>
    [System.ComponentModel.TypeConverter(typeof(MachineUpdateTypeConverter))]
    public partial class MachineUpdate
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.MachineUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdate" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdate DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MachineUpdate(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.MachineUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdate" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdate DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MachineUpdate(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MachineUpdate" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdate FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.MachineUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MachineUpdate(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IdentityTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.MachineUpdatePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IResourceUpdateInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IResourceUpdateTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IResourceUpdateInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.ResourceUpdateTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).IdentityTenantId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).LocationData = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ILocationData) content.GetValueForProperty("LocationData",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).LocationData, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.LocationDataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).IdentityType = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.ResourceIdentityType?) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).IdentityType, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.ResourceIdentityType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).ParentClusterResourceId = (string) content.GetValueForProperty("ParentClusterResourceId",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).ParentClusterResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).PrivateLinkScopeResourceId = (string) content.GetValueForProperty("PrivateLinkScopeResourceId",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).PrivateLinkScopeResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).LocationDataName = (string) content.GetValueForProperty("LocationDataName",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).LocationDataName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).LocationDataCity = (string) content.GetValueForProperty("LocationDataCity",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).LocationDataCity, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).LocationDataDistrict = (string) content.GetValueForProperty("LocationDataDistrict",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).LocationDataDistrict, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).LocationDataCountryOrRegion = (string) content.GetValueForProperty("LocationDataCountryOrRegion",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).LocationDataCountryOrRegion, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.MachineUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MachineUpdate(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IdentityTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.MachineUpdatePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IResourceUpdateInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IResourceUpdateTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IResourceUpdateInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.ResourceUpdateTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).IdentityTenantId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).LocationData = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ILocationData) content.GetValueForProperty("LocationData",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).LocationData, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.LocationDataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).IdentityType = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.ResourceIdentityType?) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).IdentityType, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.ResourceIdentityType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).ParentClusterResourceId = (string) content.GetValueForProperty("ParentClusterResourceId",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).ParentClusterResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).PrivateLinkScopeResourceId = (string) content.GetValueForProperty("PrivateLinkScopeResourceId",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).PrivateLinkScopeResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).LocationDataName = (string) content.GetValueForProperty("LocationDataName",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).LocationDataName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).LocationDataCity = (string) content.GetValueForProperty("LocationDataCity",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).LocationDataCity, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).LocationDataDistrict = (string) content.GetValueForProperty("LocationDataDistrict",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).LocationDataDistrict, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).LocationDataCountryOrRegion = (string) content.GetValueForProperty("LocationDataCountryOrRegion",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineUpdateInternal)this).LocationDataCountryOrRegion, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Describes a hybrid machine Update.
    [System.ComponentModel.TypeConverter(typeof(MachineUpdateTypeConverter))]
    public partial interface IMachineUpdate

    {

    }
}