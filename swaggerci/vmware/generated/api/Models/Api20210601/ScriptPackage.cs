namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>Script Package resources available for execution</summary>
    public partial class ScriptPackage :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptPackage,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptPackageInternal,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.Resource();

        /// <summary>User friendly description of the package</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptPackagePropertiesInternal)Property).Description; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)__resource).Id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for Description</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptPackageInternal.Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptPackagePropertiesInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptPackagePropertiesInternal)Property).Description = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptPackageProperties Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptPackageInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ScriptPackageProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Version</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptPackageInternal.Version { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptPackagePropertiesInternal)Property).Version; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptPackagePropertiesInternal)Property).Version = value; }

        /// <summary>Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptPackageProperties _property;

        /// <summary>ScriptPackage resource properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptPackageProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ScriptPackageProperties()); set => this._property = value; }

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)__resource).Type; }

        /// <summary>Module version</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Inlined)]
        public string Version { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptPackagePropertiesInternal)Property).Version; }

        /// <summary>Creates an new <see cref="ScriptPackage" /> instance.</summary>
        public ScriptPackage()
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
    /// Script Package resources available for execution
    public partial interface IScriptPackage :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResource
    {
        /// <summary>User friendly description of the package</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"User friendly description of the package",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get;  }
        /// <summary>Module version</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Module version",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get;  }

    }
    /// Script Package resources available for execution
    internal partial interface IScriptPackageInternal :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal
    {
        /// <summary>User friendly description of the package</summary>
        string Description { get; set; }
        /// <summary>ScriptPackage resource properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IScriptPackageProperties Property { get; set; }
        /// <summary>Module version</summary>
        string Version { get; set; }

    }
}