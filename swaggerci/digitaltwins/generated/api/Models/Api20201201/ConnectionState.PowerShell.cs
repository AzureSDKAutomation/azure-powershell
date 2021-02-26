namespace Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201
{
    using Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.PowerShell;

    /// <summary>The current state of a private endpoint connection.</summary>
    [System.ComponentModel.TypeConverter(typeof(ConnectionStateTypeConverter))]
    public partial class ConnectionState
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.ConnectionState"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ConnectionState(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionStateInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.PrivateLinkServiceConnectionStatus) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionStateInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.PrivateLinkServiceConnectionStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionStateInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionStateInternal)this).Description, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionStateInternal)this).ActionsRequired = (string) content.GetValueForProperty("ActionsRequired",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionStateInternal)this).ActionsRequired, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.ConnectionState"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ConnectionState(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionStateInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.PrivateLinkServiceConnectionStatus) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionStateInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.PrivateLinkServiceConnectionStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionStateInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionStateInternal)this).Description, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionStateInternal)this).ActionsRequired = (string) content.GetValueForProperty("ActionsRequired",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionStateInternal)this).ActionsRequired, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.ConnectionState"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionState" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionState DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ConnectionState(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.ConnectionState"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionState" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionState DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ConnectionState(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ConnectionState" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IConnectionState FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The current state of a private endpoint connection.
    [System.ComponentModel.TypeConverter(typeof(ConnectionStateTypeConverter))]
    public partial interface IConnectionState

    {

    }
}