// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support
{

    /// <summary>The kind of the DataSource.</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataSourceKindTypeConverter))]
    public partial struct DataSourceKind :
        System.Management.Automation.IArgumentCompleter
    {

        /// <summary>
        /// Implementations of this function are called by PowerShell to complete arguments.
        /// </summary>
        /// <param name="commandName">The name of the command that needs argument completion.</param>
        /// <param name="parameterName">The name of the parameter that needs argument completion.</param>
        /// <param name="wordToComplete">The (possibly empty) word being completed.</param>
        /// <param name="commandAst">The command ast in case it is needed for completion.</param>
        /// <param name="fakeBoundParameters">This parameter is similar to $PSBoundParameters, except that sometimes PowerShell cannot
        /// or will not attempt to evaluate an argument, in which case you may need to use commandAst.</param>
        /// <returns>
        /// A collection of completion results, most like with ResultType set to ParameterValue.
        /// </returns>
        public global::System.Collections.Generic.IEnumerable<global::System.Management.Automation.CompletionResult> CompleteArgument(global::System.String commandName, global::System.String parameterName, global::System.String wordToComplete, global::System.Management.Automation.Language.CommandAst commandAst, global::System.Collections.IDictionary fakeBoundParameters)
        {
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "WindowsEvent".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("WindowsEvent", "WindowsEvent", global::System.Management.Automation.CompletionResultType.ParameterValue, "WindowsEvent");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "WindowsPerformanceCounter".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("WindowsPerformanceCounter", "WindowsPerformanceCounter", global::System.Management.Automation.CompletionResultType.ParameterValue, "WindowsPerformanceCounter");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "IISLogs".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("IISLogs", "IISLogs", global::System.Management.Automation.CompletionResultType.ParameterValue, "IISLogs");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "LinuxSyslog".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("LinuxSyslog", "LinuxSyslog", global::System.Management.Automation.CompletionResultType.ParameterValue, "LinuxSyslog");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "LinuxSyslogCollection".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("LinuxSyslogCollection", "LinuxSyslogCollection", global::System.Management.Automation.CompletionResultType.ParameterValue, "LinuxSyslogCollection");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "LinuxPerformanceObject".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("LinuxPerformanceObject", "LinuxPerformanceObject", global::System.Management.Automation.CompletionResultType.ParameterValue, "LinuxPerformanceObject");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "LinuxPerformanceCollection".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("LinuxPerformanceCollection", "LinuxPerformanceCollection", global::System.Management.Automation.CompletionResultType.ParameterValue, "LinuxPerformanceCollection");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "CustomLog".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("CustomLog", "CustomLog", global::System.Management.Automation.CompletionResultType.ParameterValue, "CustomLog");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "CustomLogCollection".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("CustomLogCollection", "CustomLogCollection", global::System.Management.Automation.CompletionResultType.ParameterValue, "CustomLogCollection");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "AzureAuditLog".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("AzureAuditLog", "AzureAuditLog", global::System.Management.Automation.CompletionResultType.ParameterValue, "AzureAuditLog");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "AzureActivityLog".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("AzureActivityLog", "AzureActivityLog", global::System.Management.Automation.CompletionResultType.ParameterValue, "AzureActivityLog");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "GenericDataSource".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("GenericDataSource", "GenericDataSource", global::System.Management.Automation.CompletionResultType.ParameterValue, "GenericDataSource");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ChangeTrackingCustomPath".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("ChangeTrackingCustomPath", "ChangeTrackingCustomPath", global::System.Management.Automation.CompletionResultType.ParameterValue, "ChangeTrackingCustomPath");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ChangeTrackingPath".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("ChangeTrackingPath", "ChangeTrackingPath", global::System.Management.Automation.CompletionResultType.ParameterValue, "ChangeTrackingPath");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ChangeTrackingServices".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("ChangeTrackingServices", "ChangeTrackingServices", global::System.Management.Automation.CompletionResultType.ParameterValue, "ChangeTrackingServices");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ChangeTrackingDataTypeConfiguration".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("ChangeTrackingDataTypeConfiguration", "ChangeTrackingDataTypeConfiguration", global::System.Management.Automation.CompletionResultType.ParameterValue, "ChangeTrackingDataTypeConfiguration");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ChangeTrackingDefaultRegistry".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("ChangeTrackingDefaultRegistry", "ChangeTrackingDefaultRegistry", global::System.Management.Automation.CompletionResultType.ParameterValue, "ChangeTrackingDefaultRegistry");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ChangeTrackingRegistry".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("ChangeTrackingRegistry", "ChangeTrackingRegistry", global::System.Management.Automation.CompletionResultType.ParameterValue, "ChangeTrackingRegistry");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ChangeTrackingLinuxPath".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("ChangeTrackingLinuxPath", "ChangeTrackingLinuxPath", global::System.Management.Automation.CompletionResultType.ParameterValue, "ChangeTrackingLinuxPath");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "LinuxChangeTrackingPath".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("LinuxChangeTrackingPath", "LinuxChangeTrackingPath", global::System.Management.Automation.CompletionResultType.ParameterValue, "LinuxChangeTrackingPath");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ChangeTrackingContentLocation".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("ChangeTrackingContentLocation", "ChangeTrackingContentLocation", global::System.Management.Automation.CompletionResultType.ParameterValue, "ChangeTrackingContentLocation");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "WindowsTelemetry".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("WindowsTelemetry", "WindowsTelemetry", global::System.Management.Automation.CompletionResultType.ParameterValue, "WindowsTelemetry");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Office365".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Office365", "Office365", global::System.Management.Automation.CompletionResultType.ParameterValue, "Office365");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "SecurityWindowsBaselineConfiguration".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("SecurityWindowsBaselineConfiguration", "SecurityWindowsBaselineConfiguration", global::System.Management.Automation.CompletionResultType.ParameterValue, "SecurityWindowsBaselineConfiguration");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "SecurityCenterSecurityWindowsBaselineConfiguration".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("SecurityCenterSecurityWindowsBaselineConfiguration", "SecurityCenterSecurityWindowsBaselineConfiguration", global::System.Management.Automation.CompletionResultType.ParameterValue, "SecurityCenterSecurityWindowsBaselineConfiguration");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "SecurityEventCollectionConfiguration".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("SecurityEventCollectionConfiguration", "SecurityEventCollectionConfiguration", global::System.Management.Automation.CompletionResultType.ParameterValue, "SecurityEventCollectionConfiguration");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "SecurityInsightsSecurityEventCollectionConfiguration".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("SecurityInsightsSecurityEventCollectionConfiguration", "SecurityInsightsSecurityEventCollectionConfiguration", global::System.Management.Automation.CompletionResultType.ParameterValue, "SecurityInsightsSecurityEventCollectionConfiguration");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ImportComputerGroup".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("ImportComputerGroup", "ImportComputerGroup", global::System.Management.Automation.CompletionResultType.ParameterValue, "ImportComputerGroup");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "NetworkMonitoring".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("NetworkMonitoring", "NetworkMonitoring", global::System.Management.Automation.CompletionResultType.ParameterValue, "NetworkMonitoring");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Itsm".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Itsm", "Itsm", global::System.Management.Automation.CompletionResultType.ParameterValue, "Itsm");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "DnsAnalytics".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("DnsAnalytics", "DnsAnalytics", global::System.Management.Automation.CompletionResultType.ParameterValue, "DnsAnalytics");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ApplicationInsights".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("ApplicationInsights", "ApplicationInsights", global::System.Management.Automation.CompletionResultType.ParameterValue, "ApplicationInsights");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "SqlDataClassification".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("SqlDataClassification", "SqlDataClassification", global::System.Management.Automation.CompletionResultType.ParameterValue, "SqlDataClassification");
            }
        }
    }
}