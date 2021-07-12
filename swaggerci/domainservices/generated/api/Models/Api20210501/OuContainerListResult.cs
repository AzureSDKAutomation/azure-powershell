namespace Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Extensions;

    /// <summary>The response from the List OuContainer operation.</summary>
    public partial class OuContainerListResult :
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerListResult,
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerListResultInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainerListResultInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The continuation token for the next page of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainer[] _value;

        /// <summary>The list of OuContainer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainer[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="OuContainerListResult" /> instance.</summary>
        public OuContainerListResult()
        {

        }
    }
    /// The response from the List OuContainer operation.
    public partial interface IOuContainerListResult :
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.IJsonSerializable
    {
        /// <summary>The continuation token for the next page of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The continuation token for the next page of results.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>The list of OuContainer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of OuContainer.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainer) })]
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainer[] Value { get; set; }

    }
    /// The response from the List OuContainer operation.
    internal partial interface IOuContainerListResultInternal

    {
        /// <summary>The continuation token for the next page of results.</summary>
        string NextLink { get; set; }
        /// <summary>The list of OuContainer.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IOuContainer[] Value { get; set; }

    }
}