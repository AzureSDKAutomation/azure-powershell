namespace Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.PowerShell;

    /// <summary>
    /// Parameters supplied to the Create or Update Environment operation for a Gen1 environment.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(Gen1EnvironmentCreateOrUpdateParametersTypeConverter))]
    public partial class Gen1EnvironmentCreateOrUpdateParameters
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.Gen1EnvironmentCreateOrUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IGen1EnvironmentCreateOrUpdateParameters"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IGen1EnvironmentCreateOrUpdateParameters DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Gen1EnvironmentCreateOrUpdateParameters(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.Gen1EnvironmentCreateOrUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IGen1EnvironmentCreateOrUpdateParameters"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IGen1EnvironmentCreateOrUpdateParameters DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Gen1EnvironmentCreateOrUpdateParameters(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Gen1EnvironmentCreateOrUpdateParameters" />, deserializing the content from a json
        /// string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IGen1EnvironmentCreateOrUpdateParameters FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.Gen1EnvironmentCreateOrUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Gen1EnvironmentCreateOrUpdateParameters(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IGen1EnvironmentCreateOrUpdateParametersInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IGen1EnvironmentCreationProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IGen1EnvironmentCreateOrUpdateParametersInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.Gen1EnvironmentCreationPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ICreateOrUpdateTrackedResourcePropertiesInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ICreateOrUpdateTrackedResourcePropertiesInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ICreateOrUpdateTrackedResourcePropertiesInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ICreateOrUpdateTrackedResourcePropertiesTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ICreateOrUpdateTrackedResourcePropertiesInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.CreateOrUpdateTrackedResourcePropertiesTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentCreateOrUpdateParametersInternal)this).SkuName = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.SkuName) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentCreateOrUpdateParametersInternal)this).SkuName, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.SkuName.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentCreateOrUpdateParametersInternal)this).SkuCapacity = (int) content.GetValueForProperty("SkuCapacity",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentCreateOrUpdateParametersInternal)this).SkuCapacity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentCreateOrUpdateParametersInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ISku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentCreateOrUpdateParametersInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.SkuTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentCreateOrUpdateParametersInternal)this).Kind = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.EnvironmentKind) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentCreateOrUpdateParametersInternal)this).Kind, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.EnvironmentKind.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IGen1EnvironmentCreateOrUpdateParametersInternal)this).DataRetentionTime = (global::System.TimeSpan) content.GetValueForProperty("DataRetentionTime",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IGen1EnvironmentCreateOrUpdateParametersInternal)this).DataRetentionTime, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IGen1EnvironmentCreateOrUpdateParametersInternal)this).StorageLimitExceededBehavior = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.StorageLimitExceededBehavior?) content.GetValueForProperty("StorageLimitExceededBehavior",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IGen1EnvironmentCreateOrUpdateParametersInternal)this).StorageLimitExceededBehavior, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.StorageLimitExceededBehavior.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IGen1EnvironmentCreateOrUpdateParametersInternal)this).PartitionKeyProperty = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ITimeSeriesIdProperty[]) content.GetValueForProperty("PartitionKeyProperty",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IGen1EnvironmentCreateOrUpdateParametersInternal)this).PartitionKeyProperty, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ITimeSeriesIdProperty>(__y, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.TimeSeriesIdPropertyTypeConverter.ConvertFrom));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.Gen1EnvironmentCreateOrUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Gen1EnvironmentCreateOrUpdateParameters(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IGen1EnvironmentCreateOrUpdateParametersInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IGen1EnvironmentCreationProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IGen1EnvironmentCreateOrUpdateParametersInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.Gen1EnvironmentCreationPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ICreateOrUpdateTrackedResourcePropertiesInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ICreateOrUpdateTrackedResourcePropertiesInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ICreateOrUpdateTrackedResourcePropertiesInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ICreateOrUpdateTrackedResourcePropertiesTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ICreateOrUpdateTrackedResourcePropertiesInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.CreateOrUpdateTrackedResourcePropertiesTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentCreateOrUpdateParametersInternal)this).SkuName = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.SkuName) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentCreateOrUpdateParametersInternal)this).SkuName, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.SkuName.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentCreateOrUpdateParametersInternal)this).SkuCapacity = (int) content.GetValueForProperty("SkuCapacity",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentCreateOrUpdateParametersInternal)this).SkuCapacity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentCreateOrUpdateParametersInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ISku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentCreateOrUpdateParametersInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.SkuTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentCreateOrUpdateParametersInternal)this).Kind = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.EnvironmentKind) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IEnvironmentCreateOrUpdateParametersInternal)this).Kind, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.EnvironmentKind.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IGen1EnvironmentCreateOrUpdateParametersInternal)this).DataRetentionTime = (global::System.TimeSpan) content.GetValueForProperty("DataRetentionTime",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IGen1EnvironmentCreateOrUpdateParametersInternal)this).DataRetentionTime, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IGen1EnvironmentCreateOrUpdateParametersInternal)this).StorageLimitExceededBehavior = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.StorageLimitExceededBehavior?) content.GetValueForProperty("StorageLimitExceededBehavior",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IGen1EnvironmentCreateOrUpdateParametersInternal)this).StorageLimitExceededBehavior, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.StorageLimitExceededBehavior.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IGen1EnvironmentCreateOrUpdateParametersInternal)this).PartitionKeyProperty = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ITimeSeriesIdProperty[]) content.GetValueForProperty("PartitionKeyProperty",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IGen1EnvironmentCreateOrUpdateParametersInternal)this).PartitionKeyProperty, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.ITimeSeriesIdProperty>(__y, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.TimeSeriesIdPropertyTypeConverter.ConvertFrom));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Parameters supplied to the Create or Update Environment operation for a Gen1 environment.
    [System.ComponentModel.TypeConverter(typeof(Gen1EnvironmentCreateOrUpdateParametersTypeConverter))]
    public partial interface IGen1EnvironmentCreateOrUpdateParameters

    {

    }
}