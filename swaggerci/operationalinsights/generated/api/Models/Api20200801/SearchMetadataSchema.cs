namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>Schema metadata for search.</summary>
    public partial class SearchMetadataSchema :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataSchema,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataSchemaInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the metadata schema.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private int? _version;

        /// <summary>The version of the metadata schema.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public int? Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="SearchMetadataSchema" /> instance.</summary>
        public SearchMetadataSchema()
        {

        }
    }
    /// Schema metadata for search.
    public partial interface ISearchMetadataSchema :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>The name of the metadata schema.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the metadata schema.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The version of the metadata schema.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The version of the metadata schema.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(int) })]
        int? Version { get; set; }

    }
    /// Schema metadata for search.
    internal partial interface ISearchMetadataSchemaInternal

    {
        /// <summary>The name of the metadata schema.</summary>
        string Name { get; set; }
        /// <summary>The version of the metadata schema.</summary>
        int? Version { get; set; }

    }
}