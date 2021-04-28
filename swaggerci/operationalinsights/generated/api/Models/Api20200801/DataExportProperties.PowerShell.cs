namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.PowerShell;

    /// <summary>Data Export properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(DataExportPropertiesTypeConverter))]
    public partial class DataExportProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.DataExportProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DataExportProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).Destination = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDestination) content.GetValueForProperty("Destination",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).Destination, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.DestinationTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).DataExportId = (string) content.GetValueForProperty("DataExportId",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).DataExportId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).TableName = (string[]) content.GetValueForProperty("TableName",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).TableName, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).Enable = (bool?) content.GetValueForProperty("Enable",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).Enable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).CreatedDate = (string) content.GetValueForProperty("CreatedDate",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).CreatedDate, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).LastModifiedDate = (string) content.GetValueForProperty("LastModifiedDate",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).LastModifiedDate, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).DestinationMetaData = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDestinationMetaData) content.GetValueForProperty("DestinationMetaData",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).DestinationMetaData, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.DestinationMetaDataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).DestinationResourceId = (string) content.GetValueForProperty("DestinationResourceId",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).DestinationResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).DestinationType = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.Type?) content.GetValueForProperty("DestinationType",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).DestinationType, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.Type.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).MetaDataEventHubName = (string) content.GetValueForProperty("MetaDataEventHubName",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).MetaDataEventHubName, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.DataExportProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DataExportProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).Destination = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDestination) content.GetValueForProperty("Destination",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).Destination, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.DestinationTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).DataExportId = (string) content.GetValueForProperty("DataExportId",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).DataExportId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).TableName = (string[]) content.GetValueForProperty("TableName",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).TableName, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).Enable = (bool?) content.GetValueForProperty("Enable",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).Enable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).CreatedDate = (string) content.GetValueForProperty("CreatedDate",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).CreatedDate, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).LastModifiedDate = (string) content.GetValueForProperty("LastModifiedDate",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).LastModifiedDate, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).DestinationMetaData = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDestinationMetaData) content.GetValueForProperty("DestinationMetaData",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).DestinationMetaData, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.DestinationMetaDataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).DestinationResourceId = (string) content.GetValueForProperty("DestinationResourceId",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).DestinationResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).DestinationType = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.Type?) content.GetValueForProperty("DestinationType",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).DestinationType, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.Type.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).MetaDataEventHubName = (string) content.GetValueForProperty("MetaDataEventHubName",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)this).MetaDataEventHubName, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.DataExportProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DataExportProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.DataExportProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DataExportProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DataExportProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Data Export properties.
    [System.ComponentModel.TypeConverter(typeof(DataExportPropertiesTypeConverter))]
    public partial interface IDataExportProperties

    {

    }
}