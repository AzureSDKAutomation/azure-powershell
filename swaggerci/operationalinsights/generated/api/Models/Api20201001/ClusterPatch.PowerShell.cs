namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001
{
    using Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.PowerShell;

    /// <summary>The top level Log Analytics cluster resource container.</summary>
    [System.ComponentModel.TypeConverter(typeof(ClusterPatchTypeConverter))]
    public partial class ClusterPatch
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ClusterPatch"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ClusterPatch(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ClusterPatchPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IdentityTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterSku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ClusterSkuTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ClusterPatchTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).IdentityTenantId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).IdentityType = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.IdentityType) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).IdentityType, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.IdentityType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).KeyVaultProperty = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IKeyVaultProperties) content.GetValueForProperty("KeyVaultProperty",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).KeyVaultProperty, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.KeyVaultPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).KeyVaultPropertyKeyName = (string) content.GetValueForProperty("KeyVaultPropertyKeyName",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).KeyVaultPropertyKeyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).KeyVaultPropertyKeyVersion = (string) content.GetValueForProperty("KeyVaultPropertyKeyVersion",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).KeyVaultPropertyKeyVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).IdentityUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentityUserAssignedIdentities) content.GetValueForProperty("IdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).IdentityUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IdentityUserAssignedIdentitiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).SkuCapacity = (long?) content.GetValueForProperty("SkuCapacity",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).SkuCapacity, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).SkuName = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterSkuNameEnum?) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).SkuName, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterSkuNameEnum.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).KeyVaultPropertyKeyVaultUri = (string) content.GetValueForProperty("KeyVaultPropertyKeyVaultUri",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).KeyVaultPropertyKeyVaultUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).KeyVaultPropertyKeyRsaSize = (int?) content.GetValueForProperty("KeyVaultPropertyKeyRsaSize",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).KeyVaultPropertyKeyRsaSize, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ClusterPatch"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ClusterPatch(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ClusterPatchPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IdentityTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterSku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ClusterSkuTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ClusterPatchTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).IdentityTenantId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).IdentityType = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.IdentityType) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).IdentityType, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.IdentityType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).KeyVaultProperty = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IKeyVaultProperties) content.GetValueForProperty("KeyVaultProperty",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).KeyVaultProperty, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.KeyVaultPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).KeyVaultPropertyKeyName = (string) content.GetValueForProperty("KeyVaultPropertyKeyName",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).KeyVaultPropertyKeyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).KeyVaultPropertyKeyVersion = (string) content.GetValueForProperty("KeyVaultPropertyKeyVersion",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).KeyVaultPropertyKeyVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).IdentityUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentityUserAssignedIdentities) content.GetValueForProperty("IdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).IdentityUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IdentityUserAssignedIdentitiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).SkuCapacity = (long?) content.GetValueForProperty("SkuCapacity",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).SkuCapacity, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).SkuName = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterSkuNameEnum?) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).SkuName, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterSkuNameEnum.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).KeyVaultPropertyKeyVaultUri = (string) content.GetValueForProperty("KeyVaultPropertyKeyVaultUri",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).KeyVaultPropertyKeyVaultUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).KeyVaultPropertyKeyRsaSize = (int?) content.GetValueForProperty("KeyVaultPropertyKeyRsaSize",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchInternal)this).KeyVaultPropertyKeyRsaSize, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ClusterPatch"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatch" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatch DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ClusterPatch(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ClusterPatch"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatch" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatch DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ClusterPatch(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ClusterPatch" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatch FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The top level Log Analytics cluster resource container.
    [System.ComponentModel.TypeConverter(typeof(ClusterPatchTypeConverter))]
    public partial interface IClusterPatch

    {

    }
}