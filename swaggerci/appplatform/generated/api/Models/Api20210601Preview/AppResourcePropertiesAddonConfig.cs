namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Collection of addons</summary>
    public partial class AppResourcePropertiesAddonConfig :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourcePropertiesAddonConfig,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAppResourcePropertiesAddonConfigInternal
    {

        /// <summary>Creates an new <see cref="AppResourcePropertiesAddonConfig" /> instance.</summary>
        public AppResourcePropertiesAddonConfig()
        {

        }
    }
    /// Collection of addons
    public partial interface IAppResourcePropertiesAddonConfig :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IAssociativeArray<Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAddonProfile>
    {

    }
    /// Collection of addons
    internal partial interface IAppResourcePropertiesAddonConfigInternal

    {

    }
}