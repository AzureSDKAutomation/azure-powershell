namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Extensions;

    /// <summary>The error object.</summary>
    public partial class ErrorDetailsError :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IErrorDetailsError,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IErrorDetailsErrorInternal
    {

        /// <summary>Backing field for <see cref="Code" /> property.</summary>
        private string _code;

        /// <summary>One of a server-defined set of error codes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.PropertyOrigin.Owned)]
        public string Code { get => this._code; set => this._code = value; }

        /// <summary>Backing field for <see cref="Detail" /> property.</summary>
        private string _detail;

        /// <summary>A human-readable representation of the error's details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.PropertyOrigin.Owned)]
        public string Detail { get => this._detail; set => this._detail = value; }

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>A human-readable representation of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>Backing field for <see cref="Target" /> property.</summary>
        private string _target;

        /// <summary>The target of the particular error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.PropertyOrigin.Owned)]
        public string Target { get => this._target; set => this._target = value; }

        /// <summary>Creates an new <see cref="ErrorDetailsError" /> instance.</summary>
        public ErrorDetailsError()
        {

        }
    }
    /// The error object.
    public partial interface IErrorDetailsError :
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
    /// The error object.
    internal partial interface IErrorDetailsErrorInternal

    {
        /// <summary>One of a server-defined set of error codes.</summary>
        string Code { get; set; }
        /// <summary>A human-readable representation of the error's details.</summary>
        string Detail { get; set; }
        /// <summary>A human-readable representation of the error.</summary>
        string Message { get; set; }
        /// <summary>The target of the particular error.</summary>
        string Target { get; set; }

    }
}