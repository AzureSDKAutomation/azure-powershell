namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001
{
    using Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.PowerShell;

    /// <summary>The top level Log Analytics cluster resource container.</summary>
    [System.ComponentModel.TypeConverter(typeof(ClusterTypeConverter))]
    public partial class Cluster
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.Cluster"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Cluster(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IdentityTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterSku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ClusterSkuTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ClusterPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.TrackedResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).IdentityTenantId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).IdentityType = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.IdentityType) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).IdentityType, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.IdentityType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).BillingType = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.BillingType?) content.GetValueForProperty("BillingType",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).BillingType, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.BillingType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).IdentityUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentityUserAssignedIdentities) content.GetValueForProperty("IdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).IdentityUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IdentityUserAssignedIdentitiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).SkuCapacity = (long?) content.GetValueForProperty("SkuCapacity",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).SkuCapacity, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).SkuName = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterSkuNameEnum?) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).SkuName, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterSkuNameEnum.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).KeyVaultProperty = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IKeyVaultProperties) content.GetValueForProperty("KeyVaultProperty",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).KeyVaultProperty, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.KeyVaultPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).CapacityReservationProperty = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ICapacityReservationProperties) content.GetValueForProperty("CapacityReservationProperty",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).CapacityReservationProperty, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.CapacityReservationPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).ClusterId = (string) content.GetValueForProperty("ClusterId",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).ClusterId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterEntityStatus?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterEntityStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).IsDoubleEncryptionEnabled = (bool?) content.GetValueForProperty("IsDoubleEncryptionEnabled",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).IsDoubleEncryptionEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).IsAvailabilityZonesEnabled = (bool?) content.GetValueForProperty("IsAvailabilityZonesEnabled",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).IsAvailabilityZonesEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).LastModifiedDate = (string) content.GetValueForProperty("LastModifiedDate",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).LastModifiedDate, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).CreatedDate = (string) content.GetValueForProperty("CreatedDate",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).CreatedDate, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).AssociatedWorkspace = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspace[]) content.GetValueForProperty("AssociatedWorkspace",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).AssociatedWorkspace, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspace>(__y, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.AssociatedWorkspaceTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).KeyVaultPropertyKeyName = (string) content.GetValueForProperty("KeyVaultPropertyKeyName",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).KeyVaultPropertyKeyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).KeyVaultPropertyKeyVersion = (string) content.GetValueForProperty("KeyVaultPropertyKeyVersion",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).KeyVaultPropertyKeyVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).KeyVaultPropertyKeyVaultUri = (string) content.GetValueForProperty("KeyVaultPropertyKeyVaultUri",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).KeyVaultPropertyKeyVaultUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).KeyVaultPropertyKeyRsaSize = (int?) content.GetValueForProperty("KeyVaultPropertyKeyRsaSize",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).KeyVaultPropertyKeyRsaSize, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).CapacityReservationPropertyLastSkuUpdate = (string) content.GetValueForProperty("CapacityReservationPropertyLastSkuUpdate",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).CapacityReservationPropertyLastSkuUpdate, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).CapacityReservationPropertyMinCapacity = (long?) content.GetValueForProperty("CapacityReservationPropertyMinCapacity",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).CapacityReservationPropertyMinCapacity, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).CapacityReservationPropertyMaxCapacity = (long?) content.GetValueForProperty("CapacityReservationPropertyMaxCapacity",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).CapacityReservationPropertyMaxCapacity, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.Cluster"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Cluster(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IdentityTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterSku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ClusterSkuTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ClusterPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.TrackedResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).IdentityTenantId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).IdentityType = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.IdentityType) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).IdentityType, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.IdentityType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).BillingType = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.BillingType?) content.GetValueForProperty("BillingType",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).BillingType, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.BillingType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).IdentityUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentityUserAssignedIdentities) content.GetValueForProperty("IdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).IdentityUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IdentityUserAssignedIdentitiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).SkuCapacity = (long?) content.GetValueForProperty("SkuCapacity",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).SkuCapacity, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).SkuName = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterSkuNameEnum?) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).SkuName, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterSkuNameEnum.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).KeyVaultProperty = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IKeyVaultProperties) content.GetValueForProperty("KeyVaultProperty",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).KeyVaultProperty, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.KeyVaultPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).CapacityReservationProperty = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ICapacityReservationProperties) content.GetValueForProperty("CapacityReservationProperty",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).CapacityReservationProperty, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.CapacityReservationPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).ClusterId = (string) content.GetValueForProperty("ClusterId",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).ClusterId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterEntityStatus?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterEntityStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).IsDoubleEncryptionEnabled = (bool?) content.GetValueForProperty("IsDoubleEncryptionEnabled",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).IsDoubleEncryptionEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).IsAvailabilityZonesEnabled = (bool?) content.GetValueForProperty("IsAvailabilityZonesEnabled",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).IsAvailabilityZonesEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).LastModifiedDate = (string) content.GetValueForProperty("LastModifiedDate",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).LastModifiedDate, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).CreatedDate = (string) content.GetValueForProperty("CreatedDate",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).CreatedDate, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).AssociatedWorkspace = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspace[]) content.GetValueForProperty("AssociatedWorkspace",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).AssociatedWorkspace, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspace>(__y, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.AssociatedWorkspaceTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).KeyVaultPropertyKeyName = (string) content.GetValueForProperty("KeyVaultPropertyKeyName",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).KeyVaultPropertyKeyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).KeyVaultPropertyKeyVersion = (string) content.GetValueForProperty("KeyVaultPropertyKeyVersion",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).KeyVaultPropertyKeyVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).KeyVaultPropertyKeyVaultUri = (string) content.GetValueForProperty("KeyVaultPropertyKeyVaultUri",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).KeyVaultPropertyKeyVaultUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).KeyVaultPropertyKeyRsaSize = (int?) content.GetValueForProperty("KeyVaultPropertyKeyRsaSize",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).KeyVaultPropertyKeyRsaSize, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).CapacityReservationPropertyLastSkuUpdate = (string) content.GetValueForProperty("CapacityReservationPropertyLastSkuUpdate",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).CapacityReservationPropertyLastSkuUpdate, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).CapacityReservationPropertyMinCapacity = (long?) content.GetValueForProperty("CapacityReservationPropertyMinCapacity",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).CapacityReservationPropertyMinCapacity, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).CapacityReservationPropertyMaxCapacity = (long?) content.GetValueForProperty("CapacityReservationPropertyMaxCapacity",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterInternal)this).CapacityReservationPropertyMaxCapacity, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.Cluster"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ICluster" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ICluster DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Cluster(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.Cluster"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ICluster" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ICluster DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Cluster(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Cluster" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ICluster FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The top level Log Analytics cluster resource container.
    [System.ComponentModel.TypeConverter(typeof(ClusterTypeConverter))]
    public partial interface ICluster

    {

    }
}