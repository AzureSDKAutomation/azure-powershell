namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001
{
    using Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.PowerShell;

    /// <summary>The top level Workspace resource container.</summary>
    [System.ComponentModel.TypeConverter(typeof(WorkspaceTypeConverter))]
    public partial class Workspace
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.Workspace"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspace" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspace DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Workspace(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.Workspace"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspace" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspace DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Workspace(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Workspace" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspace FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.Workspace"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Workspace(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.WorkspacePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).ETag = (string) content.GetValueForProperty("ETag",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).ETag, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.TrackedResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).Capping = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceCapping) content.GetValueForProperty("Capping",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).Capping, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.WorkspaceCappingTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceSku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.WorkspaceSkuTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceEntityStatus?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceEntityStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).CustomerId = (string) content.GetValueForProperty("CustomerId",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).CustomerId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).RetentionInDay = (int?) content.GetValueForProperty("RetentionInDay",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).RetentionInDay, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).CreatedDate = (string) content.GetValueForProperty("CreatedDate",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).CreatedDate, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).ModifiedDate = (string) content.GetValueForProperty("ModifiedDate",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).ModifiedDate, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).PublicNetworkAccessForIngestion = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PublicNetworkAccessType?) content.GetValueForProperty("PublicNetworkAccessForIngestion",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).PublicNetworkAccessForIngestion, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PublicNetworkAccessType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).PublicNetworkAccessForQuery = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PublicNetworkAccessType?) content.GetValueForProperty("PublicNetworkAccessForQuery",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).PublicNetworkAccessForQuery, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PublicNetworkAccessType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).ForceCmkForQuery = (bool?) content.GetValueForProperty("ForceCmkForQuery",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).ForceCmkForQuery, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).PrivateLinkScopedResource = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IPrivateLinkScopedResource[]) content.GetValueForProperty("PrivateLinkScopedResource",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).PrivateLinkScopedResource, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IPrivateLinkScopedResource>(__y, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.PrivateLinkScopedResourceTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).Feature = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceFeatures) content.GetValueForProperty("Feature",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).Feature, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.WorkspaceFeaturesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).SkuName = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceSkuNameEnum) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).SkuName, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceSkuNameEnum.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).SkuCapacityReservationLevel = (int?) content.GetValueForProperty("SkuCapacityReservationLevel",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).SkuCapacityReservationLevel, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).SkuMaxCapacityReservationLevel = (int?) content.GetValueForProperty("SkuMaxCapacityReservationLevel",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).SkuMaxCapacityReservationLevel, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).SkuLastSkuUpdate = (string) content.GetValueForProperty("SkuLastSkuUpdate",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).SkuLastSkuUpdate, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).CappingDailyQuotaGb = (double?) content.GetValueForProperty("CappingDailyQuotaGb",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).CappingDailyQuotaGb, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).CappingQuotaNextResetTime = (string) content.GetValueForProperty("CappingQuotaNextResetTime",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).CappingQuotaNextResetTime, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).CappingDataIngestionStatus = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataIngestionStatus?) content.GetValueForProperty("CappingDataIngestionStatus",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).CappingDataIngestionStatus, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataIngestionStatus.CreateFrom);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.Workspace"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Workspace(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.WorkspacePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).ETag = (string) content.GetValueForProperty("ETag",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).ETag, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.TrackedResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).Capping = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceCapping) content.GetValueForProperty("Capping",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).Capping, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.WorkspaceCappingTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceSku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.WorkspaceSkuTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceEntityStatus?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceEntityStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).CustomerId = (string) content.GetValueForProperty("CustomerId",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).CustomerId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).RetentionInDay = (int?) content.GetValueForProperty("RetentionInDay",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).RetentionInDay, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).CreatedDate = (string) content.GetValueForProperty("CreatedDate",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).CreatedDate, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).ModifiedDate = (string) content.GetValueForProperty("ModifiedDate",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).ModifiedDate, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).PublicNetworkAccessForIngestion = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PublicNetworkAccessType?) content.GetValueForProperty("PublicNetworkAccessForIngestion",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).PublicNetworkAccessForIngestion, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PublicNetworkAccessType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).PublicNetworkAccessForQuery = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PublicNetworkAccessType?) content.GetValueForProperty("PublicNetworkAccessForQuery",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).PublicNetworkAccessForQuery, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PublicNetworkAccessType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).ForceCmkForQuery = (bool?) content.GetValueForProperty("ForceCmkForQuery",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).ForceCmkForQuery, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).PrivateLinkScopedResource = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IPrivateLinkScopedResource[]) content.GetValueForProperty("PrivateLinkScopedResource",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).PrivateLinkScopedResource, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IPrivateLinkScopedResource>(__y, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.PrivateLinkScopedResourceTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).Feature = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceFeatures) content.GetValueForProperty("Feature",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).Feature, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.WorkspaceFeaturesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).SkuName = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceSkuNameEnum) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).SkuName, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceSkuNameEnum.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).SkuCapacityReservationLevel = (int?) content.GetValueForProperty("SkuCapacityReservationLevel",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).SkuCapacityReservationLevel, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).SkuMaxCapacityReservationLevel = (int?) content.GetValueForProperty("SkuMaxCapacityReservationLevel",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).SkuMaxCapacityReservationLevel, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).SkuLastSkuUpdate = (string) content.GetValueForProperty("SkuLastSkuUpdate",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).SkuLastSkuUpdate, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).CappingDailyQuotaGb = (double?) content.GetValueForProperty("CappingDailyQuotaGb",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).CappingDailyQuotaGb, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).CappingQuotaNextResetTime = (string) content.GetValueForProperty("CappingQuotaNextResetTime",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).CappingQuotaNextResetTime, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).CappingDataIngestionStatus = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataIngestionStatus?) content.GetValueForProperty("CappingDataIngestionStatus",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceInternal)this).CappingDataIngestionStatus, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataIngestionStatus.CreateFrom);
            AfterDeserializePSObject(content);
        }
    }
    /// The top level Workspace resource container.
    [System.ComponentModel.TypeConverter(typeof(WorkspaceTypeConverter))]
    public partial interface IWorkspace

    {

    }
}