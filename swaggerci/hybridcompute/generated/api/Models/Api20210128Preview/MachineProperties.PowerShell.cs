namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.PowerShell;

    /// <summary>Describes the properties of a hybrid machine.</summary>
    [System.ComponentModel.TypeConverter(typeof(MachinePropertiesTypeConverter))]
    public partial class MachineProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.MachineProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MachineProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.MachineProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MachineProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MachineProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.MachineProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MachineProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).LocationData = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ILocationData) content.GetValueForProperty("LocationData",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).LocationData, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.LocationDataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).OSProfile = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IOSProfile) content.GetValueForProperty("OSProfile",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).OSProfile, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.OSProfileTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.StatusTypes?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.StatusTypes.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).LastStatusChange = (global::System.DateTime?) content.GetValueForProperty("LastStatusChange",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).LastStatusChange, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).ErrorDetail = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20.IErrorDetail[]) content.GetValueForProperty("ErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).ErrorDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20.IErrorDetail>(__y, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20.ErrorDetailTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).AgentVersion = (string) content.GetValueForProperty("AgentVersion",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).AgentVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).VMId = (string) content.GetValueForProperty("VMId",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).VMId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).DisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).MachineFqdn = (string) content.GetValueForProperty("MachineFqdn",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).MachineFqdn, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).ClientPublicKey = (string) content.GetValueForProperty("ClientPublicKey",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).ClientPublicKey, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).OSName = (string) content.GetValueForProperty("OSName",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).OSName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).OSVersion = (string) content.GetValueForProperty("OSVersion",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).OSVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).VMUuid = (string) content.GetValueForProperty("VMUuid",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).VMUuid, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).Extension = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineExtensionInstanceView[]) content.GetValueForProperty("Extension",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).Extension, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineExtensionInstanceView>(__y, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.MachineExtensionInstanceViewTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).OSSku = (string) content.GetValueForProperty("OSSku",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).OSSku, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).DomainName = (string) content.GetValueForProperty("DomainName",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).DomainName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).AdFqdn = (string) content.GetValueForProperty("AdFqdn",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).AdFqdn, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).DnsFqdn = (string) content.GetValueForProperty("DnsFqdn",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).DnsFqdn, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).PrivateLinkScopeResourceId = (string) content.GetValueForProperty("PrivateLinkScopeResourceId",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).PrivateLinkScopeResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).ParentClusterResourceId = (string) content.GetValueForProperty("ParentClusterResourceId",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).ParentClusterResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).DetectedProperty = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IDetectedProperties) content.GetValueForProperty("DetectedProperty",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).DetectedProperty, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.DetectedPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).LocationDataName = (string) content.GetValueForProperty("LocationDataName",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).LocationDataName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).LocationDataCity = (string) content.GetValueForProperty("LocationDataCity",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).LocationDataCity, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).LocationDataDistrict = (string) content.GetValueForProperty("LocationDataDistrict",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).LocationDataDistrict, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).LocationDataCountryOrRegion = (string) content.GetValueForProperty("LocationDataCountryOrRegion",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).LocationDataCountryOrRegion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).OSProfileComputerName = (string) content.GetValueForProperty("OSProfileComputerName",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).OSProfileComputerName, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.MachineProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MachineProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).LocationData = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ILocationData) content.GetValueForProperty("LocationData",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).LocationData, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.LocationDataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).OSProfile = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IOSProfile) content.GetValueForProperty("OSProfile",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).OSProfile, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.OSProfileTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.StatusTypes?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.StatusTypes.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).LastStatusChange = (global::System.DateTime?) content.GetValueForProperty("LastStatusChange",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).LastStatusChange, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).ErrorDetail = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20.IErrorDetail[]) content.GetValueForProperty("ErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).ErrorDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20.IErrorDetail>(__y, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20.ErrorDetailTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).AgentVersion = (string) content.GetValueForProperty("AgentVersion",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).AgentVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).VMId = (string) content.GetValueForProperty("VMId",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).VMId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).DisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).MachineFqdn = (string) content.GetValueForProperty("MachineFqdn",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).MachineFqdn, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).ClientPublicKey = (string) content.GetValueForProperty("ClientPublicKey",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).ClientPublicKey, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).OSName = (string) content.GetValueForProperty("OSName",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).OSName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).OSVersion = (string) content.GetValueForProperty("OSVersion",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).OSVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).VMUuid = (string) content.GetValueForProperty("VMUuid",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).VMUuid, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).Extension = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineExtensionInstanceView[]) content.GetValueForProperty("Extension",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).Extension, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachineExtensionInstanceView>(__y, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.MachineExtensionInstanceViewTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).OSSku = (string) content.GetValueForProperty("OSSku",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).OSSku, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).DomainName = (string) content.GetValueForProperty("DomainName",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).DomainName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).AdFqdn = (string) content.GetValueForProperty("AdFqdn",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).AdFqdn, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).DnsFqdn = (string) content.GetValueForProperty("DnsFqdn",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).DnsFqdn, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).PrivateLinkScopeResourceId = (string) content.GetValueForProperty("PrivateLinkScopeResourceId",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).PrivateLinkScopeResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).ParentClusterResourceId = (string) content.GetValueForProperty("ParentClusterResourceId",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).ParentClusterResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).DetectedProperty = (Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IDetectedProperties) content.GetValueForProperty("DetectedProperty",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).DetectedProperty, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.DetectedPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).LocationDataName = (string) content.GetValueForProperty("LocationDataName",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).LocationDataName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).LocationDataCity = (string) content.GetValueForProperty("LocationDataCity",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).LocationDataCity, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).LocationDataDistrict = (string) content.GetValueForProperty("LocationDataDistrict",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).LocationDataDistrict, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).LocationDataCountryOrRegion = (string) content.GetValueForProperty("LocationDataCountryOrRegion",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).LocationDataCountryOrRegion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).OSProfileComputerName = (string) content.GetValueForProperty("OSProfileComputerName",((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210128Preview.IMachinePropertiesInternal)this).OSProfileComputerName, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Describes the properties of a hybrid machine.
    [System.ComponentModel.TypeConverter(typeof(MachinePropertiesTypeConverter))]
    public partial interface IMachineProperties

    {

    }
}