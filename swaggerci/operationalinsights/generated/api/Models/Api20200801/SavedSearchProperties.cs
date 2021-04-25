namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>Value object for saved search results.</summary>
    public partial class SavedSearchProperties :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchProperties,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearchPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Category" /> property.</summary>
        private string _category;

        /// <summary>
        /// The category of the saved search. This helps the user to find a saved search faster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string Category { get => this._category; set => this._category = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Saved search display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="FunctionAlias" /> property.</summary>
        private string _functionAlias;

        /// <summary>The function alias if query serves as a function.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string FunctionAlias { get => this._functionAlias; set => this._functionAlias = value; }

        /// <summary>Backing field for <see cref="FunctionParameter" /> property.</summary>
        private string _functionParameter;

        /// <summary>
        /// The optional function parameters if query serves as a function. Value should be in the following format: 'param-name1:type1
        /// = default_value1, param-name2:type2 = default_value2'. For more examples and proper syntax please refer to https://docs.microsoft.com/en-us/azure/kusto/query/functions/user-defined-functions.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string FunctionParameter { get => this._functionParameter; set => this._functionParameter = value; }

        /// <summary>Backing field for <see cref="Query" /> property.</summary>
        private string _query;

        /// <summary>The query expression for the saved search.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string Query { get => this._query; set => this._query = value; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ITag[] _tag;

        /// <summary>The tags attached to the saved search.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ITag[] Tag { get => this._tag; set => this._tag = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private long? _version;

        /// <summary>
        /// The version number of the query language. The current version is 2 and is the default.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public long? Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="SavedSearchProperties" /> instance.</summary>
        public SavedSearchProperties()
        {

        }
    }
    /// Value object for saved search results.
    public partial interface ISavedSearchProperties :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The category of the saved search. This helps the user to find a saved search faster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The category of the saved search. This helps the user to find a saved search faster. ",
        SerializedName = @"category",
        PossibleTypes = new [] { typeof(string) })]
        string Category { get; set; }
        /// <summary>Saved search display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Saved search display name.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>The function alias if query serves as a function.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The function alias if query serves as a function.",
        SerializedName = @"functionAlias",
        PossibleTypes = new [] { typeof(string) })]
        string FunctionAlias { get; set; }
        /// <summary>
        /// The optional function parameters if query serves as a function. Value should be in the following format: 'param-name1:type1
        /// = default_value1, param-name2:type2 = default_value2'. For more examples and proper syntax please refer to https://docs.microsoft.com/en-us/azure/kusto/query/functions/user-defined-functions.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The optional function parameters if query serves as a function. Value should be in the following format: 'param-name1:type1 = default_value1, param-name2:type2 = default_value2'. For more examples and proper syntax please refer to https://docs.microsoft.com/en-us/azure/kusto/query/functions/user-defined-functions.",
        SerializedName = @"functionParameters",
        PossibleTypes = new [] { typeof(string) })]
        string FunctionParameter { get; set; }
        /// <summary>The query expression for the saved search.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The query expression for the saved search.",
        SerializedName = @"query",
        PossibleTypes = new [] { typeof(string) })]
        string Query { get; set; }
        /// <summary>The tags attached to the saved search.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tags attached to the saved search.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ITag) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ITag[] Tag { get; set; }
        /// <summary>
        /// The version number of the query language. The current version is 2 and is the default.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The version number of the query language. The current version is 2 and is the default.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(long) })]
        long? Version { get; set; }

    }
    /// Value object for saved search results.
    internal partial interface ISavedSearchPropertiesInternal

    {
        /// <summary>
        /// The category of the saved search. This helps the user to find a saved search faster.
        /// </summary>
        string Category { get; set; }
        /// <summary>Saved search display name.</summary>
        string DisplayName { get; set; }
        /// <summary>The function alias if query serves as a function.</summary>
        string FunctionAlias { get; set; }
        /// <summary>
        /// The optional function parameters if query serves as a function. Value should be in the following format: 'param-name1:type1
        /// = default_value1, param-name2:type2 = default_value2'. For more examples and proper syntax please refer to https://docs.microsoft.com/en-us/azure/kusto/query/functions/user-defined-functions.
        /// </summary>
        string FunctionParameter { get; set; }
        /// <summary>The query expression for the saved search.</summary>
        string Query { get; set; }
        /// <summary>The tags attached to the saved search.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ITag[] Tag { get; set; }
        /// <summary>
        /// The version number of the query language. The current version is 2 and is the default.
        /// </summary>
        long? Version { get; set; }

    }
}