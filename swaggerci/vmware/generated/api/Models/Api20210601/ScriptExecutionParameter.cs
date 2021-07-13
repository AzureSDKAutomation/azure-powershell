namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>The arguments passed in to the execution</summary>
    public partial class ScriptExecutionParameter :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionParameter,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionParameterInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The parameter name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.ScriptExecutionParameterType _type;

        /// <summary>The type of execution parameter</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.ScriptExecutionParameterType Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="ScriptExecutionParameter" /> instance.</summary>
        public ScriptExecutionParameter()
        {

        }
    }
    /// The arguments passed in to the execution
    public partial interface IScriptExecutionParameter :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable
    {
        /// <summary>The parameter name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The parameter name",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The type of execution parameter</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The type of execution parameter",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.ScriptExecutionParameterType) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.ScriptExecutionParameterType Type { get; set; }

    }
    /// The arguments passed in to the execution
    internal partial interface IScriptExecutionParameterInternal

    {
        /// <summary>The parameter name</summary>
        string Name { get; set; }
        /// <summary>The type of execution parameter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.ScriptExecutionParameterType Type { get; set; }

    }
}