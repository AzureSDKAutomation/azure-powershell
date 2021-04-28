namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>The sort parameters for search.</summary>
    public partial class SearchSort :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSort,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchSortInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the field the search query is sorted on.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Order" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.SearchSortEnum? _order;

        /// <summary>The sort order of the search.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.SearchSortEnum? Order { get => this._order; set => this._order = value; }

        /// <summary>Creates an new <see cref="SearchSort" /> instance.</summary>
        public SearchSort()
        {

        }
    }
    /// The sort parameters for search.
    public partial interface ISearchSort :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>The name of the field the search query is sorted on.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the field the search query is sorted on.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The sort order of the search.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The sort order of the search.",
        SerializedName = @"order",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.SearchSortEnum) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.SearchSortEnum? Order { get; set; }

    }
    /// The sort parameters for search.
    internal partial interface ISearchSortInternal

    {
        /// <summary>The name of the field the search query is sorted on.</summary>
        string Name { get; set; }
        /// <summary>The sort order of the search.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.SearchSortEnum? Order { get; set; }

    }
}