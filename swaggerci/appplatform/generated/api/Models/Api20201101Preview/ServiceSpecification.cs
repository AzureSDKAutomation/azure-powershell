namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Service specification payload</summary>
    public partial class ServiceSpecification :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceSpecification,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IServiceSpecificationInternal
    {

        /// <summary>Backing field for <see cref="LogSpecification" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ILogSpecification[] _logSpecification;

        /// <summary>Specifications of the Log for Azure Monitoring</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ILogSpecification[] LogSpecification { get => this._logSpecification; set => this._logSpecification = value; }

        /// <summary>Backing field for <see cref="MetricSpecification" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMetricSpecification[] _metricSpecification;

        /// <summary>Specifications of the Metrics for Azure Monitoring</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMetricSpecification[] MetricSpecification { get => this._metricSpecification; set => this._metricSpecification = value; }

        /// <summary>Creates an new <see cref="ServiceSpecification" /> instance.</summary>
        public ServiceSpecification()
        {

        }
    }
    /// Service specification payload
    public partial interface IServiceSpecification :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable
    {
        /// <summary>Specifications of the Log for Azure Monitoring</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifications of the Log for Azure Monitoring",
        SerializedName = @"logSpecifications",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ILogSpecification) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ILogSpecification[] LogSpecification { get; set; }
        /// <summary>Specifications of the Metrics for Azure Monitoring</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifications of the Metrics for Azure Monitoring",
        SerializedName = @"metricSpecifications",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMetricSpecification) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMetricSpecification[] MetricSpecification { get; set; }

    }
    /// Service specification payload
    internal partial interface IServiceSpecificationInternal

    {
        /// <summary>Specifications of the Log for Azure Monitoring</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.ILogSpecification[] LogSpecification { get; set; }
        /// <summary>Specifications of the Metrics for Azure Monitoring</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IMetricSpecification[] MetricSpecification { get; set; }

    }
}