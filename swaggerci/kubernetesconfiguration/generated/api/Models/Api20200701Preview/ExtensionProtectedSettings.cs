namespace Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Extensions;

    /// <summary>
    /// Configuration settings that are sensitive, as name-value pairs for configuring this instance of the extension.
    /// </summary>
    public partial class ExtensionProtectedSettings :
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionProtectedSettings,
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionProtectedSettingsInternal
    {

        /// <summary>Creates an new <see cref="ExtensionProtectedSettings" /> instance.</summary>
        public ExtensionProtectedSettings()
        {

        }
    }
    /// Configuration settings that are sensitive, as name-value pairs for configuring this instance of the extension.
    public partial interface IExtensionProtectedSettings :
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.IAssociativeArray<string>
    {

    }
    /// Configuration settings that are sensitive, as name-value pairs for configuring this instance of the extension.
    internal partial interface IExtensionProtectedSettingsInternal

    {

    }
}