namespace Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Extensions;

    /// <summary>Violation information.</summary>
    public partial class Violation :
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IViolation,
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IViolationInternal
    {

        /// <summary>Backing field for <see cref="ErrorMessage" /> property.</summary>
        private string _errorMessage;

        /// <summary>Error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Owned)]
        public string ErrorMessage { get => this._errorMessage; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Id of the item that violates tenant configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Internal Acessors for ErrorMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IViolationInternal.ErrorMessage { get => this._errorMessage; set { {_errorMessage = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IViolationInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for UserId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IViolationInternal.UserId { get => this._userId; set { {_userId = value;} } }

        /// <summary>Backing field for <see cref="UserId" /> property.</summary>
        private string _userId;

        /// <summary>Id of the user who owns violated item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Owned)]
        public string UserId { get => this._userId; }

        /// <summary>Creates an new <see cref="Violation" /> instance.</summary>
        public Violation()
        {

        }
    }
    /// Violation information.
    public partial interface IViolation :
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.IJsonSerializable
    {
        /// <summary>Error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Error message.",
        SerializedName = @"errorMessage",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorMessage { get;  }
        /// <summary>Id of the item that violates tenant configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Id of the item that violates tenant configuration.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>Id of the user who owns violated item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Id of the user who owns violated item.",
        SerializedName = @"userId",
        PossibleTypes = new [] { typeof(string) })]
        string UserId { get;  }

    }
    /// Violation information.
    internal partial interface IViolationInternal

    {
        /// <summary>Error message.</summary>
        string ErrorMessage { get; set; }
        /// <summary>Id of the item that violates tenant configuration.</summary>
        string Id { get; set; }
        /// <summary>Id of the user who owns violated item.</summary>
        string UserId { get; set; }

    }
}