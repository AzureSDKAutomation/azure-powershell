namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>Metadata for search results.</summary>
    public partial class SearchMetadata :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadata,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal
    {

        /// <summary>Backing field for <see cref="AggregatedGroupingField" /> property.</summary>
        private string _aggregatedGroupingField;

        /// <summary>The aggregated grouping fields.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string AggregatedGroupingField { get => this._aggregatedGroupingField; set => this._aggregatedGroupingField = value; }

        /// <summary>Backing field for <see cref="AggregatedValueField" /> property.</summary>
        private string _aggregatedValueField;

        /// <summary>The aggregated value field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string AggregatedValueField { get => this._aggregatedValueField; set => this._aggregatedValueField = value; }

        /// <summary>Backing field for <see cref="CoreSummary" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ICoreSummary[] _coreSummary;

        /// <summary>The core summaries.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ICoreSummary[] CoreSummary { get => this._coreSummary; set => this._coreSummary = value; }

        /// <summary>Backing field for <see cref="ETag" /> property.</summary>
        private string _eTag;

        /// <summary>The ETag of the search results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string ETag { get => this._eTag; set => this._eTag = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The id of the search results request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="LastUpdated" /> property.</summary>
        private global::System.DateTime? _lastUpdated;

        /// <summary>The time of last update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public global::System.DateTime? LastUpdated { get => this._lastUpdated; set => this._lastUpdated = value; }

        /// <summary>Backing field for <see cref="Max" /> property.</summary>
        private long? _max;

        /// <summary>The max of all aggregates returned in the result set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public long? Max { get => this._max; set => this._max = value; }

        /// <summary>Internal Acessors for Schema</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataSchema Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataInternal.Schema { get => (this._schema = this._schema ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.SearchMetadataSchema()); set { {_schema = value;} } }

        /// <summary>Backing field for <see cref="RequestTime" /> property.</summary>
        private long? _requestTime;

        /// <summary>The request time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public long? RequestTime { get => this._requestTime; set => this._requestTime = value; }

        /// <summary>Backing field for <see cref="ResultType" /> property.</summary>
        private string _resultType;

        /// <summary>The search result type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string ResultType { get => this._resultType; set => this._resultType = value; }

        /// <summary>Backing field for <see cref="Schema" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataSchema _schema;

        /// <summary>The schema.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataSchema Schema { get => (this._schema = this._schema ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.SearchMetadataSchema()); set => this._schema = value; }

        /// <summary>The name of the metadata schema.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string SchemaName { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataSchemaInternal)Schema).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataSchemaInternal)Schema).Name = value ?? null; }

        /// <summary>The version of the metadata schema.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public int? SchemaVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataSchemaInternal)Schema).Version; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataSchemaInternal)Schema).Version = value ?? default(int); }

        /// <summary>Backing field for <see cref="SearchId" /> property.</summary>
        private string _searchId;

        /// <summary>The request id of the search.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string SearchId { get => this._searchId; set => this._searchId = value; }

        /// <summary>Backing field for <see cref="Sort" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSort[] _sort;

        /// <summary>How the results are sorted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSort[] Sort { get => this._sort; set => this._sort = value; }

        /// <summary>Backing field for <see cref="StartTime" /> property.</summary>
        private global::System.DateTime? _startTime;

        /// <summary>The start time for the search.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public global::System.DateTime? StartTime { get => this._startTime; set => this._startTime = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>The status of the search results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Backing field for <see cref="Sum" /> property.</summary>
        private long? _sum;

        /// <summary>The sum of all aggregates returned in the result set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public long? Sum { get => this._sum; set => this._sum = value; }

        /// <summary>Backing field for <see cref="Top" /> property.</summary>
        private long? _top;

        /// <summary>The number of top search results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public long? Top { get => this._top; set => this._top = value; }

        /// <summary>Backing field for <see cref="Total" /> property.</summary>
        private long? _total;

        /// <summary>The total number of search results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public long? Total { get => this._total; set => this._total = value; }

        /// <summary>Creates an new <see cref="SearchMetadata" /> instance.</summary>
        public SearchMetadata()
        {

        }
    }
    /// Metadata for search results.
    public partial interface ISearchMetadata :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>The aggregated grouping fields.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The aggregated grouping fields.",
        SerializedName = @"aggregatedGroupingFields",
        PossibleTypes = new [] { typeof(string) })]
        string AggregatedGroupingField { get; set; }
        /// <summary>The aggregated value field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The aggregated value field.",
        SerializedName = @"aggregatedValueField",
        PossibleTypes = new [] { typeof(string) })]
        string AggregatedValueField { get; set; }
        /// <summary>The core summaries.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The core summaries.",
        SerializedName = @"coreSummaries",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ICoreSummary) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ICoreSummary[] CoreSummary { get; set; }
        /// <summary>The ETag of the search results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ETag of the search results.",
        SerializedName = @"eTag",
        PossibleTypes = new [] { typeof(string) })]
        string ETag { get; set; }
        /// <summary>The id of the search results request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The id of the search results request.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The time of last update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The time of last update.",
        SerializedName = @"lastUpdated",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastUpdated { get; set; }
        /// <summary>The max of all aggregates returned in the result set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The max of all aggregates returned in the result set.",
        SerializedName = @"max",
        PossibleTypes = new [] { typeof(long) })]
        long? Max { get; set; }
        /// <summary>The request time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The request time.",
        SerializedName = @"requestTime",
        PossibleTypes = new [] { typeof(long) })]
        long? RequestTime { get; set; }
        /// <summary>The search result type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The search result type.",
        SerializedName = @"resultType",
        PossibleTypes = new [] { typeof(string) })]
        string ResultType { get; set; }
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
        /// <summary>The request id of the search.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The request id of the search.",
        SerializedName = @"requestId",
        PossibleTypes = new [] { typeof(string) })]
        string SearchId { get; set; }
        /// <summary>How the results are sorted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"How the results are sorted.",
        SerializedName = @"sort",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSort) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSort[] Sort { get; set; }
        /// <summary>The start time for the search.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The start time for the search.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartTime { get; set; }
        /// <summary>The status of the search results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The status of the search results.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get; set; }
        /// <summary>The sum of all aggregates returned in the result set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The sum of all aggregates returned in the result set.",
        SerializedName = @"sum",
        PossibleTypes = new [] { typeof(long) })]
        long? Sum { get; set; }
        /// <summary>The number of top search results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of top search results.",
        SerializedName = @"top",
        PossibleTypes = new [] { typeof(long) })]
        long? Top { get; set; }
        /// <summary>The total number of search results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The total number of search results.",
        SerializedName = @"total",
        PossibleTypes = new [] { typeof(long) })]
        long? Total { get; set; }

    }
    /// Metadata for search results.
    internal partial interface ISearchMetadataInternal

    {
        /// <summary>The aggregated grouping fields.</summary>
        string AggregatedGroupingField { get; set; }
        /// <summary>The aggregated value field.</summary>
        string AggregatedValueField { get; set; }
        /// <summary>The core summaries.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ICoreSummary[] CoreSummary { get; set; }
        /// <summary>The ETag of the search results.</summary>
        string ETag { get; set; }
        /// <summary>The id of the search results request.</summary>
        string Id { get; set; }
        /// <summary>The time of last update.</summary>
        global::System.DateTime? LastUpdated { get; set; }
        /// <summary>The max of all aggregates returned in the result set.</summary>
        long? Max { get; set; }
        /// <summary>The request time.</summary>
        long? RequestTime { get; set; }
        /// <summary>The search result type.</summary>
        string ResultType { get; set; }
        /// <summary>The schema.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchMetadataSchema Schema { get; set; }
        /// <summary>The name of the metadata schema.</summary>
        string SchemaName { get; set; }
        /// <summary>The version of the metadata schema.</summary>
        int? SchemaVersion { get; set; }
        /// <summary>The request id of the search.</summary>
        string SearchId { get; set; }
        /// <summary>How the results are sorted.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSort[] Sort { get; set; }
        /// <summary>The start time for the search.</summary>
        global::System.DateTime? StartTime { get; set; }
        /// <summary>The status of the search results.</summary>
        string Status { get; set; }
        /// <summary>The sum of all aggregates returned in the result set.</summary>
        long? Sum { get; set; }
        /// <summary>The number of top search results.</summary>
        long? Top { get; set; }
        /// <summary>The total number of search results.</summary>
        long? Total { get; set; }

    }
}