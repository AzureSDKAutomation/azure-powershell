namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    /// <summary>Credentials needed to create the virtual machine.</summary>
    public partial class CredentialsProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ICredentialsProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ICredentialsPropertiesInternal
    {

        /// <summary>Backing field for <see cref="DomainAdmin" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialProperties _domainAdmin;

        /// <summary>The domain admin credentials.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialProperties DomainAdmin { get => (this._domainAdmin = this._domainAdmin ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.KeyVaultCredentialProperties()); set => this._domainAdmin = value; }

        /// <summary>The keyvault resource id to the keyvault secrets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string DomainAdminPasswordKeyVaultResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialPropertiesInternal)DomainAdmin).PasswordKeyVaultResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialPropertiesInternal)DomainAdmin).PasswordKeyVaultResourceId = value ?? null; }

        /// <summary>The keyvault secret name the password is stored in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string DomainAdminPasswordSecretName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialPropertiesInternal)DomainAdmin).PasswordSecretName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialPropertiesInternal)DomainAdmin).PasswordSecretName = value ?? null; }

        /// <summary>The user name to the account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string DomainAdminUserName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialPropertiesInternal)DomainAdmin).UserName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialPropertiesInternal)DomainAdmin).UserName = value ?? null; }

        /// <summary>Backing field for <see cref="LocalAdmin" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialProperties _localAdmin;

        /// <summary>The local admin credentials.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialProperties LocalAdmin { get => (this._localAdmin = this._localAdmin ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.KeyVaultCredentialProperties()); set => this._localAdmin = value; }

        /// <summary>The keyvault resource id to the keyvault secrets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string LocalAdminPasswordKeyVaultResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialPropertiesInternal)LocalAdmin).PasswordKeyVaultResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialPropertiesInternal)LocalAdmin).PasswordKeyVaultResourceId = value ?? null; }

        /// <summary>The keyvault secret name the password is stored in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string LocalAdminPasswordSecretName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialPropertiesInternal)LocalAdmin).PasswordSecretName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialPropertiesInternal)LocalAdmin).PasswordSecretName = value ?? null; }

        /// <summary>The user name to the account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string LocalAdminUserName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialPropertiesInternal)LocalAdmin).UserName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialPropertiesInternal)LocalAdmin).UserName = value ?? null; }

        /// <summary>Internal Acessors for DomainAdmin</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ICredentialsPropertiesInternal.DomainAdmin { get => (this._domainAdmin = this._domainAdmin ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.KeyVaultCredentialProperties()); set { {_domainAdmin = value;} } }

        /// <summary>Internal Acessors for LocalAdmin</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ICredentialsPropertiesInternal.LocalAdmin { get => (this._localAdmin = this._localAdmin ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.KeyVaultCredentialProperties()); set { {_localAdmin = value;} } }

        /// <summary>Creates an new <see cref="CredentialsProperties" /> instance.</summary>
        public CredentialsProperties()
        {

        }
    }
    /// Credentials needed to create the virtual machine.
    public partial interface ICredentialsProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IJsonSerializable
    {
        /// <summary>The keyvault resource id to the keyvault secrets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The keyvault resource id to the keyvault secrets.",
        SerializedName = @"passwordKeyVaultResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string DomainAdminPasswordKeyVaultResourceId { get; set; }
        /// <summary>The keyvault secret name the password is stored in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The keyvault secret name the password is stored in.",
        SerializedName = @"passwordSecretName",
        PossibleTypes = new [] { typeof(string) })]
        string DomainAdminPasswordSecretName { get; set; }
        /// <summary>The user name to the account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The user name to the account.",
        SerializedName = @"userName",
        PossibleTypes = new [] { typeof(string) })]
        string DomainAdminUserName { get; set; }
        /// <summary>The keyvault resource id to the keyvault secrets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The keyvault resource id to the keyvault secrets.",
        SerializedName = @"passwordKeyVaultResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string LocalAdminPasswordKeyVaultResourceId { get; set; }
        /// <summary>The keyvault secret name the password is stored in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The keyvault secret name the password is stored in.",
        SerializedName = @"passwordSecretName",
        PossibleTypes = new [] { typeof(string) })]
        string LocalAdminPasswordSecretName { get; set; }
        /// <summary>The user name to the account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The user name to the account.",
        SerializedName = @"userName",
        PossibleTypes = new [] { typeof(string) })]
        string LocalAdminUserName { get; set; }

    }
    /// Credentials needed to create the virtual machine.
    internal partial interface ICredentialsPropertiesInternal

    {
        /// <summary>The domain admin credentials.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialProperties DomainAdmin { get; set; }
        /// <summary>The keyvault resource id to the keyvault secrets.</summary>
        string DomainAdminPasswordKeyVaultResourceId { get; set; }
        /// <summary>The keyvault secret name the password is stored in.</summary>
        string DomainAdminPasswordSecretName { get; set; }
        /// <summary>The user name to the account.</summary>
        string DomainAdminUserName { get; set; }
        /// <summary>The local admin credentials.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialProperties LocalAdmin { get; set; }
        /// <summary>The keyvault resource id to the keyvault secrets.</summary>
        string LocalAdminPasswordKeyVaultResourceId { get; set; }
        /// <summary>The keyvault secret name the password is stored in.</summary>
        string LocalAdminPasswordSecretName { get; set; }
        /// <summary>The user name to the account.</summary>
        string LocalAdminUserName { get; set; }

    }
}