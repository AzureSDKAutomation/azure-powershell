namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Extensions;

    /// <summary>Describes the Machine Extension Upgrade Properties</summary>
    public partial class MachineExtensionUpgrade :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionUpgrade,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionUpgradeInternal
    {

        /// <summary>Backing field for <see cref="ExtensionTarget" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IExtensionTarget _extensionTarget;

        /// <summary>Describes the Extension Target Properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IExtensionTarget ExtensionTarget { get => (this._extensionTarget = this._extensionTarget ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.ExtensionTarget()); set => this._extensionTarget = value; }

        /// <summary>Creates an new <see cref="MachineExtensionUpgrade" /> instance.</summary>
        public MachineExtensionUpgrade()
        {

        }
    }
    /// Describes the Machine Extension Upgrade Properties
    public partial interface IMachineExtensionUpgrade :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IJsonSerializable
    {
        /// <summary>Describes the Extension Target Properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Describes the Extension Target Properties.",
        SerializedName = @"extensionTargets",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IExtensionTarget) })]
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IExtensionTarget ExtensionTarget { get; set; }

    }
    /// Describes the Machine Extension Upgrade Properties
    internal partial interface IMachineExtensionUpgradeInternal

    {
        /// <summary>Describes the Extension Target Properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IExtensionTarget ExtensionTarget { get; set; }

    }
}