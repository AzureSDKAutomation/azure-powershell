namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621
{
    using Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(ConnectionDetailTypeConverter))]
    public partial class ConnectionDetail
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.ConnectionDetail"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ConnectionDetail(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IConnectionDetailInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IConnectionDetailInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IConnectionDetailInternal)this).PrivateIPAddress = (string) content.GetValueForProperty("PrivateIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IConnectionDetailInternal)this).PrivateIPAddress, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IConnectionDetailInternal)this).LinkIdentifier = (string) content.GetValueForProperty("LinkIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IConnectionDetailInternal)this).LinkIdentifier, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IConnectionDetailInternal)this).GroupId = (string) content.GetValueForProperty("GroupId",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IConnectionDetailInternal)this).GroupId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IConnectionDetailInternal)this).MemberName = (string) content.GetValueForProperty("MemberName",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IConnectionDetailInternal)this).MemberName, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.ConnectionDetail"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ConnectionDetail(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IConnectionDetailInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IConnectionDetailInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IConnectionDetailInternal)this).PrivateIPAddress = (string) content.GetValueForProperty("PrivateIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IConnectionDetailInternal)this).PrivateIPAddress, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IConnectionDetailInternal)this).LinkIdentifier = (string) content.GetValueForProperty("LinkIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IConnectionDetailInternal)this).LinkIdentifier, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IConnectionDetailInternal)this).GroupId = (string) content.GetValueForProperty("GroupId",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IConnectionDetailInternal)this).GroupId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IConnectionDetailInternal)this).MemberName = (string) content.GetValueForProperty("MemberName",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IConnectionDetailInternal)this).MemberName, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.ConnectionDetail"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IConnectionDetail" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IConnectionDetail DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ConnectionDetail(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.ConnectionDetail"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IConnectionDetail" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IConnectionDetail DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ConnectionDetail(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ConnectionDetail" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IConnectionDetail FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(ConnectionDetailTypeConverter))]
    public partial interface IConnectionDetail

    {

    }
}