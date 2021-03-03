namespace Microsoft.Azure.PowerShell.Cmdlets.Hana.Models.Api20200207Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Hana.Runtime.Extensions;

    /// <summary>Describes the error object.</summary>
    public partial class ErrorResponseError :
        Microsoft.Azure.PowerShell.Cmdlets.Hana.Models.Api20200207Preview.IErrorResponseError,
        Microsoft.Azure.PowerShell.Cmdlets.Hana.Models.Api20200207Preview.IErrorResponseErrorInternal
    {

        /// <summary>Backing field for <see cref="Code" /> property.</summary>
        private string _code;

        /// <summary>Error code</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hana.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hana.PropertyOrigin.Owned)]
        public string Code { get => this._code; }

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>Error message indicating why the operation failed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hana.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hana.PropertyOrigin.Owned)]
        public string Message { get => this._message; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Hana.Models.Api20200207Preview.IErrorResponseErrorInternal.Code { get => this._code; set { {_code = value;} } }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Hana.Models.Api20200207Preview.IErrorResponseErrorInternal.Message { get => this._message; set { {_message = value;} } }

        /// <summary>Creates an new <see cref="ErrorResponseError" /> instance.</summary>
        public ErrorResponseError()
        {

        }
    }
    /// Describes the error object.
    public partial interface IErrorResponseError :
        Microsoft.Azure.PowerShell.Cmdlets.Hana.Runtime.IJsonSerializable
    {
        /// <summary>Error code</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hana.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Error code",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
        /// <summary>Error message indicating why the operation failed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hana.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Error message indicating why the operation failed.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }

    }
    /// Describes the error object.
    internal partial interface IErrorResponseErrorInternal

    {
        /// <summary>Error code</summary>
        string Code { get; set; }
        /// <summary>Error message indicating why the operation failed.</summary>
        string Message { get; set; }

    }
}