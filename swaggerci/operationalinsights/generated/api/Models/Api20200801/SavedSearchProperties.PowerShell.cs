namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.PowerShell;

    /// <summary>Value object for saved search results.</summary>
    [System.ComponentModel.TypeConverter(typeof(SavedSearchPropertiesTypeConverter))]
    public partial class SavedSearchProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.SavedSearchProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SavedSearchProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.SavedSearchProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SavedSearchProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SavedSearchProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.SavedSearchProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SavedSearchProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchPropertiesInternal)this).Category = (string) content.GetValueForProperty("Category",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchPropertiesInternal)this).Category, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchPropertiesInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchPropertiesInternal)this).DisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchPropertiesInternal)this).Query = (string) content.GetValueForProperty("Query",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchPropertiesInternal)this).Query, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchPropertiesInternal)this).FunctionAlias = (string) content.GetValueForProperty("FunctionAlias",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchPropertiesInternal)this).FunctionAlias, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchPropertiesInternal)this).FunctionParameter = (string) content.GetValueForProperty("FunctionParameter",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchPropertiesInternal)this).FunctionParameter, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchPropertiesInternal)this).Version = (long?) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchPropertiesInternal)this).Version, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchPropertiesInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ITag[]) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchPropertiesInternal)this).Tag, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ITag>(__y, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.TagTypeConverter.ConvertFrom));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.SavedSearchProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SavedSearchProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchPropertiesInternal)this).Category = (string) content.GetValueForProperty("Category",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchPropertiesInternal)this).Category, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchPropertiesInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchPropertiesInternal)this).DisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchPropertiesInternal)this).Query = (string) content.GetValueForProperty("Query",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchPropertiesInternal)this).Query, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchPropertiesInternal)this).FunctionAlias = (string) content.GetValueForProperty("FunctionAlias",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchPropertiesInternal)this).FunctionAlias, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchPropertiesInternal)this).FunctionParameter = (string) content.GetValueForProperty("FunctionParameter",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchPropertiesInternal)this).FunctionParameter, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchPropertiesInternal)this).Version = (long?) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchPropertiesInternal)this).Version, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchPropertiesInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ITag[]) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchPropertiesInternal)this).Tag, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ITag>(__y, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.TagTypeConverter.ConvertFrom));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Value object for saved search results.
    [System.ComponentModel.TypeConverter(typeof(SavedSearchPropertiesTypeConverter))]
    public partial interface ISavedSearchProperties

    {

    }
}