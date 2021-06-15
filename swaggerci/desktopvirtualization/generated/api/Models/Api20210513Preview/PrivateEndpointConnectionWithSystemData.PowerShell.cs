namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.PowerShell;

    /// <summary>The Private Endpoint Connection resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(PrivateEndpointConnectionWithSystemDataTypeConverter))]
    public partial class PrivateEndpointConnectionWithSystemData
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.PrivateEndpointConnectionWithSystemData"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IPrivateEndpointConnectionWithSystemData"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IPrivateEndpointConnectionWithSystemData DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PrivateEndpointConnectionWithSystemData(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.PrivateEndpointConnectionWithSystemData"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IPrivateEndpointConnectionWithSystemData"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IPrivateEndpointConnectionWithSystemData DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new PrivateEndpointConnectionWithSystemData(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PrivateEndpointConnectionWithSystemData" />, deserializing the content from a json
        /// string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IPrivateEndpointConnectionWithSystemData FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.PrivateEndpointConnectionWithSystemData"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PrivateEndpointConnectionWithSystemData(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IPrivateEndpointConnectionWithSystemDataInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IPrivateEndpointConnectionWithSystemDataInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20.SystemDataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpointConnectionInternal)this).PrivateEndpoint = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpoint) content.GetValueForProperty("PrivateEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpointConnectionInternal)this).PrivateEndpoint, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.PrivateEndpointTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpointConnectionInternal)this).PrivateLinkServiceConnectionState = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateLinkServiceConnectionState) content.GetValueForProperty("PrivateLinkServiceConnectionState",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpointConnectionInternal)this).PrivateLinkServiceConnectionState, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.PrivateLinkServiceConnectionStateTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpointConnectionInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PrivateEndpointConnectionProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpointConnectionInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PrivateEndpointConnectionProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpointConnectionInternal)this).PrivateEndpointId = (string) content.GetValueForProperty("PrivateEndpointId",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpointConnectionInternal)this).PrivateEndpointId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpointConnectionInternal)this).PrivateLinkServiceConnectionStateDescription = (string) content.GetValueForProperty("PrivateLinkServiceConnectionStateDescription",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpointConnectionInternal)this).PrivateLinkServiceConnectionStateDescription, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpointConnectionInternal)this).PrivateLinkServiceConnectionStateActionsRequired = (string) content.GetValueForProperty("PrivateLinkServiceConnectionStateActionsRequired",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpointConnectionInternal)this).PrivateLinkServiceConnectionStateActionsRequired, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpointConnectionInternal)this).PrivateLinkServiceConnectionStateStatus = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PrivateEndpointServiceConnectionStatus?) content.GetValueForProperty("PrivateLinkServiceConnectionStateStatus",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpointConnectionInternal)this).PrivateLinkServiceConnectionStateStatus, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PrivateEndpointServiceConnectionStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpointConnectionInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpointConnectionProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpointConnectionInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.PrivateEndpointConnectionPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IPrivateEndpointConnectionWithSystemDataInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IPrivateEndpointConnectionWithSystemDataInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IPrivateEndpointConnectionWithSystemDataInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IPrivateEndpointConnectionWithSystemDataInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IPrivateEndpointConnectionWithSystemDataInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IPrivateEndpointConnectionWithSystemDataInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IPrivateEndpointConnectionWithSystemDataInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IPrivateEndpointConnectionWithSystemDataInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IPrivateEndpointConnectionWithSystemDataInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IPrivateEndpointConnectionWithSystemDataInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IPrivateEndpointConnectionWithSystemDataInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IPrivateEndpointConnectionWithSystemDataInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.PrivateEndpointConnectionWithSystemData"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal PrivateEndpointConnectionWithSystemData(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IPrivateEndpointConnectionWithSystemDataInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IPrivateEndpointConnectionWithSystemDataInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20.SystemDataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpointConnectionInternal)this).PrivateEndpoint = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpoint) content.GetValueForProperty("PrivateEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpointConnectionInternal)this).PrivateEndpoint, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.PrivateEndpointTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpointConnectionInternal)this).PrivateLinkServiceConnectionState = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateLinkServiceConnectionState) content.GetValueForProperty("PrivateLinkServiceConnectionState",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpointConnectionInternal)this).PrivateLinkServiceConnectionState, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.PrivateLinkServiceConnectionStateTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpointConnectionInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PrivateEndpointConnectionProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpointConnectionInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PrivateEndpointConnectionProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpointConnectionInternal)this).PrivateEndpointId = (string) content.GetValueForProperty("PrivateEndpointId",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpointConnectionInternal)this).PrivateEndpointId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpointConnectionInternal)this).PrivateLinkServiceConnectionStateDescription = (string) content.GetValueForProperty("PrivateLinkServiceConnectionStateDescription",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpointConnectionInternal)this).PrivateLinkServiceConnectionStateDescription, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpointConnectionInternal)this).PrivateLinkServiceConnectionStateActionsRequired = (string) content.GetValueForProperty("PrivateLinkServiceConnectionStateActionsRequired",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpointConnectionInternal)this).PrivateLinkServiceConnectionStateActionsRequired, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpointConnectionInternal)this).PrivateLinkServiceConnectionStateStatus = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PrivateEndpointServiceConnectionStatus?) content.GetValueForProperty("PrivateLinkServiceConnectionStateStatus",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpointConnectionInternal)this).PrivateLinkServiceConnectionStateStatus, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PrivateEndpointServiceConnectionStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpointConnectionInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpointConnectionProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPrivateEndpointConnectionInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.PrivateEndpointConnectionPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IPrivateEndpointConnectionWithSystemDataInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IPrivateEndpointConnectionWithSystemDataInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IPrivateEndpointConnectionWithSystemDataInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IPrivateEndpointConnectionWithSystemDataInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IPrivateEndpointConnectionWithSystemDataInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IPrivateEndpointConnectionWithSystemDataInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IPrivateEndpointConnectionWithSystemDataInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IPrivateEndpointConnectionWithSystemDataInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IPrivateEndpointConnectionWithSystemDataInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IPrivateEndpointConnectionWithSystemDataInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IPrivateEndpointConnectionWithSystemDataInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IPrivateEndpointConnectionWithSystemDataInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The Private Endpoint Connection resource.
    [System.ComponentModel.TypeConverter(typeof(PrivateEndpointConnectionWithSystemDataTypeConverter))]
    public partial interface IPrivateEndpointConnectionWithSystemData

    {

    }
}