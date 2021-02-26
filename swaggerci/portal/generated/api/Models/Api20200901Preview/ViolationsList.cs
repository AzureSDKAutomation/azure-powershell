namespace Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Extensions;

    /// <summary>List of list of items that violate tenant's configuration.</summary>
    public partial class ViolationsList :
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IViolationsList,
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IViolationsListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The URL to use for getting the next set of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IViolation[] _value;

        /// <summary>The array of violations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IViolation[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ViolationsList" /> instance.</summary>
        public ViolationsList()
        {

        }
    }
    /// List of list of items that violate tenant's configuration.
    public partial interface IViolationsList :
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.IJsonSerializable
    {
        /// <summary>The URL to use for getting the next set of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URL to use for getting the next set of results.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The array of violations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The array of violations.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IViolation) })]
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IViolation[] Value { get; set; }

    }
    /// List of list of items that violate tenant's configuration.
    internal partial interface IViolationsListInternal

    {
        /// <summary>The URL to use for getting the next set of results.</summary>
        string NextLink { get; set; }
        /// <summary>The array of violations.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IViolation[] Value { get; set; }

    }
}