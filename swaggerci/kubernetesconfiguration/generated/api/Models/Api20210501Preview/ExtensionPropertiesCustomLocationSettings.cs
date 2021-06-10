namespace Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Extensions;

    /// <summary>Custom Location settings properties.</summary>
    public partial class ExtensionPropertiesCustomLocationSettings :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesCustomLocationSettings,
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionPropertiesCustomLocationSettingsInternal
    {

        /// <summary>
        /// Creates an new <see cref="ExtensionPropertiesCustomLocationSettings" /> instance.
        /// </summary>
        public ExtensionPropertiesCustomLocationSettings()
        {

        }
    }
    /// Custom Location settings properties.
    public partial interface IExtensionPropertiesCustomLocationSettings :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.IAssociativeArray<string>
    {

    }
    /// Custom Location settings properties.
    internal partial interface IExtensionPropertiesCustomLocationSettingsInternal

    {

    }
}