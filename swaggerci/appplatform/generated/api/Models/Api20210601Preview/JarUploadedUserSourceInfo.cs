namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Uploaded Jar binary for a deployment</summary>
    public partial class JarUploadedUserSourceInfo :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IJarUploadedUserSourceInfo,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IJarUploadedUserSourceInfoInternal,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUploadedUserSourceInfo"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUploadedUserSourceInfo __uploadedUserSourceInfo = new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.UploadedUserSourceInfo();

        /// <summary>Relative path of the storage which stores the source</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inherited)]
        public string RelativePath { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUploadedUserSourceInfoInternal)__uploadedUserSourceInfo).RelativePath; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUploadedUserSourceInfoInternal)__uploadedUserSourceInfo).RelativePath = value ?? null; }

        /// <summary>Backing field for <see cref="RuntimeVersion" /> property.</summary>
        private string _runtimeVersion;

        /// <summary>Runtime version of the Jar file</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string RuntimeVersion { get => this._runtimeVersion; set => this._runtimeVersion = value; }

        /// <summary>Type of the source uploaded</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)__uploadedUserSourceInfo).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)__uploadedUserSourceInfo).Type = value ; }

        /// <summary>Version of the source</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inherited)]
        public string Version { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)__uploadedUserSourceInfo).Version; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal)__uploadedUserSourceInfo).Version = value ?? null; }

        /// <summary>Creates an new <see cref="JarUploadedUserSourceInfo" /> instance.</summary>
        public JarUploadedUserSourceInfo()
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
    /// Uploaded Jar binary for a deployment
    public partial interface IJarUploadedUserSourceInfo :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUploadedUserSourceInfo
    {
        /// <summary>Runtime version of the Jar file</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Runtime version of the Jar file",
        SerializedName = @"runtimeVersion",
        PossibleTypes = new [] { typeof(string) })]
        string RuntimeVersion { get; set; }

    }
    /// Uploaded Jar binary for a deployment
    internal partial interface IJarUploadedUserSourceInfoInternal :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUploadedUserSourceInfoInternal
    {
        /// <summary>Runtime version of the Jar file</summary>
        string RuntimeVersion { get; set; }

    }
}