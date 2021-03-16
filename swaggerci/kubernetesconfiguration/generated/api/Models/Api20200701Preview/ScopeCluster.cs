namespace Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Extensions;

    /// <summary>Specifies that the scope of the extensionInstance is Cluster</summary>
    public partial class ScopeCluster :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IScopeCluster,
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IScopeClusterInternal
    {

        /// <summary>Backing field for <see cref="ReleaseNamespace" /> property.</summary>
        private string _releaseNamespace;

        /// <summary>
        /// Namespace where the extension Release must be placed, for a Cluster scoped extensionInstance. If this namespace does not
        /// exist, it will be created
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public string ReleaseNamespace { get => this._releaseNamespace; set => this._releaseNamespace = value; }

        /// <summary>Creates an new <see cref="ScopeCluster" /> instance.</summary>
        public ScopeCluster()
        {

        }
    }
    /// Specifies that the scope of the extensionInstance is Cluster
    public partial interface IScopeCluster :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Namespace where the extension Release must be placed, for a Cluster scoped extensionInstance. If this namespace does not
        /// exist, it will be created
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Namespace where the extension Release must be placed, for a Cluster scoped extensionInstance.  If this namespace does not exist, it will be created",
        SerializedName = @"releaseNamespace",
        PossibleTypes = new [] { typeof(string) })]
        string ReleaseNamespace { get; set; }

    }
    /// Specifies that the scope of the extensionInstance is Cluster
    internal partial interface IScopeClusterInternal

    {
        /// <summary>
        /// Namespace where the extension Release must be placed, for a Cluster scoped extensionInstance. If this namespace does not
        /// exist, it will be created
        /// </summary>
        string ReleaseNamespace { get; set; }

    }
}