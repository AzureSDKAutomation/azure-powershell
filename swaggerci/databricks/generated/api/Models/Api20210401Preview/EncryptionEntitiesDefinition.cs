namespace Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Extensions;

    /// <summary>Encryption entities for databricks workspace resource.</summary>
    public partial class EncryptionEntitiesDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinition,
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinitionInternal
    {

        /// <summary>The name of KeyVault key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyKeyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2Internal)ManagedService).KeyVaultPropertyKeyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2Internal)ManagedService).KeyVaultPropertyKeyName = value ?? null; }

        /// <summary>The Uri of KeyVault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyKeyVaultUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2Internal)ManagedService).KeyVaultPropertyKeyVaultUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2Internal)ManagedService).KeyVaultPropertyKeyVaultUri = value ?? null; }

        /// <summary>The version of KeyVault key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyKeyVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2Internal)ManagedService).KeyVaultPropertyKeyVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2Internal)ManagedService).KeyVaultPropertyKeyVersion = value ?? null; }

        /// <summary>Backing field for <see cref="ManagedService" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2 _managedService;

        /// <summary>Encryption properties for the databricks managed services.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2 ManagedService { get => (this._managedService = this._managedService ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.EncryptionV2()); set => this._managedService = value; }

        /// <summary>
        /// The encryption keySource (provider). Possible values (case-insensitive): Microsoft.Keyvault
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string ManagedServiceKeySource { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2Internal)ManagedService).KeySource; }

        /// <summary>Internal Acessors for ManagedService</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2 Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinitionInternal.ManagedService { get => (this._managedService = this._managedService ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.EncryptionV2()); set { {_managedService = value;} } }

        /// <summary>Internal Acessors for ManagedServiceKeySource</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinitionInternal.ManagedServiceKeySource { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2Internal)ManagedService).KeySource; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2Internal)ManagedService).KeySource = value; }

        /// <summary>Internal Acessors for ManagedServiceKeyVaultProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2KeyVaultProperties Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionEntitiesDefinitionInternal.ManagedServiceKeyVaultProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2Internal)ManagedService).KeyVaultProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2Internal)ManagedService).KeyVaultProperty = value; }

        /// <summary>Creates an new <see cref="EncryptionEntitiesDefinition" /> instance.</summary>
        public EncryptionEntitiesDefinition()
        {

        }
    }
    /// Encryption entities for databricks workspace resource.
    public partial interface IEncryptionEntitiesDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.IJsonSerializable
    {
        /// <summary>The name of KeyVault key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of KeyVault key.",
        SerializedName = @"keyName",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVaultPropertyKeyName { get; set; }
        /// <summary>The Uri of KeyVault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Uri of KeyVault.",
        SerializedName = @"keyVaultUri",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVaultPropertyKeyVaultUri { get; set; }
        /// <summary>The version of KeyVault key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The version of KeyVault key.",
        SerializedName = @"keyVersion",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVaultPropertyKeyVersion { get; set; }
        /// <summary>
        /// The encryption keySource (provider). Possible values (case-insensitive): Microsoft.Keyvault
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.Keyvault",
        SerializedName = @"keySource",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedServiceKeySource { get;  }

    }
    /// Encryption entities for databricks workspace resource.
    internal partial interface IEncryptionEntitiesDefinitionInternal

    {
        /// <summary>The name of KeyVault key.</summary>
        string KeyVaultPropertyKeyName { get; set; }
        /// <summary>The Uri of KeyVault.</summary>
        string KeyVaultPropertyKeyVaultUri { get; set; }
        /// <summary>The version of KeyVault key.</summary>
        string KeyVaultPropertyKeyVersion { get; set; }
        /// <summary>Encryption properties for the databricks managed services.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2 ManagedService { get; set; }
        /// <summary>
        /// The encryption keySource (provider). Possible values (case-insensitive): Microsoft.Keyvault
        /// </summary>
        string ManagedServiceKeySource { get; set; }
        /// <summary>Key Vault input properties for encryption.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryptionV2KeyVaultProperties ManagedServiceKeyVaultProperty { get; set; }

    }
}