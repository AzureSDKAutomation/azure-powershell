namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    /// <summary>Domain configurations of session hosts.</summary>
    public partial class DomainInfoProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Credentials" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ICredentialsProperties _credentials;

        /// <summary>Credentials needed to create the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ICredentialsProperties Credentials { get => (this._credentials = this._credentials ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.CredentialsProperties()); set => this._credentials = value; }

        /// <summary>The keyvault resource id to the keyvault secrets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string DomainAdminPasswordKeyVaultResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ICredentialsPropertiesInternal)Credentials).DomainAdminPasswordKeyVaultResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ICredentialsPropertiesInternal)Credentials).DomainAdminPasswordKeyVaultResourceId = value ?? null; }

        /// <summary>The keyvault secret name the password is stored in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string DomainAdminPasswordSecretName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ICredentialsPropertiesInternal)Credentials).DomainAdminPasswordSecretName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ICredentialsPropertiesInternal)Credentials).DomainAdminPasswordSecretName = value ?? null; }

        /// <summary>The user name to the account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string DomainAdminUserName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ICredentialsPropertiesInternal)Credentials).DomainAdminUserName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ICredentialsPropertiesInternal)Credentials).DomainAdminUserName = value ?? null; }

        /// <summary>Backing field for <see cref="JoinType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.DomainJoinType? _joinType;

        /// <summary>The type of domain join done by the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.DomainJoinType? JoinType { get => this._joinType; set => this._joinType = value; }

        /// <summary>The keyvault resource id to the keyvault secrets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string LocalAdminPasswordKeyVaultResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ICredentialsPropertiesInternal)Credentials).LocalAdminPasswordKeyVaultResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ICredentialsPropertiesInternal)Credentials).LocalAdminPasswordKeyVaultResourceId = value ?? null; }

        /// <summary>The keyvault secret name the password is stored in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string LocalAdminPasswordSecretName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ICredentialsPropertiesInternal)Credentials).LocalAdminPasswordSecretName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ICredentialsPropertiesInternal)Credentials).LocalAdminPasswordSecretName = value ?? null; }

        /// <summary>The user name to the account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string LocalAdminUserName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ICredentialsPropertiesInternal)Credentials).LocalAdminUserName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ICredentialsPropertiesInternal)Credentials).LocalAdminUserName = value ?? null; }

        /// <summary>Backing field for <see cref="MdmProviderGuid" /> property.</summary>
        private string _mdmProviderGuid;

        /// <summary>
        /// The MDM Provider GUID used during MDM enrollment for Azure AD joined virtual machines.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string MdmProviderGuid { get => this._mdmProviderGuid; set => this._mdmProviderGuid = value; }

        /// <summary>Internal Acessors for Credentials</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ICredentialsProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoPropertiesInternal.Credentials { get => (this._credentials = this._credentials ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.CredentialsProperties()); set { {_credentials = value;} } }

        /// <summary>Internal Acessors for CredentialsDomainAdmin</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoPropertiesInternal.CredentialsDomainAdmin { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ICredentialsPropertiesInternal)Credentials).DomainAdmin; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ICredentialsPropertiesInternal)Credentials).DomainAdmin = value; }

        /// <summary>Internal Acessors for CredentialsLocalAdmin</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IDomainInfoPropertiesInternal.CredentialsLocalAdmin { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ICredentialsPropertiesInternal)Credentials).LocalAdmin; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ICredentialsPropertiesInternal)Credentials).LocalAdmin = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The domain a virtual machine connected to a hostpool will join.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="DomainInfoProperties" /> instance.</summary>
        public DomainInfoProperties()
        {

        }
    }
    /// Domain configurations of session hosts.
    public partial interface IDomainInfoProperties :
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
        /// <summary>The type of domain join done by the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of domain join done by the virtual machine.",
        SerializedName = @"joinType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.DomainJoinType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.DomainJoinType? JoinType { get; set; }
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
        /// <summary>
        /// The MDM Provider GUID used during MDM enrollment for Azure AD joined virtual machines.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The MDM Provider GUID used during MDM enrollment for Azure AD joined virtual machines.",
        SerializedName = @"mdmProviderGuid",
        PossibleTypes = new [] { typeof(string) })]
        string MdmProviderGuid { get; set; }
        /// <summary>The domain a virtual machine connected to a hostpool will join.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The domain a virtual machine connected to a hostpool will join.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// Domain configurations of session hosts.
    internal partial interface IDomainInfoPropertiesInternal

    {
        /// <summary>Credentials needed to create the virtual machine.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ICredentialsProperties Credentials { get; set; }
        /// <summary>The domain admin credentials.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialProperties CredentialsDomainAdmin { get; set; }
        /// <summary>The local admin credentials.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IKeyVaultCredentialProperties CredentialsLocalAdmin { get; set; }
        /// <summary>The keyvault resource id to the keyvault secrets.</summary>
        string DomainAdminPasswordKeyVaultResourceId { get; set; }
        /// <summary>The keyvault secret name the password is stored in.</summary>
        string DomainAdminPasswordSecretName { get; set; }
        /// <summary>The user name to the account.</summary>
        string DomainAdminUserName { get; set; }
        /// <summary>The type of domain join done by the virtual machine.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.DomainJoinType? JoinType { get; set; }
        /// <summary>The keyvault resource id to the keyvault secrets.</summary>
        string LocalAdminPasswordKeyVaultResourceId { get; set; }
        /// <summary>The keyvault secret name the password is stored in.</summary>
        string LocalAdminPasswordSecretName { get; set; }
        /// <summary>The user name to the account.</summary>
        string LocalAdminUserName { get; set; }
        /// <summary>
        /// The MDM Provider GUID used during MDM enrollment for Azure AD joined virtual machines.
        /// </summary>
        string MdmProviderGuid { get; set; }
        /// <summary>The domain a virtual machine connected to a hostpool will join.</summary>
        string Name { get; set; }

    }
}