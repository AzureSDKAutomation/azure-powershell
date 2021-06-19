namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Uploaded Java source code binary for a deployment</summary>
    public partial class SourceUploadedUserSourceInfo :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ISourceUploadedUserSourceInfo,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ISourceUploadedUserSourceInfoInternal,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUploadedUserSourceInfo"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUploadedUserSourceInfo __uploadedUserSourceInfo = new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.UploadedUserSourceInfo();

        /// <summary>Backing field for <see cref="ArtifactSelector" /> property.</summary>
        private string _artifactSelector;

        /// <summary>
        /// Selector for the artifact to be used for the deployment for multi-module projects. This should be
        /// the relative path to the target module/project.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string ArtifactSelector { get => this._artifactSelector; set => this._artifactSelector = value; }

        /// <summary>Relative path of the storage which stores the source</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inherited)]
        public string RelativePath { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUploadedUserSourceInfoInternal)__uploadedUserSourceInfo).RelativePath; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUploadedUserSourceInfoInternal)__uploadedUserSourceInfo).RelativePath = value ?? null; }

        /// <summary>Type of the source uploaded</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)__uploadedUserSourceInfo).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)__uploadedUserSourceInfo).Type = value ; }

        /// <summary>Version of the source</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inherited)]
        public string Version { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)__uploadedUserSourceInfo).Version; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)__uploadedUserSourceInfo).Version = value ?? null; }

        /// <summary>Creates an new <see cref="SourceUploadedUserSourceInfo" /> instance.</summary>
        public SourceUploadedUserSourceInfo()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__uploadedUserSourceInfo), __uploadedUserSourceInfo);
            await eventListener.AssertObjectIsValid(nameof(__uploadedUserSourceInfo), __uploadedUserSourceInfo);
        }
    }
    /// Uploaded Java source code binary for a deployment
    public partial interface ISourceUploadedUserSourceInfo :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUploadedUserSourceInfo
    {
        /// <summary>
        /// Selector for the artifact to be used for the deployment for multi-module projects. This should be
        /// the relative path to the target module/project.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Selector for the artifact to be used for the deployment for multi-module projects. This should be
        the relative path to the target module/project.",
        SerializedName = @"artifactSelector",
        PossibleTypes = new [] { typeof(string) })]
        string ArtifactSelector { get; set; }

    }
    /// Uploaded Java source code binary for a deployment
    internal partial interface ISourceUploadedUserSourceInfoInternal :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUploadedUserSourceInfoInternal
    {
        /// <summary>
        /// Selector for the artifact to be used for the deployment for multi-module projects. This should be
        /// the relative path to the target module/project.
        /// </summary>
        string ArtifactSelector { get; set; }

    }
}