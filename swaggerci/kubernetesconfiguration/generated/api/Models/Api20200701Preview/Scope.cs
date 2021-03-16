namespace Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Extensions;

    /// <summary>
    /// Scope of the extensionInstance. It can be either Cluster or Namespace; but not both.
    /// </summary>
    public partial class Scope :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IScope,
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IScopeInternal
    {

        /// <summary>Backing field for <see cref="Cluster" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IScopeCluster _cluster;

        /// <summary>Specifies that the scope of the extensionInstance is Cluster</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IScopeCluster Cluster { get => (this._cluster = this._cluster ?? new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.ScopeCluster()); set => this._cluster = value; }

        /// <summary>
        /// Namespace where the extension Release must be placed, for a Cluster scoped extensionInstance. If this namespace does not
        /// exist, it will be created
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public string ClusterReleaseNamespace { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IScopeClusterInternal)Cluster).ReleaseNamespace; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IScopeClusterInternal)Cluster).ReleaseNamespace = value ?? null; }

        /// <summary>Internal Acessors for Cluster</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IScopeCluster Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IScopeInternal.Cluster { get => (this._cluster = this._cluster ?? new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.ScopeCluster()); set { {_cluster = value;} } }

        /// <summary>Internal Acessors for Namespace</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IScopeNamespace Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IScopeInternal.Namespace { get => (this._namespace = this._namespace ?? new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.ScopeNamespace()); set { {_namespace = value;} } }

        /// <summary>Backing field for <see cref="Namespace" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IScopeNamespace _namespace;

        /// <summary>Specifies that the scope of the extensionInstance is Namespace</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IScopeNamespace Namespace { get => (this._namespace = this._namespace ?? new Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.ScopeNamespace()); set => this._namespace = value; }

        /// <summary>
        /// Namespace where the extensionInstance will be created for an Namespace scoped extensionInstance. If this namespace does
        /// not exist, it will be created
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Inlined)]
        public string NamespaceTargetNamespace { get => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IScopeNamespaceInternal)Namespace).TargetNamespace; set => ((Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IScopeNamespaceInternal)Namespace).TargetNamespace = value ?? null; }

        /// <summary>Creates an new <see cref="Scope" /> instance.</summary>
        public Scope()
        {

        }
    }
    /// Scope of the extensionInstance. It can be either Cluster or Namespace; but not both.
    public partial interface IScope :
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
        string ClusterReleaseNamespace { get; set; }
        /// <summary>
        /// Namespace where the extensionInstance will be created for an Namespace scoped extensionInstance. If this namespace does
        /// not exist, it will be created
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Namespace where the extensionInstance will be created for an Namespace scoped extensionInstance.  If this namespace does not exist, it will be created",
        SerializedName = @"targetNamespace",
        PossibleTypes = new [] { typeof(string) })]
        string NamespaceTargetNamespace { get; set; }

    }
    /// Scope of the extensionInstance. It can be either Cluster or Namespace; but not both.
    internal partial interface IScopeInternal

    {
        /// <summary>Specifies that the scope of the extensionInstance is Cluster</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IScopeCluster Cluster { get; set; }
        /// <summary>
        /// Namespace where the extension Release must be placed, for a Cluster scoped extensionInstance. If this namespace does not
        /// exist, it will be created
        /// </summary>
        string ClusterReleaseNamespace { get; set; }
        /// <summary>Specifies that the scope of the extensionInstance is Namespace</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IScopeNamespace Namespace { get; set; }
        /// <summary>
        /// Namespace where the extensionInstance will be created for an Namespace scoped extensionInstance. If this namespace does
        /// not exist, it will be created
        /// </summary>
        string NamespaceTargetNamespace { get; set; }

    }
}