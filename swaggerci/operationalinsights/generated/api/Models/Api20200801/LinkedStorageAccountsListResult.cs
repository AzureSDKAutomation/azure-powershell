namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>The list linked storage accounts service operation response.</summary>
    public partial class LinkedStorageAccountsListResult :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedStorageAccountsListResult,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedStorageAccountsListResultInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedStorageAccountsResource[] _value;

        /// <summary>A list of linked storage accounts instances.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedStorageAccountsResource[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="LinkedStorageAccountsListResult" /> instance.</summary>
        public LinkedStorageAccountsListResult()
        {

        }
    }
    /// The list linked storage accounts service operation response.
    public partial interface ILinkedStorageAccountsListResult :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>A list of linked storage accounts instances.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A list of linked storage accounts instances.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedStorageAccountsResource) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedStorageAccountsResource[] Value { get; set; }

    }
    /// The list linked storage accounts service operation response.
    internal partial interface ILinkedStorageAccountsListResultInternal

    {
        /// <summary>A list of linked storage accounts instances.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedStorageAccountsResource[] Value { get; set; }

    }
}