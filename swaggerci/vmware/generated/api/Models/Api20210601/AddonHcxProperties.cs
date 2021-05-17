namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>The properties of an HCX addon</summary>
    public partial class AddonHcxProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IAddonHcxProperties,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IAddonHcxPropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IAddonProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IAddonProperties __addonProperties = new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.AddonProperties();

        /// <summary>The type of private cloud addon</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.AddonType AddonType { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IAddonPropertiesInternal)__addonProperties).AddonType; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IAddonPropertiesInternal)__addonProperties).AddonType = value ; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.AddonProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IAddonPropertiesInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IAddonPropertiesInternal)__addonProperties).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IAddonPropertiesInternal)__addonProperties).ProvisioningState = value; }

        /// <summary>Backing field for <see cref="Offer" /> property.</summary>
        private string _offer;

        /// <summary>The HCX offer, example VMware MaaS Cloud Provider (Enterprise)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string Offer { get => this._offer; set => this._offer = value; }

        /// <summary>The state of the addon provisioning</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.AddonProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IAddonPropertiesInternal)__addonProperties).ProvisioningState; }

        /// <summary>Creates an new <see cref="AddonHcxProperties" /> instance.</summary>
        public AddonHcxProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__addonProperties), __addonProperties);
            await eventListener.AssertObjectIsValid(nameof(__addonProperties), __addonProperties);
        }
    }
    /// The properties of an HCX addon
    public partial interface IAddonHcxProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IAddonProperties
    {
        /// <summary>The HCX offer, example VMware MaaS Cloud Provider (Enterprise)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The HCX offer, example VMware MaaS Cloud Provider (Enterprise)",
        SerializedName = @"offer",
        PossibleTypes = new [] { typeof(string) })]
        string Offer { get; set; }

    }
    /// The properties of an HCX addon
    internal partial interface IAddonHcxPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IAddonPropertiesInternal
    {
        /// <summary>The HCX offer, example VMware MaaS Cloud Provider (Enterprise)</summary>
        string Offer { get; set; }

    }
}