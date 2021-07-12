namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Custom container payload</summary>
    public partial class CustomContainer :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ICustomContainer,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ICustomContainerInternal
    {

        /// <summary>Backing field for <see cref="Arg" /> property.</summary>
        private string[] _arg;

        /// <summary>
        /// Arguments to the entrypoint. The docker image's CMD is used if this is not provided.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string[] Arg { get => this._arg; set => this._arg = value; }

        /// <summary>Backing field for <see cref="Command" /> property.</summary>
        private string[] _command;

        /// <summary>
        /// Entrypoint array. Not executed within a shell. The docker image's ENTRYPOINT is used if this is not provided.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string[] Command { get => this._command; set => this._command = value; }

        /// <summary>Backing field for <see cref="ContainerImage" /> property.</summary>
        private string _containerImage;

        /// <summary>
        /// Container image of the custom container. This should be in the form of <repository>:<tag> without the server name of the
        /// registry
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string ContainerImage { get => this._containerImage; set => this._containerImage = value; }

        /// <summary>Backing field for <see cref="ImageRegistryCredential" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IImageRegistryCredential _imageRegistryCredential;

        /// <summary>Credential of the image registry</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IImageRegistryCredential ImageRegistryCredential { get => (this._imageRegistryCredential = this._imageRegistryCredential ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ImageRegistryCredential()); set => this._imageRegistryCredential = value; }

        /// <summary>The password of the image registry credential</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string ImageRegistryCredentialPassword { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IImageRegistryCredentialInternal)ImageRegistryCredential).Password; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IImageRegistryCredentialInternal)ImageRegistryCredential).Password = value ?? null; }

        /// <summary>The username of the image registry credential</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string ImageRegistryCredentialUsername { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IImageRegistryCredentialInternal)ImageRegistryCredential).Username; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IImageRegistryCredentialInternal)ImageRegistryCredential).Username = value ?? null; }

        /// <summary>Internal Acessors for ImageRegistryCredential</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IImageRegistryCredential Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ICustomContainerInternal.ImageRegistryCredential { get => (this._imageRegistryCredential = this._imageRegistryCredential ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ImageRegistryCredential()); set { {_imageRegistryCredential = value;} } }

        /// <summary>Backing field for <see cref="Server" /> property.</summary>
        private string _server;

        /// <summary>The name of the registry that contains the container image</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string Server { get => this._server; set => this._server = value; }

        /// <summary>Creates an new <see cref="CustomContainer" /> instance.</summary>
        public CustomContainer()
        {

        }
    }
    /// Custom container payload
    public partial interface ICustomContainer :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Arguments to the entrypoint. The docker image's CMD is used if this is not provided.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Arguments to the entrypoint. The docker image's CMD is used if this is not provided.",
        SerializedName = @"args",
        PossibleTypes = new [] { typeof(string) })]
        string[] Arg { get; set; }
        /// <summary>
        /// Entrypoint array. Not executed within a shell. The docker image's ENTRYPOINT is used if this is not provided.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Entrypoint array. Not executed within a shell. The docker image's ENTRYPOINT is used if this is not provided.",
        SerializedName = @"command",
        PossibleTypes = new [] { typeof(string) })]
        string[] Command { get; set; }
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
        string ContainerImage { get; set; }
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
        /// <summary>The name of the registry that contains the container image</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the registry that contains the container image",
        SerializedName = @"server",
        PossibleTypes = new [] { typeof(string) })]
        string Server { get; set; }

    }
    /// Custom container payload
    internal partial interface ICustomContainerInternal

    {
        /// <summary>
        /// Arguments to the entrypoint. The docker image's CMD is used if this is not provided.
        /// </summary>
        string[] Arg { get; set; }
        /// <summary>
        /// Entrypoint array. Not executed within a shell. The docker image's ENTRYPOINT is used if this is not provided.
        /// </summary>
        string[] Command { get; set; }
        /// <summary>
        /// Container image of the custom container. This should be in the form of <repository>:<tag> without the server name of the
        /// registry
        /// </summary>
        string ContainerImage { get; set; }
        /// <summary>Credential of the image registry</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IImageRegistryCredential ImageRegistryCredential { get; set; }
        /// <summary>The password of the image registry credential</summary>
        string ImageRegistryCredentialPassword { get; set; }
        /// <summary>The username of the image registry credential</summary>
        string ImageRegistryCredentialUsername { get; set; }
        /// <summary>The name of the registry that contains the container image</summary>
        string Server { get; set; }

    }
}