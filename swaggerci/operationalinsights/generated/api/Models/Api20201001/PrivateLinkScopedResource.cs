namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>The private link scope resource reference.</summary>
    public partial class PrivateLinkScopedResource :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IPrivateLinkScopedResource,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IPrivateLinkScopedResourceInternal
    {

        /// <summary>Backing field for <see cref="ResourceId" /> property.</summary>
        private string _resourceId;

        /// <summary>The full resource Id of the private link scope resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string ResourceId { get => this._resourceId; set => this._resourceId = value; }

        /// <summary>Backing field for <see cref="ScopeId" /> property.</summary>
        private string _scopeId;

        /// <summary>The private link scope unique Identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string ScopeId { get => this._scopeId; set => this._scopeId = value; }

        /// <summary>Creates an new <see cref="PrivateLinkScopedResource" /> instance.</summary>
        public PrivateLinkScopedResource()
        {

        }
    }
    /// The private link scope resource reference.
    public partial interface IPrivateLinkScopedResource :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>The full resource Id of the private link scope resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The full resource Id of the private link scope resource.",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceId { get; set; }
        /// <summary>The private link scope unique Identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The private link scope unique Identifier.",
        SerializedName = @"scopeId",
        PossibleTypes = new [] { typeof(string) })]
        string ScopeId { get; set; }

    }
    /// The private link scope resource reference.
    internal partial interface IPrivateLinkScopedResourceInternal

    {
        /// <summary>The full resource Id of the private link scope resource.</summary>
        string ResourceId { get; set; }
        /// <summary>The private link scope unique Identifier.</summary>
        string ScopeId { get; set; }

    }
}