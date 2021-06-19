namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Key-value pairs for configurations of add-on</summary>
    public partial class AddonProfileProperties :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAddonProfileProperties,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IAddonProfilePropertiesInternal
    {

        /// <summary>Creates an new <see cref="AddonProfileProperties" /> instance.</summary>
        public AddonProfileProperties()
        {

        }
    }
    /// Key-value pairs for configurations of add-on
    public partial interface IAddonProfileProperties :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IAssociativeArray<string>
    {

    }
    /// Key-value pairs for configurations of add-on
    internal partial interface IAddonProfilePropertiesInternal

    {

    }
}