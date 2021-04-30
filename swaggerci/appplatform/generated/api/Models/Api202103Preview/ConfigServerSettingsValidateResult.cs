namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Validation result for config server settings</summary>
    public partial class ConfigServerSettingsValidateResult :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IConfigServerSettingsValidateResult,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IConfigServerSettingsValidateResultInternal
    {

        /// <summary>Backing field for <see cref="Detail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IConfigServerSettingsErrorRecord[] _detail;

        /// <summary>The detail validation results</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IConfigServerSettingsErrorRecord[] Detail { get => this._detail; set => this._detail = value; }

        /// <summary>Backing field for <see cref="IsValid" /> property.</summary>
        private bool? _isValid;

        /// <summary>Indicate if the config server settings are valid</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public bool? IsValid { get => this._isValid; set => this._isValid = value; }

        /// <summary>Creates an new <see cref="ConfigServerSettingsValidateResult" /> instance.</summary>
        public ConfigServerSettingsValidateResult()
        {

        }
    }
    /// Validation result for config server settings
    public partial interface IConfigServerSettingsValidateResult :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable
    {
        /// <summary>The detail validation results</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The detail validation results",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IConfigServerSettingsErrorRecord) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IConfigServerSettingsErrorRecord[] Detail { get; set; }
        /// <summary>Indicate if the config server settings are valid</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicate if the config server settings are valid",
        SerializedName = @"isValid",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsValid { get; set; }

    }
    /// Validation result for config server settings
    internal partial interface IConfigServerSettingsValidateResultInternal

    {
        /// <summary>The detail validation results</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IConfigServerSettingsErrorRecord[] Detail { get; set; }
        /// <summary>Indicate if the config server settings are valid</summary>
        bool? IsValid { get; set; }

    }
}