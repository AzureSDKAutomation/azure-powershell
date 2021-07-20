namespace Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Extensions;

    /// <summary>Dimension of blobs, possibly be blob type or access tier.</summary>
    public partial class Dimension :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IDimension,
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IDimensionInternal
    {

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Display name of dimension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Display name of dimension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="Dimension" /> instance.</summary>
        public Dimension()
        {

        }
    }
    /// Dimension of blobs, possibly be blob type or access tier.
    public partial interface IDimension :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IJsonSerializable
    {
        /// <summary>Display name of dimension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of dimension.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>Display name of dimension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of dimension.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// Dimension of blobs, possibly be blob type or access tier.
    internal partial interface IDimensionInternal

    {
        /// <summary>Display name of dimension.</summary>
        string DisplayName { get; set; }
        /// <summary>Display name of dimension.</summary>
        string Name { get; set; }

    }
}