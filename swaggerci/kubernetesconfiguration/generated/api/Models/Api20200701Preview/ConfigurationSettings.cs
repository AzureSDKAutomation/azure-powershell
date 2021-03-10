namespace Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Extensions;

    /// <summary>Name-value pairs for configuring the extensionInstance</summary>
    public partial class ConfigurationSettings :
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IConfigurationSettings,
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IConfigurationSettingsInternal
    {

        /// <summary>Creates an new <see cref="ConfigurationSettings" /> instance.</summary>
        public ConfigurationSettings()
        {

        }
    }
    /// Name-value pairs for configuring the extensionInstance
    public partial interface IConfigurationSettings :
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.IAssociativeArray<string>
    {

    }
    /// Name-value pairs for configuring the extensionInstance
    internal partial interface IConfigurationSettingsInternal

    {

    }
}