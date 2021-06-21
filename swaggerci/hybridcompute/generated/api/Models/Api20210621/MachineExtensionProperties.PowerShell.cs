namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621
{
    using Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.PowerShell;

    /// <summary>Describes the properties of a Machine Extension.</summary>
    [System.ComponentModel.TypeConverter(typeof(MachineExtensionPropertiesTypeConverter))]
    public partial class MachineExtensionProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.MachineExtensionProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MachineExtensionProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.MachineExtensionProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MachineExtensionProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MachineExtensionProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.MachineExtensionProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MachineExtensionProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).InstanceView = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionInstanceView) content.GetValueForProperty("InstanceView",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).InstanceView, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.MachineExtensionInstanceViewTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).ForceUpdateTag = (string) content.GetValueForProperty("ForceUpdateTag",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).ForceUpdateTag, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).Publisher = (string) content.GetValueForProperty("Publisher",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).Publisher, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).TypeHandlerVersion = (string) content.GetValueForProperty("TypeHandlerVersion",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).TypeHandlerVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).AutoUpgradeMinorVersion = (bool?) content.GetValueForProperty("AutoUpgradeMinorVersion",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).AutoUpgradeMinorVersion, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).Setting = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.IAny) content.GetValueForProperty("Setting",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).Setting, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.AnyTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).ProtectedSetting = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.IAny) content.GetValueForProperty("ProtectedSetting",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).ProtectedSetting, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.AnyTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).InstanceViewStatus = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionInstanceViewStatus) content.GetValueForProperty("InstanceViewStatus",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).InstanceViewStatus, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.MachineExtensionInstanceViewStatusTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).InstanceViewName = (string) content.GetValueForProperty("InstanceViewName",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).InstanceViewName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).InstanceViewType = (string) content.GetValueForProperty("InstanceViewType",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).InstanceViewType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).InstanceViewTypeHandlerVersion = (string) content.GetValueForProperty("InstanceViewTypeHandlerVersion",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).InstanceViewTypeHandlerVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).StatusCode = (string) content.GetValueForProperty("StatusCode",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).StatusCode, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).StatusLevel = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.StatusLevelTypes?) content.GetValueForProperty("StatusLevel",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).StatusLevel, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.StatusLevelTypes.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).StatusDisplayStatus = (string) content.GetValueForProperty("StatusDisplayStatus",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).StatusDisplayStatus, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).StatusMessage = (string) content.GetValueForProperty("StatusMessage",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).StatusMessage, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).StatusTime = (global::System.DateTime?) content.GetValueForProperty("StatusTime",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).StatusTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.MachineExtensionProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MachineExtensionProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).InstanceView = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionInstanceView) content.GetValueForProperty("InstanceView",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).InstanceView, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.MachineExtensionInstanceViewTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).ForceUpdateTag = (string) content.GetValueForProperty("ForceUpdateTag",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).ForceUpdateTag, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).Publisher = (string) content.GetValueForProperty("Publisher",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).Publisher, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).TypeHandlerVersion = (string) content.GetValueForProperty("TypeHandlerVersion",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).TypeHandlerVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).AutoUpgradeMinorVersion = (bool?) content.GetValueForProperty("AutoUpgradeMinorVersion",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).AutoUpgradeMinorVersion, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).Setting = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.IAny) content.GetValueForProperty("Setting",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).Setting, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.AnyTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).ProtectedSetting = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.IAny) content.GetValueForProperty("ProtectedSetting",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).ProtectedSetting, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.AnyTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).InstanceViewStatus = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionInstanceViewStatus) content.GetValueForProperty("InstanceViewStatus",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).InstanceViewStatus, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.MachineExtensionInstanceViewStatusTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).InstanceViewName = (string) content.GetValueForProperty("InstanceViewName",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).InstanceViewName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).InstanceViewType = (string) content.GetValueForProperty("InstanceViewType",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).InstanceViewType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).InstanceViewTypeHandlerVersion = (string) content.GetValueForProperty("InstanceViewTypeHandlerVersion",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).InstanceViewTypeHandlerVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).StatusCode = (string) content.GetValueForProperty("StatusCode",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).StatusCode, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).StatusLevel = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.StatusLevelTypes?) content.GetValueForProperty("StatusLevel",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).StatusLevel, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.StatusLevelTypes.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).StatusDisplayStatus = (string) content.GetValueForProperty("StatusDisplayStatus",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).StatusDisplayStatus, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).StatusMessage = (string) content.GetValueForProperty("StatusMessage",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).StatusMessage, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).StatusTime = (global::System.DateTime?) content.GetValueForProperty("StatusTime",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IMachineExtensionPropertiesInternal)this).StatusTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Describes the properties of a Machine Extension.
    [System.ComponentModel.TypeConverter(typeof(MachineExtensionPropertiesTypeConverter))]
    public partial interface IMachineExtensionProperties

    {

    }
}