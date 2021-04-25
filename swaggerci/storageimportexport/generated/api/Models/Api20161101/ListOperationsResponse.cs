namespace Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Extensions;

    /// <summary>List operations response</summary>
    public partial class ListOperationsResponse :
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IListOperationsResponse,
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IListOperationsResponseInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IOperation[] _value;

        /// <summary>operations</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IOperation[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ListOperationsResponse" /> instance.</summary>
        public ListOperationsResponse()
        {

        }
    }
    /// List operations response
    public partial interface IListOperationsResponse :
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.IJsonSerializable
    {
        /// <summary>operations</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"operations",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IOperation) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IOperation[] Value { get; set; }

    }
    /// List operations response
    internal partial interface IListOperationsResponseInternal

    {
        /// <summary>operations</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IOperation[] Value { get; set; }

    }
}