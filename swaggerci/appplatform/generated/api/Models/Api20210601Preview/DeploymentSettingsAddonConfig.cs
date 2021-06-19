namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Collection of addons</summary>
    public partial class DeploymentSettingsAddonConfig :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsAddonConfig,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsAddonConfigInternal
    {

        /// <summary>Creates an new <see cref="DeploymentSettingsAddonConfig" /> instance.</summary>
        public DeploymentSettingsAddonConfig()
        {

        }
    }
    /// Collection of addons
    public partial interface IDeploymentSettingsAddonConfig :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IAssociativeArray<Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAddonProfile>
    {

    }
    /// Collection of addons
    internal partial interface IDeploymentSettingsAddonConfigInternal

    {

    }
}