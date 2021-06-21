namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Extensions;

    /// <summary>Specifies the linux configuration for update management.</summary>
    public partial class OSProfileLinuxConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IOSProfileLinuxConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IOSProfileLinuxConfigurationInternal
    {

        /// <summary>Internal Acessors for PatchSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IPatchSettings Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IOSProfileLinuxConfigurationInternal.PatchSetting { get => (this._patchSetting = this._patchSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.PatchSettings()); set { {_patchSetting = value;} } }

        /// <summary>Backing field for <see cref="PatchSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IPatchSettings _patchSetting;

        /// <summary>Specifies the patch settings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IPatchSettings PatchSetting { get => (this._patchSetting = this._patchSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.PatchSettings()); set => this._patchSetting = value; }

        /// <summary>Specifies the assessment mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string PatchSettingAssessmentMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IPatchSettingsInternal)PatchSetting).AssessmentMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IPatchSettingsInternal)PatchSetting).AssessmentMode = value ?? null; }

        /// <summary>Creates an new <see cref="OSProfileLinuxConfiguration" /> instance.</summary>
        public OSProfileLinuxConfiguration()
        {

        }
    }
    /// Specifies the linux configuration for update management.
    public partial interface IOSProfileLinuxConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IJsonSerializable
    {
        /// <summary>Specifies the assessment mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the assessment mode.",
        SerializedName = @"assessmentMode",
        PossibleTypes = new [] { typeof(string) })]
        string PatchSettingAssessmentMode { get; set; }

    }
    /// Specifies the linux configuration for update management.
    internal partial interface IOSProfileLinuxConfigurationInternal

    {
        /// <summary>Specifies the patch settings.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IPatchSettings PatchSetting { get; set; }
        /// <summary>Specifies the assessment mode.</summary>
        string PatchSettingAssessmentMode { get; set; }

    }
}