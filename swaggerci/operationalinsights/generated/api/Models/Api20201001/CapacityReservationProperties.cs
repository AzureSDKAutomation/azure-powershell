namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>The Capacity Reservation properties.</summary>
    public partial class CapacityReservationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ICapacityReservationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ICapacityReservationPropertiesInternal
    {

        /// <summary>Backing field for <see cref="LastSkuUpdate" /> property.</summary>
        private string _lastSkuUpdate;

        /// <summary>The last time Sku was updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string LastSkuUpdate { get => this._lastSkuUpdate; }

        /// <summary>Backing field for <see cref="MaxCapacity" /> property.</summary>
        private long? _maxCapacity;

        /// <summary>Maximum CapacityReservation value in GB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public long? MaxCapacity { get => this._maxCapacity; }

        /// <summary>Internal Acessors for LastSkuUpdate</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ICapacityReservationPropertiesInternal.LastSkuUpdate { get => this._lastSkuUpdate; set { {_lastSkuUpdate = value;} } }

        /// <summary>Internal Acessors for MaxCapacity</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ICapacityReservationPropertiesInternal.MaxCapacity { get => this._maxCapacity; set { {_maxCapacity = value;} } }

        /// <summary>Internal Acessors for MinCapacity</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ICapacityReservationPropertiesInternal.MinCapacity { get => this._minCapacity; set { {_minCapacity = value;} } }

        /// <summary>Backing field for <see cref="MinCapacity" /> property.</summary>
        private long? _minCapacity;

        /// <summary>Minimum CapacityReservation value in GB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public long? MinCapacity { get => this._minCapacity; }

        /// <summary>Creates an new <see cref="CapacityReservationProperties" /> instance.</summary>
        public CapacityReservationProperties()
        {

        }
    }
    /// The Capacity Reservation properties.
    public partial interface ICapacityReservationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>The last time Sku was updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The last time Sku was updated.",
        SerializedName = @"lastSkuUpdate",
        PossibleTypes = new [] { typeof(string) })]
        string LastSkuUpdate { get;  }
        /// <summary>Maximum CapacityReservation value in GB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Maximum CapacityReservation value in GB.",
        SerializedName = @"maxCapacity",
        PossibleTypes = new [] { typeof(long) })]
        long? MaxCapacity { get;  }
        /// <summary>Minimum CapacityReservation value in GB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Minimum CapacityReservation value in GB.",
        SerializedName = @"minCapacity",
        PossibleTypes = new [] { typeof(long) })]
        long? MinCapacity { get;  }

    }
    /// The Capacity Reservation properties.
    internal partial interface ICapacityReservationPropertiesInternal

    {
        /// <summary>The last time Sku was updated.</summary>
        string LastSkuUpdate { get; set; }
        /// <summary>Maximum CapacityReservation value in GB.</summary>
        long? MaxCapacity { get; set; }
        /// <summary>Minimum CapacityReservation value in GB.</summary>
        long? MinCapacity { get; set; }

    }
}