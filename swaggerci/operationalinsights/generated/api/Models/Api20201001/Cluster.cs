namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>The top level Log Analytics cluster resource container.</summary>
    public partial class Cluster :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ICluster,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.TrackedResource();

        /// <summary>The list of Log Analytics workspaces associated with the cluster</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspace[] AssociatedWorkspace { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).AssociatedWorkspace; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).AssociatedWorkspace = value ?? null /* arrayOf */; }

        /// <summary>
        /// Configures whether billing will be only on the cluster or each workspace will be billed by its proportional use. This
        /// does not change the overall billing, only how it will be distributed. Default value is 'Cluster'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.BillingType? BillingType { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).BillingType; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).BillingType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.BillingType)""); }

        /// <summary>The last time Sku was updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string CapacityReservationPropertyLastSkuUpdate { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).CapacityReservationPropertyLastSkuUpdate; }

        /// <summary>Maximum CapacityReservation value in GB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public long? CapacityReservationPropertyMaxCapacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).CapacityReservationPropertyMaxCapacity; }

        /// <summary>Minimum CapacityReservation value in GB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public long? CapacityReservationPropertyMinCapacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).CapacityReservationPropertyMinCapacity; }

        /// <summary>The ID associated with the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string ClusterId { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).ClusterId; }

        /// <summary>The cluster creation time</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string CreatedDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).CreatedDate; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__trackedResource).Id; }

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentity _identity;

        /// <summary>The identity of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentity Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.Identity()); set => this._identity = value; }

        /// <summary>The principal ID of resource identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentityInternal)Identity).PrincipalId; }

        /// <summary>The tenant ID of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentityInternal)Identity).TenantId; }

        /// <summary>Type of managed service identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.IdentityType? IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentityInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentityInternal)Identity).Type = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.IdentityType)""); }

        /// <summary>
        /// The list of user identities associated with the resource. The user identity dictionary key references will be ARM resource
        /// ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentityUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentityInternal)Identity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentityInternal)Identity).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>
        /// Sets whether the cluster will support availability zones. This can be set as true only in regions where Azure Data Explorer
        /// support Availability Zones. This Property can not be modified after cluster creation. Default value is 'true' if region
        /// supports Availability Zones.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public bool? IsAvailabilityZonesEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).IsAvailabilityZonesEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).IsAvailabilityZonesEnabled = value ?? default(bool); }

        /// <summary>
        /// Configures whether cluster will use double encryption. This Property can not be modified after cluster creation. Default
        /// value is 'true'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public bool? IsDoubleEncryptionEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).IsDoubleEncryptionEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).IsDoubleEncryptionEnabled = value ?? default(bool); }

        /// <summary>The name of the key associated with the Log Analytics cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyKeyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).KeyVaultPropertyKeyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).KeyVaultPropertyKeyName = value ?? null; }

        /// <summary>Selected key minimum required size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public int? KeyVaultPropertyKeyRsaSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).KeyVaultPropertyKeyRsaSize; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).KeyVaultPropertyKeyRsaSize = value ?? default(int); }

        /// <summary>
        /// The Key Vault uri which holds they key associated with the Log Analytics cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyKeyVaultUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).KeyVaultPropertyKeyVaultUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).KeyVaultPropertyKeyVaultUri = value ?? null; }

        /// <summary>The version of the key associated with the Log Analytics cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyKeyVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).KeyVaultPropertyKeyVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).KeyVaultPropertyKeyVersion = value ?? null; }

        /// <summary>The last time the cluster was updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string LastModifiedDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).LastModifiedDate; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ITrackedResourceInternal)__trackedResource).Location = value ; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__trackedResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__trackedResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__trackedResource).Type = value; }

        /// <summary>Internal Acessors for CapacityReservationProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ICapacityReservationProperties Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal.CapacityReservationProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).CapacityReservationProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).CapacityReservationProperty = value; }

        /// <summary>Internal Acessors for CapacityReservationPropertyLastSkuUpdate</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal.CapacityReservationPropertyLastSkuUpdate { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).CapacityReservationPropertyLastSkuUpdate; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).CapacityReservationPropertyLastSkuUpdate = value; }

        /// <summary>Internal Acessors for CapacityReservationPropertyMaxCapacity</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal.CapacityReservationPropertyMaxCapacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).CapacityReservationPropertyMaxCapacity; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).CapacityReservationPropertyMaxCapacity = value; }

        /// <summary>Internal Acessors for CapacityReservationPropertyMinCapacity</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal.CapacityReservationPropertyMinCapacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).CapacityReservationPropertyMinCapacity; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).CapacityReservationPropertyMinCapacity = value; }

        /// <summary>Internal Acessors for ClusterId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal.ClusterId { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).ClusterId; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).ClusterId = value; }

        /// <summary>Internal Acessors for CreatedDate</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal.CreatedDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).CreatedDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).CreatedDate = value; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentity Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.Identity()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentityInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentityInternal)Identity).PrincipalId = value; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentityInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentityInternal)Identity).TenantId = value; }

        /// <summary>Internal Acessors for KeyVaultProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IKeyVaultProperties Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal.KeyVaultProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).KeyVaultProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).KeyVaultProperty = value; }

        /// <summary>Internal Acessors for LastModifiedDate</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal.LastModifiedDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).LastModifiedDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).LastModifiedDate = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterProperties Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ClusterProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterEntityStatus? Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterSku Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ClusterSku()); set { {_sku = value;} } }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__trackedResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterProperties _property;

        /// <summary>Log Analytics cluster properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ClusterProperties()); set => this._property = value; }

        /// <summary>The provisioning state of the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterEntityStatus? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterSku _sku;

        /// <summary>The sku properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterSku Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ClusterSku()); set => this._sku = value; }

        /// <summary>The capacity value</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public long? SkuCapacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterSkuInternal)Sku).Capacity; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterSkuInternal)Sku).Capacity = value ?? default(long); }

        /// <summary>The name of the SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterSkuNameEnum? SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterSkuInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterSkuInternal)Sku).Name = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterSkuNameEnum)""); }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__trackedResource).Type; }

        /// <summary>Creates an new <see cref="Cluster" /> instance.</summary>
        public Cluster()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// The top level Log Analytics cluster resource container.
    public partial interface ICluster :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ITrackedResource
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
        /// <summary>The principal ID of resource identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The principal ID of resource identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPrincipalId { get;  }
        /// <summary>The tenant ID of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The tenant ID of resource.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityTenantId { get;  }
        /// <summary>Type of managed service identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of managed service identity.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.IdentityType) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.IdentityType? IdentityType { get; set; }
        /// <summary>
        /// The list of user identities associated with the resource. The user identity dictionary key references will be ARM resource
        /// ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of user identities associated with the resource. The user identity dictionary key references will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentityUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentityUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
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
        /// <summary>The capacity value</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The capacity value",
        SerializedName = @"capacity",
        PossibleTypes = new [] { typeof(long) })]
        long? SkuCapacity { get; set; }
        /// <summary>The name of the SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the SKU.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterSkuNameEnum) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterSkuNameEnum? SkuName { get; set; }

    }
    /// The top level Log Analytics cluster resource container.
    internal partial interface IClusterInternal :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ITrackedResourceInternal
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
        /// <summary>The identity of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentity Identity { get; set; }
        /// <summary>The principal ID of resource identity.</summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>The tenant ID of resource.</summary>
        string IdentityTenantId { get; set; }
        /// <summary>Type of managed service identity.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.IdentityType? IdentityType { get; set; }
        /// <summary>
        /// The list of user identities associated with the resource. The user identity dictionary key references will be ARM resource
        /// ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentityUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
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
        /// <summary>Log Analytics cluster properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterProperties Property { get; set; }
        /// <summary>The provisioning state of the cluster.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterEntityStatus? ProvisioningState { get; set; }
        /// <summary>The sku properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterSku Sku { get; set; }
        /// <summary>The capacity value</summary>
        long? SkuCapacity { get; set; }
        /// <summary>The name of the SKU.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterSkuNameEnum? SkuName { get; set; }

    }
}