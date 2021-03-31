namespace Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Extensions;

    /// <summary>Specifies the encryption key properties</summary>
    public partial class EncryptionKeyDetails :
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IEncryptionKeyDetails,
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IEncryptionKeyDetailsInternal
    {

        /// <summary>Backing field for <see cref="KekType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Support.EncryptionKekType? _kekType;

        /// <summary>The type of kek encryption key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Support.EncryptionKekType? KekType { get => this._kekType; set => this._kekType = value; }

        /// <summary>Backing field for <see cref="KekUrl" /> property.</summary>
        private string _kekUrl;

        /// <summary>Specifies the url for kek encryption key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Owned)]
        public string KekUrl { get => this._kekUrl; set => this._kekUrl = value; }

        /// <summary>Backing field for <see cref="KekVaultResourceId" /> property.</summary>
        private string _kekVaultResourceId;

        /// <summary>Specifies the keyvault resource id for kek encryption key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Owned)]
        public string KekVaultResourceId { get => this._kekVaultResourceId; set => this._kekVaultResourceId = value; }

        /// <summary>Creates an new <see cref="EncryptionKeyDetails" /> instance.</summary>
        public EncryptionKeyDetails()
        {

        }
    }
    /// Specifies the encryption key properties
    public partial interface IEncryptionKeyDetails :
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.IJsonSerializable
    {
        /// <summary>The type of kek encryption key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of kek encryption key",
        SerializedName = @"kekType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Support.EncryptionKekType) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Support.EncryptionKekType? KekType { get; set; }
        /// <summary>Specifies the url for kek encryption key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the url for kek encryption key. ",
        SerializedName = @"kekUrl",
        PossibleTypes = new [] { typeof(string) })]
        string KekUrl { get; set; }
        /// <summary>Specifies the keyvault resource id for kek encryption key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the keyvault resource id for kek encryption key. ",
        SerializedName = @"kekVaultResourceID",
        PossibleTypes = new [] { typeof(string) })]
        string KekVaultResourceId { get; set; }

    }
    /// Specifies the encryption key properties
    internal partial interface IEncryptionKeyDetailsInternal

    {
        /// <summary>The type of kek encryption key</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Support.EncryptionKekType? KekType { get; set; }
        /// <summary>Specifies the url for kek encryption key.</summary>
        string KekUrl { get; set; }
        /// <summary>Specifies the keyvault resource id for kek encryption key.</summary>
        string KekVaultResourceId { get; set; }

    }
}