namespace Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Extensions;

    public partial class ExtensionVersionListVersionsItem :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionVersionListVersionsItem,
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionVersionListVersionsItemInternal
    {

        /// <summary>Backing field for <see cref="ReleaseTrain" /> property.</summary>
        private string _releaseTrain;

        /// <summary>The release train for this Extension Type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public string ReleaseTrain { get => this._releaseTrain; set => this._releaseTrain = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string[] _version;

        /// <summary>Versions available for this Extension Type and release train</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public string[] Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="ExtensionVersionListVersionsItem" /> instance.</summary>
        public ExtensionVersionListVersionsItem()
        {

        }
    }
    public partial interface IExtensionVersionListVersionsItem :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.IJsonSerializable
    {
        /// <summary>The release train for this Extension Type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The release train for this Extension Type",
        SerializedName = @"releaseTrain",
        PossibleTypes = new [] { typeof(string) })]
        string ReleaseTrain { get; set; }
        /// <summary>Versions available for this Extension Type and release train</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Versions available for this Extension Type and release train",
        SerializedName = @"versions",
        PossibleTypes = new [] { typeof(string) })]
        string[] Version { get; set; }

    }
    internal partial interface IExtensionVersionListVersionsItemInternal

    {
        /// <summary>The release train for this Extension Type</summary>
        string ReleaseTrain { get; set; }
        /// <summary>Versions available for this Extension Type and release train</summary>
        string[] Version { get; set; }

    }
}