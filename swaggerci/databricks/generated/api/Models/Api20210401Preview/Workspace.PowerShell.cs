namespace Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.PowerShell;

    /// <summary>Information about workspace.</summary>
    [System.ComponentModel.TypeConverter(typeof(WorkspaceTypeConverter))]
    public partial class Workspace
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.Workspace"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspace" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspace DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Workspace(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.Workspace"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspace" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspace DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Workspace(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Workspace" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspace FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.Workspace"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Workspace(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspacePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ISku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.SkuTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20.SystemDataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.TrackedResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).CreatedBy = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ICreatedBy) content.GetValueForProperty("CreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).CreatedBy, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.CreatedByTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.ProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SkuName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SkuTier = (string) content.GetValueForProperty("SkuTier",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SkuTier, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).UpdatedBy = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ICreatedBy) content.GetValueForProperty("UpdatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).UpdatedBy, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.CreatedByTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).StorageAccountIdentity = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IManagedIdentityConfiguration) content.GetValueForProperty("StorageAccountIdentity",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).StorageAccountIdentity, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ManagedIdentityConfigurationTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).Encryption = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesEncryption) content.GetValueForProperty("Encryption",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).Encryption, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspacePropertiesEncryptionTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).ManagedResourceGroupId = (string) content.GetValueForProperty("ManagedResourceGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).ManagedResourceGroupId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).UiDefinitionUri = (string) content.GetValueForProperty("UiDefinitionUri",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).UiDefinitionUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).Authorization = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceProviderAuthorization[]) content.GetValueForProperty("Authorization",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).Authorization, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceProviderAuthorization>(__y, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceProviderAuthorizationTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).CreatedDateTime = (global::System.DateTime?) content.GetValueForProperty("CreatedDateTime",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).CreatedDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).WorkspaceId = (string) content.GetValueForProperty("WorkspaceId",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).WorkspaceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).Url = (string) content.GetValueForProperty("Url",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).Url, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).Parameter = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParameters) content.GetValueForProperty("Parameter",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).Parameter, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceCustomParametersTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).CreatedByOid = (string) content.GetValueForProperty("CreatedByOid",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).CreatedByOid, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).CreatedByPuid = (string) content.GetValueForProperty("CreatedByPuid",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).CreatedByPuid, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).CreatedByApplicationId = (string) content.GetValueForProperty("CreatedByApplicationId",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).CreatedByApplicationId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).UpdatedByOid = (string) content.GetValueForProperty("UpdatedByOid",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).UpdatedByOid, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).UpdatedByPuid = (string) content.GetValueForProperty("UpdatedByPuid",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).UpdatedByPuid, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).UpdatedByApplicationId = (string) content.GetValueForProperty("UpdatedByApplicationId",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).UpdatedByApplicationId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).StorageAccountIdentityPrincipalId = (string) content.GetValueForProperty("StorageAccountIdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).StorageAccountIdentityPrincipalId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).StorageAccountIdentityTenantId = (string) content.GetValueForProperty("StorageAccountIdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).StorageAccountIdentityTenantId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).StorageAccountIdentityType = (string) content.GetValueForProperty("StorageAccountIdentityType",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).StorageAccountIdentityType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).EncryptionEntity = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinition) content.GetValueForProperty("EncryptionEntity",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).EncryptionEntity, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.EncryptionEntitiesDefinitionTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).EntityManagedService = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2) content.GetValueForProperty("EntityManagedService",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).EntityManagedService, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.EncryptionV2TypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).ManagedServiceKeyVaultProperty = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2KeyVaultProperties) content.GetValueForProperty("ManagedServiceKeyVaultProperty",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).ManagedServiceKeyVaultProperty, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.EncryptionV2KeyVaultPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).ManagedServiceKeySource = (string) content.GetValueForProperty("ManagedServiceKeySource",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).ManagedServiceKeySource, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).KeyVaultPropertyKeyVaultUri = (string) content.GetValueForProperty("KeyVaultPropertyKeyVaultUri",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).KeyVaultPropertyKeyVaultUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).KeyVaultPropertyKeyName = (string) content.GetValueForProperty("KeyVaultPropertyKeyName",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).KeyVaultPropertyKeyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).KeyVaultPropertyKeyVersion = (string) content.GetValueForProperty("KeyVaultPropertyKeyVersion",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).KeyVaultPropertyKeyVersion, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.Workspace"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Workspace(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspacePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ISku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.SkuTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20.SystemDataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.TrackedResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).CreatedBy = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ICreatedBy) content.GetValueForProperty("CreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).CreatedBy, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.CreatedByTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.ProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SkuName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SkuTier = (string) content.GetValueForProperty("SkuTier",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SkuTier, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).UpdatedBy = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ICreatedBy) content.GetValueForProperty("UpdatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).UpdatedBy, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.CreatedByTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).StorageAccountIdentity = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IManagedIdentityConfiguration) content.GetValueForProperty("StorageAccountIdentity",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).StorageAccountIdentity, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ManagedIdentityConfigurationTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).Encryption = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesEncryption) content.GetValueForProperty("Encryption",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).Encryption, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspacePropertiesEncryptionTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).ManagedResourceGroupId = (string) content.GetValueForProperty("ManagedResourceGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).ManagedResourceGroupId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).UiDefinitionUri = (string) content.GetValueForProperty("UiDefinitionUri",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).UiDefinitionUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).Authorization = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceProviderAuthorization[]) content.GetValueForProperty("Authorization",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).Authorization, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceProviderAuthorization>(__y, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceProviderAuthorizationTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).CreatedDateTime = (global::System.DateTime?) content.GetValueForProperty("CreatedDateTime",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).CreatedDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).WorkspaceId = (string) content.GetValueForProperty("WorkspaceId",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).WorkspaceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).Url = (string) content.GetValueForProperty("Url",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).Url, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).Parameter = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParameters) content.GetValueForProperty("Parameter",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).Parameter, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceCustomParametersTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).CreatedByOid = (string) content.GetValueForProperty("CreatedByOid",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).CreatedByOid, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).CreatedByPuid = (string) content.GetValueForProperty("CreatedByPuid",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).CreatedByPuid, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).CreatedByApplicationId = (string) content.GetValueForProperty("CreatedByApplicationId",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).CreatedByApplicationId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).UpdatedByOid = (string) content.GetValueForProperty("UpdatedByOid",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).UpdatedByOid, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).UpdatedByPuid = (string) content.GetValueForProperty("UpdatedByPuid",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).UpdatedByPuid, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).UpdatedByApplicationId = (string) content.GetValueForProperty("UpdatedByApplicationId",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).UpdatedByApplicationId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).StorageAccountIdentityPrincipalId = (string) content.GetValueForProperty("StorageAccountIdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).StorageAccountIdentityPrincipalId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).StorageAccountIdentityTenantId = (string) content.GetValueForProperty("StorageAccountIdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).StorageAccountIdentityTenantId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).StorageAccountIdentityType = (string) content.GetValueForProperty("StorageAccountIdentityType",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).StorageAccountIdentityType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).EncryptionEntity = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinition) content.GetValueForProperty("EncryptionEntity",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).EncryptionEntity, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.EncryptionEntitiesDefinitionTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).EntityManagedService = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2) content.GetValueForProperty("EntityManagedService",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).EntityManagedService, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.EncryptionV2TypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).ManagedServiceKeyVaultProperty = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2KeyVaultProperties) content.GetValueForProperty("ManagedServiceKeyVaultProperty",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).ManagedServiceKeyVaultProperty, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.EncryptionV2KeyVaultPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).ManagedServiceKeySource = (string) content.GetValueForProperty("ManagedServiceKeySource",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).ManagedServiceKeySource, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).KeyVaultPropertyKeyVaultUri = (string) content.GetValueForProperty("KeyVaultPropertyKeyVaultUri",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).KeyVaultPropertyKeyVaultUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).KeyVaultPropertyKeyName = (string) content.GetValueForProperty("KeyVaultPropertyKeyName",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).KeyVaultPropertyKeyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).KeyVaultPropertyKeyVersion = (string) content.GetValueForProperty("KeyVaultPropertyKeyVersion",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal)this).KeyVaultPropertyKeyVersion, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }
    }
    /// Information about workspace.
    [System.ComponentModel.TypeConverter(typeof(WorkspaceTypeConverter))]
    public partial interface IWorkspace

    {

    }
}