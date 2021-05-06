namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>The status of the storage insight.</summary>
    public partial class StorageInsightStatus :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightStatus,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightStatusInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Description of the state of the storage insight.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.StorageInsightState _state;

        /// <summary>The state of the storage insight connection to the workspace</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.StorageInsightState State { get => this._state; set => this._state = value; }

        /// <summary>Creates an new <see cref="StorageInsightStatus" /> instance.</summary>
        public StorageInsightStatus()
        {

        }
    }
    /// The status of the storage insight.
    public partial interface IStorageInsightStatus :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>Description of the state of the storage insight.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Description of the state of the storage insight.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>The state of the storage insight connection to the workspace</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The state of the storage insight connection to the workspace",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.StorageInsightState) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.StorageInsightState State { get; set; }

    }
    /// The status of the storage insight.
    internal partial interface IStorageInsightStatusInternal

    {
        /// <summary>Description of the state of the storage insight.</summary>
        string Description { get; set; }
        /// <summary>The state of the storage insight connection to the workspace</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.StorageInsightState State { get; set; }

    }
}