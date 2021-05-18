namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.PowerShell;

    /// <summary>Source information for a deployment</summary>
    [System.ComponentModel.TypeConverter(typeof(UserSourceInfoTypeConverter))]
    public partial class UserSourceInfo
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.UserSourceInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfo" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfo DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new UserSourceInfo(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.UserSourceInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfo" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfo DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new UserSourceInfo(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="UserSourceInfo" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfo FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.UserSourceInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal UserSourceInfo(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).CustomContainer = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ICustomContainer) content.GetValueForProperty("CustomContainer",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).CustomContainer, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.CustomContainerTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).Type = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.UserSourceType?) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).Type, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.UserSourceType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).RelativePath = (string) content.GetValueForProperty("RelativePath",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).RelativePath, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).Version, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).ArtifactSelector = (string) content.GetValueForProperty("ArtifactSelector",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).ArtifactSelector, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).CustomContainerServer = (string) content.GetValueForProperty("CustomContainerServer",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).CustomContainerServer, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).CustomContainerCommand = (string[]) content.GetValueForProperty("CustomContainerCommand",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).CustomContainerCommand, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).CustomContainerArg = (string[]) content.GetValueForProperty("CustomContainerArg",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).CustomContainerArg, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).CustomContainerImageRegistryCredential = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IImageRegistryCredential) content.GetValueForProperty("CustomContainerImageRegistryCredential",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).CustomContainerImageRegistryCredential, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ImageRegistryCredentialTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).CustomContainerImage = (string) content.GetValueForProperty("CustomContainerImage",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).CustomContainerImage, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).ImageRegistryCredentialUsername = (string) content.GetValueForProperty("ImageRegistryCredentialUsername",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).ImageRegistryCredentialUsername, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).ImageRegistryCredentialPassword = (string) content.GetValueForProperty("ImageRegistryCredentialPassword",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).ImageRegistryCredentialPassword, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.UserSourceInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal UserSourceInfo(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).CustomContainer = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ICustomContainer) content.GetValueForProperty("CustomContainer",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).CustomContainer, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.CustomContainerTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).Type = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.UserSourceType?) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).Type, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.UserSourceType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).RelativePath = (string) content.GetValueForProperty("RelativePath",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).RelativePath, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).Version, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).ArtifactSelector = (string) content.GetValueForProperty("ArtifactSelector",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).ArtifactSelector, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).CustomContainerServer = (string) content.GetValueForProperty("CustomContainerServer",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).CustomContainerServer, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).CustomContainerCommand = (string[]) content.GetValueForProperty("CustomContainerCommand",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).CustomContainerCommand, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).CustomContainerArg = (string[]) content.GetValueForProperty("CustomContainerArg",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).CustomContainerArg, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).CustomContainerImageRegistryCredential = (Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IImageRegistryCredential) content.GetValueForProperty("CustomContainerImageRegistryCredential",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).CustomContainerImageRegistryCredential, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ImageRegistryCredentialTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).CustomContainerImage = (string) content.GetValueForProperty("CustomContainerImage",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).CustomContainerImage, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).ImageRegistryCredentialUsername = (string) content.GetValueForProperty("ImageRegistryCredentialUsername",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).ImageRegistryCredentialUsername, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).ImageRegistryCredentialPassword = (string) content.GetValueForProperty("ImageRegistryCredentialPassword",((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)this).ImageRegistryCredentialPassword, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }
    }
    /// Source information for a deployment
    [System.ComponentModel.TypeConverter(typeof(UserSourceInfoTypeConverter))]
    public partial interface IUserSourceInfo

    {

    }
}