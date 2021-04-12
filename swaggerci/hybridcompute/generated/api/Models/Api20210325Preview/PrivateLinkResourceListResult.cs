namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Extensions;

    /// <summary>A list of private link resources</summary>
    public partial class PrivateLinkResourceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateLinkResourceListResult,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateLinkResourceListResultInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateLinkResourceListResultInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Internal Acessors for Value</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateLinkResource[] Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateLinkResourceListResultInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>Link to retrieve next page of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateLinkResource[] _value;

        /// <summary>Array of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateLinkResource[] Value { get => this._value; }

        /// <summary>Creates an new <see cref="PrivateLinkResourceListResult" /> instance.</summary>
        public PrivateLinkResourceListResult()
        {

        }
    }
    /// A list of private link resources
    public partial interface IPrivateLinkResourceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IJsonSerializable
    {
        /// <summary>Link to retrieve next page of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Link to retrieve next page of results.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>Array of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Array of results.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateLinkResource) })]
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateLinkResource[] Value { get;  }

    }
    /// A list of private link resources
    internal partial interface IPrivateLinkResourceListResultInternal

    {
        /// <summary>Link to retrieve next page of results.</summary>
        string NextLink { get; set; }
        /// <summary>Array of results.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateLinkResource[] Value { get; set; }

    }
}