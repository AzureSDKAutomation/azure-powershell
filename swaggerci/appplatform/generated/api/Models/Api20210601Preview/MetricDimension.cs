namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Specifications of the Dimension of metrics</summary>
    public partial class MetricDimension :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMetricDimension,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IMetricDimensionInternal
    {

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Localized friendly display name of the dimension</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the dimension</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="ToBeExportedForShoebox" /> property.</summary>
        private bool? _toBeExportedForShoebox;

        /// <summary>Whether this dimension should be included for the Shoebox export scenario</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public bool? ToBeExportedForShoebox { get => this._toBeExportedForShoebox; set => this._toBeExportedForShoebox = value; }

        /// <summary>Creates an new <see cref="MetricDimension" /> instance.</summary>
        public MetricDimension()
        {

        }
    }
    /// Specifications of the Dimension of metrics
    public partial interface IMetricDimension :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable
    {
        /// <summary>Localized friendly display name of the dimension</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Localized friendly display name of the dimension",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>Name of the dimension</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the dimension",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Whether this dimension should be included for the Shoebox export scenario</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether this dimension should be included for the Shoebox export scenario",
        SerializedName = @"toBeExportedForShoebox",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ToBeExportedForShoebox { get; set; }

    }
    /// Specifications of the Dimension of metrics
    internal partial interface IMetricDimensionInternal

    {
        /// <summary>Localized friendly display name of the dimension</summary>
        string DisplayName { get; set; }
        /// <summary>Name of the dimension</summary>
        string Name { get; set; }
        /// <summary>Whether this dimension should be included for the Shoebox export scenario</summary>
        bool? ToBeExportedForShoebox { get; set; }

    }
}