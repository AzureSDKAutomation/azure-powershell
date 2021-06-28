namespace Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Extensions;

    /// <summary>Container Account Description</summary>
    public partial class ContainerAccount :
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IContainerAccount,
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IContainerAccountInternal
    {

        /// <summary>Backing field for <see cref="AccountName" /> property.</summary>
        private string _accountName;

        /// <summary>The account name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public string AccountName { get => this._accountName; set => this._accountName = value; }

        /// <summary>Backing field for <see cref="Password" /> property.</summary>
        private string _password;

        /// <summary>The account password</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public string Password { get => this._password; set => this._password = value; }

        /// <summary>Backing field for <see cref="Spn" /> property.</summary>
        private string _spn;

        /// <summary>The account spn</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public string Spn { get => this._spn; set => this._spn = value; }

        /// <summary>Creates an new <see cref="ContainerAccount" /> instance.</summary>
        public ContainerAccount()
        {

        }
    }
    /// Container Account Description
    public partial interface IContainerAccount :
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.IJsonSerializable
    {
        /// <summary>The account name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The account name",
        SerializedName = @"accountName",
        PossibleTypes = new [] { typeof(string) })]
        string AccountName { get; set; }
        /// <summary>The account password</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The account password",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(string) })]
        string Password { get; set; }
        /// <summary>The account spn</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The account spn",
        SerializedName = @"spn",
        PossibleTypes = new [] { typeof(string) })]
        string Spn { get; set; }

    }
    /// Container Account Description
    internal partial interface IContainerAccountInternal

    {
        /// <summary>The account name</summary>
        string AccountName { get; set; }
        /// <summary>The account password</summary>
        string Password { get; set; }
        /// <summary>The account spn</summary>
        string Spn { get; set; }

    }
}