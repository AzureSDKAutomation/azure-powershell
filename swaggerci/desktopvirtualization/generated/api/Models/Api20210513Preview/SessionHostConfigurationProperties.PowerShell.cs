namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.PowerShell;

    /// <summary>Session host configurations of HostPool.</summary>
    [System.ComponentModel.TypeConverter(typeof(SessionHostConfigurationPropertiesTypeConverter))]
    public partial class SessionHostConfigurationProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.SessionHostConfigurationProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SessionHostConfigurationProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.SessionHostConfigurationProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SessionHostConfigurationProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SessionHostConfigurationProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.SessionHostConfigurationProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SessionHostConfigurationProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).ImageInfo = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IImageInfoProperties) content.GetValueForProperty("ImageInfo",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).ImageInfo, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ImageInfoPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DomainInfo = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoProperties) content.GetValueForProperty("DomainInfo",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DomainInfo, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.DomainInfoPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).Version = (global::System.DateTime?) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).Version, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).VMSizeId = (string) content.GetValueForProperty("VMSizeId",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).VMSizeId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DiskType = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.VirtualMachineDiskType?) content.GetValueForProperty("DiskType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DiskType, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.VirtualMachineDiskType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).VMCustomConfigurationUri = (string) content.GetValueForProperty("VMCustomConfigurationUri",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).VMCustomConfigurationUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).ImageInfoMarketPlaceInfo = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMarketPlaceInfoProperties) content.GetValueForProperty("ImageInfoMarketPlaceInfo",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).ImageInfoMarketPlaceInfo, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.MarketPlaceInfoPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).ImageInfoType = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ImageType?) content.GetValueForProperty("ImageInfoType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).ImageInfoType, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ImageType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).ImageInfoStorageBlobUri = (string) content.GetValueForProperty("ImageInfoStorageBlobUri",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).ImageInfoStorageBlobUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).ImageInfoCustomId = (string) content.GetValueForProperty("ImageInfoCustomId",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).ImageInfoCustomId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DomainInfoCredentials = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ICredentialsProperties) content.GetValueForProperty("DomainInfoCredentials",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DomainInfoCredentials, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.CredentialsPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DomainInfoName = (string) content.GetValueForProperty("DomainInfoName",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DomainInfoName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DomainInfoJoinType = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.DomainJoinType?) content.GetValueForProperty("DomainInfoJoinType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DomainInfoJoinType, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.DomainJoinType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DomainInfoMdmProviderGuid = (string) content.GetValueForProperty("DomainInfoMdmProviderGuid",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DomainInfoMdmProviderGuid, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).MarketPlaceInfoOffer = (string) content.GetValueForProperty("MarketPlaceInfoOffer",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).MarketPlaceInfoOffer, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).MarketPlaceInfoPublisher = (string) content.GetValueForProperty("MarketPlaceInfoPublisher",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).MarketPlaceInfoPublisher, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).MarketPlaceInfoSku = (string) content.GetValueForProperty("MarketPlaceInfoSku",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).MarketPlaceInfoSku, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).MarketPlaceInfoExactVersion = (string) content.GetValueForProperty("MarketPlaceInfoExactVersion",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).MarketPlaceInfoExactVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).CredentialsLocalAdmin = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialProperties) content.GetValueForProperty("CredentialsLocalAdmin",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).CredentialsLocalAdmin, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.KeyVaultCredentialPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).CredentialsDomainAdmin = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialProperties) content.GetValueForProperty("CredentialsDomainAdmin",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).CredentialsDomainAdmin, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.KeyVaultCredentialPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).LocalAdminUserName = (string) content.GetValueForProperty("LocalAdminUserName",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).LocalAdminUserName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).LocalAdminPasswordKeyVaultResourceId = (string) content.GetValueForProperty("LocalAdminPasswordKeyVaultResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).LocalAdminPasswordKeyVaultResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).LocalAdminPasswordSecretName = (string) content.GetValueForProperty("LocalAdminPasswordSecretName",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).LocalAdminPasswordSecretName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DomainAdminUserName = (string) content.GetValueForProperty("DomainAdminUserName",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DomainAdminUserName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DomainAdminPasswordKeyVaultResourceId = (string) content.GetValueForProperty("DomainAdminPasswordKeyVaultResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DomainAdminPasswordKeyVaultResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DomainAdminPasswordSecretName = (string) content.GetValueForProperty("DomainAdminPasswordSecretName",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DomainAdminPasswordSecretName, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.SessionHostConfigurationProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SessionHostConfigurationProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).ImageInfo = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IImageInfoProperties) content.GetValueForProperty("ImageInfo",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).ImageInfo, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ImageInfoPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DomainInfo = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoProperties) content.GetValueForProperty("DomainInfo",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DomainInfo, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.DomainInfoPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).Version = (global::System.DateTime?) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).Version, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).VMSizeId = (string) content.GetValueForProperty("VMSizeId",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).VMSizeId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DiskType = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.VirtualMachineDiskType?) content.GetValueForProperty("DiskType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DiskType, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.VirtualMachineDiskType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).VMCustomConfigurationUri = (string) content.GetValueForProperty("VMCustomConfigurationUri",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).VMCustomConfigurationUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).ImageInfoMarketPlaceInfo = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMarketPlaceInfoProperties) content.GetValueForProperty("ImageInfoMarketPlaceInfo",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).ImageInfoMarketPlaceInfo, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.MarketPlaceInfoPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).ImageInfoType = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ImageType?) content.GetValueForProperty("ImageInfoType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).ImageInfoType, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ImageType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).ImageInfoStorageBlobUri = (string) content.GetValueForProperty("ImageInfoStorageBlobUri",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).ImageInfoStorageBlobUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).ImageInfoCustomId = (string) content.GetValueForProperty("ImageInfoCustomId",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).ImageInfoCustomId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DomainInfoCredentials = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ICredentialsProperties) content.GetValueForProperty("DomainInfoCredentials",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DomainInfoCredentials, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.CredentialsPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DomainInfoName = (string) content.GetValueForProperty("DomainInfoName",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DomainInfoName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DomainInfoJoinType = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.DomainJoinType?) content.GetValueForProperty("DomainInfoJoinType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DomainInfoJoinType, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.DomainJoinType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DomainInfoMdmProviderGuid = (string) content.GetValueForProperty("DomainInfoMdmProviderGuid",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DomainInfoMdmProviderGuid, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).MarketPlaceInfoOffer = (string) content.GetValueForProperty("MarketPlaceInfoOffer",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).MarketPlaceInfoOffer, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).MarketPlaceInfoPublisher = (string) content.GetValueForProperty("MarketPlaceInfoPublisher",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).MarketPlaceInfoPublisher, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).MarketPlaceInfoSku = (string) content.GetValueForProperty("MarketPlaceInfoSku",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).MarketPlaceInfoSku, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).MarketPlaceInfoExactVersion = (string) content.GetValueForProperty("MarketPlaceInfoExactVersion",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).MarketPlaceInfoExactVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).CredentialsLocalAdmin = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialProperties) content.GetValueForProperty("CredentialsLocalAdmin",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).CredentialsLocalAdmin, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.KeyVaultCredentialPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).CredentialsDomainAdmin = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialProperties) content.GetValueForProperty("CredentialsDomainAdmin",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).CredentialsDomainAdmin, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.KeyVaultCredentialPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).LocalAdminUserName = (string) content.GetValueForProperty("LocalAdminUserName",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).LocalAdminUserName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).LocalAdminPasswordKeyVaultResourceId = (string) content.GetValueForProperty("LocalAdminPasswordKeyVaultResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).LocalAdminPasswordKeyVaultResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).LocalAdminPasswordSecretName = (string) content.GetValueForProperty("LocalAdminPasswordSecretName",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).LocalAdminPasswordSecretName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DomainAdminUserName = (string) content.GetValueForProperty("DomainAdminUserName",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DomainAdminUserName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DomainAdminPasswordKeyVaultResourceId = (string) content.GetValueForProperty("DomainAdminPasswordKeyVaultResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DomainAdminPasswordKeyVaultResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DomainAdminPasswordSecretName = (string) content.GetValueForProperty("DomainAdminPasswordSecretName",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfigurationPropertiesInternal)this).DomainAdminPasswordSecretName, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Session host configurations of HostPool.
    [System.ComponentModel.TypeConverter(typeof(SessionHostConfigurationPropertiesTypeConverter))]
    public partial interface ISessionHostConfigurationProperties

    {

    }
}