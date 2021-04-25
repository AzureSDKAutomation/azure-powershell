namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>The name of a metric.</summary>
    public partial class MetricName :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IMetricName,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IMetricNameInternal
    {

        /// <summary>Backing field for <see cref="LocalizedValue" /> property.</summary>
        private string _localizedValue;

        /// <summary>The localized name of the metric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string LocalizedValue { get => this._localizedValue; set => this._localizedValue = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private string _value;

        /// <summary>The system name of the metric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="MetricName" /> instance.</summary>
        public MetricName()
        {

        }
    }
    /// The name of a metric.
    public partial interface IMetricName :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>The localized name of the metric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The localized name of the metric.",
        SerializedName = @"localizedValue",
        PossibleTypes = new [] { typeof(string) })]
        string LocalizedValue { get; set; }
        /// <summary>The system name of the metric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The system name of the metric.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string Value { get; set; }

    }
    /// The name of a metric.
    internal partial interface IMetricNameInternal

    {
        /// <summary>The localized name of the metric.</summary>
        string LocalizedValue { get; set; }
        /// <summary>The system name of the metric.</summary>
        string Value { get; set; }

    }
}