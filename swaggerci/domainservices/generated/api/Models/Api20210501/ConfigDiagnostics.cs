namespace Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Extensions;

    /// <summary>Configuration Diagnostics</summary>
    public partial class ConfigDiagnostics :
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IConfigDiagnostics,
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IConfigDiagnosticsInternal
    {

        /// <summary>Backing field for <see cref="LastExecuted" /> property.</summary>
        private global::System.DateTime? _lastExecuted;

        /// <summary>Last domain configuration diagnostics DateTime</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public global::System.DateTime? LastExecuted { get => this._lastExecuted; set => this._lastExecuted = value; }

        /// <summary>Backing field for <see cref="ValidatorResult" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IConfigDiagnosticsValidatorResult[] _validatorResult;

        /// <summary>List of Configuration Diagnostics validator results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IConfigDiagnosticsValidatorResult[] ValidatorResult { get => this._validatorResult; set => this._validatorResult = value; }

        /// <summary>Creates an new <see cref="ConfigDiagnostics" /> instance.</summary>
        public ConfigDiagnostics()
        {

        }
    }
    /// Configuration Diagnostics
    public partial interface IConfigDiagnostics :
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.IJsonSerializable
    {
        /// <summary>Last domain configuration diagnostics DateTime</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Last domain configuration diagnostics DateTime",
        SerializedName = @"lastExecuted",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastExecuted { get; set; }
        /// <summary>List of Configuration Diagnostics validator results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of Configuration Diagnostics validator results.",
        SerializedName = @"validatorResults",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IConfigDiagnosticsValidatorResult) })]
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IConfigDiagnosticsValidatorResult[] ValidatorResult { get; set; }

    }
    /// Configuration Diagnostics
    internal partial interface IConfigDiagnosticsInternal

    {
        /// <summary>Last domain configuration diagnostics DateTime</summary>
        global::System.DateTime? LastExecuted { get; set; }
        /// <summary>List of Configuration Diagnostics validator results.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IConfigDiagnosticsValidatorResult[] ValidatorResult { get; set; }

    }
}