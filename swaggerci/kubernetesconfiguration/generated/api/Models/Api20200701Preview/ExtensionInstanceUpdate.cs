namespace Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Extensions;

    /// <summary>Update Extension Instance request object.</summary>
    public partial class ExtensionInstanceUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IExtensionInstanceUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IExtensionInstanceUpdateInternal
    {

        /// <summary>
        /// Flag to note if this instance participates in Extension Lifecycle Management or not.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public bool? AutoUpgradeMinorVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IExtensionInstanceUpdatePropertiesInternal)Property).AutoUpgradeMinorVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IExtensionInstanceUpdatePropertiesInternal)Property).AutoUpgradeMinorVersion = value ?? default(bool); }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IExtensionInstanceUpdateProperties Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IExtensionInstanceUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.ExtensionInstanceUpdateProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IExtensionInstanceUpdateProperties _property;

        /// <summary>Properties to update an Extension Instance resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IExtensionInstanceUpdateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.ExtensionInstanceUpdateProperties()); set => this._property = value; }

        /// <summary>
        /// ReleaseTrain this extension instance participates in for auto-upgrade (e.g. Stable, Preview, etc.) - only if autoUpgradeMinorVersion
        /// is 'true'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public string ReleaseTrain { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IExtensionInstanceUpdatePropertiesInternal)Property).ReleaseTrain; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IExtensionInstanceUpdatePropertiesInternal)Property).ReleaseTrain = value ?? null; }

        /// <summary>
        /// Version number of extension, to 'pin' to a specific version. autoUpgradeMinorVersion must be 'false'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public string Version { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IExtensionInstanceUpdatePropertiesInternal)Property).Version; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IExtensionInstanceUpdatePropertiesInternal)Property).Version = value ?? null; }

        /// <summary>Creates an new <see cref="ExtensionInstanceUpdate" /> instance.</summary>
        public ExtensionInstanceUpdate()
        {

        }
    }
    /// Update Extension Instance request object.
    public partial interface IExtensionInstanceUpdate :
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
    /// Update Extension Instance request object.
    internal partial interface IExtensionInstanceUpdateInternal

    {
        /// <summary>
        /// Flag to note if this instance participates in Extension Lifecycle Management or not.
        /// </summary>
        bool? AutoUpgradeMinorVersion { get; set; }
        /// <summary>Properties to update an Extension Instance resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IExtensionInstanceUpdateProperties Property { get; set; }
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