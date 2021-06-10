namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Extensions;

    public partial class PrivateLinkScopeValidationDetails :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateLinkScopeValidationDetails,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateLinkScopeValidationDetailsInternal
    {

        /// <summary>Backing field for <see cref="ConnectionDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IConnectionDetail[] _connectionDetail;

        /// <summary>List of Private Endpoint Connection details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IConnectionDetail[] ConnectionDetail { get => this._connectionDetail; set => this._connectionDetail = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Azure resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IPrivateLinkScopeValidationDetailsInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Backing field for <see cref="PublicNetworkAccess" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.PublicNetworkAccessType? _publicNetworkAccess;

        /// <summary>
        /// Indicates whether machines associated with the private link scope can also use public Azure Arc service endpoints.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.PublicNetworkAccessType? PublicNetworkAccess { get => this._publicNetworkAccess; set => this._publicNetworkAccess = value; }

        /// <summary>Creates an new <see cref="PrivateLinkScopeValidationDetails" /> instance.</summary>
        public PrivateLinkScopeValidationDetails()
        {

        }
    }
    public partial interface IPrivateLinkScopeValidationDetails :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IJsonSerializable
    {
        /// <summary>List of Private Endpoint Connection details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of Private Endpoint Connection details.",
        SerializedName = @"connectionDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IConnectionDetail) })]
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IConnectionDetail[] ConnectionDetail { get; set; }
        /// <summary>Azure resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Azure resource Id",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>
        /// Indicates whether machines associated with the private link scope can also use public Azure Arc service endpoints.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether machines associated with the private link scope can also use public Azure Arc service endpoints.",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.PublicNetworkAccessType) })]
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.PublicNetworkAccessType? PublicNetworkAccess { get; set; }

    }
    internal partial interface IPrivateLinkScopeValidationDetailsInternal

    {
        /// <summary>List of Private Endpoint Connection details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IConnectionDetail[] ConnectionDetail { get; set; }
        /// <summary>Azure resource Id</summary>
        string Id { get; set; }
        /// <summary>
        /// Indicates whether machines associated with the private link scope can also use public Azure Arc service endpoints.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.PublicNetworkAccessType? PublicNetworkAccess { get; set; }

    }
}