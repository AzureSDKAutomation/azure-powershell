namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>A metric describing the usage of a resource.</summary>
    public partial class UsageMetric :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IUsageMetric,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IUsageMetricInternal
    {

        /// <summary>Backing field for <see cref="CurrentValue" /> property.</summary>
        private double? _currentValue;

        /// <summary>The current value of the metric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public double? CurrentValue { get => this._currentValue; set => this._currentValue = value; }

        /// <summary>Backing field for <see cref="Limit" /> property.</summary>
        private double? _limit;

        /// <summary>The quota limit for the metric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public double? Limit { get => this._limit; set => this._limit = value; }

        /// <summary>Internal Acessors for Name</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IMetricName Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IUsageMetricInternal.Name { get => (this._name = this._name ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.MetricName()); set { {_name = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IMetricName _name;

        /// <summary>The name of the metric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IMetricName Name { get => (this._name = this._name ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.MetricName()); set => this._name = value; }

        /// <summary>The localized name of the metric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string NameLocalizedValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IMetricNameInternal)Name).LocalizedValue; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IMetricNameInternal)Name).LocalizedValue = value ?? null; }

        /// <summary>The system name of the metric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string NameValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IMetricNameInternal)Name).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IMetricNameInternal)Name).Value = value ?? null; }

        /// <summary>Backing field for <see cref="NextResetTime" /> property.</summary>
        private global::System.DateTime? _nextResetTime;

        /// <summary>The time that the metric's value will reset.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public global::System.DateTime? NextResetTime { get => this._nextResetTime; set => this._nextResetTime = value; }

        /// <summary>Backing field for <see cref="QuotaPeriod" /> property.</summary>
        private string _quotaPeriod;

        /// <summary>The quota period that determines the length of time between value resets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string QuotaPeriod { get => this._quotaPeriod; set => this._quotaPeriod = value; }

        /// <summary>Backing field for <see cref="Unit" /> property.</summary>
        private string _unit;

        /// <summary>The units used for the metric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string Unit { get => this._unit; set => this._unit = value; }

        /// <summary>Creates an new <see cref="UsageMetric" /> instance.</summary>
        public UsageMetric()
        {

        }
    }
    /// A metric describing the usage of a resource.
    public partial interface IUsageMetric :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>The current value of the metric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The current value of the metric.",
        SerializedName = @"currentValue",
        PossibleTypes = new [] { typeof(double) })]
        double? CurrentValue { get; set; }
        /// <summary>The quota limit for the metric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The quota limit for the metric.",
        SerializedName = @"limit",
        PossibleTypes = new [] { typeof(double) })]
        double? Limit { get; set; }
        /// <summary>The localized name of the metric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The localized name of the metric.",
        SerializedName = @"localizedValue",
        PossibleTypes = new [] { typeof(string) })]
        string NameLocalizedValue { get; set; }
        /// <summary>The system name of the metric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The system name of the metric.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string NameValue { get; set; }
        /// <summary>The time that the metric's value will reset.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The time that the metric's value will reset.",
        SerializedName = @"nextResetTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? NextResetTime { get; set; }
        /// <summary>The quota period that determines the length of time between value resets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The quota period that determines the length of time between value resets.",
        SerializedName = @"quotaPeriod",
        PossibleTypes = new [] { typeof(string) })]
        string QuotaPeriod { get; set; }
        /// <summary>The units used for the metric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The units used for the metric.",
        SerializedName = @"unit",
        PossibleTypes = new [] { typeof(string) })]
        string Unit { get; set; }

    }
    /// A metric describing the usage of a resource.
    internal partial interface IUsageMetricInternal

    {
        /// <summary>The current value of the metric.</summary>
        double? CurrentValue { get; set; }
        /// <summary>The quota limit for the metric.</summary>
        double? Limit { get; set; }
        /// <summary>The name of the metric.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IMetricName Name { get; set; }
        /// <summary>The localized name of the metric.</summary>
        string NameLocalizedValue { get; set; }
        /// <summary>The system name of the metric.</summary>
        string NameValue { get; set; }
        /// <summary>The time that the metric's value will reset.</summary>
        global::System.DateTime? NextResetTime { get; set; }
        /// <summary>The quota period that determines the length of time between value resets.</summary>
        string QuotaPeriod { get; set; }
        /// <summary>The units used for the metric.</summary>
        string Unit { get; set; }

    }
}