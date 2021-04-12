namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Extensions;

    /// <summary>Specifications of the Metrics for Azure Monitoring</summary>
    public partial class MetricSpecification :
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IMetricSpecification,
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IMetricSpecificationInternal
    {

        /// <summary>Backing field for <see cref="AggregationType" /> property.</summary>
        private string _aggregationType;

        /// <summary>
        /// Only provide one value for this field. Valid values: Average, Minimum, Maximum, Total, Count.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        public string AggregationType { get => this._aggregationType; set => this._aggregationType = value; }

        /// <summary>Backing field for <see cref="Dimension" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IMetricDimension[] _dimension;

        /// <summary>Dimensions of the metric</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IMetricDimension[] Dimension { get => this._dimension; set => this._dimension = value; }

        /// <summary>Backing field for <see cref="DisplayDescription" /> property.</summary>
        private string _displayDescription;

        /// <summary>Localized friendly description of the metric</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        public string DisplayDescription { get => this._displayDescription; set => this._displayDescription = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Localized friendly display name of the metric</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="InternalMetricName" /> property.</summary>
        private string _internalMetricName;

        /// <summary>Internal metric name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        public string InternalMetricName { get => this._internalMetricName; set => this._internalMetricName = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the metric</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Unit" /> property.</summary>
        private string _unit;

        /// <summary>Unit that makes sense for the metric</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        public string Unit { get => this._unit; set => this._unit = value; }

        /// <summary>Creates an new <see cref="MetricSpecification" /> instance.</summary>
        public MetricSpecification()
        {

        }
    }
    /// Specifications of the Metrics for Azure Monitoring
    public partial interface IMetricSpecification :
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Only provide one value for this field. Valid values: Average, Minimum, Maximum, Total, Count.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Only provide one value for this field. Valid values: Average, Minimum, Maximum, Total, Count.",
        SerializedName = @"aggregationType",
        PossibleTypes = new [] { typeof(string) })]
        string AggregationType { get; set; }
        /// <summary>Dimensions of the metric</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Dimensions of the metric",
        SerializedName = @"dimensions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IMetricDimension) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IMetricDimension[] Dimension { get; set; }
        /// <summary>Localized friendly description of the metric</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Localized friendly description of the metric",
        SerializedName = @"displayDescription",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayDescription { get; set; }
        /// <summary>Localized friendly display name of the metric</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Localized friendly display name of the metric",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>Internal metric name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Internal metric name.",
        SerializedName = @"internalMetricName",
        PossibleTypes = new [] { typeof(string) })]
        string InternalMetricName { get; set; }
        /// <summary>Name of the metric</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the metric",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Unit that makes sense for the metric</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Unit that makes sense for the metric",
        SerializedName = @"unit",
        PossibleTypes = new [] { typeof(string) })]
        string Unit { get; set; }

    }
    /// Specifications of the Metrics for Azure Monitoring
    internal partial interface IMetricSpecificationInternal

    {
        /// <summary>
        /// Only provide one value for this field. Valid values: Average, Minimum, Maximum, Total, Count.
        /// </summary>
        string AggregationType { get; set; }
        /// <summary>Dimensions of the metric</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IMetricDimension[] Dimension { get; set; }
        /// <summary>Localized friendly description of the metric</summary>
        string DisplayDescription { get; set; }
        /// <summary>Localized friendly display name of the metric</summary>
        string DisplayName { get; set; }
        /// <summary>Internal metric name.</summary>
        string InternalMetricName { get; set; }
        /// <summary>Name of the metric</summary>
        string Name { get; set; }
        /// <summary>Unit that makes sense for the metric</summary>
        string Unit { get; set; }

    }
}