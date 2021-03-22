namespace Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Extensions;

    /// <summary>The response from the List Domain Services operation.</summary>
    public partial class DomainServiceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IDomainServiceListResult,
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IDomainServiceListResultInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IDomainServiceListResultInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The continuation token for the next page of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IDomainService[] _value;

        /// <summary>the list of domain services.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IDomainService[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="DomainServiceListResult" /> instance.</summary>
        public DomainServiceListResult()
        {

        }
    }
    /// The response from the List Domain Services operation.
    public partial interface IDomainServiceListResult :
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
        /// <summary>the list of domain services.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the list of domain services.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IDomainService) })]
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IDomainService[] Value { get; set; }

    }
    /// The response from the List Domain Services operation.
    internal partial interface IDomainServiceListResultInternal

    {
        /// <summary>The continuation token for the next page of results.</summary>
        string NextLink { get; set; }
        /// <summary>the list of domain services.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IDomainService[] Value { get; set; }

    }
}