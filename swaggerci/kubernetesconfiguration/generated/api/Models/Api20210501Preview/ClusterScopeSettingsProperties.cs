namespace Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Extensions;

    /// <summary>Extension scope settings</summary>
    public partial class ClusterScopeSettingsProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IClusterScopeSettingsProperties,
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IClusterScopeSettingsPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AllowMultipleInstance" /> property.</summary>
        private bool? _allowMultipleInstance;

        /// <summary>Describes if multiple instances of the extension are allowed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public bool? AllowMultipleInstance { get => this._allowMultipleInstance; set => this._allowMultipleInstance = value; }

        /// <summary>Backing field for <see cref="DefaultReleaseNamespace" /> property.</summary>
        private string _defaultReleaseNamespace;

        /// <summary>Default extension release namespace</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public string DefaultReleaseNamespace { get => this._defaultReleaseNamespace; set => this._defaultReleaseNamespace = value; }

        /// <summary>Creates an new <see cref="ClusterScopeSettingsProperties" /> instance.</summary>
        public ClusterScopeSettingsProperties()
        {

        }
    }
    /// Extension scope settings
    public partial interface IClusterScopeSettingsProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.IJsonSerializable
    {
        /// <summary>Describes if multiple instances of the extension are allowed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Describes if multiple instances of the extension are allowed",
        SerializedName = @"allowMultipleInstances",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AllowMultipleInstance { get; set; }
        /// <summary>Default extension release namespace</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Default extension release namespace",
        SerializedName = @"defaultReleaseNamespace",
        PossibleTypes = new [] { typeof(string) })]
        string DefaultReleaseNamespace { get; set; }

    }
    /// Extension scope settings
    internal partial interface IClusterScopeSettingsPropertiesInternal

    {
        /// <summary>Describes if multiple instances of the extension are allowed</summary>
        bool? AllowMultipleInstance { get; set; }
        /// <summary>Default extension release namespace</summary>
        string DefaultReleaseNamespace { get; set; }

    }
}