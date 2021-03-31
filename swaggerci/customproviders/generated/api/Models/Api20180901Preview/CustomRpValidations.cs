namespace Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Models.Api20180901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Runtime.Extensions;

    /// <summary>A validation to apply on custom resource provider requests.</summary>
    public partial class CustomRpValidations :
        Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Models.Api20180901Preview.ICustomRpValidations,
        Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Models.Api20180901Preview.ICustomRpValidationsInternal
    {

        /// <summary>Backing field for <see cref="Specification" /> property.</summary>
        private string _specification;

        /// <summary>
        /// A link to the validation specification. The specification must be hosted on raw.githubusercontent.com.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Origin(Microsoft.Azure.PowerShell.Cmdlets.Customproviders.PropertyOrigin.Owned)]
        public string Specification { get => this._specification; set => this._specification = value; }

        /// <summary>Backing field for <see cref="ValidationType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Support.ValidationType? _validationType;

        /// <summary>The type of validation to run against a matching request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Origin(Microsoft.Azure.PowerShell.Cmdlets.Customproviders.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Support.ValidationType? ValidationType { get => this._validationType; set => this._validationType = value; }

        /// <summary>Creates an new <see cref="CustomRpValidations" /> instance.</summary>
        public CustomRpValidations()
        {

        }
    }
    /// A validation to apply on custom resource provider requests.
    public partial interface ICustomRpValidations :
        Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Runtime.IJsonSerializable
    {
        /// <summary>
        /// A link to the validation specification. The specification must be hosted on raw.githubusercontent.com.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"A link to the validation specification. The specification must be hosted on raw.githubusercontent.com.",
        SerializedName = @"specification",
        PossibleTypes = new [] { typeof(string) })]
        string Specification { get; set; }
        /// <summary>The type of validation to run against a matching request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of validation to run against a matching request.",
        SerializedName = @"validationType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Support.ValidationType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Support.ValidationType? ValidationType { get; set; }

    }
    /// A validation to apply on custom resource provider requests.
    internal partial interface ICustomRpValidationsInternal

    {
        /// <summary>
        /// A link to the validation specification. The specification must be hosted on raw.githubusercontent.com.
        /// </summary>
        string Specification { get; set; }
        /// <summary>The type of validation to run against a matching request.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Customproviders.Support.ValidationType? ValidationType { get; set; }

    }
}