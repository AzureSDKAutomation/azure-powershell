namespace Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Extensions;

    /// <summary>Name-value pairs of protected configuration settings for the configuration</summary>
    public partial class ConfigurationProtectedSettings :
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IConfigurationProtectedSettings,
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IConfigurationProtectedSettingsInternal
    {

        /// <summary>Creates an new <see cref="ConfigurationProtectedSettings" /> instance.</summary>
        public ConfigurationProtectedSettings()
        {

        }
    }
    /// Name-value pairs of protected configuration settings for the configuration
    public partial interface IConfigurationProtectedSettings :
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.IAssociativeArray<string>
    {

    }
    /// Name-value pairs of protected configuration settings for the configuration
    internal partial interface IConfigurationProtectedSettingsInternal

    {

    }
}