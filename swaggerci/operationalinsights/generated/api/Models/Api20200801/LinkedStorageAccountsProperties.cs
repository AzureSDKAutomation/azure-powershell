namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>Linked storage accounts properties.</summary>
    public partial class LinkedStorageAccountsProperties :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedStorageAccountsProperties,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedStorageAccountsPropertiesInternal
    {

        /// <summary>Backing field for <see cref="DataSourceType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataSourceType? _dataSourceType;

        /// <summary>Linked storage accounts type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataSourceType? DataSourceType { get => this._dataSourceType; }

        /// <summary>Internal Acessors for DataSourceType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataSourceType? Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedStorageAccountsPropertiesInternal.DataSourceType { get => this._dataSourceType; set { {_dataSourceType = value;} } }

        /// <summary>Backing field for <see cref="StorageAccountId" /> property.</summary>
        private string[] _storageAccountId;

        /// <summary>Linked storage accounts resources ids.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string[] StorageAccountId { get => this._storageAccountId; set => this._storageAccountId = value; }

        /// <summary>Creates an new <see cref="LinkedStorageAccountsProperties" /> instance.</summary>
        public LinkedStorageAccountsProperties()
        {

        }
    }
    /// Linked storage accounts properties.
    public partial interface ILinkedStorageAccountsProperties :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>Linked storage accounts type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Linked storage accounts type.",
        SerializedName = @"dataSourceType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataSourceType) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataSourceType? DataSourceType { get;  }
        /// <summary>Linked storage accounts resources ids.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Linked storage accounts resources ids.",
        SerializedName = @"storageAccountIds",
        PossibleTypes = new [] { typeof(string) })]
        string[] StorageAccountId { get; set; }

    }
    /// Linked storage accounts properties.
    internal partial interface ILinkedStorageAccountsPropertiesInternal

    {
        /// <summary>Linked storage accounts type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataSourceType? DataSourceType { get; set; }
        /// <summary>Linked storage accounts resources ids.</summary>
        string[] StorageAccountId { get; set; }

    }
}