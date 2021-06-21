namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    /// <summary>Credentials kept in the keyvault.</summary>
    public partial class KeyVaultCredentialProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialPropertiesInternal
    {

        /// <summary>Backing field for <see cref="PasswordKeyVaultResourceId" /> property.</summary>
        private string _passwordKeyVaultResourceId;

        /// <summary>The keyvault resource id to the keyvault secrets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string PasswordKeyVaultResourceId { get => this._passwordKeyVaultResourceId; set => this._passwordKeyVaultResourceId = value; }

        /// <summary>Backing field for <see cref="PasswordSecretName" /> property.</summary>
        private string _passwordSecretName;

        /// <summary>The keyvault secret name the password is stored in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string PasswordSecretName { get => this._passwordSecretName; set => this._passwordSecretName = value; }

        /// <summary>Backing field for <see cref="UserName" /> property.</summary>
        private string _userName;

        /// <summary>The user name to the account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string UserName { get => this._userName; set => this._userName = value; }

        /// <summary>Creates an new <see cref="KeyVaultCredentialProperties" /> instance.</summary>
        public KeyVaultCredentialProperties()
        {

        }
    }
    /// Credentials kept in the keyvault.
    public partial interface IKeyVaultCredentialProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IJsonSerializable
    {
        /// <summary>The keyvault resource id to the keyvault secrets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The keyvault resource id to the keyvault secrets.",
        SerializedName = @"passwordKeyVaultResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string PasswordKeyVaultResourceId { get; set; }
        /// <summary>The keyvault secret name the password is stored in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The keyvault secret name the password is stored in.",
        SerializedName = @"passwordSecretName",
        PossibleTypes = new [] { typeof(string) })]
        string PasswordSecretName { get; set; }
        /// <summary>The user name to the account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The user name to the account.",
        SerializedName = @"userName",
        PossibleTypes = new [] { typeof(string) })]
        string UserName { get; set; }

    }
    /// Credentials kept in the keyvault.
    internal partial interface IKeyVaultCredentialPropertiesInternal

    {
        /// <summary>The keyvault resource id to the keyvault secrets.</summary>
        string PasswordKeyVaultResourceId { get; set; }
        /// <summary>The keyvault secret name the password is stored in.</summary>
        string PasswordSecretName { get; set; }
        /// <summary>The user name to the account.</summary>
        string UserName { get; set; }

    }
}