namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>a plain text value execution parameter</summary>
    public partial class ScriptSecureStringExecutionParameter :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptSecureStringExecutionParameter,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptSecureStringExecutionParameterInternal,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionParameter"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionParameter __scriptExecutionParameter = new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ScriptExecutionParameter();

        /// <summary>The parameter name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionParameterInternal)__scriptExecutionParameter).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionParameterInternal)__scriptExecutionParameter).Name = value ; }

        /// <summary>Backing field for <see cref="SecureValue" /> property.</summary>
        private string _secureValue;

        /// <summary>A secure value for the passed parameter, not to be stored in logs</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string SecureValue { get => this._secureValue; set => this._secureValue = value; }

        /// <summary>The type of execution parameter</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.ScriptExecutionParameterType Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionParameterInternal)__scriptExecutionParameter).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionParameterInternal)__scriptExecutionParameter).Type = value ; }

        /// <summary>Creates an new <see cref="ScriptSecureStringExecutionParameter" /> instance.</summary>
        public ScriptSecureStringExecutionParameter()
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
            await eventListener.AssertNotNull(nameof(__scriptExecutionParameter), __scriptExecutionParameter);
            await eventListener.AssertObjectIsValid(nameof(__scriptExecutionParameter), __scriptExecutionParameter);
        }
    }
    /// a plain text value execution parameter
    public partial interface IScriptSecureStringExecutionParameter :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionParameter
    {
        /// <summary>A secure value for the passed parameter, not to be stored in logs</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A secure value for the passed parameter, not to be stored in logs",
        SerializedName = @"secureValue",
        PossibleTypes = new [] { typeof(string) })]
        string SecureValue { get; set; }

    }
    /// a plain text value execution parameter
    internal partial interface IScriptSecureStringExecutionParameterInternal :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionParameterInternal
    {
        /// <summary>A secure value for the passed parameter, not to be stored in logs</summary>
        string SecureValue { get; set; }

    }
}