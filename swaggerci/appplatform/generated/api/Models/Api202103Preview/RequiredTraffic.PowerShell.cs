namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.PowerShell;

    /// <summary>Required inbound or outbound traffic for Azure Spring Cloud instance.</summary>
    [System.ComponentModel.TypeConverter(typeof(RequiredTrafficTypeConverter))]
    public partial class RequiredTraffic
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.RequiredTraffic"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IRequiredTraffic" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IRequiredTraffic DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new RequiredTraffic(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.RequiredTraffic"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IRequiredTraffic" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IRequiredTraffic DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new RequiredTraffic(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="RequiredTraffic" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IRequiredTraffic FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.RequiredTraffic"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal RequiredTraffic(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IRequiredTrafficInternal)this).Protocol = (string) content.GetValueForProperty("Protocol",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IRequiredTrafficInternal)this).Protocol, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IRequiredTrafficInternal)this).Port = (int?) content.GetValueForProperty("Port",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IRequiredTrafficInternal)this).Port, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IRequiredTrafficInternal)this).IP = (string[]) content.GetValueForProperty("IP",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IRequiredTrafficInternal)this).IP, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IRequiredTrafficInternal)this).Fqdn = (string[]) content.GetValueForProperty("Fqdn",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IRequiredTrafficInternal)this).Fqdn, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IRequiredTrafficInternal)this).Direction = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.TrafficDirection?) content.GetValueForProperty("Direction",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IRequiredTrafficInternal)this).Direction, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.TrafficDirection.CreateFrom);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.RequiredTraffic"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal RequiredTraffic(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IRequiredTrafficInternal)this).Protocol = (string) content.GetValueForProperty("Protocol",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IRequiredTrafficInternal)this).Protocol, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IRequiredTrafficInternal)this).Port = (int?) content.GetValueForProperty("Port",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IRequiredTrafficInternal)this).Port, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IRequiredTrafficInternal)this).IP = (string[]) content.GetValueForProperty("IP",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IRequiredTrafficInternal)this).IP, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IRequiredTrafficInternal)this).Fqdn = (string[]) content.GetValueForProperty("Fqdn",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IRequiredTrafficInternal)this).Fqdn, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IRequiredTrafficInternal)this).Direction = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.TrafficDirection?) content.GetValueForProperty("Direction",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IRequiredTrafficInternal)this).Direction, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.TrafficDirection.CreateFrom);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Required inbound or outbound traffic for Azure Spring Cloud instance.
    [System.ComponentModel.TypeConverter(typeof(RequiredTrafficTypeConverter))]
    public partial interface IRequiredTraffic

    {

    }
}