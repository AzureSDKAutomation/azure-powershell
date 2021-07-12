namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Source information for a deployment</summary>
    public partial class UserSourceInfo :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfo,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal
    {

        /// <summary>Backing field for <see cref="ArtifactSelector" /> property.</summary>
        private string _artifactSelector;

        /// <summary>
        /// Selector for the artifact to be used for the deployment for multi-module projects. This should be
        /// the relative path to the target module/project.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string ArtifactSelector { get => this._artifactSelector; set => this._artifactSelector = value; }

        /// <summary>Backing field for <see cref="CustomContainer" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ICustomContainer _customContainer;

        /// <summary>Custom container payload</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ICustomContainer CustomContainer { get => (this._customContainer = this._customContainer ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.CustomContainer()); set => this._customContainer = value; }

        /// <summary>
        /// Arguments to the entrypoint. The docker image's CMD is used if this is not provided.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string[] CustomContainerArg { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ICustomContainerInternal)CustomContainer).Arg; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ICustomContainerInternal)CustomContainer).Arg = value ?? null /* arrayOf */; }

        /// <summary>
        /// Entrypoint array. Not executed within a shell. The docker image's ENTRYPOINT is used if this is not provided.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string[] CustomContainerCommand { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ICustomContainerInternal)CustomContainer).Command; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ICustomContainerInternal)CustomContainer).Command = value ?? null /* arrayOf */; }

        /// <summary>
        /// Container image of the custom container. This should be in the form of <repository>:<tag> without the server name of the
        /// registry
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string CustomContainerImage { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ICustomContainerInternal)CustomContainer).ContainerImage; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ICustomContainerInternal)CustomContainer).ContainerImage = value ?? null; }

        /// <summary>The name of the registry that contains the container image</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string CustomContainerServer { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ICustomContainerInternal)CustomContainer).Server; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ICustomContainerInternal)CustomContainer).Server = value ?? null; }

        /// <summary>The password of the image registry credential</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string ImageRegistryCredentialPassword { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ICustomContainerInternal)CustomContainer).ImageRegistryCredentialPassword; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ICustomContainerInternal)CustomContainer).ImageRegistryCredentialPassword = value ?? null; }

        /// <summary>The username of the image registry credential</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string ImageRegistryCredentialUsername { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ICustomContainerInternal)CustomContainer).ImageRegistryCredentialUsername; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ICustomContainerInternal)CustomContainer).ImageRegistryCredentialUsername = value ?? null; }

        /// <summary>Internal Acessors for CustomContainer</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ICustomContainer Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal.CustomContainer { get => (this._customContainer = this._customContainer ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.CustomContainer()); set { {_customContainer = value;} } }

        /// <summary>Internal Acessors for CustomContainerImageRegistryCredential</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IImageRegistryCredential Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IUserSourceInfoInternal.CustomContainerImageRegistryCredential { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ICustomContainerInternal)CustomContainer).ImageRegistryCredential; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ICustomContainerInternal)CustomContainer).ImageRegistryCredential = value; }

        /// <summary>Backing field for <see cref="RelativePath" /> property.</summary>
        private string _relativePath;

        /// <summary>Relative path of the storage which stores the source</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string RelativePath { get => this._relativePath; set => this._relativePath = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.UserSourceType? _type;

        /// <summary>Type of the source uploaded</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.UserSourceType? Type { get => this._type; set => this._type = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>Version of the source</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="UserSourceInfo" /> instance.</summary>
        public UserSourceInfo()
        {

        }
    }
    /// Source information for a deployment
    public partial interface IUserSourceInfo :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable
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
        /// <summary>
        /// Arguments to the entrypoint. The docker image's CMD is used if this is not provided.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Arguments to the entrypoint. The docker image's CMD is used if this is not provided.",
        SerializedName = @"args",
        PossibleTypes = new [] { typeof(string) })]
        string[] CustomContainerArg { get; set; }
        /// <summary>
        /// Entrypoint array. Not executed within a shell. The docker image's ENTRYPOINT is used if this is not provided.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Entrypoint array. Not executed within a shell. The docker image's ENTRYPOINT is used if this is not provided.",
        SerializedName = @"command",
        PossibleTypes = new [] { typeof(string) })]
        string[] CustomContainerCommand { get; set; }
        /// <summary>
        /// Container image of the custom container. This should be in the form of <repository>:<tag> without the server name of the
        /// registry
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Container image of the custom container. This should be in the form of <repository>:<tag> without the server name of the registry",
        SerializedName = @"containerImage",
        PossibleTypes = new [] { typeof(string) })]
        string CustomContainerImage { get; set; }
        /// <summary>The name of the registry that contains the container image</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the registry that contains the container image",
        SerializedName = @"server",
        PossibleTypes = new [] { typeof(string) })]
        string CustomContainerServer { get; set; }
        /// <summary>The password of the image registry credential</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The password of the image registry credential",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(string) })]
        string ImageRegistryCredentialPassword { get; set; }
        /// <summary>The username of the image registry credential</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The username of the image registry credential",
        SerializedName = @"username",
        PossibleTypes = new [] { typeof(string) })]
        string ImageRegistryCredentialUsername { get; set; }
        /// <summary>Relative path of the storage which stores the source</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Relative path of the storage which stores the source",
        SerializedName = @"relativePath",
        PossibleTypes = new [] { typeof(string) })]
        string RelativePath { get; set; }
        /// <summary>Type of the source uploaded</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the source uploaded",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.UserSourceType) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.UserSourceType? Type { get; set; }
        /// <summary>Version of the source</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Version of the source",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// Source information for a deployment
    internal partial interface IUserSourceInfoInternal

    {
        /// <summary>
        /// Selector for the artifact to be used for the deployment for multi-module projects. This should be
        /// the relative path to the target module/project.
        /// </summary>
        string ArtifactSelector { get; set; }
        /// <summary>Custom container payload</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ICustomContainer CustomContainer { get; set; }
        /// <summary>
        /// Arguments to the entrypoint. The docker image's CMD is used if this is not provided.
        /// </summary>
        string[] CustomContainerArg { get; set; }
        /// <summary>
        /// Entrypoint array. Not executed within a shell. The docker image's ENTRYPOINT is used if this is not provided.
        /// </summary>
        string[] CustomContainerCommand { get; set; }
        /// <summary>
        /// Container image of the custom container. This should be in the form of <repository>:<tag> without the server name of the
        /// registry
        /// </summary>
        string CustomContainerImage { get; set; }
        /// <summary>Credential of the image registry</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IImageRegistryCredential CustomContainerImageRegistryCredential { get; set; }
        /// <summary>The name of the registry that contains the container image</summary>
        string CustomContainerServer { get; set; }
        /// <summary>The password of the image registry credential</summary>
        string ImageRegistryCredentialPassword { get; set; }
        /// <summary>The username of the image registry credential</summary>
        string ImageRegistryCredentialUsername { get; set; }
        /// <summary>Relative path of the storage which stores the source</summary>
        string RelativePath { get; set; }
        /// <summary>Type of the source uploaded</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.UserSourceType? Type { get; set; }
        /// <summary>Version of the source</summary>
        string Version { get; set; }

    }
}