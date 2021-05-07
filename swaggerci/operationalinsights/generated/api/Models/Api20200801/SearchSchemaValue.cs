namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>Value object for schema results.</summary>
    public partial class SearchSchemaValue :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValue,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValueInternal
    {

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>The display name of the schema.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="Facet" /> property.</summary>
        private bool _facet;

        /// <summary>The boolean that indicates whether or not the field is a facet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public bool Facet { get => this._facet; set => this._facet = value; }

        /// <summary>Backing field for <see cref="Indexed" /> property.</summary>
        private bool _indexed;

        /// <summary>The boolean that indicates the field is searchable as free text.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public bool Indexed { get => this._indexed; set => this._indexed = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the schema.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="OwnerType" /> property.</summary>
        private string[] _ownerType;

        /// <summary>The array of workflows containing the field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string[] OwnerType { get => this._ownerType; set => this._ownerType = value; }

        /// <summary>Backing field for <see cref="Stored" /> property.</summary>
        private bool _stored;

        /// <summary>The boolean that indicates whether or not the field is stored.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public bool Stored { get => this._stored; set => this._stored = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="SearchSchemaValue" /> instance.</summary>
        public SearchSchemaValue()
        {

        }
    }
    /// Value object for schema results.
    public partial interface ISearchSchemaValue :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>The display name of the schema.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The display name of the schema.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>The boolean that indicates whether or not the field is a facet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The boolean that indicates whether or not the field is a facet.",
        SerializedName = @"facet",
        PossibleTypes = new [] { typeof(bool) })]
        bool Facet { get; set; }
        /// <summary>The boolean that indicates the field is searchable as free text.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The boolean that indicates the field is searchable as free text.",
        SerializedName = @"indexed",
        PossibleTypes = new [] { typeof(bool) })]
        bool Indexed { get; set; }
        /// <summary>The name of the schema.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the schema.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The array of workflows containing the field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The array of workflows containing the field.",
        SerializedName = @"ownerType",
        PossibleTypes = new [] { typeof(string) })]
        string[] OwnerType { get; set; }
        /// <summary>The boolean that indicates whether or not the field is stored.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The boolean that indicates whether or not the field is stored.",
        SerializedName = @"stored",
        PossibleTypes = new [] { typeof(bool) })]
        bool Stored { get; set; }
        /// <summary>The type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// Value object for schema results.
    internal partial interface ISearchSchemaValueInternal

    {
        /// <summary>The display name of the schema.</summary>
        string DisplayName { get; set; }
        /// <summary>The boolean that indicates whether or not the field is a facet.</summary>
        bool Facet { get; set; }
        /// <summary>The boolean that indicates the field is searchable as free text.</summary>
        bool Indexed { get; set; }
        /// <summary>The name of the schema.</summary>
        string Name { get; set; }
        /// <summary>The array of workflows containing the field.</summary>
        string[] OwnerType { get; set; }
        /// <summary>The boolean that indicates whether or not the field is stored.</summary>
        bool Stored { get; set; }
        /// <summary>The type.</summary>
        string Type { get; set; }

    }
}