namespace Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Extensions;

    /// <summary>
    /// Result of the request to list Extension Instances. It contains a list of ExtensionInstance objects and a URL link to get
    /// the next set of results.
    /// </summary>
    public partial class ExtensionInstancesList :
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancesList,
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancesListInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancesListInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Internal Acessors for Value</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstance[] Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstancesListInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URL to get the next set of extension instance objects, if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstance[] _value;

        /// <summary>List of Extension Instances within a Kubernetes cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstance[] Value { get => this._value; }

        /// <summary>Creates an new <see cref="ExtensionInstancesList" /> instance.</summary>
        public ExtensionInstancesList()
        {

        }
    }
    /// Result of the request to list Extension Instances. It contains a list of ExtensionInstance objects and a URL link to get
    /// the next set of results.
    public partial interface IExtensionInstancesList :
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.IJsonSerializable
    {
        /// <summary>URL to get the next set of extension instance objects, if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"URL to get the next set of extension instance objects, if any.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>List of Extension Instances within a Kubernetes cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of Extension Instances within a Kubernetes cluster.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstance) })]
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstance[] Value { get;  }

    }
    /// Result of the request to list Extension Instances. It contains a list of ExtensionInstance objects and a URL link to get
    /// the next set of results.
    internal partial interface IExtensionInstancesListInternal

    {
        /// <summary>URL to get the next set of extension instance objects, if any.</summary>
        string NextLink { get; set; }
        /// <summary>List of Extension Instances within a Kubernetes cluster.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20200701Preview.IExtensionInstance[] Value { get; set; }

    }
}