namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>An instance of a script executed by a user - custom or AVS</summary>
    public partial class ScriptExecution :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecution,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionInternal,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.Resource();

        /// <summary>Standard error output stream from the powershell execution</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string[] Error { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).Error; }

        /// <summary>
        /// Error message if the script was able to run, but if the script itself had errors or powershell threw an exception
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string FailureReason { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).FailureReason; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).FailureReason = value ?? null; }

        /// <summary>Time the script execution was finished</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public global::System.DateTime? FinishedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).FinishedAt; }

        /// <summary>
        /// Parameters that will be hidden/not visible to ARM, such as passwords and credentials
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionParameter[] HiddenParameter { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).HiddenParameter; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).HiddenParameter = value ?? null /* arrayOf */; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)__resource).Id; }

        /// <summary>Standard information out stream from the powershell execution</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string[] Information { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).Information; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for Error</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionInternal.Error { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).Error; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).Error = value; }

        /// <summary>Internal Acessors for FinishedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionInternal.FinishedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).FinishedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).FinishedAt = value; }

        /// <summary>Internal Acessors for Information</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionInternal.Information { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).Information; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).Information = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionProperties Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ScriptExecutionProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.ScriptExecutionProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for StartedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionInternal.StartedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).StartedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).StartedAt = value; }

        /// <summary>Internal Acessors for SubmittedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionInternal.SubmittedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).SubmittedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).SubmittedAt = value; }

        /// <summary>Internal Acessors for Warning</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionInternal.Warning { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).Warning; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).Warning = value; }

        /// <summary>Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)__resource).Name; }

        /// <summary>User-defined dictionary.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesNamedOutputs NamedOutput { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).NamedOutput; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).NamedOutput = value ?? null /* model class */; }

        /// <summary>Standard output stream from the powershell execution</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string[] Output { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).Output; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).Output = value ?? null /* arrayOf */; }

        /// <summary>Parameters the script will accept</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionParameter[] Parameter { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).Parameter; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).Parameter = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionProperties _property;

        /// <summary>The properties of a script execution resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ScriptExecutionProperties()); set => this._property = value; }

        /// <summary>The state of the script execution resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.ScriptExecutionProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Time to live for the resource. If not provided, will be available for 60 days</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string Retention { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).Retention; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).Retention = value ?? null; }

        /// <summary>A reference to the script cmdlet resource if user is running a AVS script</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string ScriptCmdletId { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).ScriptCmdletId; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).ScriptCmdletId = value ?? null; }

        /// <summary>Time the script execution was started</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public global::System.DateTime? StartedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).StartedAt; }

        /// <summary>Time the script execution was submitted</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public global::System.DateTime? SubmittedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).SubmittedAt; }

        /// <summary>Time limit for execution</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string Timeout { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).Timeout; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).Timeout = value ?? null; }

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)__resource).Type; }

        /// <summary>Standard warning out stream from the powershell execution</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string[] Warning { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesInternal)Property).Warning; }

        /// <summary>Creates an new <see cref="ScriptExecution" /> instance.</summary>
        public ScriptExecution()
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
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// An instance of a script executed by a user - custom or AVS
    public partial interface IScriptExecution :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResource
    {
        /// <summary>Standard error output stream from the powershell execution</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Standard error output stream from the powershell execution",
        SerializedName = @"errors",
        PossibleTypes = new [] { typeof(string) })]
        string[] Error { get;  }
        /// <summary>
        /// Error message if the script was able to run, but if the script itself had errors or powershell threw an exception
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Error message if the script was able to run, but if the script itself had errors or powershell threw an exception",
        SerializedName = @"failureReason",
        PossibleTypes = new [] { typeof(string) })]
        string FailureReason { get; set; }
        /// <summary>Time the script execution was finished</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Time the script execution was finished",
        SerializedName = @"finishedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? FinishedAt { get;  }
        /// <summary>
        /// Parameters that will be hidden/not visible to ARM, such as passwords and credentials
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Parameters that will be hidden/not visible to ARM, such as passwords and credentials",
        SerializedName = @"hiddenParameters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionParameter) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionParameter[] HiddenParameter { get; set; }
        /// <summary>Standard information out stream from the powershell execution</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Standard information out stream from the powershell execution",
        SerializedName = @"information",
        PossibleTypes = new [] { typeof(string) })]
        string[] Information { get;  }
        /// <summary>User-defined dictionary.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"User-defined dictionary.",
        SerializedName = @"namedOutputs",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesNamedOutputs) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesNamedOutputs NamedOutput { get; set; }
        /// <summary>Standard output stream from the powershell execution</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Standard output stream from the powershell execution",
        SerializedName = @"output",
        PossibleTypes = new [] { typeof(string) })]
        string[] Output { get; set; }
        /// <summary>Parameters the script will accept</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Parameters the script will accept",
        SerializedName = @"parameters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionParameter) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionParameter[] Parameter { get; set; }
        /// <summary>The state of the script execution resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The state of the script execution resource",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.ScriptExecutionProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.ScriptExecutionProvisioningState? ProvisioningState { get;  }
        /// <summary>Time to live for the resource. If not provided, will be available for 60 days</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Time to live for the resource. If not provided, will be available for 60 days",
        SerializedName = @"retention",
        PossibleTypes = new [] { typeof(string) })]
        string Retention { get; set; }
        /// <summary>A reference to the script cmdlet resource if user is running a AVS script</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A reference to the script cmdlet resource if user is running a AVS script",
        SerializedName = @"scriptCmdletId",
        PossibleTypes = new [] { typeof(string) })]
        string ScriptCmdletId { get; set; }
        /// <summary>Time the script execution was started</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Time the script execution was started",
        SerializedName = @"startedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartedAt { get;  }
        /// <summary>Time the script execution was submitted</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Time the script execution was submitted",
        SerializedName = @"submittedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SubmittedAt { get;  }
        /// <summary>Time limit for execution</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Time limit for execution",
        SerializedName = @"timeout",
        PossibleTypes = new [] { typeof(string) })]
        string Timeout { get; set; }
        /// <summary>Standard warning out stream from the powershell execution</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Standard warning out stream from the powershell execution",
        SerializedName = @"warnings",
        PossibleTypes = new [] { typeof(string) })]
        string[] Warning { get;  }

    }
    /// An instance of a script executed by a user - custom or AVS
    internal partial interface IScriptExecutionInternal :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal
    {
        /// <summary>Standard error output stream from the powershell execution</summary>
        string[] Error { get; set; }
        /// <summary>
        /// Error message if the script was able to run, but if the script itself had errors or powershell threw an exception
        /// </summary>
        string FailureReason { get; set; }
        /// <summary>Time the script execution was finished</summary>
        global::System.DateTime? FinishedAt { get; set; }
        /// <summary>
        /// Parameters that will be hidden/not visible to ARM, such as passwords and credentials
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionParameter[] HiddenParameter { get; set; }
        /// <summary>Standard information out stream from the powershell execution</summary>
        string[] Information { get; set; }
        /// <summary>User-defined dictionary.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionPropertiesNamedOutputs NamedOutput { get; set; }
        /// <summary>Standard output stream from the powershell execution</summary>
        string[] Output { get; set; }
        /// <summary>Parameters the script will accept</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionParameter[] Parameter { get; set; }
        /// <summary>The properties of a script execution resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptExecutionProperties Property { get; set; }
        /// <summary>The state of the script execution resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.ScriptExecutionProvisioningState? ProvisioningState { get; set; }
        /// <summary>Time to live for the resource. If not provided, will be available for 60 days</summary>
        string Retention { get; set; }
        /// <summary>A reference to the script cmdlet resource if user is running a AVS script</summary>
        string ScriptCmdletId { get; set; }
        /// <summary>Time the script execution was started</summary>
        global::System.DateTime? StartedAt { get; set; }
        /// <summary>Time the script execution was submitted</summary>
        global::System.DateTime? SubmittedAt { get; set; }
        /// <summary>Time limit for execution</summary>
        string Timeout { get; set; }
        /// <summary>Standard warning out stream from the powershell execution</summary>
        string[] Warning { get; set; }

    }
}