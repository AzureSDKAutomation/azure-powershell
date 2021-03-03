namespace Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Extensions;

    /// <summary>Information about workspace.</summary>
    public partial class Workspace :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspace,
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.TrackedResource();

        /// <summary>The workspace provider authorizations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceProviderAuthorization[] Authorization { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).Authorization; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).Authorization = value ?? null /* arrayOf */; }

        /// <summary>
        /// The application ID of the application that initiated the creation of the workspace. For example, Azure Portal.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string CreatedByApplicationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).CreatedByApplicationId; }

        /// <summary>The Object ID that created the workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string CreatedByOid { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).CreatedByOid; }

        /// <summary>The Personal Object ID corresponding to the object ID above</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string CreatedByPuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).CreatedByPuid; }

        /// <summary>Specifies the date and time when the workspace is created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public global::System.DateTime? CreatedDateTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).CreatedDateTime; }

        /// <summary>
        /// Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IResourceInternal)__trackedResource).Id; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.ITrackedResourceInternal)__trackedResource).Location = value ; }

        /// <summary>The managed resource group Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string ManagedResourceGroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).ManagedResourceGroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).ManagedResourceGroupId = value ; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IResourceInternal)__trackedResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IResourceInternal)__trackedResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IResourceInternal)__trackedResource).Type = value; }

        /// <summary>Internal Acessors for CreatedBy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.ICreatedBy Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceInternal.CreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).CreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).CreatedBy = value; }

        /// <summary>Internal Acessors for CreatedByApplicationId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceInternal.CreatedByApplicationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).CreatedByApplicationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).CreatedByApplicationId = value; }

        /// <summary>Internal Acessors for CreatedByOid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceInternal.CreatedByOid { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).CreatedByOid; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).CreatedByOid = value; }

        /// <summary>Internal Acessors for CreatedByPuid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceInternal.CreatedByPuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).CreatedByPuid; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).CreatedByPuid = value; }

        /// <summary>Internal Acessors for CreatedDateTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceInternal.CreatedDateTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).CreatedDateTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).CreatedDateTime = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceProperties Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.WorkspaceProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.ISku Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.Sku()); set { {_sku = value;} } }

        /// <summary>Internal Acessors for StorageAccountIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IManagedIdentityConfiguration Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceInternal.StorageAccountIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).StorageAccountIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).StorageAccountIdentity = value; }

        /// <summary>Internal Acessors for StorageAccountIdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceInternal.StorageAccountIdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).StorageAccountIdentityPrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).StorageAccountIdentityPrincipalId = value; }

        /// <summary>Internal Acessors for StorageAccountIdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceInternal.StorageAccountIdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).StorageAccountIdentityTenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).StorageAccountIdentityTenantId = value; }

        /// <summary>Internal Acessors for StorageAccountIdentityType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceInternal.StorageAccountIdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).StorageAccountIdentityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).StorageAccountIdentityType = value; }

        /// <summary>Internal Acessors for UpdatedBy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.ICreatedBy Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceInternal.UpdatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).UpdatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).UpdatedBy = value; }

        /// <summary>Internal Acessors for UpdatedByApplicationId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceInternal.UpdatedByApplicationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).UpdatedByApplicationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).UpdatedByApplicationId = value; }

        /// <summary>Internal Acessors for UpdatedByOid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceInternal.UpdatedByOid { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).UpdatedByOid; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).UpdatedByOid = value; }

        /// <summary>Internal Acessors for UpdatedByPuid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceInternal.UpdatedByPuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).UpdatedByPuid; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).UpdatedByPuid = value; }

        /// <summary>Internal Acessors for Url</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceInternal.Url { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).WorkspaceUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).WorkspaceUrl = value; }

        /// <summary>Internal Acessors for WorkspaceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceInternal.WorkspaceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).WorkspaceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).WorkspaceId = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IResourceInternal)__trackedResource).Name; }

        /// <summary>The workspace's custom parameters.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceCustomParameters Parameter { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).Parameter; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).Parameter = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceProperties _property;

        /// <summary>The workspace properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.WorkspaceProperties()); set => this._property = value; }

        /// <summary>The workspace provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.ISku _sku;

        /// <summary>The SKU of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.ISku Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.Sku()); set => this._sku = value; }

        /// <summary>The SKU name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.ISkuInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.ISkuInternal)Sku).Name = value ?? null; }

        /// <summary>The SKU tier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string SkuTier { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.ISkuInternal)Sku).Tier; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.ISkuInternal)Sku).Tier = value ?? null; }

        /// <summary>
        /// The objectId of the Managed Identity that is linked to the Managed Storage account.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string StorageAccountIdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).StorageAccountIdentityPrincipalId; }

        /// <summary>The tenant Id where the Managed Identity is created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string StorageAccountIdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).StorageAccountIdentityTenantId; }

        /// <summary>The type of Identity created. It can be either SystemAssigned or UserAssigned.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string StorageAccountIdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).StorageAccountIdentityType; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IResourceInternal)__trackedResource).Type; }

        /// <summary>The blob URI where the UI definition file is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string UiDefinitionUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).UiDefinitionUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).UiDefinitionUri = value ?? null; }

        /// <summary>
        /// The application ID of the application that initiated the creation of the workspace. For example, Azure Portal.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string UpdatedByApplicationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).UpdatedByApplicationId; }

        /// <summary>The Object ID that created the workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string UpdatedByOid { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).UpdatedByOid; }

        /// <summary>The Personal Object ID corresponding to the object ID above</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string UpdatedByPuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).UpdatedByPuid; }

        /// <summary>
        /// The workspace URL which is of the format 'adb-{workspaceId}.{random}.azuredatabricks.net'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string Url { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).WorkspaceUrl; }

        /// <summary>The unique identifier of the databricks workspace in databricks control plane.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string WorkspaceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspacePropertiesInternal)Property).WorkspaceId; }

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
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.ITrackedResource
    {
        /// <summary>The workspace provider authorizations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The workspace provider authorizations.",
        SerializedName = @"authorizations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceProviderAuthorization) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceProviderAuthorization[] Authorization { get; set; }
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
        /// <summary>The managed resource group Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The managed resource group Id.",
        SerializedName = @"managedResourceGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedResourceGroupId { get; set; }
        /// <summary>The workspace's custom parameters.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The workspace's custom parameters.",
        SerializedName = @"parameters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceCustomParameters) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceCustomParameters Parameter { get; set; }
        /// <summary>The workspace provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The workspace provisioning state.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.ProvisioningState? ProvisioningState { get;  }
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
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.ITrackedResourceInternal
    {
        /// <summary>The workspace provider authorizations.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceProviderAuthorization[] Authorization { get; set; }
        /// <summary>
        /// Indicates the Object ID, PUID and Application ID of entity that created the workspace.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.ICreatedBy CreatedBy { get; set; }
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
        /// <summary>The managed resource group Id.</summary>
        string ManagedResourceGroupId { get; set; }
        /// <summary>The workspace's custom parameters.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceCustomParameters Parameter { get; set; }
        /// <summary>The workspace properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IWorkspaceProperties Property { get; set; }
        /// <summary>The workspace provisioning state.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>The SKU of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.ISku Sku { get; set; }
        /// <summary>The SKU name.</summary>
        string SkuName { get; set; }
        /// <summary>The SKU tier.</summary>
        string SkuTier { get; set; }
        /// <summary>The details of Managed Identity of Storage Account</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.IManagedIdentityConfiguration StorageAccountIdentity { get; set; }
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
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20180401.ICreatedBy UpdatedBy { get; set; }
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