namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.PowerShell;

    /// <summary>App resource payload</summary>
    [System.ComponentModel.TypeConverter(typeof(AppResourceTypeConverter))]
    public partial class AppResource
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.AppResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AppResource(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.AppResourcePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20.SystemDataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IManagedIdentityProperties) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ManagedIdentityPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).TemporaryDisk = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ITemporaryDisk) content.GetValueForProperty("TemporaryDisk",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).TemporaryDisk, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.TemporaryDiskTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).PersistentDisk = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IPersistentDisk) content.GetValueForProperty("PersistentDisk",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).PersistentDisk, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.PersistentDiskTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).Public = (bool?) content.GetValueForProperty("Public",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).Public, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).Url = (string) content.GetValueForProperty("Url",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).Url, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).AddonConfig = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourcePropertiesAddonConfig) content.GetValueForProperty("AddonConfig",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).AddonConfig, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.AppResourcePropertiesAddonConfigTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.AppResourceProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.AppResourceProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).Fqdn = (string) content.GetValueForProperty("Fqdn",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).Fqdn, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).HttpsOnly = (bool?) content.GetValueForProperty("HttpsOnly",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).HttpsOnly, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).EnableEndToEndTl = (bool?) content.GetValueForProperty("EnableEndToEndTl",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).EnableEndToEndTl, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).TemporaryDiskMountPath = (string) content.GetValueForProperty("TemporaryDiskMountPath",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).TemporaryDiskMountPath, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).PersistentDiskMountPath = (string) content.GetValueForProperty("PersistentDiskMountPath",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).PersistentDiskMountPath, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).IdentityType = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ManagedIdentityType?) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).IdentityType, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ManagedIdentityType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).IdentityTenantId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).TemporaryDiskSizeInGb = (int?) content.GetValueForProperty("TemporaryDiskSizeInGb",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).TemporaryDiskSizeInGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).PersistentDiskSizeInGb = (int?) content.GetValueForProperty("PersistentDiskSizeInGb",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).PersistentDiskSizeInGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).PersistentDiskUsedInGb = (int?) content.GetValueForProperty("PersistentDiskUsedInGb",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).PersistentDiskUsedInGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.AppResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AppResource(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.AppResourcePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20.SystemDataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IManagedIdentityProperties) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ManagedIdentityPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).TemporaryDisk = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ITemporaryDisk) content.GetValueForProperty("TemporaryDisk",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).TemporaryDisk, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.TemporaryDiskTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).PersistentDisk = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IPersistentDisk) content.GetValueForProperty("PersistentDisk",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).PersistentDisk, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.PersistentDiskTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).Public = (bool?) content.GetValueForProperty("Public",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).Public, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).Url = (string) content.GetValueForProperty("Url",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).Url, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).AddonConfig = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourcePropertiesAddonConfig) content.GetValueForProperty("AddonConfig",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).AddonConfig, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.AppResourcePropertiesAddonConfigTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.AppResourceProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.AppResourceProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).Fqdn = (string) content.GetValueForProperty("Fqdn",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).Fqdn, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).HttpsOnly = (bool?) content.GetValueForProperty("HttpsOnly",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).HttpsOnly, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).EnableEndToEndTl = (bool?) content.GetValueForProperty("EnableEndToEndTl",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).EnableEndToEndTl, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).TemporaryDiskMountPath = (string) content.GetValueForProperty("TemporaryDiskMountPath",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).TemporaryDiskMountPath, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).PersistentDiskMountPath = (string) content.GetValueForProperty("PersistentDiskMountPath",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).PersistentDiskMountPath, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).IdentityType = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ManagedIdentityType?) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).IdentityType, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ManagedIdentityType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).IdentityTenantId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).TemporaryDiskSizeInGb = (int?) content.GetValueForProperty("TemporaryDiskSizeInGb",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).TemporaryDiskSizeInGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).PersistentDiskSizeInGb = (int?) content.GetValueForProperty("PersistentDiskSizeInGb",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).PersistentDiskSizeInGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).PersistentDiskUsedInGb = (int?) content.GetValueForProperty("PersistentDiskUsedInGb",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourceInternal)this).PersistentDiskUsedInGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.AppResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResource DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AppResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.AppResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResource DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AppResource(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AppResource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// App resource payload
    [System.ComponentModel.TypeConverter(typeof(AppResourceTypeConverter))]
    public partial interface IAppResource

    {

    }
}