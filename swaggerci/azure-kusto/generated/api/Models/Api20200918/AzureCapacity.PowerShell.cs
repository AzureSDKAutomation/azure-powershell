namespace Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200918
{
    using Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.PowerShell;

    /// <summary>Azure capacity definition.</summary>
    [System.ComponentModel.TypeConverter(typeof(AzureCapacityTypeConverter))]
    public partial class AzureCapacity
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200918.AzureCapacity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AzureCapacity(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200918.IAzureCapacityInternal)this).ScaleType = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureScaleType) content.GetValueForProperty("ScaleType",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200918.IAzureCapacityInternal)this).ScaleType, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureScaleType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200918.IAzureCapacityInternal)this).Minimum = (int) content.GetValueForProperty("Minimum",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200918.IAzureCapacityInternal)this).Minimum, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200918.IAzureCapacityInternal)this).Maximum = (int) content.GetValueForProperty("Maximum",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200918.IAzureCapacityInternal)this).Maximum, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200918.IAzureCapacityInternal)this).Default = (int) content.GetValueForProperty("Default",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200918.IAzureCapacityInternal)this).Default, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200918.AzureCapacity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AzureCapacity(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200918.IAzureCapacityInternal)this).ScaleType = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureScaleType) content.GetValueForProperty("ScaleType",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200918.IAzureCapacityInternal)this).ScaleType, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureScaleType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200918.IAzureCapacityInternal)this).Minimum = (int) content.GetValueForProperty("Minimum",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200918.IAzureCapacityInternal)this).Minimum, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200918.IAzureCapacityInternal)this).Maximum = (int) content.GetValueForProperty("Maximum",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200918.IAzureCapacityInternal)this).Maximum, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200918.IAzureCapacityInternal)this).Default = (int) content.GetValueForProperty("Default",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200918.IAzureCapacityInternal)this).Default, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200918.AzureCapacity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200918.IAzureCapacity" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200918.IAzureCapacity DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AzureCapacity(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200918.AzureCapacity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200918.IAzureCapacity" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200918.IAzureCapacity DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AzureCapacity(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AzureCapacity" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200918.IAzureCapacity FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Azure capacity definition.
    [System.ComponentModel.TypeConverter(typeof(AzureCapacityTypeConverter))]
    public partial interface IAzureCapacity

    {

    }
}