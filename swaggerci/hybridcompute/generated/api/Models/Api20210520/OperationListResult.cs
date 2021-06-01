namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Extensions;

    /// <summary>The List Compute Operation operation response.</summary>
    public partial class OperationListResult :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IOperationListResult,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IOperationListResultInternal
    {

        /// <summary>Internal Acessors for Value</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IOperationValue[] Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IOperationListResultInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IOperationValue[] _value;

        /// <summary>The list of compute operations</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IOperationValue[] Value { get => this._value; }

        /// <summary>Creates an new <see cref="OperationListResult" /> instance.</summary>
        public OperationListResult()
        {

        }
    }
    /// The List Compute Operation operation response.
    public partial interface IOperationListResult :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IJsonSerializable
    {
        /// <summary>The list of compute operations</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The list of compute operations",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IOperationValue) })]
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IOperationValue[] Value { get;  }

    }
    /// The List Compute Operation operation response.
    internal partial interface IOperationListResultInternal

    {
        /// <summary>The list of compute operations</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IOperationValue[] Value { get; set; }

    }
}