namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>An update of an addon resource</summary>
    public partial class AddonUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IAddonUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IAddonUpdateInternal
    {

        /// <summary>The type of private cloud addon</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.AddonType? AddonType { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IAddonUpdatePropertiesInternal)Property).AddonType; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IAddonUpdatePropertiesInternal)Property).AddonType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.AddonType)""); }

        /// <summary>The SRM license</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string LicenseKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IAddonUpdatePropertiesInternal)Property).LicenseKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IAddonUpdatePropertiesInternal)Property).LicenseKey = value ?? null; }

        /// <summary>Internal Acessors for AddonProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IAddonProperties Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IAddonUpdateInternal.AddonProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IAddonUpdatePropertiesInternal)Property).Property; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IAddonUpdatePropertiesInternal)Property).Property = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IAddonUpdateProperties Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IAddonUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.AddonUpdateProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.AddonProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IAddonUpdateInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IAddonUpdatePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IAddonUpdatePropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IAddonUpdateProperties _property;

        /// <summary>The properties of an addon resource that may be updated</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IAddonUpdateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.AddonUpdateProperties()); set => this._property = value; }

        /// <summary>The state of the addon provisioning</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.AddonProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IAddonUpdatePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Creates an new <see cref="AddonUpdate" /> instance.</summary>
        public AddonUpdate()
        {

        }
    }
    /// An update of an addon resource
    public partial interface IAddonUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable
    {
        /// <summary>The type of private cloud addon</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of private cloud addon",
        SerializedName = @"addonType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.AddonType) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.AddonType? AddonType { get; set; }
        /// <summary>The SRM license</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The SRM license",
        SerializedName = @"licenseKey",
        PossibleTypes = new [] { typeof(string) })]
        string LicenseKey { get; set; }
        /// <summary>The state of the addon provisioning</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The state of the addon provisioning",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.AddonProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.AddonProvisioningState? ProvisioningState { get;  }

    }
    /// An update of an addon resource
    internal partial interface IAddonUpdateInternal

    {
        /// <summary>reference specific properties definition for addon type being used</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IAddonProperties AddonProperty { get; set; }
        /// <summary>The type of private cloud addon</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.AddonType? AddonType { get; set; }
        /// <summary>The SRM license</summary>
        string LicenseKey { get; set; }
        /// <summary>The properties of an addon resource that may be updated</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IAddonUpdateProperties Property { get; set; }
        /// <summary>The state of the addon provisioning</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.AddonProvisioningState? ProvisioningState { get; set; }

    }
}