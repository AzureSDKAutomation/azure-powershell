namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>User assigned identity properties.</summary>
    public partial class UserIdentityProperties :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IUserIdentityProperties,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IUserIdentityPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ClientId" /> property.</summary>
        private string _clientId;

        /// <summary>The client id of user assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string ClientId { get => this._clientId; }

        /// <summary>Internal Acessors for ClientId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IUserIdentityPropertiesInternal.ClientId { get => this._clientId; set { {_clientId = value;} } }

        /// <summary>Internal Acessors for PrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IUserIdentityPropertiesInternal.PrincipalId { get => this._principalId; set { {_principalId = value;} } }

        /// <summary>Backing field for <see cref="PrincipalId" /> property.</summary>
        private string _principalId;

        /// <summary>The principal id of user assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string PrincipalId { get => this._principalId; }

        /// <summary>Creates an new <see cref="UserIdentityProperties" /> instance.</summary>
        public UserIdentityProperties()
        {

        }
    }
    /// User assigned identity properties.
    public partial interface IUserIdentityProperties :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>The client id of user assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The client id of user assigned identity.",
        SerializedName = @"clientId",
        PossibleTypes = new [] { typeof(string) })]
        string ClientId { get;  }
        /// <summary>The principal id of user assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The principal id of user assigned identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalId { get;  }

    }
    /// User assigned identity properties.
    internal partial interface IUserIdentityPropertiesInternal

    {
        /// <summary>The client id of user assigned identity.</summary>
        string ClientId { get; set; }
        /// <summary>The principal id of user assigned identity.</summary>
        string PrincipalId { get; set; }

    }
}