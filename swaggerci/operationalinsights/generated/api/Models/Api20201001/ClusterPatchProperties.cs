namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>Log Analytics cluster patch properties.</summary>
    public partial class ClusterPatchProperties :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchProperties,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchPropertiesInternal
    {

        /// <summary>Backing field for <see cref="KeyVaultProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IKeyVaultProperties _keyVaultProperty;

        /// <summary>The associated key properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IKeyVaultProperties KeyVaultProperty { get => (this._keyVaultProperty = this._keyVaultProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.KeyVaultProperties()); set => this._keyVaultProperty = value; }

        /// <summary>The name of the key associated with the Log Analytics cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyKeyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IKeyVaultPropertiesInternal)KeyVaultProperty).KeyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IKeyVaultPropertiesInternal)KeyVaultProperty).KeyName = value ?? null; }

        /// <summary>Selected key minimum required size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public int? KeyVaultPropertyKeyRsaSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IKeyVaultPropertiesInternal)KeyVaultProperty).KeyRsaSize; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IKeyVaultPropertiesInternal)KeyVaultProperty).KeyRsaSize = value ?? default(int); }

        /// <summary>
        /// The Key Vault uri which holds they key associated with the Log Analytics cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyKeyVaultUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IKeyVaultPropertiesInternal)KeyVaultProperty).KeyVaultUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IKeyVaultPropertiesInternal)KeyVaultProperty).KeyVaultUri = value ?? null; }

        /// <summary>The version of the key associated with the Log Analytics cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyKeyVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IKeyVaultPropertiesInternal)KeyVaultProperty).KeyVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IKeyVaultPropertiesInternal)KeyVaultProperty).KeyVersion = value ?? null; }

        /// <summary>Internal Acessors for KeyVaultProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IKeyVaultProperties Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchPropertiesInternal.KeyVaultProperty { get => (this._keyVaultProperty = this._keyVaultProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.KeyVaultProperties()); set { {_keyVaultProperty = value;} } }

        /// <summary>Creates an new <see cref="ClusterPatchProperties" /> instance.</summary>
        public ClusterPatchProperties()
        {

        }
    }
    /// Log Analytics cluster patch properties.
    public partial interface IClusterPatchProperties :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>The name of the key associated with the Log Analytics cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the key associated with the Log Analytics cluster.",
        SerializedName = @"keyName",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVaultPropertyKeyName { get; set; }
        /// <summary>Selected key minimum required size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Selected key minimum required size.",
        SerializedName = @"keyRsaSize",
        PossibleTypes = new [] { typeof(int) })]
        int? KeyVaultPropertyKeyRsaSize { get; set; }
        /// <summary>
        /// The Key Vault uri which holds they key associated with the Log Analytics cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Key Vault uri which holds they key associated with the Log Analytics cluster.",
        SerializedName = @"keyVaultUri",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVaultPropertyKeyVaultUri { get; set; }
        /// <summary>The version of the key associated with the Log Analytics cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The version of the key associated with the Log Analytics cluster.",
        SerializedName = @"keyVersion",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVaultPropertyKeyVersion { get; set; }

    }
    /// Log Analytics cluster patch properties.
    internal partial interface IClusterPatchPropertiesInternal

    {
        /// <summary>The associated key properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IKeyVaultProperties KeyVaultProperty { get; set; }
        /// <summary>The name of the key associated with the Log Analytics cluster.</summary>
        string KeyVaultPropertyKeyName { get; set; }
        /// <summary>Selected key minimum required size.</summary>
        int? KeyVaultPropertyKeyRsaSize { get; set; }
        /// <summary>
        /// The Key Vault uri which holds they key associated with the Log Analytics cluster.
        /// </summary>
        string KeyVaultPropertyKeyVaultUri { get; set; }
        /// <summary>The version of the key associated with the Log Analytics cluster.</summary>
        string KeyVaultPropertyKeyVersion { get; set; }

    }
}