namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.PowerShell;

    /// <summary>Service Tier details.</summary>
    [System.ComponentModel.TypeConverter(typeof(AvailableServiceTierTypeConverter))]
    public partial class AvailableServiceTier
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.AvailableServiceTier"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AvailableServiceTier(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal)this).ServiceTier = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.SkuNameEnum?) content.GetValueForProperty("ServiceTier",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal)this).ServiceTier, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.SkuNameEnum.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal)this).Enabled = (bool?) content.GetValueForProperty("Enabled",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal)this).Enabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal)this).MinimumRetention = (long?) content.GetValueForProperty("MinimumRetention",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal)this).MinimumRetention, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal)this).MaximumRetention = (long?) content.GetValueForProperty("MaximumRetention",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal)this).MaximumRetention, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal)this).DefaultRetention = (long?) content.GetValueForProperty("DefaultRetention",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal)this).DefaultRetention, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal)this).CapacityReservationLevel = (long?) content.GetValueForProperty("CapacityReservationLevel",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal)this).CapacityReservationLevel, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal)this).LastSkuUpdate = (string) content.GetValueForProperty("LastSkuUpdate",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal)this).LastSkuUpdate, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.AvailableServiceTier"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AvailableServiceTier(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal)this).ServiceTier = (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.SkuNameEnum?) content.GetValueForProperty("ServiceTier",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal)this).ServiceTier, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.SkuNameEnum.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal)this).Enabled = (bool?) content.GetValueForProperty("Enabled",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal)this).Enabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal)this).MinimumRetention = (long?) content.GetValueForProperty("MinimumRetention",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal)this).MinimumRetention, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal)this).MaximumRetention = (long?) content.GetValueForProperty("MaximumRetention",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal)this).MaximumRetention, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal)this).DefaultRetention = (long?) content.GetValueForProperty("DefaultRetention",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal)this).DefaultRetention, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal)this).CapacityReservationLevel = (long?) content.GetValueForProperty("CapacityReservationLevel",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal)this).CapacityReservationLevel, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal)this).LastSkuUpdate = (string) content.GetValueForProperty("LastSkuUpdate",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal)this).LastSkuUpdate, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.AvailableServiceTier"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTier"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTier DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AvailableServiceTier(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.AvailableServiceTier"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTier"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTier DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AvailableServiceTier(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AvailableServiceTier" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTier FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Service Tier details.
    [System.ComponentModel.TypeConverter(typeof(AvailableServiceTierTypeConverter))]
    public partial interface IAvailableServiceTier

    {

    }
}