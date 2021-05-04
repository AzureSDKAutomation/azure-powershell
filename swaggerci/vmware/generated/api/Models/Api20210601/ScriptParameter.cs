namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>An parameter that the script will accept</summary>
    public partial class ScriptParameter :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptParameter,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptParameterInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>User friendly description of the parameter</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string Description { get => this._description; }

        /// <summary>Internal Acessors for Description</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptParameterInternal.Description { get => this._description; set { {_description = value;} } }

        /// <summary>Internal Acessors for Type</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.ScriptParameterTypes? Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptParameterInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Internal Acessors for Visibility</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.VisibilityParameterEnum? Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptParameterInternal.Visibility { get => this._visibility; set { {_visibility = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The parameter name that the script will expect a parameter value for</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.ScriptParameterTypes? _type;

        /// <summary>
        /// The type of parameter the script is expecting. psCredential is a PSCredentialObject
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.ScriptParameterTypes? Type { get => this._type; }

        /// <summary>Backing field for <see cref="Visibility" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.VisibilityParameterEnum? _visibility;

        /// <summary>
        /// Should this parameter be visible to arm and passed in the parameters argument when executing
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.VisibilityParameterEnum? Visibility { get => this._visibility; }

        /// <summary>Creates an new <see cref="ScriptParameter" /> instance.</summary>
        public ScriptParameter()
        {

        }
    }
    /// An parameter that the script will accept
    public partial interface IScriptParameter :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable
    {
        /// <summary>User friendly description of the parameter</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"User friendly description of the parameter",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get;  }
        /// <summary>The parameter name that the script will expect a parameter value for</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The parameter name that the script will expect a parameter value for",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>
        /// The type of parameter the script is expecting. psCredential is a PSCredentialObject
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of parameter the script is expecting. psCredential is a PSCredentialObject",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.ScriptParameterTypes) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.ScriptParameterTypes? Type { get;  }
        /// <summary>
        /// Should this parameter be visible to arm and passed in the parameters argument when executing
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Should this parameter be visible to arm and passed in the parameters argument when executing",
        SerializedName = @"visibility",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.VisibilityParameterEnum) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.VisibilityParameterEnum? Visibility { get;  }

    }
    /// An parameter that the script will accept
    internal partial interface IScriptParameterInternal

    {
        /// <summary>User friendly description of the parameter</summary>
        string Description { get; set; }
        /// <summary>The parameter name that the script will expect a parameter value for</summary>
        string Name { get; set; }
        /// <summary>
        /// The type of parameter the script is expecting. psCredential is a PSCredentialObject
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.ScriptParameterTypes? Type { get; set; }
        /// <summary>
        /// Should this parameter be visible to arm and passed in the parameters argument when executing
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.VisibilityParameterEnum? Visibility { get; set; }

    }
}