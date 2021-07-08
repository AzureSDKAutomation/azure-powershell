namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.PowerShell;

    /// <summary>Metadata for search results.</summary>
    [System.ComponentModel.TypeConverter(typeof(SearchMetadataTypeConverter))]
    public partial class SearchMetadata
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.SearchMetadata"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadata" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadata DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SearchMetadata(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.SearchMetadata"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadata" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadata DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SearchMetadata(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SearchMetadata" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadata FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.SearchMetadata"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SearchMetadata(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).Schema = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataSchema) content.GetValueForProperty("Schema",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).Schema, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.SearchMetadataSchemaTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).SearchId = (string) content.GetValueForProperty("SearchId",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).SearchId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).ResultType = (string) content.GetValueForProperty("ResultType",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).ResultType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).Total = (long?) content.GetValueForProperty("Total",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).Total, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).Top = (long?) content.GetValueForProperty("Top",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).Top, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).CoreSummary = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ICoreSummary[]) content.GetValueForProperty("CoreSummary",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).CoreSummary, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ICoreSummary>(__y, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.CoreSummaryTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).Status, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).StartTime = (global::System.DateTime?) content.GetValueForProperty("StartTime",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).StartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).LastUpdated = (global::System.DateTime?) content.GetValueForProperty("LastUpdated",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).LastUpdated, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).ETag = (string) content.GetValueForProperty("ETag",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).ETag, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).Sort = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSort[]) content.GetValueForProperty("Sort",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).Sort, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSort>(__y, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.SearchSortTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).RequestTime = (long?) content.GetValueForProperty("RequestTime",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).RequestTime, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).AggregatedValueField = (string) content.GetValueForProperty("AggregatedValueField",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).AggregatedValueField, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).AggregatedGroupingField = (string) content.GetValueForProperty("AggregatedGroupingField",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).AggregatedGroupingField, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).Sum = (long?) content.GetValueForProperty("Sum",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).Sum, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).Max = (long?) content.GetValueForProperty("Max",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).Max, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).SchemaName = (string) content.GetValueForProperty("SchemaName",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).SchemaName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).SchemaVersion = (int?) content.GetValueForProperty("SchemaVersion",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).SchemaVersion, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.SearchMetadata"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SearchMetadata(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).Schema = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataSchema) content.GetValueForProperty("Schema",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).Schema, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.SearchMetadataSchemaTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).SearchId = (string) content.GetValueForProperty("SearchId",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).SearchId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).ResultType = (string) content.GetValueForProperty("ResultType",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).ResultType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).Total = (long?) content.GetValueForProperty("Total",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).Total, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).Top = (long?) content.GetValueForProperty("Top",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).Top, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).CoreSummary = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ICoreSummary[]) content.GetValueForProperty("CoreSummary",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).CoreSummary, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ICoreSummary>(__y, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.CoreSummaryTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).Status, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).StartTime = (global::System.DateTime?) content.GetValueForProperty("StartTime",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).StartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).LastUpdated = (global::System.DateTime?) content.GetValueForProperty("LastUpdated",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).LastUpdated, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).ETag = (string) content.GetValueForProperty("ETag",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).ETag, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).Sort = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSort[]) content.GetValueForProperty("Sort",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).Sort, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSort>(__y, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.SearchSortTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).RequestTime = (long?) content.GetValueForProperty("RequestTime",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).RequestTime, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).AggregatedValueField = (string) content.GetValueForProperty("AggregatedValueField",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).AggregatedValueField, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).AggregatedGroupingField = (string) content.GetValueForProperty("AggregatedGroupingField",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).AggregatedGroupingField, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).Sum = (long?) content.GetValueForProperty("Sum",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).Sum, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).Max = (long?) content.GetValueForProperty("Max",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).Max, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).SchemaName = (string) content.GetValueForProperty("SchemaName",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).SchemaName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).SchemaVersion = (int?) content.GetValueForProperty("SchemaVersion",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)this).SchemaVersion, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Metadata for search results.
    [System.ComponentModel.TypeConverter(typeof(SearchMetadataTypeConverter))]
    public partial interface ISearchMetadata

    {

    }
}