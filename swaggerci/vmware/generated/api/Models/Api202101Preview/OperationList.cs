namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>Pageable list of operations</summary>
    public partial class OperationList :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IOperationList,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IOperationListInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IOperationListInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Internal Acessors for Value</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IOperation[] Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IOperationListInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URL to get the next page if any</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IOperation[] _value;

        /// <summary>List of operations</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IOperation[] Value { get => this._value; }

        /// <summary>Creates an new <see cref="OperationList" /> instance.</summary>
        public OperationList()
        {

        }
    }
    /// Pageable list of operations
    public partial interface IOperationList :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable
    {
        /// <summary>URL to get the next page if any</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"URL to get the next page if any",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>List of operations</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of operations",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IOperation) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IOperation[] Value { get;  }

    }
    /// Pageable list of operations
    internal partial interface IOperationListInternal

    {
        /// <summary>URL to get the next page if any</summary>
        string NextLink { get; set; }
        /// <summary>List of operations</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IOperation[] Value { get; set; }

    }
}