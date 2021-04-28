namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>The key vault properties.</summary>
    public partial class KeyVaultProperties :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IKeyVaultProperties,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IKeyVaultPropertiesInternal
    {

        /// <summary>Backing field for <see cref="KeyName" /> property.</summary>
        private string _keyName;

        /// <summary>The name of the key associated with the Log Analytics cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string KeyName { get => this._keyName; set => this._keyName = value; }

        /// <summary>Backing field for <see cref="KeyRsaSize" /> property.</summary>
        private int? _keyRsaSize;

        /// <summary>Selected key minimum required size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public int? KeyRsaSize { get => this._keyRsaSize; set => this._keyRsaSize = value; }

        /// <summary>Backing field for <see cref="KeyVaultUri" /> property.</summary>
        private string _keyVaultUri;

        /// <summary>
        /// The Key Vault uri which holds they key associated with the Log Analytics cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string KeyVaultUri { get => this._keyVaultUri; set => this._keyVaultUri = value; }

        /// <summary>Backing field for <see cref="KeyVersion" /> property.</summary>
        private string _keyVersion;

        /// <summary>The version of the key associated with the Log Analytics cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string KeyVersion { get => this._keyVersion; set => this._keyVersion = value; }

        /// <summary>Creates an new <see cref="KeyVaultProperties" /> instance.</summary>
        public KeyVaultProperties()
        {

        }
    }
    /// The key vault properties.
    public partial interface IKeyVaultProperties :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>The name of the key associated with the Log Analytics cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the key associated with the Log Analytics cluster.",
        SerializedName = @"keyName",
        PossibleTypes = new [] { typeof(string) })]
        string KeyName { get; set; }
        /// <summary>Selected key minimum required size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Selected key minimum required size.",
        SerializedName = @"keyRsaSize",
        PossibleTypes = new [] { typeof(int) })]
        int? KeyRsaSize { get; set; }
        /// <summary>
        /// The Key Vault uri which holds they key associated with the Log Analytics cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Key Vault uri which holds they key associated with the Log Analytics cluster.",
        SerializedName = @"keyVaultUri",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVaultUri { get; set; }
        /// <summary>The version of the key associated with the Log Analytics cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The version of the key associated with the Log Analytics cluster.",
        SerializedName = @"keyVersion",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVersion { get; set; }

    }
    /// The key vault properties.
    internal partial interface IKeyVaultPropertiesInternal

    {
        /// <summary>The name of the key associated with the Log Analytics cluster.</summary>
        string KeyName { get; set; }
        /// <summary>Selected key minimum required size.</summary>
        int? KeyRsaSize { get; set; }
        /// <summary>
        /// The Key Vault uri which holds they key associated with the Log Analytics cluster.
        /// </summary>
        string KeyVaultUri { get; set; }
        /// <summary>The version of the key associated with the Log Analytics cluster.</summary>
        string KeyVersion { get; set; }

    }
}