namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.PowerShell;

    /// <summary>The top level storage insight resource container.</summary>
    [System.ComponentModel.TypeConverter(typeof(StorageInsightTypeConverter))]
    public partial class StorageInsight
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.StorageInsight"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsight" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsight DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new StorageInsight(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.StorageInsight"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsight" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsight DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new StorageInsight(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="StorageInsight" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsight FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.StorageInsight"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal StorageInsight(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.StorageInsightPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).ETag = (string) content.GetValueForProperty("ETag",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).ETag, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.StorageInsightTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).StorageAccount = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageAccount) content.GetValueForProperty("StorageAccount",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).StorageAccount, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.StorageAccountTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightStatus) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.StorageInsightStatusTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).Container = (string[]) content.GetValueForProperty("Container",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).Container, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).Table = (string[]) content.GetValueForProperty("Table",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).Table, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).StorageAccountId = (string) content.GetValueForProperty("StorageAccountId",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).StorageAccountId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).StorageAccountKey = (string) content.GetValueForProperty("StorageAccountKey",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).StorageAccountKey, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).StatusState = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.StorageInsightState) content.GetValueForProperty("StatusState",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).StatusState, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.StorageInsightState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).StatusDescription = (string) content.GetValueForProperty("StatusDescription",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).StatusDescription, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.StorageInsight"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal StorageInsight(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.StorageInsightPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).ETag = (string) content.GetValueForProperty("ETag",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).ETag, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.StorageInsightTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).StorageAccount = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageAccount) content.GetValueForProperty("StorageAccount",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).StorageAccount, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.StorageAccountTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightStatus) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.StorageInsightStatusTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).Container = (string[]) content.GetValueForProperty("Container",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).Container, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).Table = (string[]) content.GetValueForProperty("Table",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).Table, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).StorageAccountId = (string) content.GetValueForProperty("StorageAccountId",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).StorageAccountId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).StorageAccountKey = (string) content.GetValueForProperty("StorageAccountKey",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).StorageAccountKey, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).StatusState = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.StorageInsightState) content.GetValueForProperty("StatusState",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).StatusState, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.StorageInsightState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).StatusDescription = (string) content.GetValueForProperty("StatusDescription",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightInternal)this).StatusDescription, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The top level storage insight resource container.
    [System.ComponentModel.TypeConverter(typeof(StorageInsightTypeConverter))]
    public partial interface IStorageInsight

    {

    }
}