namespace Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Extensions;

    /// <summary>The workspace properties.</summary>
    public partial class WorkspaceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal
    {

        /// <summary>Backing field for <see cref="Authorization" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceProviderAuthorization[] _authorization;

        /// <summary>The workspace provider authorizations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceProviderAuthorization[] Authorization { get => this._authorization; set => this._authorization = value; }

        /// <summary>Backing field for <see cref="CreatedBy" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ICreatedBy _createdBy;

        /// <summary>
        /// Indicates the Object ID, PUID and Application ID of entity that created the workspace.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ICreatedBy CreatedBy { get => (this._createdBy = this._createdBy ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.CreatedBy()); set => this._createdBy = value; }

        /// <summary>
        /// The application ID of the application that initiated the creation of the workspace. For example, Azure Portal.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string CreatedByApplicationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ICreatedByInternal)CreatedBy).ApplicationId; }

        /// <summary>The Object ID that created the workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string CreatedByOid { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ICreatedByInternal)CreatedBy).Oid; }

        /// <summary>The Personal Object ID corresponding to the object ID above</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string CreatedByPuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ICreatedByInternal)CreatedBy).Puid; }

        /// <summary>Backing field for <see cref="CreatedDateTime" /> property.</summary>
        private global::System.DateTime? _createdDateTime;

        /// <summary>Specifies the date and time when the workspace is created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        public global::System.DateTime? CreatedDateTime { get => this._createdDateTime; }

        /// <summary>Backing field for <see cref="Encryption" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesEncryption _encryption;

        /// <summary>Encryption properties for databricks workspace</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesEncryption Encryption { get => (this._encryption = this._encryption ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspacePropertiesEncryption()); set => this._encryption = value; }

        /// <summary>The name of KeyVault key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyKeyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesEncryptionInternal)Encryption).KeyVaultPropertyKeyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesEncryptionInternal)Encryption).KeyVaultPropertyKeyName = value ?? null; }

        /// <summary>The Uri of KeyVault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyKeyVaultUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesEncryptionInternal)Encryption).KeyVaultPropertyKeyVaultUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesEncryptionInternal)Encryption).KeyVaultPropertyKeyVaultUri = value ?? null; }

        /// <summary>The version of KeyVault key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyKeyVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesEncryptionInternal)Encryption).KeyVaultPropertyKeyVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesEncryptionInternal)Encryption).KeyVaultPropertyKeyVersion = value ?? null; }

        /// <summary>Backing field for <see cref="ManagedResourceGroupId" /> property.</summary>
        private string _managedResourceGroupId;

        /// <summary>The managed resource group Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        public string ManagedResourceGroupId { get => this._managedResourceGroupId; set => this._managedResourceGroupId = value; }

        /// <summary>
        /// The encryption keySource (provider). Possible values (case-insensitive): Microsoft.Keyvault
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string ManagedServiceKeySource { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesEncryptionInternal)Encryption).ManagedServiceKeySource; }

        /// <summary>Internal Acessors for CreatedBy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ICreatedBy Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal.CreatedBy { get => (this._createdBy = this._createdBy ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.CreatedBy()); set { {_createdBy = value;} } }

        /// <summary>Internal Acessors for CreatedByApplicationId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal.CreatedByApplicationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ICreatedByInternal)CreatedBy).ApplicationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ICreatedByInternal)CreatedBy).ApplicationId = value; }

        /// <summary>Internal Acessors for CreatedByOid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal.CreatedByOid { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ICreatedByInternal)CreatedBy).Oid; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ICreatedByInternal)CreatedBy).Oid = value; }

        /// <summary>Internal Acessors for CreatedByPuid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal.CreatedByPuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ICreatedByInternal)CreatedBy).Puid; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ICreatedByInternal)CreatedBy).Puid = value; }

        /// <summary>Internal Acessors for CreatedDateTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal.CreatedDateTime { get => this._createdDateTime; set { {_createdDateTime = value;} } }

        /// <summary>Internal Acessors for Encryption</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesEncryption Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal.Encryption { get => (this._encryption = this._encryption ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspacePropertiesEncryption()); set { {_encryption = value;} } }

        /// <summary>Internal Acessors for EncryptionEntity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinition Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal.EncryptionEntity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesEncryptionInternal)Encryption).Entity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesEncryptionInternal)Encryption).Entity = value; }

        /// <summary>Internal Acessors for EntityManagedService</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2 Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal.EntityManagedService { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesEncryptionInternal)Encryption).EntityManagedService; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesEncryptionInternal)Encryption).EntityManagedService = value; }

        /// <summary>Internal Acessors for ManagedServiceKeySource</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal.ManagedServiceKeySource { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesEncryptionInternal)Encryption).ManagedServiceKeySource; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesEncryptionInternal)Encryption).ManagedServiceKeySource = value; }

        /// <summary>Internal Acessors for ManagedServiceKeyVaultProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2KeyVaultProperties Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal.ManagedServiceKeyVaultProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesEncryptionInternal)Encryption).ManagedServiceKeyVaultProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesEncryptionInternal)Encryption).ManagedServiceKeyVaultProperty = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for StorageAccountIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IManagedIdentityConfiguration Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal.StorageAccountIdentity { get => (this._storageAccountIdentity = this._storageAccountIdentity ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ManagedIdentityConfiguration()); set { {_storageAccountIdentity = value;} } }

        /// <summary>Internal Acessors for StorageAccountIdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal.StorageAccountIdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IManagedIdentityConfigurationInternal)StorageAccountIdentity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IManagedIdentityConfigurationInternal)StorageAccountIdentity).PrincipalId = value; }

        /// <summary>Internal Acessors for StorageAccountIdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal.StorageAccountIdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IManagedIdentityConfigurationInternal)StorageAccountIdentity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IManagedIdentityConfigurationInternal)StorageAccountIdentity).TenantId = value; }

        /// <summary>Internal Acessors for StorageAccountIdentityType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal.StorageAccountIdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IManagedIdentityConfigurationInternal)StorageAccountIdentity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IManagedIdentityConfigurationInternal)StorageAccountIdentity).Type = value; }

        /// <summary>Internal Acessors for UpdatedBy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ICreatedBy Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal.UpdatedBy { get => (this._updatedBy = this._updatedBy ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.CreatedBy()); set { {_updatedBy = value;} } }

        /// <summary>Internal Acessors for UpdatedByApplicationId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal.UpdatedByApplicationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ICreatedByInternal)UpdatedBy).ApplicationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ICreatedByInternal)UpdatedBy).ApplicationId = value; }

        /// <summary>Internal Acessors for UpdatedByOid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal.UpdatedByOid { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ICreatedByInternal)UpdatedBy).Oid; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ICreatedByInternal)UpdatedBy).Oid = value; }

        /// <summary>Internal Acessors for UpdatedByPuid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal.UpdatedByPuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ICreatedByInternal)UpdatedBy).Puid; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ICreatedByInternal)UpdatedBy).Puid = value; }

        /// <summary>Internal Acessors for WorkspaceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal.WorkspaceId { get => this._workspaceId; set { {_workspaceId = value;} } }

        /// <summary>Internal Acessors for WorkspaceUrl</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspacePropertiesInternal.WorkspaceUrl { get => this._workspaceUrl; set { {_workspaceUrl = value;} } }

        /// <summary>Backing field for <see cref="Parameter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParameters _parameter;

        /// <summary>The workspace's custom parameters.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParameters Parameter { get => (this._parameter = this._parameter ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceCustomParameters()); set => this._parameter = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.ProvisioningState? _provisioningState;

        /// <summary>The workspace provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="StorageAccountIdentity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IManagedIdentityConfiguration _storageAccountIdentity;

        /// <summary>The details of Managed Identity of Storage Account</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IManagedIdentityConfiguration StorageAccountIdentity { get => (this._storageAccountIdentity = this._storageAccountIdentity ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ManagedIdentityConfiguration()); set => this._storageAccountIdentity = value; }

        /// <summary>
        /// The objectId of the Managed Identity that is linked to the Managed Storage account.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string StorageAccountIdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IManagedIdentityConfigurationInternal)StorageAccountIdentity).PrincipalId; }

        /// <summary>The tenant Id where the Managed Identity is created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string StorageAccountIdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IManagedIdentityConfigurationInternal)StorageAccountIdentity).TenantId; }

        /// <summary>The type of Identity created. It can be either SystemAssigned or UserAssigned.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string StorageAccountIdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IManagedIdentityConfigurationInternal)StorageAccountIdentity).Type; }

        /// <summary>Backing field for <see cref="UiDefinitionUri" /> property.</summary>
        private string _uiDefinitionUri;

        /// <summary>The blob URI where the UI definition file is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        public string UiDefinitionUri { get => this._uiDefinitionUri; set => this._uiDefinitionUri = value; }

        /// <summary>Backing field for <see cref="UpdatedBy" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ICreatedBy _updatedBy;

        /// <summary>
        /// Indicates the Object ID, PUID and Application ID of entity that last updated the workspace.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ICreatedBy UpdatedBy { get => (this._updatedBy = this._updatedBy ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.CreatedBy()); set => this._updatedBy = value; }

        /// <summary>
        /// The application ID of the application that initiated the creation of the workspace. For example, Azure Portal.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string UpdatedByApplicationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ICreatedByInternal)UpdatedBy).ApplicationId; }

        /// <summary>The Object ID that created the workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string UpdatedByOid { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ICreatedByInternal)UpdatedBy).Oid; }

        /// <summary>The Personal Object ID corresponding to the object ID above</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string UpdatedByPuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.ICreatedByInternal)UpdatedBy).Puid; }

        /// <summary>Backing field for <see cref="WorkspaceId" /> property.</summary>
        private string _workspaceId;

        /// <summary>The unique identifier of the databricks workspace in databricks control plane.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        public string WorkspaceId { get => this._workspaceId; }

        /// <summary>Backing field for <see cref="WorkspaceUrl" /> property.</summary>
        private string _workspaceUrl;

        /// <summary>
        /// The workspace URL which is of the format 'adb-{workspaceId}.{random}.azuredatabricks.net'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        public string WorkspaceUrl { get => this._workspaceUrl; }

        /// <summary>Creates an new <see cref="WorkspaceProperties" /> instance.</summary>
        public WorkspaceProperties()
        {

        }
    }
    /// The workspace properties.
    public partial interface IWorkspaceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.IJsonSerializable
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
        /// <summary>The workspace provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The workspace provisioning state.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.ProvisioningState? ProvisioningState { get;  }
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
        /// <summary>The unique identifier of the databricks workspace in databricks control plane.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The unique identifier of the databricks workspace in databricks control plane.",
        SerializedName = @"workspaceId",
        PossibleTypes = new [] { typeof(string) })]
        string WorkspaceId { get;  }
        /// <summary>
        /// The workspace URL which is of the format 'adb-{workspaceId}.{random}.azuredatabricks.net'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The workspace URL which is of the format 'adb-{workspaceId}.{random}.azuredatabricks.net'",
        SerializedName = @"workspaceUrl",
        PossibleTypes = new [] { typeof(string) })]
        string WorkspaceUrl { get;  }

    }
    /// The workspace properties.
    internal partial interface IWorkspacePropertiesInternal

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
        /// <summary>The workspace provisioning state.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.ProvisioningState? ProvisioningState { get; set; }
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
        /// <summary>The unique identifier of the databricks workspace in databricks control plane.</summary>
        string WorkspaceId { get; set; }
        /// <summary>
        /// The workspace URL which is of the format 'adb-{workspaceId}.{random}.azuredatabricks.net'
        /// </summary>
        string WorkspaceUrl { get; set; }

    }
}