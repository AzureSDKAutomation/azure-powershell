namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Extensions;

    /// <summary>The definition of a configuration store operation.</summary>
    public partial class OperationDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IOperationDefinition,
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IOperationDefinitionInternal
    {

        /// <summary>Backing field for <see cref="Display" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IOperationDefinitionDisplay _display;

        /// <summary>The display information for the configuration store operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IOperationDefinitionDisplay Display { get => (this._display = this._display ?? new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.OperationDefinitionDisplay()); set => this._display = value; }

        /// <summary>The description for the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Inlined)]
        public string DisplayDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IOperationDefinitionDisplayInternal)Display).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IOperationDefinitionDisplayInternal)Display).Description = value ?? null; }

        /// <summary>The operation that users can perform.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Inlined)]
        public string DisplayOperation { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IOperationDefinitionDisplayInternal)Display).Operation; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IOperationDefinitionDisplayInternal)Display).Operation = value ?? null; }

        /// <summary>The resource provider name: Microsoft App Configuration."</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Inlined)]
        public string DisplayProvider { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IOperationDefinitionDisplayInternal)Display).Provider; }

        /// <summary>The resource on which the operation is performed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Inlined)]
        public string DisplayResource { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IOperationDefinitionDisplayInternal)Display).Resource; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IOperationDefinitionDisplayInternal)Display).Resource = value ?? null; }

        /// <summary>Backing field for <see cref="IsDataAction" /> property.</summary>
        private bool? _isDataAction;

        /// <summary>Indicates whether the operation is a data action</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        public bool? IsDataAction { get => this._isDataAction; set => this._isDataAction = value; }

        /// <summary>Internal Acessors for Display</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IOperationDefinitionDisplay Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IOperationDefinitionInternal.Display { get => (this._display = this._display ?? new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.OperationDefinitionDisplay()); set { {_display = value;} } }

        /// <summary>Internal Acessors for DisplayProvider</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IOperationDefinitionInternal.DisplayProvider { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IOperationDefinitionDisplayInternal)Display).Provider; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IOperationDefinitionDisplayInternal)Display).Provider = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IOperationProperties Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IOperationDefinitionInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.OperationProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ServiceSpecification</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IServiceSpecification Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IOperationDefinitionInternal.ServiceSpecification { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IOperationPropertiesInternal)Property).ServiceSpecification; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IOperationPropertiesInternal)Property).ServiceSpecification = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Operation name: {provider}/{resource}/{operation}.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Origin" /> property.</summary>
        private string _origin;

        /// <summary>Origin of the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        public string Origin { get => this._origin; set => this._origin = value; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IOperationProperties _property;

        /// <summary>Properties of the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IOperationProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.OperationProperties()); set => this._property = value; }

        /// <summary>Specifications of the Log for Azure Monitoring</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.ILogSpecification[] ServiceSpecificationLogSpecification { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IOperationPropertiesInternal)Property).ServiceSpecificationLogSpecification; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IOperationPropertiesInternal)Property).ServiceSpecificationLogSpecification = value ?? null /* arrayOf */; }

        /// <summary>Specifications of the Metrics for Azure Monitoring</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IMetricSpecification[] ServiceSpecificationMetricSpecification { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IOperationPropertiesInternal)Property).ServiceSpecificationMetricSpecification; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IOperationPropertiesInternal)Property).ServiceSpecificationMetricSpecification = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="OperationDefinition" /> instance.</summary>
        public OperationDefinition()
        {

        }
    }
    /// The definition of a configuration store operation.
    public partial interface IOperationDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IJsonSerializable
    {
        /// <summary>The description for the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The description for the operation.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayDescription { get; set; }
        /// <summary>The operation that users can perform.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The operation that users can perform.",
        SerializedName = @"operation",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayOperation { get; set; }
        /// <summary>The resource provider name: Microsoft App Configuration."</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resource provider name: Microsoft App Configuration.""",
        SerializedName = @"provider",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayProvider { get;  }
        /// <summary>The resource on which the operation is performed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource on which the operation is performed.",
        SerializedName = @"resource",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayResource { get; set; }
        /// <summary>Indicates whether the operation is a data action</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether the operation is a data action",
        SerializedName = @"isDataAction",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsDataAction { get; set; }
        /// <summary>Operation name: {provider}/{resource}/{operation}.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Operation name: {provider}/{resource}/{operation}.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Origin of the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Origin of the operation",
        SerializedName = @"origin",
        PossibleTypes = new [] { typeof(string) })]
        string Origin { get; set; }
        /// <summary>Specifications of the Log for Azure Monitoring</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifications of the Log for Azure Monitoring",
        SerializedName = @"logSpecifications",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.ILogSpecification) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.ILogSpecification[] ServiceSpecificationLogSpecification { get; set; }
        /// <summary>Specifications of the Metrics for Azure Monitoring</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifications of the Metrics for Azure Monitoring",
        SerializedName = @"metricSpecifications",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IMetricSpecification) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IMetricSpecification[] ServiceSpecificationMetricSpecification { get; set; }

    }
    /// The definition of a configuration store operation.
    internal partial interface IOperationDefinitionInternal

    {
        /// <summary>The display information for the configuration store operation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IOperationDefinitionDisplay Display { get; set; }
        /// <summary>The description for the operation.</summary>
        string DisplayDescription { get; set; }
        /// <summary>The operation that users can perform.</summary>
        string DisplayOperation { get; set; }
        /// <summary>The resource provider name: Microsoft App Configuration."</summary>
        string DisplayProvider { get; set; }
        /// <summary>The resource on which the operation is performed.</summary>
        string DisplayResource { get; set; }
        /// <summary>Indicates whether the operation is a data action</summary>
        bool? IsDataAction { get; set; }
        /// <summary>Operation name: {provider}/{resource}/{operation}.</summary>
        string Name { get; set; }
        /// <summary>Origin of the operation</summary>
        string Origin { get; set; }
        /// <summary>Properties of the operation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IOperationProperties Property { get; set; }
        /// <summary>Service specifications of the operation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IServiceSpecification ServiceSpecification { get; set; }
        /// <summary>Specifications of the Log for Azure Monitoring</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.ILogSpecification[] ServiceSpecificationLogSpecification { get; set; }
        /// <summary>Specifications of the Metrics for Azure Monitoring</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200701Preview.IMetricSpecification[] ServiceSpecificationMetricSpecification { get; set; }

    }
}