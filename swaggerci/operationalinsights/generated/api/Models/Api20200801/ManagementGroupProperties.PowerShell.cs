namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.PowerShell;

    /// <summary>Management group properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(ManagementGroupPropertiesTypeConverter))]
    public partial class ManagementGroupProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ManagementGroupProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ManagementGroupProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ManagementGroupProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ManagementGroupProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ManagementGroupProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ManagementGroupProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ManagementGroupProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)this).ServerCount = (int?) content.GetValueForProperty("ServerCount",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)this).ServerCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)this).IsGateway = (bool?) content.GetValueForProperty("IsGateway",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)this).IsGateway, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)this).Created = (global::System.DateTime?) content.GetValueForProperty("Created",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)this).Created, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)this).DataReceived = (global::System.DateTime?) content.GetValueForProperty("DataReceived",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)this).DataReceived, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)this).Version, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)this).Sku = (string) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)this).Sku, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ManagementGroupProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ManagementGroupProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)this).ServerCount = (int?) content.GetValueForProperty("ServerCount",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)this).ServerCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)this).IsGateway = (bool?) content.GetValueForProperty("IsGateway",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)this).IsGateway, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)this).Created = (global::System.DateTime?) content.GetValueForProperty("Created",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)this).Created, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)this).DataReceived = (global::System.DateTime?) content.GetValueForProperty("DataReceived",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)this).DataReceived, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)this).Version, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)this).Sku = (string) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)this).Sku, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Management group properties.
    [System.ComponentModel.TypeConverter(typeof(ManagementGroupPropertiesTypeConverter))]
    public partial interface IManagementGroupProperties

    {

    }
}