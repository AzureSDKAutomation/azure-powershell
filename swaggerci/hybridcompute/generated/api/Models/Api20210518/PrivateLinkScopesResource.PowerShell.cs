namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518
{
    using Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.PowerShell;

    /// <summary>An azure resource object</summary>
    [System.ComponentModel.TypeConverter(typeof(PrivateLinkScopesResourceTypeConverter))]
    public partial class PrivateLinkScopesResource
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.PrivateLinkScopesResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IPrivateLinkScopesResource"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IPrivateLinkScopesResource DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PrivateLinkScopesResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.PrivateLinkScopesResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IPrivateLinkScopesResource"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IPrivateLinkScopesResource DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new PrivateLinkScopesResource(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PrivateLinkScopesResource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IPrivateLinkScopesResource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.PrivateLinkScopesResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PrivateLinkScopesResource(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IPrivateLinkScopesResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IPrivateLinkScopesResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IPrivateLinkScopesResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IPrivateLinkScopesResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IPrivateLinkScopesResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IPrivateLinkScopesResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IPrivateLinkScopesResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IPrivateLinkScopesResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IPrivateLinkScopesResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IPrivateLinkScopesResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IPrivateLinkScopesResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.PrivateLinkScopesResourceTagsTypeConverter.ConvertFrom);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.PrivateLinkScopesResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal PrivateLinkScopesResource(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IPrivateLinkScopesResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IPrivateLinkScopesResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IPrivateLinkScopesResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IPrivateLinkScopesResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IPrivateLinkScopesResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IPrivateLinkScopesResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IPrivateLinkScopesResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IPrivateLinkScopesResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IPrivateLinkScopesResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IPrivateLinkScopesResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IPrivateLinkScopesResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.PrivateLinkScopesResourceTagsTypeConverter.ConvertFrom);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// An azure resource object
    [System.ComponentModel.TypeConverter(typeof(PrivateLinkScopesResourceTypeConverter))]
    public partial interface IPrivateLinkScopesResource

    {

    }
}