namespace Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Extensions;

    /// <summary>Error response.</summary>
    public partial class ErrorResponse :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IErrorResponse,
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IErrorResponseInternal
    {

        /// <summary>
        /// Service specific error code which serves as the substatus for the HTTP error code.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IErrorDefinitionInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IErrorDefinitionInternal)Error).Code = value ?? null; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IErrorDefinition _error;

        /// <summary>Error definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IErrorDefinition Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.ErrorDefinition()); }

        /// <summary>Description of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IErrorDefinitionInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IErrorDefinitionInternal)Error).Message = value ?? null; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IErrorDefinition Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IErrorResponseInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.ErrorDefinition()); set { {_error = value;} } }

        /// <summary>Creates an new <see cref="ErrorResponse" /> instance.</summary>
        public ErrorResponse()
        {

        }
    }
    /// Error response.
    public partial interface IErrorResponse :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Service specific error code which serves as the substatus for the HTTP error code.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Service specific error code which serves as the substatus for the HTTP error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get; set; }
        /// <summary>Description of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Description of the error.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }

    }
    /// Error response.
    internal partial interface IErrorResponseInternal

    {
        /// <summary>
        /// Service specific error code which serves as the substatus for the HTTP error code.
        /// </summary>
        string Code { get; set; }
        /// <summary>Error definition.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IErrorDefinition Error { get; set; }
        /// <summary>Description of the error.</summary>
        string Message { get; set; }

    }
}