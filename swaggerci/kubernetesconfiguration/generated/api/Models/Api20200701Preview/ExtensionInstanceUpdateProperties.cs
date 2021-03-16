namespace Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Extensions;

    /// <summary>Properties to update an Extension Instance resource</summary>
    public partial class ExtensionInstanceUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IExtensionInstanceUpdateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IExtensionInstanceUpdatePropertiesInternal
    {

        /// <summary>Backing field for <see cref="AutoUpgradeMinorVersion" /> property.</summary>
        private bool? _autoUpgradeMinorVersion;

        /// <summary>
        /// Flag to note if this instance participates in Extension Lifecycle Management or not.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public bool? AutoUpgradeMinorVersion { get => this._autoUpgradeMinorVersion; set => this._autoUpgradeMinorVersion = value; }

        /// <summary>Backing field for <see cref="ReleaseTrain" /> property.</summary>
        private string _releaseTrain;

        /// <summary>
        /// ReleaseTrain this extension instance participates in for auto-upgrade (e.g. Stable, Preview, etc.) - only if autoUpgradeMinorVersion
        /// is 'true'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public string ReleaseTrain { get => this._releaseTrain; set => this._releaseTrain = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>
        /// Version number of extension, to 'pin' to a specific version. autoUpgradeMinorVersion must be 'false'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="ExtensionInstanceUpdateProperties" /> instance.</summary>
        public ExtensionInstanceUpdateProperties()
        {

        }
    }
    /// Properties to update an Extension Instance resource
    public partial interface IExtensionInstanceUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Flag to note if this instance participates in Extension Lifecycle Management or not.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag to note if this instance participates in Extension Lifecycle Management or not.",
        SerializedName = @"autoUpgradeMinorVersion",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AutoUpgradeMinorVersion { get; set; }
        /// <summary>
        /// ReleaseTrain this extension instance participates in for auto-upgrade (e.g. Stable, Preview, etc.) - only if autoUpgradeMinorVersion
        /// is 'true'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ReleaseTrain this extension instance participates in for auto-upgrade (e.g. Stable, Preview, etc.) - only if autoUpgradeMinorVersion is 'true'.",
        SerializedName = @"releaseTrain",
        PossibleTypes = new [] { typeof(string) })]
        string ReleaseTrain { get; set; }
        /// <summary>
        /// Version number of extension, to 'pin' to a specific version. autoUpgradeMinorVersion must be 'false'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Version number of extension, to 'pin' to a specific version.  autoUpgradeMinorVersion must be 'false'.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// Properties to update an Extension Instance resource
    internal partial interface IExtensionInstanceUpdatePropertiesInternal

    {
        /// <summary>
        /// Flag to note if this instance participates in Extension Lifecycle Management or not.
        /// </summary>
        bool? AutoUpgradeMinorVersion { get; set; }
        /// <summary>
        /// ReleaseTrain this extension instance participates in for auto-upgrade (e.g. Stable, Preview, etc.) - only if autoUpgradeMinorVersion
        /// is 'true'.
        /// </summary>
        string ReleaseTrain { get; set; }
        /// <summary>
        /// Version number of extension, to 'pin' to a specific version. autoUpgradeMinorVersion must be 'false'.
        /// </summary>
        string Version { get; set; }

    }
}