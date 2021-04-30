namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>The get schema operation response.</summary>
    public partial class SearchGetSchemaResponse :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchGetSchemaResponse,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchGetSchemaResponseInternal
    {

        /// <summary>Backing field for <see cref="Metadata" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadata _metadata;

        /// <summary>The metadata from search results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadata Metadata { get => (this._metadata = this._metadata ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.SearchMetadata()); set => this._metadata = value; }

        /// <summary>The aggregated grouping fields.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string MetadataAggregatedGroupingField { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).AggregatedGroupingField; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).AggregatedGroupingField = value ?? null; }

        /// <summary>The aggregated value field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string MetadataAggregatedValueField { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).AggregatedValueField; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).AggregatedValueField = value ?? null; }

        /// <summary>The core summaries.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ICoreSummary[] MetadataCoreSummary { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).CoreSummary; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).CoreSummary = value ?? null /* arrayOf */; }

        /// <summary>The ETag of the search results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string MetadataETag { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).ETag; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).ETag = value ?? null; }

        /// <summary>The id of the search results request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string MetadataId { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).Id = value ?? null; }

        /// <summary>The time of last update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public global::System.DateTime? MetadataLastUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).LastUpdated; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).LastUpdated = value ?? default(global::System.DateTime); }

        /// <summary>The max of all aggregates returned in the result set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public long? MetadataMax { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).Max; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).Max = value ?? default(long); }

        /// <summary>The request time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public long? MetadataRequestTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).RequestTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).RequestTime = value ?? default(long); }

        /// <summary>The search result type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string MetadataResultType { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).ResultType; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).ResultType = value ?? null; }

        /// <summary>The request id of the search.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string MetadataSearchId { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).SearchId; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).SearchId = value ?? null; }

        /// <summary>How the results are sorted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSort[] MetadataSort { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).Sort; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).Sort = value ?? null /* arrayOf */; }

        /// <summary>The start time for the search.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public global::System.DateTime? MetadataStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).StartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).StartTime = value ?? default(global::System.DateTime); }

        /// <summary>The status of the search results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string MetadataStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).Status = value ?? null; }

        /// <summary>The sum of all aggregates returned in the result set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public long? MetadataSum { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).Sum; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).Sum = value ?? default(long); }

        /// <summary>The number of top search results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public long? MetadataTop { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).Top; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).Top = value ?? default(long); }

        /// <summary>The total number of search results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public long? MetadataTotal { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).Total; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).Total = value ?? default(long); }

        /// <summary>Internal Acessors for Metadata</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadata Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchGetSchemaResponseInternal.Metadata { get => (this._metadata = this._metadata ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.SearchMetadata()); set { {_metadata = value;} } }

        /// <summary>Internal Acessors for MetadataSchema</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataSchema Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchGetSchemaResponseInternal.MetadataSchema { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).Schema; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).Schema = value; }

        /// <summary>The name of the metadata schema.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string SchemaName { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).SchemaName; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).SchemaName = value ?? null; }

        /// <summary>The version of the metadata schema.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public int? SchemaVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).SchemaVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal)Metadata).SchemaVersion = value ?? default(int); }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValue[] _value;

        /// <summary>The array of result values.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValue[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="SearchGetSchemaResponse" /> instance.</summary>
        public SearchGetSchemaResponse()
        {

        }
    }
    /// The get schema operation response.
    public partial interface ISearchGetSchemaResponse :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>The aggregated grouping fields.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The aggregated grouping fields.",
        SerializedName = @"aggregatedGroupingFields",
        PossibleTypes = new [] { typeof(string) })]
        string MetadataAggregatedGroupingField { get; set; }
        /// <summary>The aggregated value field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The aggregated value field.",
        SerializedName = @"aggregatedValueField",
        PossibleTypes = new [] { typeof(string) })]
        string MetadataAggregatedValueField { get; set; }
        /// <summary>The core summaries.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The core summaries.",
        SerializedName = @"coreSummaries",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ICoreSummary) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ICoreSummary[] MetadataCoreSummary { get; set; }
        /// <summary>The ETag of the search results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ETag of the search results.",
        SerializedName = @"eTag",
        PossibleTypes = new [] { typeof(string) })]
        string MetadataETag { get; set; }
        /// <summary>The id of the search results request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The id of the search results request.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string MetadataId { get; set; }
        /// <summary>The time of last update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The time of last update.",
        SerializedName = @"lastUpdated",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? MetadataLastUpdated { get; set; }
        /// <summary>The max of all aggregates returned in the result set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The max of all aggregates returned in the result set.",
        SerializedName = @"max",
        PossibleTypes = new [] { typeof(long) })]
        long? MetadataMax { get; set; }
        /// <summary>The request time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The request time.",
        SerializedName = @"requestTime",
        PossibleTypes = new [] { typeof(long) })]
        long? MetadataRequestTime { get; set; }
        /// <summary>The search result type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The search result type.",
        SerializedName = @"resultType",
        PossibleTypes = new [] { typeof(string) })]
        string MetadataResultType { get; set; }
        /// <summary>The request id of the search.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The request id of the search.",
        SerializedName = @"requestId",
        PossibleTypes = new [] { typeof(string) })]
        string MetadataSearchId { get; set; }
        /// <summary>How the results are sorted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"How the results are sorted.",
        SerializedName = @"sort",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSort) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSort[] MetadataSort { get; set; }
        /// <summary>The start time for the search.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The start time for the search.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? MetadataStartTime { get; set; }
        /// <summary>The status of the search results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The status of the search results.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string MetadataStatus { get; set; }
        /// <summary>The sum of all aggregates returned in the result set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The sum of all aggregates returned in the result set.",
        SerializedName = @"sum",
        PossibleTypes = new [] { typeof(long) })]
        long? MetadataSum { get; set; }
        /// <summary>The number of top search results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of top search results.",
        SerializedName = @"top",
        PossibleTypes = new [] { typeof(long) })]
        long? MetadataTop { get; set; }
        /// <summary>The total number of search results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The total number of search results.",
        SerializedName = @"total",
        PossibleTypes = new [] { typeof(long) })]
        long? MetadataTotal { get; set; }
        /// <summary>The name of the metadata schema.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the metadata schema.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string SchemaName { get; set; }
        /// <summary>The version of the metadata schema.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The version of the metadata schema.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(int) })]
        int? SchemaVersion { get; set; }
        /// <summary>The array of result values.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The array of result values.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValue) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValue[] Value { get; set; }

    }
    /// The get schema operation response.
    internal partial interface ISearchGetSchemaResponseInternal

    {
        /// <summary>The metadata from search results.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadata Metadata { get; set; }
        /// <summary>The aggregated grouping fields.</summary>
        string MetadataAggregatedGroupingField { get; set; }
        /// <summary>The aggregated value field.</summary>
        string MetadataAggregatedValueField { get; set; }
        /// <summary>The core summaries.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ICoreSummary[] MetadataCoreSummary { get; set; }
        /// <summary>The ETag of the search results.</summary>
        string MetadataETag { get; set; }
        /// <summary>The id of the search results request.</summary>
        string MetadataId { get; set; }
        /// <summary>The time of last update.</summary>
        global::System.DateTime? MetadataLastUpdated { get; set; }
        /// <summary>The max of all aggregates returned in the result set.</summary>
        long? MetadataMax { get; set; }
        /// <summary>The request time.</summary>
        long? MetadataRequestTime { get; set; }
        /// <summary>The search result type.</summary>
        string MetadataResultType { get; set; }
        /// <summary>The schema.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataSchema MetadataSchema { get; set; }
        /// <summary>The request id of the search.</summary>
        string MetadataSearchId { get; set; }
        /// <summary>How the results are sorted.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSort[] MetadataSort { get; set; }
        /// <summary>The start time for the search.</summary>
        global::System.DateTime? MetadataStartTime { get; set; }
        /// <summary>The status of the search results.</summary>
        string MetadataStatus { get; set; }
        /// <summary>The sum of all aggregates returned in the result set.</summary>
        long? MetadataSum { get; set; }
        /// <summary>The number of top search results.</summary>
        long? MetadataTop { get; set; }
        /// <summary>The total number of search results.</summary>
        long? MetadataTotal { get; set; }
        /// <summary>The name of the metadata schema.</summary>
        string SchemaName { get; set; }
        /// <summary>The version of the metadata schema.</summary>
        int? SchemaVersion { get; set; }
        /// <summary>The array of result values.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSchemaValue[] Value { get; set; }

    }
}