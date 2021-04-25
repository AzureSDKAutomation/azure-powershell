namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>The properties of an HCX Enterprise Site</summary>
    public partial class HcxEnterpriseSiteProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IHcxEnterpriseSiteProperties,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IHcxEnterpriseSitePropertiesInternal
    {

        /// <summary>Backing field for <see cref="ActivationKey" /> property.</summary>
        private string _activationKey;

        /// <summary>The activation key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string ActivationKey { get => this._activationKey; }

        /// <summary>Internal Acessors for ActivationKey</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IHcxEnterpriseSitePropertiesInternal.ActivationKey { get => this._activationKey; set { {_activationKey = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.HcxEnterpriseSiteStatus? Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IHcxEnterpriseSitePropertiesInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.HcxEnterpriseSiteStatus? _status;

        /// <summary>The status of the HCX Enterprise Site</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.HcxEnterpriseSiteStatus? Status { get => this._status; }

        /// <summary>Creates an new <see cref="HcxEnterpriseSiteProperties" /> instance.</summary>
        public HcxEnterpriseSiteProperties()
        {

        }
    }
    /// The properties of an HCX Enterprise Site
    public partial interface IHcxEnterpriseSiteProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable
    {
        /// <summary>The activation key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The activation key",
        SerializedName = @"activationKey",
        PossibleTypes = new [] { typeof(string) })]
        string ActivationKey { get;  }
        /// <summary>The status of the HCX Enterprise Site</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The status of the HCX Enterprise Site",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.HcxEnterpriseSiteStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.HcxEnterpriseSiteStatus? Status { get;  }

    }
    /// The properties of an HCX Enterprise Site
    internal partial interface IHcxEnterpriseSitePropertiesInternal

    {
        /// <summary>The activation key</summary>
        string ActivationKey { get; set; }
        /// <summary>The status of the HCX Enterprise Site</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.HcxEnterpriseSiteStatus? Status { get; set; }

    }
}