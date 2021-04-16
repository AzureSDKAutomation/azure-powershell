namespace Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Extensions;

    /// <summary>Specifies that the scope of the extensionInstance is Namespace</summary>
    public partial class ScopeNamespace :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScopeNamespace,
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IScopeNamespaceInternal
    {

        /// <summary>Backing field for <see cref="TargetNamespace" /> property.</summary>
        private string _targetNamespace;

        /// <summary>
        /// Namespace where the extensionInstance will be created for an Namespace scoped extensionInstance. If this namespace does
        /// not exist, it will be created
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public string TargetNamespace { get => this._targetNamespace; set => this._targetNamespace = value; }

        /// <summary>Creates an new <see cref="ScopeNamespace" /> instance.</summary>
        public ScopeNamespace()
        {

        }
    }
    /// Specifies that the scope of the extensionInstance is Namespace
    public partial interface IScopeNamespace :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.IJsonSerializable
    {
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
        string TargetNamespace { get; set; }

    }
    /// Specifies that the scope of the extensionInstance is Namespace
    internal partial interface IScopeNamespaceInternal

    {
        /// <summary>
        /// Namespace where the extensionInstance will be created for an Namespace scoped extensionInstance. If this namespace does
        /// not exist, it will be created
        /// </summary>
        string TargetNamespace { get; set; }

    }
}