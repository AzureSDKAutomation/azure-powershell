namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.PowerShell;

    /// <summary>Value object for schema results.</summary>
    [System.ComponentModel.TypeConverter(typeof(SearchSchemaValueTypeConverter))]
    public partial class SearchSchemaValue
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.SearchSchemaValue"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValue"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValue DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SearchSchemaValue(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.SearchSchemaValue"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValue"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValue DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SearchSchemaValue(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SearchSchemaValue" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValue FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.SearchSchemaValue"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SearchSchemaValue(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValueInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValueInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValueInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValueInternal)this).DisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValueInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValueInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValueInternal)this).Indexed = (bool) content.GetValueForProperty("Indexed",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValueInternal)this).Indexed, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValueInternal)this).Stored = (bool) content.GetValueForProperty("Stored",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValueInternal)this).Stored, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValueInternal)this).Facet = (bool) content.GetValueForProperty("Facet",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValueInternal)this).Facet, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValueInternal)this).OwnerType = (string[]) content.GetValueForProperty("OwnerType",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValueInternal)this).OwnerType, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.SearchSchemaValue"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SearchSchemaValue(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValueInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValueInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValueInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValueInternal)this).DisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValueInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValueInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValueInternal)this).Indexed = (bool) content.GetValueForProperty("Indexed",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValueInternal)this).Indexed, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValueInternal)this).Stored = (bool) content.GetValueForProperty("Stored",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValueInternal)this).Stored, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValueInternal)this).Facet = (bool) content.GetValueForProperty("Facet",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValueInternal)this).Facet, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValueInternal)this).OwnerType = (string[]) content.GetValueForProperty("OwnerType",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValueInternal)this).OwnerType, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Value object for schema results.
    [System.ComponentModel.TypeConverter(typeof(SearchSchemaValueTypeConverter))]
    public partial interface ISearchSchemaValue

    {

    }
}