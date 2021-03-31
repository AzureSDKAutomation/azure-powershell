namespace Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200918
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Extensions;

    /// <summary>The result returned from a cluster check name availability request.</summary>
    public partial class ClusterCheckNameRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200918.IClusterCheckNameRequest,
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200918.IClusterCheckNameRequestInternal
    {

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200918.IClusterCheckNameRequestInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Cluster name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type= @"Microsoft.Kusto/clusters";

        /// <summary>The type of resource, Microsoft.Kusto/clusters.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="ClusterCheckNameRequest" /> instance.</summary>
        public ClusterCheckNameRequest()
        {

        }
    }
    /// The result returned from a cluster check name availability request.
    public partial interface IClusterCheckNameRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.IJsonSerializable
    {
        /// <summary>Cluster name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Cluster name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The type of resource, Microsoft.Kusto/clusters.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Description = @"The type of resource, Microsoft.Kusto/clusters.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// The result returned from a cluster check name availability request.
    internal partial interface IClusterCheckNameRequestInternal

    {
        /// <summary>Cluster name.</summary>
        string Name { get; set; }
        /// <summary>The type of resource, Microsoft.Kusto/clusters.</summary>
        string Type { get; set; }

    }
}