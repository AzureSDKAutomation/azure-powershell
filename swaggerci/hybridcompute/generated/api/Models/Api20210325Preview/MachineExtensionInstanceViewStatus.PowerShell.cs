namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.PowerShell;

    /// <summary>Instance view status.</summary>
    [System.ComponentModel.TypeConverter(typeof(MachineExtensionInstanceViewStatusTypeConverter))]
    public partial class MachineExtensionInstanceViewStatus
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.MachineExtensionInstanceViewStatus"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineExtensionInstanceViewStatus"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineExtensionInstanceViewStatus DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MachineExtensionInstanceViewStatus(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.MachineExtensionInstanceViewStatus"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineExtensionInstanceViewStatus"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineExtensionInstanceViewStatus DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MachineExtensionInstanceViewStatus(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MachineExtensionInstanceViewStatus" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineExtensionInstanceViewStatus FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.MachineExtensionInstanceViewStatus"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MachineExtensionInstanceViewStatus(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineExtensionInstanceViewStatusInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineExtensionInstanceViewStatusInternal)this).Code, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineExtensionInstanceViewStatusInternal)this).Level = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.StatusLevelTypes?) content.GetValueForProperty("Level",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineExtensionInstanceViewStatusInternal)this).Level, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.StatusLevelTypes.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineExtensionInstanceViewStatusInternal)this).DisplayStatus = (string) content.GetValueForProperty("DisplayStatus",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineExtensionInstanceViewStatusInternal)this).DisplayStatus, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineExtensionInstanceViewStatusInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineExtensionInstanceViewStatusInternal)this).Message, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineExtensionInstanceViewStatusInternal)this).Time = (global::System.DateTime?) content.GetValueForProperty("Time",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineExtensionInstanceViewStatusInternal)this).Time, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.MachineExtensionInstanceViewStatus"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MachineExtensionInstanceViewStatus(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineExtensionInstanceViewStatusInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineExtensionInstanceViewStatusInternal)this).Code, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineExtensionInstanceViewStatusInternal)this).Level = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.StatusLevelTypes?) content.GetValueForProperty("Level",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineExtensionInstanceViewStatusInternal)this).Level, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.StatusLevelTypes.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineExtensionInstanceViewStatusInternal)this).DisplayStatus = (string) content.GetValueForProperty("DisplayStatus",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineExtensionInstanceViewStatusInternal)this).DisplayStatus, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineExtensionInstanceViewStatusInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineExtensionInstanceViewStatusInternal)this).Message, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineExtensionInstanceViewStatusInternal)this).Time = (global::System.DateTime?) content.GetValueForProperty("Time",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineExtensionInstanceViewStatusInternal)this).Time, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Instance view status.
    [System.ComponentModel.TypeConverter(typeof(MachineExtensionInstanceViewStatusTypeConverter))]
    public partial interface IMachineExtensionInstanceViewStatus

    {

    }
}