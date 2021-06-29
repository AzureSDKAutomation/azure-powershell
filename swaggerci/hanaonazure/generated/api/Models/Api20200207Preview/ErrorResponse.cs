namespace Microsoft.Azure.PowerShell.Cmdlets.Hana.Models.Api20200207Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Hana.Runtime.Extensions;

    /// <summary>Describes the format of Error response.</summary>
    public partial class ErrorResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Hana.Models.Api20200207Preview.IErrorResponse,
        Microsoft.Azure.PowerShell.Cmdlets.Hana.Models.Api20200207Preview.IErrorResponseInternal
    {

        /// <summary>Error code</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hana.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hana.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hana.Models.Api20200207Preview.IErrorResponseErrorInternal)Error).Code; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Hana.Models.Api20200207Preview.IErrorResponseError _error;

        /// <summary>Describes the error object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hana.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hana.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Hana.Models.Api20200207Preview.IErrorResponseError Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.Hana.Models.Api20200207Preview.ErrorResponseError()); set => this._error = value; }

        /// <summary>Error message indicating why the operation failed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hana.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hana.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hana.Models.Api20200207Preview.IErrorResponseErrorInternal)Error).Message; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Hana.Models.Api20200207Preview.IErrorResponseInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hana.Models.Api20200207Preview.IErrorResponseErrorInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hana.Models.Api20200207Preview.IErrorResponseErrorInternal)Error).Code = value; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Hana.Models.Api20200207Preview.IErrorResponseError Microsoft.Azure.PowerShell.Cmdlets.Hana.Models.Api20200207Preview.IErrorResponseInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.Hana.Models.Api20200207Preview.ErrorResponseError()); set { {_error = value;} } }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Hana.Models.Api20200207Preview.IErrorResponseInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.Hana.Models.Api20200207Preview.IErrorResponseErrorInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.Hana.Models.Api20200207Preview.IErrorResponseErrorInternal)Error).Message = value; }

        /// <summary>Creates an new <see cref="ErrorResponse" /> instance.</summary>
        public ErrorResponse()
        {

        }
    }
    /// Describes the format of Error response.
    public partial interface IErrorResponse :
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
    /// Describes the format of Error response.
    internal partial interface IErrorResponseInternal

    {
        /// <summary>Error code</summary>
        string Code { get; set; }
        /// <summary>Describes the error object.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Hana.Models.Api20200207Preview.IErrorResponseError Error { get; set; }
        /// <summary>Error message indicating why the operation failed.</summary>
        string Message { get; set; }

    }
}