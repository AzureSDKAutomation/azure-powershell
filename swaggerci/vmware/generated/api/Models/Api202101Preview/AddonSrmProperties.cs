namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>The properties of an SRM addon that may be updated</summary>
    public partial class AddonSrmProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IAddonSrmProperties,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IAddonSrmPropertiesInternal
    {

        /// <summary>Backing field for <see cref="LicenseKey" /> property.</summary>
        private string _licenseKey;

        /// <summary>The SRM license</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string LicenseKey { get => this._licenseKey; set => this._licenseKey = value; }

        /// <summary>Creates an new <see cref="AddonSrmProperties" /> instance.</summary>
        public AddonSrmProperties()
        {

        }
    }
    /// The properties of an SRM addon that may be updated
    public partial interface IAddonSrmProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable
    {
        /// <summary>The SRM license</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The SRM license",
        SerializedName = @"licenseKey",
        PossibleTypes = new [] { typeof(string) })]
        string LicenseKey { get; set; }

    }
    /// The properties of an SRM addon that may be updated
    internal partial interface IAddonSrmPropertiesInternal

    {
        /// <summary>The SRM license</summary>
        string LicenseKey { get; set; }

    }
}