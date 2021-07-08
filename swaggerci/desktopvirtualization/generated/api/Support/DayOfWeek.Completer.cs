// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support
{

    /// <summary>Day of the week.</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.DayOfWeekTypeConverter))]
    public partial struct DayOfWeek :
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
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Monday".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Monday", "Monday", global::System.Management.Automation.CompletionResultType.ParameterValue, "Monday");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Tuesday".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Tuesday", "Tuesday", global::System.Management.Automation.CompletionResultType.ParameterValue, "Tuesday");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Wednesday".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Wednesday", "Wednesday", global::System.Management.Automation.CompletionResultType.ParameterValue, "Wednesday");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Thursday".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Thursday", "Thursday", global::System.Management.Automation.CompletionResultType.ParameterValue, "Thursday");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Friday".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Friday", "Friday", global::System.Management.Automation.CompletionResultType.ParameterValue, "Friday");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Saturday".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Saturday", "Saturday", global::System.Management.Automation.CompletionResultType.ParameterValue, "Saturday");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Sunday".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Sunday", "Sunday", global::System.Management.Automation.CompletionResultType.ParameterValue, "Sunday");
            }
        }
    }
}