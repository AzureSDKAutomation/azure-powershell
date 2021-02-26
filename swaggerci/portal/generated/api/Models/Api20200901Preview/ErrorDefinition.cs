namespace Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Extensions;

    /// <summary>Error definition.</summary>
    public partial class ErrorDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IErrorDefinition,
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IErrorDefinitionInternal
    {

        /// <summary>Backing field for <see cref="Code" /> property.</summary>
        private int? _code;

        /// <summary>
        /// Service specific error code which serves as the substatus for the HTTP error code.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Owned)]
        public int? Code { get => this._code; }

        /// <summary>Backing field for <see cref="Detail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IErrorDefinition[] _detail;

        /// <summary>Internal error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IErrorDefinition[] Detail { get => this._detail; }

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>Description of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Owned)]
        public string Message { get => this._message; }

        /// <summary>Internal Acessors for Code</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IErrorDefinitionInternal.Code { get => this._code; set { {_code = value;} } }

        /// <summary>Internal Acessors for Detail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IErrorDefinition[] Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IErrorDefinitionInternal.Detail { get => this._detail; set { {_detail = value;} } }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IErrorDefinitionInternal.Message { get => this._message; set { {_message = value;} } }

        /// <summary>Creates an new <see cref="ErrorDefinition" /> instance.</summary>
        public ErrorDefinition()
        {

        }
    }
    /// Error definition.
    public partial interface IErrorDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Service specific error code which serves as the substatus for the HTTP error code.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Service specific error code which serves as the substatus for the HTTP error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(int) })]
        int? Code { get;  }
        /// <summary>Internal error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Internal error details.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IErrorDefinition) })]
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IErrorDefinition[] Detail { get;  }
        /// <summary>Description of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Description of the error.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }

    }
    /// Error definition.
    internal partial interface IErrorDefinitionInternal

    {
        /// <summary>
        /// Service specific error code which serves as the substatus for the HTTP error code.
        /// </summary>
        int? Code { get; set; }
        /// <summary>Internal error details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IErrorDefinition[] Detail { get; set; }
        /// <summary>Description of the error.</summary>
        string Message { get; set; }

    }
}