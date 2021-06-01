namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520
{
    using Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.PowerShell;

    /// <summary>Describes a Machine Extension.</summary>
    [System.ComponentModel.TypeConverter(typeof(MachineExtensionTypeConverter))]
    public partial class MachineExtension
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.MachineExtension"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtension" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtension DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MachineExtension(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.MachineExtension"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtension" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtension DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MachineExtension(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MachineExtension" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtension FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.MachineExtension"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MachineExtension(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.MachineExtensionPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.SystemDataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.TrackedResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).InstanceView = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInstanceView) content.GetValueForProperty("InstanceView",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).InstanceView, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.MachineExtensionInstanceViewTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).ForceUpdateTag = (string) content.GetValueForProperty("ForceUpdateTag",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).ForceUpdateTag, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).Publisher = (string) content.GetValueForProperty("Publisher",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).Publisher, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).PropertiesType = (string) content.GetValueForProperty("PropertiesType",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).PropertiesType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).TypeHandlerVersion = (string) content.GetValueForProperty("TypeHandlerVersion",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).TypeHandlerVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).AutoUpgradeMinorVersion = (bool?) content.GetValueForProperty("AutoUpgradeMinorVersion",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).AutoUpgradeMinorVersion, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).Setting = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.IAny) content.GetValueForProperty("Setting",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).Setting, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.AnyTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).ProtectedSetting = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.IAny) content.GetValueForProperty("ProtectedSetting",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).ProtectedSetting, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.AnyTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).ProvisioningState, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).InstanceViewStatus = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInstanceViewStatus) content.GetValueForProperty("InstanceViewStatus",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).InstanceViewStatus, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.MachineExtensionInstanceViewStatusTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).InstanceViewName = (string) content.GetValueForProperty("InstanceViewName",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).InstanceViewName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).InstanceViewType = (string) content.GetValueForProperty("InstanceViewType",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).InstanceViewType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).InstanceViewTypeHandlerVersion = (string) content.GetValueForProperty("InstanceViewTypeHandlerVersion",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).InstanceViewTypeHandlerVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).StatusCode = (string) content.GetValueForProperty("StatusCode",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).StatusCode, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).StatusLevel = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.StatusLevelTypes?) content.GetValueForProperty("StatusLevel",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).StatusLevel, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.StatusLevelTypes.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).StatusDisplayStatus = (string) content.GetValueForProperty("StatusDisplayStatus",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).StatusDisplayStatus, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).StatusMessage = (string) content.GetValueForProperty("StatusMessage",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).StatusMessage, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).StatusTime = (global::System.DateTime?) content.GetValueForProperty("StatusTime",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).StatusTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.MachineExtension"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MachineExtension(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.MachineExtensionPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.SystemDataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.TrackedResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).InstanceView = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInstanceView) content.GetValueForProperty("InstanceView",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).InstanceView, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.MachineExtensionInstanceViewTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).ForceUpdateTag = (string) content.GetValueForProperty("ForceUpdateTag",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).ForceUpdateTag, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).Publisher = (string) content.GetValueForProperty("Publisher",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).Publisher, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).PropertiesType = (string) content.GetValueForProperty("PropertiesType",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).PropertiesType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).TypeHandlerVersion = (string) content.GetValueForProperty("TypeHandlerVersion",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).TypeHandlerVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).AutoUpgradeMinorVersion = (bool?) content.GetValueForProperty("AutoUpgradeMinorVersion",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).AutoUpgradeMinorVersion, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).Setting = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.IAny) content.GetValueForProperty("Setting",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).Setting, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.AnyTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).ProtectedSetting = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.IAny) content.GetValueForProperty("ProtectedSetting",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).ProtectedSetting, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.AnyTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).ProvisioningState, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).InstanceViewStatus = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInstanceViewStatus) content.GetValueForProperty("InstanceViewStatus",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).InstanceViewStatus, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.MachineExtensionInstanceViewStatusTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).InstanceViewName = (string) content.GetValueForProperty("InstanceViewName",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).InstanceViewName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).InstanceViewType = (string) content.GetValueForProperty("InstanceViewType",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).InstanceViewType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).InstanceViewTypeHandlerVersion = (string) content.GetValueForProperty("InstanceViewTypeHandlerVersion",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).InstanceViewTypeHandlerVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).StatusCode = (string) content.GetValueForProperty("StatusCode",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).StatusCode, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).StatusLevel = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.StatusLevelTypes?) content.GetValueForProperty("StatusLevel",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).StatusLevel, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.StatusLevelTypes.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).StatusDisplayStatus = (string) content.GetValueForProperty("StatusDisplayStatus",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).StatusDisplayStatus, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).StatusMessage = (string) content.GetValueForProperty("StatusMessage",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).StatusMessage, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).StatusTime = (global::System.DateTime?) content.GetValueForProperty("StatusTime",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IMachineExtensionInternal)this).StatusTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Describes a Machine Extension.
    [System.ComponentModel.TypeConverter(typeof(MachineExtensionTypeConverter))]
    public partial interface IMachineExtension

    {

    }
}