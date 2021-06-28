namespace Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Extensions;

    /// <summary>Configuration settings, as name-value pairs for configuring this extension.</summary>
    public partial class ExtensionPropertiesConfigurationSettings :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesConfigurationSettings,
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesConfigurationSettingsInternal
    {

        /// <summary>
        /// Creates an new <see cref="ExtensionPropertiesConfigurationSettings" /> instance.
        /// </summary>
        public ExtensionPropertiesConfigurationSettings()
        {

        }
    }
    /// Configuration settings, as name-value pairs for configuring this extension.
    public partial interface IExtensionPropertiesConfigurationSettings :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.IAssociativeArray<string>
    {

    }
    /// Configuration settings, as name-value pairs for configuring this extension.
    internal partial interface IExtensionPropertiesConfigurationSettingsInternal

    {

    }
}