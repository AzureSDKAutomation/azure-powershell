namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>Result of the request to list solution operations.</summary>
    public partial class OperationListResult :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IOperationListResult,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IOperationListResultInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IOperationListResultInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URL to get the next set of operation list results if there are any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IOperation[] _value;

        /// <summary>
        /// List of solution operations supported by the OperationsManagement resource provider.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IOperation[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="OperationListResult" /> instance.</summary>
        public OperationListResult()
        {

        }
    }
    /// Result of the request to list solution operations.
    public partial interface IOperationListResult :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>URL to get the next set of operation list results if there are any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"URL to get the next set of operation list results if there are any.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>
        /// List of solution operations supported by the OperationsManagement resource provider.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of solution operations supported by the OperationsManagement resource provider.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IOperation) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IOperation[] Value { get; set; }

    }
    /// Result of the request to list solution operations.
    internal partial interface IOperationListResultInternal

    {
        /// <summary>URL to get the next set of operation list results if there are any.</summary>
        string NextLink { get; set; }
        /// <summary>
        /// List of solution operations supported by the OperationsManagement resource provider.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IOperation[] Value { get; set; }

    }
}