namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712
{
    using Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.PowerShell;

    /// <summary>Properties of HostPool.</summary>
    [System.ComponentModel.TypeConverter(typeof(HostPoolPropertiesTypeConverter))]
    public partial class HostPoolProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.HostPoolProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new HostPoolProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.HostPoolProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new HostPoolProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="HostPoolProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.HostPoolProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal HostPoolProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).RegistrationInfo = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IRegistrationInfo) content.GetValueForProperty("RegistrationInfo",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).RegistrationInfo, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.RegistrationInfoTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).MigrationRequest = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IMigrationRequestProperties) content.GetValueForProperty("MigrationRequest",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).MigrationRequest, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.MigrationRequestPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).ObjectId = (string) content.GetValueForProperty("ObjectId",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).ObjectId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).FriendlyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).Description, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).HostPoolType = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.HostPoolType) content.GetValueForProperty("HostPoolType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).HostPoolType, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.HostPoolType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).PersonalDesktopAssignmentType = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PersonalDesktopAssignmentType?) content.GetValueForProperty("PersonalDesktopAssignmentType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).PersonalDesktopAssignmentType, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PersonalDesktopAssignmentType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).CustomRdpProperty = (string) content.GetValueForProperty("CustomRdpProperty",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).CustomRdpProperty, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).MaxSessionLimit = (int?) content.GetValueForProperty("MaxSessionLimit",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).MaxSessionLimit, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).LoadBalancerType = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.LoadBalancerType) content.GetValueForProperty("LoadBalancerType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).LoadBalancerType, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.LoadBalancerType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).Ring = (int?) content.GetValueForProperty("Ring",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).Ring, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).ValidationEnvironment = (bool?) content.GetValueForProperty("ValidationEnvironment",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).ValidationEnvironment, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).VMTemplate = (string) content.GetValueForProperty("VMTemplate",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).VMTemplate, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).ApplicationGroupReference = (string[]) content.GetValueForProperty("ApplicationGroupReference",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).ApplicationGroupReference, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).SsoadfsAuthority = (string) content.GetValueForProperty("SsoadfsAuthority",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).SsoadfsAuthority, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).SsoClientId = (string) content.GetValueForProperty("SsoClientId",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).SsoClientId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).SsoClientSecretKeyVaultPath = (string) content.GetValueForProperty("SsoClientSecretKeyVaultPath",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).SsoClientSecretKeyVaultPath, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).SsoSecretType = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SsoSecretType?) content.GetValueForProperty("SsoSecretType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).SsoSecretType, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SsoSecretType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).PreferredAppGroupType = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PreferredAppGroupType) content.GetValueForProperty("PreferredAppGroupType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).PreferredAppGroupType, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PreferredAppGroupType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).StartVMOnConnect = (bool?) content.GetValueForProperty("StartVMOnConnect",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).StartVMOnConnect, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).CloudPcResource = (bool?) content.GetValueForProperty("CloudPcResource",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).CloudPcResource, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).RegistrationInfoExpirationTime = (global::System.DateTime?) content.GetValueForProperty("RegistrationInfoExpirationTime",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).RegistrationInfoExpirationTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).RegistrationInfoToken = (string) content.GetValueForProperty("RegistrationInfoToken",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).RegistrationInfoToken, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).MigrationRequestOperation = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.Operation?) content.GetValueForProperty("MigrationRequestOperation",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).MigrationRequestOperation, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.Operation.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).RegistrationInfoRegistrationTokenOperation = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.RegistrationTokenOperation?) content.GetValueForProperty("RegistrationInfoRegistrationTokenOperation",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).RegistrationInfoRegistrationTokenOperation, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.RegistrationTokenOperation.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).MigrationRequestMigrationPath = (string) content.GetValueForProperty("MigrationRequestMigrationPath",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).MigrationRequestMigrationPath, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.HostPoolProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal HostPoolProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).RegistrationInfo = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IRegistrationInfo) content.GetValueForProperty("RegistrationInfo",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).RegistrationInfo, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.RegistrationInfoTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).MigrationRequest = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IMigrationRequestProperties) content.GetValueForProperty("MigrationRequest",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).MigrationRequest, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.MigrationRequestPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).ObjectId = (string) content.GetValueForProperty("ObjectId",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).ObjectId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).FriendlyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).Description, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).HostPoolType = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.HostPoolType) content.GetValueForProperty("HostPoolType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).HostPoolType, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.HostPoolType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).PersonalDesktopAssignmentType = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PersonalDesktopAssignmentType?) content.GetValueForProperty("PersonalDesktopAssignmentType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).PersonalDesktopAssignmentType, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PersonalDesktopAssignmentType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).CustomRdpProperty = (string) content.GetValueForProperty("CustomRdpProperty",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).CustomRdpProperty, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).MaxSessionLimit = (int?) content.GetValueForProperty("MaxSessionLimit",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).MaxSessionLimit, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).LoadBalancerType = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.LoadBalancerType) content.GetValueForProperty("LoadBalancerType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).LoadBalancerType, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.LoadBalancerType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).Ring = (int?) content.GetValueForProperty("Ring",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).Ring, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).ValidationEnvironment = (bool?) content.GetValueForProperty("ValidationEnvironment",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).ValidationEnvironment, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).VMTemplate = (string) content.GetValueForProperty("VMTemplate",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).VMTemplate, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).ApplicationGroupReference = (string[]) content.GetValueForProperty("ApplicationGroupReference",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).ApplicationGroupReference, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).SsoadfsAuthority = (string) content.GetValueForProperty("SsoadfsAuthority",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).SsoadfsAuthority, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).SsoClientId = (string) content.GetValueForProperty("SsoClientId",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).SsoClientId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).SsoClientSecretKeyVaultPath = (string) content.GetValueForProperty("SsoClientSecretKeyVaultPath",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).SsoClientSecretKeyVaultPath, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).SsoSecretType = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SsoSecretType?) content.GetValueForProperty("SsoSecretType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).SsoSecretType, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SsoSecretType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).PreferredAppGroupType = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PreferredAppGroupType) content.GetValueForProperty("PreferredAppGroupType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).PreferredAppGroupType, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PreferredAppGroupType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).StartVMOnConnect = (bool?) content.GetValueForProperty("StartVMOnConnect",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).StartVMOnConnect, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).CloudPcResource = (bool?) content.GetValueForProperty("CloudPcResource",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).CloudPcResource, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).RegistrationInfoExpirationTime = (global::System.DateTime?) content.GetValueForProperty("RegistrationInfoExpirationTime",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).RegistrationInfoExpirationTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).RegistrationInfoToken = (string) content.GetValueForProperty("RegistrationInfoToken",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).RegistrationInfoToken, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).MigrationRequestOperation = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.Operation?) content.GetValueForProperty("MigrationRequestOperation",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).MigrationRequestOperation, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.Operation.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).RegistrationInfoRegistrationTokenOperation = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.RegistrationTokenOperation?) content.GetValueForProperty("RegistrationInfoRegistrationTokenOperation",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).RegistrationInfoRegistrationTokenOperation, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.RegistrationTokenOperation.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).MigrationRequestMigrationPath = (string) content.GetValueForProperty("MigrationRequestMigrationPath",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IHostPoolPropertiesInternal)this).MigrationRequestMigrationPath, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Properties of HostPool.
    [System.ComponentModel.TypeConverter(typeof(HostPoolPropertiesTypeConverter))]
    public partial interface IHostPoolProperties

    {

    }
}