namespace Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Extensions;

    /// <summary>Information about workspace.</summary>
    public partial class Workspace :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspace,
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.TrackedResource();

        /// <summary>The workspace provider authorizations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceProviderAuthorization[] Authorization { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).Authorization; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).Authorization = value ?? null /* arrayOf */; }

        /// <summary>
        /// The application ID of the application that initiated the creation of the workspace. For example, Azure Portal.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string CreatedByApplicationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).CreatedByApplicationId; }

        /// <summary>The Object ID that created the workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string CreatedByOid { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).CreatedByOid; }

        /// <summary>The Personal Object ID corresponding to the object ID above</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string CreatedByPuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).CreatedByPuid; }

        /// <summary>Specifies the date and time when the workspace is created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public global::System.DateTime? CreatedDateTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).CreatedDateTime; }

        /// <summary>
        /// Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal)__trackedResource).Id; }

        /// <summary>The name of KeyVault key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyKeyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).KeyVaultPropertyKeyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).KeyVaultPropertyKeyName = value ?? null; }

        /// <summary>The Uri of KeyVault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyKeyVaultUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).KeyVaultPropertyKeyVaultUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).KeyVaultPropertyKeyVaultUri = value ?? null; }

        /// <summary>The version of KeyVault key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyKeyVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).KeyVaultPropertyKeyVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).KeyVaultPropertyKeyVersion = value ?? null; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ITrackedResourceInternal)__trackedResource).Location = value ; }

        /// <summary>The managed resource group Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string ManagedResourceGroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).ManagedResourceGroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).ManagedResourceGroupId = value ; }

        /// <summary>
        /// The encryption keySource (provider). Possible values (case-insensitive): Microsoft.Keyvault
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string ManagedServiceKeySource { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).ManagedServiceKeySource; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal)__trackedResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal)__trackedResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal)__trackedResource).Type = value; }

        /// <summary>Internal Acessors for CreatedBy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ICreatedBy Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal.CreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).CreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).CreatedBy = value; }

        /// <summary>Internal Acessors for CreatedByApplicationId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal.CreatedByApplicationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).CreatedByApplicationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).CreatedByApplicationId = value; }

        /// <summary>Internal Acessors for CreatedByOid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal.CreatedByOid { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).CreatedByOid; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).CreatedByOid = value; }

        /// <summary>Internal Acessors for CreatedByPuid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal.CreatedByPuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).CreatedByPuid; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).CreatedByPuid = value; }

        /// <summary>Internal Acessors for CreatedDateTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal.CreatedDateTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).CreatedDateTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).CreatedDateTime = value; }

        /// <summary>Internal Acessors for Encryption</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesEncryption Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal.Encryption { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).Encryption; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).Encryption = value; }

        /// <summary>Internal Acessors for EncryptionEntity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinition Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal.EncryptionEntity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).EncryptionEntity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).EncryptionEntity = value; }

        /// <summary>Internal Acessors for EntityManagedService</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2 Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal.EntityManagedService { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).EntityManagedService; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).EntityManagedService = value; }

        /// <summary>Internal Acessors for ManagedServiceKeySource</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal.ManagedServiceKeySource { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).ManagedServiceKeySource; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).ManagedServiceKeySource = value; }

        /// <summary>Internal Acessors for ManagedServiceKeyVaultProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2KeyVaultProperties Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal.ManagedServiceKeyVaultProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).ManagedServiceKeyVaultProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).ManagedServiceKeyVaultProperty = value; }

        /// <summary>Internal Acessors for PrivateEndpointConnection</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnection[] Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal.PrivateEndpointConnection { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).PrivateEndpointConnection; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).PrivateEndpointConnection = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceProperties Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ISku Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.Sku()); set { {_sku = value;} } }

        /// <summary>Internal Acessors for StorageAccountIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IManagedIdentityConfiguration Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal.StorageAccountIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).StorageAccountIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).StorageAccountIdentity = value; }

        /// <summary>Internal Acessors for StorageAccountIdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal.StorageAccountIdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).StorageAccountIdentityPrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).StorageAccountIdentityPrincipalId = value; }

        /// <summary>Internal Acessors for StorageAccountIdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal.StorageAccountIdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).StorageAccountIdentityTenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).StorageAccountIdentityTenantId = value; }

        /// <summary>Internal Acessors for StorageAccountIdentityType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal.StorageAccountIdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).StorageAccountIdentityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).StorageAccountIdentityType = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20.ISystemData Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal.SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20.SystemData()); set { {_systemData = value;} } }

        /// <summary>Internal Acessors for UpdatedBy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ICreatedBy Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal.UpdatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).UpdatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).UpdatedBy = value; }

        /// <summary>Internal Acessors for UpdatedByApplicationId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal.UpdatedByApplicationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).UpdatedByApplicationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).UpdatedByApplicationId = value; }

        /// <summary>Internal Acessors for UpdatedByOid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal.UpdatedByOid { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).UpdatedByOid; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).UpdatedByOid = value; }

        /// <summary>Internal Acessors for UpdatedByPuid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal.UpdatedByPuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).UpdatedByPuid; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).UpdatedByPuid = value; }

        /// <summary>Internal Acessors for Url</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal.Url { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).WorkspaceUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).WorkspaceUrl = value; }

        /// <summary>Internal Acessors for WorkspaceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceInternal.WorkspaceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).WorkspaceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).WorkspaceId = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal)__trackedResource).Name; }

        /// <summary>The workspace's custom parameters.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParameters Parameter { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).Parameter; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).Parameter = value ?? null /* model class */; }

        /// <summary>Private endpoint connections created on the workspace</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnection[] PrivateEndpointConnection { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).PrivateEndpointConnection; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceProperties _property;

        /// <summary>The workspace properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceProperties()); set => this._property = value; }

        /// <summary>The workspace provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Whether requests from Public Network are allowed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PublicNetworkAccess? PublicNetworkAccess { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).PublicNetworkAccess; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).PublicNetworkAccess = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PublicNetworkAccess)""); }

        /// <summary>
        /// Gets or sets a value indicating data plane to control plane communication. Possible values are 'AllRules' and 'NoAzureDatabricksRules'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.RequiredNsgRules? RequiredNsgRule { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).RequiredNsgRule; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).RequiredNsgRule = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.RequiredNsgRules)""); }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ISku _sku;

        /// <summary>The SKU of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ISku Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.Sku()); set => this._sku = value; }

        /// <summary>The SKU name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ISkuInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ISkuInternal)Sku).Name = value ?? null; }

        /// <summary>The SKU tier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string SkuTier { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ISkuInternal)Sku).Tier; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ISkuInternal)Sku).Tier = value ?? null; }

        /// <summary>
        /// The objectId of the Managed Identity that is linked to the Managed Storage account.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string StorageAccountIdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).StorageAccountIdentityPrincipalId; }

        /// <summary>The tenant Id where the Managed Identity is created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string StorageAccountIdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).StorageAccountIdentityTenantId; }

        /// <summary>The type of Identity created. It can be either SystemAssigned or UserAssigned.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string StorageAccountIdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).StorageAccountIdentityType; }

        /// <summary>Backing field for <see cref="SystemData" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20.ISystemData _systemData;

        /// <summary>The system metadata relating to this resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20.ISystemData SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20.SystemData()); }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20.ISystemDataInternal)SystemData).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20.ISystemDataInternal)SystemData).CreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20.ISystemDataInternal)SystemData).CreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20.ISystemDataInternal)SystemData).CreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20.ISystemDataInternal)SystemData).CreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20.ISystemDataInternal)SystemData).CreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20.ISystemDataInternal)SystemData).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20.ISystemDataInternal)SystemData).LastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20.ISystemDataInternal)SystemData).LastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20.ISystemDataInternal)SystemData).LastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20.ISystemDataInternal)SystemData).LastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20.ISystemDataInternal)SystemData).LastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CreatedByType)""); }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal)__trackedResource).Type; }

        /// <summary>The blob URI where the UI definition file is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string UiDefinitionUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).UiDefinitionUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).UiDefinitionUri = value ?? null; }

        /// <summary>
        /// The application ID of the application that initiated the creation of the workspace. For example, Azure Portal.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string UpdatedByApplicationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).UpdatedByApplicationId; }

        /// <summary>The Object ID that created the workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string UpdatedByOid { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).UpdatedByOid; }

        /// <summary>The Personal Object ID corresponding to the object ID above</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string UpdatedByPuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).UpdatedByPuid; }

        /// <summary>
        /// The workspace URL which is of the format 'adb-{workspaceId}.{random}.azuredatabricks.net'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string Url { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).WorkspaceUrl; }

        /// <summary>The unique identifier of the databricks workspace in databricks control plane.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string WorkspaceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal)Property).WorkspaceId; }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }

        /// <summary>Creates an new <see cref="Workspace" /> instance.</summary>
        public Workspace()
        {

        }
    }
    /// Information about workspace.
    public partial interface IWorkspace :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ITrackedResource
    {
        /// <summary>The workspace provider authorizations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The workspace provider authorizations.",
        SerializedName = @"authorizations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceProviderAuthorization) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceProviderAuthorization[] Authorization { get; set; }
        /// <summary>
        /// The application ID of the application that initiated the creation of the workspace. For example, Azure Portal.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The application ID of the application that initiated the creation of the workspace. For example, Azure Portal.",
        SerializedName = @"applicationId",
        PossibleTypes = new [] { typeof(string) })]
        string CreatedByApplicationId { get;  }
        /// <summary>The Object ID that created the workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The Object ID that created the workspace.",
        SerializedName = @"oid",
        PossibleTypes = new [] { typeof(string) })]
        string CreatedByOid { get;  }
        /// <summary>The Personal Object ID corresponding to the object ID above</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The Personal Object ID corresponding to the object ID above",
        SerializedName = @"puid",
        PossibleTypes = new [] { typeof(string) })]
        string CreatedByPuid { get;  }
        /// <summary>Specifies the date and time when the workspace is created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Specifies the date and time when the workspace is created.",
        SerializedName = @"createdDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreatedDateTime { get;  }
        /// <summary>The name of KeyVault key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of KeyVault key.",
        SerializedName = @"keyName",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVaultPropertyKeyName { get; set; }
        /// <summary>The Uri of KeyVault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Uri of KeyVault.",
        SerializedName = @"keyVaultUri",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVaultPropertyKeyVaultUri { get; set; }
        /// <summary>The version of KeyVault key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The version of KeyVault key.",
        SerializedName = @"keyVersion",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVaultPropertyKeyVersion { get; set; }
        /// <summary>The managed resource group Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The managed resource group Id.",
        SerializedName = @"managedResourceGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedResourceGroupId { get; set; }
        /// <summary>
        /// The encryption keySource (provider). Possible values (case-insensitive): Microsoft.Keyvault
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.Keyvault",
        SerializedName = @"keySource",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedServiceKeySource { get;  }
        /// <summary>The workspace's custom parameters.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The workspace's custom parameters.",
        SerializedName = @"parameters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParameters) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParameters Parameter { get; set; }
        /// <summary>Private endpoint connections created on the workspace</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Private endpoint connections created on the workspace",
        SerializedName = @"privateEndpointConnections",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnection) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnection[] PrivateEndpointConnection { get;  }
        /// <summary>The workspace provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The workspace provisioning state.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>Whether requests from Public Network are allowed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether requests from Public Network are allowed",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PublicNetworkAccess) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary>
        /// Gets or sets a value indicating data plane to control plane communication. Possible values are 'AllRules' and 'NoAzureDatabricksRules'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets a value indicating data plane to control plane communication. Possible values are 'AllRules' and 'NoAzureDatabricksRules'",
        SerializedName = @"requiredNsgRules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.RequiredNsgRules) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.RequiredNsgRules? RequiredNsgRule { get; set; }
        /// <summary>The SKU name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The SKU name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string SkuName { get; set; }
        /// <summary>The SKU tier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The SKU tier.",
        SerializedName = @"tier",
        PossibleTypes = new [] { typeof(string) })]
        string SkuTier { get; set; }
        /// <summary>
        /// The objectId of the Managed Identity that is linked to the Managed Storage account.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The objectId of the Managed Identity that is linked to the Managed Storage account.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string StorageAccountIdentityPrincipalId { get;  }
        /// <summary>The tenant Id where the Managed Identity is created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The tenant Id where the Managed Identity is created.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string StorageAccountIdentityTenantId { get;  }
        /// <summary>The type of Identity created. It can be either SystemAssigned or UserAssigned.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of Identity created. It can be either SystemAssigned or UserAssigned.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string StorageAccountIdentityType { get;  }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that created the resource.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource last modification (UTC)",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that last modified the resource.",
        SerializedName = @"lastModifiedBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }
        /// <summary>The blob URI where the UI definition file is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The blob URI where the UI definition file is located.",
        SerializedName = @"uiDefinitionUri",
        PossibleTypes = new [] { typeof(string) })]
        string UiDefinitionUri { get; set; }
        /// <summary>
        /// The application ID of the application that initiated the creation of the workspace. For example, Azure Portal.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The application ID of the application that initiated the creation of the workspace. For example, Azure Portal.",
        SerializedName = @"applicationId",
        PossibleTypes = new [] { typeof(string) })]
        string UpdatedByApplicationId { get;  }
        /// <summary>The Object ID that created the workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The Object ID that created the workspace.",
        SerializedName = @"oid",
        PossibleTypes = new [] { typeof(string) })]
        string UpdatedByOid { get;  }
        /// <summary>The Personal Object ID corresponding to the object ID above</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The Personal Object ID corresponding to the object ID above",
        SerializedName = @"puid",
        PossibleTypes = new [] { typeof(string) })]
        string UpdatedByPuid { get;  }
        /// <summary>
        /// The workspace URL which is of the format 'adb-{workspaceId}.{random}.azuredatabricks.net'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The workspace URL which is of the format 'adb-{workspaceId}.{random}.azuredatabricks.net'",
        SerializedName = @"workspaceUrl",
        PossibleTypes = new [] { typeof(string) })]
        string Url { get;  }
        /// <summary>The unique identifier of the databricks workspace in databricks control plane.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The unique identifier of the databricks workspace in databricks control plane.",
        SerializedName = @"workspaceId",
        PossibleTypes = new [] { typeof(string) })]
        string WorkspaceId { get;  }

    }
    /// Information about workspace.
    internal partial interface IWorkspaceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ITrackedResourceInternal
    {
        /// <summary>The workspace provider authorizations.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceProviderAuthorization[] Authorization { get; set; }
        /// <summary>
        /// Indicates the Object ID, PUID and Application ID of entity that created the workspace.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ICreatedBy CreatedBy { get; set; }
        /// <summary>
        /// The application ID of the application that initiated the creation of the workspace. For example, Azure Portal.
        /// </summary>
        string CreatedByApplicationId { get; set; }
        /// <summary>The Object ID that created the workspace.</summary>
        string CreatedByOid { get; set; }
        /// <summary>The Personal Object ID corresponding to the object ID above</summary>
        string CreatedByPuid { get; set; }
        /// <summary>Specifies the date and time when the workspace is created.</summary>
        global::System.DateTime? CreatedDateTime { get; set; }
        /// <summary>Encryption properties for databricks workspace</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesEncryption Encryption { get; set; }
        /// <summary>Encryption entities definition for the workspace.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinition EncryptionEntity { get; set; }
        /// <summary>Encryption properties for the databricks managed services.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2 EntityManagedService { get; set; }
        /// <summary>The name of KeyVault key.</summary>
        string KeyVaultPropertyKeyName { get; set; }
        /// <summary>The Uri of KeyVault.</summary>
        string KeyVaultPropertyKeyVaultUri { get; set; }
        /// <summary>The version of KeyVault key.</summary>
        string KeyVaultPropertyKeyVersion { get; set; }
        /// <summary>The managed resource group Id.</summary>
        string ManagedResourceGroupId { get; set; }
        /// <summary>
        /// The encryption keySource (provider). Possible values (case-insensitive): Microsoft.Keyvault
        /// </summary>
        string ManagedServiceKeySource { get; set; }
        /// <summary>Key Vault input properties for encryption.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2KeyVaultProperties ManagedServiceKeyVaultProperty { get; set; }
        /// <summary>The workspace's custom parameters.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParameters Parameter { get; set; }
        /// <summary>Private endpoint connections created on the workspace</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnection[] PrivateEndpointConnection { get; set; }
        /// <summary>The workspace properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceProperties Property { get; set; }
        /// <summary>The workspace provisioning state.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>Whether requests from Public Network are allowed</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary>
        /// Gets or sets a value indicating data plane to control plane communication. Possible values are 'AllRules' and 'NoAzureDatabricksRules'
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.RequiredNsgRules? RequiredNsgRule { get; set; }
        /// <summary>The SKU of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ISku Sku { get; set; }
        /// <summary>The SKU name.</summary>
        string SkuName { get; set; }
        /// <summary>The SKU tier.</summary>
        string SkuTier { get; set; }
        /// <summary>The details of Managed Identity of Storage Account</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IManagedIdentityConfiguration StorageAccountIdentity { get; set; }
        /// <summary>
        /// The objectId of the Managed Identity that is linked to the Managed Storage account.
        /// </summary>
        string StorageAccountIdentityPrincipalId { get; set; }
        /// <summary>The tenant Id where the Managed Identity is created.</summary>
        string StorageAccountIdentityTenantId { get; set; }
        /// <summary>The type of Identity created. It can be either SystemAssigned or UserAssigned.</summary>
        string StorageAccountIdentityType { get; set; }
        /// <summary>The system metadata relating to this resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20.ISystemData SystemData { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }
        /// <summary>The blob URI where the UI definition file is located.</summary>
        string UiDefinitionUri { get; set; }
        /// <summary>
        /// Indicates the Object ID, PUID and Application ID of entity that last updated the workspace.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ICreatedBy UpdatedBy { get; set; }
        /// <summary>
        /// The application ID of the application that initiated the creation of the workspace. For example, Azure Portal.
        /// </summary>
        string UpdatedByApplicationId { get; set; }
        /// <summary>The Object ID that created the workspace.</summary>
        string UpdatedByOid { get; set; }
        /// <summary>The Personal Object ID corresponding to the object ID above</summary>
        string UpdatedByPuid { get; set; }
        /// <summary>
        /// The workspace URL which is of the format 'adb-{workspaceId}.{random}.azuredatabricks.net'
        /// </summary>
        string Url { get; set; }
        /// <summary>The unique identifier of the databricks workspace in databricks control plane.</summary>
        string WorkspaceId { get; set; }

    }
}