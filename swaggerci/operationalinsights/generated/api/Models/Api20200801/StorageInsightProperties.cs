namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>Storage insight properties.</summary>
    public partial class StorageInsightProperties :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightProperties,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Container" /> property.</summary>
        private string[] _container;

        /// <summary>The names of the blob containers that the workspace should read</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string[] Container { get => this._container; set => this._container = value; }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightStatus Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightPropertiesInternal.Status { get => (this._status = this._status ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.StorageInsightStatus()); set { {_status = value;} } }

        /// <summary>Internal Acessors for StorageAccount</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageAccount Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightPropertiesInternal.StorageAccount { get => (this._storageAccount = this._storageAccount ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.StorageAccount()); set { {_storageAccount = value;} } }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightStatus _status;

        /// <summary>The status of the storage insight</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightStatus Status { get => (this._status = this._status ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.StorageInsightStatus()); }

        /// <summary>Description of the state of the storage insight.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string StatusDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightStatusInternal)Status).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightStatusInternal)Status).Description = value ?? null; }

        /// <summary>The state of the storage insight connection to the workspace</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.StorageInsightState? StatusState { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightStatusInternal)Status).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightStatusInternal)Status).State = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.StorageInsightState)""); }

        /// <summary>Backing field for <see cref="StorageAccount" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageAccount _storageAccount;

        /// <summary>The storage account connection details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageAccount StorageAccount { get => (this._storageAccount = this._storageAccount ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.StorageAccount()); set => this._storageAccount = value; }

        /// <summary>The Azure Resource Manager ID of the storage account resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string StorageAccountId { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageAccountInternal)StorageAccount).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageAccountInternal)StorageAccount).Id = value ; }

        /// <summary>The storage account key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string StorageAccountKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageAccountInternal)StorageAccount).Key; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageAccountInternal)StorageAccount).Key = value ; }

        /// <summary>Backing field for <see cref="Table" /> property.</summary>
        private string[] _table;

        /// <summary>The names of the Azure tables that the workspace should read</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string[] Table { get => this._table; set => this._table = value; }

        /// <summary>Creates an new <see cref="StorageInsightProperties" /> instance.</summary>
        public StorageInsightProperties()
        {

        }
    }
    /// Storage insight properties.
    public partial interface IStorageInsightProperties :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>The names of the blob containers that the workspace should read</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The names of the blob containers that the workspace should read",
        SerializedName = @"containers",
        PossibleTypes = new [] { typeof(string) })]
        string[] Container { get; set; }
        /// <summary>Description of the state of the storage insight.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Description of the state of the storage insight.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string StatusDescription { get; set; }
        /// <summary>The state of the storage insight connection to the workspace</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The state of the storage insight connection to the workspace",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.StorageInsightState) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.StorageInsightState? StatusState { get; set; }
        /// <summary>The Azure Resource Manager ID of the storage account resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The Azure Resource Manager ID of the storage account resource.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string StorageAccountId { get; set; }
        /// <summary>The storage account key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The storage account key.",
        SerializedName = @"key",
        PossibleTypes = new [] { typeof(string) })]
        string StorageAccountKey { get; set; }
        /// <summary>The names of the Azure tables that the workspace should read</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The names of the Azure tables that the workspace should read",
        SerializedName = @"tables",
        PossibleTypes = new [] { typeof(string) })]
        string[] Table { get; set; }

    }
    /// Storage insight properties.
    internal partial interface IStorageInsightPropertiesInternal

    {
        /// <summary>The names of the blob containers that the workspace should read</summary>
        string[] Container { get; set; }
        /// <summary>The status of the storage insight</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightStatus Status { get; set; }
        /// <summary>Description of the state of the storage insight.</summary>
        string StatusDescription { get; set; }
        /// <summary>The state of the storage insight connection to the workspace</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.StorageInsightState? StatusState { get; set; }
        /// <summary>The storage account connection details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageAccount StorageAccount { get; set; }
        /// <summary>The Azure Resource Manager ID of the storage account resource.</summary>
        string StorageAccountId { get; set; }
        /// <summary>The storage account key.</summary>
        string StorageAccountKey { get; set; }
        /// <summary>The names of the Azure tables that the workspace should read</summary>
        string[] Table { get; set; }

    }
}