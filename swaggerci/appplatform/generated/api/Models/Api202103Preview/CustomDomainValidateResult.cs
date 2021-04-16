namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Validation result for custom domain.</summary>
    public partial class CustomDomainValidateResult :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ICustomDomainValidateResult,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ICustomDomainValidateResultInternal
    {

        /// <summary>Backing field for <see cref="IsValid" /> property.</summary>
        private bool? _isValid;

        /// <summary>Indicates if domain name is valid.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public bool? IsValid { get => this._isValid; set => this._isValid = value; }

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>Message of why domain name is invalid.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>Creates an new <see cref="CustomDomainValidateResult" /> instance.</summary>
        public CustomDomainValidateResult()
        {

        }
    }
    /// Validation result for custom domain.
    public partial interface ICustomDomainValidateResult :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable
    {
        /// <summary>Indicates if domain name is valid.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates if domain name is valid.",
        SerializedName = @"isValid",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsValid { get; set; }
        /// <summary>Message of why domain name is invalid.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Message of why domain name is invalid.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }

    }
    /// Validation result for custom domain.
    internal partial interface ICustomDomainValidateResultInternal

    {
        /// <summary>Indicates if domain name is valid.</summary>
        bool? IsValid { get; set; }
        /// <summary>Message of why domain name is invalid.</summary>
        string Message { get; set; }

    }
}