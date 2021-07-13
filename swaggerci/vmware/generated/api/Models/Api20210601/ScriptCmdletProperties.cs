namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>Properties of a pre-canned script</summary>
    public partial class ScriptCmdletProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptCmdletProperties,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptCmdletPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Description of the scripts functionality</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string Description { get => this._description; }

        /// <summary>Internal Acessors for Description</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptCmdletPropertiesInternal.Description { get => this._description; set { {_description = value;} } }

        /// <summary>Internal Acessors for Parameter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptParameter[] Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptCmdletPropertiesInternal.Parameter { get => this._parameter; set { {_parameter = value;} } }

        /// <summary>Internal Acessors for Timeout</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptCmdletPropertiesInternal.Timeout { get => this._timeout; set { {_timeout = value;} } }

        /// <summary>Backing field for <see cref="Parameter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptParameter[] _parameter;

        /// <summary>Parameters the script will accept</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptParameter[] Parameter { get => this._parameter; }

        /// <summary>Backing field for <see cref="Timeout" /> property.</summary>
        private string _timeout;

        /// <summary>Recommended time limit for execution</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string Timeout { get => this._timeout; }

        /// <summary>Creates an new <see cref="ScriptCmdletProperties" /> instance.</summary>
        public ScriptCmdletProperties()
        {

        }
    }
    /// Properties of a pre-canned script
    public partial interface IScriptCmdletProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable
    {
        /// <summary>Description of the scripts functionality</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Description of the scripts functionality",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get;  }
        /// <summary>Parameters the script will accept</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Parameters the script will accept",
        SerializedName = @"parameters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptParameter) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptParameter[] Parameter { get;  }
        /// <summary>Recommended time limit for execution</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Recommended time limit for execution",
        SerializedName = @"timeout",
        PossibleTypes = new [] { typeof(string) })]
        string Timeout { get;  }

    }
    /// Properties of a pre-canned script
    internal partial interface IScriptCmdletPropertiesInternal

    {
        /// <summary>Description of the scripts functionality</summary>
        string Description { get; set; }
        /// <summary>Parameters the script will accept</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptParameter[] Parameter { get; set; }
        /// <summary>Recommended time limit for execution</summary>
        string Timeout { get; set; }

    }
}