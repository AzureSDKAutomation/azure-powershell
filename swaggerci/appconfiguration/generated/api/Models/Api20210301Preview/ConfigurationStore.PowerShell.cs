namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.PowerShell;

    /// <summary>
    /// The configuration store along with all resource properties. The Configuration Store will have all information to begin
    /// utilizing it.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(ConfigurationStoreTypeConverter))]
    public partial class ConfigurationStore
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.ConfigurationStore"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ConfigurationStore(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IResourceIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.ResourceIdentityTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.ConfigurationStorePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.ISku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.SkuTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20.SystemDataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20.TrackedResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).IdentityType = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.IdentityType?) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).IdentityType, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.IdentityType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).SkuName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).IdentityUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IResourceIdentityUserAssignedIdentities) content.GetValueForProperty("IdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).IdentityUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.ResourceIdentityUserAssignedIdentitiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).IdentityTenantId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).Encryption = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IEncryptionProperties) content.GetValueForProperty("Encryption",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).Encryption, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.EncryptionPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).CreationDate = (global::System.DateTime?) content.GetValueForProperty("CreationDate",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).CreationDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).Endpoint = (string) content.GetValueForProperty("Endpoint",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).Endpoint, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).PrivateEndpointConnection = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpointConnectionReference[]) content.GetValueForProperty("PrivateEndpointConnection",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).PrivateEndpointConnection, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpointConnectionReference>(__y, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.PrivateEndpointConnectionReferenceTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).PublicNetworkAccess = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.PublicNetworkAccess?) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).PublicNetworkAccess, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.PublicNetworkAccess.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).DisableLocalAuth = (bool?) content.GetValueForProperty("DisableLocalAuth",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).DisableLocalAuth, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).EncryptionKeyVaultProperty = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IKeyVaultProperties) content.GetValueForProperty("EncryptionKeyVaultProperty",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).EncryptionKeyVaultProperty, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.KeyVaultPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).KeyVaultPropertyKeyIdentifier = (string) content.GetValueForProperty("KeyVaultPropertyKeyIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).KeyVaultPropertyKeyIdentifier, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).KeyVaultPropertyIdentityClientId = (string) content.GetValueForProperty("KeyVaultPropertyIdentityClientId",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).KeyVaultPropertyIdentityClientId, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.ConfigurationStore"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ConfigurationStore(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IResourceIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.ResourceIdentityTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.ConfigurationStorePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.ISku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.SkuTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20.SystemDataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20.TrackedResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).IdentityType = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.IdentityType?) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).IdentityType, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.IdentityType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).SkuName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).IdentityUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IResourceIdentityUserAssignedIdentities) content.GetValueForProperty("IdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).IdentityUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.ResourceIdentityUserAssignedIdentitiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).IdentityTenantId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).Encryption = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IEncryptionProperties) content.GetValueForProperty("Encryption",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).Encryption, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.EncryptionPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).CreationDate = (global::System.DateTime?) content.GetValueForProperty("CreationDate",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).CreationDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).Endpoint = (string) content.GetValueForProperty("Endpoint",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).Endpoint, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).PrivateEndpointConnection = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpointConnectionReference[]) content.GetValueForProperty("PrivateEndpointConnection",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).PrivateEndpointConnection, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IPrivateEndpointConnectionReference>(__y, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.PrivateEndpointConnectionReferenceTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).PublicNetworkAccess = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.PublicNetworkAccess?) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).PublicNetworkAccess, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.PublicNetworkAccess.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).DisableLocalAuth = (bool?) content.GetValueForProperty("DisableLocalAuth",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).DisableLocalAuth, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).EncryptionKeyVaultProperty = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IKeyVaultProperties) content.GetValueForProperty("EncryptionKeyVaultProperty",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).EncryptionKeyVaultProperty, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.KeyVaultPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).KeyVaultPropertyKeyIdentifier = (string) content.GetValueForProperty("KeyVaultPropertyKeyIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).KeyVaultPropertyKeyIdentifier, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).KeyVaultPropertyIdentityClientId = (string) content.GetValueForProperty("KeyVaultPropertyIdentityClientId",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStoreInternal)this).KeyVaultPropertyIdentityClientId, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.ConfigurationStore"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStore"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStore DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ConfigurationStore(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.ConfigurationStore"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStore"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStore DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ConfigurationStore(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ConfigurationStore" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IConfigurationStore FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The configuration store along with all resource properties. The Configuration Store will have all information to begin
    /// utilizing it.
    [System.ComponentModel.TypeConverter(typeof(ConfigurationStoreTypeConverter))]
    public partial interface IConfigurationStore

    {

    }
}