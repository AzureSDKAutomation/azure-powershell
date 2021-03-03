namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.PowerShell;

    /// <summary>NSX DNS Service Properties</summary>
    [System.ComponentModel.TypeConverter(typeof(WorkloadNetworkDnsServicePropertiesTypeConverter))]
    public partial class WorkloadNetworkDnsServiceProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.WorkloadNetworkDnsServiceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServiceProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServiceProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new WorkloadNetworkDnsServiceProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.WorkloadNetworkDnsServiceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServiceProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServiceProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new WorkloadNetworkDnsServiceProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="WorkloadNetworkDnsServiceProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServiceProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.WorkloadNetworkDnsServiceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal WorkloadNetworkDnsServiceProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal)this).DisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal)this).DnsServiceIP = (string) content.GetValueForProperty("DnsServiceIP",((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal)this).DnsServiceIP, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal)this).DefaultDnsZone = (string) content.GetValueForProperty("DefaultDnsZone",((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal)this).DefaultDnsZone, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal)this).FqdnZone = (string[]) content.GetValueForProperty("FqdnZone",((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal)this).FqdnZone, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal)this).LogLevel = (Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DnsServiceLogLevelEnum?) content.GetValueForProperty("LogLevel",((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal)this).LogLevel, Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DnsServiceLogLevelEnum.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DnsServiceStatusEnum?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DnsServiceStatusEnum.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.WorkloadNetworkDnsServiceProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.WorkloadNetworkDnsServiceProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal)this).Revision = (long?) content.GetValueForProperty("Revision",((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal)this).Revision, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.WorkloadNetworkDnsServiceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal WorkloadNetworkDnsServiceProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal)this).DisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal)this).DnsServiceIP = (string) content.GetValueForProperty("DnsServiceIP",((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal)this).DnsServiceIP, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal)this).DefaultDnsZone = (string) content.GetValueForProperty("DefaultDnsZone",((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal)this).DefaultDnsZone, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal)this).FqdnZone = (string[]) content.GetValueForProperty("FqdnZone",((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal)this).FqdnZone, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal)this).LogLevel = (Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DnsServiceLogLevelEnum?) content.GetValueForProperty("LogLevel",((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal)this).LogLevel, Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DnsServiceLogLevelEnum.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DnsServiceStatusEnum?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DnsServiceStatusEnum.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.WorkloadNetworkDnsServiceProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.WorkloadNetworkDnsServiceProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal)this).Revision = (long?) content.GetValueForProperty("Revision",((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkDnsServicePropertiesInternal)this).Revision, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            AfterDeserializePSObject(content);
        }
    }
    /// NSX DNS Service Properties
    [System.ComponentModel.TypeConverter(typeof(WorkloadNetworkDnsServicePropertiesTypeConverter))]
    public partial interface IWorkloadNetworkDnsServiceProperties

    {

    }
}