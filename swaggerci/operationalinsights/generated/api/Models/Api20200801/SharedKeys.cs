namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>The shared keys for a workspace.</summary>
    public partial class SharedKeys :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISharedKeys,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISharedKeysInternal
    {

        /// <summary>Backing field for <see cref="PrimarySharedKey" /> property.</summary>
        private string _primarySharedKey;

        /// <summary>The primary shared key of a workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string PrimarySharedKey { get => this._primarySharedKey; set => this._primarySharedKey = value; }

        /// <summary>Backing field for <see cref="SecondarySharedKey" /> property.</summary>
        private string _secondarySharedKey;

        /// <summary>The secondary shared key of a workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string SecondarySharedKey { get => this._secondarySharedKey; set => this._secondarySharedKey = value; }

        /// <summary>Creates an new <see cref="SharedKeys" /> instance.</summary>
        public SharedKeys()
        {

        }
    }
    /// The shared keys for a workspace.
    public partial interface ISharedKeys :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>The primary shared key of a workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The primary shared key of a workspace.",
        SerializedName = @"primarySharedKey",
        PossibleTypes = new [] { typeof(string) })]
        string PrimarySharedKey { get; set; }
        /// <summary>The secondary shared key of a workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The secondary shared key of a workspace.",
        SerializedName = @"secondarySharedKey",
        PossibleTypes = new [] { typeof(string) })]
        string SecondarySharedKey { get; set; }

    }
    /// The shared keys for a workspace.
    internal partial interface ISharedKeysInternal

    {
        /// <summary>The primary shared key of a workspace.</summary>
        string PrimarySharedKey { get; set; }
        /// <summary>The secondary shared key of a workspace.</summary>
        string SecondarySharedKey { get; set; }

    }
}