namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>The SKU (tier) of a workspace.</summary>
    public partial class WorkspaceSku :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceSku,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceSkuInternal
    {

        /// <summary>Backing field for <see cref="CapacityReservationLevel" /> property.</summary>
        private int? _capacityReservationLevel;

        /// <summary>
        /// The capacity reservation level for this workspace, when CapacityReservation sku is selected.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public int? CapacityReservationLevel { get => this._capacityReservationLevel; set => this._capacityReservationLevel = value; }

        /// <summary>Backing field for <see cref="LastSkuUpdate" /> property.</summary>
        private string _lastSkuUpdate;

        /// <summary>The last time when the sku was updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string LastSkuUpdate { get => this._lastSkuUpdate; }

        /// <summary>Internal Acessors for LastSkuUpdate</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceSkuInternal.LastSkuUpdate { get => this._lastSkuUpdate; set { {_lastSkuUpdate = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceSkuNameEnum _name;

        /// <summary>The name of the SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceSkuNameEnum Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="WorkspaceSku" /> instance.</summary>
        public WorkspaceSku()
        {

        }
    }
    /// The SKU (tier) of a workspace.
    public partial interface IWorkspaceSku :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The capacity reservation level for this workspace, when CapacityReservation sku is selected.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The capacity reservation level for this workspace, when CapacityReservation sku is selected.",
        SerializedName = @"capacityReservationLevel",
        PossibleTypes = new [] { typeof(int) })]
        int? CapacityReservationLevel { get; set; }
        /// <summary>The last time when the sku was updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The last time when the sku was updated.",
        SerializedName = @"lastSkuUpdate",
        PossibleTypes = new [] { typeof(string) })]
        string LastSkuUpdate { get;  }
        /// <summary>The name of the SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the SKU.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceSkuNameEnum) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceSkuNameEnum Name { get; set; }

    }
    /// The SKU (tier) of a workspace.
    internal partial interface IWorkspaceSkuInternal

    {
        /// <summary>
        /// The capacity reservation level for this workspace, when CapacityReservation sku is selected.
        /// </summary>
        int? CapacityReservationLevel { get; set; }
        /// <summary>The last time when the sku was updated.</summary>
        string LastSkuUpdate { get; set; }
        /// <summary>The name of the SKU.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceSkuNameEnum Name { get; set; }

    }
}