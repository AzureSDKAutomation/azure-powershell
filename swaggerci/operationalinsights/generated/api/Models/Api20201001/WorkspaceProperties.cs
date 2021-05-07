namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>Workspace properties.</summary>
    public partial class WorkspaceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal
    {

        /// <summary>Backing field for <see cref="CreatedDate" /> property.</summary>
        private string _createdDate;

        /// <summary>Workspace creation date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string CreatedDate { get => this._createdDate; }

        /// <summary>Backing field for <see cref="CustomerId" /> property.</summary>
        private string _customerId;

        /// <summary>This is a read-only property. Represents the ID associated with the workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string CustomerId { get => this._customerId; }

        /// <summary>Backing field for <see cref="Feature" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceFeatures _feature;

        /// <summary>Workspace features.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceFeatures Feature { get => (this._feature = this._feature ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.WorkspaceFeatures()); set => this._feature = value; }

        /// <summary>Backing field for <see cref="ForceCmkForQuery" /> property.</summary>
        private bool? _forceCmkForQuery;

        /// <summary>Indicates whether customer managed storage is mandatory for query management.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public bool? ForceCmkForQuery { get => this._forceCmkForQuery; set => this._forceCmkForQuery = value; }

        /// <summary>Internal Acessors for CreatedDate</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal.CreatedDate { get => this._createdDate; set { {_createdDate = value;} } }

        /// <summary>Internal Acessors for CustomerId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal.CustomerId { get => this._customerId; set { {_customerId = value;} } }

        /// <summary>Internal Acessors for ModifiedDate</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal.ModifiedDate { get => this._modifiedDate; set { {_modifiedDate = value;} } }

        /// <summary>Internal Acessors for PrivateLinkScopedResource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IPrivateLinkScopedResource[] Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal.PrivateLinkScopedResource { get => this._privateLinkScopedResource; set { {_privateLinkScopedResource = value;} } }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceSku Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.WorkspaceSku()); set { {_sku = value;} } }

        /// <summary>Internal Acessors for SkuLastSkuUpdate</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal.SkuLastSkuUpdate { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceSkuInternal)Sku).LastSkuUpdate; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceSkuInternal)Sku).LastSkuUpdate = value; }

        /// <summary>Internal Acessors for WorkspaceCapping</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceCapping Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal.WorkspaceCapping { get => (this._workspaceCapping = this._workspaceCapping ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.WorkspaceCapping()); set { {_workspaceCapping = value;} } }

        /// <summary>Internal Acessors for WorkspaceCappingDataIngestionStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataIngestionStatus? Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal.WorkspaceCappingDataIngestionStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceCappingInternal)WorkspaceCapping).DataIngestionStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceCappingInternal)WorkspaceCapping).DataIngestionStatus = value; }

        /// <summary>Internal Acessors for WorkspaceCappingQuotaNextResetTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePropertiesInternal.WorkspaceCappingQuotaNextResetTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceCappingInternal)WorkspaceCapping).QuotaNextResetTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceCappingInternal)WorkspaceCapping).QuotaNextResetTime = value; }

        /// <summary>Backing field for <see cref="ModifiedDate" /> property.</summary>
        private string _modifiedDate;

        /// <summary>Workspace modification date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string ModifiedDate { get => this._modifiedDate; }

        /// <summary>Backing field for <see cref="PrivateLinkScopedResource" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IPrivateLinkScopedResource[] _privateLinkScopedResource;

        /// <summary>List of linked private link scope resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IPrivateLinkScopedResource[] PrivateLinkScopedResource { get => this._privateLinkScopedResource; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceEntityStatus? _provisioningState;

        /// <summary>The provisioning state of the workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceEntityStatus? ProvisioningState { get => this._provisioningState; set => this._provisioningState = value; }

        /// <summary>Backing field for <see cref="PublicNetworkAccessForIngestion" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PublicNetworkAccessType? _publicNetworkAccessForIngestion;

        /// <summary>The network access type for accessing Log Analytics ingestion.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PublicNetworkAccessType? PublicNetworkAccessForIngestion { get => this._publicNetworkAccessForIngestion; set => this._publicNetworkAccessForIngestion = value; }

        /// <summary>Backing field for <see cref="PublicNetworkAccessForQuery" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PublicNetworkAccessType? _publicNetworkAccessForQuery;

        /// <summary>The network access type for accessing Log Analytics query.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PublicNetworkAccessType? PublicNetworkAccessForQuery { get => this._publicNetworkAccessForQuery; set => this._publicNetworkAccessForQuery = value; }

        /// <summary>Backing field for <see cref="RetentionInDay" /> property.</summary>
        private int? _retentionInDay;

        /// <summary>
        /// The workspace data retention in days. Allowed values are per pricing plan. See pricing tiers documentation for details.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public int? RetentionInDay { get => this._retentionInDay; set => this._retentionInDay = value; }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceSku _sku;

        /// <summary>The SKU of the workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceSku Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.WorkspaceSku()); set => this._sku = value; }

        /// <summary>
        /// The capacity reservation level for this workspace, when CapacityReservation sku is selected.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public int? SkuCapacityReservationLevel { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceSkuInternal)Sku).CapacityReservationLevel; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceSkuInternal)Sku).CapacityReservationLevel = value ?? default(int); }

        /// <summary>The last time when the sku was updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string SkuLastSkuUpdate { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceSkuInternal)Sku).LastSkuUpdate; }

        /// <summary>The name of the SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceSkuNameEnum? SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceSkuInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceSkuInternal)Sku).Name = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceSkuNameEnum)""); }

        /// <summary>Backing field for <see cref="WorkspaceCapping" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceCapping _workspaceCapping;

        /// <summary>The daily volume cap for ingestion.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceCapping WorkspaceCapping { get => (this._workspaceCapping = this._workspaceCapping ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.WorkspaceCapping()); set => this._workspaceCapping = value; }

        /// <summary>The workspace daily quota for ingestion.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public double? WorkspaceCappingDailyQuotaGb { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceCappingInternal)WorkspaceCapping).DailyQuotaGb; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceCappingInternal)WorkspaceCapping).DailyQuotaGb = value ?? default(double); }

        /// <summary>The status of data ingestion for this workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataIngestionStatus? WorkspaceCappingDataIngestionStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceCappingInternal)WorkspaceCapping).DataIngestionStatus; }

        /// <summary>The time when the quota will be rest.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string WorkspaceCappingQuotaNextResetTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceCappingInternal)WorkspaceCapping).QuotaNextResetTime; }

        /// <summary>Creates an new <see cref="WorkspaceProperties" /> instance.</summary>
        public WorkspaceProperties()
        {

        }
    }
    /// Workspace properties.
    public partial interface IWorkspaceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
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
    /// Workspace properties.
    internal partial interface IWorkspacePropertiesInternal

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