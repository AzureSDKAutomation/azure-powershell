namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Extensions;

    /// <summary>Specifies the operating system settings for the hybrid machine.</summary>
    public partial class OSProfile :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfile,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileInternal
    {

        /// <summary>Backing field for <see cref="ComputerName" /> property.</summary>
        private string _computerName;

        /// <summary>Specifies the host OS name of the hybrid machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public string ComputerName { get => this._computerName; }

        /// <summary>Backing field for <see cref="LinuxConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileLinuxConfiguration _linuxConfiguration;

        /// <summary>Specifies the linux configuration for update management.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileLinuxConfiguration LinuxConfiguration { get => (this._linuxConfiguration = this._linuxConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.OSProfileLinuxConfiguration()); set => this._linuxConfiguration = value; }

        /// <summary>Specifies the assessment mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string LinuxConfigurationPatchSettingsAssessmentMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileLinuxConfigurationInternal)LinuxConfiguration).PatchSettingAssessmentMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileLinuxConfigurationInternal)LinuxConfiguration).PatchSettingAssessmentMode = value ?? null; }

        /// <summary>Internal Acessors for ComputerName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileInternal.ComputerName { get => this._computerName; set { {_computerName = value;} } }

        /// <summary>Internal Acessors for LinuxConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileLinuxConfiguration Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileInternal.LinuxConfiguration { get => (this._linuxConfiguration = this._linuxConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.OSProfileLinuxConfiguration()); set { {_linuxConfiguration = value;} } }

        /// <summary>Internal Acessors for LinuxConfigurationPatchSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IPatchSettings Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileInternal.LinuxConfigurationPatchSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileLinuxConfigurationInternal)LinuxConfiguration).PatchSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileLinuxConfigurationInternal)LinuxConfiguration).PatchSetting = value; }

        /// <summary>Internal Acessors for WindowConfigurationPatchSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IPatchSettings Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileInternal.WindowConfigurationPatchSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileWindowsConfigurationInternal)WindowsConfiguration).PatchSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileWindowsConfigurationInternal)WindowsConfiguration).PatchSetting = value; }

        /// <summary>Internal Acessors for WindowsConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileWindowsConfiguration Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileInternal.WindowsConfiguration { get => (this._windowsConfiguration = this._windowsConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.OSProfileWindowsConfiguration()); set { {_windowsConfiguration = value;} } }

        /// <summary>Backing field for <see cref="WindowsConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileWindowsConfiguration _windowsConfiguration;

        /// <summary>Specifies the windows configuration for update management.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileWindowsConfiguration WindowsConfiguration { get => (this._windowsConfiguration = this._windowsConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.OSProfileWindowsConfiguration()); set => this._windowsConfiguration = value; }

        /// <summary>Specifies the assessment mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string WindowsConfigurationPatchSettingsAssessmentMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileWindowsConfigurationInternal)WindowsConfiguration).PatchSettingAssessmentMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileWindowsConfigurationInternal)WindowsConfiguration).PatchSettingAssessmentMode = value ?? null; }

        /// <summary>Creates an new <see cref="OSProfile" /> instance.</summary>
        public OSProfile()
        {

        }
    }
    /// Specifies the operating system settings for the hybrid machine.
    public partial interface IOSProfile :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IJsonSerializable
    {
        /// <summary>Specifies the host OS name of the hybrid machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Specifies the host OS name of the hybrid machine.",
        SerializedName = @"computerName",
        PossibleTypes = new [] { typeof(string) })]
        string ComputerName { get;  }
        /// <summary>Specifies the assessment mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the assessment mode.",
        SerializedName = @"assessmentMode",
        PossibleTypes = new [] { typeof(string) })]
        string LinuxConfigurationPatchSettingsAssessmentMode { get; set; }
        /// <summary>Specifies the assessment mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the assessment mode.",
        SerializedName = @"assessmentMode",
        PossibleTypes = new [] { typeof(string) })]
        string WindowsConfigurationPatchSettingsAssessmentMode { get; set; }

    }
    /// Specifies the operating system settings for the hybrid machine.
    internal partial interface IOSProfileInternal

    {
        /// <summary>Specifies the host OS name of the hybrid machine.</summary>
        string ComputerName { get; set; }
        /// <summary>Specifies the linux configuration for update management.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileLinuxConfiguration LinuxConfiguration { get; set; }
        /// <summary>Specifies the patch settings.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IPatchSettings LinuxConfigurationPatchSetting { get; set; }
        /// <summary>Specifies the assessment mode.</summary>
        string LinuxConfigurationPatchSettingsAssessmentMode { get; set; }
        /// <summary>Specifies the patch settings.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IPatchSettings WindowConfigurationPatchSetting { get; set; }
        /// <summary>Specifies the windows configuration for update management.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileWindowsConfiguration WindowsConfiguration { get; set; }
        /// <summary>Specifies the assessment mode.</summary>
        string WindowsConfigurationPatchSettingsAssessmentMode { get; set; }

    }
}