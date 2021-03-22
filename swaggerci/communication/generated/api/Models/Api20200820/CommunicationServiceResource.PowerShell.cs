namespace Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820
{
    using Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.PowerShell;

    /// <summary>A class representing a CommunicationService resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(CommunicationServiceResourceTypeConverter))]
    public partial class CommunicationServiceResource
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.CommunicationServiceResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CommunicationServiceResource(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.CommunicationServicePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.SystemDataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).AzureAsyncOperation = (string) content.GetValueForProperty("AzureAsyncOperation",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).AzureAsyncOperation, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ILocationResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ILocationResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ITaggedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ITaggedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ITaggedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.TaggedResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.ProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).HostName = (string) content.GetValueForProperty("HostName",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).HostName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).DataLocation = (string) content.GetValueForProperty("DataLocation",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).DataLocation, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).NotificationHubId = (string) content.GetValueForProperty("NotificationHubId",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).NotificationHubId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).Version, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).ImmutableResourceId = (string) content.GetValueForProperty("ImmutableResourceId",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).ImmutableResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.CommunicationServiceResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CommunicationServiceResource(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.CommunicationServicePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.SystemDataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).AzureAsyncOperation = (string) content.GetValueForProperty("AzureAsyncOperation",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).AzureAsyncOperation, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ILocationResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ILocationResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ITaggedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ITaggedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ITaggedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.TaggedResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.ProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).HostName = (string) content.GetValueForProperty("HostName",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).HostName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).DataLocation = (string) content.GetValueForProperty("DataLocation",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).DataLocation, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).NotificationHubId = (string) content.GetValueForProperty("NotificationHubId",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).NotificationHubId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).Version, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).ImmutableResourceId = (string) content.GetValueForProperty("ImmutableResourceId",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).ImmutableResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.CommunicationServiceResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResource"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResource DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CommunicationServiceResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.CommunicationServiceResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResource"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResource DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CommunicationServiceResource(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CommunicationServiceResource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ICommunicationServiceResource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// A class representing a CommunicationService resource.
    [System.ComponentModel.TypeConverter(typeof(CommunicationServiceResourceTypeConverter))]
    public partial interface ICommunicationServiceResource

    {

    }
}