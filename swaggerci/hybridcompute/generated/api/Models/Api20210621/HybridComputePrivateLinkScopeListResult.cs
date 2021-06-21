namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Extensions;

    /// <summary>Describes the list of Azure Arc PrivateLinkScope resources.</summary>
    public partial class HybridComputePrivateLinkScopeListResult :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IHybridComputePrivateLinkScopeListResult,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IHybridComputePrivateLinkScopeListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>
        /// The URI to get the next set of Azure Arc PrivateLinkScope definitions if too many PrivateLinkScopes where returned in
        /// the result set.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IHybridComputePrivateLinkScope[] _value;

        /// <summary>List of Azure Arc PrivateLinkScope definitions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IHybridComputePrivateLinkScope[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="HybridComputePrivateLinkScopeListResult" /> instance.</summary>
        public HybridComputePrivateLinkScopeListResult()
        {

        }
    }
    /// Describes the list of Azure Arc PrivateLinkScope resources.
    public partial interface IHybridComputePrivateLinkScopeListResult :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The URI to get the next set of Azure Arc PrivateLinkScope definitions if too many PrivateLinkScopes where returned in
        /// the result set.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URI to get the next set of Azure Arc PrivateLinkScope definitions if too many PrivateLinkScopes where returned in the result set.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>List of Azure Arc PrivateLinkScope definitions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"List of Azure Arc PrivateLinkScope definitions.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IHybridComputePrivateLinkScope) })]
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IHybridComputePrivateLinkScope[] Value { get; set; }

    }
    /// Describes the list of Azure Arc PrivateLinkScope resources.
    internal partial interface IHybridComputePrivateLinkScopeListResultInternal

    {
        /// <summary>
        /// The URI to get the next set of Azure Arc PrivateLinkScope definitions if too many PrivateLinkScopes where returned in
        /// the result set.
        /// </summary>
        string NextLink { get; set; }
        /// <summary>List of Azure Arc PrivateLinkScope definitions.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IHybridComputePrivateLinkScope[] Value { get; set; }

    }
}