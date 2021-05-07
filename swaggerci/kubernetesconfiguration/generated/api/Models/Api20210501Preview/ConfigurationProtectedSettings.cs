namespace Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Extensions;

    /// <summary>Name-value pairs of protected configuration settings for the configuration</summary>
    public partial class ConfigurationProtectedSettings :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IConfigurationProtectedSettings,
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IConfigurationProtectedSettingsInternal
    {

        /// <summary>Creates an new <see cref="ConfigurationProtectedSettings" /> instance.</summary>
        public ConfigurationProtectedSettings()
        {

        }
    }
    /// Name-value pairs of protected configuration settings for the configuration
    public partial interface IConfigurationProtectedSettings :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.IAssociativeArray<string>
    {

    }
    /// Name-value pairs of protected configuration settings for the configuration
    internal partial interface IConfigurationProtectedSettingsInternal

    {

    }
}