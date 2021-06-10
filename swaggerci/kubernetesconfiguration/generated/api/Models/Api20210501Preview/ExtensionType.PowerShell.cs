namespace Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.PowerShell;

    /// <summary>Represents an Extension Type.</summary>
    [System.ComponentModel.TypeConverter(typeof(ExtensionTypeTypeConverter))]
    public partial class ExtensionType
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ExtensionType"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionType"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionType DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ExtensionType(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ExtensionType"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionType"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionType DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ExtensionType(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ExtensionType"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ExtensionType(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ExtensionTypePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.SystemDataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SupportedScope = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ISupportedScopes) content.GetValueForProperty("SupportedScope",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SupportedScope, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.SupportedScopesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).ClusterType = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ClusterTypes?) content.GetValueForProperty("ClusterType",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).ClusterType, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ClusterTypes.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).ReleaseTrain = (string[]) content.GetValueForProperty("ReleaseTrain",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).ReleaseTrain, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SupportedScopeDefaultScope = (string) content.GetValueForProperty("SupportedScopeDefaultScope",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SupportedScopeDefaultScope, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SupportedScopeClusterScopeSetting = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IClusterScopeSettings) content.GetValueForProperty("SupportedScopeClusterScopeSetting",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SupportedScopeClusterScopeSetting, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ClusterScopeSettingsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).ClusterScopeSettingProperty = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IClusterScopeSettingsProperties) content.GetValueForProperty("ClusterScopeSettingProperty",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).ClusterScopeSettingProperty, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ClusterScopeSettingsPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).ClusterScopeSettingId = (string) content.GetValueForProperty("ClusterScopeSettingId",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).ClusterScopeSettingId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).ClusterScopeSettingName = (string) content.GetValueForProperty("ClusterScopeSettingName",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).ClusterScopeSettingName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).ClusterScopeSettingType = (string) content.GetValueForProperty("ClusterScopeSettingType",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).ClusterScopeSettingType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).AllowMultipleInstance = (bool?) content.GetValueForProperty("AllowMultipleInstance",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).AllowMultipleInstance, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).DefaultReleaseNamespace = (string) content.GetValueForProperty("DefaultReleaseNamespace",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).DefaultReleaseNamespace, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ExtensionType"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ExtensionType(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ExtensionTypePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20.SystemDataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SupportedScope = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ISupportedScopes) content.GetValueForProperty("SupportedScope",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SupportedScope, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.SupportedScopesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).ClusterType = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ClusterTypes?) content.GetValueForProperty("ClusterType",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).ClusterType, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ClusterTypes.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).ReleaseTrain = (string[]) content.GetValueForProperty("ReleaseTrain",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).ReleaseTrain, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SupportedScopeDefaultScope = (string) content.GetValueForProperty("SupportedScopeDefaultScope",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SupportedScopeDefaultScope, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SupportedScopeClusterScopeSetting = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IClusterScopeSettings) content.GetValueForProperty("SupportedScopeClusterScopeSetting",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).SupportedScopeClusterScopeSetting, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ClusterScopeSettingsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).ClusterScopeSettingProperty = (Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IClusterScopeSettingsProperties) content.GetValueForProperty("ClusterScopeSettingProperty",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).ClusterScopeSettingProperty, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.ClusterScopeSettingsPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).ClusterScopeSettingId = (string) content.GetValueForProperty("ClusterScopeSettingId",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).ClusterScopeSettingId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).ClusterScopeSettingName = (string) content.GetValueForProperty("ClusterScopeSettingName",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).ClusterScopeSettingName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).ClusterScopeSettingType = (string) content.GetValueForProperty("ClusterScopeSettingType",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).ClusterScopeSettingType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).AllowMultipleInstance = (bool?) content.GetValueForProperty("AllowMultipleInstance",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).AllowMultipleInstance, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).DefaultReleaseNamespace = (string) content.GetValueForProperty("DefaultReleaseNamespace",((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionTypeInternal)this).DefaultReleaseNamespace, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ExtensionType" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionType FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Represents an Extension Type.
    [System.ComponentModel.TypeConverter(typeof(ExtensionTypeTypeConverter))]
    public partial interface IExtensionType

    {

    }
}