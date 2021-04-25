namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>Service Tier details.</summary>
    public partial class AvailableServiceTier :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTier,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal
    {

        /// <summary>Backing field for <see cref="CapacityReservationLevel" /> property.</summary>
        private long? _capacityReservationLevel;

        /// <summary>
        /// The capacity reservation level in GB per day. Returned for the Capacity Reservation Service Tier.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public long? CapacityReservationLevel { get => this._capacityReservationLevel; }

        /// <summary>Backing field for <see cref="DefaultRetention" /> property.</summary>
        private long? _defaultRetention;

        /// <summary>The default retention for the Service Tier, in days.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public long? DefaultRetention { get => this._defaultRetention; }

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>True if the Service Tier is enabled for the workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; }

        /// <summary>Backing field for <see cref="LastSkuUpdate" /> property.</summary>
        private string _lastSkuUpdate;

        /// <summary>
        /// Time when the sku was last updated for the workspace. Returned for the Capacity Reservation Service Tier.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string LastSkuUpdate { get => this._lastSkuUpdate; }

        /// <summary>Backing field for <see cref="MaximumRetention" /> property.</summary>
        private long? _maximumRetention;

        /// <summary>The maximum retention for the Service Tier, in days.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public long? MaximumRetention { get => this._maximumRetention; }

        /// <summary>Internal Acessors for CapacityReservationLevel</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal.CapacityReservationLevel { get => this._capacityReservationLevel; set { {_capacityReservationLevel = value;} } }

        /// <summary>Internal Acessors for DefaultRetention</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal.DefaultRetention { get => this._defaultRetention; set { {_defaultRetention = value;} } }

        /// <summary>Internal Acessors for Enabled</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal.Enabled { get => this._enabled; set { {_enabled = value;} } }

        /// <summary>Internal Acessors for LastSkuUpdate</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal.LastSkuUpdate { get => this._lastSkuUpdate; set { {_lastSkuUpdate = value;} } }

        /// <summary>Internal Acessors for MaximumRetention</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal.MaximumRetention { get => this._maximumRetention; set { {_maximumRetention = value;} } }

        /// <summary>Internal Acessors for MinimumRetention</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal.MinimumRetention { get => this._minimumRetention; set { {_minimumRetention = value;} } }

        /// <summary>Internal Acessors for ServiceTier</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.SkuNameEnum? Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTierInternal.ServiceTier { get => this._serviceTier; set { {_serviceTier = value;} } }

        /// <summary>Backing field for <see cref="MinimumRetention" /> property.</summary>
        private long? _minimumRetention;

        /// <summary>The minimum retention for the Service Tier, in days.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public long? MinimumRetention { get => this._minimumRetention; }

        /// <summary>Backing field for <see cref="ServiceTier" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.SkuNameEnum? _serviceTier;

        /// <summary>The name of the Service Tier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.SkuNameEnum? ServiceTier { get => this._serviceTier; }

        /// <summary>Creates an new <see cref="AvailableServiceTier" /> instance.</summary>
        public AvailableServiceTier()
        {

        }
    }
    /// Service Tier details.
    public partial interface IAvailableServiceTier :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The capacity reservation level in GB per day. Returned for the Capacity Reservation Service Tier.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The capacity reservation level in GB per day. Returned for the Capacity Reservation Service Tier.",
        SerializedName = @"capacityReservationLevel",
        PossibleTypes = new [] { typeof(long) })]
        long? CapacityReservationLevel { get;  }
        /// <summary>The default retention for the Service Tier, in days.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The default retention for the Service Tier, in days.",
        SerializedName = @"defaultRetention",
        PossibleTypes = new [] { typeof(long) })]
        long? DefaultRetention { get;  }
        /// <summary>True if the Service Tier is enabled for the workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"True if the Service Tier is enabled for the workspace.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get;  }
        /// <summary>
        /// Time when the sku was last updated for the workspace. Returned for the Capacity Reservation Service Tier.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Time when the sku was last updated for the workspace. Returned for the Capacity Reservation Service Tier.",
        SerializedName = @"lastSkuUpdate",
        PossibleTypes = new [] { typeof(string) })]
        string LastSkuUpdate { get;  }
        /// <summary>The maximum retention for the Service Tier, in days.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The maximum retention for the Service Tier, in days.",
        SerializedName = @"maximumRetention",
        PossibleTypes = new [] { typeof(long) })]
        long? MaximumRetention { get;  }
        /// <summary>The minimum retention for the Service Tier, in days.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The minimum retention for the Service Tier, in days.",
        SerializedName = @"minimumRetention",
        PossibleTypes = new [] { typeof(long) })]
        long? MinimumRetention { get;  }
        /// <summary>The name of the Service Tier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The name of the Service Tier.",
        SerializedName = @"serviceTier",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.SkuNameEnum) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.SkuNameEnum? ServiceTier { get;  }

    }
    /// Service Tier details.
    internal partial interface IAvailableServiceTierInternal

    {
        /// <summary>
        /// The capacity reservation level in GB per day. Returned for the Capacity Reservation Service Tier.
        /// </summary>
        long? CapacityReservationLevel { get; set; }
        /// <summary>The default retention for the Service Tier, in days.</summary>
        long? DefaultRetention { get; set; }
        /// <summary>True if the Service Tier is enabled for the workspace.</summary>
        bool? Enabled { get; set; }
        /// <summary>
        /// Time when the sku was last updated for the workspace. Returned for the Capacity Reservation Service Tier.
        /// </summary>
        string LastSkuUpdate { get; set; }
        /// <summary>The maximum retention for the Service Tier, in days.</summary>
        long? MaximumRetention { get; set; }
        /// <summary>The minimum retention for the Service Tier, in days.</summary>
        long? MinimumRetention { get; set; }
        /// <summary>The name of the Service Tier.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.SkuNameEnum? ServiceTier { get; set; }

    }
}