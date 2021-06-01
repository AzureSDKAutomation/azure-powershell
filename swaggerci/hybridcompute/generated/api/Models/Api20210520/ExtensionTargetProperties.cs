namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Extensions;

    /// <summary>Describes the Machine Extension Target Version Properties</summary>
    public partial class ExtensionTargetProperties :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IExtensionTargetProperties,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IExtensionTargetPropertiesInternal
    {

        /// <summary>Backing field for <see cref="TargetVersion" /> property.</summary>
        private string _targetVersion;

        /// <summary>Properties for the specified Extension to Upgrade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public string TargetVersion { get => this._targetVersion; set => this._targetVersion = value; }

        /// <summary>Creates an new <see cref="ExtensionTargetProperties" /> instance.</summary>
        public ExtensionTargetProperties()
        {

        }
    }
    /// Describes the Machine Extension Target Version Properties
    public partial interface IExtensionTargetProperties :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IJsonSerializable
    {
        /// <summary>Properties for the specified Extension to Upgrade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Properties for the specified Extension to Upgrade.",
        SerializedName = @"targetVersion",
        PossibleTypes = new [] { typeof(string) })]
        string TargetVersion { get; set; }

    }
    /// Describes the Machine Extension Target Version Properties
    internal partial interface IExtensionTargetPropertiesInternal

    {
        /// <summary>Properties for the specified Extension to Upgrade.</summary>
        string TargetVersion { get; set; }

    }
}