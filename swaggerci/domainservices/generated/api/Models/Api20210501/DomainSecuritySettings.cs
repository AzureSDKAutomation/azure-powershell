namespace Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Extensions;

    /// <summary>Domain Security Settings</summary>
    public partial class DomainSecuritySettings :
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IDomainSecuritySettings,
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IDomainSecuritySettingsInternal
    {

        /// <summary>Backing field for <see cref="KerberosArmoring" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.KerberosArmoring? _kerberosArmoring;

        /// <summary>A flag to determine whether or not KerberosArmoring is enabled or disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.KerberosArmoring? KerberosArmoring { get => this._kerberosArmoring; set => this._kerberosArmoring = value; }

        /// <summary>Backing field for <see cref="KerberosRc4Encryption" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.KerberosRc4Encryption? _kerberosRc4Encryption;

        /// <summary>
        /// A flag to determine whether or not KerberosRc4Encryption is enabled or disabled.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.KerberosRc4Encryption? KerberosRc4Encryption { get => this._kerberosRc4Encryption; set => this._kerberosRc4Encryption = value; }

        /// <summary>Backing field for <see cref="NtlmV1" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.NtlmV1? _ntlmV1;

        /// <summary>A flag to determine whether or not NtlmV1 is enabled or disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.NtlmV1? NtlmV1 { get => this._ntlmV1; set => this._ntlmV1 = value; }

        /// <summary>Backing field for <see cref="SyncKerberosPassword" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.SyncKerberosPasswords? _syncKerberosPassword;

        /// <summary>
        /// A flag to determine whether or not SyncKerberosPasswords is enabled or disabled.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.SyncKerberosPasswords? SyncKerberosPassword { get => this._syncKerberosPassword; set => this._syncKerberosPassword = value; }

        /// <summary>Backing field for <see cref="SyncNtlmPassword" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.SyncNtlmPasswords? _syncNtlmPassword;

        /// <summary>A flag to determine whether or not SyncNtlmPasswords is enabled or disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.SyncNtlmPasswords? SyncNtlmPassword { get => this._syncNtlmPassword; set => this._syncNtlmPassword = value; }

        /// <summary>Backing field for <see cref="SyncOnPremPassword" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.SyncOnPremPasswords? _syncOnPremPassword;

        /// <summary>A flag to determine whether or not SyncOnPremPasswords is enabled or disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.SyncOnPremPasswords? SyncOnPremPassword { get => this._syncOnPremPassword; set => this._syncOnPremPassword = value; }

        /// <summary>Backing field for <see cref="TlsV1" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.TlsV1? _tlsV1;

        /// <summary>A flag to determine whether or not TlsV1 is enabled or disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.TlsV1? TlsV1 { get => this._tlsV1; set => this._tlsV1 = value; }

        /// <summary>Creates an new <see cref="DomainSecuritySettings" /> instance.</summary>
        public DomainSecuritySettings()
        {

        }
    }
    /// Domain Security Settings
    public partial interface IDomainSecuritySettings :
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.IJsonSerializable
    {
        /// <summary>A flag to determine whether or not KerberosArmoring is enabled or disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A flag to determine whether or not KerberosArmoring is enabled or disabled.",
        SerializedName = @"kerberosArmoring",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.KerberosArmoring) })]
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.KerberosArmoring? KerberosArmoring { get; set; }
        /// <summary>
        /// A flag to determine whether or not KerberosRc4Encryption is enabled or disabled.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A flag to determine whether or not KerberosRc4Encryption is enabled or disabled.",
        SerializedName = @"kerberosRc4Encryption",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.KerberosRc4Encryption) })]
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.KerberosRc4Encryption? KerberosRc4Encryption { get; set; }
        /// <summary>A flag to determine whether or not NtlmV1 is enabled or disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A flag to determine whether or not NtlmV1 is enabled or disabled.",
        SerializedName = @"ntlmV1",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.NtlmV1) })]
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.NtlmV1? NtlmV1 { get; set; }
        /// <summary>
        /// A flag to determine whether or not SyncKerberosPasswords is enabled or disabled.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A flag to determine whether or not SyncKerberosPasswords is enabled or disabled.",
        SerializedName = @"syncKerberosPasswords",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.SyncKerberosPasswords) })]
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.SyncKerberosPasswords? SyncKerberosPassword { get; set; }
        /// <summary>A flag to determine whether or not SyncNtlmPasswords is enabled or disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A flag to determine whether or not SyncNtlmPasswords is enabled or disabled.",
        SerializedName = @"syncNtlmPasswords",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.SyncNtlmPasswords) })]
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.SyncNtlmPasswords? SyncNtlmPassword { get; set; }
        /// <summary>A flag to determine whether or not SyncOnPremPasswords is enabled or disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A flag to determine whether or not SyncOnPremPasswords is enabled or disabled.",
        SerializedName = @"syncOnPremPasswords",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.SyncOnPremPasswords) })]
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.SyncOnPremPasswords? SyncOnPremPassword { get; set; }
        /// <summary>A flag to determine whether or not TlsV1 is enabled or disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A flag to determine whether or not TlsV1 is enabled or disabled.",
        SerializedName = @"tlsV1",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.TlsV1) })]
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.TlsV1? TlsV1 { get; set; }

    }
    /// Domain Security Settings
    internal partial interface IDomainSecuritySettingsInternal

    {
        /// <summary>A flag to determine whether or not KerberosArmoring is enabled or disabled.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.KerberosArmoring? KerberosArmoring { get; set; }
        /// <summary>
        /// A flag to determine whether or not KerberosRc4Encryption is enabled or disabled.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.KerberosRc4Encryption? KerberosRc4Encryption { get; set; }
        /// <summary>A flag to determine whether or not NtlmV1 is enabled or disabled.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.NtlmV1? NtlmV1 { get; set; }
        /// <summary>
        /// A flag to determine whether or not SyncKerberosPasswords is enabled or disabled.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.SyncKerberosPasswords? SyncKerberosPassword { get; set; }
        /// <summary>A flag to determine whether or not SyncNtlmPasswords is enabled or disabled.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.SyncNtlmPasswords? SyncNtlmPassword { get; set; }
        /// <summary>A flag to determine whether or not SyncOnPremPasswords is enabled or disabled.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.SyncOnPremPasswords? SyncOnPremPassword { get; set; }
        /// <summary>A flag to determine whether or not TlsV1 is enabled or disabled.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.TlsV1? TlsV1 { get; set; }

    }
}