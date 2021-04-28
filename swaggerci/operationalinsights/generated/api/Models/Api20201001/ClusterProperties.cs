namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>Cluster properties.</summary>
    public partial class ClusterProperties :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterProperties,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AssociatedWorkspace" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspace[] _associatedWorkspace;

        /// <summary>The list of Log Analytics workspaces associated with the cluster</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspace[] AssociatedWorkspace { get => this._associatedWorkspace; set => this._associatedWorkspace = value; }

        /// <summary>Backing field for <see cref="BillingType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.BillingType? _billingType;

        /// <summary>
        /// Configures whether billing will be only on the cluster or each workspace will be billed by its proportional use. This
        /// does not change the overall billing, only how it will be distributed. Default value is 'Cluster'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.BillingType? BillingType { get => this._billingType; set => this._billingType = value; }

        /// <summary>Backing field for <see cref="CapacityReservationProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ICapacityReservationProperties _capacityReservationProperty;

        /// <summary>Additional properties for capacity reservation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ICapacityReservationProperties CapacityReservationProperty { get => (this._capacityReservationProperty = this._capacityReservationProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.CapacityReservationProperties()); set => this._capacityReservationProperty = value; }

        /// <summary>The last time Sku was updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string CapacityReservationPropertyLastSkuUpdate { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ICapacityReservationPropertiesInternal)CapacityReservationProperty).LastSkuUpdate; }

        /// <summary>Maximum CapacityReservation value in GB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public long? CapacityReservationPropertyMaxCapacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ICapacityReservationPropertiesInternal)CapacityReservationProperty).MaxCapacity; }

        /// <summary>Minimum CapacityReservation value in GB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public long? CapacityReservationPropertyMinCapacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ICapacityReservationPropertiesInternal)CapacityReservationProperty).MinCapacity; }

        /// <summary>Backing field for <see cref="ClusterId" /> property.</summary>
        private string _clusterId;

        /// <summary>The ID associated with the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string ClusterId { get => this._clusterId; }

        /// <summary>Backing field for <see cref="CreatedDate" /> property.</summary>
        private string _createdDate;

        /// <summary>The cluster creation time</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string CreatedDate { get => this._createdDate; }

        /// <summary>Backing field for <see cref="IsAvailabilityZonesEnabled" /> property.</summary>
        private bool? _isAvailabilityZonesEnabled;

        /// <summary>
        /// Sets whether the cluster will support availability zones. This can be set as true only in regions where Azure Data Explorer
        /// support Availability Zones. This Property can not be modified after cluster creation. Default value is 'true' if region
        /// supports Availability Zones.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public bool? IsAvailabilityZonesEnabled { get => this._isAvailabilityZonesEnabled; set => this._isAvailabilityZonesEnabled = value; }

        /// <summary>Backing field for <see cref="IsDoubleEncryptionEnabled" /> property.</summary>
        private bool? _isDoubleEncryptionEnabled;

        /// <summary>
        /// Configures whether cluster will use double encryption. This Property can not be modified after cluster creation. Default
        /// value is 'true'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public bool? IsDoubleEncryptionEnabled { get => this._isDoubleEncryptionEnabled; set => this._isDoubleEncryptionEnabled = value; }

        /// <summary>Backing field for <see cref="KeyVaultProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IKeyVaultProperties _keyVaultProperty;

        /// <summary>The associated key properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IKeyVaultProperties KeyVaultProperty { get => (this._keyVaultProperty = this._keyVaultProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.KeyVaultProperties()); set => this._keyVaultProperty = value; }

        /// <summary>The name of the key associated with the Log Analytics cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyKeyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IKeyVaultPropertiesInternal)KeyVaultProperty).KeyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IKeyVaultPropertiesInternal)KeyVaultProperty).KeyName = value ?? null; }

        /// <summary>Selected key minimum required size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public int? KeyVaultPropertyKeyRsaSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IKeyVaultPropertiesInternal)KeyVaultProperty).KeyRsaSize; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IKeyVaultPropertiesInternal)KeyVaultProperty).KeyRsaSize = value ?? default(int); }

        /// <summary>
        /// The Key Vault uri which holds they key associated with the Log Analytics cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyKeyVaultUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IKeyVaultPropertiesInternal)KeyVaultProperty).KeyVaultUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IKeyVaultPropertiesInternal)KeyVaultProperty).KeyVaultUri = value ?? null; }

        /// <summary>The version of the key associated with the Log Analytics cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyKeyVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IKeyVaultPropertiesInternal)KeyVaultProperty).KeyVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IKeyVaultPropertiesInternal)KeyVaultProperty).KeyVersion = value ?? null; }

        /// <summary>Backing field for <see cref="LastModifiedDate" /> property.</summary>
        private string _lastModifiedDate;

        /// <summary>The last time the cluster was updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string LastModifiedDate { get => this._lastModifiedDate; }

        /// <summary>Internal Acessors for CapacityReservationProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ICapacityReservationProperties Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal.CapacityReservationProperty { get => (this._capacityReservationProperty = this._capacityReservationProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.CapacityReservationProperties()); set { {_capacityReservationProperty = value;} } }

        /// <summary>Internal Acessors for CapacityReservationPropertyLastSkuUpdate</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal.CapacityReservationPropertyLastSkuUpdate { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ICapacityReservationPropertiesInternal)CapacityReservationProperty).LastSkuUpdate; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ICapacityReservationPropertiesInternal)CapacityReservationProperty).LastSkuUpdate = value; }

        /// <summary>Internal Acessors for CapacityReservationPropertyMaxCapacity</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal.CapacityReservationPropertyMaxCapacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ICapacityReservationPropertiesInternal)CapacityReservationProperty).MaxCapacity; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ICapacityReservationPropertiesInternal)CapacityReservationProperty).MaxCapacity = value; }

        /// <summary>Internal Acessors for CapacityReservationPropertyMinCapacity</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal.CapacityReservationPropertyMinCapacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ICapacityReservationPropertiesInternal)CapacityReservationProperty).MinCapacity; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ICapacityReservationPropertiesInternal)CapacityReservationProperty).MinCapacity = value; }

        /// <summary>Internal Acessors for ClusterId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal.ClusterId { get => this._clusterId; set { {_clusterId = value;} } }

        /// <summary>Internal Acessors for CreatedDate</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal.CreatedDate { get => this._createdDate; set { {_createdDate = value;} } }

        /// <summary>Internal Acessors for KeyVaultProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IKeyVaultProperties Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal.KeyVaultProperty { get => (this._keyVaultProperty = this._keyVaultProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.KeyVaultProperties()); set { {_keyVaultProperty = value;} } }

        /// <summary>Internal Acessors for LastModifiedDate</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal.LastModifiedDate { get => this._lastModifiedDate; set { {_lastModifiedDate = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterEntityStatus? Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterEntityStatus? _provisioningState;

        /// <summary>The provisioning state of the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterEntityStatus? ProvisioningState { get => this._provisioningState; }

        /// <summary>Creates an new <see cref="ClusterProperties" /> instance.</summary>
        public ClusterProperties()
        {

        }
    }
    /// Cluster properties.
    public partial interface IClusterProperties :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>The list of Log Analytics workspaces associated with the cluster</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of Log Analytics workspaces associated with the cluster",
        SerializedName = @"associatedWorkspaces",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspace) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspace[] AssociatedWorkspace { get; set; }
        /// <summary>
        /// Configures whether billing will be only on the cluster or each workspace will be billed by its proportional use. This
        /// does not change the overall billing, only how it will be distributed. Default value is 'Cluster'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Configures whether billing will be only on the cluster or each workspace will be billed by its proportional use. This does not change the overall billing, only how it will be distributed. Default value is 'Cluster'",
        SerializedName = @"billingType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.BillingType) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.BillingType? BillingType { get; set; }
        /// <summary>The last time Sku was updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The last time Sku was updated.",
        SerializedName = @"lastSkuUpdate",
        PossibleTypes = new [] { typeof(string) })]
        string CapacityReservationPropertyLastSkuUpdate { get;  }
        /// <summary>Maximum CapacityReservation value in GB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Maximum CapacityReservation value in GB.",
        SerializedName = @"maxCapacity",
        PossibleTypes = new [] { typeof(long) })]
        long? CapacityReservationPropertyMaxCapacity { get;  }
        /// <summary>Minimum CapacityReservation value in GB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Minimum CapacityReservation value in GB.",
        SerializedName = @"minCapacity",
        PossibleTypes = new [] { typeof(long) })]
        long? CapacityReservationPropertyMinCapacity { get;  }
        /// <summary>The ID associated with the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The ID associated with the cluster.",
        SerializedName = @"clusterId",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterId { get;  }
        /// <summary>The cluster creation time</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The cluster creation time",
        SerializedName = @"createdDate",
        PossibleTypes = new [] { typeof(string) })]
        string CreatedDate { get;  }
        /// <summary>
        /// Sets whether the cluster will support availability zones. This can be set as true only in regions where Azure Data Explorer
        /// support Availability Zones. This Property can not be modified after cluster creation. Default value is 'true' if region
        /// supports Availability Zones.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sets whether the cluster will support availability zones. This can be set as true only in regions where Azure Data Explorer support Availability Zones. This Property can not be modified after cluster creation. Default value is 'true' if region supports Availability Zones.",
        SerializedName = @"isAvailabilityZonesEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsAvailabilityZonesEnabled { get; set; }
        /// <summary>
        /// Configures whether cluster will use double encryption. This Property can not be modified after cluster creation. Default
        /// value is 'true'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Configures whether cluster will use double encryption. This Property can not be modified after cluster creation. Default value is 'true'",
        SerializedName = @"isDoubleEncryptionEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsDoubleEncryptionEnabled { get; set; }
        /// <summary>The name of the key associated with the Log Analytics cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the key associated with the Log Analytics cluster.",
        SerializedName = @"keyName",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVaultPropertyKeyName { get; set; }
        /// <summary>Selected key minimum required size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Selected key minimum required size.",
        SerializedName = @"keyRsaSize",
        PossibleTypes = new [] { typeof(int) })]
        int? KeyVaultPropertyKeyRsaSize { get; set; }
        /// <summary>
        /// The Key Vault uri which holds they key associated with the Log Analytics cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Key Vault uri which holds they key associated with the Log Analytics cluster.",
        SerializedName = @"keyVaultUri",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVaultPropertyKeyVaultUri { get; set; }
        /// <summary>The version of the key associated with the Log Analytics cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The version of the key associated with the Log Analytics cluster.",
        SerializedName = @"keyVersion",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVaultPropertyKeyVersion { get; set; }
        /// <summary>The last time the cluster was updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The last time the cluster was updated.",
        SerializedName = @"lastModifiedDate",
        PossibleTypes = new [] { typeof(string) })]
        string LastModifiedDate { get;  }
        /// <summary>The provisioning state of the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the cluster.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterEntityStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterEntityStatus? ProvisioningState { get;  }

    }
    /// Cluster properties.
    internal partial interface IClusterPropertiesInternal

    {
        /// <summary>The list of Log Analytics workspaces associated with the cluster</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspace[] AssociatedWorkspace { get; set; }
        /// <summary>
        /// Configures whether billing will be only on the cluster or each workspace will be billed by its proportional use. This
        /// does not change the overall billing, only how it will be distributed. Default value is 'Cluster'
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.BillingType? BillingType { get; set; }
        /// <summary>Additional properties for capacity reservation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ICapacityReservationProperties CapacityReservationProperty { get; set; }
        /// <summary>The last time Sku was updated.</summary>
        string CapacityReservationPropertyLastSkuUpdate { get; set; }
        /// <summary>Maximum CapacityReservation value in GB.</summary>
        long? CapacityReservationPropertyMaxCapacity { get; set; }
        /// <summary>Minimum CapacityReservation value in GB.</summary>
        long? CapacityReservationPropertyMinCapacity { get; set; }
        /// <summary>The ID associated with the cluster.</summary>
        string ClusterId { get; set; }
        /// <summary>The cluster creation time</summary>
        string CreatedDate { get; set; }
        /// <summary>
        /// Sets whether the cluster will support availability zones. This can be set as true only in regions where Azure Data Explorer
        /// support Availability Zones. This Property can not be modified after cluster creation. Default value is 'true' if region
        /// supports Availability Zones.
        /// </summary>
        bool? IsAvailabilityZonesEnabled { get; set; }
        /// <summary>
        /// Configures whether cluster will use double encryption. This Property can not be modified after cluster creation. Default
        /// value is 'true'
        /// </summary>
        bool? IsDoubleEncryptionEnabled { get; set; }
        /// <summary>The associated key properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IKeyVaultProperties KeyVaultProperty { get; set; }
        /// <summary>The name of the key associated with the Log Analytics cluster.</summary>
        string KeyVaultPropertyKeyName { get; set; }
        /// <summary>Selected key minimum required size.</summary>
        int? KeyVaultPropertyKeyRsaSize { get; set; }
        /// <summary>
        /// The Key Vault uri which holds they key associated with the Log Analytics cluster.
        /// </summary>
        string KeyVaultPropertyKeyVaultUri { get; set; }
        /// <summary>The version of the key associated with the Log Analytics cluster.</summary>
        string KeyVaultPropertyKeyVersion { get; set; }
        /// <summary>The last time the cluster was updated.</summary>
        string LastModifiedDate { get; set; }
        /// <summary>The provisioning state of the cluster.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterEntityStatus? ProvisioningState { get; set; }

    }
}