namespace Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Extensions;

    /// <summary>
    /// Configuration settings that are sensitive, as name-value pairs for configuring this extension.
    /// </summary>
    public partial class ExtensionPropertiesConfigurationProtectedSettings :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesConfigurationProtectedSettings,
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesConfigurationProtectedSettingsInternal
    {

        /// <summary>
        /// Creates an new <see cref="ExtensionPropertiesConfigurationProtectedSettings" /> instance.
        /// </summary>
        public ExtensionPropertiesConfigurationProtectedSettings()
        {

        }
    }
    /// Configuration settings that are sensitive, as name-value pairs for configuring this extension.
    public partial interface IExtensionPropertiesConfigurationProtectedSettings :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.IAssociativeArray<string>
    {

    }
    /// Configuration settings that are sensitive, as name-value pairs for configuring this extension.
    internal partial interface IExtensionPropertiesConfigurationProtectedSettingsInternal

    {

    }
}