namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Extensions;

    /// <summary>The details of the error.</summary>
    public partial class ErrorDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IErrorDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IErrorDetailsInternal
    {

        /// <summary>One of a server-defined set of error codes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IErrorDetailsErrorInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IErrorDetailsErrorInternal)Error).Code = value ?? null; }

        /// <summary>A human-readable representation of the error's details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.PropertyOrigin.Inlined)]
        public string Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IErrorDetailsErrorInternal)Error).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IErrorDetailsErrorInternal)Error).Detail = value ?? null; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IErrorDetailsError _error;

        /// <summary>The error object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IErrorDetailsError Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.ErrorDetailsError()); set => this._error = value; }

        /// <summary>A human-readable representation of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IErrorDetailsErrorInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IErrorDetailsErrorInternal)Error).Message = value ?? null; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IErrorDetailsError Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IErrorDetailsInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.ErrorDetailsError()); set { {_error = value;} } }

        /// <summary>The target of the particular error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.PropertyOrigin.Inlined)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IErrorDetailsErrorInternal)Error).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IErrorDetailsErrorInternal)Error).Target = value ?? null; }

        /// <summary>Creates an new <see cref="ErrorDetails" /> instance.</summary>
        public ErrorDetails()
        {

        }
    }
    /// The details of the error.
    public partial interface IErrorDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.IJsonSerializable
    {
        /// <summary>One of a server-defined set of error codes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"One of a server-defined set of error codes.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get; set; }
        /// <summary>A human-readable representation of the error's details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A human-readable representation of the error's details.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(string) })]
        string Detail { get; set; }
        /// <summary>A human-readable representation of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A human-readable representation of the error.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }
        /// <summary>The target of the particular error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target of the particular error.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string Target { get; set; }

    }
    /// The details of the error.
    internal partial interface IErrorDetailsInternal

    {
        /// <summary>One of a server-defined set of error codes.</summary>
        string Code { get; set; }
        /// <summary>A human-readable representation of the error's details.</summary>
        string Detail { get; set; }
        /// <summary>The error object.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IErrorDetailsError Error { get; set; }
        /// <summary>A human-readable representation of the error.</summary>
        string Message { get; set; }
        /// <summary>The target of the particular error.</summary>
        string Target { get; set; }

    }
}