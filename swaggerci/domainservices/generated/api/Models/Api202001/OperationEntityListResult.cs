namespace Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Extensions;

    /// <summary>The list of domain service operation response.</summary>
    public partial class OperationEntityListResult :
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOperationEntityListResult,
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOperationEntityListResultInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOperationEntityListResultInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The continuation token for the next page of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOperationEntity[] _value;

        /// <summary>The list of operations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOperationEntity[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="OperationEntityListResult" /> instance.</summary>
        public OperationEntityListResult()
        {

        }
    }
    /// The list of domain service operation response.
    public partial interface IOperationEntityListResult :
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
        /// <summary>The list of operations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of operations.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOperationEntity) })]
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOperationEntity[] Value { get; set; }

    }
    /// The list of domain service operation response.
    internal partial interface IOperationEntityListResultInternal

    {
        /// <summary>The continuation token for the next page of results.</summary>
        string NextLink { get; set; }
        /// <summary>The list of operations.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOperationEntity[] Value { get; set; }

    }
}