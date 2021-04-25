namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>The list storage insights operation response.</summary>
    public partial class StorageInsightListResult :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightListResult,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightListResultInternal
    {

        /// <summary>Backing field for <see cref="OdataNextLink" /> property.</summary>
        private string _odataNextLink;

        /// <summary>The link (url) to the next page of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string OdataNextLink { get => this._odataNextLink; set => this._odataNextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsight[] _value;

        /// <summary>A list of storage insight items.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsight[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="StorageInsightListResult" /> instance.</summary>
        public StorageInsightListResult()
        {

        }
    }
    /// The list storage insights operation response.
    public partial interface IStorageInsightListResult :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>The link (url) to the next page of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The link (url) to the next page of results.",
        SerializedName = @"@odata.nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string OdataNextLink { get; set; }
        /// <summary>A list of storage insight items.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A list of storage insight items.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsight) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsight[] Value { get; set; }

    }
    /// The list storage insights operation response.
    internal partial interface IStorageInsightListResultInternal

    {
        /// <summary>The link (url) to the next page of results.</summary>
        string OdataNextLink { get; set; }
        /// <summary>A list of storage insight items.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsight[] Value { get; set; }

    }
}