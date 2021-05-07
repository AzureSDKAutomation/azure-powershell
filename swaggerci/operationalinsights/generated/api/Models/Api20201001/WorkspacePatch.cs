namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>The top level Workspace resource container.</summary>
    public partial class WorkspacePatch :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePatch,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePatchInternal,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IAzureEntityResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IAzureEntityResource __azureEntityResource = new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.AzureEntityResource();

        /// <summary>Workspace creation date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string CreatedDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).CreatedDate; }

        /// <summary>This is a read-only property. Represents the ID associated with the workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string CustomerId { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).CustomerId; }

        /// <summary>Resource Etag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inherited)]
        public string Etag { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IAzureEntityResourceInternal)__azureEntityResource).Etag; }

        /// <summary>Workspace features.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceFeatures Feature { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).Feature; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).Feature = value ?? null /* model class */; }

        /// <summary>Indicates whether customer managed storage is mandatory for query management.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public bool? ForceCmkForQuery { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).ForceCmkForQuery; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).ForceCmkForQuery = value ?? default(bool); }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__azureEntityResource).Id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__azureEntityResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__azureEntityResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__azureEntityResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__azureEntityResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__azureEntityResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__azureEntityResource).Type = value; }

        /// <summary>Internal Acessors for Etag</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IAzureEntityResourceInternal.Etag { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IAzureEntityResourceInternal)__azureEntityResource).Etag; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IAzureEntityResourceInternal)__azureEntityResource).Etag = value; }

        /// <summary>Internal Acessors for CreatedDate</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePatchInternal.CreatedDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).CreatedDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).CreatedDate = value; }

        /// <summary>Internal Acessors for CustomerId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePatchInternal.CustomerId { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).CustomerId; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).CustomerId = value; }

        /// <summary>Internal Acessors for ModifiedDate</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePatchInternal.ModifiedDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).ModifiedDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).ModifiedDate = value; }

        /// <summary>Internal Acessors for PrivateLinkScopedResource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IPrivateLinkScopedResource[] Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePatchInternal.PrivateLinkScopedResource { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).PrivateLinkScopedResource; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).PrivateLinkScopedResource = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceProperties Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePatchInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.WorkspaceProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceSku Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePatchInternal.Sku { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).Sku; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).Sku = value; }

        /// <summary>Internal Acessors for SkuLastSkuUpdate</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePatchInternal.SkuLastSkuUpdate { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).SkuLastSkuUpdate; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).SkuLastSkuUpdate = value; }

        /// <summary>Internal Acessors for WorkspaceCapping</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceCapping Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePatchInternal.WorkspaceCapping { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).WorkspaceCapping; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).WorkspaceCapping = value; }

        /// <summary>Internal Acessors for WorkspaceCappingDataIngestionStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataIngestionStatus? Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePatchInternal.WorkspaceCappingDataIngestionStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).WorkspaceCappingDataIngestionStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).WorkspaceCappingDataIngestionStatus = value; }

        /// <summary>Internal Acessors for WorkspaceCappingQuotaNextResetTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePatchInternal.WorkspaceCappingQuotaNextResetTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).WorkspaceCappingQuotaNextResetTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).WorkspaceCappingQuotaNextResetTime = value; }

        /// <summary>Workspace modification date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string ModifiedDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).ModifiedDate; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__azureEntityResource).Name; }

        /// <summary>List of linked private link scope resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IPrivateLinkScopedResource[] PrivateLinkScopedResource { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).PrivateLinkScopedResource; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceProperties _property;

        /// <summary>Workspace properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.WorkspaceProperties()); set => this._property = value; }

        /// <summary>The provisioning state of the workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceEntityStatus? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).ProvisioningState = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceEntityStatus)""); }

        /// <summary>The network access type for accessing Log Analytics ingestion.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PublicNetworkAccessType? PublicNetworkAccessForIngestion { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).PublicNetworkAccessForIngestion; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).PublicNetworkAccessForIngestion = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PublicNetworkAccessType)""); }

        /// <summary>The network access type for accessing Log Analytics query.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PublicNetworkAccessType? PublicNetworkAccessForQuery { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).PublicNetworkAccessForQuery; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).PublicNetworkAccessForQuery = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PublicNetworkAccessType)""); }

        /// <summary>
        /// The workspace data retention in days. Allowed values are per pricing plan. See pricing tiers documentation for details.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public int? RetentionInDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).RetentionInDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).RetentionInDay = value ?? default(int); }

        /// <summary>
        /// The capacity reservation level for this workspace, when CapacityReservation sku is selected.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public int? SkuCapacityReservationLevel { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).SkuCapacityReservationLevel; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).SkuCapacityReservationLevel = value ?? default(int); }

        /// <summary>The last time when the sku was updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string SkuLastSkuUpdate { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).SkuLastSkuUpdate; }

        /// <summary>The name of the SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceSkuNameEnum? SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).SkuName; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).SkuName = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceSkuNameEnum)""); }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePatchTags _tag;

        /// <summary>Resource tags. Optional.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePatchTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.WorkspacePatchTags()); set => this._tag = value; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__azureEntityResource).Type; }

        /// <summary>The workspace daily quota for ingestion.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public double? WorkspaceCappingDailyQuotaGb { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).WorkspaceCappingDailyQuotaGb; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).WorkspaceCappingDailyQuotaGb = value ?? default(double); }

        /// <summary>The status of data ingestion for this workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataIngestionStatus? WorkspaceCappingDataIngestionStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).WorkspaceCappingDataIngestionStatus; }

        /// <summary>The time when the quota will be rest.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string WorkspaceCappingQuotaNextResetTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal)Property).WorkspaceCappingQuotaNextResetTime; }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__azureEntityResource), __azureEntityResource);
            await eventListener.AssertObjectIsValid(nameof(__azureEntityResource), __azureEntityResource);
        }

        /// <summary>Creates an new <see cref="WorkspacePatch" /> instance.</summary>
        public WorkspacePatch()
        {

        }
    }
    /// The top level Workspace resource container.
    public partial interface IWorkspacePatch :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IAzureEntityResource
    {
        /// <summary>Workspace creation date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Workspace creation date.",
        SerializedName = @"createdDate",
        PossibleTypes = new [] { typeof(string) })]
        string CreatedDate { get;  }
        /// <summary>This is a read-only property. Represents the ID associated with the workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"This is a read-only property. Represents the ID associated with the workspace.",
        SerializedName = @"customerId",
        PossibleTypes = new [] { typeof(string) })]
        string CustomerId { get;  }
        /// <summary>Workspace features.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Workspace features.",
        SerializedName = @"features",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceFeatures) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceFeatures Feature { get; set; }
        /// <summary>Indicates whether customer managed storage is mandatory for query management.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether customer managed storage is mandatory for query management.",
        SerializedName = @"forceCmkForQuery",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ForceCmkForQuery { get; set; }
        /// <summary>Workspace modification date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Workspace modification date.",
        SerializedName = @"modifiedDate",
        PossibleTypes = new [] { typeof(string) })]
        string ModifiedDate { get;  }
        /// <summary>List of linked private link scope resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of linked private link scope resources.",
        SerializedName = @"privateLinkScopedResources",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IPrivateLinkScopedResource) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IPrivateLinkScopedResource[] PrivateLinkScopedResource { get;  }
        /// <summary>The provisioning state of the workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The provisioning state of the workspace.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceEntityStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceEntityStatus? ProvisioningState { get; set; }
        /// <summary>The network access type for accessing Log Analytics ingestion.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The network access type for accessing Log Analytics ingestion.",
        SerializedName = @"publicNetworkAccessForIngestion",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PublicNetworkAccessType) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PublicNetworkAccessType? PublicNetworkAccessForIngestion { get; set; }
        /// <summary>The network access type for accessing Log Analytics query.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The network access type for accessing Log Analytics query.",
        SerializedName = @"publicNetworkAccessForQuery",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PublicNetworkAccessType) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PublicNetworkAccessType? PublicNetworkAccessForQuery { get; set; }
        /// <summary>
        /// The workspace data retention in days. Allowed values are per pricing plan. See pricing tiers documentation for details.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The workspace data retention in days. Allowed values are per pricing plan. See pricing tiers documentation for details.",
        SerializedName = @"retentionInDays",
        PossibleTypes = new [] { typeof(int) })]
        int? RetentionInDay { get; set; }
        /// <summary>
        /// The capacity reservation level for this workspace, when CapacityReservation sku is selected.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The capacity reservation level for this workspace, when CapacityReservation sku is selected.",
        SerializedName = @"capacityReservationLevel",
        PossibleTypes = new [] { typeof(int) })]
        int? SkuCapacityReservationLevel { get; set; }
        /// <summary>The last time when the sku was updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The last time when the sku was updated.",
        SerializedName = @"lastSkuUpdate",
        PossibleTypes = new [] { typeof(string) })]
        string SkuLastSkuUpdate { get;  }
        /// <summary>The name of the SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the SKU.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceSkuNameEnum) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceSkuNameEnum? SkuName { get; set; }
        /// <summary>Resource tags. Optional.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags. Optional.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePatchTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePatchTags Tag { get; set; }
        /// <summary>The workspace daily quota for ingestion.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The workspace daily quota for ingestion.",
        SerializedName = @"dailyQuotaGb",
        PossibleTypes = new [] { typeof(double) })]
        double? WorkspaceCappingDailyQuotaGb { get; set; }
        /// <summary>The status of data ingestion for this workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The status of data ingestion for this workspace.",
        SerializedName = @"dataIngestionStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataIngestionStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataIngestionStatus? WorkspaceCappingDataIngestionStatus { get;  }
        /// <summary>The time when the quota will be rest.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The time when the quota will be rest.",
        SerializedName = @"quotaNextResetTime",
        PossibleTypes = new [] { typeof(string) })]
        string WorkspaceCappingQuotaNextResetTime { get;  }

    }
    /// The top level Workspace resource container.
    internal partial interface IWorkspacePatchInternal :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IAzureEntityResourceInternal
    {
        /// <summary>Workspace creation date.</summary>
        string CreatedDate { get; set; }
        /// <summary>This is a read-only property. Represents the ID associated with the workspace.</summary>
        string CustomerId { get; set; }
        /// <summary>Workspace features.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceFeatures Feature { get; set; }
        /// <summary>Indicates whether customer managed storage is mandatory for query management.</summary>
        bool? ForceCmkForQuery { get; set; }
        /// <summary>Workspace modification date.</summary>
        string ModifiedDate { get; set; }
        /// <summary>List of linked private link scope resources.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IPrivateLinkScopedResource[] PrivateLinkScopedResource { get; set; }
        /// <summary>Workspace properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceProperties Property { get; set; }
        /// <summary>The provisioning state of the workspace.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceEntityStatus? ProvisioningState { get; set; }
        /// <summary>The network access type for accessing Log Analytics ingestion.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PublicNetworkAccessType? PublicNetworkAccessForIngestion { get; set; }
        /// <summary>The network access type for accessing Log Analytics query.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PublicNetworkAccessType? PublicNetworkAccessForQuery { get; set; }
        /// <summary>
        /// The workspace data retention in days. Allowed values are per pricing plan. See pricing tiers documentation for details.
        /// </summary>
        int? RetentionInDay { get; set; }
        /// <summary>The SKU of the workspace.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceSku Sku { get; set; }
        /// <summary>
        /// The capacity reservation level for this workspace, when CapacityReservation sku is selected.
        /// </summary>
        int? SkuCapacityReservationLevel { get; set; }
        /// <summary>The last time when the sku was updated.</summary>
        string SkuLastSkuUpdate { get; set; }
        /// <summary>The name of the SKU.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceSkuNameEnum? SkuName { get; set; }
        /// <summary>Resource tags. Optional.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePatchTags Tag { get; set; }
        /// <summary>The daily volume cap for ingestion.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceCapping WorkspaceCapping { get; set; }
        /// <summary>The workspace daily quota for ingestion.</summary>
        double? WorkspaceCappingDailyQuotaGb { get; set; }
        /// <summary>The status of data ingestion for this workspace.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataIngestionStatus? WorkspaceCappingDataIngestionStatus { get; set; }
        /// <summary>The time when the quota will be rest.</summary>
        string WorkspaceCappingQuotaNextResetTime { get; set; }

    }
}