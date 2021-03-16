namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Monitoring Setting properties payload</summary>
    public partial class MonitoringSettingProperties :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingProperties,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingPropertiesInternal
    {

        /// <summary>Indicates the version of application insight java agent</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string AppInsightAgentVersionJava { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IApplicationInsightsAgentVersionsInternal)AppInsightsAgentVersion).Java; }

        /// <summary>Backing field for <see cref="AppInsightsAgentVersion" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IApplicationInsightsAgentVersions _appInsightsAgentVersion;

        /// <summary>Indicates the versions of application insight agent</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IApplicationInsightsAgentVersions AppInsightsAgentVersion { get => (this._appInsightsAgentVersion = this._appInsightsAgentVersion ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ApplicationInsightsAgentVersions()); set => this._appInsightsAgentVersion = value; }

        /// <summary>Backing field for <see cref="AppInsightsInstrumentationKey" /> property.</summary>
        private string _appInsightsInstrumentationKey;

        /// <summary>
        /// Target application insight instrumentation key, null or whitespace include empty will disable monitoringSettings
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string AppInsightsInstrumentationKey { get => this._appInsightsInstrumentationKey; set => this._appInsightsInstrumentationKey = value; }

        /// <summary>Backing field for <see cref="AppInsightsSamplingRate" /> property.</summary>
        private double? _appInsightsSamplingRate;

        /// <summary>
        /// Indicates the sampling rate of application insight agent, should be in range [0.0, 100.0]
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public double? AppInsightsSamplingRate { get => this._appInsightsSamplingRate; set => this._appInsightsSamplingRate = value; }

        /// <summary>The code of error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IErrorInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IErrorInternal)Error).Code = value ?? null; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IError _error;

        /// <summary>Error when apply Monitoring Setting changes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IError Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.Error()); set => this._error = value; }

        /// <summary>The message of error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IErrorInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IErrorInternal)Error).Message = value ?? null; }

        /// <summary>Internal Acessors for AppInsightAgentVersionJava</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingPropertiesInternal.AppInsightAgentVersionJava { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IApplicationInsightsAgentVersionsInternal)AppInsightsAgentVersion).Java; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IApplicationInsightsAgentVersionsInternal)AppInsightsAgentVersion).Java = value; }

        /// <summary>Internal Acessors for AppInsightsAgentVersion</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IApplicationInsightsAgentVersions Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingPropertiesInternal.AppInsightsAgentVersion { get => (this._appInsightsAgentVersion = this._appInsightsAgentVersion ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ApplicationInsightsAgentVersions()); set { {_appInsightsAgentVersion = value;} } }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IError Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingPropertiesInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.Error()); set { {_error = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.MonitoringSettingState? Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMonitoringSettingPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.MonitoringSettingState? _provisioningState;

        /// <summary>State of the Monitoring Setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.MonitoringSettingState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="TraceEnabled" /> property.</summary>
        private bool? _traceEnabled;

        /// <summary>
        /// Indicates whether enable the trace functionality, which will be deprecated since api version 2020-11-01-preview. Please
        /// leverage appInsightsInstrumentationKey to indicate if monitoringSettings enabled or not
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public bool? TraceEnabled { get => this._traceEnabled; set => this._traceEnabled = value; }

        /// <summary>Creates an new <see cref="MonitoringSettingProperties" /> instance.</summary>
        public MonitoringSettingProperties()
        {

        }
    }
    /// Monitoring Setting properties payload
    public partial interface IMonitoringSettingProperties :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable
    {
        /// <summary>Indicates the version of application insight java agent</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Indicates the version of application insight java agent",
        SerializedName = @"java",
        PossibleTypes = new [] { typeof(string) })]
        string AppInsightAgentVersionJava { get;  }
        /// <summary>
        /// Target application insight instrumentation key, null or whitespace include empty will disable monitoringSettings
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Target application insight instrumentation key, null or whitespace include empty will disable monitoringSettings",
        SerializedName = @"appInsightsInstrumentationKey",
        PossibleTypes = new [] { typeof(string) })]
        string AppInsightsInstrumentationKey { get; set; }
        /// <summary>
        /// Indicates the sampling rate of application insight agent, should be in range [0.0, 100.0]
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates the sampling rate of application insight agent, should be in range [0.0, 100.0]",
        SerializedName = @"appInsightsSamplingRate",
        PossibleTypes = new [] { typeof(double) })]
        double? AppInsightsSamplingRate { get; set; }
        /// <summary>The code of error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The code of error.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get; set; }
        /// <summary>The message of error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The message of error.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }
        /// <summary>State of the Monitoring Setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"State of the Monitoring Setting.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.MonitoringSettingState) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.MonitoringSettingState? ProvisioningState { get;  }
        /// <summary>
        /// Indicates whether enable the trace functionality, which will be deprecated since api version 2020-11-01-preview. Please
        /// leverage appInsightsInstrumentationKey to indicate if monitoringSettings enabled or not
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether enable the trace functionality, which will be deprecated since api version 2020-11-01-preview. Please leverage appInsightsInstrumentationKey to indicate if monitoringSettings enabled or not",
        SerializedName = @"traceEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? TraceEnabled { get; set; }

    }
    /// Monitoring Setting properties payload
    internal partial interface IMonitoringSettingPropertiesInternal

    {
        /// <summary>Indicates the version of application insight java agent</summary>
        string AppInsightAgentVersionJava { get; set; }
        /// <summary>Indicates the versions of application insight agent</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IApplicationInsightsAgentVersions AppInsightsAgentVersion { get; set; }
        /// <summary>
        /// Target application insight instrumentation key, null or whitespace include empty will disable monitoringSettings
        /// </summary>
        string AppInsightsInstrumentationKey { get; set; }
        /// <summary>
        /// Indicates the sampling rate of application insight agent, should be in range [0.0, 100.0]
        /// </summary>
        double? AppInsightsSamplingRate { get; set; }
        /// <summary>The code of error.</summary>
        string Code { get; set; }
        /// <summary>Error when apply Monitoring Setting changes.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IError Error { get; set; }
        /// <summary>The message of error.</summary>
        string Message { get; set; }
        /// <summary>State of the Monitoring Setting.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.MonitoringSettingState? ProvisioningState { get; set; }
        /// <summary>
        /// Indicates whether enable the trace functionality, which will be deprecated since api version 2020-11-01-preview. Please
        /// leverage appInsightsInstrumentationKey to indicate if monitoringSettings enabled or not
        /// </summary>
        bool? TraceEnabled { get; set; }

    }
}