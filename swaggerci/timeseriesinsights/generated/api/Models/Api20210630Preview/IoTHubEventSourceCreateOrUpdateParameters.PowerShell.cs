namespace Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.PowerShell;

    /// <summary>
    /// Parameters supplied to the Create or Update Event Source operation for an IoTHub event source.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(IoTHubEventSourceCreateOrUpdateParametersTypeConverter))]
    public partial class IoTHubEventSourceCreateOrUpdateParameters
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IoTHubEventSourceCreateOrUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParameters"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParameters DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new IoTHubEventSourceCreateOrUpdateParameters(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IoTHubEventSourceCreateOrUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParameters"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParameters DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new IoTHubEventSourceCreateOrUpdateParameters(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="IoTHubEventSourceCreateOrUpdateParameters" />, deserializing the content from a json
        /// string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParameters FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IoTHubEventSourceCreateOrUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal IoTHubEventSourceCreateOrUpdateParameters(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreationProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IoTHubEventSourceCreationPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ICreateOrUpdateTrackedResourcePropertiesInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ICreateOrUpdateTrackedResourcePropertiesInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ICreateOrUpdateTrackedResourcePropertiesInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ICreateOrUpdateTrackedResourcePropertiesTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ICreateOrUpdateTrackedResourcePropertiesInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.CreateOrUpdateTrackedResourcePropertiesTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCreateOrUpdateParametersInternal)this).LocalTimestampFormat = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.LocalTimestampFormat?) content.GetValueForProperty("LocalTimestampFormat",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCreateOrUpdateParametersInternal)this).LocalTimestampFormat, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.LocalTimestampFormat.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCreateOrUpdateParametersInternal)this).LocalTimestampTimeZoneOffset = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ILocalTimestampTimeZoneOffset) content.GetValueForProperty("LocalTimestampTimeZoneOffset",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCreateOrUpdateParametersInternal)this).LocalTimestampTimeZoneOffset, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.LocalTimestampTimeZoneOffsetTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCreateOrUpdateParametersInternal)this).TimeZoneOffsetPropertyName = (string) content.GetValueForProperty("TimeZoneOffsetPropertyName",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCreateOrUpdateParametersInternal)this).TimeZoneOffsetPropertyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCreateOrUpdateParametersInternal)this).LocalTimestamp = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ILocalTimestamp) content.GetValueForProperty("LocalTimestamp",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCreateOrUpdateParametersInternal)this).LocalTimestamp, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.LocalTimestampTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCreateOrUpdateParametersInternal)this).Kind = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.EventSourceKind) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCreateOrUpdateParametersInternal)this).Kind, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.EventSourceKind.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.ProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).PropertiesLocalTimestamp = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ILocalTimestamp) content.GetValueForProperty("PropertiesLocalTimestamp",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).PropertiesLocalTimestamp, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.LocalTimestampTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).CreationTime = (global::System.DateTime?) content.GetValueForProperty("CreationTime",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).CreationTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).PropertiesLocalTimestampFormat = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.LocalTimestampFormat?) content.GetValueForProperty("PropertiesLocalTimestampFormat",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).PropertiesLocalTimestampFormat, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.LocalTimestampFormat.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).IngressStartAtType = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.IngressStartAtType?) content.GetValueForProperty("IngressStartAtType",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).IngressStartAtType, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.IngressStartAtType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).IngressStartAt = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIngressStartAtProperties) content.GetValueForProperty("IngressStartAt",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).IngressStartAt, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IngressStartAtPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).TimestampPropertyName = (string) content.GetValueForProperty("TimestampPropertyName",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).TimestampPropertyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).EventSourceResourceId = (string) content.GetValueForProperty("EventSourceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).EventSourceResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).IotHubName = (string) content.GetValueForProperty("IotHubName",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).IotHubName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).ConsumerGroupName = (string) content.GetValueForProperty("ConsumerGroupName",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).ConsumerGroupName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).KeyName = (string) content.GetValueForProperty("KeyName",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).KeyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).SharedAccessKey = (string) content.GetValueForProperty("SharedAccessKey",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).SharedAccessKey, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).PropertiesLocalTimestampTimeZoneOffset = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ILocalTimestampTimeZoneOffset) content.GetValueForProperty("PropertiesLocalTimestampTimeZoneOffset",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).PropertiesLocalTimestampTimeZoneOffset, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.LocalTimestampTimeZoneOffsetTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).PropertiesLocalTimestampTimeZoneOffsetPropertyName = (string) content.GetValueForProperty("PropertiesLocalTimestampTimeZoneOffsetPropertyName",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).PropertiesLocalTimestampTimeZoneOffsetPropertyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).IngressStartAtTime = (string) content.GetValueForProperty("IngressStartAtTime",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).IngressStartAtTime, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IoTHubEventSourceCreateOrUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal IoTHubEventSourceCreateOrUpdateParameters(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreationProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IoTHubEventSourceCreationPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ICreateOrUpdateTrackedResourcePropertiesInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ICreateOrUpdateTrackedResourcePropertiesInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ICreateOrUpdateTrackedResourcePropertiesInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ICreateOrUpdateTrackedResourcePropertiesTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ICreateOrUpdateTrackedResourcePropertiesInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.CreateOrUpdateTrackedResourcePropertiesTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCreateOrUpdateParametersInternal)this).LocalTimestampFormat = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.LocalTimestampFormat?) content.GetValueForProperty("LocalTimestampFormat",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCreateOrUpdateParametersInternal)this).LocalTimestampFormat, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.LocalTimestampFormat.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCreateOrUpdateParametersInternal)this).LocalTimestampTimeZoneOffset = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ILocalTimestampTimeZoneOffset) content.GetValueForProperty("LocalTimestampTimeZoneOffset",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCreateOrUpdateParametersInternal)this).LocalTimestampTimeZoneOffset, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.LocalTimestampTimeZoneOffsetTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCreateOrUpdateParametersInternal)this).TimeZoneOffsetPropertyName = (string) content.GetValueForProperty("TimeZoneOffsetPropertyName",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCreateOrUpdateParametersInternal)this).TimeZoneOffsetPropertyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCreateOrUpdateParametersInternal)this).LocalTimestamp = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ILocalTimestamp) content.GetValueForProperty("LocalTimestamp",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCreateOrUpdateParametersInternal)this).LocalTimestamp, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.LocalTimestampTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCreateOrUpdateParametersInternal)this).Kind = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.EventSourceKind) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEventSourceCreateOrUpdateParametersInternal)this).Kind, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.EventSourceKind.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.ProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).PropertiesLocalTimestamp = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ILocalTimestamp) content.GetValueForProperty("PropertiesLocalTimestamp",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).PropertiesLocalTimestamp, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.LocalTimestampTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).CreationTime = (global::System.DateTime?) content.GetValueForProperty("CreationTime",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).CreationTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).PropertiesLocalTimestampFormat = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.LocalTimestampFormat?) content.GetValueForProperty("PropertiesLocalTimestampFormat",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).PropertiesLocalTimestampFormat, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.LocalTimestampFormat.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).IngressStartAtType = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.IngressStartAtType?) content.GetValueForProperty("IngressStartAtType",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).IngressStartAtType, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.IngressStartAtType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).IngressStartAt = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIngressStartAtProperties) content.GetValueForProperty("IngressStartAt",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).IngressStartAt, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IngressStartAtPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).TimestampPropertyName = (string) content.GetValueForProperty("TimestampPropertyName",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).TimestampPropertyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).EventSourceResourceId = (string) content.GetValueForProperty("EventSourceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).EventSourceResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).IotHubName = (string) content.GetValueForProperty("IotHubName",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).IotHubName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).ConsumerGroupName = (string) content.GetValueForProperty("ConsumerGroupName",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).ConsumerGroupName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).KeyName = (string) content.GetValueForProperty("KeyName",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).KeyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).SharedAccessKey = (string) content.GetValueForProperty("SharedAccessKey",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).SharedAccessKey, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).PropertiesLocalTimestampTimeZoneOffset = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ILocalTimestampTimeZoneOffset) content.GetValueForProperty("PropertiesLocalTimestampTimeZoneOffset",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).PropertiesLocalTimestampTimeZoneOffset, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.LocalTimestampTimeZoneOffsetTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).PropertiesLocalTimestampTimeZoneOffsetPropertyName = (string) content.GetValueForProperty("PropertiesLocalTimestampTimeZoneOffsetPropertyName",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).PropertiesLocalTimestampTimeZoneOffsetPropertyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).IngressStartAtTime = (string) content.GetValueForProperty("IngressStartAtTime",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IIoTHubEventSourceCreateOrUpdateParametersInternal)this).IngressStartAtTime, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Parameters supplied to the Create or Update Event Source operation for an IoTHub event source.
    [System.ComponentModel.TypeConverter(typeof(IoTHubEventSourceCreateOrUpdateParametersTypeConverter))]
    public partial interface IIoTHubEventSourceCreateOrUpdateParameters

    {

    }
}